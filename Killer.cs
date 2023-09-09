using System;

namespace project {

    // наследование

    // мы имеем доступ до всех элементов в объекте Robot


    // основные принципы ооп
    // Инкапсуляция.Скрытие внутреннего состояния и функций объекта и предоставление доступа только через открытый набор функций.
    // Наследование. Возможность создания новых абстракций на основе существующих.
    // Полиморфизм. Возможность реализации наследуемых свойств или методов отличающимися способами в рамках множества абстракций.

    class Killer: Robot {

        public int Health {get; set;}


        // conctructor
        // base() - обращение к классу родителю
        public Killer(string name, int weight, byte[] coordinates, int health) : base(name, weight, coordinates) {
            // передаем значение в качестве параметра
            this.Health = health;
        }


        // переписываем виртуальный метод
        // переписываем метод должен сохранять базовую концепцию
        public override void printValues()
        {
            base.printValues();
            System.Console.WriteLine("health" + this.Health);
        }
        public void Lazer() {
            System.Console.WriteLine("laser is shooting");
        }
    }
}