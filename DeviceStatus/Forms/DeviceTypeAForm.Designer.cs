
namespace DeviceStatus
{
    partial class DeviceTypeAForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.deviceNameTextBox = new System.Windows.Forms.TextBox();
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firmwareVersionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.delayTimeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startingFreqTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.switchingFreqTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorStateTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device Name :";
            // 
            // deviceNameTextBox
            // 
            this.deviceNameTextBox.Location = new System.Drawing.Point(130, 32);
            this.deviceNameTextBox.Name = "deviceNameTextBox";
            this.deviceNameTextBox.ReadOnly = true;
            this.deviceNameTextBox.Size = new System.Drawing.Size(141, 20);
            this.deviceNameTextBox.TabIndex = 1;
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.Location = new System.Drawing.Point(130, 67);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.ReadOnly = true;
            this.productCodeTextBox.Size = new System.Drawing.Size(141, 20);
            this.productCodeTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Code :";
            // 
            // firmwareVersionTextBox
            // 
            this.firmwareVersionTextBox.Location = new System.Drawing.Point(130, 102);
            this.firmwareVersionTextBox.Name = "firmwareVersionTextBox";
            this.firmwareVersionTextBox.ReadOnly = true;
            this.firmwareVersionTextBox.Size = new System.Drawing.Size(141, 20);
            this.firmwareVersionTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Switching Freq. :";
            // 
            // delayTimeTextBox
            // 
            this.delayTimeTextBox.Location = new System.Drawing.Point(130, 207);
            this.delayTimeTextBox.Name = "delayTimeTextBox";
            this.delayTimeTextBox.ReadOnly = true;
            this.delayTimeTextBox.Size = new System.Drawing.Size(141, 20);
            this.delayTimeTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Firmware Version :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // startingFreqTextBox
            // 
            this.startingFreqTextBox.Location = new System.Drawing.Point(130, 172);
            this.startingFreqTextBox.Name = "startingFreqTextBox";
            this.startingFreqTextBox.ReadOnly = true;
            this.startingFreqTextBox.Size = new System.Drawing.Size(141, 20);
            this.startingFreqTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Starting Freq :";
            // 
            // switchingFreqTextBox
            // 
            this.switchingFreqTextBox.Location = new System.Drawing.Point(130, 137);
            this.switchingFreqTextBox.Name = "switchingFreqTextBox";
            this.switchingFreqTextBox.ReadOnly = true;
            this.switchingFreqTextBox.Size = new System.Drawing.Size(141, 20);
            this.switchingFreqTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Delay Time :";
            // 
            // errorStateTextBox
            // 
            this.errorStateTextBox.BackColor = System.Drawing.Color.DarkRed;
            this.errorStateTextBox.Enabled = false;
            this.errorStateTextBox.Location = new System.Drawing.Point(130, 247);
            this.errorStateTextBox.Name = "errorStateTextBox";
            this.errorStateTextBox.ReadOnly = true;
            this.errorStateTextBox.Size = new System.Drawing.Size(22, 20);
            this.errorStateTextBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Error State :";
            // 
            // DeviceTypeAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(336, 364);
            this.Controls.Add(this.errorStateTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.delayTimeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startingFreqTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.switchingFreqTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.firmwareVersionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productCodeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deviceNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "DeviceTypeAForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device Details";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DeviceTypeAForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deviceNameTextBox;
        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firmwareVersionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox delayTimeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox startingFreqTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox switchingFreqTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox errorStateTextBox;
        private System.Windows.Forms.Label label7;
    }
}