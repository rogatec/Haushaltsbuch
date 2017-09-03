using System;
using System.IO;
using Haushaltsbuch.ViewModels;
using NUnit.Framework;

namespace Haushaltsbuch.Tests.ViewModels
{
    [TestFixture]
    public class AppViewModelTests
    {
        [Test]
        public void Ctor_DepositOutput() {
            const int amount = 400;

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                new AppViewModel(amount);

                var expected = $"Kassenbestand: {400} EUR{Environment.NewLine}";
                Assert.That(expected, Is.EqualTo(sw.ToString()));
            }
        }
    }
}