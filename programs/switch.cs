using System;

namespace project {
    class switch1 {
        static void Main() {




            // в операторе switch case мы проверяем определенную переменную на множество ее значений

            short user_input = Convert.ToInt16(Console.ReadLine());

            switch(user_input) {
                // если пользователь введет 5, то код будет выполняться
                case 5: System.Console.WriteLine("Number is 5");

                break; // оператор break обозначает, где заканчивается код

                case 15: System.Console.WriteLine("Number is 15");
                break;

                // оператор default cрабатывает, если все остальные кейсы не сработали
                default:
                System.Console.WriteLine("Number is recognized");
                break;
            }

        }
    }
}