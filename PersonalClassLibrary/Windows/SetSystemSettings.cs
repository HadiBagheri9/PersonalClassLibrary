using Microsoft.Win32;
using PersonalClassLibrary.Notif;
using System;
using System.Runtime.InteropServices;

namespace PersonalClassLibrary.Windows
{
    public class SetSystemSettings
    {
        [DllImport("shell32.dll")]
        static extern void SHChangeNotify(int wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);

        public static void SetFileExtensionDefaultIcon(
        string extension,
        string fileTypeName,
        string description,
        string iconPath/*,
        string applicationPath*/)
        {
            try
            {

                using (RegistryKey extKey = Registry.ClassesRoot.CreateSubKey(extension))
                {
                    extKey.SetValue("", fileTypeName);
                }


                using (RegistryKey typeKey = Registry.ClassesRoot.CreateSubKey(fileTypeName))
                {
                    typeKey.SetValue("", description);

                    using (RegistryKey iconKey = typeKey.CreateSubKey("DefaultIcon"))
                    {
                        iconKey.SetValue("", iconPath);
                    }

                    //using (RegistryKey shellKey = typeKey.CreateSubKey(@"shell\open\command"))
                    //{
                    //    shellKey.SetValue("", $"\"{applicationPath}\" \"%1\"");
                    //}
                }


                SHChangeNotify(0x08000000, 0x0000, IntPtr.Zero, IntPtr.Zero); // SHCNE_ASSOCCHANGED

            }
            catch (Exception ex)
            {
                ex.Message.MessageBoxError();
            }
        }
    }
}
