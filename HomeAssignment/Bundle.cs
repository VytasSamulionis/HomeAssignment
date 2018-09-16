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
        public string name
        {
            get { return _name; }
        }
        public int value
        {
            get { return _value; }
        }
        public List<string> products
        {
            get { return _products; }
        }
        public List<IRule> rules
        {
            get { return _rules; }
        }

        private string _name = string.Empty;
        private int _value = 0;
        private List<string> _products = new List<string>();
        private List<IRule> _rules = new List<IRule>();

        public Bundle(string bundleName, int bundleValue, List<string> bundleProducts, List<IRule> bundleRules)
        {
            _name = bundleName;
            _value = bundleValue;
            _products = bundleProducts;
            _rules = bundleRules;
        }
    }
}
