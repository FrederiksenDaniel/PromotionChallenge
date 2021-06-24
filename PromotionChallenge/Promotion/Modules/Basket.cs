using System.Collections.Generic;

namespace Promotion.Modules
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