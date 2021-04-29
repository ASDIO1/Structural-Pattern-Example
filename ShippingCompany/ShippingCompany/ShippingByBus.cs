using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCompany
{
    class ShippingByBus : IShippingMedium
    {
        public void SendPackage(Package package)
        {
            StringBuilder sendingMessage = new StringBuilder();
            sendingMessage.Append($"Sending package by BUS...");
            sendingMessage.Append($"\nfrom: {package.Sender.FirstNames}");
            sendingMessage.Append($"\nto: {package.Receiver.FirstNames}");
            sendingMessage.Append($"\nSubject: {package.Subject}");
            sendingMessage.Append($"\nThe BUS may take from 7 to 10 hours until the package shipping is done");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(sendingMessage);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
