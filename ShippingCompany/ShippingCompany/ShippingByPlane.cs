using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCompany
{
    class ShippingByPlane : IShippingMedium
    {
        public void SendPackage(Client sender, Package package, Client receiver)
        {
            throw new NotImplementedException();
        }
    }
}
