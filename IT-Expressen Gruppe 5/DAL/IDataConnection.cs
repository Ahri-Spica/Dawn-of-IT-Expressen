using IT_Expressen_Gruppe_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Expressen_Gruppe_5.DAL
{   //Af dannie
    public interface IDataConnection
    {
        Project CreatNewProject(Project model);
    }
}
