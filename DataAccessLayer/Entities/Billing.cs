using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Billing
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string CCode { get; set; }
        public string ICode { get; set; }
        public string IQuantity { get; set; }
        public string Ostatus { get; set; }
        public string SDiscount { get; set; }
        public string Stax { get; set; }
        public string Totalamount { get; set; }
    }
}
