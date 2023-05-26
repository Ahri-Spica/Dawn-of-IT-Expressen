using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Expressen_Gruppe_5.DAL
{
    class SpecsRepo
    {
        Database.SQL_DBDataContext dbc = new Database.SQL_DBDataContext();

        //Tech

        public List<Models.Technologies> GetAllTechnologies()
        {
            var result = new List<Models.Technologies>();

            var ALLDtoItemTech = dbc.Teknologis;

            
            foreach (var dto in ALLDtoItemTech)
            {   
                Models.Technologies technologies = new Models.Technologies();
                
                technologies.TechnologyID = dto.Teknologi_ID;
                technologies.Technology = dto.Teknologi1;

                result.Add(technologies);
            }
            return result;
        }

        public void AddTechnology(Models.Technologies dto)
        {
            var DBObject = new Database.Teknologi()
            {
                Teknologi_ID = dto.TechnologyID,
                Teknologi1 = dto.Technology
            };

            dbc.Teknologis.InsertOnSubmit(DBObject);

            dbc.SubmitChanges();
        }

        public void DeleteTechnology(Models.Technologies dto)
        {
            var targetTechnology = dbc.Teknologis.FirstOrDefault(x => x.Teknologi_ID == dto.TechnologyID);

            dbc.Teknologis.DeleteOnSubmit(targetTechnology);

            dbc.SubmitChanges();
        }

        public void EditTechnology(Models.Technologies TechEdit)
        {
            Database.SQL_DBDataContext dbc = new Database.SQL_DBDataContext();

            var targetTech = dbc.Teknologis.FirstOrDefault(x => x.Teknologi_ID == TechEdit.TechnologyID);

            targetTech.Teknologi1 = TechEdit.Technology;

            dbc.SubmitChanges();
        }

        //Type

        public List<Models.ConsultType> GetAllCoTypes()
        {
            var result = new List<Models.ConsultType>();

            var ALLDtoItemCoType = dbc.Konsulent_Types;

            Models.ConsultType CoTypes = new Models.ConsultType();
            foreach (var dto in ALLDtoItemCoType)
            {
                CoTypes.ConsultantTypeID = dto.Konsulent_type_Id;
                CoTypes.Area = dto.Område;

                result.Add(CoTypes);
            }
            return result;
        }

        public void AddCoType(Models.ConsultType dto)
        {
            var DBObject = new Database.Konsulent_Type()
            {
                Konsulent_type_Id = dto.ConsultantTypeID,
                Område = dto.Area,
            };

            dbc.Konsulent_Types.InsertOnSubmit(DBObject);

            dbc.SubmitChanges();
        }

        public void DeleteCoType(Models.ConsultType dto)
        {
            var targetCoType = dbc.Konsulent_Types.FirstOrDefault(x => x.Konsulent_type_Id == dto.ConsultantTypeID);

            dbc.Konsulent_Types.DeleteOnSubmit(targetCoType);

            dbc.SubmitChanges();
        }

        public void EditCoType(Models.ConsultType CoTypeEdit)
        {
            Database.SQL_DBDataContext dbc = new Database.SQL_DBDataContext();

            var targetCoType = dbc.Konsulent_Types.FirstOrDefault(x => x.Konsulent_type_Id == CoTypeEdit.ConsultantTypeID);

            targetCoType.Område = CoTypeEdit.Area;

            dbc.SubmitChanges();
        }


    }
}
