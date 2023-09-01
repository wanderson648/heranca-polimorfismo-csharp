

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
            double tax = 0;

            if (AnuualIncome >= 20_000 && HealthExpense >= 0)
            {
                tax = (AnuualIncome * 25 / 100) - (HealthExpense * 50 / 100);
            }
            else if (AnuualIncome < 20_000 && HealthExpense >= 0)
            {
                tax = (AnuualIncome * 15 / 100) - (HealthExpense * 50 / 100);
            }
            return tax;
        }
    }
}
