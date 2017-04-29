using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal totoalParam);
    }

    public class DefaultDiscountHelper : IDiscountHelper
    {
        private decimal discountSize;

        public DefaultDiscountHelper(decimal disconutSizeParam)
        {
            discountSize = disconutSizeParam;
        }

        public decimal ApplyDiscount(decimal totalParam)
        {
            return (totalParam - (discountSize / 100m * totalParam));
        }    
    }
}