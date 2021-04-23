using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Customer
    {
        public string  ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PPhone { get; set; }
        public string SPhone { get; set; }
        public string ACode { get; set; }
        public string SmanID { get; set; }
    }
}
