using System;

namespace project {
    class Program4 {
        static void Main() {

                    ///// Циклы



            for(byte i = 20; i > 10; i/=2) {
                Console.WriteLine("Element: {0}", i);
            }

            // цикл while отличается от цикла for тем что, в while мы указываем только условие, используется только тогла, когда нужно прописать только одно условие
            byte a = 0;
            while(a < 10) {
                Console.WriteLine("Element {0}", a);
                a++;
            }


            bool isHasApple = true;
            // если условие будет неверным, то цыкл не выполниться
            while(isHasApple) {
                string end = Console.ReadLine();
                if(end == "end");
                isHasApple = false;
            }


            // в этом цикле сто процентов действие сто процентов должно выполниться
            byte b = 100;
            do {
                Console.WriteLine("Element:" b);

                // тут если только, оно есть верным, если оно неверное, то оно не выполняется
            } while(b < 10){

            }


            // оператор break
                for(short i = 0;i < 10;i++) {
                    if(i > 5) {

                        // выведет только до 5
                        break;
                    }

                    // continue - пропускает один круг цикла
                    // тут он выведет только нечетные числа, он пропускает все четные, и выводит только четные
                    if(i % 2 == 0) {
                        continue;
                    }

                }

        }
    }
}