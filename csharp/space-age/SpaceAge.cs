using System;

public class SpaceAge
{
    private static double EARTH_YEAR_IN_SECONDS = 31557600.0;
    private static double MERCURY_YEAR_IN_SECONDS = 0.2408467 * EARTH_YEAR_IN_SECONDS;
    private static double VENUS_YEAR_IN_SECONDS = 0.61519726 * EARTH_YEAR_IN_SECONDS;
    private static double MARS_YEAR_IN_SECONDS = 1.8808158 * EARTH_YEAR_IN_SECONDS;
    private static double JUPITER_YEAR_IN_SECONDS = 11.862615 * EARTH_YEAR_IN_SECONDS;
    private static double SATURN_YEAR_IN_SECONDS = 29.447498 * EARTH_YEAR_IN_SECONDS;
    private static double URANUS_YEAR_IN_SECONDS = 84.016846 * EARTH_YEAR_IN_SECONDS;
    private static double NEPTUNE_YEAR_IN_SECONDS = 164.79132 * EARTH_YEAR_IN_SECONDS;

    private double PersonsAgeInSeconds;

    public SpaceAge(int seconds)
    {
        PersonsAgeInSeconds = (double)seconds;
    }

    public double OnEarth() => PersonsAgeInSeconds / EARTH_YEAR_IN_SECONDS;

    public double OnMercury() => PersonsAgeInSeconds / MERCURY_YEAR_IN_SECONDS; 

    public double OnVenus() => PersonsAgeInSeconds / VENUS_YEAR_IN_SECONDS;

    public double OnMars() => PersonsAgeInSeconds / MARS_YEAR_IN_SECONDS;

    public double OnJupiter() => PersonsAgeInSeconds / JUPITER_YEAR_IN_SECONDS;

    public double OnSaturn() => PersonsAgeInSeconds / SATURN_YEAR_IN_SECONDS;

    public double OnUranus() => PersonsAgeInSeconds / URANUS_YEAR_IN_SECONDS;

    public double OnNeptune() => PersonsAgeInSeconds / NEPTUNE_YEAR_IN_SECONDS;
}