using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceStatus
{
    public class DeviceTypeA:IDevice
    {
        public int SwitchingFrequency { get; set; }
        public int StartFrequency { get; set; }
        public DateTime DelayTime { get; set; }
        public string DeviceName { get; set; }
        public string ProductCode { get; set; }
        public string FirmwareVersion { get; set; }
        public bool IsErrorState { get; set; }
        public DeviceTypeA(string deviceName, string productCode, string firmwareVersion,int switchingFrequency,int startFrequency,DateTime delayTime)
        {
            this.DeviceName = deviceName;
            this.ProductCode = productCode;
            this.FirmwareVersion = firmwareVersion;
            this.SwitchingFrequency = switchingFrequency;
            this.StartFrequency = startFrequency;
            this.DelayTime = delayTime;
            CheckErrorState();
        }

        public void CheckErrorState()
        {
            //
            //If start frquency is greater than 250 and switching frequency is greater than 500
            //show error
            IsErrorState = ((StartFrequency > 250) && (SwitchingFrequency > 500)) ? true : false;
        }
    }
}
