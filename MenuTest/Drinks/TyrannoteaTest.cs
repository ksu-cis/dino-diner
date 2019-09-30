using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;
namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        public void ShouldHaveCorrectDefaults()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal(0.99, tea.Price);
            Assert.True(tea.Calories == 8);
            Assert.True(tea.Ice == true);

        }
        [Fact]
        public void ShouldHaveCorrectValuesForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal(1.49, tea.Price);
            Assert.True(tea.Calories == 16);
            Assert.True(tea.Ice == true);
        }
        [Fact]
        public void ShouldHaveCorrectValuesForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal(1.99, tea.Price);
            Assert.True(tea.Calories == 32);
            Assert.True(tea.Ice == true);
        }
        [Fact]
        public void AddSweetener()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSugar();
            Assert.True(tea.Calories == 16);
            tea.Size = Size.Medium;
            tea.AddSugar();
            Assert.True(32 == tea.Calories);
            tea.Size = Size.Large;
            tea.AddSugar();
            Assert.True(64 == tea.Calories);
        }

        [Fact]
        public void HoldsIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.True(tea.Ice == false);
        }
        [Fact]
        public void AddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.lemon == true);
            Assert.Contains<string>("Lemon", tea.Ingredients);

        }
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Equal<int>(2, tea.Ingredients.Count);
            tea.AddSugar();

            Assert.Contains<string>("Cane Sugar", tea.Ingredients);
        }
    }
}
