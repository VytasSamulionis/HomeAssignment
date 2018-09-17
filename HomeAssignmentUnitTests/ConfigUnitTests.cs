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
            config.Load("unit_test_config.xml");
            Assert.AreEqual(3, config.Bundles.Count);
            Assert.AreEqual(4, config.Products.Count);

            Bundle bundle;

            Assert.IsTrue(config.Bundles.TryGetValue("0", out bundle));
            Assert.AreEqual("Junior Saver", bundle.Name);
            Assert.AreEqual(1, bundle.Products.Count);
            Assert.AreEqual("2", bundle.Products[0]);
            Assert.AreEqual(1, bundle.Rules.Count);
            Assert.AreEqual(RuleType.MaxAge, bundle.Rules[0].Type);
            Assert.AreEqual(0, bundle.Value);

            Assert.IsTrue(config.Bundles.TryGetValue("1", out bundle));
            Assert.AreEqual("Student", bundle.Name);
            Assert.AreEqual(3, bundle.Products.Count);
            Assert.AreEqual("3", bundle.Products[0]);
            Assert.AreEqual("4", bundle.Products[1]);
            Assert.AreEqual("5", bundle.Products[2]);
            Assert.AreEqual(2, bundle.Rules.Count);
            Assert.AreEqual(RuleType.MinAge, bundle.Rules[0].Type);
            Assert.AreEqual(RuleType.Student, bundle.Rules[1].Type);
            Assert.AreEqual(0, bundle.Value);

            Assert.IsTrue(config.Bundles.TryGetValue("2", out bundle));
            Assert.AreEqual("Classic", bundle.Name);
            Assert.AreEqual(2, bundle.Products.Count);
            Assert.AreEqual("0", bundle.Products[0]);
            Assert.AreEqual("4", bundle.Products[1]);
            Assert.AreEqual(2, bundle.Rules.Count);
            Assert.AreEqual(RuleType.MinAge, bundle.Rules[0].Type);
            Assert.AreEqual(RuleType.MinIncome, bundle.Rules[1].Type);
            Assert.AreEqual(1, bundle.Value);

            Product product;

            Assert.IsTrue(config.Products.TryGetValue("0", out product));
            Assert.AreEqual("Current Account", product.Name);
            Assert.IsTrue(product.IsAccount);
            Assert.AreEqual(2, product.Rules.Count);
            Assert.AreEqual(RuleType.MinAge, product.Rules[0].Type);
            Assert.AreEqual(RuleType.MinIncome, product.Rules[1].Type);

            Assert.IsTrue(config.Products.TryGetValue("1", out product));
            Assert.AreEqual("Junior Saver Account", product.Name);
            Assert.IsTrue(product.IsAccount);
            Assert.AreEqual(1, product.Rules.Count);
            Assert.AreEqual(RuleType.MaxAge, product.Rules[0].Type);

            Assert.IsTrue(config.Products.TryGetValue("2", out product));
            Assert.AreEqual("Student Account", product.Name);
            Assert.IsTrue(product.IsAccount);
            Assert.AreEqual(2, product.Rules.Count);
            Assert.AreEqual(RuleType.MinAge, product.Rules[0].Type);
            Assert.AreEqual(RuleType.Student, product.Rules[1].Type);

            Assert.IsTrue(config.Products.TryGetValue("3", out product));
            Assert.AreEqual("Debit Card", product.Name);
            Assert.IsFalse(product.IsAccount);
            Assert.AreEqual(1, product.Rules.Count);
            Assert.AreEqual(RuleType.IncludeOneOfProducts, product.Rules[0].Type);
        }
    }
}