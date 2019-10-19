using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class JurassicJavaTest
    {
        //1. The correct default price, calories, ice, size, and SpaceForCream properties.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<double>(.59, java.Price);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Ice);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }
        [Fact]
        public void ShouldHaveDefaultSpaceForCream()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.RoomForCream);
        }

        //2. The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Small;
            Assert.Equal<double>(.59, java.Price);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(.99, java.Price);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }

        //3. That invoking AddIce() results in the Ice property being true
        [Fact]
        public void ShouldHaveIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }
        //4. That invoking LeaveSpaceForCream() results in the SpaceForCream property being true.
        [Fact]
        public void ShouldHaveRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }

        [Fact]
        public void ShouldHaveDecaf()
        {
            JurassicJava java = new JurassicJava();
            java.MakeDecaf();
            Assert.True(java.Decaf);
        }

        //5. The correct ingredients are given.

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurassicJava java = new JurassicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
            Assert.Equal<int>(2, java.Ingredients.Count);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            JurassicJava java = new JurassicJava();
            Assert.Empty(java.Special);
        }

        [Fact]
        public void AddIceShouldAddToSpecial()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.Collection<string>(java.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            });
        }

        [Fact]
        public void LeaveRoomForCreamShouldAddToSpecial()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.Collection<string>(java.Special, item =>
            {
                Assert.Equal("Leave Room for Cream", item);
            });
        }

        [Fact]
        public void HoldAllShouldAddAllToSpecial()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            java.LeaveRoomForCream();
            Assert.Collection<string>(java.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            },
            item =>
            {
                Assert.Equal("Leave Room for Cream", item);
            });
        }

        [Fact]
        public void AddiceShouldNotifySpecialChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.AddIce();
            });
        }

        [Fact]
        public void HoldingLeaveRoomForCreamShouldNotifySpecialChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.LeaveRoomForCream();
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifyPriceChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Price", () =>
            {
                java.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldNotifyCaloriesChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Calories", () =>
            {
                java.Size = Size.Large;
            });
        }

    }
}
