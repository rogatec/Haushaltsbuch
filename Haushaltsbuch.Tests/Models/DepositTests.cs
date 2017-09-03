using System;
using Haushaltsbuch.Models;
using NUnit.Framework;

namespace Haushaltsbuch.Tests.Models {
    [TestFixture]
    public class DepositTests {
        private Deposit _deposit;

        [SetUp]
        public void SetUp() {
            _deposit = new Deposit();
        }

        [Test]
        public void SetArguments_DepositHasAmount() {
            var args = new[] {"einzahlung", "400"};
            _deposit.SetArguments(args);

            Assert.That(_deposit.Amount, Is.EqualTo(400));
        }

        [Test]
        public void SetArguments_DepositHasDate() {
            var args = new[] {"einzahlung", "12.12.2006"};
            _deposit.SetArguments(args);

            Assert.That(_deposit.Date.ToShortDateString(), Is.EqualTo("12.12.2006"));
        }

        [Test]
        public void SetArguments_DepositHasDateAndAmount() {
            var args = new[] {"einzahlung", "12.12.2012", "400"};
            _deposit.SetArguments(args);

            Assert.That(_deposit.Date.ToShortDateString(), Is.EqualTo("12.12.2012"));
            Assert.That(_deposit.Amount, Is.EqualTo(400));
        }
    }
}