using DinoDiner.Menu.Drinks;
using Xunit;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        //Checks for correct default price.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Equal(.99, t.Price);
        }

        //Checks for correct default calories.
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Equal<uint>(8, t.Calories);
        }

        //Checks if new drink has ice. 
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.True(t.Ice);
        }

        //Checks if new drink has the right size.
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Equal(Size.Small, t.Size);
        }

        //Checks if new drink has no lemon.
        [Fact]
        public void ShouldHaveNoDefaultLemon()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.False(t.Lemon);
        }

        //Checks if new drink has no sweetener.
        [Fact]
        public void ShouldHaveNoDefaultSweet()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.False(t.Sweet);
        }

        //Checks if new changing size changes price and calories correctly.
        [Fact]
        public void SizeChangeShouldCorrectlyChangePriceAndCalories()
        {
            Tyrannotea t = new Tyrannotea();

            t.Size = Size.Medium;
            Assert.Equal(1.49, t.Price);
            Assert.Equal<uint>(16, t.Calories);

            t.Size = Size.Large;
            Assert.Equal(1.99, t.Price);
            Assert.Equal<uint>(32, t.Calories);

            t.Size = Size.Small;
            Assert.Equal(.99, t.Price);
            Assert.Equal<uint>(8, t.Calories);
        }

        //Checks if hold ice function works.
        [Fact]
        public void HoldIceShouldHoldIce()
        {
            Tyrannotea t = new Tyrannotea();
            t.HoldIce();
            Assert.False(t.Ice);
        }

        //Checks if add lemon function works.
        [Fact]
        public void AddLemonShouldAddLemon()
        {
            Tyrannotea t = new Tyrannotea();
            t.AddLemon();
            Assert.True(t.Lemon);
            Assert.Contains("Lemon", t.Ingredients);
        }

        //Checks if price and calorie count are correctly affected by sweetener.
        [Fact]
        public void SweetChangeShouldCorrectlyChangePriceAndCaloriesForEachSize()
        {
            Tyrannotea t = new Tyrannotea();

            t.Sweet = true;
            Assert.Equal<uint>(16, t.Calories);

            t.Sweet = false;
            Assert.Equal<uint>(8, t.Calories);

            t.Size = Size.Medium;
            t.Sweet = true;
            Assert.Equal<uint>(32, t.Calories);

            t.Sweet = false;
            Assert.Equal<uint>(16, t.Calories);

            t.Size = Size.Large;
            t.Sweet = true;
            Assert.Equal<uint>(64, t.Calories);

            t.Sweet = false;
            Assert.Equal<uint>(32, t.Calories);
        }

        //Checks if all the ingredients are there.
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Contains("Water", t.Ingredients);
            Assert.Contains("Tea", t.Ingredients);
            Assert.Equal(2, t.Ingredients.Count);
        }
    }
}
