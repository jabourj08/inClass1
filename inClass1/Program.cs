using System;

namespace inClass1
{
    class Program
    {
        static void Main(string[] args)
        {

            //EXERCISE 1

            /*
            Console.WriteLine("Hello, and welcome to the really cool program where we tell you how old you will be in 10 years!!!!!");
            Console.WriteLine("How old are you currently? ");

            string age = Console.ReadLine();

            int ageNum = int.Parse(age);

            int newAge = ageNum + 10;
            Console.WriteLine("You are currently " + age + " years old.");
            Console.WriteLine("in 10 years, you will be " + newAge + " years old!");
            */

            //EXERCISE 2

            //part 1
            int myInt = 10;
            float myFloat = 12.5f;
            string myString = "C# programming";

            Console.WriteLine("My integer value is: " + myInt);
            Console.WriteLine("My Float value is: " + myFloat);
            Console.WriteLine("My phrase is: " + myString);
            Console.WriteLine();

            //part 2
            Console.WriteLine("How old are you currently? ");
            string age = Console.ReadLine();
            int ageNum = int.Parse(age);

            if (ageNum >= 62)
            {
                Console.WriteLine("Nice! you can start collecting that juicy Social Security check!");
            }
            else
            {
                Console.WriteLine("You have " + (62 - ageNum) + " years before you can start collecting that juicy Social Security check.");
            }


            //EXERCISE 3
            Console.WriteLine("Gimme a number!");

            string input = Console.ReadLine();
            int number = int.Parse(input);
            //int number = int.Parse(Console.ReadLine());

            int counter = 0;

            while (counter <= number)
            {
                Console.WriteLine(counter);
                counter++;
            }

        }
    }
}
