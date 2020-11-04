using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_UML_3
{
    public class CustomerCatalog : ICustomerCatalog
    {
        public int Count { get; }
        public void AddCustomer(ICustomer aCustomer)
        {
            throw new NotImplementedException();
        }

        public ICustomer LookupCustomerName(string name)
        {
            throw new NotImplementedException();
        }

        public ICustomer LookupCustomerID(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(string phoneNo, ICustomer theCustomer)
        {
            throw new NotImplementedException();
        }

        public void PrintCustomerList()
        {
            throw new NotImplementedException();
        }

        public CustomerCatalog(int count)
        {
            Count = count;
        }
    }
}
