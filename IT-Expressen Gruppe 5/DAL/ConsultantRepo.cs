using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Expressen_Gruppe_5.DAL
{
    public class ConsultantRepo
    {
        Database.SQL_DBDataContext dbc = new Database.SQL_DBDataContext();

        public List<Models.Consultant> GetAllConsultants()
        {
            var result = new List<Models.Consultant>();

            var ALLDtoConsultant = dbc.Konsulent_s;

            Models.Consultant Consults = new Models.Consultant();
            foreach (var dto in ALLDtoConsultant)
            {
                var Consultant = new Models.Consultant();

                Consultant.ConsultantID = dto.Konsulent_ID;
                Consultant.SpecializationID = dto.specifikationer_ID;
                Consultant.Name = dto.Navn;
                Consultant.Adress = dto.adresse;
                Consultant.PhoneNr = dto.Tlf_nr;
                Consultant.Projects = new List<Models.Project>();

                // Fetch related projects for this consultant
                var relatedProjects = dbc.Projekts.Where(p => p.Konsulent_ID == dto.Konsulent_ID);
                Consultant.Projects = new List<Models.Project>();
                foreach (var dbProject in relatedProjects)
                {
                    var project = new Models.Project();
                    project.ProjectID = dbProject.projekt_ID;
                    project.CustomerID = (int)dbProject.Kunde_ID;
                    project.Name = dbProject.Name;
                    project.StartDate = (DateTime)dbProject.start_dato;
                    project.EndDate = (DateTime)dbProject.slut_dato;
                    project.Description = dbProject.Description;
                    project.ProjectStatus = (int)dbProject.Projekt_status;
                    project.HourlyRate = (int)dbProject.Timeopgørelse;
                    project.ConsultantID = (int)dbProject.Konsulent_ID;
                    project.ChatID = (int)dbProject.Chat_Id;
                    project.Requirements = (int)dbProject.Krav_ID;

                    Consultant.Projects.Add(project);
                }

                result.Add(Consultant);
            }
            return result;
        }

        public void DeleteConsultants(Models.Consultant dto)
        {
            var targetConsult = dbc.Konsulent_s.FirstOrDefault(x => x.Konsulent_ID == dto.ConsultantID);

            dbc.Konsulent_s.DeleteOnSubmit(targetConsult);

            dbc.SubmitChanges();
        }

        public void EditConsultants(Models.Consultant consultEdit)
        {
            //? Database.SQL_DBDataContext dbc = new Database.SQL_DBDataContext();

            var targetConsult = dbc.Konsulent_s.FirstOrDefault(x => x.Konsulent_ID == consultEdit.ConsultantID);

            targetConsult.Navn = consultEdit.Name;
            targetConsult.adresse = consultEdit.Adress;
            targetConsult.Tlf_nr = consultEdit.PhoneNr; 

            dbc.SubmitChanges();
        }
    }
}
