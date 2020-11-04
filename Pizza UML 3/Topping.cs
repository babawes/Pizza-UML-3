using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_UML_3
{
    class Topping : MenuItem
    {
        public Topping(int number, string name, string description, double price, MenuType menuType, bool isVegan, bool isOrganic) : base(number, name, description, price, menuType, isVegan, isOrganic)
        {
        }
    }
}
