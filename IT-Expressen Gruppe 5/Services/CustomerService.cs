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
            var CustomerRepo = new DAL.CustomerRepo();
            return CustomerRepo.GetAllCustomers();
        }
        public void AddCustomer(Models.Customer dto)
        {
            var AddCustomerToRepo = new DAL.CustomerRepo();
            AddCustomerToRepo.AddCustomer(dto);

            /*public void AddCustomer(Models.Customer dto)
            {
                var AddCustomerRepository = new Repositories.CustomerRepository();
                AddCustomerRepository.AddCustomer(dto);
            }*/
        }
    }
}
