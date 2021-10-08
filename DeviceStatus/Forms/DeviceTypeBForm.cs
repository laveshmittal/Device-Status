using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceStatus
{
    public partial class DeviceTypeBForm : Form
    {
        private DeviceTypeB deviceTypeB;
        public DeviceTypeBForm(DeviceTypeB deviceTypeB)
        {
            InitializeComponent();
            this.deviceTypeB = deviceTypeB;
        }

        private void DeviceTypeBForm_Load(object sender, EventArgs e)
        {   
            this.deviceNameTextBox.Text = deviceTypeB.DeviceName;
            this.productCodeTextBox.Text = deviceTypeB.ProductCode;
            this.firmwareVersionTextBox.Text = deviceTypeB.FirmwareVersion;
            this.actualSpeedTextBox.Text = deviceTypeB.ActualSpeed.ToString();
            this.actualTorqueTextBox.Text = deviceTypeB.ActualTorque.ToString();
            this.actualVoltageTextBox.Text = deviceTypeB.ActualVoltage.ToString();
            this.errorStateTextBox.BackColor = deviceTypeB.IsErrorState ? Color.Red : Color.Green;

        }
    }
}
