using System;
using System.Net;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ExcludedPortRange
{
  public partial class Main : Form
  {
    [DllImport("Iphlpapi.dll")]
    internal static extern uint DeletePersistentTcpPortReservation(ushort startPort, ushort numberOfPorts);

    [DllImport("Iphlpapi.dll")]
    internal static extern uint DeletePersistentUdpPortReservation(ushort startPort, ushort numberOfPorts);

    [DllImport("Iphlpapi.dll")]
    internal static extern uint CreatePersistentTcpPortReservation(ushort startPort, ushort numberOfPorts, out IntPtr token);

    [DllImport("Iphlpapi.dll")]
    internal static extern uint CreatePersistentUdpPortReservation(ushort startPort, ushort numberOfPorts, out IntPtr token);

    /// <summary>
    /// Main
    /// </summary>
    public Main()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Exclude function function is called with the mode as D.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnDeleteExclude_Click(object sender, EventArgs e)
    {
      Exclude('D');
    }

    /// <summary>
    /// Exclude function function is called with the mode as C.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnCreateExclude_Click(object sender, EventArgs e)
    {
      Exclude('C');
    }

    /// <summary>
    /// deletes or creates a persistent TCP or UDP port reservation for a consecutive block of TCP or UDP ports on the local computer.
    /// </summary>
    /// <param name="mode">
    /// Exclude mode.
    /// 'D' is deletes a persistent TCP or UDP port reservation for a consecutive block of TCP or UDP ports on the local computer.
    /// 'C' is creates a persistent TCP or UDP port reservation for a consecutive block of TCP or UDP ports on the local computer.</param>
    private void Exclude(char mode)
    {
      Cursor = Cursors.WaitCursor;
      string type = (rbTCP.Checked) ? "tcp" : "udp";
      string msg = null;
      int result = 0;

      try
      {
        if (txtStartPort.Text.ToString().All(char.IsDigit) && txtEndPort.Text.ToString().All(char.IsDigit))
        {
          ushort startPort = UInt16.Parse(txtStartPort.Text.ToString());
          ushort endPort = UInt16.Parse(txtEndPort.Text.ToString());

          if (startPort <= endPort)
          {
            ushort numberOfPorts = (ushort)(endPort - startPort + 1);
            ushort portToDelete = (ushort)IPAddress.HostToNetworkOrder((short)startPort);

            if(mode == 'D')
            {
              switch (type)
              {
                case "tcp":
                  result = (int)DeletePersistentTcpPortReservation(portToDelete, numberOfPorts);
                  break;
                case "udp":
                  result = (int)DeletePersistentUdpPortReservation(portToDelete, numberOfPorts);
                  break;
              }
            }
            else
            {
              // A pointer to a port reservation token that is returned if the function succeeds.
              IntPtr token = IntPtr.Zero;
              switch (type)
              {
                case "tcp":
                  result = (int)CreatePersistentTcpPortReservation(portToDelete, numberOfPorts, out token);
                  break;
                case "udp":
                  result = (int)CreatePersistentUdpPortReservation(portToDelete, numberOfPorts, out token);
                  break;
              }
            }

            if (result != 0)
            {
              msg = "Please run it with administrator privileges. or already processed.";
            }
          }
          else
          {
            msg = "For endPort, enter a port number greater than startPort.";
          }
        }
        else
        {
          msg = "Please enter the port number as a number.";
        }
      }
      catch (Exception ex)
      {
        msg = ex.Message;
      }
      finally
      {
        Cursor = Cursors.Default;
        if (msg == null)
        {
          MessageBox.Show(((mode == 'D') ? "Delete":"Create") + " Exclude Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
          MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }
  }
}
