using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    /// <summary>
    /// Класс, описывающий основную форму
    /// </summary>
    public partial class Purchase : Form
    {
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
            radioButtonWithoutDiscount.Checked = true;
        }


        private void buttonSolvePrice_Click(object sender, EventArgs e)
        {

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
        }

        private void radioButtonPercent_CheckedChanged(
            object sender, EventArgs e)
        {

            lableValueOfDiscount.Text = "Процент скидки:";
            textBoxValueDiscount.Visible = true;
            lableValueOfDiscount.Visible = true;
        }

        private void radioButtonCertificate_CheckedChanged(
            object sender, EventArgs e)
        {
            textBoxPriceAfterDiscount.Text = "23";
            lableValueOfDiscount.Text = "Сертефикат на:";
            textBoxValueDiscount.Visible = true;
            lableValueOfDiscount.Visible = true;
        }
    }
}
