using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeAssignment.Rules;

namespace HomeAssignment.UnitTests
{
    [TestClass()]
    public class ConfigUnitTests
    {
        [TestMethod()]
        public void LoadUnitTest()
        {
            Config config = new Config();
            config.Load("config.xml");
            Assert.AreEqual(3, config.bundles.Count);
            Assert.AreEqual(4, config.products.Count);

            Bundle bundle;

            Assert.IsTrue(config.bundles.TryGetValue("0", out bundle));
            Assert.AreEqual("Junior Saver", bundle.name);
            Assert.AreEqual(1, bundle.products.Count);
            Assert.AreEqual("2", bundle.products[0]);
            Assert.AreEqual(1, bundle.rules.Count);
            Assert.AreEqual(RuleType.MaxAge, bundle.rules[0].type);
            Assert.AreEqual(0, bundle.value);

            Assert.IsTrue(config.bundles.TryGetValue("1", out bundle));
            Assert.AreEqual("Student", bundle.name);
            Assert.AreEqual(3, bundle.products.Count);
            Assert.AreEqual("3", bundle.products[0]);
            Assert.AreEqual("4", bundle.products[1]);
            Assert.AreEqual("5", bundle.products[2]);
            Assert.AreEqual(2, bundle.rules.Count);
            Assert.AreEqual(RuleType.MinAge, bundle.rules[0].type);
            Assert.AreEqual(RuleType.Student, bundle.rules[1].type);
            Assert.AreEqual(0, bundle.value);

            Assert.IsTrue(config.bundles.TryGetValue("2", out bundle));
            Assert.AreEqual("Classic", bundle.name);
            Assert.AreEqual(2, bundle.products.Count);
            Assert.AreEqual("0", bundle.products[0]);
            Assert.AreEqual("4", bundle.products[1]);
            Assert.AreEqual(2, bundle.rules.Count);
            Assert.AreEqual(RuleType.MinAge, bundle.rules[0].type);
            Assert.AreEqual(RuleType.MinIncome, bundle.rules[1].type);
            Assert.AreEqual(1, bundle.value);

            Product product;

            Assert.IsTrue(config.products.TryGetValue("0", out product));
            Assert.AreEqual("Current Account", product.name);
            Assert.IsTrue(product.isAccount);
            Assert.AreEqual(2, product.rules.Count);
            Assert.AreEqual(RuleType.MinAge, product.rules[0].type);
            Assert.AreEqual(RuleType.MinIncome, product.rules[1].type);

            Assert.IsTrue(config.products.TryGetValue("1", out product));
            Assert.AreEqual("Junior Saver Account", product.name);
            Assert.IsTrue(product.isAccount);
            Assert.AreEqual(1, product.rules.Count);
            Assert.AreEqual(RuleType.MaxAge, product.rules[0].type);

            Assert.IsTrue(config.products.TryGetValue("2", out product));
            Assert.AreEqual("Student Account", product.name);
            Assert.IsTrue(product.isAccount);
            Assert.AreEqual(2, product.rules.Count);
            Assert.AreEqual(RuleType.MinAge, product.rules[0].type);
            Assert.AreEqual(RuleType.Student, product.rules[1].type);

            Assert.IsTrue(config.products.TryGetValue("3", out product));
            Assert.AreEqual("Debit Card", product.name);
            Assert.IsFalse(product.isAccount);
            Assert.AreEqual(1, product.rules.Count);
            Assert.AreEqual(RuleType.IncludeOneOfProducts, product.rules[0].type);
        }
    }
}