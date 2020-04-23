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
            this.textBoxFacePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonWithoutDiscount = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPriceAfterDiscount = new System.Windows.Forms.TextBox();
            this.radioButtonCertificate = new System.Windows.Forms.RadioButton();
            this.radioButtonPercent = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lableValueOfDiscount = new System.Windows.Forms.Label();
            this.textBoxValueDiscount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFacePrice
            // 
            this.textBoxFacePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFacePrice.Location = new System.Drawing.Point(139, 9);
            this.textBoxFacePrice.Name = "textBoxFacePrice";
            this.textBoxFacePrice.Size = new System.Drawing.Size(124, 29);
            this.textBoxFacePrice.TabIndex = 0;
            this.textBoxFacePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxFacePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFacePrice_KeyDown);
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
            // radioButtonWithoutDiscount
            // 
            this.radioButtonWithoutDiscount.AutoSize = true;
            this.radioButtonWithoutDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonWithoutDiscount.Location = new System.Drawing.Point(31, 28);
            this.radioButtonWithoutDiscount.Name = "radioButtonWithoutDiscount";
            this.radioButtonWithoutDiscount.Size = new System.Drawing.Size(99, 21);
            this.radioButtonWithoutDiscount.TabIndex = 5;
            this.radioButtonWithoutDiscount.TabStop = true;
            this.radioButtonWithoutDiscount.Text = "Без скидки";
            this.radioButtonWithoutDiscount.UseVisualStyleBackColor = true;
            this.radioButtonWithoutDiscount.CheckedChanged += new System.EventHandler(this.radioButtonWithoutDiscount_CheckedChanged);
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
            // textBoxPriceAfterDiscount
            // 
            this.textBoxPriceAfterDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPriceAfterDiscount.Location = new System.Drawing.Point(168, 167);
            this.textBoxPriceAfterDiscount.Name = "textBoxPriceAfterDiscount";
            this.textBoxPriceAfterDiscount.ReadOnly = true;
            this.textBoxPriceAfterDiscount.Size = new System.Drawing.Size(95, 29);
            this.textBoxPriceAfterDiscount.TabIndex = 7;
            this.textBoxPriceAfterDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPriceAfterDiscount.UseWaitCursor = true;
            // 
            // radioButtonCertificate
            // 
            this.radioButtonCertificate.AutoSize = true;
            this.radioButtonCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonCertificate.Location = new System.Drawing.Point(61, 48);
            this.radioButtonCertificate.Name = "radioButtonCertificate";
            this.radioButtonCertificate.Size = new System.Drawing.Size(134, 21);
            this.radioButtonCertificate.TabIndex = 8;
            this.radioButtonCertificate.TabStop = true;
            this.radioButtonCertificate.Text = "По сертифекату";
            this.radioButtonCertificate.UseVisualStyleBackColor = true;
            this.radioButtonCertificate.CheckedChanged += new System.EventHandler(this.radioButtonCertificate_CheckedChanged);
            // 
            // radioButtonPercent
            // 
            this.radioButtonPercent.AutoSize = true;
            this.radioButtonPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPercent.Location = new System.Drawing.Point(136, 28);
            this.radioButtonPercent.Name = "radioButtonPercent";
            this.radioButtonPercent.Size = new System.Drawing.Size(107, 21);
            this.radioButtonPercent.TabIndex = 9;
            this.radioButtonPercent.TabStop = true;
            this.radioButtonPercent.Text = "Процентная";
            this.radioButtonPercent.UseVisualStyleBackColor = true;
            this.radioButtonPercent.CheckedChanged += new System.EventHandler(this.radioButtonPercent_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCertificate);
            this.groupBox1.Controls.Add(this.radioButtonPercent);
            this.groupBox1.Controls.Add(this.radioButtonWithoutDiscount);
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
            // textBoxValueDiscount
            // 
            this.textBoxValueDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxValueDiscount.Location = new System.Drawing.Point(161, 129);
            this.textBoxValueDiscount.Name = "textBoxValueDiscount";
            this.textBoxValueDiscount.Size = new System.Drawing.Size(95, 29);
            this.textBoxValueDiscount.TabIndex = 13;
            this.textBoxValueDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxValueDiscount.Visible = false;
            this.textBoxValueDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxValueDiscount_KeyDown);
            // 
            // Purchase
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 203);
            this.Controls.Add(this.textBoxValueDiscount);
            this.Controls.Add(this.lableValueOfDiscount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxPriceAfterDiscount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFacePrice);
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
        public System.Windows.Forms.TextBox textBoxFacePrice;
        private System.Windows.Forms.RadioButton radioButtonWithoutDiscount;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxPriceAfterDiscount;
        private System.Windows.Forms.RadioButton radioButtonCertificate;
        private System.Windows.Forms.RadioButton radioButtonPercent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lableValueOfDiscount;
        public System.Windows.Forms.TextBox textBoxValueDiscount;
    }
}

