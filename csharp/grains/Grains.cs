using System;

public static class Grains
{
    private static int SQUARES_ON_CHESSBOARD = 64;

    public static ulong Square(int n)
    {
        if (n < 1 || n > Grains.SQUARES_ON_CHESSBOARD) throw new ArgumentOutOfRangeException();
        return (ulong)Math.Pow(2, n - 1);
    }

    public static ulong Total()
    {
        return (ulong)Math.Pow(2, Grains.SQUARES_ON_CHESSBOARD) - 1;
    }
}