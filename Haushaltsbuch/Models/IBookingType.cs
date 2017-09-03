using System;

namespace Haushaltsbuch.Models {
    public interface IBookingType {
        DateTime Date { get; set; }

        DateTime GetBookingDate(string dateArg);
    }
}