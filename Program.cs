using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            NumberManipulator numberManipulator = new NumberManipulator();

            result = numberManipulator.FindMax(50, 30);

            Console.WriteLine(result + " Мама Владика даёт.");
            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("Ну и чего ты встал так рано? А ну дуй в постель!");
            }
            else
            {
                Console.WriteLine("Ого, а кто это у нас так долго спит? Мог бы и не вставать уже!");
            }
            Console.WriteLine("Выбери себе прозвище, боец!");
            string player_name = Console.ReadLine();
            Console.WriteLine("Отлично! {0}, что бы ты хотел отведать сегодня?", player_name);
            string order = Console.ReadLine();
            Console.WriteLine("К сожалению, мы не сможем дать тебе {0}. Зато дадим тебе горячих пиздюлин!", order);
            int time = new Random().Next(5, 20);
            Console.WriteLine("У тебя {0} минут, чтобы съебать отсюда. Время пошло.", time);
            Console.ReadKey();
        }


    }
}
