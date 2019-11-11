using System;

public static class Darts
{
    private static int OUTER_RADIUS_SQUARED = 10 * 10;
    private static int MIDDLE_RADIUS_SQUARED = 5 * 5;
    private static int INNER_RADIUS_SQUARED = 1;

    public static int Score(double x, double y)
    {
        double dartLocation = x * x + y * y;
        if (dartLocation <= INNER_RADIUS_SQUARED) return 10;
        else if (dartLocation <= MIDDLE_RADIUS_SQUARED) return 5;
        else if (dartLocation <= OUTER_RADIUS_SQUARED) return 1;
        else return 0;
    }
}
