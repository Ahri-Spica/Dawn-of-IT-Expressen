using IT_Expressen_Gruppe_5.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Expressen_Gruppe_5.DAL
{     // Af dannie
    public class ProjectRepo
    {

        public Models.Consultant MyConsultant { get; }

        //opretter en instance af SQLDB klassen
        Database.SQL_DBDataContext dbc = new Database.SQL_DBDataContext();

        //fra DB.Project til Model.Project
        private Models.Project HelperProject(Database.Projekt dbProject)
        {
            //Opretter instance af Models.project
            return new Models.Project
            {

                ProjectID = dbProject.projekt_ID,
                CustomerID = (int)dbProject.Kunde_ID,
                Name = dbProject.Name,
                StartDate = dbProject.start_dato,
                EndDate = dbProject.slut_dato,
                Description = dbProject.Description,
                ProjectStatus = dbProject.Projekt_status,
                HourlyRate = dbProject.Timeopgørelse,
                ConsultantID = dbProject.Konsulent_ID,
                ChatID = dbProject.Chat_Id,
                Requirements = dbProject.Krav_ID
            };
        }

        // retunere dbProjekts sorteret
        public List<Models.Project> GetAllProjects()
        {
            return dbc.Projekts.Select(HelperProject).ToList();
        }

        public List<Models.Project> GetCompletedProjectsToConsultant()
        {
            return dbc.Projekts
                 .Where(cp => cp.Projekt_status == 1 && cp.Konsulent_ID == MyConsultant.ConsultantID)
                 .Select(HelperProject).ToList();

        }
        public List<Models.Project> GetActiveProjectsToConsultant()
        {
            return dbc.Projekts
                .Where(ap => ap.Projekt_status == 0 && ap.Konsulent_ID == MyConsultant.ConsultantID)
                .Select(HelperProject)
                .ToList();
        }

        
    }

       /* public List<Models.Consultant> GetAllConsultants()
        {
            var result = new List<Models.Consultant>();

        var ALLDtoItem = dbc.Konsulents;

            Models.Consul tant Consuls = new Models.Consultant();
            foreach (var dto in ALLDtoItem)
            {

                Consults.___ =

                result.Add(Consults);
            }
            return result;
        }

        public void DeleteConsultants(Models.Consultants dto)
        {
            var targetConsult = dbc.Konsulents.FirstOrDefault(x => x.Konsulent.Id == dto.__;

            dbc.Konsulents.DeleteOnSubmit(targetConsult);

            dbc.SubmitChanges();
        }

        public void EditConsultants(Models.Consultant consultEdit)
        {
            //? Database.SQL_DBDataContext dbc = new Database.SQL_DBDataContext();

            var targetConsult = dbc.Konsulents.FirstOrDefault(x => x.Konsulent.Id == ConsultEdit.Konsulent_Id);

            targetConsult.Navn = consultEdit.Navn;
            targetConsult.Adresse = consultEdit.Adresse;
            targetConsult.TelefonNR = consultEdit.TelefonNr;

            dbc.SubmitChanges();
        }*/

}
