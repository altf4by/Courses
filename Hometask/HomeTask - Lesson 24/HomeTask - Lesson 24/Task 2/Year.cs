using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Year : IEnumerable
    {
        private 
            Month[] months;

        public Year()
        {
            months = new Month[12];
            months[0] = new Month("January", 1, 31);
            months[1] = new Month("February", 2, 28);
            months[2] = new Month("March", 3, 31);
            months[3] = new Month("April", 4, 30);
            months[4] = new Month("May", 5, 31);
            months[5] = new Month("June", 6, 30);
            months[6] = new Month("July", 7, 31);
            months[7] = new Month("August", 8, 31);
            months[8] = new Month("September", 9, 30);
            months[9] = new Month("October", 10, 31);
            months[10] = new Month("November", 11, 30);
            months[11] = new Month("December", 12, 31);
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < months.Length; i++)
                yield return months[i];           
        }

        public Month GetMonthByPosition(int position)
        {
            Month tempMonth = null;
            if (position > 0 && position <= months.Length)
                tempMonth = months[position - 1];

            else
                throw new ArgumentOutOfRangeException("Index of the month can be in the range between 1 and 12.");

            return tempMonth;
        }

        public IEnumerable GetMonthsByDays(int days)
        {
            foreach (Month item in months)
            {
                if (item.Days == days)
                    yield return item;
            }
            yield break;
        }
    }
}
