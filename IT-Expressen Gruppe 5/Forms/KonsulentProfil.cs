using IT_Expressen_Gruppe_5.DAL;
using IT_Expressen_Gruppe_5.Models;
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

namespace IT_Expressen_Gruppe_5.Forms
{
    // Af Jakob
    public partial class KonsulentProfil : Form
    {
        private ProjectRepo projectRepo;
        private List<Models.Project> MyActiveProjects;
        private List<Models.Project> MyCompletedProjects;
        private Models.Consultant MyConsultant;
        //public Models.Invite MyInvite { get; set; }

        public KonsulentProfil()
        {
            InitializeComponent();
        }
        public void UpdateProjectOnUI()
        {
            dgv_AProjects.DataSource = MyActiveProjects.ToList();
            dgv_FProjects.DataSource = MyCompletedProjects.ToList();
            dgv_AProjects.Refresh();
            dgv_FProjects.Refresh();
        }
        public void LoadProjectData()
        {

            var ProjectService = new Services.ProjectServices(MyConsultant);
            MyActiveProjects = ProjectService.GetActiveProjectsToConsultant().ToList();
            MyCompletedProjects = ProjectService.GetCompletedProjectsToConsultant().ToList();

        }
        public void LoadConsultData()
        {
            string fullname = MyConsultant.Name;
            var names = fullname.Split(' ');
            string firstname = names[0];
            string lastname = names[1];
            //dgw_invitationer.DataSource = MyInvite;

            //Her bliver data fra databasen overført til textboxene på KonsulentProfil formen
            tb_konFornavn.Text = firstname;
            tb_konEfternavn.Text = lastname;
            tb_konAdresse.Text = MyConsultant.Adress;
            //tb_konKommune.Text = MyConsultant.State;
            //tb_konBy.Text = MyConsultant.City;
            //tb_konPostnummer.Text = MyConsultant.Zip.ToString();
            //tb_konEmail.Text = MyConsultant.Email;
            tb_konTlf.Text = MyConsultant.PhoneNr.ToString();

        }
        public void SaveConsultantData()
        {
            Services.Konsulent_Services konsulent_Services = new Services.Konsulent_Services();

            //bool canParseZip = int.TryParse(tb_konPostnummer, out int Zip);
            bool canParsePhonenumber = int.TryParse(tb_konTlf.Text, out int phonenumber);
            MyConsultant.Name = tb_konFornavn.Text + " " + tb_konEfternavn.Text;
            MyConsultant.Adress = tb_konAdresse.Text;
            //MyConsultant.State = tb_konKommune.Text;
            //MyConsultant.City = tb_konBy.Text;
            //MyConsultant.Zip = Zip;
            //MyConsultant.Email = tb_konEmail.Text;
            MyConsultant.PhoneNr = phonenumber;
            konsulent_Services.EditConsultant(MyConsultant);
        }
        private void OpenEditProjectFormDgvA()
        {
            Models.Project SelectedProject = (Models.Project)dgv_AProjects.SelectedRows[0].DataBoundItem;

            if (SelectedProject == null)
            {
                throw new NullReferenceException("SelectedProject was null");
            }

            Projekt OpenProjectForm = new Projekt(SelectedProject, false);
            OpenProjectForm.ShowDialog();
        }
        private void OpenEditProjectFormDgvF()
        {
            Models.Project SelectedProject = (Models.Project)dgv_FProjects.SelectedRows[0].DataBoundItem;

            if (SelectedProject == null)
            {
                throw new NullReferenceException("SelectedProject was null");
            }

            Projekt OpenProjectForm = new Projekt(SelectedProject, false);
            OpenProjectForm.ShowDialog();
        }
        private void DeleteProjectDgvA()
        {
            Models.Project SelectedProject = (Models.Project)dgv_AProjects.SelectedRows[0].DataBoundItem;

            if (SelectedProject == null)
            {
                throw new NullReferenceException("SelectedCustomer was null");
            }

            Services.ProjectServices deleteProject = new Services.ProjectServices(MyConsultant);
            deleteProject.DeleteProject(SelectedProject);
        }
        private void DeleteProjectDgvF()
        {

            Models.Project SelectedProject = (Models.Project)dgv_FProjects.SelectedRows[0].DataBoundItem;
            if (SelectedProject == null)
            {
                throw new NullReferenceException("SelectedCustomer was null");
            }

            Services.ProjectServices deleteProject = new Services.ProjectServices(MyConsultant);
            deleteProject.DeleteProject(SelectedProject);
        }
        private void OpenAddProjectForm()
        {
            //Models.Project NewProject = new Models.Project();
            //OpretProjekt AddProject = new OpretProjekt(NewProject, true);
            //AddProject.ShowDialog();
            Models.Project NewProject = new Models.Project();
            OpretProjekt AddProject = new OpretProjekt();
            AddProject.ShowDialog();
        }

        private void bt_apRediger_Click(object sender, EventArgs e)
        {
            OpenEditProjectFormDgvA();
        }

        private void bt_opret_Click(object sender, EventArgs e)
        {
            OpenAddProjectForm();
        }

        private void bt_fpRediger_Click(object sender, EventArgs e)
        {
            OpenEditProjectFormDgvF();
        }

        private void KonsulentProfil_Load_1(object sender, EventArgs e)
        {

            Consultant consultant = new Consultant();
            consultant.ConsultantID = 3;
            consultant.PhoneNr = 23232323;
            consultant.Adress = "Adresse";
            consultant.Name = "Jakob Stephensen";

            this.MyConsultant = consultant;
            projectRepo = new ProjectRepo();
            LoadConsultData();
            LoadProjectData();
            UpdateProjectOnUI();
        }


        private void bt_save_Click_1(object sender, EventArgs e)
        {
            SaveConsultantData();
            UpdateProjectOnUI();
        }

        private void bt_FpDelete_Click(object sender, EventArgs e)
        {
            DeleteProjectDgvF();
        }

        private void bt_ApDelete_Click(object sender, EventArgs e)
        {
            DeleteProjectDgvA();
        }
    }
}
