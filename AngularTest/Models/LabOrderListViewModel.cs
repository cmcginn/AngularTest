using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularTest.Models
{
    public class LabOrderListViewModel
    {
        public int Id { get; set; }
        public string LabTestName { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderDateDisplay { get; set; }
        public decimal AmountBilled { get; set; }
        public decimal AmountCollected { get; set; }
    }
}