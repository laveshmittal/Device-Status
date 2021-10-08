using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceStatus
{
    interface IDevice
    {
         string DeviceName { get; set; }
         string ProductCode { get; set; }
         string FirmwareVersion { get; set; }
         bool IsErrorState { get; }
         void CheckErrorState();


    }
}
