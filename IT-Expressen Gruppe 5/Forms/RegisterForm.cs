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
        //The Register Form is for Creating new Users
        //It Uses Connection Strings rather than LinQ to Achieve 

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        public void CreateAdmin()
        {
            var NewUserController = new Controllers.NewUser();
            string AdName = AdminNameBox.Text;
            string AdPhoneNr = maskedAdminPhoneBox.Text;
            string AdAdress = AdminAdressBox.Text;

            if (AdminNameBox.Text == "" || maskedAdminPhoneBox.Text.Length < 8 || AdminAdressBox.Text == "")
            {
                MessageBox.Show("Please fill out the form");
            }
            else
            {
                NewUserController.NewAdmin(AdName, AdPhoneNr, AdAdress);
            }
        }

        public void CreateCustomer()
        {
            var NewUserController = new Controllers.NewUser();
            string CuName = NameBox.Text;
            string CuPhoneNr = maskedPhoneBox.Text;
            string CuAdress = AdressBox.Text;

            if (NameBox.Text == "" || maskedPhoneBox.Text.Length < 8 || AdressBox.Text == "")
            {
                MessageBox.Show("Please fill out the form");
            }
            else
            {
                NewUserController.NewCustomer(CuName, CuPhoneNr, CuAdress);
            }
        }

        public void CreateConsultant()
        {
            var NewUserController = new Controllers.NewUser();
            string CoName = CoNameBox.Text;
            string CoPhone = maskedCoPhoneBox.Text;
            string CoAdress = CoAdressBox.Text;

          /*if ()
            {
                MessageBox.Show("Please fill out the form");
            }
            else
            {
                //NewUserController.NewConsultant(CuName, CuPhoneNr, CuAdress);
            }*/
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hahaha that tickles!");
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            CreateCustomer();
            this.Close();
        }

        private void AdminSubmitBtn_Click(object sender, EventArgs e)
        {
            CreateAdmin();
            this.Close();
        }

        private void CoSubmitBtn_Click(object sender, EventArgs e)
        {
            CreateConsultant();
            this.Close();
        }
    }
}
