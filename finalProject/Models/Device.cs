using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Models
{
    public class Device
    {
        public int deviceID { get; set; }
        [DisplayName("Cihaz Adı")]
        public string deviceName { get; set; }
        [DisplayName("Cihaz Kullanıcısı")]
        public string deviceOwner { get; set; }
        [DisplayName("Cihaz IP")]
        public string deviceIP { get; set; }
        [DisplayName("Cihaz MAC Address")]
        public string deviceMACaddress { get; set; }
        [DisplayName("Cihaz CPU")]
        public string deviceCPUmodel { get; set; }
        [DisplayName("Cihaz CPU Speed")]
        public int deviceCPUspeed { get; set; }
        [DisplayName("Cihaz RAM")]
        public int deviceRAM { get; set; }
        [DisplayName("Cihaz Disk")]
        public int deviceDisk { get; set; }
        [DisplayName("Cihaz Durum")]
        public string deviceSituation { get; set; }
    }
}
