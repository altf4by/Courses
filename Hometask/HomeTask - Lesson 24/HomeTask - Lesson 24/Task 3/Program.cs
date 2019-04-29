using System;
using System.Collections;
using System.Collections.Generic;


namespace Task_3
{
    class Program
    {
        static void Main()
        {
            Console.WindowWidth = 100;

            ArrayList dic = new ArrayList();

            dic.Add(new Auto("Toyota Corolla", 180, 300000, 5, 1));
            dic.Add(new Auto("VAZ 2114i", 160, 220000, 0, 2));
            dic.Add(new Auto("Daewoo Nexia", 140, 260000, 5, 3));
            dic.Add(new Auto("Honda Torneo", 220, 400000, 7, 4));
            dic.Add(new Auto("Audi R8 Best", 360, 4200000, 3, 5));

            Console.WriteLine("Исходный каталог автомобилей: \n");

            foreach (Auto a in dic)
                Console.WriteLine(a);

            dic.Sort(new AutoPriceComparer());
            //dic.Sort(new AutoPriceComparer2());

            Console.WriteLine("\nКаталог авто после сортировки по цене: \n");

            foreach (Auto a in dic)
                Console.WriteLine(a);

            Console.ReadLine();
        }
    }

}
