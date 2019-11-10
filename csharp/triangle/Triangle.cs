using System;

public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3)
    {
        if (!IsTriangle(side1, side2, side3)) return false;
        return (side1 == side2 || side2 == side3 || side3 == side1) ? false : true;
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        if (!IsTriangle(side1, side2, side3)) return false;
        return (side1 == side2 || side2 == side3 || side3 == side1) ? true : false;
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
        if (!IsTriangle(side1, side2, side3)) return false;
        return (side1 == side2 && side2 == side3) ? true : false;
    }

    private static bool IsTriangle(double side1, double side2, double side3)
    {
        if (side1 <= 0.0 || side2 <= 0.0 || side3 <= 0.0)
            return false;
        else if (side1 + side2 < side3)
            return false;
        else if (side1 + side3 < side2)
            return false;
        else if (side2 + side3 < side1)
            return false;
        else
            return true;
    }
}