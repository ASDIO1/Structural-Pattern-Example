using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCompany
{
    public interface ITransportMedium
    {// ABSTRAER TODOS ESTOS DATOS EN UNA CLASE PERSONA O ALGO ASI
        void TransportPackage(Client sender, Client receiver);
    }
}
