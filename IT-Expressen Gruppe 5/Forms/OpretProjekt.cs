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


namespace IT_Expressen_Gruppe_5
{
    public partial class OpretProjekt : Form
    {
        private readonly SpecService spec_service;
        public Models.Projekt creatProjekt { get; set; }
        Database.SQL_DBDataContext dbc = new Database.SQL_DBDataContext();
        public OpretProjekt()
        {
            InitializeComponent();
            spec_service = new SpecService();
        }

        private void OpretProjekt_Load(object sender, EventArgs e)
        {
            UpdateCheckListBox();
        }
        private void UpdateCheckListBox()
        {
            List<Models.Technologies> technologies = spec_service.GetAllTechnologies();
            clb_Requirements.DataSource = technologies;
            clb_Requirements.DisplayMember = "Technology";
        }
        private void bt_create_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                 Project creatNewProject = new Project();
                creatNewProject.Name = tb_ProjectName.Text;
                creatNewProject.Description = tb_Description.Text;
                creatNewProject.StartDate = dtp_StartDate.Value;
                creatNewProject.EndDate = dtp_EndDate.Value;

               List<Models.Technologies> selectedTechnologies = new List<Models.Technologies>();
                foreach (var item in clb_Requirements.CheckedItems)
                {
                    Models.Technologies tech = item as Models.Technologies;
                    if (tech != null)
                    {
                        selectedTechnologies.Add(tech);
                    }
                }
             

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatNewProject(creatNewProject);
                }
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            if (tb_ProjectName.Text.Length == 0)
            {   //TODO lav output til user
                output = false;
            }

            if (tb_Description.Text.Length == 0)
            {   //TODO lav output til user
                output = false;
            }
            if (dtp_StartDate.Value.Date < DateTime.Now.Date)
            {
                //TODO lav output til user
                output = false;
            }

            if (dtp_EndDate.Value.Date < dtp_StartDate.Value.Date)
            {
                //TODO lav output til user
                output = false;
            }

            if (clb_Requirements.CheckedItems.Count == 0)
            {
                // no technology selected
                MessageBox.Show("Du har ikke sat nogle krav specifikation til dit projekt.");
                output = false;
            }

            return output;
        }

        
        
    }
}
