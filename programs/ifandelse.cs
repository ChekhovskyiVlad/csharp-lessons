using System;

namespace project {
    class Program3 {
        static void Main() {

            ////    if & else
            int a = 5;
            bool isSad = false;

            bool isHasCar = true;

            // можно писать без фигурных скобок, используется только при 1 строчке кода
            if(a > 7)
                System.Console.WriteLine("It isn't true");
            else if(a < 7)
                System.Console.WriteLine("It's true");
             else
                System.Console.WriteLine("Error");

            // else if - это дополнительное условие



            if(a != 5) {
                Console.WriteLine("Number is 5");
            } else {
                Console.WriteLine("Number isnt 5");
            }


            // && - оператор И, используется если и первоя и вторая часть будет возвращать истину; то есть обе части должны выполниться

            if(isSad == false && isHasCar == true) {
                System.Console.WriteLine("all is good");
            } else {
                System.Console.WriteLine("Error");
            }


            // || - оператор ИЛИ, выполняется, если хотя бы одна часть кода будет верной
            if(isHasCar == false || isSad == false) {
                System.Console.WriteLine("all is good");
            }





            //// Практический пример

            System.Console.WriteLine("Enter a name:");

            string role = Console.ReadLine();
            if(role == "Admin")
            System.Console.Write("Enter admin name: ");
            string admin_name = Console.ReadLine();
            Console.Write("Enter {0} age:", admin_name);

            else if(role == "User"){
                System.Console.WriteLine("Enter a name: User");
        } else{

        }
    }
}