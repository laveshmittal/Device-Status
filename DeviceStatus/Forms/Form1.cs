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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var device1 = new DeviceTypeA("device1", "p1", "f1", 120, 100, DateTime.Now);
            var deviceTypeAForm = new DeviceTypeAForm(device1);
            deviceTypeAForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var device2 = new DeviceTypeB("Device 2","p123","f1.2",6000,100,30);
            var deviceTypeBForm = new DeviceTypeBForm(device2);
            deviceTypeBForm.Show();
        }
    }
}
