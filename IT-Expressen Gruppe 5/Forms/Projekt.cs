using IT_Expressen_Gruppe_5.DAL;
using IT_Expressen_Gruppe_5.Services;
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
        private readonly SpecService spec_service;
        public Models.Project CustomerProject { get; set; }

        public Projekt()
        {
            InitializeComponent();
            spec_service = new SpecService();
        }

        private void Projekt_Load(object sender, EventArgs e)
        {
            UpdateCheckListBox();
            //LoadCustomerProject();
            UpdateProjectOnUI();
        }
       
        private void UpdateCheckListBox()
        {
            List<Models.Technologies> technologies = spec_service.GetAllTechnologies();
            foreach (var tech in technologies)
            {
                clb_Requirements.Items.Add(tech.Technology);
            }
        }
        private void UpdateProjectOnUI()
        { 
            //ConsultantRepo consultantRepo = new ConsultantRepo();
           //dgv_konsulenter.DataSource = consultantRepo.GetAllConsultants();



            ProjectRepo projectRepo = new ProjectRepo();
            dgv_konsulenter.DataSource = projectRepo.GetCompletedProjectsToConsultant();


            //tb_ProjektName.Text = CustomerProject.Name;


        }
        private void LoadCustomerProject()
        {
            CustomerProject = new Models.Project();
            
        }

        private void b_SearchKon_Click(object sender, EventArgs e)
        {

        }
    }   
}
