using System;

namespace Haushaltsbuch.ViewModels {
    public class AppViewModel {
        // deposit output
        public AppViewModel(decimal amount) {
            Console.WriteLine("Kassenbestand: " + amount + " EUR");
        }
    }
}