using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment
{
    public class Product
    {
        public string name
        {
            get { return _name; }
        }
        public bool isAccount
        {
            get { return _isAccount; }
        }
        public List<IRule> rules
        {
            get { return _rules; }
        }

        private string _name = string.Empty;
        private bool _isAccount = false;
        private List<IRule> _rules = new List<IRule>();

        public Product(string productName, bool isAccountProduct, List<IRule> productRules)
        {
            _name = productName;
            _isAccount = isAccountProduct;
            _rules = productRules;
        }
    }
}
