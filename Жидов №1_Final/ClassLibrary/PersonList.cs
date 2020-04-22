using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    /// <summary>
    /// Включает в себя информацию о всенённых людях
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Список персон
        /// </summary>
        private Person[] _dataArray = new Person[0];

        /// <summary>
        /// Доавление персоны в список
        /// </summary>
        /// <param name="person">
        /// Персона, которую необходимо внести в список
        /// </param>
        public void AddPerson(Person person)
        {
            Person[] newArray = new Person[_dataArray.Length + 1];

            for (int i = 0; i < _dataArray.Length; i++)
            {
                newArray[i] = this._dataArray[i];
            }

            newArray[_dataArray.Length] = person;

            _dataArray = newArray;
        }
        
        /// <summary>
        /// Отчистить список
        /// </summary>
        public void Clean()
        {
            _dataArray = new Person[0];
        }

        /// <summary>
        /// Получить количество персон в списке
        /// </summary>
        public int Length
        {
            get
            {
                return _dataArray.Length;
            }
        }

        /// <summary>
        /// Поиск персоны по индексу
        /// </summary>
        /// <param name="index">Номер искомого лица</param>
        /// <returns>Person с искомым интексом</returns>
        public Person GetPersonByIndex(int index)
        {
            CheckIndex(index);

            return _dataArray[index];
        }

        /// <summary>
        /// Удаление последнего по списку
        /// </summary>
        public void Delete()
        {
            Person[] newArray = new Person[_dataArray.Length - 1];

            for (int i = 0; i < _dataArray.Length - 1; i++)
            {
                newArray[i] = _dataArray[i];
            }

            _dataArray = newArray;
        }

        /// <summary>
        /// Удаление персоны с заданным номером
        /// </summary>
        /// <param name="index">Номер удалаемой персоны</param>
        public void DeleteByIndex(int index)
        {
            CheckIndex(index);

            Person[] newArray = new Person[_dataArray.Length - 1];

            for (int i = 0; i < _dataArray.Length - 1; i++)
            {
                // Заполнение до удалённой строки
                if (i < index)
                {
                    newArray[i] = this._dataArray[i];
                }

                // Заполнение после удалённой строки
                else
                {
                    newArray[i] = this._dataArray[i + 1];
                }
            }

            _dataArray = newArray;
        }

        /// <summary>
        /// Получение индекса конкретной персоны по списку (-1 по умолчанию)
        /// </summary>
        /// <param name="person">Искомая персона</param>
        /// <returns>Номер персоны в списке</returns>
        public int GetIndex(Person person)
        {
            int index = -1;

            for (int i = 0; i < _dataArray.Length; i++)
            {
                if (_dataArray[i] == person)
                {
                    index = i;
                }
            }

            return index;
        }

        /// <summary>
        /// Автоматическое формирование списка
        /// </summary>
        /// <param name="quantityOfPerson">
        /// Количество персон в списке
        /// </param>
        public void AutoFill(Byte quantityOfPerson)
        {
            {
                Clean();

                for (int i = 0; i < quantityOfPerson; i++)
                {
                    AddPerson(Person.GetRandomPerson());
                }
            }
        }

        /// <summary>
        /// Проверка на допустимость индекса
        /// </summary>
        /// <param name="index">Индекс который необходимо проверить</param>
        private void CheckIndex(int index)
        {
            if (index < 0 || index > (this.Length - 1))
            {
                throw new IndexOutOfRangeException("Invalid index entered." +
                    " Valid index from 0 to " + (this.Length - 1) + ".");
            }
        }
    }
}