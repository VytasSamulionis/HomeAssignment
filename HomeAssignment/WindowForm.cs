using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeAssignment.Rules;

namespace HomeAssignment
{
    public partial class WindowForm : Form
    {
        private Config _config = null;
        private BundleRecommendation _bundleRecommendation = null;
        private bool _isCustomizationEnabled = false;

        private const string NAN_ERROR = "Error: The value has to be a number.";
        private const string ABNORMAL_AGE_WARNING = "Warning: Age number is abnormally high.";
        private const string NEGATIVE_NUMBER_ERROR = "Error: The value can't be a negative number.";
        private const string NO_BUNDLE_MATCH = "Unfortunately, none of the bundles can be recommended for this customer.";
        private const string RECOMMENDED_BUNDLE = "Recommended bundle:\n{0}\n\nNow you can customize the bundle.";

        private const string ERROR_MAX_AGE = "{0} requires a customer to be less than {1} years old.";
        private const string ERROR_MIN_AGE = "{0} requires a customer to be more than {1} years old.";
        private const string ERROR_MIN_INCOME = "{0} requires that customer's income would be more than {1}.";
        private const string ERROR_NOT_STUDENT = "{0} requires a customer to be a student.";
        private const string ERROR_PRODUCT_IS_MISSING = "{0} requires a customer to have one of the following products: {1}";

        private const string ERROR_CAPTION = "Error";
        private const string BUNDLE_SENDER_FORMAT = "\"{0}\" bundle";
        private const string PRODUCT_SENDER_FORMAT = "\"{0}\" product";

        public WindowForm()
        {
            InitializeComponent();
        }

        public void SetConfig(Config config)
        {
            _config = config;
            _bundleRecommendation = new BundleRecommendation(_config);
        }

        private void PopulateProducts(Dictionary<string, Product> products)
        {
            var enumerator = products.GetEnumerator();
            ProductList.BeginUpdate();
            while (enumerator.MoveNext())
            {
                Product product = enumerator.Current.Value;
                if (product.IsAccount)
                {
                    RadioButton accountButton = new RadioButton
                    {
                        Text = product.Name,
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
            PopulateProducts(_config.Products);
            PopulateBundles(_config.Bundles);
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateAgeInput();
        }

        private bool ValidateAgeInput()
        {
            int age = 0;
            bool isValid = false;
            if (!int.TryParse(AgeTextBox.Text, out age))
            {
                AgeFeedbackLabel.Text = NAN_ERROR;
                AgeFeedbackLabel.ForeColor = Color.DarkRed;
                AgeFeedbackLabel.Visible = true;
                AgeTextBox.BackColor = Color.OrangeRed;
                SetCustomizationEnabled(false);
            }
            else if (age < 0)
            {
                AgeFeedbackLabel.Text = NEGATIVE_NUMBER_ERROR;
                AgeFeedbackLabel.ForeColor = Color.DarkRed;
                AgeFeedbackLabel.Visible = true;
                AgeTextBox.BackColor = Color.OrangeRed;
                SetCustomizationEnabled(false);
            }
            else if (age > 130)
            {
                AgeFeedbackLabel.Text = ABNORMAL_AGE_WARNING;
                AgeFeedbackLabel.ForeColor = Color.DarkOrange;
                AgeFeedbackLabel.Visible = true;
                AgeTextBox.BackColor = Color.OrangeRed;
                isValid = true;
            }
            else
            {
                AgeFeedbackLabel.Visible = false;
                AgeTextBox.BackColor = Color.White;
                isValid = true;
            }
            return isValid;
        }

        private void IncomeTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateIncomeInput();
        }

        private bool ValidateIncomeInput()
        {
            int income = 0;
            bool isValid = false;
            if (!int.TryParse(IncomeTextBox.Text, out income))
            {
                IncomeFeedbackLabel.Text = NAN_ERROR;
                IncomeFeedbackLabel.ForeColor = Color.DarkRed;
                IncomeFeedbackLabel.Visible = true;
                IncomeTextBox.BackColor = Color.OrangeRed;
                SetCustomizationEnabled(false);
            }
            else if (income < 0)
            {
                IncomeFeedbackLabel.Text = NEGATIVE_NUMBER_ERROR;
                IncomeFeedbackLabel.ForeColor = Color.DarkRed;
                IncomeFeedbackLabel.Visible = true;
                IncomeTextBox.BackColor = Color.OrangeRed;
                SetCustomizationEnabled(false);
            }
            else
            {
                IncomeFeedbackLabel.Visible = false;
                IncomeTextBox.BackColor = Color.White;
                isValid = true;
            }
            return isValid;
        }

        private void RecommendButton_Click(object sender, EventArgs e)
        {
            if (ValidateAgeInput() && ValidateIncomeInput())
            {
                int age = int.Parse(AgeTextBox.Text);
                bool isStudent = StudentCheckBox.Checked;
                int income = int.Parse(IncomeTextBox.Text);
                string recommendedBundle = _bundleRecommendation.Evaluate(age, isStudent, income);
                if (string.IsNullOrEmpty(recommendedBundle))
                {
                    InformationLabel.Text = NO_BUNDLE_MATCH;
                }
                else
                {
                    Bundle bundle = _config.Bundles[recommendedBundle];
                    InformationLabel.Text = string.Format(RECOMMENDED_BUNDLE, bundle.Name);
                    SetupBundle(recommendedBundle, bundle);
                    UpdateCurrentBundle();
                }
                SetCustomizationEnabled(true);
            }
        }

        private void SetCustomizationEnabled(bool enabled)
        {
            if (_isCustomizationEnabled != enabled)
            {
                BundleSelection.Enabled = enabled;
                for (int i = 0; i < AccountsContainer.Controls.Count; ++i)
                {
                    AccountsContainer.Controls[i].Enabled = enabled;
                }
                ProductList.Enabled = enabled;
                ApplyButton.Enabled = enabled;
                _isCustomizationEnabled = enabled;
            }
        }

        private void SetupBundle(string bundleID, Bundle bundle)
        {
            for (int i = 0; i < BundleSelection.Items.Count; ++i)
            {
                if (((BundleItem)BundleSelection.Items[i]).BundleID == bundleID)
                {
                    BundleSelection.SelectedIndex = i;
                    break;
                }
            }
        }

        private void UpdateCurrentBundle()
        {
            CurrentBundle.BeginUpdate();
            CurrentBundle.Nodes.Clear();
            TreeNode root = CurrentBundle.Nodes.Add(string.Format(BUNDLE_SENDER_FORMAT, BundleSelection.Text));
            for (int i = 0; i < AccountsContainer.Controls.Count; ++i)
            {
                RadioButton radioButton = (RadioButton)AccountsContainer.Controls[i];
                if (radioButton.Checked)
                {
                    root.Nodes.Add(radioButton.Text);
                    break;
                }
            }
            var checkedItems = ProductList.CheckedItems.GetEnumerator();
            while (checkedItems.MoveNext())
            {
                root.Nodes.Add(checkedItems.Current.ToString());
            }
            root.ExpandAll();
            CurrentBundle.EndUpdate();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            int age = int.Parse(AgeTextBox.Text);
            bool isStudent = StudentCheckBox.Checked;
            int income = int.Parse(IncomeTextBox.Text);
            BundleItem bundleItem = (BundleItem)BundleSelection.SelectedItem;
            if (!RulesValidator.Validate(_config.Bundles[bundleItem.BundleID].Rules, age, isStudent, income, null))
            {
                Bundle bundle = _config.Bundles[bundleItem.BundleID];
                string errorMessage = GetErrorMessage(bundle.Rules, string.Format(BUNDLE_SENDER_FORMAT, bundle.Name));
                MessageBox.Show(errorMessage, ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                List<string> selectedProducts = new List<string>();
                for (int i = 0; i < AccountsContainer.Controls.Count; ++i)
                {
                    RadioButton radioButton = (RadioButton)AccountsContainer.Controls[i];
                    if (radioButton.Checked)
                    {
                        ProductItem productItem = (ProductItem)radioButton.Tag;
                        selectedProducts.Add(productItem.ProductID);
                        break;
                    }
                }
                var checkedItems = ProductList.CheckedItems.GetEnumerator();
                while (checkedItems.MoveNext())
                {
                    ProductItem productItem = (ProductItem)checkedItems.Current;
                    selectedProducts.Add(productItem.ProductID);
                }
                for (int i = 0; i < selectedProducts.Count; ++i)
                {
                    Product product = _config.Products[selectedProducts[i]];
                    if (!RulesValidator.Validate(product.Rules, age, isStudent, income, selectedProducts))
                    {
                        string errorMessage = GetErrorMessage(product.Rules, string.Format(PRODUCT_SENDER_FORMAT, product.Name));
                        MessageBox.Show(errorMessage, ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            UpdateCurrentBundle();
        }

        private string GetErrorMessage(List<IRule> rules, string sender)
        {
            string message = string.Empty;
            for (int i = 0; i < rules.Count; ++i)
            {
                if (rules[i].HasFailed)
                {
                    switch (rules[i].Type)
                    {
                        case RuleType.MaxAge:
                            message = string.Format(ERROR_MAX_AGE, sender, ((MaxAgeRule)rules[i]).MaxAge + 1);
                            break;
                        case RuleType.MinAge:
                            message = string.Format(ERROR_MIN_AGE, sender, ((MinAgeRule)rules[i]).MinAge - 1);
                            break;
                        case RuleType.MinIncome:
                            message = string.Format(ERROR_MIN_INCOME, sender, ((MinIncomeRule)rules[i]).MinIncome - 1);
                            break;
                        case RuleType.Student:
                            message = string.Format(ERROR_NOT_STUDENT, sender);
                            break;
                        case RuleType.IncludeOneOfProducts:
                            string productList = string.Empty;
                            var productsEnumerator = ((IncludeOneOfProductsRule)rules[i]).RequiredProducts.GetEnumerator();
                            productsEnumerator.MoveNext();
                            productList = _config.Products[productsEnumerator.Current].Name;
                            while (productsEnumerator.MoveNext())
                            {
                                productList += ", " + _config.Products[productsEnumerator.Current].Name;
                            }
                            message = string.Format(ERROR_PRODUCT_IS_MISSING, sender, productList);
                            break;
                        default:
                            break;
                    }
                    break;
                }
            }
            return message;
        }

        private void BundleSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bundle bundle = _config.Bundles[((BundleItem)((ComboBox)sender).SelectedItem).BundleID];
            for (int i = 0; i < AccountsContainer.Controls.Count; ++i)
            {
                string productID = ((ProductItem)AccountsContainer.Controls[i].Tag).ProductID;
                if (bundle.Products.Contains(productID))
                {
                    AccountsContainer.Controls[i].Select();
                    // a customer can only have one account so we can stop
                    break;
                }
            }
            ProductList.BeginUpdate();
            for (int i = 0; i < ProductList.Items.Count; ++i)
            {
                string productID = ((ProductItem)ProductList.Items[i]).ProductID;
                ProductList.SetItemChecked(i, bundle.Products.Contains(productID));
            }
            ProductList.EndUpdate();
        }
    }
}
