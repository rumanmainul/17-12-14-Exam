namespace DailyExpenseApp
{
    partial class DailyExpense
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.particularTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showExpense = new System.Windows.Forms.Button();
            this.maximumExpenseTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalExpenseTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.showButton = new System.Windows.Forms.Button();
            this.categoryWiseExpComboBox = new System.Windows.Forms.ComboBox();
            this.Total = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.totalCatWiseExpenseTextBox = new System.Windows.Forms.TextBox();
            this.detailsListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.categoryComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.particularTextBox);
            this.groupBox1.Controls.Add(this.amountTextBox);
            this.groupBox1.Location = new System.Drawing.Point(45, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Expense Entry";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(213, 134);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.categoryComboBox.Location = new System.Drawing.Point(137, 61);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(151, 21);
            this.categoryComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Particular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount";
            // 
            // particularTextBox
            // 
            this.particularTextBox.Location = new System.Drawing.Point(137, 97);
            this.particularTextBox.Name = "particularTextBox";
            this.particularTextBox.Size = new System.Drawing.Size(151, 20);
            this.particularTextBox.TabIndex = 1;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(137, 25);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(151, 20);
            this.amountTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showExpense);
            this.groupBox2.Controls.Add(this.maximumExpenseTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.totalExpenseTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(45, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 188);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Summary";
            // 
            // showExpense
            // 
            this.showExpense.Location = new System.Drawing.Point(209, 19);
            this.showExpense.Name = "showExpense";
            this.showExpense.Size = new System.Drawing.Size(75, 23);
            this.showExpense.TabIndex = 3;
            this.showExpense.Text = "Show";
            this.showExpense.UseVisualStyleBackColor = true;
            this.showExpense.Click += new System.EventHandler(this.showExpense_Click);
            // 
            // maximumExpenseTextBox
            // 
            this.maximumExpenseTextBox.Location = new System.Drawing.Point(133, 120);
            this.maximumExpenseTextBox.Name = "maximumExpenseTextBox";
            this.maximumExpenseTextBox.Size = new System.Drawing.Size(151, 20);
            this.maximumExpenseTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Maximum Expense";
            // 
            // totalExpenseTextBox
            // 
            this.totalExpenseTextBox.Location = new System.Drawing.Point(133, 73);
            this.totalExpenseTextBox.Name = "totalExpenseTextBox";
            this.totalExpenseTextBox.Size = new System.Drawing.Size(151, 20);
            this.totalExpenseTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Expense";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.detailsListBox);
            this.groupBox3.Controls.Add(this.showButton);
            this.groupBox3.Controls.Add(this.categoryWiseExpComboBox);
            this.groupBox3.Controls.Add(this.Total);
            this.groupBox3.Controls.Add(this.Category);
            this.groupBox3.Controls.Add(this.totalCatWiseExpenseTextBox);
            this.groupBox3.Location = new System.Drawing.Point(391, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 438);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View Categorywise Expense";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(228, 61);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 3;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // categoryWiseExpComboBox
            // 
            this.categoryWiseExpComboBox.FormattingEnabled = true;
            this.categoryWiseExpComboBox.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.categoryWiseExpComboBox.Location = new System.Drawing.Point(152, 32);
            this.categoryWiseExpComboBox.Name = "categoryWiseExpComboBox";
            this.categoryWiseExpComboBox.Size = new System.Drawing.Size(151, 21);
            this.categoryWiseExpComboBox.TabIndex = 4;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(61, 320);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(31, 13);
            this.Total.TabIndex = 2;
            this.Total.Text = "Total";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(34, 40);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(49, 13);
            this.Category.TabIndex = 2;
            this.Category.Text = "Category";
            // 
            // totalCatWiseExpenseTextBox
            // 
            this.totalCatWiseExpenseTextBox.Location = new System.Drawing.Point(152, 317);
            this.totalCatWiseExpenseTextBox.Name = "totalCatWiseExpenseTextBox";
            this.totalCatWiseExpenseTextBox.Size = new System.Drawing.Size(151, 20);
            this.totalCatWiseExpenseTextBox.TabIndex = 1;
            // 
            // detailsListBox
            // 
            this.detailsListBox.FormattingEnabled = true;
            this.detailsListBox.Location = new System.Drawing.Point(6, 91);
            this.detailsListBox.Name = "detailsListBox";
            this.detailsListBox.Size = new System.Drawing.Size(412, 173);
            this.detailsListBox.TabIndex = 5;
            // 
            // DailyExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 551);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DailyExpense";
            this.Text = "DailyExpense";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox particularTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button showExpense;
        private System.Windows.Forms.TextBox maximumExpenseTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalExpenseTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ComboBox categoryWiseExpComboBox;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.TextBox totalCatWiseExpenseTextBox;
        private System.Windows.Forms.ListBox detailsListBox;
    }
}

