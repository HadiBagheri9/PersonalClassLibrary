using Microsoft.Win32;
using System;

namespace PersonalClassLibrary.Windows
{
    public class CheckSystemSettings
    {
        /// <summary>
        /// To check if the system dark theme is on or off.
        /// </summary>
        /// <returns></returns>
        public static bool? CheckDarkModeOnOrOff()
        {
            const string registryKey = @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
            const string valueName = "AppsUseLightTheme";

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(registryKey))
            {
                if (key != null)
                {
                    object value = key.GetValue(valueName);
                    if (value != null && (int)value == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
