using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        //Checks if flavor setting works.
        [Fact]
        public void ShouldBeAbleToCorrectlySetFlavor()
        {
            Sodasaurus s = new Sodasaurus();
            foreach (SodasaurusFlavor f in (SodasaurusFlavor[]) System.Enum.GetValues(typeof(SodasaurusFlavor)))
            {
                s.Flavor = f;
                Assert.Equal(f, s.Flavor);
            }
        }

        //Checks for correct default price.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Equal(1.5, s.Price);
        }

        //Checks for correct default calories.
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Equal<uint>(112, s.Calories);
        }

        //Checks if new drink has ice. 
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.True(s.Ice);
        }

        //Checks if new drink has the right size.
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Equal(Size.Small, s.Size);
        }

        //Checks if new changing size changes price and calories correctly.
        [Fact]
        public void SizeChangeShouldCorrectlyChangePriceAndCalories()
        {
            Sodasaurus s = new Sodasaurus();

            s.Size = Size.Medium;
            Assert.Equal(2, s.Price);
            Assert.Equal<uint>(156, s.Calories);

            s.Size = Size.Large;
            Assert.Equal(2.5, s.Price);
            Assert.Equal<uint>(208, s.Calories);

            s.Size = Size.Small;
            Assert.Equal(1.5, s.Price);
            Assert.Equal<uint>(112, s.Calories);
        }

        //Checks if hold ice function works.
        [Fact]
        public void HoldIceShouldHoldIce()
        {
            Sodasaurus s = new Sodasaurus();
            s.HoldIce();
            Assert.False(s.Ice);
        }

        //Checks if all the ingredients are there.
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Contains("Water", s.Ingredients);
            Assert.Contains("Natural Flavors", s.Ingredients);
            Assert.Contains("Cane Sugar", s.Ingredients);
            Assert.Equal(3, s.Ingredients.Count);
        }
    }
}
