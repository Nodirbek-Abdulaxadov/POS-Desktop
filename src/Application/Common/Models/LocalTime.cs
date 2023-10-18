using TimeZoneConverter;

namespace POS.Application.Common.Models;

public static class LocalTime
{
    public static DateTime GetUtc5Time()
    {
        DateTime utcTime = DateTime.UtcNow; // Get current UTC time
        TimeZoneInfo timeZone = TZConvert.GetTimeZoneInfo("Pakistan Standard Time"); // Set the time zone
        return TimeZoneInfo.ConvertTimeFromUtc(utcTime, timeZone);
    }
}