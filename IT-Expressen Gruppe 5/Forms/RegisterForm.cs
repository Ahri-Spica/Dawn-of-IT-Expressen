using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IT_Expressen_Gruppe_5.Forms
{
    public partial class RegisterForm : Form
    {
        public string ConnString = @"Server=tcp:ucl-jtm-sqlserver.database.windows.net,1433;" +
               @"Initial Catalog=2-sem-gr-5; Persist Security Info=False; " +
               @"User ID = 2-sem-gr-5-login; Password='Gr25Pa$$word!';" +
               @"MultipleActiveResultSets=False; Encrypt=True; TrustServerCertificate = False;" +
               @"Connection Timeout = 30;";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            

        }
        public void CreateAdmin()
        {
            string AdName = AdminNameBox.Text;
            string AdPhoneNr = maskedAdminPhoneBox.Text;
            string AdAdress = AdminAdressBox.Text;

            if (AdminNameBox.Text == "" || maskedAdminPhoneBox.Text.Length < 8 || AdminAdressBox.Text == "")
            {
                MessageBox.Show("Please fill out the form");
            }
            else
            {
                SqlConnection conn = new SqlConnection(ConnString);
                conn.Open();

                string sSQL = $"INSERT INTO Admin VALUES ('{AdName}', '{AdAdress}', {AdPhoneNr});";
                SqlCommand command = new SqlCommand(sSQL, conn);
                command.ExecuteNonQuery();
            }
        }
        public void CreateCustomer()
        { 
            string CuName = NameBox.Text;
            string CuPhoneNr = maskedPhoneBox.Text;
            string CuAdress = AdressBox.Text;

            if (NameBox.Text == "" || maskedPhoneBox.Text.Length < 8 || AdressBox.Text == "")
            {
                MessageBox.Show("Please fill out the form");
            }
            else
            {
                SqlConnection conn = new SqlConnection(ConnString);
                conn.Open();

                string sSQL = $"INSERT INTO Kunde VALUES ('{CuName}', {CuPhoneNr}, '{CuAdress}');";
                SqlCommand command = new SqlCommand(sSQL, conn);
                command.ExecuteNonQuery();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hahaha that tickles!");
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            CreateCustomer();
        }

        private void AdminSubmitBtn_Click(object sender, EventArgs e)
        {
            CreateAdmin();
        }
    }
}
