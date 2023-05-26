using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Expressen_Gruppe_5.DAL
{
    class CustomerRepo
    {
        // conn string? //"Provider = SQLOLEDB.1; Persist Security Info=False;User ID = 2 - sem - gr - 5 - login; Initial Catalog = 2 - sem - gr - 5; Data Source = ucl - jtm - sqlserver.database.windows.net"
        Database.SQL_DBDataContext dbc = new Database.SQL_DBDataContext(); 

        public List<Models.Customer> GetAllCustomers()
        {
            var result = new List<Models.Customer>();

            var ALLDtoItemCu = dbc.Kundes;
            
           
            foreach (var dto in ALLDtoItemCu)
            {
                Models.Customer Kunder = new Models.Customer();
                Kunder.KundeID = dto.Kunde_ID;
                Kunder.Adresse = dto.adresse;
                Kunder.TelefonNr = dto.Tlf_nr;
                Kunder.Navn = dto.Navn;

                result.Add(Kunder);
            }
            return result;
        }

        public void AddCustomer(Models.Customer dto)
        {
            var DBObject = new Database.Kunde()
            {
                Kunde_ID = dto.KundeID,
                Navn = dto.Navn,
                adresse = dto.Adresse,
                Tlf_nr = dto.TelefonNr,
            };

            dbc.Kundes.InsertOnSubmit(DBObject);

            dbc.SubmitChanges();
        }
        public void DeleteCustomer(Models.Customer dto)
        {
            var targetCustomer = dbc.Kundes.FirstOrDefault(x => x.Kunde_ID == dto.KundeID);
            
            dbc.Kundes.DeleteOnSubmit(targetCustomer);

            dbc.SubmitChanges();
        }

        public void EditCustomer(Models.Customer customerEdit)
        {
            Database.SQL_DBDataContext dbc = new Database.SQL_DBDataContext();
            
            var targetCustomer = dbc.Kundes.FirstOrDefault(x => x.Kunde_ID == customerEdit.KundeID);

            targetCustomer.Navn = customerEdit.Navn;
            targetCustomer.adresse = customerEdit.Adresse;
            targetCustomer.Tlf_nr = customerEdit.TelefonNr;

            dbc.SubmitChanges();
        }
    }
}
