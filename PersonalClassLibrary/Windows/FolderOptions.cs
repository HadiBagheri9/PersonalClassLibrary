using System;
using System.IO;
using System.Security.AccessControl;

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
    }
}
