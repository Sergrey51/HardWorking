using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WinFormApp
{
    /// <summary>
    /// Класс основной формы
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Оснвной лист покупок
        /// </summary>
        private static BindingList<IPurchase> _purchases =
            new BindingList<IPurchase>();

        /// <summary>
        /// Метод инициализации формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие при загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            DataPurchasesView.DataSource = _purchases;
        }

        /// <summary>
        /// Открытие формы для добавления покупки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPurchase_Click(object sender, EventArgs e)
        {
            var purchase = new Purchase(_purchases);
            purchase.Show();
        }

        /// <summary>
        /// Удаляет выбранные элементы из списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemovePurshase_Click(object sender, EventArgs e)
        {
            int _counter = DataPurchasesView.SelectedRows.Count;

            for (int i = 0; i < _counter; i++)
            {
                _purchases.RemoveAt(DataPurchasesView.SelectedRows[0].Index);
            }
        }

        /// <summary>
        /// Открытие формы поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            var search = new SearchForm(_purchases);
            search.Show();
        }

        /// <summary>
        /// Сохранение листа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var formatter = new BinaryFormatter();
            using (var fileStream = new FileStream("Purchases.kek",
                FileMode.OpenOrCreate))
            {
                formatter.Serialize(fileStream, _purchases);
                MessageBox.Show("Файл сохранён!");
            }
        }

        /// <summary>
        /// Загрузка листа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            var formatter = new BinaryFormatter();
            using (var fileStream = new FileStream("Purchases.kek",
                FileMode.OpenOrCreate))
            {
                var newpurchases = (BindingList<IPurchase>)
                    formatter.Deserialize(fileStream);

                _purchases.Clear();

                foreach (var purchase in newpurchases)
                {
                    _purchases.Add(purchase);
                }
            }
        }
    }
}
