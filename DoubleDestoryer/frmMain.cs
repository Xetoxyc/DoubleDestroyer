using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using WebSocketSharp;
using System.IO;
using System.Web.Script.Serialization;
using System.Threading;

namespace DoubleDestroyer
{
    public partial class frmMain : Form
    {
        private delegate void DelegateNoParam();
        private delegate void DelegateParamString(string status);

        private const string HOST_ADDRESS = "http://www.csgodouble.com/";
        private const string WS_HOST_ADDRESS = "ws://www.csgodouble.com:8080";

        private WebSocket moWebSocket;
        private JavaScriptSerializer moSerializer;
        private List<string> lMessages = new List<string>();
        private enStatus mStatus = enStatus.Disconnected;

        private List<int> lRolls = new List<int>();
        private List<string> lBids = new List<string>();
        
        private int mnMinBet = 0;
        private int mnMaxBet = 0;
        private int mnMaxBetRounds = 0;
        private int mnCurrentBetRound = 0;
        private int mnRollCountdown = 0;
        private int mnBalance = 0;
        private int mnWin = 0;
        private int mnLoss = 0;
        private int mnRoundID = 0;

        private int mnBidRed = 0;
        private int mnBidGreen = 0;
        private int mnBidBlack = 0;
        private int mnCurrentTotal = 0;
        private bool mbDisabled = false;
        private bool mbWonLast = true;

        public enum enStatus
        {
            Disconnected = 0,
            Connected = 1,
            Error = 2,
            Running = 3,
            Stopped = 4,
            Rolling = 5,
            Waiting = 6
        }
        
        public frmMain()
        {
            InitializeComponent();
            Connect();

            moSerializer = new JavaScriptSerializer();
            moSerializer.RegisterConverters(new[] { new DynamicJsonConverter() });
        }
        
        #region "EventHandler"
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (moWebSocket.IsAlive)
                mStatus = enStatus.Connected;
            
            UpdateForm();

            mStatus = enStatus.Rolling;
        }

        private void txtPlaceBetRed_Click(object sender, EventArgs e)
        {
            if (mnCurrentBetRound < mnMaxBetRounds)
            {
                int nBid;

                if (int.TryParse(txtBidRed.Text, out nBid) && nBid > 0)
                {
                    SendBet(GetSendJSON(nBid, 1, 7, mnRoundID));
                    btnPlaceBetRed.Enabled = false;
                    btnPlaceBetGreen.Enabled = false;
                    btnPlaceBetBlack.Enabled = false;
                    mbDisabled = true;
                }
            }
            else
            {
                MessageBox.Show("You can only bet " + mnMaxBetRounds + " times per round!");
            }
        }

        private void txtPlaceBetGreen_Click(object sender, EventArgs e)
        {
            if (mnCurrentBetRound < mnMaxBetRounds)
            {
                int nBid;

                if (int.TryParse(txtBidGreen.Text, out nBid) && nBid > 0)
                {
                    SendBet(GetSendJSON(nBid, 0, 0, mnRoundID));
                    btnPlaceBetRed.Enabled = false;
                    btnPlaceBetGreen.Enabled = false;
                    btnPlaceBetBlack.Enabled = false;
                    mbDisabled = true;
                }
            }
            else
            {
                MessageBox.Show("You can only bet " + mnMaxBetRounds + " times per round!");
            }
        }

        private void txtPlaceBetBlack_Click(object sender, EventArgs e)
        {
            if (mnCurrentBetRound < mnMaxBetRounds)
            {
                int nBid;

                if (int.TryParse(txtBidBlack.Text, out nBid) && nBid > 0)
                {
                    SendBet(GetSendJSON(nBid, 8, 14, mnRoundID));
                    btnPlaceBetRed.Enabled = false;
                    btnPlaceBetGreen.Enabled = false;
                    btnPlaceBetBlack.Enabled = false;
                    mbDisabled = true;
                }
            }
            else
            {
                MessageBox.Show("You can only bet " + mnMaxBetRounds + " times per round!");
            }
        }

        #endregion

        #region "Web-Service Handlers"
        private void OnClose(object sender, CloseEventArgs e)
        {
            mStatus = enStatus.Disconnected;
            UpdateForm();
        }
        
        private void OnMessage(object sender, MessageEventArgs e)
        {
            dynamic json = moSerializer.Deserialize(e.Data, typeof(object));

            string type = json.type;

            switch (type)
            {
                case "hello":
                    StartCountdown(json.count);
                    mnMinBet = json.minbet;
                    mnMaxBet = json.maxbet;
                    mnMaxBetRounds = json.br;
                    mnRollCountdown = json.accept;
                    mnBalance = json.balance;
                    mnRoundID = json.rolls[9].rollid;

                    for(int i = 9; i >= 0; i--)
                    {
                        lRolls.Add(json.rolls[i].roll);
                        lBids.Add("");
                    }


                    break;

                case "roll":
                    lRolls.RemoveAt(0);
                    lRolls.Add(json.roll);

                    lBids.RemoveAt(0);
                    if (mnCurrentTotal > 0)
                        lBids.Add(json.won > 0 ? "WIN" : "LOSE");
                    else
                        lBids.Add("");

                    if (json.won > 0)
                        mbWonLast = true;
                    else
                        mbWonLast = false;

                    mnLoss += mnCurrentTotal - json.won < 0 ? 0: mnCurrentTotal - json.won;
                    mnWin += mnCurrentTotal - json.won > 0 ? 0 : json.won - mnCurrentTotal;
                    mnRoundID = json.rollid;

                    mnCurrentBetRound = 0;
                    mnCurrentTotal = 0;
                    mnBidRed = 0;
                    mnBidGreen = 0;
                    mnBidBlack = 0;

                    mbDisabled = true;
                    UpdateForm();
                    System.Threading.Thread.Sleep(json.wait * 1000);
                    mbDisabled = false;
                    StartCountdown(mnRollCountdown);

                    break;
                    
                case "bet":
                    //TODO
                    break;

                case "logins":
                    //ToDo
                    break;

                case "chat":
                    //ToDo
                    break;

                case "error":
                    lblStatus.Text = json.error;
                    break;

                case "betconfirm":
                    mnCurrentTotal += json.bet.amount;

                    if (json.bet.lower == 1 && json.bet.upper == 7)
                        mnBidRed = json.bet.amount;
                    
                    if (json.bet.lower == 0 && json.bet.upper == 0)
                        mnBidGreen = json.bet.amount;

                    if (json.bet.lower == 8 && json.bet.upper == 14)
                        mnBidBlack = json.bet.amount;

                    mnCurrentBetRound = json.mybr;
                    mnBalance = json.balance;
                    mbDisabled = false;

                    break;

                default:
                    break;

                    

            }

            UpdateForm();
        }
        #endregion

        #region "methods"
        private void Connect()
        {
            //TOKEN ABRUFEN

            HttpWebRequest oWebRequest = (HttpWebRequest)WebRequest.Create(HOST_ADDRESS + "scripts/getToken.php");
            oWebRequest.CookieContainer = new CookieContainer();

            foreach (Tuple<string, string> cookie in ChromeCookieReader.ReadCookies(".csgodouble.com"))
            {
                Uri target = new Uri(HOST_ADDRESS);
                oWebRequest.CookieContainer.Add(new Cookie(cookie.Item1, cookie.Item2) { Domain = target.Host });
            }
            
            string strResponse = String.Empty;

            using (HttpWebResponse oWebResponse = (HttpWebResponse)oWebRequest.GetResponse())
            {
                using (StreamReader readStream = new StreamReader(oWebResponse.GetResponseStream(), System.Text.Encoding.GetEncoding("utf-8")))
                {
                    Char[] read = new Char[256];
                    // Reads 256 characters at a time.    
                    int count = readStream.Read(read, 0, 256);
                    while (count > 0)
                    {
                        // Dumps the 256 characters on a string and displays the string to the console.
                        strResponse += new String(read, 0, count);
                        count = readStream.Read(read, 0, 256);
                    }
                }
            }
            
            moWebSocket = new WebSocket(WS_HOST_ADDRESS + "/" + strResponse);
            moWebSocket.WaitTime = new TimeSpan(0,1,0);
            moWebSocket.OnMessage += (sender, e) => { OnMessage(sender, e); };

            foreach (Tuple<string, string> cookie in ChromeCookieReader.ReadCookies(".csgodouble.com"))
                moWebSocket.SetCookie(new WebSocketSharp.Net.Cookie(cookie.Item1, cookie.Item2));
            
            moWebSocket.Connect();

        }

        public void SendBet(string json)
        {
            moWebSocket.SendAsync(json, null);
        }

        public string GetSendJSON(int amount, int lower, int upper, int roundid)
        {
            return  "{\"type\":\"bet\",\"amount\":" + amount + ",\"lower\":" + lower + ",\"upper\":" + upper + ",\"round\":" + roundid + "}";
        }


        private int mnTimeLeft = 0;
        private bool mbBettingTime = true;
        System.Timers.Timer oCountdown;
        private void StartCountdown(int seconds)
        {
            mStatus = enStatus.Rolling;
            mbBettingTime = true;
            mnTimeLeft = seconds * 1000;
            oCountdown = new System.Timers.Timer(1000);
            oCountdown.Enabled = true;
            oCountdown.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            oCountdown.Start();
        }
        

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            mnTimeLeft = mnTimeLeft - 1000;

            if(mStatus == enStatus.Waiting)
                SetStatus("Next round in " + mnTimeLeft / 1000 + " seconds");
            else
                SetStatus("Rolling in " + mnTimeLeft / 1000 + " seconds");

            if (mnTimeLeft <= 0)
            {
                oCountdown.Stop();
                mbBettingTime = false;
            }
        }

        private void SetStatus(string status)
        {
            if (this.InvokeRequired)
                this.Invoke(new DelegateParamString(SetStatus), status);
            else
                lblStatus.Text = status;
        }
        
        private void UpdateForm()
        {
            if(this.InvokeRequired)
            {
                this.Invoke(new DelegateNoParam(UpdateForm));
            }
            else
            {
                switch (mStatus)
                {
                    case enStatus.Disconnected:
                        lblStatus.Text = "Disconnected";
                        btnStartBot.Text = "Try to Reconnect";
                        btnStartBot.Enabled = true;
                        frmConfig.Enabled = false;
                        break;

                    case enStatus.Error:
                        lblStatus.Text = "Error";
                        btnStartBot.Text = "Try to Reconnect";
                        btnStartBot.Enabled = true;
                        frmConfig.Enabled = false;
                        break;

                    case enStatus.Connected:
                        lblStatus.Text = "Connected";
                        btnStartBot.Text = "Start Bot";
                        btnStartBot.Enabled = true;
                        btnPlaceBetRed.Enabled = true;
                        btnPlaceBetGreen.Enabled = true;
                        btnPlaceBetBlack.Enabled = true;
                        frmConfig.Enabled = true;
                        break;

                    case enStatus.Running:
                        lblStatus.Text = "Running";
                        btnStartBot.Text = "Stop Bot";
                        btnStartBot.Enabled = true;
                        frmConfig.Enabled = false;
                        break;
                }

                btnPlaceBetRed.Enabled = !mbDisabled || !bBotIsRunning;
                btnPlaceBetGreen.Enabled = !mbDisabled || !bBotIsRunning;
                btnPlaceBetBlack.Enabled = !mbDisabled || !bBotIsRunning;

                txtBalance.Text = mnBalance.ToString("#,##0");
                txtWin.Text = mnWin.ToString("#,##0");
                txtLoss.Text = mnLoss.ToString("#,##0");
                txtTotal.Text = (mnWin - mnLoss).ToString("#,##0");
                txtTotal.BackColor = mnWin - mnLoss < 0 ? System.Drawing.Color.Red : System.Drawing.Color.Green;

                lblBidRed.Text = mnBidRed.ToString("#,##0");
                lblBidGreen.Text = mnBidGreen.ToString("#,##0");
                lblBidBlack.Text = mnBidBlack.ToString("#,##0");
                
                for (int i = 0; i < lRolls.Count; i++)
                {
                    ColorAndSetRoll((Label)Controls.Find("lblPastRoll" + i, true)[0], lRolls[i]);
                    ColorAndSetBid((Label)Controls.Find("lblPastBid" + i, true)[0], lBids[i]);
                }
            }
        }

        private void ColorAndSetRoll(Label lbl, int roll)
        {
            lbl.Text = roll.ToString("#0");

            if (roll == 0)
            {
                lbl.BackColor = System.Drawing.Color.Green;
                lbl.ForeColor = System.Drawing.Color.Black;
            }
            else if (roll < 8)
            {
                lbl.BackColor = System.Drawing.Color.Red;
                lbl.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                lbl.BackColor = System.Drawing.Color.Black;
                lbl.ForeColor = System.Drawing.Color.White;
            }
        }

        private void ColorAndSetBid(Label lbl, string bid)
        {
            switch (bid)
            {
                case "":
                    lbl.Text = "";
                    lbl.BackColor = System.Drawing.Color.Transparent;
                    break;

                case "WIN":
                    lbl.Text = "WIN";
                    lbl.BackColor = System.Drawing.Color.Green;
                    break;

                case "LOSE":
                    lbl.Text = "LOSE";
                    lbl.BackColor = System.Drawing.Color.Red;
                    break;
            }
            
        }
        #endregion

        #region "BOT"

        private bool bBotIsRunning = false;
        private static Thread tBot;

        string color;
        int nStartBid;
        int nMaxLosestreak;
        int nSwitchColor;
        int nBidMultiplier;
        int nMultiplyAfter;

        private void btnStartBot_Click(object sender, EventArgs e)
        {
            if (tBot == null || !tBot.IsAlive)
            {
                int n = 0;

                if(String.IsNullOrEmpty((string)cmbColor.SelectedItem) | !int.TryParse(txtStartBid.Text, out n) | !int.TryParse(txtMaxLosestreak.Text, out n) | !int.TryParse(txtSwitchColor.Text, out n) | !int.TryParse(txtMultiplier.Text, out n) | !int.TryParse(txtMultiplyAfter.Text, out n))
                    MessageBox.Show("Bot is not configurated correctly");
                else
                {
                    btnStartBot.Text = "Stop Bot";

                    color = (string)cmbColor.SelectedItem;
                    nStartBid = int.Parse(txtStartBid.Text);
                    nMaxLosestreak = int.Parse(txtMaxLosestreak.Text);
                    nSwitchColor = int.Parse(txtSwitchColor.Text);
                    nBidMultiplier = int.Parse(txtMultiplier.Text);
                    nMultiplyAfter = int.Parse(txtMultiplyAfter.Text);

                    txtStartBid.ReadOnly = true;
                    txtMaxLosestreak.ReadOnly = true;
                    txtSwitchColor.ReadOnly = true;
                    txtMultiplier.ReadOnly = true;
                    txtMultiplyAfter.ReadOnly = true;

                    tBot = new Thread(new ThreadStart(RunBot));
                    tBot.Start();
                }
            }
            else
            {
                tBot.Abort();

                btnStartBot.Text = "Start Bot";

                txtStartBid.ReadOnly = false;
                txtMaxLosestreak.ReadOnly = false;
                txtSwitchColor.ReadOnly = false;
                txtMultiplier.ReadOnly = false;
                txtMultiplyAfter.ReadOnly = false;
            }
        }

        public void RunBot()
        {
           

            int nCurrentLoseStreak = -1;
            int nLastBid = 0;

            while (tBot != null || !tBot.IsAlive)
            {
                if(mbBettingTime && mnCurrentBetRound == 0)
                {
                    mbBettingTime = false;
                    int nBid = nStartBid;

                    if (mbWonLast)
                    {
                        nCurrentLoseStreak = 0;
                    }
                    else
                    {
                        nCurrentLoseStreak += 1;

                        if (nCurrentLoseStreak % nMaxLosestreak == 0) { }
                        else if (nCurrentLoseStreak % nMultiplyAfter == 0)
                            nBid = (nLastBid * nBidMultiplier) + nStartBid; //+StartBid is win maximisation mode;
                    }
                    
                    if(nCurrentLoseStreak != 0 && nCurrentLoseStreak % nSwitchColor == 0)
                    {
                        if (color == "red")
                            color = "black";
                        else if (color == "black")
                            color = "red";
                    }

                    nLastBid = nBid;

                    switch (color)
                    {
                        case "red":
                            SendBet(GetSendJSON(nBid, 1, 7, mnRoundID));
                            break;
                        case "green":
                            SendBet(GetSendJSON(nBid, 0, 0, mnRoundID));
                            break;
                        case "black":
                            SendBet(GetSendJSON(nBid, 8, 14, mnRoundID));
                            break;
                    }
                }
            };
        }
        #endregion


    }
}
