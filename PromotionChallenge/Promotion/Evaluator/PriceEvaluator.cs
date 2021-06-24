using Promotion.Modules;
using System;

namespace Promotion.Evaluator
{
    public class PriceEvaluator
    {
        public int EvaluatePrice(Basket basket)
        {
            var result = 0;
            foreach(var basketLine in basket.BasketLines)
            {
                result += (basketLine.BasketLineProduct.Price * basketLine.Quantity);
            }
            return result;
        }
    }
}