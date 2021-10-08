using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceStatus
{
   public class DeviceTypeB:IDevice
    {
        public int ActualSpeed { get; set; }
        public int ActualVoltage { get; set; }
        public int ActualTorque { get; set; }
        public string DeviceName { get; set; }
        public string ProductCode { get; set; }
        public string FirmwareVersion { get; set; }
        public bool IsErrorState { get; set; }
        public DeviceTypeB(string deviceName, string productCode, string firmwareVersion, int actualSpeed, int actualTorque, int actualVoltage)
        {
            this.DeviceName = deviceName;
            this.ProductCode = productCode;
            this.FirmwareVersion = firmwareVersion;
            this.ActualSpeed = actualSpeed;
            this.ActualTorque = actualTorque;
            this.ActualVoltage = actualVoltage;
            this.CheckErrorState();
        }

        public void CheckErrorState()
        {
            //
            //if Voltage greater than 25 and speed not in (-5000,5000) range show error
            //
            IsErrorState = ((ActualVoltage > 25) && ((ActualSpeed > 5000) || (ActualSpeed < -5000))) ? true : false;
        }
    }

}
