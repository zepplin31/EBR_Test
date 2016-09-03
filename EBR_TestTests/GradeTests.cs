using Microsoft.VisualStudio.TestTools.UnitTesting;
using EBR_Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBR_Test.Tests
{
    [TestClass()]
    public class GradeTests
    {
        [TestMethod()]
        public void CompareToTest_Null()
        {
            Grade m = new Grade("HARTLEY", "JR", 55);
            Grade n = null;
            Assert.AreEqual(1, m.CompareTo(n));
        }

        [TestMethod()]
        public void CompareToTest_FirstName()
        {
            Grade m = new Grade("HARTLEY", "JR", 55);
            Grade n = new Grade("HARTLEY", "JS", 55);
            Assert.AreEqual(-1, m.CompareTo(n));
        }

    }
}