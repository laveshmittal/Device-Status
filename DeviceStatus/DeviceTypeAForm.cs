using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DeviceStatus
{
    public partial class DeviceTypeAForm : Form
    {
         DeviceTypeA deviceTypeA;

        public DeviceTypeAForm(DeviceTypeA deviceTypeA)
        {
            InitializeComponent();
            this.deviceTypeA = deviceTypeA;
        }

        private void DeviceTypeAForm_Load(object sender, EventArgs e)
        {
            this.deviceNameTextBox.Text = deviceTypeA.DeviceName;
            this.productCodeTextBox.Text = deviceTypeA.ProductCode;
            this.firmwareVersionTextBox.Text = deviceTypeA.FirmwareVersion;
            this.switchingFreqTextBox.Text = deviceTypeA.SwitchingFrequency.ToString();
            this.startingFreqTextBox.Text = deviceTypeA.StartFrequency.ToString();
            this.delayTimeTextBox.Text = deviceTypeA.DelayTime.ToString();
            this.errorStateTextBox.BackColor = deviceTypeA.IsErrorState ? Color.Red : Color.Green;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
