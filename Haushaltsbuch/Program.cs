using Haushaltsbuch.Services;

namespace Haushaltsbuch {
    public static class Program {
        public static void Main(string[] args) {
            var bookingObject = CommandLineService.GetBookingTypeObject(args);
        }
    }
}