using System.Runtime.Intrinsics.X86;

namespace AbstractMethodsExercise1.Entities;
internal class Individual : TaxPayer
{
    public double HealthExpendures { get; set; }

    public Individual()
    {

    }
    public Individual(string name, double anualIncome, double healthExpendures) : base(name, anualIncome)
    {
        HealthExpendures = healthExpendures;
    }

    public sealed override double Tax()
    {
        double tax = 0.0;
        if (AnualIncome < 20000.00)
        {
            tax = AnualIncome * 0.15;
        }
        else 
        {
            tax = AnualIncome * 0.25;
        }
        return tax - (HealthExpendures * 0.5);
    }
}
