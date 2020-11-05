using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_UML_3
{
    public class MenuItemNumberExistsException : Exception
    {
        public MenuItemNumberExistsException()
        {
                
        }
        public MenuItemNumberExistsException(string message):base(message)
        {
        
        }
    }
}
