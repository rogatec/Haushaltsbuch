using System;
using Haushaltsbuch.Models;
using Haushaltsbuch.Services;

namespace Haushaltsbuch {
    public static class Program {
        public static void Main(string[] args) {
            var bookingObject = (Deposit) CommandLineService.GetBookingTypeObject(args);

            //TODO: remove debug output
            Console.WriteLine(bookingObject.Date.ToShortDateString());
            Console.WriteLine(bookingObject.Amount);
            Console.ReadLine();
        }
    }
}