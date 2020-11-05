using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizza_UML_3;

namespace PizzaUMLUnitTest
{
    [TestClass]
    public class MenuCatalogTest
    {
        [TestMethod]
        public void AddMenuItemTest()
        {
            //arrange
            MenuCatalog menu = new MenuCatalog();
            Pizza pizza1 = new Pizza(1,"Asdf","En pizza",100.1,false,true,false);
            //act
            menu.Add(pizza1);
            //assert
            Assert.AreEqual(menu.Search(1), pizza1);
        }
        [TestMethod]
        public void MenuNumberExistsTest()
        {
            //arrange
            MenuCatalog menu = new MenuCatalog();
            Pizza pizza1 = new Pizza(1, "Asdf", "En pizza", 100.1, false, true, false);
            Pizza pizza2 = new Pizza(1, "Esdf", "To pizza", 110.1, true, false, true);
            //act
            try { menu.Add(pizza1); } catch (MenuItemNumberExistsException e) { System.Console.WriteLine(e.Message); }
            try { menu.Add(pizza2); } catch (MenuItemNumberExistsException e) { System.Console.WriteLine(e.Message); }
            //assert
            Assert.AreEqual(menu.Search(1), pizza1);

        }
    }
}
