using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_UML_3
{
    public class MenuCatalog : IMenuCatalog
    {
        private Dictionary<int,IMenuItem> _menuCatalog;
        public override int Count { get; }
        public override void Add(IMenuItem aMenuItems)
        {
            if(_menuCatalog.ContainsKey(aMenuItems.Number))
            {
                throw new MenuItemNumberExistsException("Menu number already in use");
            }
            _menuCatalog.Add(aMenuItems.Number,aMenuItems);
        }

        public override IMenuItem Search(int number)
        {
            IMenuItem result = null;
            if (_menuCatalog.ContainsKey(number)) { result = _menuCatalog[number]; }
            return result;
        }

        public override void Delete(int number)
        {
            _menuCatalog.Remove(number);
        }

        public override void PrintPizzasMenu()
        {
            foreach (IMenuItem menuItem in _menuCatalog.Values)
            {
                if (menuItem is Pizza)
                {
                    Console.WriteLine(menuItem.PrintInfo());
                }
            }
        }

        public override void PrintBeveragesMenu()
        {
            foreach (IMenuItem menuItem in _menuCatalog.Values)
            {
                if (menuItem is Beverage)
                {
                    Console.WriteLine(menuItem.PrintInfo());
                }
            }
        }

        public override void PrintToppingsMenu()
        {
            foreach (IMenuItem menuItem in _menuCatalog.Values)
            {
                if (menuItem is Topping)
                {
                    Console.WriteLine(menuItem.PrintInfo());
                }
            }
        }

        public override void Update(int number, IMenuItem theMenuItem)
        {
            _menuCatalog[number] = theMenuItem;
        }

        public override List<IMenuItem> FindAllVegan(MenuType type)
        {
            List<IMenuItem> result = new List<IMenuItem>();
            foreach (IMenuItem menuItem in _menuCatalog.Values)
            {
                if (menuItem.IsVegan==true && menuItem.Type== type)
                {
                    result.Add(menuItem);
                }
            }
            return result;
        }

        public override List<IMenuItem> FindAllOrganic(MenuType type)
        {
            List<IMenuItem> result = new List<IMenuItem>();
            foreach (IMenuItem menuItem in _menuCatalog.Values)
            {
                if (menuItem.IsOrganic == true && menuItem.Type == type)
                {
                    result.Add(menuItem);
                }
            }
            return result;
        }

        public override IMenuItem MostExpensiveMenuItem()
        {
            IMenuItem result = null;
            double priceResult = 0;
            foreach (IMenuItem menuItem in _menuCatalog.Values)
            {
                if (menuItem.Price>priceResult)
                {
                    priceResult = menuItem.Price;
                    result = menuItem;
                }
            }
            return result;
        }

        public MenuCatalog()
        {
            _menuCatalog = new Dictionary<int, IMenuItem>();
        }
    }
}
