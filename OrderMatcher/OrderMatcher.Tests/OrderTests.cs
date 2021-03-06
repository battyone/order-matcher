using Xunit;

namespace OrderMatcher.Tests
{
    public class OrderTests
    {
        [Fact]
        public void Filled_ReturnsTrue_MarketOrderFilled()
        {
            Order order = new Order() { Price = 0, OpenQuantity = 0, OrderAmount = 0, IsBuy = true };
            Assert.True(order.IsFilled);
        }

        [Fact]
        public void Filled_ReturnsFalse_MarketOrderFilled_1()
        {
            Order order = new Order() { Price = 0, OpenQuantity = 0, OrderAmount = 2, IsBuy = true };
            Assert.False(order.IsFilled);
        }

        [Fact]
        public void Filled_ReturnsFalse_MarketOrderFilled_2()
        {
            Order order = new Order() { Price = 0, OpenQuantity = 1, IsBuy = true };
            Assert.False(order.IsFilled);
        }

        [Fact]
        public void Filled_ReturnsTrue_MarketOrderFilled_3()
        {
            Order order = new Order() { Price = 0, OpenQuantity = 0, OrderAmount = 2, IsBuy = false };
            Assert.True(order.IsFilled);
        }

        [Fact]
        public void Filled_ReturnsFalse_MarketOrderFilled_4()
        {
            Order order = new Order() { Price = 0, OpenQuantity = 1, IsBuy = false };
            Assert.False(order.IsFilled);
        }
    }
}
