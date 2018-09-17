using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Rules
{
    public class IncludeOneOfProductsRule : IRule
    {
        public List<string> products = null;
        public List<string> RequiredProducts
        {
            get { return _productsList; }
        }

        private List<string> _productsList = null;

        public IncludeOneOfProductsRule(List<string> productsList)
        {
            _productsList = productsList;
            _type = RuleType.IncludeOneOfProducts;
        }

        public override bool Validate()
        {
            if (products == null || _productsList == null)
            {
                HasFailed = true;
                return false;
            }
            for (int i = 0; i < products.Count; ++i)
            {
                if (_productsList.Contains(products[i]))
                {
                    HasFailed = false;
                    return true;
                }
            }
            HasFailed = true;
            return false;
        }
    }
}
