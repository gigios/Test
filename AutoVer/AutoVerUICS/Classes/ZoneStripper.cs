using System;
using System.IO;
using System.Security;
using System.Security.Permissions;
using System.Runtime.InteropServices;
using AutoVer;

namespace AutoVerUICS.Classes
{
    public class ZoneStripper
    {
        private int _filesScanned;
        private int _zoneIdRemoved;
        private const string ZONE_IDENTIFIER = "Zone.Identifier";
        private Logger Log;

        public ZoneStripper(Logger logInstance)
        {
            Log = logInstance;
        }

        public int FileScanned { get { return _filesScanned; } }

        public int ZoneIdRemoved { get { return _zoneIdRemoved; } }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        public void Unblock(string directory, bool recurse)
        {
            try
            {
                var di = new DirectoryInfo(directory);
                foreach (var file in di.GetFiles())
                {
                    _filesScanned += 1;
                    WipeZoneId(file.FullName);
                }

                foreach (var dir in di.GetDirectories())
                {
                    WipeZoneId(dir.FullName);
                    if (recurse)
                        RecurseDirectory(dir.FullName);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, "ZoneStripper.Unblock");
            }
        }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        private void RecurseDirectory(string dirName)
        {
            try
            {
                var di = new DirectoryInfo(dirName);
                foreach (var file in di.GetFiles())
                {
                    _filesScanned += 1;
                    WipeZoneId(file.FullName);
                }

                foreach (var subdir in di.GetDirectories())
                {
                    WipeZoneId(subdir.FullName);
                    RecurseDirectory(subdir.FullName);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, "ZoneStripper.RecurseDirectory");
            }
        }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        private void WipeZoneId(string fullPathName)
        {
            try
            {
                if (StreamExists(fullPathName, ZONE_IDENTIFIER))
                {
                    DeleteStream(fullPathName, ZONE_IDENTIFIER);
                    _zoneIdRemoved += 1;
                }
            }
            catch (Exception ex)
            {
                Log.Debug(String.Format("Unable to remove Zone Identifier from {0}: {1}", fullPathName, ex.Message), "ZoneStripper.WipeZoneId");
            }
        }

        #region Native Methods

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        public static void DeleteStream(string path, string stream)
        {
            if (!DeleteFile(path + ":" + stream))
            {
                Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
            }
        }

        public static bool StreamExists(string path, string stream)
        {
            IntPtr handle = default(IntPtr);

            handle = CreateFile(path + ":" + stream, GENERIC_READ, FILE_SHARE_READ, IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero);

            bool retVal = Convert.ToBoolean((Convert.ToInt32(handle) == -1 ? false : true));
            CloseHandle(handle);
            return retVal;
        }


        private const uint GENERIC_READ = 2147483648;
        //Private Const GENERIC_WRITE As UInteger = 1073741824

        //Private Const CREATE_NEW As UInteger = 1
        //Private Const CREATE_ALWAYS As UInteger = 2
        private const uint OPEN_EXISTING = 3;
        //Private Const OPEN_ALWAYS As UInteger = 4
        //Private Const TRUNCATE_EXISTING As UInteger = 5

        //Private Const FILE_BEGIN As UInteger = 0
        //Private Const FILE_CURRENT As UInteger = 1
        //Private Const FILE_END As UInteger = 2

        //Private Const FILE_SHARE_NONE As UInteger = 0

        private const uint FILE_SHARE_READ = 1;

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern IntPtr CreateFile(string fileName, uint access, uint sharemode, IntPtr security_attributes, uint creation, uint flags, IntPtr template);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CloseHandle(IntPtr handle);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool DeleteFile(string fileName);

        #endregion [END] Native Methods
    }
}
