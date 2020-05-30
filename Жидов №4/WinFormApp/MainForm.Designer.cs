namespace WinFormApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DataPurchasesView = new System.Windows.Forms.DataGridView();
            this.PurchasesGroupBox = new System.Windows.Forms.GroupBox();
            this.AddPurchase = new System.Windows.Forms.Button();
            this.RemovePurshase = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataPurchasesView)).BeginInit();
            this.PurchasesGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            this.DataPurchasesView.RowHeadersVisible = false;
            this.DataPurchasesView.Size = new System.Drawing.Size(281, 189);
            this.DataPurchasesView.TabIndex = 1;
            // 
            // PurchasesGroupBox
            // 
            this.PurchasesGroupBox.Controls.Add(this.DataPurchasesView);
            this.PurchasesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.PurchasesGroupBox.Name = "PurchasesGroupBox";
            this.PurchasesGroupBox.Size = new System.Drawing.Size(281, 208);
            this.PurchasesGroupBox.TabIndex = 2;
            this.PurchasesGroupBox.TabStop = false;
            this.PurchasesGroupBox.Text = "Список покупок";
            // 
            // AddPurchase
            // 
            this.AddPurchase.Location = new System.Drawing.Point(12, 226);
            this.AddPurchase.Name = "AddPurchase";
            this.AddPurchase.Size = new System.Drawing.Size(127, 26);
            this.AddPurchase.TabIndex = 2;
            this.AddPurchase.Text = "Оформить покупку";
            this.AddPurchase.UseVisualStyleBackColor = true;
            this.AddPurchase.Click += new System.EventHandler(this.AddPurchase_Click);
            // 
            // RemovePurshase
            // 
            this.RemovePurshase.Location = new System.Drawing.Point(172, 226);
            this.RemovePurshase.Name = "RemovePurshase";
            this.RemovePurshase.Size = new System.Drawing.Size(121, 26);
            this.RemovePurshase.TabIndex = 3;
            this.RemovePurshase.Text = "Отменить покупку";
            this.RemovePurshase.UseVisualStyleBackColor = true;
            this.RemovePurshase.Click += new System.EventHandler(this.RemovePurshase_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(125, 258);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(62, 23);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 258);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(74, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(225, 258);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(68, 23);
            this.LoadButton.TabIndex = 6;
            this.LoadButton.Text = "Загрузить";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 291);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.RemovePurshase);
            this.Controls.Add(this.PurchasesGroupBox);
            this.Controls.Add(this.AddPurchase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Покупки";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataPurchasesView)).EndInit();
            this.PurchasesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataPurchasesView;
        private System.Windows.Forms.GroupBox PurchasesGroupBox;
        private System.Windows.Forms.Button RemovePurshase;
        private System.Windows.Forms.Button AddPurchase;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
    }
}