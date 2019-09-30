using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        public void ShouldHaveCorrectDefaults()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal(.59, java.Price);
            Assert.True(java.Calories == 2);
            Assert.True(java.Ice == true);
            Assert.True(java._decaf == false);
            Assert.True(java._roomForCream == false);

        }
        [Fact]
        public void ShouldHaveCorrectValuesForMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            Assert.Equal(.99, java.Price);
            Assert.True(java.Calories == 4);
            Assert.True(java.Ice == false);
        }
        [Fact]
        public void ShouldHaveCorrectValuesForLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal(1.49, java.Price);
            Assert.True(java.Calories == 8);
            Assert.True(java.Ice == false);
        }
        [Fact]
        public void AddIce()
        {
            JurrasicJava java = new JurrasicJava();
            java.AddIce();
            Assert.True(java.Ice == true);
        }
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
            Assert.Equal<int>(2, java.Ingredients.Count);
        }
        [Fact]
        public void IsDecaf()
        {
            JurrasicJava java = new JurrasicJava();
            java.MakeDecaf();
            Assert.True(java._decaf == true);
        }
        [Fact]
        public void HasRoomForCream()
        {
            JurrasicJava java = new JurrasicJava();
            java.RoomForCream();
            Assert.True(java._roomForCream == true);
        }
    }
}
