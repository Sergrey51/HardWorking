namespace WinFormApp
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataPurchasesView = new System.Windows.Forms.DataGridView();
            this.FacePriceRadioButton = new System.Windows.Forms.RadioButton();
            this.FinishPriceRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPurchasesView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataPurchasesView);
            this.groupBox1.Location = new System.Drawing.Point(124, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Найденные элементы";
            // 
            // DataPurchasesView
            // 
            this.DataPurchasesView.AllowUserToAddRows = false;
            this.DataPurchasesView.AllowUserToDeleteRows = false;
            this.DataPurchasesView.AllowUserToResizeRows = false;
            this.DataPurchasesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPurchasesView.Location = new System.Drawing.Point(0, 19);
            this.DataPurchasesView.Name = "DataPurchasesView";
            this.DataPurchasesView.ReadOnly = true;
            this.DataPurchasesView.Size = new System.Drawing.Size(245, 130);
            this.DataPurchasesView.TabIndex = 2;
            // 
            // FacePriceRadioButton
            // 
            this.FacePriceRadioButton.AutoSize = true;
            this.FacePriceRadioButton.Location = new System.Drawing.Point(13, 13);
            this.FacePriceRadioButton.Name = "FacePriceRadioButton";
            this.FacePriceRadioButton.Size = new System.Drawing.Size(105, 17);
            this.FacePriceRadioButton.TabIndex = 1;
            this.FacePriceRadioButton.TabStop = true;
            this.FacePriceRadioButton.Text = "Стартовая цена";
            this.FacePriceRadioButton.UseVisualStyleBackColor = true;
            this.FacePriceRadioButton.CheckedChanged += new System.EventHandler(this.FacePriceRadioButton_CheckedChanged);
            // 
            // FinishPriceRadioButton
            // 
            this.FinishPriceRadioButton.AutoSize = true;
            this.FinishPriceRadioButton.Location = new System.Drawing.Point(13, 37);
            this.FinishPriceRadioButton.Name = "FinishPriceRadioButton";
            this.FinishPriceRadioButton.Size = new System.Drawing.Size(100, 17);
            this.FinishPriceRadioButton.TabIndex = 2;
            this.FinishPriceRadioButton.TabStop = true;
            this.FinishPriceRadioButton.Text = "Итоговая цена";
            this.FinishPriceRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(25, 109);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(25, 138);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(12, 83);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите величину:";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 169);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.FinishPriceRadioButton);
            this.Controls.Add(this.FacePriceRadioButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataPurchasesView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataPurchasesView;
        private System.Windows.Forms.RadioButton FacePriceRadioButton;
        private System.Windows.Forms.RadioButton FinishPriceRadioButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label1;
    }
}