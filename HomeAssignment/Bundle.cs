using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeAssignment
{
    public class Bundle
    {
        public string Name
        {
            get { return _name; }
        }
        public int Value
        {
            get { return _value; }
        }
        public List<string> Products
        {
            get { return _products; }
        }
        public List<IRule> Rules
        {
            get { return _rules; }
        }

        private readonly string _name = string.Empty;
        private readonly int _value = 0;
        private readonly List<string> _products = new List<string>();
        private readonly List<IRule> _rules = new List<IRule>();

        public Bundle(string bundleName, int bundleValue, List<string> bundleProducts, List<IRule> bundleRules)
        {
            _name = bundleName;
            _value = bundleValue;
            _products = bundleProducts;
            _rules = bundleRules;
        }
    }
}
