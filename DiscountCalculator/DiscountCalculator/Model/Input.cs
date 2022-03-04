using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCalculator.Model
{
    public class Input
    {
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        public decimal? Discount { get; set; }
    }
}
