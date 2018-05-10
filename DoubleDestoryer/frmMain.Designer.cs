namespace DoubleDestroyer
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.frmConfig = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxLosestreak = new System.Windows.Forms.TextBox();
            this.btnStartBot = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLoss = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtWin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.frmRolls = new System.Windows.Forms.GroupBox();
            this.lblPastRoll8 = new System.Windows.Forms.Label();
            this.lblPastRoll7 = new System.Windows.Forms.Label();
            this.lblPastRoll6 = new System.Windows.Forms.Label();
            this.lblPastRoll5 = new System.Windows.Forms.Label();
            this.lblPastRoll4 = new System.Windows.Forms.Label();
            this.lblPastRoll3 = new System.Windows.Forms.Label();
            this.lblPastRoll2 = new System.Windows.Forms.Label();
            this.lblPastRoll1 = new System.Windows.Forms.Label();
            this.lblPastRoll0 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPastBid8 = new System.Windows.Forms.Label();
            this.lblPastBid7 = new System.Windows.Forms.Label();
            this.lblPastBid6 = new System.Windows.Forms.Label();
            this.lblPastBid5 = new System.Windows.Forms.Label();
            this.lblPastBid4 = new System.Windows.Forms.Label();
            this.lblPastBid3 = new System.Windows.Forms.Label();
            this.lblPastBid2 = new System.Windows.Forms.Label();
            this.lblPastBid1 = new System.Windows.Forms.Label();
            this.lblPastBid0 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPastRoll9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblPastBid9 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnPlaceBetBlack = new System.Windows.Forms.Button();
            this.btnPlaceBetGreen = new System.Windows.Forms.Button();
            this.btnPlaceBetRed = new System.Windows.Forms.Button();
            this.lblBidBlack = new System.Windows.Forms.Label();
            this.lblBidGreen = new System.Windows.Forms.Label();
            this.lblBidRed = new System.Windows.Forms.Label();
            this.txtBidBlack = new System.Windows.Forms.TextBox();
            this.txtBidGreen = new System.Windows.Forms.TextBox();
            this.txtBidRed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSwitchColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMultiplier = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMultiplyAfter = new System.Windows.Forms.TextBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStartBid = new System.Windows.Forms.TextBox();
            this.frmConfig.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.frmRolls.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmConfig
            // 
            this.frmConfig.Controls.Add(this.label9);
            this.frmConfig.Controls.Add(this.txtStartBid);
            this.frmConfig.Controls.Add(this.label8);
            this.frmConfig.Controls.Add(this.cmbColor);
            this.frmConfig.Controls.Add(this.label7);
            this.frmConfig.Controls.Add(this.txtMultiplyAfter);
            this.frmConfig.Controls.Add(this.label6);
            this.frmConfig.Controls.Add(this.txtMultiplier);
            this.frmConfig.Controls.Add(this.label5);
            this.frmConfig.Controls.Add(this.txtSwitchColor);
            this.frmConfig.Controls.Add(this.btnStartBot);
            this.frmConfig.Controls.Add(this.label2);
            this.frmConfig.Controls.Add(this.txtMaxLosestreak);
            this.frmConfig.Location = new System.Drawing.Point(12, 317);
            this.frmConfig.Name = "frmConfig";
            this.frmConfig.Size = new System.Drawing.Size(503, 121);
            this.frmConfig.TabIndex = 4;
            this.frmConfig.TabStop = false;
            this.frmConfig.Text = "Bot-Configuration";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Max allowed losestreak";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaxLosestreak
            // 
            this.txtMaxLosestreak.Location = new System.Drawing.Point(132, 43);
            this.txtMaxLosestreak.Name = "txtMaxLosestreak";
            this.txtMaxLosestreak.Size = new System.Drawing.Size(110, 20);
            this.txtMaxLosestreak.TabIndex = 5;
            this.txtMaxLosestreak.Text = "10";
            // 
            // btnStartBot
            // 
            this.btnStartBot.Enabled = false;
            this.btnStartBot.Location = new System.Drawing.Point(6, 95);
            this.btnStartBot.Name = "btnStartBot";
            this.btnStartBot.Size = new System.Drawing.Size(491, 20);
            this.btnStartBot.TabIndex = 6;
            this.btnStartBot.Text = "Start Bot";
            this.btnStartBot.UseVisualStyleBackColor = true;
            this.btnStartBot.Click += new System.EventHandler(this.btnStartBot_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.txtLoss);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.txtWin);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtBalance);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(315, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 127);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Session Win / Loss";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(103, 101);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(91, 20);
            this.txtTotal.TabIndex = 24;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(6, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 20);
            this.label15.TabIndex = 25;
            this.label15.Text = "Total";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(9, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 2);
            this.panel2.TabIndex = 22;
            // 
            // txtLoss
            // 
            this.txtLoss.Location = new System.Drawing.Point(103, 70);
            this.txtLoss.Name = "txtLoss";
            this.txtLoss.ReadOnly = true;
            this.txtLoss.Size = new System.Drawing.Size(91, 20);
            this.txtLoss.TabIndex = 22;
            this.txtLoss.Text = "0";
            this.txtLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(6, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "Loss";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(9, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 2);
            this.panel1.TabIndex = 21;
            // 
            // txtWin
            // 
            this.txtWin.Location = new System.Drawing.Point(103, 44);
            this.txtWin.Name = "txtWin";
            this.txtWin.ReadOnly = true;
            this.txtWin.Size = new System.Drawing.Size(91, 20);
            this.txtWin.TabIndex = 7;
            this.txtWin.Text = "0";
            this.txtWin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "Win";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(103, 16);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(91, 20);
            this.txtBalance.TabIndex = 6;
            this.txtBalance.Text = "0";
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Current Balance";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblStatus);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(503, 59);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Status";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(6, 16);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(491, 40);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Disconnected";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRolls
            // 
            this.frmRolls.Controls.Add(this.lblPastRoll8);
            this.frmRolls.Controls.Add(this.lblPastRoll7);
            this.frmRolls.Controls.Add(this.lblPastRoll6);
            this.frmRolls.Controls.Add(this.lblPastRoll5);
            this.frmRolls.Controls.Add(this.lblPastRoll4);
            this.frmRolls.Controls.Add(this.lblPastRoll3);
            this.frmRolls.Controls.Add(this.lblPastRoll2);
            this.frmRolls.Controls.Add(this.lblPastRoll1);
            this.frmRolls.Controls.Add(this.lblPastRoll0);
            this.frmRolls.Location = new System.Drawing.Point(12, 77);
            this.frmRolls.Name = "frmRolls";
            this.frmRolls.Size = new System.Drawing.Size(420, 59);
            this.frmRolls.TabIndex = 7;
            this.frmRolls.TabStop = false;
            this.frmRolls.Text = "Past Rolls";
            // 
            // lblPastRoll8
            // 
            this.lblPastRoll8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastRoll8.Location = new System.Drawing.Point(374, 16);
            this.lblPastRoll8.Name = "lblPastRoll8";
            this.lblPastRoll8.Size = new System.Drawing.Size(40, 40);
            this.lblPastRoll8.TabIndex = 16;
            this.lblPastRoll8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPastRoll7
            // 
            this.lblPastRoll7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastRoll7.Location = new System.Drawing.Point(328, 16);
            this.lblPastRoll7.Name = "lblPastRoll7";
            this.lblPastRoll7.Size = new System.Drawing.Size(40, 40);
            this.lblPastRoll7.TabIndex = 15;
            this.lblPastRoll7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPastRoll6
            // 
            this.lblPastRoll6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastRoll6.Location = new System.Drawing.Point(282, 16);
            this.lblPastRoll6.Name = "lblPastRoll6";
            this.lblPastRoll6.Size = new System.Drawing.Size(40, 40);
            this.lblPastRoll6.TabIndex = 14;
            this.lblPastRoll6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPastRoll5
            // 
            this.lblPastRoll5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastRoll5.Location = new System.Drawing.Point(236, 16);
            this.lblPastRoll5.Name = "lblPastRoll5";
            this.lblPastRoll5.Size = new System.Drawing.Size(40, 40);
            this.lblPastRoll5.TabIndex = 13;
            this.lblPastRoll5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPastRoll4
            // 
            this.lblPastRoll4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastRoll4.Location = new System.Drawing.Point(190, 16);
            this.lblPastRoll4.Name = "lblPastRoll4";
            this.lblPastRoll4.Size = new System.Drawing.Size(40, 40);
            this.lblPastRoll4.TabIndex = 12;
            this.lblPastRoll4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPastRoll3
            // 
            this.lblPastRoll3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastRoll3.Location = new System.Drawing.Point(144, 16);
            this.lblPastRoll3.Name = "lblPastRoll3";
            this.lblPastRoll3.Size = new System.Drawing.Size(40, 40);
            this.lblPastRoll3.TabIndex = 11;
            this.lblPastRoll3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPastRoll2
            // 
            this.lblPastRoll2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastRoll2.Location = new System.Drawing.Point(98, 16);
            this.lblPastRoll2.Name = "lblPastRoll2";
            this.lblPastRoll2.Size = new System.Drawing.Size(40, 40);
            this.lblPastRoll2.TabIndex = 10;
            this.lblPastRoll2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPastRoll1
            // 
            this.lblPastRoll1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastRoll1.Location = new System.Drawing.Point(52, 16);
            this.lblPastRoll1.Name = "lblPastRoll1";
            this.lblPastRoll1.Size = new System.Drawing.Size(40, 40);
            this.lblPastRoll1.TabIndex = 9;
            this.lblPastRoll1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPastRoll0
            // 
            this.lblPastRoll0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastRoll0.Location = new System.Drawing.Point(6, 16);
            this.lblPastRoll0.Name = "lblPastRoll0";
            this.lblPastRoll0.Size = new System.Drawing.Size(40, 40);
            this.lblPastRoll0.TabIndex = 8;
            this.lblPastRoll0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPastBid8);
            this.groupBox1.Controls.Add(this.lblPastBid7);
            this.groupBox1.Controls.Add(this.lblPastBid6);
            this.groupBox1.Controls.Add(this.lblPastBid5);
            this.groupBox1.Controls.Add(this.lblPastBid4);
            this.groupBox1.Controls.Add(this.lblPastBid3);
            this.groupBox1.Controls.Add(this.lblPastBid2);
            this.groupBox1.Controls.Add(this.lblPastBid1);
            this.groupBox1.Controls.Add(this.lblPastBid0);
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 42);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Past Bids";
            // 
            // lblPastBid8
            // 
            this.lblPastBid8.Location = new System.Drawing.Point(374, 16);
            this.lblPastBid8.Name = "lblPastBid8";
            this.lblPastBid8.Size = new System.Drawing.Size(40, 20);
            this.lblPastBid8.TabIndex = 16;
            this.lblPastBid8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPastBid7
            // 
            this.lblPastBid7.Location = new System.Drawing.Point(328, 16);
            this.lblPastBid7.Name = "lblPastBid7";
            this.lblPastBid7.Size = new System.Drawing.Size(40, 20);
            this.lblPastBid7.TabIndex = 15;
            this.lblPastBid7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPastBid6
            // 
            this.lblPastBid6.Location = new System.Drawing.Point(282, 16);
            this.lblPastBid6.Name = "lblPastBid6";
            this.lblPastBid6.Size = new System.Drawing.Size(40, 20);
            this.lblPastBid6.TabIndex = 14;
            this.lblPastBid6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPastBid5
            // 
            this.lblPastBid5.Location = new System.Drawing.Point(236, 16);
            this.lblPastBid5.Name = "lblPastBid5";
            this.lblPastBid5.Size = new System.Drawing.Size(40, 20);
            this.lblPastBid5.TabIndex = 13;
            this.lblPastBid5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPastBid4
            // 
            this.lblPastBid4.Location = new System.Drawing.Point(190, 16);
            this.lblPastBid4.Name = "lblPastBid4";
            this.lblPastBid4.Size = new System.Drawing.Size(40, 20);
            this.lblPastBid4.TabIndex = 12;
            this.lblPastBid4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPastBid3
            // 
            this.lblPastBid3.Location = new System.Drawing.Point(144, 16);
            this.lblPastBid3.Name = "lblPastBid3";
            this.lblPastBid3.Size = new System.Drawing.Size(40, 20);
            this.lblPastBid3.TabIndex = 11;
            this.lblPastBid3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPastBid2
            // 
            this.lblPastBid2.Location = new System.Drawing.Point(98, 16);
            this.lblPastBid2.Name = "lblPastBid2";
            this.lblPastBid2.Size = new System.Drawing.Size(40, 20);
            this.lblPastBid2.TabIndex = 10;
            this.lblPastBid2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPastBid1
            // 
            this.lblPastBid1.Location = new System.Drawing.Point(52, 16);
            this.lblPastBid1.Name = "lblPastBid1";
            this.lblPastBid1.Size = new System.Drawing.Size(40, 20);
            this.lblPastBid1.TabIndex = 9;
            this.lblPastBid1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPastBid0
            // 
            this.lblPastBid0.Location = new System.Drawing.Point(6, 16);
            this.lblPastBid0.Name = "lblPastBid0";
            this.lblPastBid0.Size = new System.Drawing.Size(40, 20);
            this.lblPastBid0.TabIndex = 8;
            this.lblPastBid0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPastRoll9);
            this.groupBox2.Location = new System.Drawing.Point(438, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(77, 59);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Last Roll";
            // 
            // lblPastRoll9
            // 
            this.lblPastRoll9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastRoll9.Location = new System.Drawing.Point(6, 16);
            this.lblPastRoll9.Name = "lblPastRoll9";
            this.lblPastRoll9.Size = new System.Drawing.Size(65, 40);
            this.lblPastRoll9.TabIndex = 6;
            this.lblPastRoll9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblPastBid9);
            this.groupBox5.Location = new System.Drawing.Point(438, 136);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(77, 42);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Last Bid";
            // 
            // lblPastBid9
            // 
            this.lblPastBid9.Location = new System.Drawing.Point(6, 16);
            this.lblPastBid9.Name = "lblPastBid9";
            this.lblPastBid9.Size = new System.Drawing.Size(65, 20);
            this.lblPastBid9.TabIndex = 6;
            this.lblPastBid9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnPlaceBetBlack);
            this.groupBox6.Controls.Add(this.btnPlaceBetGreen);
            this.groupBox6.Controls.Add(this.btnPlaceBetRed);
            this.groupBox6.Controls.Add(this.lblBidBlack);
            this.groupBox6.Controls.Add(this.lblBidGreen);
            this.groupBox6.Controls.Add(this.lblBidRed);
            this.groupBox6.Controls.Add(this.txtBidBlack);
            this.groupBox6.Controls.Add(this.txtBidGreen);
            this.groupBox6.Controls.Add(this.txtBidRed);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.lblRed);
            this.groupBox6.Location = new System.Drawing.Point(12, 184);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(297, 127);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Bid";
            // 
            // btnPlaceBetBlack
            // 
            this.btnPlaceBetBlack.Enabled = false;
            this.btnPlaceBetBlack.Location = new System.Drawing.Point(162, 68);
            this.btnPlaceBetBlack.Name = "btnPlaceBetBlack";
            this.btnPlaceBetBlack.Size = new System.Drawing.Size(38, 20);
            this.btnPlaceBetBlack.TabIndex = 35;
            this.btnPlaceBetBlack.Text = "Bid!";
            this.btnPlaceBetBlack.UseVisualStyleBackColor = true;
            this.btnPlaceBetBlack.Click += new System.EventHandler(this.txtPlaceBetBlack_Click);
            // 
            // btnPlaceBetGreen
            // 
            this.btnPlaceBetGreen.Enabled = false;
            this.btnPlaceBetGreen.Location = new System.Drawing.Point(162, 42);
            this.btnPlaceBetGreen.Name = "btnPlaceBetGreen";
            this.btnPlaceBetGreen.Size = new System.Drawing.Size(38, 20);
            this.btnPlaceBetGreen.TabIndex = 34;
            this.btnPlaceBetGreen.Text = "Bid!";
            this.btnPlaceBetGreen.UseVisualStyleBackColor = true;
            this.btnPlaceBetGreen.Click += new System.EventHandler(this.txtPlaceBetGreen_Click);
            // 
            // btnPlaceBetRed
            // 
            this.btnPlaceBetRed.Enabled = false;
            this.btnPlaceBetRed.Location = new System.Drawing.Point(162, 16);
            this.btnPlaceBetRed.Name = "btnPlaceBetRed";
            this.btnPlaceBetRed.Size = new System.Drawing.Size(38, 20);
            this.btnPlaceBetRed.TabIndex = 3;
            this.btnPlaceBetRed.Text = "Bid!";
            this.btnPlaceBetRed.UseVisualStyleBackColor = true;
            this.btnPlaceBetRed.Click += new System.EventHandler(this.txtPlaceBetRed_Click);
            // 
            // lblBidBlack
            // 
            this.lblBidBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBidBlack.Location = new System.Drawing.Point(206, 66);
            this.lblBidBlack.Name = "lblBidBlack";
            this.lblBidBlack.Size = new System.Drawing.Size(85, 20);
            this.lblBidBlack.TabIndex = 33;
            this.lblBidBlack.Text = "0";
            this.lblBidBlack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBidGreen
            // 
            this.lblBidGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBidGreen.Location = new System.Drawing.Point(206, 41);
            this.lblBidGreen.Name = "lblBidGreen";
            this.lblBidGreen.Size = new System.Drawing.Size(85, 20);
            this.lblBidGreen.TabIndex = 32;
            this.lblBidGreen.Text = "0";
            this.lblBidGreen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBidRed
            // 
            this.lblBidRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBidRed.Location = new System.Drawing.Point(206, 16);
            this.lblBidRed.Name = "lblBidRed";
            this.lblBidRed.Size = new System.Drawing.Size(85, 20);
            this.lblBidRed.TabIndex = 31;
            this.lblBidRed.Text = "0";
            this.lblBidRed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBidBlack
            // 
            this.txtBidBlack.Location = new System.Drawing.Point(65, 68);
            this.txtBidBlack.Name = "txtBidBlack";
            this.txtBidBlack.Size = new System.Drawing.Size(91, 20);
            this.txtBidBlack.TabIndex = 2;
            this.txtBidBlack.Text = "0";
            this.txtBidBlack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBidGreen
            // 
            this.txtBidGreen.Location = new System.Drawing.Point(65, 42);
            this.txtBidGreen.Name = "txtBidGreen";
            this.txtBidGreen.Size = new System.Drawing.Size(91, 20);
            this.txtBidGreen.TabIndex = 1;
            this.txtBidGreen.Text = "0";
            this.txtBidGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBidRed
            // 
            this.txtBidRed.Location = new System.Drawing.Point(65, 16);
            this.txtBidRed.Name = "txtBidRed";
            this.txtBidRed.Size = new System.Drawing.Size(91, 20);
            this.txtBidRed.TabIndex = 0;
            this.txtBidRed.Text = "0";
            this.txtBidRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Black";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Green";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRed
            // 
            this.lblRed.Location = new System.Drawing.Point(6, 15);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(53, 20);
            this.lblRed.TabIndex = 26;
            this.lblRed.Text = "Red";
            this.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Switch color (not green)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSwitchColor
            // 
            this.txtSwitchColor.Location = new System.Drawing.Point(132, 69);
            this.txtSwitchColor.Name = "txtSwitchColor";
            this.txtSwitchColor.Size = new System.Drawing.Size(110, 20);
            this.txtSwitchColor.TabIndex = 8;
            this.txtSwitchColor.Text = "5";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(248, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Last Bid Multiplier";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMultiplier
            // 
            this.txtMultiplier.Location = new System.Drawing.Point(374, 43);
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.Size = new System.Drawing.Size(123, 20);
            this.txtMultiplier.TabIndex = 10;
            this.txtMultiplier.Text = "2";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(248, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Multiply after";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMultiplyAfter
            // 
            this.txtMultiplyAfter.Location = new System.Drawing.Point(374, 69);
            this.txtMultiplyAfter.Name = "txtMultiplyAfter";
            this.txtMultiplyAfter.Size = new System.Drawing.Size(123, 20);
            this.txtMultiplyAfter.TabIndex = 12;
            this.txtMultiplyAfter.Text = "1";
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "red",
            "green",
            "black"});
            this.cmbColor.Location = new System.Drawing.Point(132, 16);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(110, 21);
            this.cmbColor.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Start Color";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(248, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Start Bid";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStartBid
            // 
            this.txtStartBid.Location = new System.Drawing.Point(374, 16);
            this.txtStartBid.Name = "txtStartBid";
            this.txtStartBid.Size = new System.Drawing.Size(123, 20);
            this.txtStartBid.TabIndex = 16;
            this.txtStartBid.Text = "1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 444);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.frmRolls);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.frmConfig);
            this.MaximumSize = new System.Drawing.Size(537, 483);
            this.MinimumSize = new System.Drawing.Size(537, 483);
            this.Name = "frmMain";
            this.Text = "DoubleDestroyer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.frmConfig.ResumeLayout(false);
            this.frmConfig.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.frmRolls.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox frmConfig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxLosestreak;
        private System.Windows.Forms.Button btnStartBot;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox frmRolls;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtLoss;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtWin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPastRoll8;
        private System.Windows.Forms.Label lblPastRoll7;
        private System.Windows.Forms.Label lblPastRoll6;
        private System.Windows.Forms.Label lblPastRoll5;
        private System.Windows.Forms.Label lblPastRoll4;
        private System.Windows.Forms.Label lblPastRoll3;
        private System.Windows.Forms.Label lblPastRoll2;
        private System.Windows.Forms.Label lblPastRoll1;
        private System.Windows.Forms.Label lblPastRoll0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPastBid8;
        private System.Windows.Forms.Label lblPastBid7;
        private System.Windows.Forms.Label lblPastBid6;
        private System.Windows.Forms.Label lblPastBid5;
        private System.Windows.Forms.Label lblPastBid4;
        private System.Windows.Forms.Label lblPastBid3;
        private System.Windows.Forms.Label lblPastBid2;
        private System.Windows.Forms.Label lblPastBid1;
        private System.Windows.Forms.Label lblPastBid0;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPastRoll9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblPastBid9;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblBidBlack;
        private System.Windows.Forms.Label lblBidGreen;
        private System.Windows.Forms.Label lblBidRed;
        private System.Windows.Forms.TextBox txtBidBlack;
        private System.Windows.Forms.TextBox txtBidGreen;
        private System.Windows.Forms.TextBox txtBidRed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Button btnPlaceBetRed;
        private System.Windows.Forms.Button btnPlaceBetBlack;
        private System.Windows.Forms.Button btnPlaceBetGreen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMultiplyAfter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMultiplier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSwitchColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStartBid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbColor;
    }
}

