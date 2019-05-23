using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ефыл_16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Action> actions = new List<Action>();
            for (int i = 0; i < 10; i++)
            {
                int y = i;
                actions.Add(() => Console.WriteLine(y));
            }
            foreach (var action in actions)
            {
                action();
            }

        }
    }
}
