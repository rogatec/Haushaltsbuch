using System;
using Haushaltsbuch.Services;
using NUnit.Framework;

namespace Haushaltsbuch.Tests.Services {
    [TestFixture]
    public class CommandLineServiceTests {
        [Test]
        public void GetBookingTypeObject_ReturnsObjectWithGivenDate() {
            var args = new string[] {"einzahlung", "12.12.2012", "c", "d"};

            var sut = CommandLineService.GetBookingTypeObject(args);

            Assert.That(sut.Date.ToShortDateString(), Is.EqualTo("12.12.2012"));
        }

        [Test]
        public void GetBookingTypeObject_ReturnsObjectWithCurrentDate() {
            var args = new string[] {"einzahlung", ""};

            var sut = CommandLineService.GetBookingTypeObject(args);

            Assert.That(sut.Date.ToShortDateString(), Is.EqualTo(DateTime.Now.ToShortDateString()));
        }

        [Test]
        public void GetBookingTypeObject_ThrowsArgumentExceptionIfNoArgs() {
            var args = new string[] { };

            var ex = Assert.Throws<ArgumentException>(() => CommandLineService.GetBookingTypeObject(args));

            Assert.That(ex.Message,
                Is.EqualTo("at least one argument must be given: uebersicht|einzahlung|auszahlung"));
        }

        [Test]
        public void GetBookingTypeObject_ThrowsArgumentExceptionIfWrongFirstArg() {
            var args = new string[] {"a"};

            var ex = Assert.Throws<ArgumentException>(() => CommandLineService.GetBookingTypeObject(args));

            Assert.That(ex.Message,
                Is.EqualTo("first argument should be a valid booking type: uebersicht|einzahlung|auszahlung"));
        }
    }
}