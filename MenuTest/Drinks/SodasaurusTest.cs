using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class SodaSuarusTest
    {
        //1. The ability to set each possible flavor
        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            Sodasuarus soda = new Sodasuarus();
            soda.Flavor = SodasuarusFlavor.Cherry;
            Assert.Equal<SodasuarusFlavor>(SodasuarusFlavor.Cherry, soda.Flavor);
        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            Sodasuarus soda = new Sodasuarus();
            soda.Flavor = SodasuarusFlavor.Orange;
            Assert.Equal<SodasuarusFlavor>(SodasuarusFlavor.Orange, soda.Flavor);
        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToVanilla()
        {
            Sodasuarus soda = new Sodasuarus();
            soda.Flavor = SodasuarusFlavor.Vanilla;
            Assert.Equal<SodasuarusFlavor>(SodasuarusFlavor.Vanilla, soda.Flavor);
        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToChocolate()
        {
            Sodasuarus soda = new Sodasuarus();
            soda.Flavor = SodasuarusFlavor.Chocolate;
            Assert.Equal<SodasuarusFlavor>(SodasuarusFlavor.Chocolate, soda.Flavor);
        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToRootbeer()
        {
            Sodasuarus soda = new Sodasuarus();
            soda.Flavor = SodasuarusFlavor.RootBeer;
            Assert.Equal<SodasuarusFlavor>(SodasuarusFlavor.RootBeer, soda.Flavor);
        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToLime()
        {
            Sodasuarus soda = new Sodasuarus();
            soda.Flavor = SodasuarusFlavor.Lime;
            Assert.Equal<SodasuarusFlavor>(SodasuarusFlavor.Lime, soda.Flavor);
        }

        //2. The correct default price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasuarus soda = new Sodasuarus();
            Assert.Equal<double>(1.50, soda.Price);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasuarus soda = new Sodasuarus();
            Assert.Equal<uint>(112, soda.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Sodasuarus soda = new Sodasuarus();
            Assert.True(soda.Ice);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Sodasuarus soda = new Sodasuarus();
            Assert.Equal<Size>(Size.Small, soda.Size);
        }

        //3. The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Sodasuarus soda = new Sodasuarus();
            soda.Size = Size.Small;
            Assert.Equal<double>(1.5, soda.Price);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Sodasuarus soda = new Sodasuarus();
            soda.Size = Size.Small;
            Assert.Equal<uint>(112, soda.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Sodasuarus soda = new Sodasuarus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2, soda.Price);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Sodasuarus soda = new Sodasuarus();
            soda.Size = Size.Medium;
            Assert.Equal<uint>(156, soda.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Sodasuarus soda = new Sodasuarus();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.5, soda.Price);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Sodasuarus soda = new Sodasuarus();
            soda.Size = Size.Large;
            Assert.Equal<uint>(208, soda.Calories);
        }

        //4. That invoking HoldIce() results in the Ice property being false.
        [Fact]
        public void ShouldNotHaveIce()
        {
            Sodasuarus soda = new Sodasuarus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Sodasuarus soda = new Sodasuarus();
            Assert.Contains<string>("Water", soda.Ingredients);
            Assert.Contains<string>("Natural Flavors", soda.Ingredients);
            Assert.Contains<string>("Cane Sugar", soda.Ingredients);
            Assert.Equal<int>(3, soda.Ingredients.Count);
        }


    }
}
