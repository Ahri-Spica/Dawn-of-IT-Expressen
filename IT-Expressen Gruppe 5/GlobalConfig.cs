using IT_Expressen_Gruppe_5.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace IT_Expressen_Gruppe_5
{   //Af dannie
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();    

        public static void InitializeConnection(bool database)
        {
            if (database)
            {   //ikke sat op ordenligt
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
        }

        public static string CnnString(String name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
