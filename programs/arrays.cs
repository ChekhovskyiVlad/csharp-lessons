using System;

namespace project{
    class Program4 {
        static void Main(){

            // nums - это название массива
            // new нужно для выделение памяти
            int[] nums = new int[5];

            // обратились к первому елементу
            nums[0] = 250;
            nums[1] = 230;
            nums[2] = 2530;
            nums[3] = 253420;
            nums[4] = 250423;

            // разница массива с переменной, есть то, что в масииве можно хранить множество значений
            Console.WriteLine("EL: " + nums[0]);
            string[] strings = new string[] {"daniel", "vlad", "bob"};

            strings[1] = "bobbi";
            for(byte i = 0;i < nums.Length; i++) {
                System.Console.WriteLine("El" + nums[i]);
            }



            short[] numbers = new short[5];
            short sum = 0;
            Random random = new Random();

            for(byte i = 0;i < numbers.Length;i++ ){


                // 1 - минимальное значение, 432412 - максимальное значение
                numbers[i] = Convert.ToInt16(random.Next(-3312, 4243));

                sum += numbers[i];

                System.Console.WriteLine("El:" + numbers[i]);

                System.Console.WriteLine("Sum:" + sum);
            }


            // все что выше это были одномерные массивы - где каждый элемент имеет определенное значение
            // в многомернных - каждый элемент другой определенный массив

            // чтобы создать двумернный массив нужно добавить запятую
            char[,] symbols = new char[2,3];

            // мы обратились к элементу массиву, то естьь первый массив, и в нем я обращаюсь к первому массиву того же элемента
            /*
                в js это было бы так

                [
                        temp: {
                            number: 321;
                            string: "rewqrq";
                            symbols: {
                                321,
                                "rew",
                                231
                            }
                        }
                ]
            */
            symbols[0, 0] = 'H';
            System.Console.WriteLine(symbols[0, 0]);


            // пример двухмерного массива
            int[,] nums1 = {
                {4, 6, 7},
                {42, 123, 43},
                {4, 6, 7},

            };
            // то есть вместо 43, будет 321
            nums1[1, 2] = 321;


            

        }
    }
}