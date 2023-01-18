using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;

namespace ClickA.Models
{
    public  class SQLConnector{
        public  string Username { get; set; }
        public  string Password { get; set; }


        private static string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=ClickA_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conobj = new SqlConnection(connectionString);
        SqlCommand sqlCommand;

        public  DataTable LogInRequest() {
                DataTable dt = new DataTable();
                sqlCommand = new SqlCommand("select * from " + "users", conobj);
                using (SqlDataAdapter adaobj = new SqlDataAdapter(sqlCommand)){
                    conobj.Open();
                    adaobj.Fill(dt);
                    conobj.Close();
                }
            return dt;
        }

        public bool RegisterRequest(string checkforusername){
            sqlCommand = new SqlCommand($"SELECT * FROM USERS WHERE username = '{checkforusername}'", conobj);
            if (sqlCommand.ExecuteReader().HasRows)
            {
                // return registration has failed view -- username already exists
                return false;
            }
            return true;
        }

        public void RegisterUser(string checkforusername, string userpassword){
            conobj.Open();
            if (RegisterRequest(checkforusername))
            {
                sqlCommand = new SqlCommand($"INSERT INTO USERS values(1, '{checkforusername}', '{userpassword}')");
            }
            else { /*return registration has failed view -- username already exists */}
            conobj.Close();
        }
    }
}
