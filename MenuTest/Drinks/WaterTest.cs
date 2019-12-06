using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        //Checks for correct default price.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water w = new Water();
            Assert.Equal(.10, w.Price);
        }

        //Checks for correct default calories.
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water w = new Water();
            Assert.Equal<uint>(0, w.Calories);
        }

        //Checks if new drink has ice. 
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water w = new Water();
            Assert.True(w.Ice);
        }

        //Checks if new drink has the right size.
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water w = new Water();
            Assert.Equal(Size.Small, w.Size);
        }

        //Checks if new drink has no lemon.
        [Fact]
        public void ShouldHaveNoDefaultLemon()
        {
            Water w = new Water();
            Assert.False(w.Lemon);
        }

        //Checks if new changing size changes price and calories correctly.
        [Fact]
        public void SizeChangeShouldCorrectlyChangePriceAndCalories()
        {
            Water w = new Water();

            w.Size = Size.Medium;
            Assert.Equal(.10, w.Price);
            Assert.Equal<uint>(0, w.Calories);

            w.Size = Size.Large;
            Assert.Equal(.10, w.Price);
            Assert.Equal<uint>(0, w.Calories);

            w.Size = Size.Small;
            Assert.Equal(.10, w.Price);
            Assert.Equal<uint>(0, w.Calories);
        }

        //Checks if hold ice function works.
        [Fact]
        public void HoldIceShouldHoldIce()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.False(w.Ice);
        }

        //Checks if add lemon function works.
        [Fact]
        public void AddLemonShouldAddLemon()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.True(w.Lemon);
            Assert.Contains("Lemon", w.Ingredients);
        }

        //Checks if all the ingredients are there.
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Water w = new Water();
            Assert.Contains("Water", w.Ingredients);
            Assert.Single(w.Ingredients);
        }
    }
}
