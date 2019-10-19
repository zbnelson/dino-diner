using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class SteakosaurusBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal(5.15, sb.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal<uint>(621, sb.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            List<string> ingredients = sb.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Steakburger Pattie", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", sb.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", sb.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", sb.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", sb.Ingredients);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Empty(sb.Special);
        }

        [Fact]
        public void HoldBunShouldAddToSpecial()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.Collection<string>(sb.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            });
        }

        [Fact]
        public void HoldPickleShouldAddToSpecial()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.Collection<string>(sb.Special, item =>
            {
                Assert.Equal("Hold Pickles", item);
            });
        }

        [Fact]
        public void HoldKethcupShouldAddToSpecial()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.Collection<string>(sb.Special, item =>
            {
                Assert.Equal("Hold Ketchup", item);
            });
        }

        [Fact]
        public void HoldMustardShouldAddToSpecial()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.Collection<string>(sb.Special, item =>
            {
                Assert.Equal("Hold Mustard", item);
            });
        }

        [Fact]
        public void HoldAllShouldAddAllToSpecial()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            sb.HoldPickle();
            sb.HoldKetchup();
            sb.HoldMustard();
            Assert.Collection<string>(sb.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            },
            item =>
            {
                Assert.Equal("Hold Pickles", item);
            },
            item =>
            {
                Assert.Equal("Hold Ketchup", item);
            },
            item =>
            {
                Assert.Equal("Hold Mustard", item);
            });
        }

        [Fact]
        public void HoldingBunShouldNotifySpecialChange()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldBun();
            });
        }

        [Fact]
        public void HoldingPickleShouldNotifySpecialChange()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldPickle();
            });
        }

        [Fact]
        public void HoldingKetchupShouldNotifySpecialChange()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldKetchup();
            });
        }

        [Fact]
        public void HoldingMustardShouldNotifySpecialChange()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldMustard();
            });
        }
    }

}
