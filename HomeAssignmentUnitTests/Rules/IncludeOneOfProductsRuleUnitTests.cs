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
    public class IncludeOneOfProductsRuleUnitTests
    {
        [TestMethod()]
        public void ValidateUnitTest()
        {
            List<string> list = new List<string>();
            list.Add("0");
            list.Add("1");
            list.Add("3");
            IncludeOneOfProductsRule rule = new IncludeOneOfProductsRule(list);
            List<string> products = new List<string>();
            products.Add("2");
            products.Add("3");
            products.Add("4");
            rule.products = products;
            Assert.IsTrue(rule.Validate());
            rule.products.RemoveAt(1);
            Assert.IsFalse(rule.Validate());
        }
    }
}