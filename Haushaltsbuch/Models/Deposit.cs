using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Haushaltsbuch.Models {
    public class Deposit : IBookingType {
        public DateTime Date { get; private set; }

        public decimal Amount { get; private set; }

        public void SetArguments(string[] args) {
            if (args.Length <= 1) {
                Date = DateTime.Now;
            }
            else {
                if (DateTime.TryParseExact(args[1], "d", new CultureInfo("de-DE"), DateTimeStyles.None,
                    out DateTime givenDate)) {
                    Date = givenDate;
                    SetAmount(args, 2);
                }
                else {
                    Date = DateTime.Now;
                    SetAmount(args, 1);
                }
            }
        }

        private void SetAmount(IReadOnlyList<string> args, int position) {
            if (args.ElementAtOrDefault(position) != null) {
                Amount = Convert.ToDecimal(args[position]);
            }
        }
    }
}