using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;

namespace ClassLibrary
{
    /// <summary>
    ///  Включает себя информацию о конкретном человеке
    /// </summary>
    public abstract class PersonBase
    {
        /// <summary>
        /// Имя
        /// </summary>
        private string _name;

        /// <summary>
        /// Имя перосоны
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                CheckNameAndSername(value);
                _name = CorrectNameAndSername(value);
            }
        }

        /// <summary>
        /// фамилия персоны
        /// </summary>
        private string _sername;

        /// <summary>
        /// Фамилия персоны
        /// </summary>
        public string Sername
        {
            get
            {
                return _sername;
            }
            set
            {
                CheckNameAndSername(value);
                _sername = CorrectNameAndSername(value);
            }
        }

        /// <summary>
        /// Возраст персоны
        /// </summary>
        protected byte _age;

        /// <summary>
        /// Возраст персоны
        /// </summary>
        public abstract byte Age
        {
            get; set;
        }

        /// <summary>
        /// Пол персоны
        /// </summary>
        public GenderType Gender { get; set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name">Имя перосоны</param>
        /// <param name="sername">Фамилия персоны</param>
        /// <param name="age">Возраст персоны</param>
        /// <param name="gender">Пол персоны</param>
        protected PersonBase(string name, string sername, byte age,
            GenderType gender)
        {
            Name = name;
            Sername = sername;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Проверка на заполненность переменной
        /// </summary>
        /// <param name="checkingValue">Проверяемая строка</param>
        private void CheckNameAndSername(string checkingValue) 
        {
            if (string.IsNullOrEmpty(checkingValue))
            {
                throw new ArgumentNullException(
                    $"Name is null or empty!");
            }

            var pattern = @"^[a-zA-Z]+-?[a-zA-Z]+$";
            var regular = new Regex(pattern);
            var match = regular.Match(checkingValue);

            if (!match.Success)
            {
                throw new FormatException("\nInput value" +
                    $" has an erroneous format!");
            }
        }

        /// <summary>
        /// Изменение формата строки согласно стандарту
        /// </summary>
        /// <param name="correctValue">Форматируемая строка</param>
        /// <returns></returns>
        private string CorrectNameAndSername(string correctValue)
        {
            string fixedValue = correctValue.ToLowerInvariant();

            fixedValue = fixedValue.Substring(0, 1).ToUpper() +
                fixedValue.Remove(0, 1);

            int indexOfDash = correctValue.IndexOf("-");
            
            if (indexOfDash != -1)
            {
                fixedValue = fixedValue.Substring(0, indexOfDash + 1) +
                    fixedValue.Substring(indexOfDash + 1, 1).ToUpper() +
                    fixedValue.Remove(0, indexOfDash + 2);
            }

            return fixedValue;
        }

        /// <summary>
        /// Получение краткой информации о персоне
        /// </summary>
        /// <returns></returns>
        public string ShortInfo 
        {
            get
            {
                var personInfo = "Имя: " + Name + ".\tФамилия: " +
                    Sername + ".   \tВозраст: " + Age + ".\tПол: " +
                    Gender + ".";

                return personInfo;
            }
        }

        /// <summary>
        /// Получение полной информации о персоне
        /// </summary>
        /// <returns>Возвращает полную информацию о персоне</returns>
        public abstract string Info
        {
            get;
        }
    }
}
