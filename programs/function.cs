using System;

namespace project {
    class Program6 {
       static void Main() {

        string words = "hello world";
        Print(words);


        int res1 = Sum(5, 6);


    /////////////////////////////////////// подсчет данных в массиве
        byte[] nums = {5,6,7,8,9};
        byte res2 = Task(nums);
        System.Console.WriteLine(res2);
    }


    // word - параметрy
    // void - ничего не возвращает
    public static void Print(string word) {
        System.Console.WriteLine(word);
    }

    // int - показывает, что возвращает функция
    public static int Sum(int a, int b) {
        return a + b;
    }

    public static byte Task(byte[] digits) {
        byte summa = 0;

        foreach(byte el in digits) {
            summa += el;
        }
        return summa;
    }

    }

    // функции принадлежащими к классу называются методы
    // перегрузка методов
}