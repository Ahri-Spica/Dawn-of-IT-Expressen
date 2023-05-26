using IT_Expressen_Gruppe_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT_Expressen_Gruppe_5.DAL;

namespace IT_Expressen_Gruppe_5.Services
{
    // AF Dannie
    public class ProjectServices
    {
     //instance af DAL.projectRepo
        private DAL.ProjectRepo projectRepo;
   
        //constructer-bliver kaldt når et nyt objekt af klassen bliver lavet
        //Inde i constructer laves en ny instance af DAL.ProjectRepo
  
        public ProjectServices()
        {
            projectRepo = new DAL.ProjectRepo();
        }
        
        public List<Models.Project> GetAllProjects()
        {
            return projectRepo.GetAllProjects();
        }

        public List<Models.Project> GetCompletedProjectsToConsultant()
        {
            return projectRepo.GetCompletedProjectsToConsultant();
        }

        public List<Models.Project> GetActiveProjectsToConsultant()
        {
            return projectRepo.GetActiveProjectsToConsultant();
        }
    }
}
