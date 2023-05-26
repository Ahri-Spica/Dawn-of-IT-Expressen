using Dapper;
using IT_Expressen_Gruppe_5.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IT_Expressen_Gruppe_5.DAL
{   //Af Dannie
//@Kunde_ID int,
//@Projekt_status int,


    public class SqlConnector : IDataConnection
    {   /// <summary>
    /// Gemmer et nyt projekt til databasen
    /// </summary>
    /// <param name="model"></param>
    /// <returns>værdierne fra opret projekt formen</returns>
        public Project CreatNewProject(Project projectModel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("IT_Expressen_Gruppe_5.Properties.Settings._2_sem_gr_5ConnectionString")))
            {
               var sp = new DynamicParameters();
                //TODOsp.Add("@Kunde_ID")
                //@Krav_ID int techk?
                sp.Add("@name", projectModel.Name);
                sp.Add("@description", projectModel.Description);
                sp.Add("@StartDate", projectModel.StartDate);
                sp.Add("@EndDate", projectModel.EndDate);
                sp.Add("@Projekt_ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spCreateNewProject", sp, commandType: CommandType.StoredProcedure);

                projectModel.ProjectID = sp.Get<int>("@Projekt_ID");

                return projectModel;

            }
        }
    }
}
