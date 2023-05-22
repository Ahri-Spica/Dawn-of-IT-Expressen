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

            
            foreach (var dto in ALLDtoConsultant)
            {
                var Consultant = new Models.Consultant();

                Consultant.ConsultantID = dto.Konsulent_ID;
                Consultant.SpecializationID = (int)dto.specifikationer_ID;
                Consultant.Name = dto.Navn;
                Consultant.Adress = dto.adresse;
                Consultant.PhoneNr = dto.Tlf_nr;
                Consultant.projects = new List<Models.Project>();

                
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

          /*  var targetConsult = dbc.Konsulent_s.FirstOrDefault(x => x.Konsulent_ID == ConsultEdit.Konsulent_Id);

            targetConsult.Navn = consultEdit.Navn;
            targetConsult.Adresse = consultEdit.Adresse;
            targetConsult.TelefonNR = consultEdit.TelefonNr; */

            dbc.SubmitChanges();
        }
    }
}
