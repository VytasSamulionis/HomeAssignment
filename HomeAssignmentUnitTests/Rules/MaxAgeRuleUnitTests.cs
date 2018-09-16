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
    public class MaxAgeRuleUnitTests
    {
        [TestMethod()]
        public void ValidateUnitTest()
        {
            MaxAgeRule rule = new MaxAgeRule(17);
            rule.age = 16;
            Assert.IsTrue(rule.Validate());
            rule.age = 17;
            Assert.IsTrue(rule.Validate());
            rule.age = 18;
            Assert.IsFalse(rule.Validate());
        }
    }
}