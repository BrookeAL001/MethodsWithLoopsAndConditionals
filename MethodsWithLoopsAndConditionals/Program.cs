using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {

        //Write a method that will print to the console all numbers 1000 through -1000.

        public static void Main(string[] args)

        {
            PrintRange(1000, -1000);
        }

        public static void PrintRange(int ceiling, int floor)

        {
            for (int i = ceiling; i >= floor; i--)
            {
                Console.WriteLine(i);
            }

            //Write a method that will print to the console numbers 3 through 999 by 3 each time.

            static void Main(string[] args)
            {
                Threes();
            }

            static void Threes()

            {
                for (int k = 3; k <= 999; k += 3)
                {
                    Console.WriteLine(k);
                }
            }

        }

        //Write a method to accept two integers as parameters and check whether they are equal or not.



        public static bool IsEqual(int a, int b)
        {
            if (a == b)
            {
                return true;
            }

            return false;
        }

        //Write a method to check whether a given number is even or odd.

        public static void EvenOrOdd(int number)

        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"This number is even");
            }

            else
            {
                Console.WriteLine($"This number is odd");
            }

        }

        //Write a method to check whether a given number is positive or negative.

        public static void PositiveOrNegative(int num1)

        {
            if (num1 > 0)
            {
                Console.WriteLine($"This number is Positive");

            }

            else

            {
                Console.WriteLine($"This number is Negative");
            }
        }
            //Write a method to read the age of a candidate and determine whether they can vote.
            //Hint: use Parse()... or the safer TryParse() for an extra challenge!!


            public static bool VotingAge(int age)
            {
                if (age > 18)
                {
                    Console.WriteLine($"You are old enough to vote");
                    return true;
                }

                else
                {
                    Console.WriteLine($"You are too young to vote");

                    return false;
                }
            }

            //Write a method to check if an integer(from the user)
            //is in the range -10 to 10.

            public static bool RangeOfTen(int num2)

            {
                if (num2 <= 10 && num2 >= -10)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }






        
    }
}


