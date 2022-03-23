using System;
using System.IO;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            //Challenge1();
            //Challenge2();
            //Challenge3();
            //Challenge4();
            //Challenge5();
            //Challenge6();
            //Challenge7();
            Challenge9();

        }

        public static int Challenge1()
        {
            int output;
            int product = 1;
            Console.WriteLine("please enter 3 numbers seperated by space");
            string input = Console.ReadLine();
            string[] arr = input.Split(" ");

            for (int i = 0; i < 3; i++)
            {

                output = Convert.ToInt32(arr[i]);
                product *= output;

            }
            Console.WriteLine($"your numbers : {arr[0]},{arr[1]},{arr[2]}");
            Console.WriteLine($"The product of these 3 numbers is: {product} ");

            return product;
        }
        public static decimal Challenge2()
        {
            Console.WriteLine("please enter a number between 2-10");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[input];
            int sum = 0;
            decimal average = 0;
            if (input < 2 || input > 10)
            {
                Console.WriteLine("Invalid Input!");
            }
            else
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"Please enter a number {i + 1} of {arr.Length} ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    sum += arr[i];
                }
                Console.WriteLine($"the sum of these numbers is : {sum}");
                average = decimal.Divide(sum, arr.Length);
                Console.WriteLine($"The average of these numbers is: {average}");
            }
            return average;
        }

        public static void Challenge3()
        {
            int size = 5;
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");

                }
                for (int k = 2; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                Console.WriteLine();

            }
            for (int i = size-1; i >= 1; i--)
            {
                for (int j = size - i; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (int k = i; k >= 1; k--)
                {
                    Console.Write("*");
                }
                for (int k = i - 1; k >= 1; k--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                Console.WriteLine();

            }


        }

        public static void Challenge4()
        {
            int[] arr = new int[] { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
            //int[] arr = new int[] { 1, 2, 3, 4 };
            //int[] arr = new int[] { 1, 1, 1, 1 };
            //int[] arr = new int[] { 1, 1, 2, 2, 3, 3 };

            int duplicate = arr[0];
            int count = 0;
            int count2 = 0;
            for (int i = 0; i < arr.Length ; i++)
            {
              int test = arr[i];
                
              for (int j = 0; j < arr.Length; j++) 
                {
                if (test == arr[j])
                    count++;
                    if (count > count2)
                    {
                        duplicate = test;
                        count2 = count;

                    }
                    count = 0;
                }

            }
            Console.WriteLine($"The most numbers duplicates is : {duplicate} ist {count} times");


        }

        public static void Challenge5()
        {
            int[] arr = new int[] { 120, 1, 90, 55, 140, 3,135 };
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            Console.WriteLine($"The max number in this array is : {max}");

        }

        public static void Challenge6()
        {
            string path = "../../../words.txt";
            if (!File.Exists(path))
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("world");
                }

            Console.Write("Enter your word: ");
            string input = Console.ReadLine();

            using (StreamWriter sw = File.AppendText(path))
                sw.WriteLine(input);
        }

        public static void Challenge7()
        {
            string path = "../../../words.txt";

            Console.WriteLine("words.txt file contains the following words:");

            using (StreamReader sr = new StreamReader(path))
            {
                string word = "";
                while ((word = sr.ReadLine()) != null)
                    Console.WriteLine(word);
            }
        }

        public static void Challenge9() 
        {
            Console.WriteLine("Enter a sentence to be counted.");
            string input = Console.ReadLine();

            string[] arr = input.Split(" ");

            int output;
            string word;
            for (int i = 0; i < arr.Length; i++)
            {
                output = arr[i].Length;

                word = $"\" {arr[i]} : {output} \", ";


                arr[i] = word;
                Console.Write(arr[i]);
            }
        }

    }
}

    