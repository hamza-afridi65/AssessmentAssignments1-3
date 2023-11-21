using System;

namespace AssessmentAssignments
{
    class Program
    {

        //1ST PROGRAM

        public static void NumberofSocks()
        {
            Console.WriteLine("Enter Letters of the Socks: ");
            string sockLetters = Console.ReadLine();

            int sockPairs = 0;

            int[] letterCount = new int[128];

            foreach (char sock in sockLetters)
            {
                letterCount[sock]++;
            }

            foreach (int count in letterCount)
            {
                sockPairs = sockPairs + count / 2;
            }

            Console.WriteLine($"The Number of Pairs are {sockPairs}");
        }




        //2ND PROGRAM

        public static void DisplaySeriesAndSum(int numberOfTerms)
        {
            int sum = 0;
            int Digit = 9;

            Console.Write("The series: ");

            for (int i = 0; i < numberOfTerms; i++)
            {
                Console.Write($"{Digit} ");

                sum = sum + Digit;

                Digit = Digit * 10 + 9;
            }

            Console.WriteLine($"\nThe sum of the series = {sum}");
        }



        

        //3RD PROGRAM

        static void AddTwoIndirectly(string num1, string num2)
        {
            int maxLength;

            if (num1.Length > num2.Length)
            {
                maxLength = num1.Length;
            }
            else
            {
                maxLength = num2.Length;
            }

            while (num1.Length < maxLength)
            {
                num1 = '0' + num1;
            }

            while (num2.Length < maxLength)
            {
                num2 = '0' + num2;
            }

            string result = "";

            for (int i = 0; i < maxLength; i++)
            {
                int digit1 = int.Parse(num1[i].ToString());
                int digit2 = int.Parse(num2[i].ToString());

                result += digit1 + digit2;
            }

            Console.WriteLine("Concatenated Result: " + result);
        }



        //4th PROGRAM
        static void CountPositivesAndSumNegatives()
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int countPositives = 0;
            int sumNegatives = 0;

            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    countPositives++;
                }
                else if (number < 0)
                {
                    sumNegatives += number;
                }
            }

            // Display the entered array
            Console.WriteLine("Entered array:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            // Display the result
            Console.WriteLine($"\nResult: [{countPositives}, {sumNegatives}]");
        }





        //5th Program
        static void BubbleSortAndDisplay(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Swap if the element found is greater than the next element
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            // Display the sorted array
            Console.WriteLine("\nSorted array:");
            foreach (int number in arr)
            {
                Console.Write(number + " ");
            }
        }



        static void Main(string[] args)
        {

            //1ST PROGRAM
            //NumberofSocks();



            //// 2nd PROGRAM
            //Console.WriteLine("Input the number of terms: ");
            //int numberOfTerms = Convert.ToInt32(Console.ReadLine());
            //DisplaySeriesAndSum(numberOfTerms);




            ////3RD PROGRAM
            //Console.Write("Enter the first number: ");
            //string num1 = Console.ReadLine();
            //Console.Write("Enter the second number: ");
            //string num2 = Console.ReadLine();
            //AddTwoIndirectly(num1, num2);



            ////4th PROGRAM
            //CountPositivesAndSumNegatives();
            // CountPosSumNeg();




            //5th Program
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter integer {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            BubbleSortAndDisplay(numbers);



            Console.ReadLine();
        }
    }
}
