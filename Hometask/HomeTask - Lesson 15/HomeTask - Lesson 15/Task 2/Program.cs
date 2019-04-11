using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom pupuls = new ClassRoom(new ExcellentPupil("Petr","Petrov"));

            pupuls.AddPupil(new GoodPupil("Ivan", "Ivanov"));
            pupuls.AddPupil(new BadPupil("Semen", "Semenov"));
            pupuls.AddPupil(new ExcellentPupil("Dmitry", "Dmitrov"));
            pupuls.AddPupil(new ExcellentPupil("Dmitry", "Dmitrov"));

            for (int i = 0; i < pupuls.Length; i++)
            {
                pupuls[i].Read();
                pupuls[i].Relax();
                pupuls[i].Study();
                pupuls[i].Write();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
