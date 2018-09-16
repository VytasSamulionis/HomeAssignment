using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeAssignment.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Rules.UnitTests
{
    [TestClass()]
    public class StudentRuleUnitTests
    {
        [TestMethod()]
        public void ValidateUnitTest()
        {
            StudentRule rule = new StudentRule();
            rule.isStudent = false;
            Assert.IsFalse(rule.Validate());
            rule.isStudent = true;
            Assert.IsTrue(rule.Validate());
        }
    }
}