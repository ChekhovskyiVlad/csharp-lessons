using System;

namespace project {
    class Program1 {
        static void Main() {


            // Математические действий
            Console.Write("Input a number with dot: ");
            // user_input = Convert.ToDouble(Console.ReadLine());

            // конвертируем строку в тип float
            float user_input = float.Parse(Console.ReadLine());


            float result;
            result = user_input + 321f + 423342f;
            result = user_input - 4f;
            result = user_input * 423f;
            result = user_input / 43f;

            // остаток при делении
            result = user_input % 2f;


            // сокращенные действия
            result += 3124f;
            result *= 2f;
            result /= 3124f;

            //// добавляем единицу

            result++;
            result--;

            Console.WriteLine("Variable:" + result);




            // Встроенные математические функции


            // PI - это константа, константу нельзя переопределить
            Console.WriteLine(Math.PI);


            // Abs - число по модулю, то есть |-x| = x
            Console.WriteLine(Math.Abs(-20));


            // Ceiling - округяет число к большему
            Console.WriteLine(Math.Ceiling(4.11f));

            // Floor - округлит к меньшему, тут выведет 4
            Console.WriteLine(Math.Floor(4.99f));

            // Round - округляет либо к большему либо к меньшему
            Console.WriteLine(Math.Round(4.99f));



            // Min - выводит минимальное число из чисел
            Console.WriteLine(Math.Min(5, 0));

            // Max - максимальное число
            Console.WriteLine(Math.Max(5, 312));



            // косинус, синус, тангенс, котангенс
            Console.WriteLine(Math.Cos(2));
            Console.WriteLine(Math.Sin(2));
            Console.WriteLine(Math.Tan(2));


            // возводит в степень тут будет 5 в степени 2
            Console.WriteLine(Math.Pow(5, 2));



            Console.WriteLine("Input a radius kryga:");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);


            // к 0 будет подставленный radius, а к 1 area
            System.Console.WriteLine("Result: {0} {1}", radius, area);
        }
    }
}