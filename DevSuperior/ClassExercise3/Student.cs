using System;
using System.Globalization;

namespace ClassExercise3;
internal class Student
{
    public string Name;
    public double N1;
    public double N2;
    public double N3;

    public double FinalGrade()
    {
        return N1 + N2 + N3;
    }

    public bool Approved()
    {
        if (FinalGrade() >= 60.0) 
        {
            return true;
        }
        return false;
    }

    public double MissingPoints()
    {
        if (Approved())
        {
            return 0.0;
        }
        else
        {
            return 60.0 - FinalGrade();
        }
    }
}
