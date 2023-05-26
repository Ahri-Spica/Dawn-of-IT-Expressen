using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Expressen_Gruppe_5.Services
{
    class Konsulent_Services
    {
      /*public List<Models.Consultant> GetAllConsultants()
        {
            var ConsultRepo = new DAL.ConsultantRepo();
            return ConsultRepo.GetAllConsultants();
        }
        public void AddConsultant(Models.Consultant dto)
        {
            var AddConsultantToRepo = new DAL.ConsultantRepo();
            AddConsultantToRepo.AddConsultant(dto);
        }
        public void DeleteConsultant(Models.Consultant dto)
        {
            var DeleteConsultantFromRepo = new DAL.ConsultantRepo();
            DeleteConsultantFromRepo.DeleteConsultant(dto);
        } */
        public void EditConsultant(Models.Consultant dto)
        {
            var EditConsultantRepo = new DAL.ConsultantRepo();
            EditConsultantRepo.EditConsultants(dto);
        } 
    }
}
