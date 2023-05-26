using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Expressen_Gruppe_5.Models
{
    class Customer
    {
        public int KundeID { get; set; }
        public int BrugerID { get; set; }
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public int? TelefonNr { get; set; }
        public List<Models.Project> Projects { get; set; }
    }
}
