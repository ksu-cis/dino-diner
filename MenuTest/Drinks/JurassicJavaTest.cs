using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class JurassicJavaTest
    {
        //Checks for correct default price.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava j = new JurassicJava();
            Assert.Equal(.59, j.Price);
        }

        //Checks for correct default calories.
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava j = new JurassicJava();
            Assert.Equal<uint>(2, j.Calories);
        }

        //Checks if new drink has ice. 
        [Fact]
        public void ShouldHaveNoDefaultIce()
        {
            JurassicJava j = new JurassicJava();
            Assert.False(j.Ice);
        }

        //Checks if new drink has the right size.
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava j = new JurassicJava();
            Assert.Equal(Size.Small, j.Size);
        }

        //Checks if new drink has room for cream.
        [Fact]
        public void ShouldHaveNoDefaultRoomForCream()
        {
            JurassicJava j = new JurassicJava();
            Assert.False(j.RoomForCream);
        }

        //Checks if new changing size changes price and calories correctly.
        [Fact]
        public void SizeChangeShouldCorrectlyChangePriceAndCalories()
        {
            JurassicJava j = new JurassicJava();

            j.Size = Size.Medium;
            Assert.Equal(.99, j.Price);
            Assert.Equal<uint>(4, j.Calories);

            j.Size = Size.Large;
            Assert.Equal(1.49, j.Price);
            Assert.Equal<uint>(8, j.Calories);

            j.Size = Size.Small;
            Assert.Equal(.59, j.Price);
            Assert.Equal<uint>(2, j.Calories);
        }

        //Checks if add ice function works.
        [Fact]
        public void AddIceShouldAddIce()
        {
            JurassicJava j = new JurassicJava();
            j.AddIce();
            Assert.True(j.Ice);
        }

        //Checks if leave room for cream function works.
        [Fact]
        public void LeaveRoomForCreamShouldLeaveRoomForCream()
        {
            JurassicJava j = new JurassicJava();
            j.LeaveRoomForCream();
            Assert.True(j.RoomForCream);
        }

        //Checks if all the ingredients are there.
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurassicJava j = new JurassicJava();
            Assert.Contains("Water", j.Ingredients);
            Assert.Contains("Coffee", j.Ingredients);
            Assert.Equal(2, j.Ingredients.Count);
        }
    }
}
