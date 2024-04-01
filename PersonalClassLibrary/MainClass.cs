using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalClassLibrary
{
    public static class ConvertDatas
    {
        private static int convertedData;
        private static bool flag;

        public static bool ToInt32(this object data)
        {
            flag = Int32.TryParse(data.ToString(), out convertedData);

            if (flag)
            {
                return flag;
            }
            else
            {
                return flag;
            }
        }
    }
}
