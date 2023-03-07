using System;
using System.Linq;

namespace MethodsExercise
{
    class Program
    {
        //Exercise 1
        public static void MadLib()
        {
            Console.WriteLine("Name?");
            var fullName = Console.ReadLine();

            //string interpolation with $
            Console.WriteLine($"Hi, {fullName}, what's your fave color?");
            var faveColor = Console.ReadLine();

            Console.WriteLine("Fave Animal?");
            var faveAnimal = Console.ReadLine();

            Console.WriteLine("Fave Band?");
            var faveBand = Console.ReadLine();

            Console.WriteLine($"One day, {fullName} was walking through the woods wearing {faveColor} pants." +
                $" Suddenly, a {faveAnimal} appeared with an iPod. " +
                $"It was listening to {faveBand}. {fullName} was surprised it liked {faveBand}, too!");
        }

        // Exercise 2 Methods
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        public static double Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        //Optional (Challenge Mode):
        public static int Add(params int[] nums)
        {
            var sum = 0;
            foreach (var x in nums)
            {
                sum += x;
            }

            return sum;

            //return nums.Sum();
        }

        //Params with Multiply
        public static int Multiply(params int[] nums)
        {
            var product = 1;
            foreach (var x in nums)
            {
                product *= x;
            }

            return product;

            //return nums.Aggregate((x, y) => x * y);
        }

        //Params with Subtract
        public static int Subtract(params int[] nums)
        {
            //Assign diff to 1st num
            int diff = nums[0];

            //Start for loop at 2nd element in array and continue on
            for (var x = 1; x < nums.Length; x++)
            {
                diff -= nums[x];
            }

            return diff;

            //Works
            //return nums.Aggregate((x, y) => x - y);
        }

        //Params with Divide - Doesn't work with doubles; shows infinity symbol
        public static int Divide(params int[] nums)
        {
            int quotient = 1;

            foreach (var x in nums)
            {
                try
                {
                    quotient /= x;
                }
                catch (Exception zero)
                {                    
                    Console.WriteLine(zero.Message);
                    Console.WriteLine("Can't divide by zero\n");
                }
            }

            return quotient;
        }

        static void Main(string[] args)
        {
            //Exercise 1

            //MadLib();

            //start Exercise 2 code

            //var amountOfCars = Sum(2, 6);
            //Console.WriteLine($"There are {amountOfCars} cars");

            //var blah = Multiply(60, 2, 4);
            //Console.WriteLine(blah);

            //var addition = Add(7, 3, 9, 4);
            //Console.WriteLine(addition);

            //Console.WriteLine(Add(10, 10, 10, 10));

            //Experiment Call

            //Console.WriteLine(Add(AskForNum()));

            //Console.WriteLine("Mulitply: 2, 2, 2, 2, 2");
            //Console.WriteLine(Multiply(2, 2, 2, 2, 2));

            //Console.WriteLine("Mulitply: 2, 2, 0, 2, 2");
            //Console.WriteLine(Multiply(2, 2, 0, 2, 2));

            //Console.WriteLine("Subtract: 2, 2, 2, 2, 2");
            //Console.WriteLine(Subtract(2, 2, 2, 2, 2));

            //Console.WriteLine("Subtract: 12, 2, 2, 2, 2");
            //Console.WriteLine(Subtract(12, 2, 2, 2, 2));

            //Should get .25
            Console.WriteLine("Divide: 4, 2, 2, 2, 2");
            Console.WriteLine(Divide(4, 2, 2, 2, 2));

            Console.WriteLine("Divide: 200, 2, 0, 2, 2");
            Console.WriteLine(Divide(200, 2, 0, 2, 2));
        }

        //Experiment:
        public static int[] AskForNum()
        {
            //Ask user how many numbers
            Console.WriteLine("How many numbers do you want to add?");
            var numOfInputs = int.Parse(Console.ReadLine());

            var numArray = new int[numOfInputs];

            for (var x = 0; x < numArray.Length; x++)
            {
                var cont = false;

                do
                {
                    Console.WriteLine("Enter a number:");
                    cont = int.TryParse(Console.ReadLine(), out numArray[x]);

                } while (!cont);
            }
            return numArray;
        }

    }

}
