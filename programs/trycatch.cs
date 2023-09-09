using System;

namespace project {
    class Program8 {
        static void Main() {
            try{
            int num = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine(num);
            } catch(FormatException) {
                System.Console.WriteLine("Not access data");
            }



            try
            {
            int a = 5, b = 0, res;
            System.Console.WriteLine("Input a first number");
            a = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Input a 2 number");
            b = Convert.ToInt32(Console.ReadLine());
            res = a / b;
            System.Console.WriteLine("Redult:" + res);
            }
            catch (DivideByZeroException)
            {
                System.Console.WriteLine("error");
            }
            catch(FormatException) {
                System.Console.WriteLine("Не тот формат");
            }
            // в finally записывается код, который должен выполняться в любом случае
            finally {

            }

        }
    }
}