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
    public partial class KonsulentProfil : Form
    {
        public Models.Project MyProject { get; set; }
        public Models.Consultant MyConsultant { get; set; }
        //public Models.Invite MyInvite { get; set; }
        public KonsulentProfil()
        {
            InitializeComponent();
        }
        private void KonsulentProfil_Load(object sender, EventArgs e)
        {
            LoadConsultData();
        }
        public void LoadConsultData()
        {
            var ProjectService = new Services.Konsulent_Services();

            //Indsætter data i datagridviews
            dgw_aktiveProjekter.DataSource = KonsulentService.GetActiveProjectsToConsultant();
            dgw_FærdigeProjekter.DataSource = KonsulentService.GetCompletedProjectsToConsultant();
            //dgw_invitationer.DataSource = MyInvite;

            //Her bliver data fra databasen overført til textboxene på KonsulentProfil formen
            tb_konFornavn.Text = MyConsultant.Name;
            tb_konEfternavn.Text = MyConsultant.Name;
            tb_konAdresse.Text = MyConsultant.Adress;
            //tb_konKommune.Text = MyConsultant.State;
            //tb_konBy.Text = MyConsultant.City;
            //tb_konPostnummer.Text = MyConsultant.Zip.ToString();
            //tb_konEmail.Text = MyConsultant.Email;
            tb_konTlf.Text = MyConsultant.PhoneNr.ToString();

        }
        public void EditConsultant()
        {
            Services.Konsulent_Services konsulent_Services = new Services.Konsulent_Services();

            //bool canParseZip = int.TryParse(tb_konPostnummer, out int Zip);
            bool canParsePhonenumber = int.TryParse(tb_konTlf.Text, out int phonenumber);
            MyConsultant.Name = tb_konFornavn.Text;
            MyConsultant.Name = tb_konEfternavn.Text;
            MyConsultant.Adress = tb_konAdresse.Text;
            //MyConsultant.State = tb_konKommune.Text;
            //MyConsultant.City = tb_konBy.Text;
            //MyConsultant.Zip = Zip;
            //MyConsultant.Email = tb_konEmail.Text;
            MyConsultant.PhoneNr = phonenumber;
            konsulent_Services.EditConsultant(MyConsultant);
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            EditConsultant();
        }

        
    }
}
