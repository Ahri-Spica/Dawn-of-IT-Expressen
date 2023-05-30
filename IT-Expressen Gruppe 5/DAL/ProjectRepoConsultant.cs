using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Expressen_Gruppe_5.DAL
{ 
    //Af dannie
    public class ProjectRepoConsultan : ProjectRepo
    {
        Database.SQL_DBDataContext dbc = new Database.SQL_DBDataContext();
        public Models.Consultant MyConsultant { get; }

        public ProjectRepoConsultan(Models.Consultant consultant)
        {
            this.MyConsultant = consultant;
        }

        public List<Models.Project> GetActiveProjectsToConsultant()
        {
            return dbc.Projekts
                .Where(cpc => cpc.Projekt_status == 1 && cpc.Konsulent_ID == MyConsultant.ConsultantID)
                .Select(HelperProject).ToList();
        }

        public List<Models.Project> GetCompletedProjectsToConsultant()
        {
            return dbc.Projekts
                .Where(apc => apc.Projekt_status == 0 && apc.Konsulent_ID == MyConsultant.ConsultantID)
                .Select(HelperProject)
                .ToList();
        }
    }

}
