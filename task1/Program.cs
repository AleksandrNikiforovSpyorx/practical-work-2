using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_Work_2 //Задания 1 и 2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Никифоров Александр Николаевич"; /// переменная ФИО

            byte age = 27; /// переменная Возраст

            string eMail = "nikifirov97@mail.ru"; /// переменная электронная почтв

            double programmingMark = 4.3; /// значение баллы по программированию
            byte mathMark = 5; /// значение  баллы по математике
            double physicsMark = 4.1; /// значение  баллы по физике

            /// Значение суммы всех балов
            double allMarks = (programmingMark + mathMark + programmingMark); 

            /// Расчет среднего балла по всем предметам
            double midleMark = (allMarks / 3); 

            /// Преобразование среднего балла в значение с одним знаком после запятой
            string midleMarkFormated = midleMark.ToString("#.#");

            /// Каждая переменная с новой стоки
            //string pattern =
            //    "\n" +
            //    "ФИО: {0} \n" +
            //    "Возраст: {1} \n" +
            //    "Электронная почта: {2} \n" +
            //    "Баллы по программированию: {3} \n" +
            //    "Баллы по математике: {4} \n" +
            //    "Баллы по физике: {5} \n" +
            //    "Сумма балов: {6} \n" +
            //    "Средний балл: {7} ";  /// Каждая переменная с новой стоки без интерполяцуии

            //Ввод в консоли нажатой клавиши
            ConsoleKeyInfo input;
           
            
            /// выполнение операции пока input = Console.ReadKey(true)
            do 
            {
                /// Вывод текчта в консоль 
                Console.WriteLine("Нажмите любую кнопку"); 

                /// Вывод текчта в консоль
                Console.WriteLine("Нажмите Esc чтобы выйти.");

                /// После нажатия любой кнопки появится информация
                input = Console.ReadKey(true);


                /// Вывод на консоль всей инофрмации
                //Console.WriteLine(pattern,   
                //fullName,
                //age,
                //eMail,
                //programmingMark,
                //mathMark,
                //physicsMark,
                //allMarks,
                //midleMarkFormated); /// Вывод на консоль всей инофрмации без интреполяции


                /// Вывод методом интерполяции
                Console.WriteLine($"\nФИО: {fullName}" +
                    $"\nВозраст: {age}" +
                    $"\neMail: {eMail}" +
                    $"\nБаллы по программированию: {programmingMark}" +
                    $"\nБаллы по математике: {mathMark}" +
                    $"\nБаллы по физике: {physicsMark}" +
                    $"\nСумма баллов: {allMarks}" +
                    $"\nСредний балл: {midleMarkFormated}");


                /// Для создания пустой строки(оступа)
                Console.WriteLine(); 
            }
            /// при нажатии ESC консоль закрывается
            while (input.Key != ConsoleKey.Escape); 
















        }
    }
}
