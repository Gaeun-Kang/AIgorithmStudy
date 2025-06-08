using System;

namespace C_BasicProject
{
    class BasicArray
    {

        static void Main(string[] args)
        {
            int[] food = { Ramen, Bread, Drink };
            Console.Write("a[] :");
            foreach (var value in food)
                Console.Write(value + "");
        }
    }
}
