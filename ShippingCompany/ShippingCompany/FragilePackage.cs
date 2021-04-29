using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCompany
{
    class FragilePackage : Package
    {
        public override void Send()
        {
            throw new NotImplementedException();
        }
    }
}
