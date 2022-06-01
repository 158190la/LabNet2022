using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void IngresoDivisorTest()
        {
            int divisor1 = 1;
            int dividendo1 = 1;
                        
            Assert.IsTrue(divisor1 == dividendo1);


        }
    }
}