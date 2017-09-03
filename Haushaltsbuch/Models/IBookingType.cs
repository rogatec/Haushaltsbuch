using System;

namespace Haushaltsbuch.Models {
    public interface IBookingType {
        DateTime Date { get; }

        void SetArguments(string[] args);
    }
}