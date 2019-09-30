using System;
using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.AbstractClasses;

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        /// <summary>
        /// Expected values/test vectors
        /// </summary>
        double[] prices = { 1.5, 2, 2.5 };
        uint[] calories = { 112, 156, 208 };
        enum expectedFlavors
        {
            Cola,
            Orange,
            Vanilla,
            Chocolate,
            RootBeer,
            Cherry,
            Lime
        }

        List<string> expectedIngredients = new List<string>()
        {
            "Water",
            "Natural Flavors",
            "Cane Sugar"
        };

        /// <summary>
        /// Verify the correct default price and calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAndCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            for (uint i = 0; i < 3; i++)
            {
                soda.Size = (Size)i;
                Assert.Equal(prices[ i ], soda.Price, 2);
                Assert.Equal(calories[i], soda.Calories);
            }
        }
        /// <summary>
        /// Verify the correct flavors 
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectFlavors()
        {
            Sodasaurus soda = new Sodasaurus();
            for ( uint i = 0; i < Enum.GetNames( typeof( expectedFlavors ) ).Length; i++)
            {
                soda.flavor = (SodasaurusFlavor)i;
                Assert.Equal( Enum.GetNames( typeof( expectedFlavors ) )[ i ]
                            , soda.flavor.ToString () );
            }
        }
        /// <summary>
        /// Verify ice is held correctly
        /// </summary>
        [Fact]
        public void HoldIceShouldSetFalse()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
            soda.HoldIce();
            Assert.False(soda.Ice);
        }
        /// <summary>
        /// Verify the correct ingredients
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal(expectedIngredients, soda.Ingredients);
        }
        /// <summary>
        /// Verify the default values are correct
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPriceAndCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal(prices[0], soda.Price);
            Assert.Equal(calories[0], soda.Calories);
            Assert.Equal(Size.Small, soda.Size);
        }
    }
}
