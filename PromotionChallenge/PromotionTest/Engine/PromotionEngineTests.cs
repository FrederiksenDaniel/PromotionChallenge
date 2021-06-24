using Promotion.Evaluator;
using Promotion.Modules;
using Xunit;

namespace Promotion.Tests.Engine
{
    public class PromotionEngineTests
    {
        Product A = new Product() { Price = 50, Sku = "A" };
        Product B = new Product() { Price = 30, Sku = "B" };
        Product C = new Product() { Price = 20, Sku = "C" };
        private readonly PriceEvaluator _priceEvaluator;

        PromotionEngineTests(PriceEvaluator priceEvaluator)
        {
            _priceEvaluator = priceEvaluator;
        }

        [Fact]
        public void TestScenarioA()
        {
            //Arrange
            BasketLine basketLine1 = new BasketLine() { BasketLineProduct = A, Quantity = 1 };
            BasketLine basketLine2 = new BasketLine() { BasketLineProduct = B, Quantity = 1 };
            BasketLine basketLine3 = new BasketLine() { BasketLineProduct = C, Quantity = 1 };

            Basket basket = new Basket();
            basket.BasketLines.Add(basketLine1);
            basket.BasketLines.Add(basketLine2);
            basket.BasketLines.Add(basketLine3);

            //Act
            var result = _priceEvaluator.EvaluatePrice(basket);

            //Assert
            Assert.Equal(result, A.Price + B.Price + C.Price);
        }

        [Fact]
        public void TestScenarioB()
        {
            //Arrange
            BasketLine basketLine1 = new BasketLine() { BasketLineProduct = A, Quantity = 5 };
            BasketLine basketLine2 = new BasketLine() { BasketLineProduct = B, Quantity = 5 };
            BasketLine basketLine3 = new BasketLine() { BasketLineProduct = C, Quantity = 1 };

            Basket basket = new Basket();
            basket.BasketLines.Add(basketLine1);
            basket.BasketLines.Add(basketLine2);
            basket.BasketLines.Add(basketLine3);

            //Act
            var result = _priceEvaluator.EvaluatePrice(basket);

            //Assert
            Assert.Equal(370, result);
        }



    }
}
