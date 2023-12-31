using System;

namespace project {


    class Bot: Robot{


    //Модификатор abstract указывает, что изменяемый элемент имеет отсутствующую или неполную реализацию. Модификатор abstract можно использовать с классами, методами, свойствами, индексаторами и событиями. Используйте модификатор abstract в объявлении класса, чтобы указать, что класс предназначен только для использования в качестве базового класса для других классов и не должен быть создан сам по себе. Элементы с пометкой abstract должны быть реализованы не абстрактными классами, производными от абстрактного класса.

        // conctructor
        // base() - обращение к классу родителю
        public Bot(string name, int weight, byte[] coordinates) : base(name, weight, coordinates) {
        }

    }
}