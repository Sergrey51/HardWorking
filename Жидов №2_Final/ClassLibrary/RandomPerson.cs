using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    /// <summary>
    /// Класс для задания рандомного человека
    /// </summary>
    public static class RandomPerson
    {
        /// <summary>
        /// Случайное число
        /// </summary>
        private static Random _randomValue = new Random();

        /// <summary>
        /// Создание базовых данных персоны 
        /// </summary>
        /// <returns></returns>
        private static void RandomBaseInfo(PersonBase person)
        {
            person.Name =
                person.Gender == GenderType.Male
                ? GetRandomString(Properties.Resources.MaleNames)
                : GetRandomString(Properties.Resources.FemaleNames);

            person.Sername =
                person.Gender == GenderType.Male
                ? GetRandomString(Properties.Resources.MaleSernames)
                : GetRandomString(Properties.Resources.FemaleSernames);
        }

        /// <summary>
        /// Задание случайной строки из массива 
        /// </summary>
        /// <param name="array">
        /// Массив строк 
        /// </param>
        /// <returns>Строка</returns>
        private static string GetRandomString(string array)
        {
            var properName = array.Split('\r');
            int properNameValue = _randomValue.Next(0,
                properName.Length - 1);
            return properName[properNameValue].Replace("\n", "");
        }

        /// <summary>
        /// Определение несвязанных параметров взрослого
        /// </summary>
        /// <param name="adult">Взрослый</param>
        private static void RandomAdditionInfoAdult(Adult adult)
        {
            RandomBaseInfo(adult);
            adult.Age = Convert.ToByte(_randomValue.Next(18, 110));
            adult.Passport = _randomValue.Next(10000000,
                99999999).ToString();
            adult.PlaceOfWork = GetRandomString(Properties.Resources.Places);
        }

        /// <summary>
        /// Создание случайного взрослого человека
        /// </summary>
        /// <returns></returns>
        private static Adult Adult()
        {
            var adult = new Adult();

            int genderValue = _randomValue.Next(0, 2);
            adult.Gender = (GenderType)genderValue;

            RandomAdditionInfoAdult(adult);

            int spouseValue = _randomValue.Next(0, 4);
            if (!(spouseValue == 0))
            {
                adult.Spouse = Adult(adult);
            }

            return adult;
        }

        /// <summary>
        /// Создание случайного взрослого, с задаваемым супругом
        /// </summary>
        /// <param name="spouse">Задаваемый супруг</param>
        /// <returns>Взрослого с заданным супругом</returns>
        private static Adult Adult(Adult spouse)
        {
            var adult = new Adult();

            adult.Gender = (spouse.Gender == GenderType.Male)
                ? GenderType.Female
                : GenderType.Male;

            RandomAdditionInfoAdult(adult);

            adult.Spouse = spouse;

            return adult;
        }

        /// <summary>
        /// Создание случайного ребенка
        /// </summary>
        /// <returns></returns>
        private static Child Child()
        {
            var child = new Child();
            
            int genderValue = _randomValue.Next(0, 2);
            child.Gender = (GenderType)genderValue;

            RandomBaseInfo(child);

            child.GardenOrSchool = GetRandomString(
                Properties.Resources.Places);

            int parentValue = _randomValue.Next(0, 4);
            if (!(parentValue == 0))
            {
                var adult = Adult();
                child.ParentOne = adult;
                child.ParentTwo = adult.Spouse;
            }

            child.Age = Convert.ToByte(_randomValue.Next(1, 18));

            return child;
        }

        /// <summary>
        /// Создание случайной персоны
        /// </summary>
        /// <returns>Персона</returns>
        public static PersonBase Person()
        {
            int personValue = _randomValue.Next(0, 3);

            if (personValue == 0)
            {
                return Child();
            }
            else
            {
                return Adult();
            }
        }
    }
}
