using System;
using System.Collections.Generic;

namespace project {
    class Program5 {
        static void Main()  {
            short[] nums =  {1, 2, 3, 5,7,7 ,7,7,};


            // foreach - нужен для перебора массивов
            foreach(short el in nums) {
                System.Console.WriteLine("El:" + el);
            };

            short[,] nums1 = {
              {42, 43,65 , 65},
              {432, 432,4,43}
            };

            foreach(int el in nums1) {
                System.Console.WriteLine(el);
            }


            // динамический массив используется, если не знаешь сколько будет элементов
            List<int> numbers = new List<int> () {
                4, 6, 7
            };

            numbers.Add(40);
            numbers.Add(43);
            numbers.Add(2);

            // удалится число 43
            numbers.Remove(43);

            // отсортировали массив по возростанию
            numbers.Sort();

            // перевернули массив
            numbers.Reverse();


            foreach(int el in numbers) {
                System.Console.WriteLine("el:" + el);
            }

        }
    }
}