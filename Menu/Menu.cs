/*  Menu.cs
*   Author: Zachary Nelson
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// class that defines the entire menu
    /// </summary>
    public class Menu
    {
        public List<IMenuItem> AvailableSides { get; } = new List<IMenuItem>()
        {
            new Fryceritops(),
            new MeteorMacAndCheese(),
            new MezzorellaSticks(),
            new Triceritots()
        };

        public List<IMenuItem> AvailableDrinks { get; } = new List<IMenuItem>()
        {
            new JurassicJava(),
            new Sodasaurus(),
            new Tyrannotea(),
            new Water()
        };

        public List<IMenuItem> AvailableEntrees { get; } = new List<IMenuItem>()
        {
            new Brontowurst(),
            new DinoNuggets(),
            new PrehistoricPBJ(),
            new PterodactylWings(),
            new SteakosaurusBurger(),
            new TRexKingBurger(),
            new VelociWrap()
        };

        public List<IMenuItem> AvailableCombos { get; } = new List<IMenuItem>()
        {
            new CretaceousCombo(new Brontowurst()),
            new CretaceousCombo(new DinoNuggets()),
            new CretaceousCombo(new PrehistoricPBJ()),
            new CretaceousCombo(new PterodactylWings()),
            new CretaceousCombo(new SteakosaurusBurger()),
            new CretaceousCombo(new TRexKingBurger()),
            new CretaceousCombo(new VelociWrap())
        };

        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
                items.AddRange(AvailableSides);
                items.AddRange(AvailableDrinks);
                items.AddRange(AvailableEntrees);
                items.AddRange(AvailableCombos);
                return items;
            }
        }

        /// <summary>
        /// overrides thes ToString method to print out the entire available menu
        /// </summary>
        /// <returns>entire menu</returns>
        public override string ToString()
        {
            string menu = "";
            foreach (IMenuItem item in AvailableMenuItems)
            {
                menu += $"{item} \n";
            }
            return menu;
        }
    }
}
