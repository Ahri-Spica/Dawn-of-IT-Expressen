using IT_Expressen_Gruppe_5.Database;
using IT_Expressen_Gruppe_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Expressen_Gruppe_5.DAL
{     // Af dannie
    public class ProjectRepo
    {
        //opretter en instance af SQLDB klassen
        Database.SQL_DBDataContext dbc = new Database.SQL_DBDataContext();

        //Henter alt data fra projekt table i DB
        public List<Models.Project> GetAllProjects()
        {           
            var result = new List<Models.Project>();
             // Henter data fra databasen linq to sql
            var ProjectData = dbc.Projekts.ToList();

            //ligger det hentet data in i projekt model klassen
            foreach (var projectDto in ProjectData)
            {
                Models.Project project = new Models.Project();
                project.ProjectID = projectDto.projekt_ID;
                project.CustomerID = (int)projectDto.Kunde_ID; 
                project.Name = projectDto.Name;
                project.StartDate = projectDto.start_dato;
                project.EndDate = projectDto.slut_dato;
                project.Description = projectDto.Description;
                project.ProjectStatus = projectDto.Projekt_status;
                project.HourlyRate = projectDto.Timeopgørelse;
                project.ConsultantID = projectDto.Konsulent_ID;
                project.ChatID = projectDto.Chat_Id;
                project.Requirements = projectDto.Krav_ID;

                result.Add(project);
            }

            return result.ToList();
        }
        //Her bliver der lavet en liste som indeholder færdige projekter - Jakob og Dannie
        public List<Models.Project> GetCompletedProjectsToConsultant()
        {
            
            var result = new List<Models.Project>();

            var SortedProjects = dbc.Projekts.Where(ap => ap.Projekt_status == 1);
            foreach (var projectDto in SortedProjects)
            {
                Models.Project project = new Models.Project();
                project.ProjectID = projectDto.projekt_ID;
                project.CustomerID = (int)projectDto.Kunde_ID;
                project.Name = projectDto.Name;
                project.StartDate = projectDto.start_dato;
                project.EndDate = projectDto.slut_dato;
                project.Description = projectDto.Description;
                project.ProjectStatus = projectDto.Projekt_status;
                project.HourlyRate = projectDto.Timeopgørelse;
                project.ConsultantID = projectDto.Konsulent_ID;
                project.ChatID = projectDto.Chat_Id;
                project.Requirements = projectDto.Krav_ID;

                result.Add(project);
            }

            return result.ToList();
        }
        //Her bliver der lavet en liste som indeholder aktive projekter - Jakob og Dannie
        public List<Models.Project> GetActiveProjectsToConsultant()
        {
            
            var result = new List<Models.Project>();
            
            var SortedProjects = dbc.Projekts.Where(ap => ap.Projekt_status == 0);
            foreach (var projectDto in SortedProjects)
            {
                Models.Project project = new Models.Project();
                project.ProjectID = projectDto.projekt_ID;
                project.CustomerID = (int)projectDto.Kunde_ID;
                project.Name = projectDto.Name;
                project.StartDate = projectDto.start_dato;
                project.EndDate = projectDto.slut_dato;
                project.Description = projectDto.Description;
                project.ProjectStatus = projectDto.Projekt_status;
                project.HourlyRate = projectDto.Timeopgørelse;
                project.ConsultantID = projectDto.Konsulent_ID;
                project.ChatID = projectDto.Chat_Id;
                project.Requirements = projectDto.Krav_ID;

                result.Add(project);
            }
            return result.ToList();
           
        }
        //Her laves en metode til at slette et Project - Jakob
        public void DeleteProject(Models.Project dto)
        {
            var targetProject = dbc.Projekts.FirstOrDefault(x => x.projekt_ID == dto.ProjectID);

            dbc.Projekts.DeleteOnSubmit(targetProject);

            dbc.SubmitChanges();
        }
    }

    /*public List<Models.Consultant> GetAllConsultants()
    {
        var result = new List<Models.Consultant>();

        var ALLDtoItem = dbc.Konsulents

        Models.Consultant Consuls = new Models.Consultant();
        foreach (var dto in ALLDtoItem)
        {

            Consults.___ =

            result.Add(Consults);
        }
        return result;
    }*/

    
    /*
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
