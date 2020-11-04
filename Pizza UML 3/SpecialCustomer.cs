using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_UML_3
{
    public class SpecialCustomer : ICustomer
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }

        public SpecialCustomer(int id, string name, string address, string phoneNo)
        {
            Id = id;
            Name = name;
            Address = address;
            PhoneNo = phoneNo;
        }
    }
}
