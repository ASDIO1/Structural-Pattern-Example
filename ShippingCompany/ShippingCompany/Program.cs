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
            // 1 Instantiating Shipping Mediums
            IShippingMedium plane = new ShippingByPlane();
            IShippingMedium bus = new ShippingByBus();
            IShippingMedium train = new ShippingByTrain();

            // 2 Instantiating a Sender client & a Receiver client
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

            // 3 Instantiating and Sending Package #1 (common)
            Package package1 = new CommonPackage()
            {
                Subject = "I hope you like this gift",
                Sender = sender,
                Receiver = receiver
            };
            package1.PackageTransporter = bus;
            package1.Send();

            package1.PackageTransporter = plane;
            package1.Send();

            package1.PackageTransporter = train;
            package1.Send();

            // 4 Instantiating and Sending Package #2 (fragile)
            Package package2 = new FragilePackage()
            {
                Subject = "Happy holidays",
                Sender = sender,
                Receiver = receiver
            };
            package2.PackageTransporter = plane;
            package2.Send();

            package2.PackageTransporter = bus;
            package2.Send();

            Console.ReadKey();
        }
    }
}
