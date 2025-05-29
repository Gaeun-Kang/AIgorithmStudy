using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_IntroductoryProject
{
    internal class EnumStudy
    {
        enum Size { Tall, Grande, Venti};
        static int[] price = { 3300, 4500, 5000 };

        static void Main(string[] args)
        {
            Console.WriteLine("카페 메뉴판");
            for (int i = 0; i < 3; i++)
            {

                if (i == (int)Size.Tall)
                {
                    Console.WriteLine("{0} : {1}", Size.Tall, price[i]);
                }

                if(i == (int)Size.Grande)
                {
                    Console.WriteLine("{0} : {1}", Size.Grande, price[i]);
                }
                if(i == (int)Size.Venti)
                {
                    Console.WriteLine("{0} : {1}", Size.Venti, price[i]);
                }
            }

        }
    }
}
