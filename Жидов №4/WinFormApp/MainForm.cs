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
using System.Threading;

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
        private BindingList<IPurchase> _purchases =
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
            DataPurchaseView.Create(_purchases, DataPurchasesView);
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
            var countOfDelete = DataPurchasesView.SelectedRows.Count;

            for (int i = 0; i < countOfDelete; i++)
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
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "kek files (*.kek)|*.kek";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var formatter = new BinaryFormatter();
                    var filePath = saveFileDialog.FileName;
                    using (var fileStream = new FileStream(filePath,
                        FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fileStream, _purchases);
                        MessageBox.Show("Файл сохранён!");
                    }
                }
            }
        }
        
        /// <summary>
        /// Загрузка листа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "kek files (*.kek)|*.kek";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var formatter = new BinaryFormatter();
                    var filePath = openFileDialog.FileName;

                    try
                    {
                        using (var fileStream = new FileStream(filePath,
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
                    catch
                    {
                        MessageBox.Show("Файл повреждён, " +
                            "невозможно загрузить.");
                    }
                }
            }
        }
    }
}
