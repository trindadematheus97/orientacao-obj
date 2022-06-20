using System;
using System.Collections.Generic;
using Polimorfismo.Entities;
using System.Globalization;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.WriteLine("Enter the number of employess: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i<= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (( ch == 'y') || ( ch == 'Y'))
                {
                    Console.WriteLine("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new OutSourceEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
                Console.WriteLine();
                Console.WriteLine("Pyments: ");
                foreach (Employee emp in list)
                {
                    Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2",CultureInfo.InvariantCulture));
                }
            }

        }
    }
}
