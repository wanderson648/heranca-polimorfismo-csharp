

namespace Teste.Entities
{
    class LegalPerson : Person
    {
        public int NumberOfEmployees { get; set; }

        public LegalPerson(string name, double anuualIncome, int numberOfEmployees) : base(name, anuualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double TotalTax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnuualIncome * 14 / 100;
            }

            return AnuualIncome * 16 / 100;
        }
    }
}
