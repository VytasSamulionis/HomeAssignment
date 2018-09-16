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
    public class MinIncomeRuleUnitTests
    {
        [TestMethod()]
        public void ValidateUnitTest()
        {
            MinIncomeRule rule = new MinIncomeRule(12001);
            rule.income = 12000;
            Assert.IsFalse(rule.Validate());
            rule.income = 12001;
            Assert.IsTrue(rule.Validate());
            rule.income = 12002;
            Assert.IsTrue(rule.Validate());
        }
    }
}