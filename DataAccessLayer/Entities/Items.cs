using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Items
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string CCode { get; set; }
        public string PSize { get; set; }
        public string TPrize { get; set; }
        public string RPrize { get; set; }
        public string STax { get; set; }
        public string SDiscount { get; set; }
        public string Stock { get; set; }
        public string SCode { get; set; }

    }
}
