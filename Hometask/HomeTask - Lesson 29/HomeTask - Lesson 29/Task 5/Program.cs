using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = new List<string>();
            text.AddRange(Console.ReadLine().Split(' '));


            var query = from word in text
                        group word by word into temp
                        select new
                        {
                            GroupName = temp.Key,
                            Count = temp.Count(),
                        };

            var query2 = text.GroupBy(word => word).Select(word=>new { GroupName = word.Key, Count = word.Count() });

            // into temp
            //let number = temp.Count(word++)
            //select new { Number = number++ }; 

            foreach (var group in query2)
            {
                Console.WriteLine($"{group.GroupName} - {group.Count}");
            }

            Console.ReadKey();
        }
    }
}