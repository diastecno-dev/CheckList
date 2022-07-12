using System;
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

        
    }
}