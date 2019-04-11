using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class RailwayStation
    {
        protected Train[] trains = new Train[0];

        public Train this[string index]
        {
            get
            {
                if (!string.IsNullOrEmpty(index) && trains.Length > 0)
                    foreach (Train train in trains)
                        if (train.Number.ToString() == index)
                            return train;
                return new Train("exit", "exit", new DateTime());
            }
        }

        public void Add(Train train)
        {
            Array.Resize(ref trains, trains.Length + 1);
            trains[trains.Length - 1] = train;
        }

        public void AddUserTrain()
        {
            Console.Write("Enter name of Destination: ");
            string name = Console.ReadLine();

            Console.Write("Enter number of the Train: ");
            string number = Console.ReadLine();

            Console.Write("Enter time of departure: ");
            DateTime dt = DateTime.Parse(Console.ReadLine());

            Add(new Train(name, number.ToString(), dt));
        }
    }
}
