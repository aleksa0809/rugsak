using System;
using System.Collections.Generic;

namespace Rucksak
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> inner = new List<string>();
            while (true)
            {
                
                Console.WriteLine("1- add");
                Console.WriteLine("2- print");
                Console.WriteLine("3-clear");
                Console.WriteLine("4-exit");

                string k = Console.ReadLine();

                switch (k )
                {
                    case "1":
                        Console.WriteLine("enter the product name");
                        string product = Console.ReadLine();
                       
                        inner.Add(product);
                        break;

                    case "2":
                       
                        foreach (string s in inner)
                            Console.WriteLine(s);
                        break;
                    case "3":
                        inner.Clear();
                        break;
                    case "4":
                        return;
                       // break;

                        

                }
            }


            
        }
    }
}
