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
            Pizza pizza1 = new Pizza(1,"Asdf","En pizza",100.1,MenuType.Pizza,false,true,false);
            //act
            menu.Add(pizza1);
            //assert
            Assert.AreEqual(menu.Search(1), pizza1);
        }
    }
}
