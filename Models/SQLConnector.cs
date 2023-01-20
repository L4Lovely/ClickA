using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using Npgsql;

namespace ClickA.Models
{
    public class SQLConnector
    {
        //Tabellen: nutzer, stats


        public string Username = string.Empty;
        public string Password = string.Empty;


        static string conString = "Host=172.21.1.92;Port=5432;User ID=testuser;Password=test;Database=clicka_db;";

        NpgsqlConnection con = new NpgsqlConnection(conString);
        DataTable dt = new DataTable();
        public DataTable ReadTable()
        {
            NpgsqlCommand com = new NpgsqlCommand("select * from nutzer;", con);
            using (NpgsqlDataAdapter ada = new NpgsqlDataAdapter(com))
            {
                ada.Fill(dt);
            }
            return dt;
        }

        public void NewSignUp(string Username, string password)
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
        public bool SignIn(string username, string password)
        {
            DataTable d = new DataTable();
            using (con)
            {
                string conString = $"select * from nutzer where username={username} and password={password}";
                using (NpgsqlCommand command = new NpgsqlCommand(conString, con))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        adapter.Fill(d);
                    }
                }
            }
            Username = d.Rows[0]["username"].ToString();
            Password = d.Rows[0]["password"].ToString();

            return d.Rows.Count == 1 ? true : false;
        }

        public void UpdateStats(int energy, int clickpower, int generator, int transformer, int clickbotfabrik, int clickbot)
        {
            using (con)
            {
                string comString = $"update table stats set energy={energy},clickpower={clickpower},generator={generator}, transformer={transformer},clickbotfabrik={clickbotfabrik}, clickbot={clickbot} where id=(select id from nutzer where username ={Username} and password = {Password}); ";
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
