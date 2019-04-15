using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.House_parts;

namespace Task.Workers
{
    class Team
    {
        IWorker[] workers;

        public Team(params IWorker[] workers)
        {
            this.workers = workers;
        }


        public void StartWork(House house)
        {
            IPart[] houseParts = house.parts;

            for (int i = 0; i < houseParts.Length; i++)
                do
                {
                    foreach (IWorker worker in workers)
                        if (worker is TeamLeader)
                            worker.Work(houseParts[i]);

                    if (TeamLeader.IsPartFinished)
                    {
                        TeamLeader.IsPartFinished = false;
                        break;
                    }
                    for (int j = 0; j < workers.Length; j++)
                        if (workers[j] is Worker)
                            workers[j].Work(houseParts[i]);

                    Console.WriteLine(new string(' ', 15) + "*NEXT DAY*");
                    Console.WriteLine();


                } while (!houseParts[houseParts.Length - 1].IsReady);

        }
    }
}
