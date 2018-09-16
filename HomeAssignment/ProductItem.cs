using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment
{
    public class ProductItem
    {
        public string ProductID
        {
            get { return _productID; }
        }

        private Product _product = null;
        private readonly string _productID = string.Empty;

        public ProductItem(Product product, string productID)
        {
            _product = product;
            _productID = productID;
        }

        public override string ToString()
        {
            return _product.Name;
        }
    }
}
