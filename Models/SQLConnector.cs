using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using Npgsql;

namespace ClickA.Models
{
    public static class SQLConnector
    {
        //Tabellen: nutzer, stats

        //SignIn muss bearbeitet werden
        public static SaveFileParser SFP { get; set; }


        static string conString = "Host=172.21.1.92;Port=5432;User ID=testuser;Password=test;Database=clicka_db;";

        static NpgsqlConnection con = new NpgsqlConnection(conString);
        static DataTable dt = new DataTable();
        public static DataTable ReadTable()
        {
            NpgsqlCommand com = new NpgsqlCommand("select * from nutzer;", con);
            using (NpgsqlDataAdapter ada = new NpgsqlDataAdapter(com))
            {
                ada.Fill(dt);
            }
            return dt;
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
            DataTable d = new DataTable();
            using (con)
            {
                string conString = $"select * from nutzer where username='{username}' and password='{password}'";
                using (NpgsqlCommand command = new NpgsqlCommand(conString, con))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        adapter.Fill(d);
                    }
                }
            }

            if (dt.Rows.Count == 1)
            {
                SFP.Username = d.Rows[0]["username"].ToString();
                SFP.Password = d.Rows[0]["password"].ToString();

            }


            return d.Rows.Count == 1 ? true : false;
        }

        public static void UpdateStats(int energy, int clickpower, int generator, int transformer, int clickbotfabrik, int clickbot)
        {
            using (con)
            {
                string comString = $"update table stats set energy={energy},clickpower={clickpower},generator={generator}, transformer={transformer},clickbotfabrik={clickbotfabrik}, clickbot={clickbot} where id=(select id from nutzer where username ={SFP.Username} and password = {SFP.Password}); ";
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
