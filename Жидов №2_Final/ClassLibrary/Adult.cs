using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    /// <summary>
    /// Класс, описывающий взрослых
    /// </summary>
    public class Adult : PersonBase
    {
        /// <summary>
        /// Возраст персоны
        /// </summary>
        public override byte Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (!(17 < value) && !(value <= 128))
                {
                    throw new ArgumentOutOfRangeException(
                        "Введённое значение недопустимо. Введите " +
                        "больше 17 и меньше 129");
                }

                _age = value;
            }
        }

        /// <summary>
        /// Уникальный номер пасспорта 
        /// </summary>
        private string _passportData;

        /// <summary>
        /// Интерфейс взаимодействия с паспортными данными
        /// </summary>
        public string Passport
        {
            get
            {
                return string.IsNullOrEmpty(_passportData)
                    ? "No information about passport data."
                    : $"Data passport: {_passportData}.";
            }
            set
            {
                _passportData = value;
            }
        }

        /// <summary>
        /// Состояние брака
        /// </summary>
        private Adult _spouse;

        /// <summary>
        /// Информация о состояние брака
        /// </summary>
        public string SpouseInfo
        {
            get
            {
                return _spouse == null
                     ? "Not married."
                     : $"Married to: \n{_spouse.ShortInfo}";
            }
        }

        /// <summary>
        /// Доступ к объекту супруг
        /// </summary>
        public Adult Spouse
        {
            get
            {
                return _spouse;
            }
            set
            {
                _spouse = value;
            }
        }

        /// <summary>
        /// Наименование места работы
        /// </summary>
        private string _placeOfWork;

        /// <summary>
        /// Наименование места работы
        /// </summary>
        public string PlaceOfWork
        {
            get
            {
                return string.IsNullOrEmpty(_placeOfWork)
                    ? "No information about place of work."
                    : $"Place of work: {_placeOfWork}.";
            }
            set
            {
                _placeOfWork = value;
            }
        }

        /// <summary>
        /// Конструктор взрослого человека
        /// </summary>
        /// <param name="name"> Имя </param>
        /// <param name="sername"> Фамилия </param>
        /// <param name="age"> Возраст </param>
        /// <param name="gender"> Пол </param>
        /// <param name="passportData"> Паспортные данные </param>
        /// <param name="spuose"> Супруг </param>
        /// <param name="placeOfWork"> Место работы </param>
        public Adult(string name, string sername, byte age,
            GenderType gender, string passportData, Adult spuose,
            string placeOfWork) : base(name, sername, age, gender)
        {
            _passportData = passportData;
            Spouse = spuose;
            PlaceOfWork = placeOfWork;
        }

        /// <summary>
        /// Конструктор класса по умолчанию
        /// </summary>
        public Adult() : this("Ivan", "Ivanov", 24, GenderType.Male, "",
            null, "Zavod") { }

        /// <summary>
        /// Полная информация о взрослом человеке
        /// </summary>
        public override string Info
        {
            get
            {
                return $"{this.ShortInfo}\n\n{this.Passport}\n\n" +
                    $"{this.SpouseInfo}\n\n{this.PlaceOfWork}";
            }
        }
    }
}
