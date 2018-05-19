using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tcc.DayHappy.Web.Utils
{
    public static class Format
    {
        public static string ToDateForTextBox(this DateTime value) => value.ToString("yyyy-MM-dd");
    }
}
