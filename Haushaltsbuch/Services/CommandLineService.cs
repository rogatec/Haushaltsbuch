using System;
using Haushaltsbuch.Models;

namespace Haushaltsbuch.Services {
    public static class CommandLineService {
        public static IBookingType GetBookingTypeObject(string[] args) {
            IBookingType bookingType = null;

            if (args.Length == 0) {
                throw new ArgumentException("at least one argument must be given: uebersicht|einzahlung|auszahlung");
            }

            // first argument is the booking type
            switch (args[0]) {
                case "uebersicht":
                    //TODO implementation
                    break;
                case "einzahlung":
                    bookingType = new Deposit();
                    bookingType.SetArguments(args);
                    //TODO save deposit
                    //TODO write to json file
                    break;
                case "auszahlung":
                    //TODO implementation
                    break;
                default:
                    throw new ArgumentException(
                        "first argument should be a valid booking type: uebersicht|einzahlung|auszahlung");
            }

            return bookingType;
        }
    }
}