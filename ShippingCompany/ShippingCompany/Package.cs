using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCompany
{
    public abstract class Package
    {
        public string Subject { get; set; }
        public Client Sender { get; set; }
        public Client Receiver { get; set; }
        public ITransportMedium PackageTransporter { get; set; }


        public abstract void Send();
    }
}
