using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Expressen_Gruppe_5.Models
{
    class Chat
    {
        public int ChatID { get; set; }
        public int ProjectID { get; set; }
        public string Messages { get; set; }
        public DateTime MsgTime { get; set; }
        public int CustomerID { get; set; }
        public int ConsultantID { get; set; }
    }
}
