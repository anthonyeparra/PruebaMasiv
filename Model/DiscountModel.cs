using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaMasiv.Model
{
    public class DiscountModel
    {
        public int Id { get; set; }
        public string Console { get; set; }
        public float Minimal_price { get; set; }
        public float Maximum_price { get; set; }
        public int Discounts { get; set; }
    }
}
