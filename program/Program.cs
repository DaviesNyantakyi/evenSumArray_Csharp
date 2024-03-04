using System;
using System.Globalization;



// Create an array of integers and write a program to find the sum of all even numbers in the array.
class MyApp
{
    class Program
    {
        static void Main()
        {
            int[] numbers = {1,2,3,4,5,6,7,8,9,10};
            // create a varbiable sum;
            // Loop trough the numbers
            // Check if the remainder of the number is 0
            // add to sum if the remainder is 0.

            int sum = 0;

            for(int i = 0; i< numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            Console.WriteLine(sum);
        }
            
    }
}

