using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Security.AccessControl;
using System.Collections.Generic;

namespace PersonalClassLibrary.Windows
{
    public class FolderOptions
    {
        public static void LockDirectory(string path)
        {
            DirectorySecurity ds = Directory.GetAccessControl(path);
            FileSystemAccessRule fsar = new FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny);
            ds.AddAccessRule(fsar);
            Directory.SetAccessControl(path, ds);
        }
        public static void UnLockDirectory(string path)
        {
            DirectorySecurity ds = Directory.GetAccessControl(path);
            FileSystemAccessRule fsar = new FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny);
            ds.RemoveAccessRule(fsar);
            Directory.SetAccessControl(path, ds);
        }

        public static List<string> GetAllFiles(string path)
        {
            string[] arrayFiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            List<string> listFiles = new List<string>();

            foreach (var item in arrayFiles)
            {
                if (item.Contains("RECYCLE") ||
                            item.Contains("Config.Msi") ||
                            item.Contains("System Volume Information"))
                {
                    continue;
                }
                try
                {
                    listFiles.Add(item);
                }
                catch
                {
                    continue;
                }
            }
            return listFiles;
        }

        public static List<string> GetAllFolders(string path)
        {
            string[] arrayFiles = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);
            List<string> listFolders = new List<string>();

            foreach (var item in arrayFiles)
            {
                if (item.Contains("RECYCLE") ||
                            item.Contains("Config.Msi") ||
                            item.Contains("System Volume Information"))
                {
                    continue;
                }
                try
                {
                    listFolders.Add(item);
                }
                catch
                {
                    continue;
                }
            }
            return listFolders;
        }
    }
}
