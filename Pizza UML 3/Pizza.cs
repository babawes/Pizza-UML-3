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

        public Pizza(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool deepPan) : base(number, name, description, price, type, isVegan, isOrganic)
        {
            _deepPan = deepPan;

        }
    }
}
