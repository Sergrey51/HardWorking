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
    /// Класс, описывающий форму покупки
    /// </summary>
    public partial class Purchase : Form
    {
        /// <summary>
        /// Объявление переменной интерфейса
        /// </summary>
        private IPurchase _purchase;

        /// <summary>
        /// Флаг для закрытия формы
        /// </summary>
        private bool _isCorrect = false;

        /// <summary>
        /// Лист покупок из основной формы
        /// </summary>
        private BindingList<IPurchase> _purchases;

        /// <summary>
        /// Метод, инициализирующий форму
        /// </summary>
        /// <param name="purchases">Список покупок</param>
        public Purchase(BindingList<IPurchase> purchases)
        {
            InitializeComponent();

            _purchases = purchases;

            #if !DEBUG
            RandomButton.Visible = false;
            #endif
        }

        /// <summary>
        /// События при инициализации формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Purchase_Load(object sender, EventArgs e)
        {
            _purchase = new PurchaseWithoutDiscount();
            DisplayData();
            RadioButtonWithoutDiscount.Checked = true;
        }

        /// <summary>
        /// Событие при нажатии кнопки без скидки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonWithoutDiscount_CheckedChanged(
            object sender, EventArgs e)
        {
            TextBoxValueDiscount.Visible = false;
            lableValueOfDiscount.Visible = false;

            _purchase = new PurchaseWithoutDiscount(_purchase.FacePrice);
            DisplayData();
        }

        /// <summary>
        /// Событие при нажатии кнопки Процентная
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonPercent_CheckedChanged(
            object sender, EventArgs e)
        {
            lableValueOfDiscount.Text = "Процент скидки:";
            TextBoxValueDiscount.Visible = true;
            lableValueOfDiscount.Visible = true;

            _purchase = new PurchaseByPercent(_purchase.FacePrice);
            DisplayData();
        }

        /// <summary>
        /// Событие при нажатии унопки По сертефикату
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonCertificate_CheckedChanged(
            object sender, EventArgs e)
        {
            lableValueOfDiscount.Text = "Сертефикат на:";
            TextBoxValueDiscount.Visible = true;
            lableValueOfDiscount.Visible = true;

            _purchase = new PurchaseByCertificate(_purchase.FacePrice);
            DisplayData();
        }

        /// <summary>
        /// Вывод информации интерфейса
        /// </summary>
        private void DisplayData()
        {
            TextBoxFacePrice.Text = _purchase.FacePrice.ToString();
            TextBoxPriceAfterDiscount.Text =
                _purchase.PriceAfterDiscount.ToString();

            if (_purchase is PurchaseByPercent)
            {
                TextBoxValueDiscount.Text =
                    ((PurchaseByPercent)_purchase).ValueOfPercent.ToString();
            }

            if (_purchase is PurchaseByCertificate)
            {
                TextBoxValueDiscount.Text =
                    ((PurchaseByCertificate)_purchase).
                    ValueOfCertificate.ToString();
            }
        }

        /// <summary>
        /// Событие при вводе значения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
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
            _isCorrect = false;

            try
            {
                _purchase.FacePrice =
                    Convert.ToDouble(TextBoxFacePrice.Text);

                if (_purchase is PurchaseByPercent)
                {
                    ((PurchaseByPercent)_purchase).ValueOfPercent =
                        Convert.ToDouble(TextBoxValueDiscount.Text);
                }

                if (_purchase is PurchaseByCertificate)
                {
                    ((PurchaseByCertificate)_purchase).ValueOfCertificate =
                        Convert.ToDouble(TextBoxValueDiscount.Text);
                }

                DisplayData();

                _isCorrect = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} " +
                    $"\nВведите десятичное число!!(Через запятую)");
            }
        }

        /// <summary>
        /// Выход к основному окну с добавлением покупки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPurchaseButton_Click(object sender, EventArgs e)
        {
            EnterInformarion();
            _purchases.Add(_purchase);
            if (_isCorrect) Close();
        }

        /// <summary>
        /// Закрытие окна, без всяких прекрас
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Создание случайной покупки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomButton_Click(object sender, EventArgs e)
        {
            _purchases.Add(RandomPurchase.CreatePurchase());
            Close();
        }
    }
}
