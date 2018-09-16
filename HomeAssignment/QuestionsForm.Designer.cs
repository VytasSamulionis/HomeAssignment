﻿namespace HomeAssignment
{
    partial class QuestionsForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Not selected");
            System.Windows.Forms.Label CurrentBundleLabel;
            System.Windows.Forms.Label ProductsLabel;
            System.Windows.Forms.Label BundleSelectionLabel;
            System.Windows.Forms.GroupBox Accounts;
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.Questions = new System.Windows.Forms.GroupBox();
            this.AgeFeedbackLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IncomeTextBox = new System.Windows.Forms.TextBox();
            this.StudentCheckBox = new System.Windows.Forms.CheckBox();
            this.RecommendButton = new System.Windows.Forms.Button();
            this.Customizations = new System.Windows.Forms.GroupBox();
            this.CurrentBundle = new System.Windows.Forms.TreeView();
            this.ProductList = new System.Windows.Forms.CheckedListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AccountsPanel = new System.Windows.Forms.Panel();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.InformationLabel = new System.Windows.Forms.Label();
            AgeLabel = new System.Windows.Forms.Label();
            IncomeLabel = new System.Windows.Forms.Label();
            CurrentBundleLabel = new System.Windows.Forms.Label();
            ProductsLabel = new System.Windows.Forms.Label();
            BundleSelectionLabel = new System.Windows.Forms.Label();
            Accounts = new System.Windows.Forms.GroupBox();
            this.Questions.SuspendLayout();
            this.Customizations.SuspendLayout();
            Accounts.SuspendLayout();
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
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(49, 40);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(53, 20);
            this.AgeTextBox.TabIndex = 1;
            // 
            // Questions
            // 
            this.Questions.Controls.Add(this.StudentCheckBox);
            this.Questions.Controls.Add(this.label1);
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
            // AgeFeedbackLabel
            // 
            this.AgeFeedbackLabel.AutoSize = true;
            this.AgeFeedbackLabel.Location = new System.Drawing.Point(14, 20);
            this.AgeFeedbackLabel.Name = "AgeFeedbackLabel";
            this.AgeFeedbackLabel.Size = new System.Drawing.Size(32, 13);
            this.AgeFeedbackLabel.TabIndex = 2;
            this.AgeFeedbackLabel.Text = "Error:";
            this.AgeFeedbackLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Error:";
            this.label1.Visible = false;
            // 
            // IncomeTextBox
            // 
            this.IncomeTextBox.Location = new System.Drawing.Point(67, 96);
            this.IncomeTextBox.Name = "IncomeTextBox";
            this.IncomeTextBox.Size = new System.Drawing.Size(134, 20);
            this.IncomeTextBox.TabIndex = 4;
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
            // StudentCheckBox
            // 
            this.StudentCheckBox.AutoSize = true;
            this.StudentCheckBox.Location = new System.Drawing.Point(138, 42);
            this.StudentCheckBox.Name = "StudentCheckBox";
            this.StudentCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StudentCheckBox.Size = new System.Drawing.Size(63, 17);
            this.StudentCheckBox.TabIndex = 7;
            this.StudentCheckBox.Text = "Student";
            this.StudentCheckBox.UseVisualStyleBackColor = true;
            // 
            // RecommendButton
            // 
            this.RecommendButton.Location = new System.Drawing.Point(91, 204);
            this.RecommendButton.Name = "RecommendButton";
            this.RecommendButton.Size = new System.Drawing.Size(109, 32);
            this.RecommendButton.TabIndex = 3;
            this.RecommendButton.Text = "Recommend";
            this.RecommendButton.UseVisualStyleBackColor = true;
            // 
            // Customizations
            // 
            this.Customizations.Controls.Add(this.ApplyButton);
            this.Customizations.Controls.Add(Accounts);
            this.Customizations.Controls.Add(BundleSelectionLabel);
            this.Customizations.Controls.Add(this.comboBox1);
            this.Customizations.Controls.Add(this.ProductList);
            this.Customizations.Controls.Add(ProductsLabel);
            this.Customizations.Location = new System.Drawing.Point(280, 36);
            this.Customizations.Name = "Customizations";
            this.Customizations.Size = new System.Drawing.Size(548, 517);
            this.Customizations.TabIndex = 4;
            this.Customizations.TabStop = false;
            this.Customizations.Text = "Customizations";
            // 
            // CurrentBundle
            // 
            this.CurrentBundle.Location = new System.Drawing.Point(850, 76);
            this.CurrentBundle.Name = "CurrentBundle";
            treeNode1.Name = "Bundle";
            treeNode1.Text = "Not selected";
            this.CurrentBundle.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.CurrentBundle.Size = new System.Drawing.Size(232, 477);
            this.CurrentBundle.TabIndex = 5;
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
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 3;
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
            // AccountsPanel
            // 
            this.AccountsPanel.AutoScroll = true;
            this.AccountsPanel.Location = new System.Drawing.Point(1, 31);
            this.AccountsPanel.Name = "AccountsPanel";
            this.AccountsPanel.Size = new System.Drawing.Size(210, 347);
            this.AccountsPanel.TabIndex = 4;
            // 
            // Accounts
            // 
            Accounts.Controls.Add(this.AccountsPanel);
            Accounts.Location = new System.Drawing.Point(20, 103);
            Accounts.Name = "Accounts";
            Accounts.Size = new System.Drawing.Size(212, 381);
            Accounts.TabIndex = 5;
            Accounts.TabStop = false;
            Accounts.Text = "Account:";
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
            // 
            // InformationLabel
            // 
            this.InformationLabel.Location = new System.Drawing.Point(21, 259);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(235, 294);
            this.InformationLabel.TabIndex = 7;
            this.InformationLabel.Text = "Give answers to the questions and click on the \"Recommend\" button.";
            // 
            // QuestionsForm
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
            this.Name = "QuestionsForm";
            this.Text = "Questionnaire";
            this.Questions.ResumeLayout(false);
            this.Questions.PerformLayout();
            this.Customizations.ResumeLayout(false);
            this.Customizations.PerformLayout();
            Accounts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.GroupBox Questions;
        private System.Windows.Forms.CheckBox StudentCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IncomeTextBox;
        private System.Windows.Forms.Label AgeFeedbackLabel;
        private System.Windows.Forms.Button RecommendButton;
        private System.Windows.Forms.GroupBox Customizations;
        private System.Windows.Forms.TreeView CurrentBundle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckedListBox ProductList;
        private System.Windows.Forms.Panel AccountsPanel;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label InformationLabel;
    }
}

