using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_5_Regular_Expressions_5
{
    class Program
    {
        static void Main()
        {
            Regex regex;
            string pattern;
            string text;

            pattern = "^[qwerty]+$";
            text = "qwec";
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            pattern = "^[qwerty]+$";
            text = "qrwere";
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            pattern = "^[abcdefghigklmnopqrstuvwxyz]+$";
            text = "test";
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            pattern = @"^[a-z]+$";
            text = "test";
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            pattern = "^[a-z0-9]+$";
            text = "test007";
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            pattern = "^[a-z0-9]+$";
            text = "test 007";
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            pattern = @"^\d{2}-\d{2}-\d{4}$";
            text = "02-05-1982";
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            pattern = @"^\d*$";
            text = "ertty";
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            pattern = @"^\d*$";
            text = "";
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));


            pattern = @"^[0-9a-z_-]+@[\S]+\.\S{2,4}$";
            text = "test@mail123.rлu";
            regex = new Regex(pattern);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            Console.ReadKey();
        }
    }

}
