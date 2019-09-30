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
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal(SodasaurusFlavor.Chocolate, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal(SodasaurusFlavor.Lime, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal(SodasaurusFlavor.Cola, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal(SodasaurusFlavor.Orange, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal(SodasaurusFlavor.Vanilla, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal(SodasaurusFlavor.RootBeer, soda.Flavor);
        }
        [Fact]
        public void ShouldHaveCorrectDefaults()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal(1.50, soda.Price);
            Assert.True(soda.Calories == 112);
            Assert.True(soda.Ice == true);
        }
        [Fact]
        public void ShouldHaveCorrectValuesForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal(2.00, soda.Price);
            Assert.True(soda.Calories == 156);
            Assert.True(soda.Ice == true);
        }
        [Fact]
        public void ShouldHaveCorrectValuesForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal(2.50, soda.Price);
            Assert.True(soda.Calories == 208);
            Assert.True(soda.Ice == true);
        }
        [Fact]
        public void HoldsIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.True(soda.Ice == false);
        }
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Contains<string>("Water", soda.Ingredients);
            Assert.Contains<string>("Cane Sugar", soda.Ingredients);
            Assert.Contains<string>("Natural Flavors", soda.Ingredients);
            Assert.Equal<int>(3, soda.Ingredients.Count);
        }
    }
}
