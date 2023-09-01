using System.Globalization;
using Teste.Entities;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> list = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (c/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new PhysicalPerson(name, income, health));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    list.Add(new LegalPerson(name, income, employees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");

            double sumTax = 0.0;
            foreach(Person person in list)
            {
                sumTax += person.TotalTax();
                Console.WriteLine($"{person.Name}: $ {person.TotalTax().ToString("f2", CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {sumTax.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}