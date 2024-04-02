using System;
using System.Globalization;

namespace PersonalClassLibrary
{
    public static class ConvertDatas
    {
        private static PersianCalendar persianCalendar = new PersianCalendar();
        private static int convertedDataAsInt32;
        private static bool flag;

        public static bool CanConvertToInt32(this object data)
        {
            return flag = int.TryParse(data.ToString(), out convertedDataAsInt32);
        }

        public static int ToInt32(this object data)
        {
            return Convert.ToInt32(data);
        }

        public static string ToPersianDate(this DateTime data)
        {
            return persianCalendar.GetYear(data) + "/" + persianCalendar.GetMonth(data) + "/" + persianCalendar.GetDayOfMonth(data);
        }

        public static string ToPersianTime(this DateTime data)
        {
            return persianCalendar.GetHour(data) + ":" + persianCalendar.GetMinute(data) + " " + data.ToString("tt");
        }
    }
}
