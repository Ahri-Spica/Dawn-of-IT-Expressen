using IT_Expressen_Gruppe_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Expressen_Gruppe_5.Services
{
    // AF Dannie
    public class ProjectServices
    {
        Database.SQL_DBDataContext dbContext = new Database.SQL_DBDataContext();
       
        public List<Models.Project> GetAllProjects() 
        {
            var ProjectRepo = new DAL.ProjectRepo();

            return ProjectRepo.GetAllProjects();
        }
        public List<Models.Project> GetCompletedProjectsToConsultant()
        {
            var projectRepo = new DAL.ProjectRepo();
            return projectRepo.GetCompletedProjectsToConsultant();
        }
        public List<Models.Project> GetActiveProjectsToConsultant()
        {
            var projectRepo = new DAL.ProjectRepo();
            return projectRepo.GetActiveProjectsToConsultant();

        }
    }
}
