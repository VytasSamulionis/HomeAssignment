using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAssignment
{
    public partial class WindowForm : Form
    {
        private Config _config = null;

        public WindowForm()
        {
            InitializeComponent();
        }

        public void SetConfig(Config config)
        {
            _config = config;
        }

        private void PopulateProducts(Dictionary<string, Product> products)
        {
            var enumerator = products.GetEnumerator();
            ProductList.BeginUpdate();
            while (enumerator.MoveNext())
            {
                Product product = enumerator.Current.Value;
                if (product.isAccount)
                {
                    RadioButton accountButton = new RadioButton
                    {
                        Text = product.name,
                        AutoSize = true,
                        Enabled = false
                    };
                    accountButton.Tag = new ProductItem(product, enumerator.Current.Key);
                    AccountsContainer.Controls.Add(accountButton);
                }
                else
                {
                    ProductList.Items.Add(new ProductItem(product, enumerator.Current.Key));
                }
            }
            ProductList.EndUpdate();
        }

        private void PopulateBundles(Dictionary<string, Bundle> bundles)
        {
            var enumerator = bundles.GetEnumerator();
            BundleSelection.BeginUpdate();
            while (enumerator.MoveNext())
            {
                BundleSelection.Items.Add(new BundleItem(enumerator.Current.Value, enumerator.Current.Key));
            }
            BundleSelection.EndUpdate();
        }

        private void QuestionsForm_Load(object sender, EventArgs e)
        {
            PopulateProducts(_config.products);
            PopulateBundles(_config.bundles);
        }
    }
}
