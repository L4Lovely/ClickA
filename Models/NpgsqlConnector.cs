using Npgsql;
using System.Data;
using System;

namespace ClickA.Models
{
    public static class NpgsqlConnector
    {
        //Tabellen: nutzer

        public static SaveFileParser SFP { get; set; } = new SaveFileParser();


        static string conString = @"Server=172.21.1.92;Database=clicka_db;User Id=testuser;Password=test;";


        static DataTable dt = new DataTable();



        public static void FirstRead()
        {
            NpgsqlConnection con = new NpgsqlConnection(conString);
            using (con)
            {
                string conString = "select * from nutzer;";
                using (NpgsqlCommand command = new NpgsqlCommand(conString, con))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                        con.Close();
                    }
                }
            }
        }


        public static void NewSignUp(string username, string password)
        {
            NpgsqlConnection con = new NpgsqlConnection(conString);
            using (con)
            {
                string comString = $"insert into nutzer values ({dt.Rows.Count},'{username}','{password}',0,0,0,0,0,0);";

                using (NpgsqlCommand command = new NpgsqlCommand(comString, con))
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                }
            }
            FirstRead();
        }

        //SignIn ist fertig!!!
        public static bool SignIn(string username, string password)
        {
            DataRow[] d = null;

            d = dt.Select($"username = '{username}' and password = '{password}'");

            if (d.Length == 1)
            {
                SFP.ID = Convert.ToInt32(d[0]["id"]);
                SFP.Username = d[0]["username"].ToString();
                SFP.Password = d[0]["password"].ToString();
                SFP.Energy = Convert.ToInt32(d[0]["energy"]);
                SFP.Transformer = Convert.ToInt32(d[0]["transformer"]);
                SFP.Clickpower = Convert.ToInt32(d[0]["clickpower"]);
                SFP.Clickbot = Convert.ToInt32(d[0]["clickbot"]);
                SFP.Clickbotfabrik = Convert.ToInt32(d[0]["clickbotfabrik"]);
                SFP.Generator = Convert.ToInt32(d[0]["generator"]);
            }
            return d.Length == 1 ? true : false;
        }

        public static void LogOut(int energy, int clickpower, int generator, int transformer, int clickbotfabrik, int clickbot)
        {
            NpgsqlConnection con = new NpgsqlConnection(conString);
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
