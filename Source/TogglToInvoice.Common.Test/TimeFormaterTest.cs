// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TimeFormaterTest.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.Common.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TogglToInvoice.Common.Services;

    [TestClass]
    public class TimeFormaterTest
    {
        [TestMethod]
        public void Cela_Hodnota_se_Nezaokrouhli()
        {
            var formater = new TimeFormaterService();
            var hod = formater.FormatToNerestQuarterHour(7200);
            Assert.AreEqual(2, hod);
        }

        [TestMethod]
        public void Hodnota_se_Na_Cela()
        {
            var formater = new TimeFormaterService();
            var hod = formater.FormatToNerestQuarterHour(7200 + 3000);
            Assert.AreEqual(3, hod);
        }

        [TestMethod]
        public void Hodnota_se_Na_Ctvrt()
        {
            var formater = new TimeFormaterService();
            var hod = formater.FormatToNerestQuarterHour(7200 + 600);
            Assert.AreEqual(2.25, hod);
        }

        [TestMethod]
        public void Hodnota_se_Na_Pul()
        {
            var formater = new TimeFormaterService();
            var hod = formater.FormatToNerestQuarterHour(7200 + 1200);
            Assert.AreEqual(2.5, hod);
        }

        [TestMethod]
        public void Hodnota_se_Na_TriCtvrte()
        {
            var formater = new TimeFormaterService();
            var hod = formater.FormatToNerestQuarterHour(7200 + 2400);
            Assert.AreEqual(2.75, hod);
        }
    }
}