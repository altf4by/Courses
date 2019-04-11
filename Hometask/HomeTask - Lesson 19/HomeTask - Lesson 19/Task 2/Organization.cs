using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Organization
    {
        protected Worker[] workers;
        private int counter = 0;

        public Organization(int workersQuantity)
        {
            workers = new Worker[workersQuantity];
            FillOrganization();
        }

        public void AddWorker(Worker worker)
        {
            if (counter <= 5)
                workers[counter++] = worker;
        }

        public void AddUserWorker()
        {
            Console.Write("Please, Enter Last name of the worker{0}: ", counter+1);
            string lastName = Console.ReadLine();

            Console.Write("Please, Enter position of the worker{0}: ", counter+1);
            string position = Console.ReadLine();

            Console.Write("Please, Enter year of start working of the worker{0}: ", counter+1);
            int year = Int32.Parse(Console.ReadLine());

            AddWorker(new Worker(lastName, position, year));
        }

        public void FillOrganization()
        {
            do
            {
                AddUserWorker();
                Console.WriteLine();
            } while (counter!=5);
            Sort();
        }
         
        public void DisplayExperiencedWorked(int experienceYears)
        {
            if (experienceYears > 0)
            { foreach (Worker worker in workers)
                    if (worker.Experience >= experienceYears)
                        Console.WriteLine(worker.Display()); }
            else Console.WriteLine("Incorrect input");
        }

        public void Sort()
        {
            Worker temp = new Worker();
            bool isEnterAllowed = true;

            int length = workers.Length;

            while (isEnterAllowed)
            {
                isEnterAllowed = false;
                for (int i = 1; i < length; i++)
                {
                    if (workers[i - 1].LastName.CompareTo(workers[i].LastName)==1)
                    {
                        temp = workers[i - 1];
                        workers[i - 1] = workers[i];
                        workers[i] = temp;
                        isEnterAllowed = true;
                    }
                }
                length--;
            }
        }
    }
}
