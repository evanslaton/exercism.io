using System;
using System.Diagnostics;

public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r)
    {
        double number = Math.Pow(realNumber, r.Numerator);
        return Math.Pow(number, 1.0 / r.Denominator);
    }
}

public struct RationalNumber
{
    public int Numerator { get; private set; }
    public int Denominator { get; private set; }

    public RationalNumber(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
    {
        int numerator = r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator;
        int denominator = r1.Denominator * r2.Denominator;
        return new RationalNumber(numerator, denominator).Reduce();
    }

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        int numerator = r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator;
        int denominator = r1.Denominator * r2.Denominator;
        return new RationalNumber(numerator, denominator).Reduce();
    }
    
    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
    {
        int numerator = r1.Numerator * r2.Numerator;
        int denominator = r1.Denominator * r2.Denominator;
        return new RationalNumber(numerator, denominator).Reduce();
    }
    
    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
    {
        int numerator = r1.Numerator * r2.Denominator;
        int denominator = r2.Numerator * r1.Denominator;
        return new RationalNumber(numerator, denominator).Reduce();
    }

    public RationalNumber Abs() 
    {
        Numerator = Math.Abs(Numerator);
        Denominator = Math.Abs(Denominator);
        return this;
    }

    public RationalNumber Reduce()
    {
        if (Numerator == 0)
        {
            Denominator = 1;
        }
        else
        {
            int greatestCommonDivisor = GetGreatestCommonDivisor(this.Numerator, this.Denominator);
            Numerator /= greatestCommonDivisor;
            Denominator /= greatestCommonDivisor;
        }
        return CorrectNegatives();
    }

    public RationalNumber Exprational(int power)
    {
        if (power < 0)
        {
            Numerator = (int)Math.Pow(Denominator, Math.Abs(power));
            Denominator = (int)Math.Pow(Numerator, Math.Abs(power));
        }
        else
        {
            Numerator = (int)Math.Pow(Numerator, power);
            Denominator = (int)Math.Pow(Denominator, power);
        }
        return this;
    }

    private static int GetGreatestCommonDivisor(int n, int m)
    {
        n = Math.Abs(n);
        m = Math.Abs(m);
        while (n != m)
        {
            if (n > m) n -= m;
            else m -= n;
        }
        return n;
    }

    private RationalNumber CorrectNegatives()
    {
        if (Numerator < 0 && Denominator < 0)
        {
            Abs();
        }
        else if (Denominator < 0)
        {
            Numerator *= -1;
            Denominator *= -1;
        }
        return this;
    }
}