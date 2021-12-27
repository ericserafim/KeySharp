using Linearstar.Windows.RawInput;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KeySharp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      var devices = JsonConvert.DeserializeObject<List<Device>>(File.ReadAllText("settings.json"));
      var window = new RawInputReceiverWindow();

      window.Input += (sender, e) =>
      {
        var data = e.Data;
        var device = devices.FirstOrDefault(x => x.Id == data.Device?.DevicePath);

        if (device != null)
        {
          var keyboard = ((RawInputKeyboardData)data).Keyboard;
          var mapping = device.Mappings.FirstOrDefault(m => m.KeyCode == keyboard.ScanCode && m.Flag == keyboard.Flags);

          if (mapping != null)
          {
            SendKeys.Send(mapping.Map);
          }
        }
      };

      RawInputDevice.RegisterDevice(HidUsageAndPage.Keyboard, RawInputDeviceFlags.ExInputSink | RawInputDeviceFlags.NoLegacy, window.Handle);
      InitializeComponent();

      grid.DataSource = devices;
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      RawInputDevice.UnregisterDevice(HidUsageAndPage.Keyboard);
    }

    private void notifyIcon1_DoubleClick(object sender, EventArgs e)
    {
      this.Show();
      this.WindowState = FormWindowState.Normal;
      this.Activate();
      notifyIcon1.Visible = false;
    }

    private void Form1_Resize(object sender, EventArgs e)
    {
      if (this.WindowState == FormWindowState.Minimized)
      {
        this.Hide();
        notifyIcon1.Visible = true;
      }
    }

    private void Exit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void grid_SelectionChanged(object sender, EventArgs e)
    {
      var device = (Device)grid.CurrentRow.DataBoundItem;
      gridDetail.DataSource = device.Mappings;
    }
  }
}
