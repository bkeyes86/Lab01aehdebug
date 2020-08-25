using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace lab01
{
    class Program
    {
        static void Main(string[] args)
        { 
        try
        {
            StartSequence();
         }
        catch (Exception ex)
        {
        Console.WriteLine("Unhandled Error!");
        Console.WriteLine(ex.Message);
        
        }
        finally
{
    Console.WriteLine("Program Done");
}

    }
   static void StartSequence()
{
    Console.WriteLine("Enter a number greater than zero");
    var input = Console.ReadLine();
    int inputNum = Convert.ToInt32(input);
      int[] array = new int[inputNum];
            Populate(array);
            int sum = GetSum(array);
            int product = GetProduct(array, sum, inputNum);
            decimal quotient = GetQuotient(product);
            Console.WriteLine($"Your array size is: {inputNum}");
            Console.Write("The numbers in your array are:");
            Console.Write(String.Join(",", array));
            Console.WriteLine($"The sum of your array is {sum}");
            int index = product / sum;
            Console.WriteLine($"{sum} * {index} = {product}");
            decimal divisor = product / quotient;
            Console.WriteLine($"{product} / {divisor} = {quotient}");
            
        }
        static int[] Populate(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter a number between 1-10.");
                string input = Console.ReadLine();
                int inputNum = Convert.ToInt32(input);
                array[i] = inputNum;

            }
            return array;
            
        }

            static int[] GetSum(int[] array)
            {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            if (sum < 20)
                throw new Exception();
            {
                Console.WriteLine($"Value of {sum} is too low");
    
        }
            return sum;
    }

        static int GetProduct(int[] array, int sum)
        {
            Console.WriteLine($"Select a number between 1 and {x - 1}.");
            int product = 0;
            {
                throw new IndexOutOfRangeException();
            }
            return product;
        }
