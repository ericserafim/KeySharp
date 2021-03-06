
using Linearstar.Windows.RawInput;
using System;
using System.Windows.Forms;

namespace KeySharp
{
  class RawInputEventArgs : EventArgs
  {
    public RawInputEventArgs(RawInputData data)
    {
      Data = data;
    }

    public RawInputData Data { get; }
  }

  class RawInputReceiverWindow : NativeWindow
  {
    private const int WM_INPUT = 0x00FF;
    public event EventHandler<RawInputEventArgs> Input;

    public RawInputReceiverWindow()
    {
      CreateHandle(new CreateParams
      {
        X = 0,
        Y = 0,
        Width = 0,
        Height = 0,
        Style = 0x800000,
      });
    }

    protected override void WndProc(ref Message m)
    {
      if (m.Msg == WM_INPUT)
      {
        var data = RawInputData.FromHandle(m.LParam);
        Input?.Invoke(this, new RawInputEventArgs(data));
        m = new Message();
      }

      base.WndProc(ref m);
    }
  }
}
