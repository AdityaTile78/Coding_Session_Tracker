using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Session_Tracker.Services
{
    public static class Validation
    {
        // ✅ Check if user entered datetime in the required format
        public static bool IsValidDateTime(string input)
        {
            return DateTime.TryParseExact(
                input,
                "yyyy-MM-dd HH:mm",                  // Required format
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out _);
        }

        // ✅ Check if EndTime > StartTime
        public static bool IsEndAfterStart(string start, string end)
        {
            DateTime startTime = DateTime.Parse(start);
            DateTime endTime = DateTime.Parse(end);

            return endTime > startTime;
        }

        // ✅ Check if user entered a number (for deleting sessions)
        public static bool IsValidInteger(string input)
        {
            return int.TryParse(input, out _);
        }
    }
}
