using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_UML_3
{
    public class Store
    {
        public void StoreCode()
        {
            Pizza pizzaEt = new Pizza(1, "Skinke pizza", "En pizza med tomat, ost og skinke", 70.0, false, true, false);
            Pizza pizzaTo = new Pizza(2, "Pepperoni pizza", "En pizza med tomat ost og pepperoni", 70.0, false, false, false);
            Beverage beverageEt = new Beverage(3, "Vand", "En flaske vand", 10.0, true, true, false);
            Beverage beverageTo = new Beverage(4, "Øl", "Et glas øl", 25.0, true, true, true);
            MenuCatalog menuCatalog = new MenuCatalog();
            try { menuCatalog.Add(pizzaEt); } catch (MenuItemNumberExistsException e) { Console.WriteLine(e.Message); }
            try { menuCatalog.Add(pizzaTo); ; } catch (MenuItemNumberExistsException e) { Console.WriteLine(e.Message); }
            try { menuCatalog.Add(beverageEt); ; } catch (MenuItemNumberExistsException e) { Console.WriteLine(e.Message); }
            try { menuCatalog.Add(beverageEt); } catch (MenuItemNumberExistsException e) { Console.WriteLine(e.Message); }
            Console.WriteLine(menuCatalog.Search(2).PrintInfo()); //Test af søgefunktionen
            menuCatalog.Delete(2);
            menuCatalog.PrintPizzasMenu();
            menuCatalog.PrintBeveragesMenu();
            menuCatalog.Update(1, pizzaTo);
            Console.WriteLine(menuCatalog.MostExpensiveMenuItem().PrintInfo());

        }
    }
}
