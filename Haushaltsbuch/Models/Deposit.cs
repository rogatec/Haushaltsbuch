using System;
using System.Collections.Generic;

namespace Haushaltsbuch.Models {
    public class Deposit : IBookingType {
        public DateTime Date { get; set; }

        private decimal Amount { get; set; }

        public Deposit(IReadOnlyList<string> args) {
            //TODO: no args[1] has been given
            Date = GetBookingDate(args[1]);
        }

        public DateTime GetBookingDate(string dateArg) {
            //TODO: args[1] is not a datetime - handle
            return string.IsNullOrEmpty(dateArg) ? DateTime.Now : DateTime.ParseExact(dateArg, "d", null);
        }
    }
}