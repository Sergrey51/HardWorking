using System;
using System.Threading;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using ClassLibrary;

namespace OOP_start_VS2010
{
    /// <summary>
    /// Класс основной программы
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Стартовая точка программы
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var personList = new PersonList();
            personList.AutoFill(7);
            PersonListConsoleView(personList, nameof(personList));
            Console.ReadKey();
            Console.Clear();

            var person = personList.GetPersonByIndex(3);
            
            if (person is Child)
            {
                Console.WriteLine((person as Child).ParentTwoInfo);
            }

            if (person is Adult)
            {
                Console.WriteLine((person as Adult).PlaceOfWork);
            }

            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Вывод информации о персоне в консоль
        /// </summary>
        /// <param name="person">
        /// Персона, которую необходимо отобразить
        /// </param>
        public static void PersonConsoleView(PersonBase person)
        {
            Console.WriteLine("\n" + person.Info);
        }

        /// <summary>
        /// Просмотр списка персон через консоль
        /// </summary>
        /// <param name="personList">Список персон</param>
        /// <param name="nameOfList">Название списка персон</param>
        public static void PersonListConsoleView(PersonList personList,
            string nameOfList)
        {
            int kolvoPerson = personList.Length;

            Console.WriteLine($"\nСодержимое " + nameOfList + ":\n");

            if (kolvoPerson == 0)
            {
                Console.WriteLine("Список пуст!!!");
            }

            for (int i = 0; i < kolvoPerson; i++)
            {
                Console.WriteLine("ID: " + i + ". -------------------" +
                    "--------------------------------------------\n\n" +
                    personList.GetPersonByIndex(i).Info);
                Console.WriteLine();
            }
        }
    }
}
