using System;
using System.Globalization;

namespace ClassExercise1;
internal class Rectangle
{
    public double Width;
    public double Height;

    public double Area()
    {
        return Width * Height;
    }

    public double Perimeter()
    {
        return (Width * 2) + (Height * 2);
    }

    public double Diagonal()
    {
        return Math.Sqrt((Width*Width) + (Height*Height));
    }

    public override string ToString()
    {
        return "AREA = " 
            + Area().ToString("F2", CultureInfo.InvariantCulture) 
            + "\nPERIMETER = " + Perimeter().ToString("F2", CultureInfo.InvariantCulture)
            + "\nDIAGONAL = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture); 
    }
}
