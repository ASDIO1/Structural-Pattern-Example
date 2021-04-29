using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCompany
{
    class ShippingByPlane : IShippingMedium
    {
        public void SendPackage(Package package)
        {
            StringBuilder sendingMessage = new StringBuilder();
            sendingMessage.Append($"Sending package by PLANE...");
            sendingMessage.Append($"\nfrom: {package.Sender.FirstNames}");
            sendingMessage.Append($"\nto: {package.Receiver.FirstNames}");
            sendingMessage.Append($"\nSubject: {package.Subject}");
            sendingMessage.Append($"\nThe PLANE may take from 30 minutes to 4 hours until the package shipping is done");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(sendingMessage);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
