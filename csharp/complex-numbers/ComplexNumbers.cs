using System;

public struct ComplexNumber
{
    private double RealNumber { get; }
    private double ImaginaryNumber { get; }

    public ComplexNumber(double real, double imaginary)
    {
        RealNumber = real;
        ImaginaryNumber = imaginary;
    }

    public double Real() => RealNumber;

    public double Imaginary() => ImaginaryNumber;

    public ComplexNumber Mul(ComplexNumber other)
    {
        double real = (RealNumber * other.RealNumber) - (ImaginaryNumber * other.ImaginaryNumber);
        double imaginary = (RealNumber * other.ImaginaryNumber) + (ImaginaryNumber * other.RealNumber);
        return new ComplexNumber(real, imaginary);
    }

    public ComplexNumber Add(ComplexNumber other)
    {
        return new ComplexNumber(RealNumber + other.RealNumber, ImaginaryNumber + other.ImaginaryNumber);
    }

    public ComplexNumber Sub(ComplexNumber other)
    {
        return new ComplexNumber(RealNumber - other.RealNumber, ImaginaryNumber - other.ImaginaryNumber);
    }

    public ComplexNumber Div(ComplexNumber other)
    {
        ComplexNumber divisorConjugate = other.Conjugate();
        ComplexNumber top = Mul(divisorConjugate);
        ComplexNumber bottom = other.Mul(divisorConjugate);
        return new ComplexNumber(top.RealNumber / bottom.RealNumber, top.ImaginaryNumber / bottom.RealNumber);
    }

    public double Abs() => Math.Sqrt(RealNumber*RealNumber + ImaginaryNumber*ImaginaryNumber);

    public ComplexNumber Conjugate() => new ComplexNumber(RealNumber, ImaginaryNumber * -1);

    public ComplexNumber Exp()
    {
        double real = Math.Pow(Math.E, RealNumber) * Math.Cos(ImaginaryNumber);
        double imaginary = Math.Pow(Math.E, RealNumber) * Math.Sin(ImaginaryNumber);
        return new ComplexNumber(real, imaginary);
    }
}