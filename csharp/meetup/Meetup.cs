using System;

public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    private int Month;
    private int Year;

    public Meetup(int month, int year)
    {
        Month = month;
        Year = year;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        switch (schedule)
        {
            case Schedule.Teenth:
                return GetTeenth(dayOfWeek);
            case Schedule.Last:
                return GetLast(dayOfWeek);
            default:
                return GetFirstThroughFourth(dayOfWeek, schedule);
        }

    }

    private DateTime GetTeenth(DayOfWeek dayOfWeek)
    {
        int FIRST_POSSIBLE_TEENTH = 13;
        DateTime dateTime = new DateTime(Year, Month, FIRST_POSSIBLE_TEENTH);
        while (dateTime.DayOfWeek != dayOfWeek)
        {
            dateTime = dateTime.AddDays(1);
        }
        return dateTime;
    }

    private DateTime GetLast(DayOfWeek dayOfWeek)
    {
        int furthestDateADayCanBeFromEndOfMonth = DateTime.DaysInMonth(Year, Month) - 6;
        DateTime dateTime = new DateTime(Year, Month, furthestDateADayCanBeFromEndOfMonth);
        while (dateTime.DayOfWeek != dayOfWeek)
        {
            dateTime = dateTime.AddDays(1);
        }
        return dateTime;
    }

    private DateTime GetFirstThroughFourth(DayOfWeek dayOfWeek, Schedule schedule)
    {
        int timesDayOfWeekHasBeenSeen = 0;
        DateTime dateTime = new DateTime(Year, Month, 1);
        while (timesDayOfWeekHasBeenSeen < (int)schedule)
        {
            if (dateTime.DayOfWeek == dayOfWeek) 
            {
                timesDayOfWeekHasBeenSeen++;
            }
            dateTime = dateTime.AddDays(1);
        }
        return dateTime.AddDays(-1); //an extra day was added in the last iteration of the while loop
    }
}