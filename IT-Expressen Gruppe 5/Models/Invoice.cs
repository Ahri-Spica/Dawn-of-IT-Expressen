using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Expressen_Gruppe_5.Models
{
    class Invoice
    {
        public int InvoiceID { get; set; }
        public int ProjectID { get; set; }
        public int ConsultantID { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        public DateTime TotalHours { get; set; }
        public string Instilations { get; set; }
    }
}
