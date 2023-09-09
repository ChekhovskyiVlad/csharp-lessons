using System;


namespace project {

    abstract class Robot: IJump, IRun {

    //Модификатор abstract указывает, что изменяемый элемент имеет отсутствующую или неполную реализацию. Модификатор abstract можно использовать с классами, методами, свойствами, индексаторами и событиями. Используйте модификатор abstract в объявлении класса, чтобы указать, что класс предназначен только для использования в качестве базового класса для других классов и не должен быть создан сам по себе. Элементы с пометкой abstract должны быть реализованы не абстрактными классами, производными от абстрактного класса.



    // Абстрактный класс — средство разработки классов на нижнем уровне, средство для повторного использования кода; интерфейс — средство выражения семантики класса.
    // Как правило, абстрактные классы фокусируются на общем состоянии классов-наследников. В то время как интерфейсы строятся вокруг какого-либо общего действия. Например, солнце, костер, батарея отопления и электрический нагреватель выполняют функцию нагревания или излучения тепла.




    // нельзя создать дочерного объект
    // в асбстрактном классе мы описываем базовый функционал




        // public - модификатор доступа, в таком случае мы говорим, что этот модификатор будет доступен везде
       // public


        // protected - будет доступен исключительно в этом классе, где он был создан, его можно передать с помощью наследования
      //  protected


        // private - будет доступен исключительно в этом классе
    //    private




        // когда мы создаем статическое поле, то это означает, что мы имеем доступ к нему сразу через название класса
        // через static - мы просто обращаемся напрямую к названию поля, нам не нужно создавать объект
        public static int count;



        public string name;
        public int weight;
        public byte[] coordinates;

        public string Name {get {
            return name;
        }
        private set {}
        }

        // с помощью аксессора мы можем контролировать установку и получения данных
        public int Weight {
            // срабатывает при получении данных с какого-то поля
            get {
                System.Console.WriteLine("all is good");
                return this.weight;
            }
            set {
            // устанавливаем то значение, которое передает нам пользователь
            if(value < 1)
                this.weight = value;
            }
        }

        // название конструкторо должно быть такое же как и название класса
        // конструктор получаем параметры

        public int Weight1 { private get; set;}

        public Robot(string name, int weight, byte[] coordinates) {
            System.Console.WriteLine("object has been created");

            // this - означает что мы обращаемся к этому же класу
            this.setValues(name, weight, coordinates);

        }
        public void setValues(string name, int weight, byte[] coordinates) {
            this.name = name;
            this.weight = weight;
            this.coordinates = coordinates;
        }


        // виртуальные методы
        public virtual void printValues() {
        System.Console.WriteLine(this.name + "weight"  + this.weight +  ".coordinates");
            foreach(byte el in coordinates)
            System.Console.WriteLine(el);
        }

        public static void Print() {
            System.Console.WriteLine("i'm hier");
        }

        public void Jump()  {
            System.Console.WriteLine("robot is jumping");
        }
    }
}