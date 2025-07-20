using System;

namespace Coding_Session_Tracker.Services
{
    public static class DurationCalculator
    {
        public static string Calculate(string start, string end)
        {
            // Parse the string dates to DateTime
            DateTime startTime = DateTime.Parse(start);
            DateTime endTime = DateTime.Parse(end);

            // Calculate the duration
            TimeSpan duration = endTime - startTime;

            // Return formatted duration (hh:mm:ss)
            return duration.ToString(@"hh\:mm\:ss");
        }
    }
}
