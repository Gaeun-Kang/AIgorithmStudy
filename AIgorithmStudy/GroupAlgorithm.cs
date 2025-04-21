using System;
using System.Collections.Generic;
using System.Linq;

class GroupAlgorithm
{
    // 테스트용 레코드 클래스 
    class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }


    static List<Product> GetAll()
    {
        return new List<Product>
        {
            new Product { Name = "RADIO", Quantity = 3 },
            new Product { Name = "DVD", Quantity = 4 },
            new Product { Name = "TV", Quantity = 5 },
            new Product { Name = "PHONE", Quantity = 2 },
            new Product { Name = "RADIO", Quantity = 1 },
            new Product { Name = "TV", Quantity = 1 },

        };
    }

    static void PrintData(string message, List<Product> data)
    {
        Console.WriteLine(message);
        foreach (var item in data)
        {
            Console.WriteLine($"{item.Name,6} - {item.Quantity}");
        }
    }

    static void Main()
    {
        //[1] Input
        List<Product> products = GetAll(); //input
        List<Product> groups = new List<Product>();//output

        int N = products.Count();

        //[2] Process : Group Algorithm( SORT -> SUM -> GROUP)

        //[2-1] Sort
        for(int i = 0; i < N; i++)
        {
            for(int j = i + 1; j < N; j++)
            {
                //Swap
                if (string.Compare(products[i].Name, products[j].Name)>0)
                {
                    var t = products[i];
                    products[i] = products[j];
                    products[j] = t; 
                }
            }

        }

        //Group

        int total = 0; 
        for (int i =0; i < N; i++)
        {
            total += products[i].Quantity; //sum
            if((i+ 1) == N || (products[i].Name != products[i+1].Name))
            {
                groups.Add(new Product { Name = products[i].Name, Quantity = total });
                total = 0; //초기화
            }
        }
       
        //[3] Output
        PrintData("Orgin Data", products);
        PrintData("total Data", groups);
        PrintData("LINQ Group Data", groups.GroupBy(r => r.Name).
            Select(g => new Product
            { Name = g.Key, Quantity = g.Sum(n=>n.Quantity)}).ToList());
    }
}