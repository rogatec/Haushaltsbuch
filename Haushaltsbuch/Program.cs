using System;
using Haushaltsbuch.Models;
using Haushaltsbuch.Services;
using Haushaltsbuch.ViewModels;

namespace Haushaltsbuch {
    public static class Program {
        public static void Main(string[] args) {
            var bookingObject = (Deposit) CommandLineService.GetBookingTypeObject(args);

            new AppViewModel(bookingObject.Amount);

            Console.ReadLine();
        }
    }
}