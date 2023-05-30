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
        private DAL.ProjectRepoConsultan projectRepoConsultan;
        private DAL.ProjectRepo projectRepo;

        //Constructer der tager Consulent            
        public ProjectServices(Models.Consultant consultant)
        {
            projectRepo = new DAL.ProjectRepoConsultan(consultant);
        }
        
        //En constructer uden parameter
        public ProjectServices()
        {
            projectRepo = new DAL.ProjectRepo();
        }
        public List<Models.Project> GetAllProjects()
        {
            return projectRepo.GetAllProjects();
        }

        public List<Models.Project> GetAllActiveProjects()
        {
            return projectRepo.GetAllActiveProjects();
        }

        public List<Models.Project> GetAllCompletedProjects()
        {
            return projectRepo.GetAllCompletedProjects();
        }
        public List<Models.Project> GetCompletedProjectsToConsultant()
        {
            return projectRepoConsultan.GetCompletedProjectsToConsultant();

        }

        public List<Models.Project> GetActiveProjectsToConsultant()
        {
            return projectRepoConsultan.GetActiveProjectsToConsultant();
        }
        public void DeleteProject(Models.Project MyProject)
        {
            
            projectRepo.DeleteProject(MyProject);
        }
    }
}
