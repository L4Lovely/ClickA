using System;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using Npgsql;

namespace ClickA.Models
{
    public static class SQLConnector
    {
        //Tabellen: nutzer

        //SignIn muss bearbeitet werden
        public static SaveFileParser SFP { get; set; }


        static string conString = "Host=172.21.1.92;Port=5432;User ID=testuser;Password=test;Database=clicka_db;";

        static NpgsqlConnection con = new NpgsqlConnection(conString);
        static DataTable dt = new DataTable();

        public static DataTable Read()
        {
            DataTable data= new DataTable();
            using (con)
            {
                string conString = $"select * from nutzer;";
                using (NpgsqlCommand command = new NpgsqlCommand(conString, con))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        adapter.Fill(data);
                    }
                }
            }
            return data;
        }

        public static void NewSignUp(string Username, string password)
        {
            using (con)
            {
                string comString = $"insert into nutzer(id,username,password) values ({dt.Rows.Count},{Username},{password});";

                using (NpgsqlCommand command = new NpgsqlCommand(comString, con))
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        public static bool SignIn(string username, string password)
        {
            using (con)
            {
                string conString = $"select * from nutzer where username='{username}' and password='{password}'";
                using (NpgsqlCommand command = new NpgsqlCommand(conString, con))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            if (dt.Rows.Count == 1)
            {
                SFP.ID = Convert.ToInt32(dt.Rows[0]["id"]);
                SFP.Username = dt.Rows[0]["username"].ToString();
                SFP.Password = dt.Rows[0]["password"].ToString();
                SFP.Energy = Convert.ToInt32(dt.Rows[0]["energy"]);
                SFP.Transformer = Convert.ToInt32(dt.Rows[0]["transformer"]);
                SFP.Clickpower = Convert.ToInt32(dt.Rows[0]["clickpower"]);
                SFP.Clickbot = Convert.ToInt32(dt.Rows[0]["clickbot"]);
                SFP.Clickbotfabrik = Convert.ToInt32(dt.Rows[0]["clickbotfabrik"]);
                SFP.Generator = Convert.ToInt32(dt.Rows[0]["generator"]);
            }
            return dt.Rows.Count == 1 ? true : false;
        }

        public static void UpdateStats(int energy, int clickpower, int generator, int transformer, int clickbotfabrik, int clickbot)
        {
            using (con)
            {
                string comString = $"update table nutzer set energy={energy},clickpower={clickpower},generator={generator}, transformer={transformer},clickbotfabrik={clickbotfabrik}, clickbot={clickbot} where id=(select id from nutzer where id = {SFP.ID};";
                using (NpgsqlCommand command = new NpgsqlCommand(comString, con))
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
