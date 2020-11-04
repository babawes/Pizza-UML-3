using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_UML_3
{
    public abstract class IMenuCatalog
    {
        public abstract int Count { get; }
        public abstract void Add(IMenuItem aMenuItems);
        public abstract IMenuItem Search(int number);
        public abstract void Delete(int number);
        public abstract void PrintPizzasMenu();
        public abstract void PrintBeveragesMenu();
        public abstract void PrintToppingsMenu();
        public abstract void Update(int number, IMenuItem theMenuItem);
        public abstract List<IMenuItem> FindAllVegan(MenuType type);
        public abstract List<IMenuItem> FindAllOrganic(MenuType type);
        public abstract IMenuItem MostExpensiveMenuItem();
    }
}
