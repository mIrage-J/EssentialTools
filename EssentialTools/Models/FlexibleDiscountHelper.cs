using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class FlexibleDiscountHelper : IDiscountHelper
    {
        public decimal ApplyDiscount(decimal totoalParam)
        {
            decimal discount = totoalParam > 100 ? 70 : 25;
            return (totoalParam - (discount / 100m * totoalParam));
        }
    }
}