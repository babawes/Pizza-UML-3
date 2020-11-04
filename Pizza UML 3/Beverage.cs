using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_UML_3
{
    class Beverage : MenuItem
    {
        private bool _alcohol;

        public bool Alcohol
        {
            get { return _alcohol; }
            set { _alcohol = value; }
        }

        public Beverage(int number, string name, string description, double price, MenuType menuType, bool isVegan, bool isOrganic, bool alcohol) : base(number, name, description, price, menuType, isVegan, isOrganic)
        {
            _alcohol = alcohol;
        }
        public override string PrintInfo()
        {   // Denne metode printer formateret ud.
            return
                $"Number {_number} \tName {_name} \n\tDescription {_description} Price {_price} MenuType {_menuType} IsVegan {_isVegan} IsOrganic {_isOrganic} Alcohol {_alcohol}";
        }
    }
}
