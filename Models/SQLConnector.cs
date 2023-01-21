using System;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;

namespace ClickA.Models
{
    public static class SQLConnector
    {
        //Tabellen: nutzer

        public static SaveFileParser SFP { get; set; }


        static string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";

        static SqlConnection con = new SqlConnection(conString);

       static DataTable dt = new DataTable();
        public static void NewSignUp(string Username, string password)
        {
            using (con)
            {
                string comString = $"insert into nutzer(id,username,password) values ({dt.Rows.Count},{Username},{password});";

                using (SqlCommand command = new SqlCommand(comString, con))
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
                string conString = $"select * from nutzer;";
                using (SqlCommand command = new SqlCommand(conString, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            DataRow[] d = dt.Select($"username = {username} and password = {password}");


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

        public static void UpdateStats(int energy, int clickpower, int generator, int transformer, int clickbotfabrik, int clickbot)
        {
            using (con)
            {
                string comString = $"update table nutzer set energy={energy},clickpower={clickpower},generator={generator}, transformer={transformer},clickbotfabrik={clickbotfabrik}, clickbot={clickbot} where id=(select id from nutzer where id = {SFP.ID};";
                using (SqlCommand command = new SqlCommand(comString, con))
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}