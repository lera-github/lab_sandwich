using Microsoft.VisualStudio.TestTools.UnitTesting;
using App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace App.Tests
{
    /// <summary>
    /// Тестирование
    /// </summary>
    [TestClass()]
    public class AmountCalculatorTests
    {
        /// <summary>
        /// Валидный тест
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="Colbasa"></param>
        /// <param name="Hleb"></param>
        [TestMethod()]
        [DataRow(20, 300, 500)]
        [DataRow(60, 4000, 1500)]
        [DataRow(80, 3000, 2000)]

        public void GetAmountTest(double amount, double Colbasa, double Hleb)
        {
            var _amount = AmountCalculator.GetAmount(Colbasa, Hleb);
            
            Assert.AreEqual(amount, _amount);
        }

        /// <summary>
        /// Невалидный тест
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="Colbasa"></param>
        /// <param name="Hleb"></param>
        [TestMethod()]
        [DataRow(20, 300, 5000)]
        [DataRow(60, 4000, 15000)]
        [DataRow(80, 3000, 20000)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void GetAmountInvalidTest(double amount, double Colbasa, double Hleb)
        {
            var _amount = AmountCalculator.GetAmount(Colbasa, Hleb);

            Assert.AreEqual(amount, _amount);
        }
    }
}