using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("введите теекущий год");
            //double year = double.Parse(Console.ReadLine());
            //if (year %4== 0)
            //{
            //    Console.WriteLine($"{year} год-высок");
            //}
            //else
            //{
            //    Console.WriteLine($"{year} год-не высокос");
            //}
            //Console.ReadKey();
            ////задача2
            //Console.WriteLine("введите цену ноутбука");
            //double price = double.Parse(Console.ReadLine());
            //if (20000 < price && price <= 30000)
            //{
            //    Console.WriteLine($"{price} рублей вход в диапазон от 20 до 30");
            //}
            //else
            //{
            //    Console.WriteLine($"{price}   не вход в диапазон от 20 до 30");
            //}
            //Console.ReadKey();
            ////задача 3
            //Console.WriteLine("введите балл ученика");
            //double mark = double.Parse(Console.ReadLine());
            //if (mark<0 && mark <=60)
            //{
            //    Console.WriteLine($"{mark} оценка недовлетворительна");
            //}
            //if (mark>60 && mark <= 74)
            //{
            //    Console.WriteLine($"{mark} оценка удолетворит");
            //}
            //if ( mark>75 && mark <= 89)
            //{
            //    Console.WriteLine($"{mark} оценка хорошо");
            //}
            //if ( mark>90 && mark <= 100)
            //{
            //    Console.WriteLine($"{mark} оценка отлично");
            //}
            ////задание 4
            Console.WriteLine("введите состояние светофора");
            double x = double.Parse(Console.ReadLine());
            switch (x)
            {
                case 1: Console.WriteLine($"цвет красный"); break;
                case 2: Console.WriteLine($"цвета желтый"); break;
                case 3: Console.WriteLine($"цвет зеленый"); break;
                default:Console.WriteLine($"нет такго кода");break;

            }  


            Console.ReadKey();




        }
    }
}
