using IT_Expressen_Gruppe_5.DAL;
using IT_Expressen_Gruppe_5.Database;
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
    {   CustomerRepo customerRepo = new CustomerRepo();
        ConsultantRepo consultantRepo = new ConsultantRepo();
        ProjectRepo projectRepo = new ProjectRepo();    
        private readonly SpecService spec_service;
        public Models.Project CustomerProject { get; set; }
        
       
        public Projekt(object openform, bool EditProject)
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
            
           dgv_konsulenter.DataSource = consultantRepo.GetAllConsultants();

            

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
