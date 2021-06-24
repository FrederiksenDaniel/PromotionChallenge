using System.Collections.Generic;

namespace Promotion.Tests.Engine
{
    public class Basket
    {
        public List<BasketLine> BasketLines { get; set; }

        public Basket()
        {
            BasketLines = new List<BasketLine>();
        }
    }
}