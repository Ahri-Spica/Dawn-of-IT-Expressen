using IT_Expressen_Gruppe_5.DAL;
using IT_Expressen_Gruppe_5.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Expressen_Gruppe_5
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void ShowLoginBox()
        {
            var Login = new Login();
            Login.ShowDialog();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            //ShowLoginBox();
            UpdateAdminUI();
        }

        private void UpdateAdminUI()
        {   ConsultantRepo consultantRepo = new ConsultantRepo();
            ProjectRepo projectRepo = new ProjectRepo();
            CustomerRepo customerRepo = new CustomerRepo();
            dgv_ActiveProjects.DataSource = projectRepo.GetAllActiveProjects();
            dgv_CompletedProjects.DataSource = projectRepo.GetAllCompletedProjects();
            dgv_Consultens.DataSource = consultantRepo.GetAllConsultants();
            dgv_Customers.DataSource = customerRepo.GetAllCustomers();
            
        }

        private void bt_opretNytProject_Click(object sender, EventArgs e)
        {
          
            OpretProjekt opretProjektForm = new OpretProjekt();

            opretProjektForm.Show();

        }

        private void bt_apRediger_Click(object sender, EventArgs e)
        {
            
        }
    }
}
