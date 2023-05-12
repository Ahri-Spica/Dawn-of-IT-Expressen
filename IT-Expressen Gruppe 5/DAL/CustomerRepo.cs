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
            var ALLDtoItemUs = dbc.Brugers;
            
            Models.Customer Kunder = new Models.Customer();
            foreach (var dto in ALLDtoItemCu)
            {

                Kunder.KundeID = dto.Kunde_Id;
                //Kunder.BrugerID = dto.Bruger_Id;

                result.Add(Kunder);
            }
            foreach (var dtoU in ALLDtoItemUs)
            {
                Kunder.Navn = dtoU.Navn;
                Kunder.Adresse = dtoU.Adresse;
                //Kunder.TelefonNr = dtoU.TelefoneNr; ;

                result.Add(Kunder);
            }
            return result;
        }

        /*public void AddCustomer(Models.Customer dto)
        {
            var daf = new Database.Customer()
            {
                CustomerID = dto.CustomerID,
                CustomerEmail = dto.CustomerEmail,
                Customer_Address = dto.CustomerAddress,
                CustomerCity = dto.CustomerCity,
                CustomerName = dto.CustomerName,
                CustomerPhonenumber = dto.CustomerPhonenumber,
                CustomerZip = dto.CustomerZipcode
            };

            dbcontext.Customers.InsertOnSubmit(daf);

            dbcontext.SubmitChanges();*/

            public void DeleteCustomer(Models.Customer dto)
        {
            //Måske er det Bruger der skal targetes her istedet?
            var targetCustomer = dbc.Kundes.FirstOrDefault(x => x.Kunde_Id == dto.KundeID);
            
            dbc.Kundes.DeleteOnSubmit(targetCustomer);

            dbc.SubmitChanges();
        }

        public void EditCustomer(Models.Customer customerEdit)
        {
            Database.SQL_DBDataContext dbc = new Database.SQL_DBDataContext();

            var targetCustomer = dbc.Kundes.FirstOrDefault(x => x.Kunde_Id == customerEdit.KundeID);

           //targetCustomer.Navn = customerEdit.Navn;
           //targetCustomer.Adresse = customerEdit.Adresse;
           //targetCustomer.TelefonNR = customerEdit.TelefonNr;

            dbc.SubmitChanges();
        }
    }
}
