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
    public class Person
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
        private byte _age;

        /// <summary>
        /// Возраст персоны
        /// </summary>
        public byte Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 128)
                {
                    throw new ArgumentOutOfRangeException(
                        "Введённое значение выше допустимого. Введите " +
                        "меньше 129");
                }
                _age = value;
            }
        }

        /// <summary>
        /// Пол персоны
        /// </summary>
        public GenderType Gender { get; set; }

        /// <summary>
        /// Случайное число
        /// </summary>
        private static Random _randomValue = new Random();

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name">Имя перосоны</param>
        /// <param name="sername">Фамилия персоны</param>
        /// <param name="age">Возраст персоны</param>
        /// <param name="gender">Пол персоны</param>
        public Person(string name, string sername, byte age,
            GenderType gender)
        {
            Name = name;
            Sername = sername;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Конструктор класса по умолчанию
        /// </summary>
        public Person() : this("Ivan", "Ivanov", 18, GenderType.Male) { }

        /// <summary>
        /// Создания персоны со случайными данными
        /// </summary>
        /// <returns></returns>
        public static Person GetRandomPerson()
        {
            int genderValue = _randomValue.Next(0, 2);
            GenderType gender = (GenderType)genderValue;

            string name =
                gender == GenderType.Male
                ? GetRandomNameOrSername(Properties.Resources.MaleNames)
                : GetRandomNameOrSername(Properties.Resources.FemaleNames);
            
            string sername =
                gender == GenderType.Male
                ? GetRandomNameOrSername(Properties.Resources.MaleSernames)
                : GetRandomNameOrSername(
                    Properties.Resources.FemaleSernames);
            
            byte age = Convert.ToByte(_randomValue.Next(18, 45));

            return new Person(name, sername, age, gender);
        }

        /// <summary>
        /// Задание случайного имяни или фамилии 
        /// </summary>
        /// <param name="array">
        /// Массив имён или фамилий 
        /// </param>
        /// <returns>Имя или фамилия</returns>
        private static string GetRandomNameOrSername(string array)
        {
            var properName = array.Split('\r');
            int properNameValue = _randomValue.Next(0,
                properName.Length - 1);
            return properName[properNameValue].Replace("\n", "");
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
        /// Получение строки информации о персоне
        /// </summary>
        /// <returns></returns>
        public string Info 
        {
            get
            {
                var personInfo = "Имя: " + Name + ".\tФамилия: " +
                    Sername + ".   \tВозраст: " + Age + ".\tПол: " +
                    Gender + ".";

                return personInfo;
            }
        }
    }
}
