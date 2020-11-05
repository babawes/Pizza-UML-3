using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_UML_3
{
    public class Pizza : MenuItem
    {
        private bool _deepPan;

        public bool DeepPan
        {
            get { return _deepPan; }
            set { _deepPan = value; }
        }

        public Pizza(int number, string name, string description, double price, bool isVegan, bool isOrganic, bool deepPan) : base(number, name, description, price, isVegan, isOrganic)
        {
            _deepPan = deepPan;
            _menuType = MenuType.Pizza;

        }
        public override string PrintInfo()
        {   // Denne metode printer formateret ud.
            return
                $"Number {_number} \tName {_name} \n\tDescription {_description} Price {_price} MenuType {_menuType} IsVegan {_isVegan} IsOrganic {_isOrganic} Deeppan {_deepPan}";
        }
    }
}
