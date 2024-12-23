using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAulaC_161.Extensions
{
    internal static class DateTimeExtesions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("f1", CultureInfo.InvariantCulture) + " Hours ";
            }
            else
            {
                return duration.TotalDays.ToString("f1",CultureInfo.InvariantCulture) + " Days ";
            }
        }
    }
}