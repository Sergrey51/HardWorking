namespace WinFormApp
{
    partial class Purchase
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase));
            this.TextBoxFacePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RadioButtonWithoutDiscount = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxPriceAfterDiscount = new System.Windows.Forms.TextBox();
            this.RadioButtonCertificate = new System.Windows.Forms.RadioButton();
            this.RadioButtonPercent = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lableValueOfDiscount = new System.Windows.Forms.Label();
            this.TextBoxValueDiscount = new System.Windows.Forms.TextBox();
            this.AddPurchaseButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.RandomButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxFacePrice
            // 
            this.TextBoxFacePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxFacePrice.Location = new System.Drawing.Point(139, 9);
            this.TextBoxFacePrice.Name = "TextBoxFacePrice";
            this.TextBoxFacePrice.Size = new System.Drawing.Size(124, 29);
            this.TextBoxFacePrice.TabIndex = 0;
            this.TextBoxFacePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBoxFacePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цена товара:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RadioButtonWithoutDiscount
            // 
            this.RadioButtonWithoutDiscount.AutoSize = true;
            this.RadioButtonWithoutDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioButtonWithoutDiscount.Location = new System.Drawing.Point(31, 28);
            this.RadioButtonWithoutDiscount.Name = "RadioButtonWithoutDiscount";
            this.RadioButtonWithoutDiscount.Size = new System.Drawing.Size(99, 21);
            this.RadioButtonWithoutDiscount.TabIndex = 5;
            this.RadioButtonWithoutDiscount.TabStop = true;
            this.RadioButtonWithoutDiscount.Text = "Без скидки";
            this.RadioButtonWithoutDiscount.UseVisualStyleBackColor = true;
            this.RadioButtonWithoutDiscount.CheckedChanged += new System.EventHandler(this.RadioButtonWithoutDiscount_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цена со скидкой:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBoxPriceAfterDiscount
            // 
            this.TextBoxPriceAfterDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPriceAfterDiscount.Location = new System.Drawing.Point(168, 167);
            this.TextBoxPriceAfterDiscount.Name = "TextBoxPriceAfterDiscount";
            this.TextBoxPriceAfterDiscount.ReadOnly = true;
            this.TextBoxPriceAfterDiscount.Size = new System.Drawing.Size(95, 29);
            this.TextBoxPriceAfterDiscount.TabIndex = 7;
            this.TextBoxPriceAfterDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxPriceAfterDiscount.UseWaitCursor = true;
            // 
            // RadioButtonCertificate
            // 
            this.RadioButtonCertificate.AutoSize = true;
            this.RadioButtonCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioButtonCertificate.Location = new System.Drawing.Point(61, 48);
            this.RadioButtonCertificate.Name = "RadioButtonCertificate";
            this.RadioButtonCertificate.Size = new System.Drawing.Size(134, 21);
            this.RadioButtonCertificate.TabIndex = 8;
            this.RadioButtonCertificate.TabStop = true;
            this.RadioButtonCertificate.Text = "По сертифекату";
            this.RadioButtonCertificate.UseVisualStyleBackColor = true;
            this.RadioButtonCertificate.CheckedChanged += new System.EventHandler(this.RadioButtonCertificate_CheckedChanged);
            // 
            // RadioButtonPercent
            // 
            this.RadioButtonPercent.AutoSize = true;
            this.RadioButtonPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioButtonPercent.Location = new System.Drawing.Point(136, 28);
            this.RadioButtonPercent.Name = "RadioButtonPercent";
            this.RadioButtonPercent.Size = new System.Drawing.Size(107, 21);
            this.RadioButtonPercent.TabIndex = 9;
            this.RadioButtonPercent.TabStop = true;
            this.RadioButtonPercent.Text = "Процентная";
            this.RadioButtonPercent.UseVisualStyleBackColor = true;
            this.RadioButtonPercent.CheckedChanged += new System.EventHandler(this.RadioButtonPercent_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButtonCertificate);
            this.groupBox1.Controls.Add(this.RadioButtonPercent);
            this.groupBox1.Controls.Add(this.RadioButtonWithoutDiscount);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 75);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип скидки:";
            // 
            // lableValueOfDiscount
            // 
            this.lableValueOfDiscount.AutoSize = true;
            this.lableValueOfDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableValueOfDiscount.Location = new System.Drawing.Point(12, 133);
            this.lableValueOfDiscount.Name = "lableValueOfDiscount";
            this.lableValueOfDiscount.Size = new System.Drawing.Size(88, 20);
            this.lableValueOfDiscount.TabIndex = 12;
            this.lableValueOfDiscount.Text = "НАДПИСЬ";
            this.lableValueOfDiscount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lableValueOfDiscount.Visible = false;
            // 
            // TextBoxValueDiscount
            // 
            this.TextBoxValueDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxValueDiscount.Location = new System.Drawing.Point(161, 129);
            this.TextBoxValueDiscount.Name = "TextBoxValueDiscount";
            this.TextBoxValueDiscount.Size = new System.Drawing.Size(95, 29);
            this.TextBoxValueDiscount.TabIndex = 13;
            this.TextBoxValueDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBoxValueDiscount.Visible = false;
            this.TextBoxValueDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // AddPurchaseButton
            // 
            this.AddPurchaseButton.Location = new System.Drawing.Point(83, 208);
            this.AddPurchaseButton.Name = "AddPurchaseButton";
            this.AddPurchaseButton.Size = new System.Drawing.Size(99, 32);
            this.AddPurchaseButton.TabIndex = 14;
            this.AddPurchaseButton.Text = "OK";
            this.AddPurchaseButton.UseVisualStyleBackColor = true;
            this.AddPurchaseButton.Click += new System.EventHandler(this.AddPurchaseButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(188, 213);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RandomButton
            // 
            this.RandomButton.Location = new System.Drawing.Point(3, 213);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(74, 22);
            this.RandomButton.TabIndex = 16;
            this.RandomButton.Text = "Рандом";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // Purchase
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 252);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddPurchaseButton);
            this.Controls.Add(this.TextBoxValueDiscount);
            this.Controls.Add(this.lableValueOfDiscount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TextBoxPriceAfterDiscount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxFacePrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxFacePrice;
        private System.Windows.Forms.RadioButton RadioButtonWithoutDiscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxPriceAfterDiscount;
        private System.Windows.Forms.RadioButton RadioButtonCertificate;
        private System.Windows.Forms.RadioButton RadioButtonPercent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lableValueOfDiscount;
        private System.Windows.Forms.TextBox TextBoxValueDiscount;
        private System.Windows.Forms.Button AddPurchaseButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button RandomButton;
    }
}

