using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        public void ShouldHaveCorrectDefaults()
        {
            Water water = new Water();
            Assert.Equal(.1, water.Price);
            Assert.True(water.Calories == 0);
            Assert.True(water.Ice == true);
            Assert.True(water._lemon == false);
        }
        [Fact]
        public void ShouldHaveCorrectValuesForMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal(.1, water.Price);
            Assert.True(water.Calories == 0);
            Assert.True(water.Ice == true);
            Assert.True(water._lemon == false);
        }
        [Fact]
        public void ShouldHaveCorrectValuesForLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal(.1, water.Price);
            Assert.True(water.Calories == 0);
            Assert.True(water.Ice == true);
            Assert.True(water._lemon == false);
        }
        [Fact]
        public void HoldsIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.True(water.Ice == false);
        }
        [Fact]
        public void AddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water._lemon == true);
        }
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Water water = new Water();
            Assert.Contains<string>("Water", water.Ingredients);

            water.AddLemon();
            Assert.True(water._lemon == true);
            Assert.Contains<string>("Water", water.Ingredients);
            Assert.Contains<string>("Lemon", water.Ingredients);
            Assert.Equal<int>(2, water.Ingredients.Count);
        }
    }
}
