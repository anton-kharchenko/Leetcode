public class Solution {
    public int DaysBetweenDates(string date1, string date2)
    {
        return Math.Abs(GetCountOfData(date1) - GetCountOfData(date2));
    }

    private int GetCountOfData(string date)
    {
        var array = date.Split('-');
        return GetTotalDaysBeforeYearAndMonth(int.Parse(array[0]), int.Parse(array[1])) + int.Parse(array[2]);
    }
    
    public static int GetTotalDaysBeforeYearAndMonth(int year, int month)
    {
        int totalDays = 0;
        
        // Add days for the full years
        for (int i = 1; i < year; i++)
        {
            totalDays += DateTime.IsLeapYear(i) ? 366 : 365;
        }

        // Add days for the months in the specified year
        for (int i = 1; i < month; i++)
        {
            totalDays += DateTime.DaysInMonth(year, i);
        }

        return totalDays;
    }
}