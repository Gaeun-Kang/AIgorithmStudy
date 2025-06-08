using System;


namespace C_IntroductoryProject
{
    internal class Switch
    {

        //switch

        public enum Color { Red, Green, Blue };
       public static void Main()
        {

            Color c = (Color)(new Random()).Next(0, 3);
            Console.WriteLine("Choose '{0}'", c);
            switch (c)
            {
                case Color.Red:
                Console.WriteLine("The color is Red");
                    break;
                case Color.Green:
                    Console.WriteLine("The color is Green");
                    break;
                case Color.Blue:
                    Console.WriteLine("The Color is Blue");
                break;
                default:
                Console.WriteLine("Unknown Color");
                break;
            }
        }
    }
}
