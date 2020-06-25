using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinFormApp
{
    /// <summary>
    /// Класс для создания таблицы
    /// </summary>
    public static class DataPurchaseView
    {
        /// <summary>
        /// СОздание таблицы определённого формата
        /// </summary>
        /// <param name="purchases">Лист покупок</param>
        /// <param name="dataGridView">Созданная таблица</param>
        public static void Create(BindingList<IPurchase> purchases,
            DataGridView dataGridView)
        {
            dataGridView.DataSource = purchases;

            if (dataGridView.Columns[0].HeaderText == "FacePrice")
            {
                dataGridView.Columns[0].HeaderText = "Стартовая цена";
            }

            if (dataGridView.Columns[1].HeaderText ==
                "PriceAfterDiscount")
            {
                dataGridView.Columns[1].HeaderText =
                    "Цена после скидки";
            }

            if (dataGridView.Columns[2].HeaderText ==
                "Description")
            {
                dataGridView.Columns[2].HeaderText =
                    "Описание покупки";
            }

            dataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView.Columns[0].Width = 80;
            dataGridView.Columns[1].Width = 90;

            dataGridView.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        } 
    }
}
