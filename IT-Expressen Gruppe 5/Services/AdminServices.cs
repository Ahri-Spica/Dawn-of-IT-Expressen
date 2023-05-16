using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Expressen_Gruppe_5.Services
{
    class Admin_Services
    {
        public List<Models.Admin> GetAdmins()
        {
            var AdminRepo = new DAL.AdminRepo();
            return AdminRepo.GetAllAdmins();
        }
        public void AddAdmin(Models.Admin dto)
        {
            var AddAdminToRepo = new DAL.AdminRepo();
            AddAdminToRepo.AddAdmin(dto);
        }
        public void DeleteAdmin(Models.Admin dto)
        {
            var DeleteAdminFromRepo = new DAL.AdminRepo();
            DeleteAdminFromRepo.DeleteAdmin(dto);
        }
        public void EditAdmin(Models.Admin dto)
        {
            var EditAdminRepo = new DAL.AdminRepo();
            EditAdminRepo.EditAdmin(dto);
        }
    }
}
