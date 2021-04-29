using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            //hacer que el cliente envie el paquete y hacer envios por avion, por bus, etc.  tambien agregar precio
            //
            //
            //

            Client sender = new Sender() 
            { 
                IdCard = 1234,
                FirstNames = "Juan Pepe",
                SecondNames = "Gomez Romero",
                Address = "Juan Street #1111",
                Phone = 0395382
            };
            Client receiver = new Receiver()
            {
                FirstNames = "Rene Luis",
                SecondNames = "Gomez Jimenez",
                Phone = 0395382
            };

            Package package1 = new CommonPackage()
            {
                Subject = "I hope you like this gift",
                Sender = sender,
                Receiver = receiver
                //PackageTransporter = plane
            };


        }
    }
}
