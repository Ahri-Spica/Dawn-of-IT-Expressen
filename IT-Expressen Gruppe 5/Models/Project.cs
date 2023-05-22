using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Expressen_Gruppe_5.Models
{
    class Project
    {
        public int ProjectID { get; set; }
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public int ProjectStatus { get; set; } //bool
        public decimal HourlyRate { get; set; }
        public int ConsultantID { get; set; }
        public int ChatID { get; set; }
        public int RequirementID { get; set; }
    }
}
