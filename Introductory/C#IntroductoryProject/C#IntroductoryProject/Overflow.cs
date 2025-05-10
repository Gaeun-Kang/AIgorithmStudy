using System;


namespace C_IntroductoryProject
{
    internal class Overflow
    {

        static void Main(string[] args)
        {
            Console.WriteLine("int.MaxValue = {0}", int.MaxValue);
            int x = int.MaxValue, y = 0;
            y = x + 10;

            //int의 최대값에 10을 더하면, int의 최대값을 넘어가므로 overflow error가 발생한다. 
            //하지만, 기대한대로 overflow error message가 아닌, -값으로 뜬다. 
            //Console.WriteLine("int.MaxValue + 10 = {0)", y);

            //checked로 에러 메세지를 보낼 수 있다. 

            checked
            {

                try
                {
                    y = x + 10;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

    }
}
