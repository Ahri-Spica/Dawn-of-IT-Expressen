using IT_Expressen_Gruppe_5.Database;
using IT_Expressen_Gruppe_5.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Expressen_Gruppe_5.DAL
{     // Dannie & Jakob
    public class ProjectRepo
    {
        Database.SQL_DBDataContext dbc = new Database.SQL_DBDataContext();

        
        public ProjectRepo()
        {

        }

        // Fra DB.Project til Model.Project
        public Models.Project HelperProject(Database.Projekt dbProject)
        {
            // Opretter instance af Models.project
            return new Models.Project
            {
                ProjectID = (int)dbProject.projekt_ID,
                CustomerID = (int)dbProject.Kunde_ID,
                Name = dbProject.Name,
                StartDate = dbProject.start_dato,
                EndDate = dbProject.slut_dato,
                Description = dbProject.Description,
                ProjectStatus = (int?)dbProject.Projekt_status,
                HourlyRate = dbProject.Timeopgørelse,
                ConsultantID = dbProject.Konsulent_ID,
                ChatID = dbProject.Chat_Id,
                Requirements = dbProject.Krav_ID
            };
        }

        public List<Models.Project> GetAllProjects()
        {

            return dbc.Projekts.Select(HelperProject).ToList();
        }

        public List<Models.Project> GetAllActiveProjects()
        {

            return dbc.Projekts
                .Where(ap =>ap.Projekt_status == 1)
                .Select(HelperProject)
                .ToList ();
        }

        public List <Models.Project> GetAllCompletedProjects() 
        {
            return dbc.Projekts
                .Where(cp => cp.Projekt_status == 0)
                .Select(HelperProject)
                .ToList();       
        }
        public void DeleteProject(Models.Project dto)
        {
            var targetProject = dbc.Projekts.FirstOrDefault(x => x.projekt_ID == dto.ProjectID);
            dbc.Projekts.DeleteOnSubmit(targetProject);
            dbc.SubmitChanges();
        }

    }
}

       /*  public List<Models.Consultant> GetAllConsultants()
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


     
     public void EditConsultants(Models.Consultant consultEdit)
     {
        //? Database.SQL_DBDataContext dbc = new Database.SQL_DBDataContext();
        {
            var targetConsult = dbc.Konsulents.FirstOrDefault(x => x.Konsulent.Id == ConsultEdit.Konsulent_Id);

            targetConsult.Navn = consultEdit.Navn;
            targetConsult.Adresse = consultEdit.Adresse;
            targetConsult.TelefonNR = consultEdit.TelefonNr;

            dbc.SubmitChanges();
        }    
    }*/

    
