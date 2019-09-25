using System;
using System.Collections.Generic;
using Xunit;
using System.Text;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        [Fact]
        public void ShouldBeDefaultFlavor()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal(SodasaurusFlavor.Cola, soda.Flavor);
        }
        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal(SodasaurusFlavor.Cherry, soda.Flavor);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal(1.50, soda.Price);
        }
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal(2.00, soda.Price);
        }
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal(2.50, soda.Price);
        }
    }
}
