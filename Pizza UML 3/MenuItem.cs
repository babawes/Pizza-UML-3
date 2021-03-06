﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_UML_3
{
    public abstract class MenuItem : IMenuItem
    {
        protected int _number;
        public int Number
        {
            get { return _number; }
        }

        protected string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        protected string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        protected double _price;
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        protected MenuType _menuType;
        public MenuType Type
        {
            get { return _menuType; }
            set { _menuType = value; }
        }

        protected bool _isVegan;
        public bool IsVegan
        {
            get { return _isVegan; }
            set { _isVegan = value; }
        }

        protected bool _isOrganic;

        public bool IsOrganic
        {
            get { return _isOrganic; }
            set { _isOrganic = value; }
        }

        public virtual string PrintInfo()
        {   // Denne metode printer formateret ud.
            return
                $"Number {_number} \tName {_name} \n\tDescription {_description} Price {_price} MenuType {_menuType} IsVegan {_isVegan} IsOrganic {_isOrganic}";
        }

        public MenuItem(int number, string name, string description, double price, bool isVegan, bool isOrganic)
        {
            _number = number;
            _name = name;
            _description = description;
            _price = price;
            _isVegan = isVegan;
            _isOrganic = isOrganic;
        }
        public override string ToString()
        {
            return
                $"Number {_number} Name {_name} Description {_description} Price {_price} MenuType {_menuType} IsVegan {_isVegan} IsOrganic {_isOrganic}";
        }
    }

}
