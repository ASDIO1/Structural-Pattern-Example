using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCompany
{
    class CommonPackage : Package
    {
        public override void Send()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("COMMON PACKAGE:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("This is a COMMON package being sent normaly");
            PackageTransporter.SendPackage(this);
            Console.WriteLine("-------------------------------------------\n");
        }
    }
}
