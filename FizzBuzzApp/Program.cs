using FizzBuzzModels;
using System;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1; i<= 100; i++)
            {
                Console.WriteLine(FizzBuzzDto.GetResult(i));
            }
        }
    }
}
