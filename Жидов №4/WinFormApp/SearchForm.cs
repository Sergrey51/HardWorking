using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace WinFormApp
{
    /// <summary>
    /// Форма для поиска по списку
    /// </summary>
    public partial class SearchForm : Form
    {
        /// <summary>
        /// Инициализация формы
        /// </summary>
        public SearchForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Отфильтрованный список
        /// </summary>
        BindingList<IPurchase> purchasesSearch =
            new BindingList<IPurchase>();

        /// <summary>
        /// При загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchForm_Load(object sender, EventArgs e)
        {
            DataPurchasesView.DataSource = purchasesSearch;

            FacePriceRadioButton.Checked = true;
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Поиск по параметру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            StartSearch();
        }

        /// <summary>
        /// Ввод информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartSearch();
            }
        }

        /// <summary>
        /// Метод начала поиска
        /// </summary>
        private void StartSearch()
        {
            purchasesSearch.Clear();

            try
            {
                if (FacePriceRadioButton.Checked)
                {
                    foreach (var row in MainForm.purchases)
                    {
                        if (row.FacePrice == Convert.ToDouble(
                            SearchTextBox.Text))
                        {
                            purchasesSearch.Add(row);
                        }
                    }
                }
                else
                {
                    foreach (var row in MainForm.purchases)
                    {
                        if (row.PriceAfterDiscount == Convert.ToDouble(
                            SearchTextBox.Text))
                        {
                            purchasesSearch.Add(row);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} " +
                    $"\nВведите десятичное число!!(Через запятую)");
            }

        }
    }
}
