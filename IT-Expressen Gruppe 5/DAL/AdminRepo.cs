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

        public List<Models.Admin> GetAllAdmins()
        {
            var result = new List<Models.Admin>();

            var ALLDtoItem = dbc.Admins;

            Models.Admin Admin = new Models.Admin();
            foreach (var dto in ALLDtoItem)
            {

                result.Add(Admin);
            }
            return result;
        }

        public void DeleteAdmin(Models.Admin dto)
        {
            var targetAdmin = dbc.Admins.FirstOrDefault(x => x.Admin_ID == dto.AdminID);

            dbc.Admins.DeleteOnSubmit(targetAdmin);

            dbc.SubmitChanges();
        }
        public void AddAdmin(Models.Admin dto)
        {
            var DBObject = new Database.Admin()
            {
                Admin_ID = dto.AdminID,
                //__
            };

            dbc.Admins.InsertOnSubmit(DBObject);

            dbc.SubmitChanges();
        }

        public void EditAdmin(Models.Admin AdminEdit)
        {
            //? Database.SQL_DBDataContext dbc = new Database.SQL_DBDataContext();

            var targetAdmin = dbc.Admins.FirstOrDefault(x => x.Admin_ID == AdminEdit.AdminID);

            targetAdmin.Navn = AdminEdit.Name;
            //__

            dbc.SubmitChanges();
        }
    }
}
