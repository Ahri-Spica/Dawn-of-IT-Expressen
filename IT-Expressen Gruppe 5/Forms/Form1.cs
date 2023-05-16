using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IT_Expressen_Gruppe_5.Forms;

namespace IT_Expressen_Gruppe_5
{
    public partial class Form1 : Form
    {
        //the list with the final login authentication data
        public List<string> Logins = new List<string>(); //{ get; set; }

        public Form1()
        {
            InitializeComponent();
            //Hai
            //fedt mand
            
        }

        internal void Form1_Load(object sender, EventArgs e)
        {
            //This Login uses a .txt IO for the usernames and passwords
            //the filepath for the .txt database for logindata
            string filePath = @"C:\txt\Logins IO.txt";
            //checks if one actually exists on your system, if not it creates a default one for you
            bool fileExists = File.Exists(filePath);
            if (!fileExists)
            {
                File.Create(filePath);
                File.WriteAllText(filePath, $"Admin,000,\nKunde,777,\nKonsulent,808");
            }
            //fetches data from filestream
            List<string> fileData = File.ReadAllLines(filePath).ToList();
            //splits the lines up into usable data, and adds it to a list
            foreach (string line in fileData)
            {
                string[] entries = line.Split(',');
                foreach (string entry in entries)
                {
                    Logins.Add(entry);
                }
            }
            
            //tests if get data works
            foreach (var item in Logins)
            {
                testBox.Text += item + "\n"+".";
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Login();
        }
        
        
        public void Login()
        {
            //Admin Login
            if (UseBox.Text == Logins[0] && PassBox.Text == Logins[1])
            {

            }
            //Kunde Login
            if (UseBox.Text == Logins[2] && PassBox.Text == Logins[3])
            {

            }
            //Konsulent Login
            if (UseBox.Text == Logins[4] && PassBox.Text == Logins[5])
            {

            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            OpenCreateForm();
        }
        public void OpenCreateForm()
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            
        }
    }
}
