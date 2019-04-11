using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_5
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesPerson fred = new SalesPerson();
            fred.Age = 31;
            fred.Name = " Fred ";
            fred.SalesNumber = 50;

            Manager chukky = new Manager("Chukky",50,92,100000,"332-23-2322",9000);
            double cost = chukky.GetBenefitCost();
            chukky.GiveBonus(300);
            chukky.DisplayStats();
            Console.WriteLine();

            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "9-32-32-3232 ", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();

            Employee emp = new SalesPerson("Fran", 43, 93, 3000, "9-32-32-3232 ", 31);



            Console.ReadLine();
        }

        static void CastingExamples()
        {
            object frank = new Manager("Frank Zappa",9,300, 40000, " 1-11-11-1111",5);

            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101 -11-132 1", 1);
            GivePromotion(moonUnit);

            PTSalesPerson jill = new PTSalesPerson("Jill", 834, 3002, 10000, "101 -11-132 1", 90);
            GivePromotion(jill);
            GivePromotion((Manager)frank);
        }

        static void GivePromotion(Employee emp)
        {
            Console.WriteLine("{0} was promoted", emp.Name);
        }
    }
}
