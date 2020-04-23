using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace WinFormApp
{
    /// <summary>
    /// Класс, описывающий основную форму
    /// </summary>
    public partial class Purchase : Form
    {
        /// <summary>
        /// Объявление переменной интерфейса
        /// </summary>
        IPurchase purchase;

        /// <summary>
        /// Метод, инициализирующий форму
        /// </summary>
        public Purchase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// События при инициализации формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Purchase_Load(object sender, EventArgs e)
        {
            purchase = new PurchaseWithoutDiscount();
            DisplayData();
            radioButtonWithoutDiscount.Checked = true;
        }

        /// <summary>
        /// Событие при нажатии кнопки без скидки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonWithoutDiscount_CheckedChanged(
            object sender, EventArgs e)
        {
            textBoxValueDiscount.Visible = false;
            lableValueOfDiscount.Visible = false;

            purchase = new PurchaseWithoutDiscount(purchase.FacePrice);
            DisplayData();
        }

        /// <summary>
        /// Событие при нажатии кнопки Процентная
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonPercent_CheckedChanged(
            object sender, EventArgs e)
        {
            lableValueOfDiscount.Text = "Процент скидки:";
            textBoxValueDiscount.Visible = true;
            lableValueOfDiscount.Visible = true;

            purchase = new PurchaseByPercent(purchase.FacePrice);
            DisplayData();
        }

        /// <summary>
        /// Событие при нажатии унопки По сертефикату
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonCertificate_CheckedChanged(
            object sender, EventArgs e)
        {
            lableValueOfDiscount.Text = "Сертефикат на:";
            textBoxValueDiscount.Visible = true;
            lableValueOfDiscount.Visible = true;
            
            purchase = new PurchaseByCertificate(purchase.FacePrice);
            DisplayData();
        }

        /// <summary>
        /// Вывод информации интерфейса
        /// </summary>
        private void DisplayData()
        {
            textBoxFacePrice.Text = purchase.FacePrice.ToString();
            textBoxPriceAfterDiscount.Text =
                purchase.PriceAfterDiscount.ToString();

            if (purchase is PurchaseByPercent)
            {
                textBoxValueDiscount.Text =
                    ((PurchaseByPercent)purchase).ValueOfPercent.ToString();
            }

            if (purchase is PurchaseByCertificate)
            {
                textBoxValueDiscount.Text =
                    ((PurchaseByCertificate)purchase).
                    ValueOfCertificate.ToString();
            }
        }

        /// <summary>
        /// Событие при вводе цены товара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFacePrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnterInformarion();
            }
        }

        /// <summary>
        /// Событие при вводе информации о скидке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxValueDiscount_KeyDown(
            object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnterInformarion();
            }
        }

        /// <summary>
        /// Ввод информации о цене товара
        /// </summary>
        private void EnterInformarion()
        {
            try
            {
                purchase.FacePrice =
                    Convert.ToDouble(textBoxFacePrice.Text);

                if (purchase is PurchaseByPercent)
                {
                    ((PurchaseByPercent)purchase).ValueOfPercent =
                        Convert.ToDouble(textBoxValueDiscount.Text);
                }

                if (purchase is PurchaseByCertificate)
                {
                    ((PurchaseByCertificate)purchase).ValueOfCertificate =
                        Convert.ToDouble(textBoxValueDiscount.Text);
                }

                DisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} " +
                    $"\nВведите десятичное число!!(Через запятую)");
            }
        }
    }
}
