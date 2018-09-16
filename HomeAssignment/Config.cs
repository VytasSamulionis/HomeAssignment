using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using HomeAssignment.Rules;

namespace HomeAssignment
{
    public class Config
    {
        public Dictionary<string, Bundle> Bundles { get; private set; }
        public Dictionary<string, Product> Products { get; private set; }

        private const string BUNDLE_KEY = "bundle";
        private const string PRODUCT_KEY = "product";
        private const string ID_KEY = "id";
        private const string NAME_KEY = "name";
        private const string VALUE_KEY = "value";
        private const string ACCOUNT_KEY = "account";
        private const string PRODUCTS_KEY = "products";
        private const string PRODUCT_ID_KEY = "product_id";
        private const string RULES_KEY = "rules";
        private const string MIN_AGE_RULE_KEY = "min_age";
        private const string MAX_AGE_RULE_KEY = "max_age";
        private const string MIN_INCOME_RULE_KEY = "min_income";
        private const string STUDENT_RULE_KEY = "student";
        private const string INCLUDE_ONE_OF_PRODUCTS_RULE_KEY = "include_one_of_products";

        public Config()
        {
            Bundles = new Dictionary<string, Bundle>();
            Products = new Dictionary<string, Product>();
        }

        public void Load(string configPath)
        {
            Bundles.Clear();
            Products.Clear();
            XElement configXml = XElement.Load(configPath);
            IEnumerator<XElement> elements = configXml.Elements().GetEnumerator();
            while (elements.MoveNext())
            {
                switch (elements.Current.Name.LocalName)
                {
                    case BUNDLE_KEY:
                        LoadBundle(elements.Current);
                        break;
                    case PRODUCT_KEY:
                        LoadProduct(elements.Current);
                        break;
                    default:
                        break;
                }
            }
        }

        private void LoadBundle(XElement element)
        {
            string id = string.Empty;
            string name = string.Empty;
            int value = 0;
            List<string> bundleProducts = new List<string>();
            List<IRule> bundleRules = new List<IRule>();
            IEnumerator<XAttribute> attributes = element.Attributes().GetEnumerator();
            while (attributes.MoveNext())
            {
                if (attributes.Current.Name == ID_KEY)
                {
                    id = attributes.Current.Value;
                }
            }
            IEnumerator<XElement> elements = element.Elements().GetEnumerator();
            while (elements.MoveNext())
            {
                switch (elements.Current.Name.LocalName)
                {
                    case NAME_KEY:
                        name = elements.Current.Value;
                        break;
                    case VALUE_KEY:
                        value = int.Parse(elements.Current.Value);
                        break;
                    case PRODUCTS_KEY:
                        IEnumerator<XElement> productIDs = elements.Current.Elements().GetEnumerator();
                        while (productIDs.MoveNext())
                        {
                            if (productIDs.Current.Name.LocalName == PRODUCT_ID_KEY)
                            {
                                bundleProducts.Add(productIDs.Current.Value);
                            }
                        }
                        break;
                    case RULES_KEY:
                        IEnumerator<XElement> rules = elements.Current.Elements().GetEnumerator();
                        while (rules.MoveNext())
                        {
                            bundleRules.Add(LoadRule(rules.Current));
                        }
                        break;
                    default:
                        break;
                }
            }
            Bundles.Add(id, new Bundle(name, value, bundleProducts, bundleRules));
        }

        private void LoadProduct(XElement element)
        {
            string id = string.Empty;
            string name = string.Empty; 
            bool isAccount = false;
            List<IRule> productRules = new List<IRule>();
            IEnumerator<XAttribute> attributes = element.Attributes().GetEnumerator();
            while (attributes.MoveNext())
            {
                switch (attributes.Current.Name.LocalName)
                {
                    case ID_KEY:
                        id = attributes.Current.Value;
                        break;
                    case ACCOUNT_KEY:
                        isAccount = attributes.Current.Value != "0";
                        break;
                    default:
                        break;
                }
            }
            IEnumerator<XElement> elements = element.Elements().GetEnumerator();
            while (elements.MoveNext())
            {
                switch (elements.Current.Name.LocalName)
                {
                    case NAME_KEY:
                        name = elements.Current.Value;
                        break;
                    case RULES_KEY:
                        IEnumerator<XElement> rules = elements.Current.Elements().GetEnumerator();
                        while (rules.MoveNext())
                        {
                            productRules.Add(LoadRule(rules.Current));
                        }
                        break;
                    default:
                        break;
                }
            }
            Products.Add(id, new Product(name, isAccount, productRules));
        }

        private IRule LoadRule(XElement element)
        {
            IRule rule = null;
            switch (element.Name.LocalName)
            {
                case MIN_AGE_RULE_KEY:
                    rule = new MinAgeRule(int.Parse(element.Value));
                    break;
                case MAX_AGE_RULE_KEY:
                    rule = new MaxAgeRule(int.Parse(element.Value));
                    break;
                case MIN_INCOME_RULE_KEY:
                    rule = new MinIncomeRule(int.Parse(element.Value));
                    break;
                case STUDENT_RULE_KEY:
                    rule = new StudentRule();
                    break;
                case INCLUDE_ONE_OF_PRODUCTS_RULE_KEY:
                    List<string> productsList = new List<string>();
                    IEnumerator<XElement> productIDs = element.Elements().GetEnumerator();
                    while (productIDs.MoveNext())
                    {
                        if (productIDs.Current.Name.LocalName == PRODUCT_ID_KEY)
                        {
                            productsList.Add(productIDs.Current.Value);
                        }
                    }
                    rule = new IncludeOneOfProductsRule(productsList);
                    break;
                default:
                    break;
            }
            return rule;
}
    }
}
