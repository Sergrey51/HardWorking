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
            var spisokFirst = new PersonList();
            spisokFirst.AutoFill(3);

            var spisokSecond = new PersonList();
            spisokSecond.AutoFill(3);

            PersonListConsoleView(spisokFirst, nameof(spisokFirst));
            PersonListConsoleView(spisokSecond, nameof(spisokSecond));
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Добавление нового человека в список.");
            spisokFirst.AddPerson(Person.GetRandomPerson());

            PersonListConsoleView(spisokFirst, nameof(spisokFirst));
            PersonListConsoleView(spisokSecond, nameof(spisokSecond));
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Копирование второго человека из" +
                " первого списка во второй список.");
            spisokSecond.AddPerson(spisokFirst.GetPersonByIndex(1));

            PersonListConsoleView(spisokFirst, nameof(spisokFirst));
            PersonListConsoleView(spisokSecond, nameof(spisokSecond));
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Удаление второго человека" +
                "из первого списка.");
            spisokFirst.DeleteByIndex(1);

            PersonListConsoleView(spisokFirst, nameof(spisokFirst));
            PersonListConsoleView(spisokSecond, nameof(spisokSecond));
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Отчистка второго списка.");
            spisokSecond.Clean();

            PersonListConsoleView(spisokFirst, nameof(spisokFirst));
            PersonListConsoleView(spisokSecond, nameof(spisokSecond));
            Console.ReadKey();
            Console.Clear();

            var chelovek = EnterPersonKeyboard();
            PersonConsoleView(chelovek);
            Console.ReadKey();
        }

        /// <summary>
        /// Статический метод создания персоны с водом данных с клавиатуры
        /// </summary>
        /// <returns></returns>
        public static Person EnterPersonKeyboard()
        {
            var person = new Person();

            List<Action> actionList = new List<Action>
            {
                new Action (() =>
                {
                    Console.WriteLine("\nВпишите имя персоны.\n");
                    person.Name = Console.ReadLine();
                }),
                new Action (() =>
                {
                    Console.WriteLine("\nВпишите фимилию персоны.\n");
                    person.Sername = Console.ReadLine();
                }),
                new Action (() =>
                {
                    Console.WriteLine("\nВпишите возраст персоны.\n");
                    person.Age = Convert.ToByte(Console.ReadLine());
                }),
                new Action (() =>
                {
                    Console.WriteLine("\nВыберите пол персоны " +
                        "(пока из двух):");
                    Console.WriteLine("1 - Мужской пол.");
                    Console.WriteLine("2 - Женский пол.");

                    int genderValue = Convert.ToInt32(Console.ReadLine())
                        - 1;

                    if (genderValue == 0 || genderValue == 1)
                    {
                        person.Gender = (GenderType)genderValue;
                    }

                    else
                    {
                        Console.WriteLine("Только два варианта," +
                            " вот их и вводи!! (1 или 2)");
                    }
                })
            };

            foreach (var checkMethod in actionList)
            {
                CheckValue (checkMethod);
            }
            
            return person;
        }

        /// <summary>
        /// Проверка на корректность ввода данных
        /// </summary>
        /// <param name="checkThis"> Впроверяемое величена </param>
        public static void CheckValue(Action checkThis)
        {
            bool isValueCorrect = false;
        
            while (!isValueCorrect)
            {
                try
                {
                    checkThis.Invoke();
                    isValueCorrect = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// Вывод информации о персоне в консоль
        /// </summary>
        /// <param name="person">
        /// Персона, которую необходимо отобразить
        /// </param>
        public static void PersonConsoleView(Person person)
        {
            Console.WriteLine("\n" + person.Info);
        }

        /// <summary>
        /// Просмотр PersonList через консоль
        /// </summary>
        /// <param name="personList">
        /// Список персон, который необходимо отобразить
        /// </param>
        public static void PersonListConsoleView(PersonList personList,
            string nameOfList)
        {
            int kolvoPerson = personList.Length;

            Console.WriteLine($"\nСодержииое " + nameOfList + ":\n");

            if (kolvoPerson == 0)
            {
                Console.WriteLine("Список пуст!!!");
            }

            for (int i = 0; i < kolvoPerson; i++)
            {
                Console.WriteLine("ID: " + i + ".\t" +
                    personList.GetPersonByIndex(i).Info);
                Console.WriteLine();
            }
        }
    }
}
