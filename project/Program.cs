using System;
using System.Collections.Generic;
namespace project {

    class Program10 {
        static void Main()
        {
            Student student = new Student { FirstName = "john", LastName = "lox"};
            student.PrintName();

            Bot bot = new Bot();
            bot.setValues("Bot", 800, new byte[] {0, 0, 0});
            bot.printValues();

            Killer killer = new Killer();
            killer.setValues("kill", 432,new byte[] { 1, 231,21});
            killer.printValues();
            killer.Health = 100;
            killer.Lazer();

            Robot bot1 = new Robot();
            bot1.Weight = -100;
            System.Console.WriteLine(bot1.Weight);

            // нам не нужно создавать объект
            Robot.count = 5;
            Robot.Print() ;

            List<Robot> robots = new List<Robot> ();
            robots.Add(new Robot("Alex", 132, new byte[] {0, 0, 12}));
            robots.Add(new Robot("John", 422, new byte[] {3, 2, 2}));
            robots.Add(new Robot("Tom", 12, new byte[] {31, 132, 12}));
            robots.Add(new Robot("Alex", 132, new byte[] {0, 0, 12}));

            Robot newRobot = null;
            // перебираем масив robots
            foreach(Robot obj in robots) {
                // у нас открыт доступ только для получения
                // для установки значениея он закрыт
                if(obj.Name == "John") {
                    // мы будем обрабатывать как определенный объект как класс родителя
                    newRobot = obj as Robot;
                }
                System.Console.WriteLine(obj.Name);
            }



            // оператор is – проверяет, совпадает ли тип выражения с заданным типом данных;
            int a = 23;
            int b = 312;


            // проверка есть ли переменная а типа int
            if(a is int) {
                System.Console.WriteLine("good");
            } else {
                System.Console.WriteLine("bad");
            }


        }
    }
}


            // наследование

            class Person {
                public string FirstName { get;set;}
                public string LastName { get;set;}

                public void PrintName() {
                    Console.WriteLine("my name john");
                }

            }

            // Person - клас который мы унаследовали
            class Student : Person {

            }