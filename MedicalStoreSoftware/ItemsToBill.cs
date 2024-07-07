using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreSoftware
{
    public class ItemsToBill
    {
        public string prdID { get; set; }
        public string prdName { get; set; }
        public int prdQuantity { get; set; }
        public int pricePI { get; set; }
        public string prdSize { get; set; }
        public int TPrice { get; set; }

        public int TotalPrice()
        {
            TPrice = pricePI * prdQuantity;
            return TPrice;
        }
    }
}
