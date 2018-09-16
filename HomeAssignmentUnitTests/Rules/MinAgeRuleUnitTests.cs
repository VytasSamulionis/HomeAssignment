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
    public class MinAgeRuleUnitTests
    {
        [TestMethod()]
        public void ValidateUnitTest()
        {
            MinAgeRule rule = new MinAgeRule(18);
            rule.age = 19;
            Assert.IsTrue(rule.Validate());
            rule.age = 18;
            Assert.IsTrue(rule.Validate());
            rule.age = 17;
            Assert.IsFalse(rule.Validate());
        }
    }
}