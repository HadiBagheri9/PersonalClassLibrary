using System;
using System.Globalization;

namespace PersonalClassLibrary
{
    public static class ConvertDatas
    {
        private static PersianCalendar persianCalendar = new PersianCalendar();
        private static int CanconverteToInt32;
        //private static bool flag;

        /// <summary>
        /// Validate conversion any data type to integer (32 Bit).
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool CanConvertToInt32(this object data)
        {
            return int.TryParse(data.ToString(), out CanconverteToInt32);
        }

        /// <summary>
        /// Convert any data type to integer (32 Bit).
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int ToInt32(this object data)
        {
            return Convert.ToInt32(data);
        }

        /// <summary>
        /// Get Persian date.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ToPersianDate(this DateTime data)
        {
            return persianCalendar.GetYear(data) + "/" + persianCalendar.GetMonth(data) + "/" + persianCalendar.GetDayOfMonth(data);
        }

        /// <summary>
        /// Get Persian time.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ToPersianTime(this DateTime data)
        {
            return persianCalendar.GetHour(data) + ":" + persianCalendar.GetMinute(data) + " " + data.ToString("tt");
        }
    }
}
