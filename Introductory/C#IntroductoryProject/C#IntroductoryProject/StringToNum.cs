using System;


namespace C_IntroductoryProject
{
    internal class StringToNum
    {

        static void Main(string[] args)
        {
            //1. Parse(), TryParse()

            string input;
            int value;

            Console.Write("1. int로 변환할 문자열을 입력하시오");
            input = Console.ReadLine();
            bool result = Int32.TryParse(input, out value);

            if (!result) 

                Console.WriteLine("'{0}'는 int로 변환될 수 없습니다.\n", input);
            else
                Console.WriteLine("int'{0}' 으로 변환되었습니다.\n", value);
            


            Console.Write("2. double로 변환할 문자열을 입력하세요:");
            input = Console.ReadLine();
            try
            {
                double m = Double.Parse(input);
                Console.WriteLine("double '{0} 으로 변환되었습니다.'\n", m);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            //2. convert Class

            int x, y;

            Console.Write("첫 번째 숫자를 입력하세요");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("두 번째 숫자를 입력하세요");
            y= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", x,y,x+y);

            //3

            int baseNum = 2;
            string s = Convert.ToString(value,baseNum);
            int i = Convert.ToInt32(s,baseNum);
            Console.WriteLine("i = {0}, { 1,2} 진수 = { 2,16} ", i, baseNum, s);

        }
    }
}
