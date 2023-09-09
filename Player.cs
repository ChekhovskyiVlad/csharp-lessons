using System;


namespace project
{

    // в абстрактных методах

   abstract class Weapon {

    // абстрактные методы могут находится только в абстрактных классах
    // в абстрактных методах нет реализации
          public abstract void Fire();
          public void ShowInfo() {
            System.Console.WriteLine(GetType().Name);
          }


          // !!!!!!!!!!!!!!!!!!!!!!!!!! все типы данных в c# унаследованы от типа object, у любого типа данных он есть
    }


    // если у нас есть абстрактный клас, и в нем есть какой-то абстрактный метод, то наследники должны будут реализовать его абстрактые методы
    class Gun : Weapon
    {
        public override void Fire()
        {
            System.Console.WriteLine("Пиу");
        }
    }

 class Bow : Weapon
    {
        public override void Fire()
        {
            System.Console.WriteLine("Пиу");
        }
    }

    class Lazer : Weapon
    {
        public override void Fire()
        {
            System.Console.WriteLine("Пиу");
        }
    }
    class Player {

        // может стрелять со всего от чего унаследовано от класса  weapon
        public void Fire(Weapon weapon){
            weapon.Fire();
        }
        public void Check
    }


    class Program100
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Weapon[] inventory = { new Gun(), new Lazer(), new Bow()};

            foreach (var item in inventory)
            {
                player.Fire(item);
                System.Console.WriteLine(item);
            }
        }
    }
}