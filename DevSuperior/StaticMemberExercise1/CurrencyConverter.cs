using System;
using System.Globalization;

namespace StaticMemberExercise1;
public static class CurrencyConverter
{
    public static double Iof = 1.06;

    public static double DolToBrl(double dolar, double quantity)
    {
        return quantity * dolar * Iof;
    }
}
