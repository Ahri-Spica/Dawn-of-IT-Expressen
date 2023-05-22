using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IT_Expressen_Gruppe_5.Controllers
{
    public class NewUser
    {
        internal string ConnString = @"Server=tcp:ucl-jtm-sqlserver.database.windows.net,1433;" +
               @"Initial Catalog=2-sem-gr-5; Persist Security Info=False; " +
               @"User ID = 2-sem-gr-5-login; Password='Gr25Pa$$word!';" +
               @"MultipleActiveResultSets=False; Encrypt=True; TrustServerCertificate = False;" +
               @"Connection Timeout = 30;";

        //This Space is for CRUD via Connection String and the Data SQL Library

        public void NewAdmin(string Name, string Phone, string Adress)
        {
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();

            string sSQL = $"INSERT INTO Admin VALUES ('{Name}', '{Adress}', {Phone});";
            SqlCommand command = new SqlCommand(sSQL, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void NewCustomer(string Name, string Phone, string Adress)
        {
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();

            string sSQL = $"INSERT INTO Kunde VALUES ('{Name}', {Phone}, '{Adress}');";
            SqlCommand command = new SqlCommand(sSQL, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void NewConsult()
        {
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();

            //insert Payload here
            conn.Close();
        }
    }
}
