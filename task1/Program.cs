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

            double allMarks = (programmingMark + mathMark + programmingMark); /// Значение суммы всех балов
            
            double midleMark = (allMarks / 3); /// Расчет среднего балла по всем предметам
           
            string midleMarkFormated = midleMark.ToString("#.#") ; /// Преобразование среднего балла в значение с одним знаком после запятой
            
            string pattern = "\nФИО: {0} \nВозраст: {1} \nЭлектронная почта: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5} \nСумма балов: {6} \nСредний балл: {7} "; /// Каждая переменная с новой стоки


            ConsoleKeyInfo input; //Ввод в консоли нажатой клавиши
            do /// выполнение операции пока input = Console.ReadKey(true)
            {
                Console.WriteLine("Нажмите любую кнопку"); // Вывод текчта в консоль 
                Console.WriteLine("Нажмите Esc чтобы выйти."); /// Вывод текчта в консоль
               
                input = Console.ReadKey(true); /// После нажатия любой кнопки появится информация


                Console.WriteLine(pattern,    /// Вывод на консоль всей инофрмации
                fullName,
                age,
                eMail,
                programmingMark,
                mathMark,
                physicsMark,
                allMarks,
                midleMarkFormated);
                Console.WriteLine(); // Для создания пустой строки(оступа)
            } while (input.Key != ConsoleKey.Escape); // при нажатии ESC консоль закрывается
















        }
    }
}
