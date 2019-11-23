using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] multiplicationTable = new int[10, 10];

            for(int i = 1; i <= 10; i++)
            {   
                Console.Write("[");
                for (int j = 1; j <= 10; j++) 
                {
                    Console.Write(i *j + ", ");
                }
                Console.Write("] \n");
            }
        }
    }
}
