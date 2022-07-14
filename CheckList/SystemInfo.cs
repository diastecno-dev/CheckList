using System;
using System.IO;
using System.Management;


namespace CheckList
{
    public class SystemInfo
    {
        public string GetOperatingSystemInfo(string hwclass, string syntax)
        {
            var hardwareInfo = string.Empty;
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "select * from " + hwclass);
            foreach (ManagementObject managementObject in mos.Get())
            {
                hardwareInfo = managementObject[syntax].ToString();
            }
            return hardwareInfo;
        }

        public string GetMemorySystemInfo(string hwclass, string syntax)
        {
            UInt64 memory = 0;
            string hardwareInfo;

            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "select * from " + hwclass);
            foreach (ManagementObject managementObject in mos.Get())
            {
                memory += (UInt64)managementObject[syntax];
            }
            memory /= (1024 * 1024 * 1024);
            hardwareInfo = memory.ToString(); ;
            return hardwareInfo;
        }
        public string GetDiskSystemInfo()
        {
            var disk = string.Empty;
            var allDisk = string.Empty;
            

            DriveInfo[] drives = DriveInfo.GetDrives();
            

            Array.ForEach(drives, drive =>
            {
                
                if (drive.IsReady && drive.DriveType != DriveType.Removable)
                {

                    disk = $"     {drive.Name}{FormatBytes(drive.TotalSize)}     ";

                    allDisk += disk;
                }                
            });
            
            return allDisk;
        }
        private static string FormatBytes(long bytes)
        {
            if (bytes >= 0x1000000000000000) { return ((double)(bytes >> 50) / 1024).ToString("0.###EB"); }
            if (bytes >= 0x4000000000000) { return ((double)(bytes >> 40) / 1024).ToString("0.###PB"); }
            if (bytes >= 0x10000000000) { return ((double)(bytes >> 30) / 1024).ToString("0.###TB"); }
            if (bytes >= 0x40000000) { return ((double)(bytes >> 20) / 1024).ToString("0.###GB"); }
            if (bytes >= 0x100000) { return ((double)(bytes >> 10) / 1024).ToString("0.###MB"); }
            if (bytes >= 0x400) { return ((double)(bytes) / 1024).ToString("0.###") + "KB"; }
            return bytes.ToString("0 Bytes");
        }

    }
}