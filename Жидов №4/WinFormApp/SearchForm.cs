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
        /// Лист покупок из основной формы
        /// </summary>
        private BindingList<IPurchase> _purchases;

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public SearchForm(BindingList<IPurchase> purchases)
        {
            InitializeComponent();

            _purchases = purchases;
        }

        /// <summary>
        /// Отфильтрованный список
        /// </summary>
        private BindingList<IPurchase> _purchasesSearch =
            new BindingList<IPurchase>();

        /// <summary>
        /// При загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchForm_Load(object sender, EventArgs e)
        {
            DataPurchasesView.DataSource = _purchasesSearch;

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
            _purchasesSearch.Clear();

            try
            {
                if (FacePriceRadioButton.Checked)
                {
                    foreach (var row in _purchases)
                    {
                        if (row.FacePrice == Convert.ToDouble(
                            SearchTextBox.Text))
                        {
                            _purchasesSearch.Add(row);
                        }
                    }
                }
                else
                {
                    foreach (var row in _purchases)
                    {
                        if (row.PriceAfterDiscount == Convert.ToDouble(
                            SearchTextBox.Text))
                        {
                            _purchasesSearch.Add(row);
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

        /// <summary>
        /// Смена фактора поиска на стартовую цену
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FacePriceRadioButton_CheckedChanged(
            object sender, EventArgs e)
        {
            _purchasesSearch.Clear();
        }
    }
}
