using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PITS_MAUI.Model
{
    public class Devices
    {
            public string machineGuid { get; set; }
            public string userID { get; set; }
            public string clientID { get; set; }
            public string machineType { get; set; }
            public string hostname { get; set; }
            public string domain { get; set; }
            public string username { get; set; }
            public string cpuVendor { get; set; }
            public int cpuCores { get; set; }
            public float cpuCurrentSpeed { get; set; }
            public float cpuCurrentLoad { get; set; }
            public string cpuModel { get; set; }
            public float cpuTemp { get; set; }
            public float freeRam { get; set; }
            public float totalRam { get; set; }
            public string ramVendor { get; set; }
            public int ramSpeed { get; set; }
            public DateTime loggedDateTime { get; set; }
            public DateTime boardedDateTime { get; set; }
            public DateTime deviceCreateDateTime { get; set; }
            public int active { get; set; }
        
    }
}
