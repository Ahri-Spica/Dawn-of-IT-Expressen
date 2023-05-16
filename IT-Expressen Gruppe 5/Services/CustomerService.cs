using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Expressen_Gruppe_5.Services
{
    class Kunde_Service
    {
        public List<Models.Customer> GetCustomers()
        {
            var customerRepo = new DAL.CustomerRepo();
            return customerRepo.GetAllCustomers();
        }
        public void AddCustomer(Models.Customer dto)
        {
            var AddCustomerToRepo = new DAL.CustomerRepo();
            AddCustomerToRepo.AddCustomer(dto);
        }
        public void DeleteCustomer(Models.Customer dto)
        {
            var DeleteCustomerFromRepo = new DAL.CustomerRepo();
            DeleteCustomerFromRepo.DeleteCustomer(dto);
        }
        public void EditCustomer(Models.Customer dto)
        {
            var EditCustomerRepo = new DAL.CustomerRepo();
            EditCustomerRepo.EditCustomer(dto);
        }
    }
}
