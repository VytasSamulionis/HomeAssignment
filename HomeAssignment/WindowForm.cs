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
        private BundleRecommendation _bundleRecommendation = null;

        private const string NAN_ERROR = "Error: The value has to be a number.";
        private const string ABNORMAL_AGE_WARNING = "Warning: Age number is abnormally high.";
        private const string NEGATIVE_NUMBER_ERROR = "Error: The value can't be a negative number.";
        private const string NO_BUNDLE_MATCH = "Unfortunately, none of the bundles can be recommended for this customer.";
        private const string RECOMMENDED_BUNDLE = "Recommended bundle:\n{0}\n\nNow you can customize the bundle.";

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
            }
            else if (age < 0)
            {
                AgeFeedbackLabel.Text = NEGATIVE_NUMBER_ERROR;
                AgeFeedbackLabel.ForeColor = Color.DarkRed;
                AgeFeedbackLabel.Visible = true;
                AgeTextBox.BackColor = Color.OrangeRed;
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
            }
            else if (income < 0)
            {
                IncomeFeedbackLabel.Text = NEGATIVE_NUMBER_ERROR;
                IncomeFeedbackLabel.ForeColor = Color.DarkRed;
                IncomeFeedbackLabel.Visible = true;
                IncomeTextBox.BackColor = Color.OrangeRed;
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
                    InformationLabel.Text = string.Format(RECOMMENDED_BUNDLE, _config.Bundles[recommendedBundle].Name);
                }
            }
        }
    }
}
