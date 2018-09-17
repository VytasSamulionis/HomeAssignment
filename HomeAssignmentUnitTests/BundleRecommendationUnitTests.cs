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
    public class BundleRecommendationUnitTests
    {
        [TestMethod()]
        public void EvaluateUnitTest()
        {
            Config config = new Config();
            config.Load("config.xml");
            BundleRecommendation recommendation = new BundleRecommendation(config);
            Assert.AreEqual("0", recommendation.Evaluate(15, false, 0));
            Assert.AreEqual("1", recommendation.Evaluate(18, true, 0));
            Assert.AreEqual("", recommendation.Evaluate(18, false, 0));
            Assert.AreEqual("2", recommendation.Evaluate(18, true, 5000));
            Assert.AreEqual("2", recommendation.Evaluate(25, false, 10000));
        }
    }
}