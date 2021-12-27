using Linearstar.Windows.RawInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeySharp
{
  public partial class FormDeviceScan : Form
  {
    public FormDeviceScan()
    {
      InitializeComponent();
      ScanDevices();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      ScanDevices();
    }

    private void ScanDevices()
    {
      var devices = RawInputDevice.GetDevices();
      var keyboards = devices.OfType<RawInputKeyboard>().ToList();
      gridDevices.DataSource = keyboards;
    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {      
      Clipboard.SetDataObject(this.gridDevices.GetClipboardContent());
    }    
  }
}
