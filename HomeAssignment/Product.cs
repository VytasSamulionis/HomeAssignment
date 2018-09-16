using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment
{
    public class Product
    {
        public string Name
        {
            get { return _name; }
        }
        public bool IsAccount
        {
            get { return _isAccount; }
        }
        public List<IRule> Rules
        {
            get { return _rules; }
        }

        private readonly string _name = string.Empty;
        private readonly bool _isAccount = false;
        private readonly List<IRule> _rules = new List<IRule>();

        public Product(string productName, bool isAccountProduct, List<IRule> productRules)
        {
            _name = productName;
            _isAccount = isAccountProduct;
            _rules = productRules;
        }
    }
}
