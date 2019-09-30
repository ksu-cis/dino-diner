using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.AbstractClasses;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        /// <summary>
        /// Expected lists
        /// </summary>
        double[] prices = { .59, .99, 1.49 };
        uint[] calories = { 2, 4, 8 };
        List<string> expectedIngredients = new List<string>()
        {
            "Water",
            "Coffee",
        };

        /// <summary>
        /// Verify the object has the correct default properties
        /// </summary>
        [Fact]
        public void CorrectDefaultProperties()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.Equal(prices[0], jj.Price);
            Assert.Equal(calories[0], jj.Calories);
            Assert.Equal(Size.Small, jj.Size);
            Assert.False(jj.SpaceForCream);
            Assert.False(jj.Ice);
            Assert.False(jj.Decaf);
        }

        /// <summary>
        /// Verify the price and calories are correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAndCalories()
        {
            JurrasicJava jj = new JurrasicJava();
            for (uint i = 0; i < 3; i++)
            {
                jj.Size = (Size)i;
                Assert.Equal(prices[i], jj.Price, 2);
                Assert.Equal(calories[i], jj.Calories);
            }
        }
        /// <summary>
        /// Verify adding ice works correctly 
        /// </summary>
        [Fact]
        public void AddIceShouldSetTrue()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.False(jj.Ice);
            jj.AddIce();
            Assert.True(jj.Ice);
        }
        /// <summary>
        /// Verify space can be left for cream
        /// </summary>
        [Fact]
        public void LeaveSpaceForCreamShouldSetTrue()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.False(jj.SpaceForCream);
            jj.LeaveRoomForCream();
            Assert.True(jj.SpaceForCream);
        }
        /// <summary>
        /// Verify the ingredients are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurrasicJava jj = new JurrasicJava();
            Assert.Equal(expectedIngredients, jj.Ingredients);
        }
    }
}
