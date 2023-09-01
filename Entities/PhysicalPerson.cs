

namespace Teste.Entities
{
    class PhysicalPerson : Person
    {

        public double HealthExpense { get; set; }

        public PhysicalPerson(string name, double anuualIncome, double healthExpense) : base(name, anuualIncome)
        {
            HealthExpense = healthExpense;
        }

        public override double TotalTax()
        {
            if (AnuualIncome >= 20_000)
            {
                return (AnuualIncome * 25 / 100) - (HealthExpense * 50 / 100);
            }
            return (AnuualIncome * 15 / 100) - (HealthExpense * 50 / 100);
        }
    }
}
