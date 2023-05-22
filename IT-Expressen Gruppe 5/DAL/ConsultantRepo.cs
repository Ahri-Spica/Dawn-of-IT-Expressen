using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Expressen_Gruppe_5.DAL
{
    class ConsultantRepo
    {
        Database.SQL_DBDataContext dbc = new Database.SQL_DBDataContext();

        public List<Models.Consultant> GetAllConsultants()
        {
            var result = new List<Models.Consultant>();

            var ALLDtoItem = dbc.Konsulent_s;

            Models.Consultant Consults = new Models.Consultant();
            foreach (var dto in ALLDtoItem)
            {
                Consults.ConsultantID = dto.Konsulent_ID;
                Consults.SpecializationID = dto.specifikationer_ID;
                Consults.Name = dto.Navn;
                Consults.PhoneNr = dto.Tlf_nr;
                Consults.Adress = dto.adresse;
                
                result.Add(Consults);
            }
            return result;
        }

        public void DeleteConsultants(Models.Consultant dto)
        {
            var targetConsult = dbc.Konsulent_s.FirstOrDefault(x => x.Konsulent_ID == dto.ConsultantID);

            dbc.Konsulent_s.DeleteOnSubmit(targetConsult);

            dbc.SubmitChanges();
        }

        public void AddConsultant(Models.Consultant dto)
        {
            var DBObject = new Database.Konsulent_()
            {
                Konsulent_ID = dto.ConsultantID,
                Navn = dto.Name,
                adresse = dto.Adress,
                Tlf_nr = dto.PhoneNr,
                // Specs intergration???
            };

            dbc.Konsulent_s.InsertOnSubmit(DBObject);

            dbc.SubmitChanges();
        }

        public void EditConsultants(Models.Consultant consultEdit)
        {
            Database.SQL_DBDataContext dbc = new Database.SQL_DBDataContext();

            var targetConsult = dbc.Konsulent_s.FirstOrDefault(x => x.Konsulent_ID == consultEdit.ConsultantID);

            targetConsult.Navn = consultEdit.Name;
            targetConsult.adresse = consultEdit.Adress;
            targetConsult.Tlf_nr = consultEdit.PhoneNr;
            //Specs intergration???

            dbc.SubmitChanges();
        }
    }
}
