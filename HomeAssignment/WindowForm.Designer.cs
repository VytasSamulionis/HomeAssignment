namespace HomeAssignment
{
    partial class WindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label AgeLabel;
            System.Windows.Forms.Label IncomeLabel;
            System.Windows.Forms.Label CurrentBundleLabel;
            System.Windows.Forms.Label ProductsLabel;
            System.Windows.Forms.Label BundleSelectionLabel;
            System.Windows.Forms.GroupBox Accounts;
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Not selected");
            this.AccountsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.Questions = new System.Windows.Forms.GroupBox();
            this.StudentCheckBox = new System.Windows.Forms.CheckBox();
            this.IncomeFeedbackLabel = new System.Windows.Forms.Label();
            this.IncomeTextBox = new System.Windows.Forms.TextBox();
            this.AgeFeedbackLabel = new System.Windows.Forms.Label();
            this.RecommendButton = new System.Windows.Forms.Button();
            this.Customizations = new System.Windows.Forms.GroupBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.BundleSelection = new System.Windows.Forms.ComboBox();
            this.ProductList = new System.Windows.Forms.CheckedListBox();
            this.CurrentBundle = new System.Windows.Forms.TreeView();
            this.InformationLabel = new System.Windows.Forms.Label();
            AgeLabel = new System.Windows.Forms.Label();
            IncomeLabel = new System.Windows.Forms.Label();
            CurrentBundleLabel = new System.Windows.Forms.Label();
            ProductsLabel = new System.Windows.Forms.Label();
            BundleSelectionLabel = new System.Windows.Forms.Label();
            Accounts = new System.Windows.Forms.GroupBox();
            Accounts.SuspendLayout();
            this.Questions.SuspendLayout();
            this.Customizations.SuspendLayout();
            this.SuspendLayout();
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new System.Drawing.Point(14, 43);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new System.Drawing.Size(29, 13);
            AgeLabel.TabIndex = 0;
            AgeLabel.Text = "Age:";
            // 
            // IncomeLabel
            // 
            IncomeLabel.AutoSize = true;
            IncomeLabel.Location = new System.Drawing.Point(16, 99);
            IncomeLabel.Name = "IncomeLabel";
            IncomeLabel.Size = new System.Drawing.Size(45, 13);
            IncomeLabel.TabIndex = 3;
            IncomeLabel.Text = "Income:";
            // 
            // CurrentBundleLabel
            // 
            CurrentBundleLabel.AutoSize = true;
            CurrentBundleLabel.Location = new System.Drawing.Point(927, 51);
            CurrentBundleLabel.Name = "CurrentBundleLabel";
            CurrentBundleLabel.Size = new System.Drawing.Size(80, 13);
            CurrentBundleLabel.TabIndex = 6;
            CurrentBundleLabel.Text = "Current Bundle:";
            // 
            // ProductsLabel
            // 
            ProductsLabel.AutoSize = true;
            ProductsLabel.Location = new System.Drawing.Point(281, 103);
            ProductsLabel.Name = "ProductsLabel";
            ProductsLabel.Size = new System.Drawing.Size(52, 13);
            ProductsLabel.TabIndex = 0;
            ProductsLabel.Text = "Products:";
            // 
            // BundleSelectionLabel
            // 
            BundleSelectionLabel.AutoSize = true;
            BundleSelectionLabel.Location = new System.Drawing.Point(17, 42);
            BundleSelectionLabel.Name = "BundleSelectionLabel";
            BundleSelectionLabel.Size = new System.Drawing.Size(43, 13);
            BundleSelectionLabel.TabIndex = 4;
            BundleSelectionLabel.Text = "Bundle:";
            // 
            // Accounts
            // 
            Accounts.Controls.Add(this.AccountsContainer);
            Accounts.Location = new System.Drawing.Point(20, 103);
            Accounts.Name = "Accounts";
            Accounts.Size = new System.Drawing.Size(212, 381);
            Accounts.TabIndex = 5;
            Accounts.TabStop = false;
            Accounts.Text = "Account:";
            // 
            // AccountsContainer
            // 
            this.AccountsContainer.AutoSize = true;
            this.AccountsContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.AccountsContainer.Location = new System.Drawing.Point(1, 32);
            this.AccountsContainer.Name = "AccountsContainer";
            this.AccountsContainer.Size = new System.Drawing.Size(210, 347);
            this.AccountsContainer.TabIndex = 0;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(49, 40);
            this.AgeTextBox.MaxLength = 3;
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(53, 20);
            this.AgeTextBox.TabIndex = 1;
            this.AgeTextBox.TextChanged += new System.EventHandler(this.AgeTextBox_TextChanged);
            // 
            // Questions
            // 
            this.Questions.Controls.Add(this.StudentCheckBox);
            this.Questions.Controls.Add(this.IncomeFeedbackLabel);
            this.Questions.Controls.Add(this.IncomeTextBox);
            this.Questions.Controls.Add(IncomeLabel);
            this.Questions.Controls.Add(this.AgeFeedbackLabel);
            this.Questions.Controls.Add(this.AgeTextBox);
            this.Questions.Controls.Add(AgeLabel);
            this.Questions.Location = new System.Drawing.Point(24, 36);
            this.Questions.Name = "Questions";
            this.Questions.Size = new System.Drawing.Size(232, 149);
            this.Questions.TabIndex = 2;
            this.Questions.TabStop = false;
            this.Questions.Text = "Questions";
            // 
            // StudentCheckBox
            // 
            this.StudentCheckBox.AutoSize = true;
            this.StudentCheckBox.Location = new System.Drawing.Point(138, 42);
            this.StudentCheckBox.Name = "StudentCheckBox";
            this.StudentCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StudentCheckBox.Size = new System.Drawing.Size(63, 17);
            this.StudentCheckBox.TabIndex = 2;
            this.StudentCheckBox.Text = "Student";
            this.StudentCheckBox.UseVisualStyleBackColor = true;
            // 
            // IncomeFeedbackLabel
            // 
            this.IncomeFeedbackLabel.AutoSize = true;
            this.IncomeFeedbackLabel.Location = new System.Drawing.Point(16, 75);
            this.IncomeFeedbackLabel.Name = "IncomeFeedbackLabel";
            this.IncomeFeedbackLabel.Size = new System.Drawing.Size(32, 13);
            this.IncomeFeedbackLabel.TabIndex = 5;
            this.IncomeFeedbackLabel.Text = "Error:";
            this.IncomeFeedbackLabel.Visible = false;
            // 
            // IncomeTextBox
            // 
            this.IncomeTextBox.Location = new System.Drawing.Point(67, 96);
            this.IncomeTextBox.Name = "IncomeTextBox";
            this.IncomeTextBox.Size = new System.Drawing.Size(134, 20);
            this.IncomeTextBox.TabIndex = 3;
            this.IncomeTextBox.TextChanged += new System.EventHandler(this.IncomeTextBox_TextChanged);
            // 
            // AgeFeedbackLabel
            // 
            this.AgeFeedbackLabel.AutoSize = true;
            this.AgeFeedbackLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AgeFeedbackLabel.Location = new System.Drawing.Point(14, 20);
            this.AgeFeedbackLabel.Name = "AgeFeedbackLabel";
            this.AgeFeedbackLabel.Size = new System.Drawing.Size(32, 13);
            this.AgeFeedbackLabel.TabIndex = 2;
            this.AgeFeedbackLabel.Text = "Error:";
            this.AgeFeedbackLabel.Visible = false;
            // 
            // RecommendButton
            // 
            this.RecommendButton.Location = new System.Drawing.Point(91, 204);
            this.RecommendButton.Name = "RecommendButton";
            this.RecommendButton.Size = new System.Drawing.Size(109, 32);
            this.RecommendButton.TabIndex = 4;
            this.RecommendButton.Text = "Recommend";
            this.RecommendButton.UseVisualStyleBackColor = true;
            this.RecommendButton.Click += new System.EventHandler(this.RecommendButton_Click);
            // 
            // Customizations
            // 
            this.Customizations.Controls.Add(this.ApplyButton);
            this.Customizations.Controls.Add(Accounts);
            this.Customizations.Controls.Add(BundleSelectionLabel);
            this.Customizations.Controls.Add(this.BundleSelection);
            this.Customizations.Controls.Add(this.ProductList);
            this.Customizations.Controls.Add(ProductsLabel);
            this.Customizations.Location = new System.Drawing.Point(280, 36);
            this.Customizations.Name = "Customizations";
            this.Customizations.Size = new System.Drawing.Size(548, 517);
            this.Customizations.TabIndex = 4;
            this.Customizations.TabStop = false;
            this.Customizations.Text = "Customizations";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Enabled = false;
            this.ApplyButton.Location = new System.Drawing.Point(372, 445);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(156, 39);
            this.ApplyButton.TabIndex = 6;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // BundleSelection
            // 
            this.BundleSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BundleSelection.Enabled = false;
            this.BundleSelection.FormattingEnabled = true;
            this.BundleSelection.Location = new System.Drawing.Point(20, 67);
            this.BundleSelection.Name = "BundleSelection";
            this.BundleSelection.Size = new System.Drawing.Size(212, 21);
            this.BundleSelection.TabIndex = 3;
            this.BundleSelection.SelectedIndexChanged += new System.EventHandler(this.BundleSelection_SelectedIndexChanged);
            // 
            // ProductList
            // 
            this.ProductList.CheckOnClick = true;
            this.ProductList.Enabled = false;
            this.ProductList.FormattingEnabled = true;
            this.ProductList.Location = new System.Drawing.Point(284, 135);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(244, 289);
            this.ProductList.TabIndex = 2;
            // 
            // CurrentBundle
            // 
            this.CurrentBundle.Location = new System.Drawing.Point(850, 76);
            this.CurrentBundle.Name = "CurrentBundle";
            treeNode9.Name = "Bundle";
            treeNode9.Text = "Not selected";
            this.CurrentBundle.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.CurrentBundle.Size = new System.Drawing.Size(232, 477);
            this.CurrentBundle.TabIndex = 5;
            // 
            // InformationLabel
            // 
            this.InformationLabel.Location = new System.Drawing.Point(21, 259);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(235, 294);
            this.InformationLabel.TabIndex = 7;
            this.InformationLabel.Text = "Give answers to the questions and click on the \"Recommend\" button.";
            // 
            // WindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 582);
            this.Controls.Add(this.InformationLabel);
            this.Controls.Add(CurrentBundleLabel);
            this.Controls.Add(this.CurrentBundle);
            this.Controls.Add(this.Customizations);
            this.Controls.Add(this.RecommendButton);
            this.Controls.Add(this.Questions);
            this.Name = "WindowForm";
            this.Text = "Bundle Recommendation";
            this.Load += new System.EventHandler(this.QuestionsForm_Load);
            Accounts.ResumeLayout(false);
            Accounts.PerformLayout();
            this.Questions.ResumeLayout(false);
            this.Questions.PerformLayout();
            this.Customizations.ResumeLayout(false);
            this.Customizations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.GroupBox Questions;
        private System.Windows.Forms.CheckBox StudentCheckBox;
        private System.Windows.Forms.Label IncomeFeedbackLabel;
        private System.Windows.Forms.TextBox IncomeTextBox;
        private System.Windows.Forms.Label AgeFeedbackLabel;
        private System.Windows.Forms.Button RecommendButton;
        private System.Windows.Forms.GroupBox Customizations;
        private System.Windows.Forms.TreeView CurrentBundle;
        private System.Windows.Forms.ComboBox BundleSelection;
        private System.Windows.Forms.CheckedListBox ProductList;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.FlowLayoutPanel AccountsContainer;
    }
}

