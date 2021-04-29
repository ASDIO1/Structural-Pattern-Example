using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCompany
{
    class ShippingByTrain : IShippingMedium
    {
        public void SendPackage(Package package)
        {
            StringBuilder sendingMessage = new StringBuilder();
            sendingMessage.Append($"Sending package by TRAIN...");
            sendingMessage.Append($"\nfrom: {package.Sender.FirstNames}");
            sendingMessage.Append($"\nto: {package.Receiver.FirstNames}");
            sendingMessage.Append($"\nSubject: {package.Subject}");
            sendingMessage.Append($"\nTRAINS are only available for local shipping, so it will be fast");
            sendingMessage.Append($"\nThe TRAIN may take from 20 minutes to 2 hour until the package shipping is done");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(sendingMessage);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
