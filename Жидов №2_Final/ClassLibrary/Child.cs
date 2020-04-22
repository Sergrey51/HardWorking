using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    /// <summary>
    /// Класс, описывающий детей
    /// </summary>
    public class Child : PersonBase
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
                if (!(value <= 17))
                {
                    throw new ArgumentOutOfRangeException(
                        "Введённое значение недопустимо. Введите " +
                        "меньше 18.");
                }
                _age = value;
            }
        }

        /// <summary>
        /// Родитель 1 
        /// </summary>
        private Adult _parent1;

        /// <summary>
        /// Информация о первом родителе
        /// </summary>
        public string ParentOneInfo
        {
            get
            {
                return GetInfo(_parent1, "Parent one");
            }
        }

        /// <summary>
        /// Задание родителя
        /// </summary>
        public Adult ParentOne
        {
            set
            {
                _parent1 = value;
            }
        }

        /// <summary>
        /// Родитель 2 
        /// </summary>
        private Adult _parent2;

        /// <summary>
        /// Информация о втором родителе
        /// </summary>
        public string ParentTwoInfo
        {
            get
            {
                return GetInfo(_parent2, "Parent two");
            }
        }

        /// <summary>
        /// Информация о втором родители
        /// </summary>
        public Adult ParentTwo
        {
            set
            {
                _parent2 = value;
            }
        }

        /// <summary>
        /// Информация о родителе
        /// </summary>
        /// <param name="person"> Родитель </param>
        /// <param name="message"> Пояснение к родителю </param>
        /// <returns>Строка  с информацией о родителе</returns>
        private string GetInfo(Adult person, string message)
        {
            return person == null
                 ? $"No information about {message.ToLower()}."
                 : $"{message}:\n{person.ShortInfo}";
        }

        /// <summary>
        /// Наименование детского сада/школы
        /// </summary>
        private string _gardenOrSchool;

        /// <summary>
        /// Наименование детского сада/школы
        /// </summary>
        public string GardenOrSchool
        {
            get
            {
                return string.IsNullOrEmpty(_gardenOrSchool)
                    ? "No information about garden of school."
                    : $"Garden of school: {_gardenOrSchool}.";
            }
            set
            {
                _gardenOrSchool = value;
            }
        }

        /// <summary>
        /// Конструктор ребёнка
        /// </summary>
        /// <param name="name"> Имя </param>
        /// <param name="sername"> Фамилия </param>
        /// <param name="age"> Возраст </param>
        /// <param name="gender"> Пол </param>
        /// <param name="parent1"> Родитель первый </param>
        /// <param name="parent2"> Родитель второй </param>
        /// <param name="gardenOrSchool"> Название садика или школы </param>
        public Child(string name, string sername, byte age,
            GenderType gender, Adult parent1, Adult parent2,
            string gardenOrSchool) : base(name, sername, age, gender)
        {
            ParentOne = parent1;
            ParentTwo = parent2;
            GardenOrSchool = gardenOrSchool;
        }

        /// <summary>
        /// Конструктор класса по умолчанию
        /// </summary>
        public Child() : this("Ivan", "Ivanov", 10, GenderType.Male, null,
            null, "School №51") { }

        /// <summary>
        /// Полная информация о ребёнке
        /// </summary>
        public override string Info
        {
            get
            {
                var childInfo = $"{this.ShortInfo}\n" +
                    $"\n{this.ParentOneInfo}\n\n{this.ParentTwoInfo}\n" +
                    $"\n{this.GardenOrSchool}";

                return childInfo;
            }
        }
    }
}
