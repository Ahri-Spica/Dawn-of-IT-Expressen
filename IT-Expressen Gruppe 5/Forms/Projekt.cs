using IT_Expressen_Gruppe_5.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Expressen_Gruppe_5.Models
{
    //Af Dannie
    public partial class Projekt : Form
    {
        public Models.Project CustomerProject { get; set; }

        public Projekt()
        {
            InitializeComponent();
        }

        private void Projekt_Load(object sender, EventArgs e)
        {
            //LoadCustomerProject();
            UpdateProjectOnUI();
        }

        private void UpdateProjectOnUI()
        {
           
            ConsultantRepo consultantRepo = new ConsultantRepo();
            dgv_konsulenter.DataSource = consultantRepo.GetAllConsultants();

             //tb_ProjektName.Text = CustomerProject.Name;
            /* Virker IKKE! Clear existing items in the CheckListBox
            clb_Requirements.Items.Clear();

            // Check if the requirements are not null before iterating
            if (CustomerProject.Requirements != null)
            {
                // Convert nullable integer to non-nullable integer
                int requirementsCount = CustomerProject.Requirements ?? 0;

                // Add requirements to the CheckListBox
                for (int i = 0; i < requirementsCount; i++)
                {
                    clb_Requirements.Items.Add(i + 1);
                }
            }*/
        }
        private void LoadCustomerProject()
        {
            CustomerProject = new Models.Project();
        }

      
    }   
}
