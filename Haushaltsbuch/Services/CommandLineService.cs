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
                    //TODO
                    break;
                case "einzahlung":
                    bookingType = new Deposit();
                    bookingType.SetArguments(args);
                    break;
                case "auszahlung":
                    //TODO
                    break;
                default:
                    throw new ArgumentException(
                        "first argument should be a valid booking type: uebersicht|einzahlung|auszahlung");
            }

            return bookingType;
        }
    }
}