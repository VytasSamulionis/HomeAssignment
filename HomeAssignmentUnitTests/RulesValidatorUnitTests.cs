using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.UnitTests
{
    [TestClass()]
    public class RulesValidatorUnitTests
    {
        [TestMethod()]
        public void ValidateUnitTest()
        {
            Config config = new Config();
            config.Load("config.xml");
            // MaxAgeRule validation
            Assert.IsTrue(RulesValidator.Validate(config.Bundles["0"].Rules, 15, false, 0, null));
            Assert.IsFalse(RulesValidator.Validate(config.Bundles["0"].Rules, 18, false, 0, null));
            // MinAgeRule and StudentRule validation
            Assert.IsTrue(RulesValidator.Validate(config.Bundles["1"].Rules, 18, true, 0, null));
            Assert.IsTrue(RulesValidator.Validate(config.Bundles["1"].Rules, 25, true, 12000, null));
            Assert.IsFalse(RulesValidator.Validate(config.Bundles["1"].Rules, 17, true, 12000, null));
            Assert.IsFalse(RulesValidator.Validate(config.Bundles["1"].Rules, 18, false, 12000, null));
            // MinAgeRule and MinIncomeRule validation
            Assert.IsTrue(RulesValidator.Validate(config.Bundles["2"].Rules, 18, false, 5000, null));
            Assert.IsTrue(RulesValidator.Validate(config.Bundles["2"].Rules, 25, true, 5000, null));
            Assert.IsFalse(RulesValidator.Validate(config.Bundles["2"].Rules, 25, true, 0, null));
            Assert.IsFalse(RulesValidator.Validate(config.Bundles["2"].Rules, 17, false, 10000, null));
            // IncludeOneOfProductRule validation
            List<string> products = new List<string>();
            products.Add("2");
            products.Add("3");
            products.Add("4");
            Assert.IsTrue(RulesValidator.Validate(config.Products["3"].Rules, 22, false, 21000, products));
            products.RemoveAt(1);
            Assert.IsFalse (RulesValidator.Validate(config.Products["3"].Rules, 22, false, 21000, products));
        }
    }
}