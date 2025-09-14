using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalClassLibrary.Data
{
    public static class Text
    {
        public static string ReverseText(this string text)
        {
            string reversedText = "";

            for (int i = (text.Length - 1) ; i >= 0; i--)
            {
                reversedText += text[i];
            }

            return reversedText;
        }
    }
}
