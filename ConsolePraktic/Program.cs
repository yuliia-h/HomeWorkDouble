using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePraktic
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Practice one
            Console.WriteLine("Hello world!!!");
            Console.WriteLine("One...");
            Console.WriteLine("Two...");
            Console.WriteLine("Three...");

            Console.Write("Four...");
            Console.Write("Five..");
            Console.Write("Six...");
            Console.WriteLine("New line!");

            Console.WriteLine("");

            Console.WriteLine("New line..." + Environment.NewLine + "... now yes!!!");
            Console.WriteLine("Tab\tTab2\tTab3");
            Console.WriteLine("Reverse oblique:\\Quotes:\"");

            Console.ReadLine();

            //Practice 2
            Console.Write("Enter name and press Enter: ");

            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name + "!");

            Console.Write("Enter pizza name and press Enter: ");
            string pizza = Console.ReadLine();
            Console.WriteLine("Hello, {0}! One {1} pizza on the way!", name, pizza);

            Console.Write("Enter your age and press Enter: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter you height and press Enter (can use fractions): ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You {0} age, and height {1}.", age, height);

            Console.ReadLine();

            //Practice 3
            int num1 = 15;
            int num2 = 10;

            int addAnswer = num1 + num2;
            int subAnswer = num1 - num2;
            int mulAnswer = num1 * num2;
            int divAnswer = num1 / num2;
            int modAnswer = num1 % num2;
            int bigAnswer = (num1 - num2) * num2 + num1;

            Console.WriteLine("number1 == {0}, and number2 == {1}...", num1, num2);
            Console.WriteLine(" + " + addAnswer);
            Console.WriteLine(" - " + subAnswer);
            Console.WriteLine(" * " + mulAnswer);
            Console.WriteLine(" / " + divAnswer);
            Console.WriteLine(" % " + modAnswer);
            Console.WriteLine("Result \"(num1-num2)*num2+num1\":" + bigAnswer);

            Console.WriteLine("Max number: " + Math.Max(num1, num2));
            Console.WriteLine("Min number: " + Math.Min(num1, num2));

            double num3 = 94.537;
            Console.WriteLine(Environment.NewLine + "Original number:\t" + num3);
            Console.WriteLine("Round off...");
            Console.WriteLine("2 numbers before comma:\t" + Math.Round(num3, 2));
            Console.WriteLine("1 number before comma:\t" + Math.Round(num3, 1));
            Console.WriteLine("0 number before comma:\t" + Math.Round(num3, 0));

            Console.WriteLine(Environment.NewLine + "Pi = " + Math.PI);

            Console.Write(Environment.NewLine + "Enter first number for multi: ");
            double mull = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            double mul2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} * {1} = {2}", mull, mul2, (mull * mul2)); ;

            Console.WriteLine(Environment.NewLine + "12 / 5 = ?");
            double badAnswer = 12 / 5;
            double goodAnswer = 12.0 / 5.0;
            Console.WriteLine("Wrong result: {0}\n" +
                "Correct result: {1}",
                badAnswer, goodAnswer);

            Console.ReadLine();

        }
    }
}
