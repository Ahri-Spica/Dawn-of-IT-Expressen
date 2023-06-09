﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Expressen_Gruppe_5.Models
{
    public class Consultant
    {
        public int ConsultantID {get; set;}
        public int? TeknologiID { get; set; }
        public int? ConsultTypeID { get; set; }
        public string Name { get; set; }
        public int? PhoneNr { get; set; }
        public string Adress { get; set; }

        public List<Models.Project> projects { get; set; }
    }
}
