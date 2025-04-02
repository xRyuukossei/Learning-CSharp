using System.Runtime.Intrinsics.X86;

namespace AbstractMethodsExercise1.Entities;
internal class Company : TaxPayer
{
    public int NumberOfEmployee { get; set; }

    public Company()
    {

    }
    public Company(string name, double anualIncome, int numberOfEmployee) : base (name, anualIncome)
    {
        NumberOfEmployee = numberOfEmployee;
    }

    public sealed override double Tax()
    {
        double tax = 0.0;
        if (NumberOfEmployee < 11)
        {
            tax = AnualIncome * 0.16;
        }
        else
        {
            tax = AnualIncome * 0.14;
        }
        return tax;
    }
}
