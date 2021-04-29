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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("FRAGILE PACKAGE:");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("This is a FRAGILE package being sent carefully");
            PackageTransporter.SendPackage(this);
            Console.WriteLine("-------------------------------------------\n");
        }
    }
}
