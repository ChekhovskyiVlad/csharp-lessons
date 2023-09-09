using System;
using System.IO;
namespace project {
    class Program7 {
        public static void Main() {
            string word = "hello";
            word += "!";


            // строка(string) это массив символов(char)
            // в этом случае выведется буква е, потому что второй символ в массиве

            System.Console.WriteLine(word[1]);



            // lenght - выведет количество символом в строке, тут их 5
            System.Console.WriteLine(word.Length);



            // Concat - довабляет строку к строке
            // String - клас
            // выведет - hello!!!!
            System.Console.WriteLine(String.Concat(word, "!!!"));



            // Compare - cравнивает две строки;
            // если элементы одинаковы то выводится 0
            // если элементы на один символ больше или меньше, то выводится -1 или 1
            System.Console.WriteLine(String.Compare(word, "hallo"));



            string people = "alex, bob, vlad";

            // split - показывает по какому символу мы будем разбивать нашу строку, разбивает строку по определенному символу
            string[] names = people.Split(new char[]{','});
            foreach(string el in names) {
                System.Console.WriteLine(el);
            }


            // join - объеденяет элементы в массив
            // элементы будут записаны через пробел
            people = String.Join(" ", names);
            System.Console.WriteLine(people);



            // trim - позволяет удалить лишние пробелы до строки и после
            System.Console.WriteLine(word.Trim());



            // substring - позволяет указать с какого элемента и по какой мы будем удалять строку
            // тут вместо hello, выведется llo
            System.Console.WriteLine(word.Substring(2));

            // удаляет последний элемент строк
            System.Console.WriteLine(word.Length -1);


            // toLower - верхний регистр, toUpper - верхний
            System.Console.WriteLine(word.ToLower());
            System.Console.WriteLine(word.ToUpper());





            // using - директива, позволяет создавать изолированный код
            // FileStream - позволяет открыть файл для чтение или записи и тд
            // new FileStream - позволяет выделить памяти
            System.Console.WriteLine("Input a text");
            string text = Console.ReadLine();
            using(FileStream stream = new FileStream("info.txt", FileMode.OpenOrCreate)) {

                // переводим в массив байтов, мы берем текст от пользователя (text), и переобразовуем его в массив байтов
                byte[] array = System.Text.Encoding.Default.GetBytes(text);

                // Write - записывает данные внутрь созданного файла
                // array.Lenght - до какого элемента записывается
                stream.Write(array, 0, array.Length);
            }


            // OpenRead - позволяет открыть и прочитать файл
            // byte[] array = new byte[stream1.Length]; - обращаемся к файлу и считываем всю его длинну
            using(FileStream stream1 = File.OpenRead("info.text")){
                byte[] array = new byte[stream1.Length];
                stream1.Read(array, 0, array.Length);


                string textFromFile = System.Text.Encoding.Default.GetString(array);
                System.Console.WriteLine(textFromFile);
            }




                // конвертация строки в число

                string str = "65";
                string str2 = "43212";
               int ConvertString = Convert.ToInt32(str);
        }
    }
}