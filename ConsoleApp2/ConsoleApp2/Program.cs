using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int res = Sum(10, 56);
            //Console.WriteLine(res);

            ////Sum(10, 56);
            //Console.WriteLine("Point1");


            //ShowError();
            //PrintWelcome("Mamed");


            //Compare(20, 91);

            //string res = ReturnPersonInfo("mamed", "mamedovich",21);

            //Console.WriteLine(res);


            //int[] nums = { 1, 2, 3, 4, 5, 6, 7 };

            //int[] nums2 = { 11, 12, 13, 14, 15, 16, 17 };

            //PrintLargerThanAverage(nums2);

            //Console.WriteLine(Sum(10,15,25));

            //PrintPersonInfo("mamed","aliyev","malyar");

            //PrintPersonInfo("mamed", "aliyev", "driver");

            //int[] nums = { 1, 2, 3, 4, 5, 6, 7 };

            //Console.WriteLine(Average( 1, 2, 3, 4, 5, 6, 7));

            SimplyPrint("Mamed", "mamed", "mamed");
        }

        static void SimplyPrint(params string[] strings)
        {
            Console.WriteLine("Point1");
        }

        static void SimplyPrint(string str1, string str2 = "salam")
        {
            Console.WriteLine("Point3");
        }


        static void SimplyPrint(string str1)
        {
            Console.WriteLine("Point2");
        }

        static int Average( params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("LoopOldu");
                sum += numbers[i];
            }
            return sum / numbers.Length;
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static string Sum(int a, string b)
        {
            return a + b;
        }

        static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }

        static string Welcome(string name)
        {
            return $"Salam ay {name}. Necesen?";
        }
        static void PrintWelcome(string name)
        {
            Console.WriteLine($"Salam ay {name}. Necesen?");
        }

        static void ShowError()
        {
            Console.WriteLine("Daxil etdiyiniz melumatlar yanlisdir.");
        }

        static void Compare(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(a);
                return;
            }
            Console.WriteLine(b);
        }

        //static void PrintPersonInfo(string name, string surname, int age = 10)
        //{
        //    Console.WriteLine($"Name-{name}, surname-{surname}, age-{age}");
        //}

        /// <summary>
        /// Prints persons informtions.
        /// </summary>
        /// <param name="name">String, represents person's name.</param>
        /// <param name="surname">String, represents person's surname.</param>
        /// <param name="workPlace">String, represents person's workPlace.</param>
        /// <param name="age">Int, represents person's age. Has default value of 10.</param>
        static void PrintPersonInfo(string name, string surname, string workPlace, int age = 10)
        {
            Console.Write($"Name-{name}, surname-{surname}, age-{age}, workPlace- {workPlace}");
        }

        static string ReturnPersonInfo(string name, string surname, int age = 10)
        {
            return $"Name-{name}, surname-{surname}, age-{age}";
        }


        static void PrintLargerThanAverage(int[] numbers)
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > Average(numbers))
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
