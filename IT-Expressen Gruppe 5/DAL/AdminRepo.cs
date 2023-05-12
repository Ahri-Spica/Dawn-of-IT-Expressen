using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Expressen_Gruppe_5.DAL
{
    class AdminRepo
    {
        Database.SQL_DBDataContext dbc = new Database.SQL_DBDataContext();

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
}
