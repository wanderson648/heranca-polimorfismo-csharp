

namespace Teste.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public double AnuualIncome { get; set; }

        protected Person(string name, double anuualIncome)
        {
            Name = name;
            AnuualIncome = anuualIncome;
        }

        public abstract double TotalTax();
    }
}
