using System;
using System.Collections.Generic;

namespace project {
    class Program {

        static void Main() {

            // \n - делает перевод на новую сттроку
            Console.WriteLine("hello world\n\n");

            // ждет пока пользователь что-то введет в терминале
            Console.ReadKey();

            // ввыводит данные без перехода на новую строку
            Console.Write("hello worrrrlldddd");

            // ждет когда пользователь введет строку и нашмет enter
            Console.ReadLine();


            //     ПЕРЕМЕННЫЕ И ТИПЫ ДАННЫХ

            // числа

            // uint - хранит только числа, которые есть положительные
           // uint number = -4232;
            // byte - можно хранить числа до только 255, отрицательные нельзя
            byte number1 = 255;
            // short - числа ограниченны диапазоном 32650, второй по величине по байта
            short number2 = 32650;
            // int - использует в два раза больше памяти
            int number3 = 3213213;
            // long - огромное количество
            long number4 = 9999898;


            // числа с плавающей точкой

            float num = 4.54352f;

            // double - для больше значения данных
            double num1 = 43242.432d;





        //          string

        // sting - это массив символов, то есть char
        string word = "String";


        // char - нужен, чтобы хранить не целую строку, а только один символ
        //char symbol = 321;

        bool isLoading = true;

        /*
            это нужно знать для того, чтобы оптимизировать программу, и потребление операционной памяти уменьшается
            поэтому, к примеру нам нужно хранить просто число 10, то мы можем использовать тип данных byte, потому что
            он меньше потребляет операционной памяти
        */



            //  укразываем новое значение
           // number = 321;
            // Console.WriteLine("Defination:" + number);



            int num_1 = 0, num_2 = 0;

            // в num_1 - я помещю результат выполнение функции
            // конвертируем значение со string в integer
            num_1 = Convert.ToInt32(Console.ReadLine());
            num_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("First:" + num_1 + "Second:" + num_2);

        }
    }
}


