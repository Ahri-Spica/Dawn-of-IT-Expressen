using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT_Expressen_Gruppe_5.DAL;
using IT_Expressen_Gruppe_5.Models;

namespace IT_Expressen_Gruppe_5.Services
{
    class SpecService
    {
        public List<Technologies> GetAllTechnologies()
        {
            var techs = new SpecsRepo();
            return techs.GetAllTechnologies();
        }
        public void AddTehnology(Technologies dto)
        {
            var techs = new SpecsRepo();
            techs.AddTechnology(dto);
        }
        public void DeleteTechnology(Technologies dto)
        {
            var techs = new SpecsRepo();
            techs.DeleteTechnology(dto);
        }
        public void EditTechnology(Technologies EditTech)
        {
            var techs = new SpecsRepo();
            techs.EditTechnology(EditTech);
        }

        public List<ConsultType> GetAllCoTypes()
        {
            var types = new SpecsRepo();
            return types.GetAllCoTypes();
        }
        public void AddTehnology(ConsultType dto)
        {
            var types = new SpecsRepo();
            types.AddCoType(dto);
        }
        public void DeleteTechnology(ConsultType dto)
        {
            var types = new SpecsRepo(); ;
            types.DeleteCoType(dto);
        }
        public void EditTechnology(ConsultType EditType)
        {
            var types = new SpecsRepo();
            types.EditCoType(EditType);
        }
    }
}
