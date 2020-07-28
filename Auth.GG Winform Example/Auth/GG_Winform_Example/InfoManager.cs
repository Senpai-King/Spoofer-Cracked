using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;

namespace Auth.GG_Winform_Example
{
	// Token: 0x0200000B RID: 11
	internal class InfoManager
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00004795 File Offset: 0x00002995
		public InfoManager()
		{
			this.lastGateway = this.GetGatewayMAC();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000047AB File Offset: 0x000029AB
		public void StartListener()
		{
			this.timer = new Timer(delegate(object _)
			{
				this.OnCallBack();
			}, null, 5000, -1);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000047CC File Offset: 0x000029CC
		private void OnCallBack()
		{
			this.timer.Dispose();
			bool flag = !(this.GetGatewayMAC() == this.lastGateway);
			if (flag)
			{
				Constants.Breached = true;
				MessageBox.Show("ARP Cache poisoning has been detected!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
				Process.GetCurrentProcess().Kill();
			}
			else
			{
				this.lastGateway = this.GetGatewayMAC();
			}
			this.timer = new Timer(delegate(object _)
			{
				this.OnCallBack();
			}, null, 5000, -1);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00004854 File Offset: 0x00002A54
		public static IPAddress GetDefaultGateway()
		{
			return (from g in (from n in NetworkInterface.GetAllNetworkInterfaces()
			where n.OperationalStatus == OperationalStatus.Up
			where n.NetworkInterfaceType != NetworkInterfaceType.Loopback
			select n).SelectMany(delegate(NetworkInterface n)
			{
				IPInterfaceProperties ipproperties = n.GetIPProperties();
				return (ipproperties != null) ? ipproperties.GatewayAddresses : null;
			})
			select (g != null) ? g.Address : null into a
			where a != null
			select a).FirstOrDefault<IPAddress>();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004924 File Offset: 0x00002B24
		private string GetArpTable()
		{
			string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
			string result;
			using (Process process = Process.Start(new ProcessStartInfo
			{
				FileName = pathRoot + "Windows\\System32\\arp.exe",
				Arguments = "-a",
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true
			}))
			{
				using (StreamReader standardOutput = process.StandardOutput)
				{
					result = standardOutput.ReadToEnd();
				}
			}
			return result;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000049C8 File Offset: 0x00002BC8
		private string GetGatewayMAC()
		{
			string arg = InfoManager.GetDefaultGateway().ToString();
			string pattern = string.Format("({0} [\\W]*) ([a-z0-9-]*)", arg);
			Regex regex = new Regex(pattern);
			Match match = regex.Match(this.GetArpTable());
			return match.Groups[2].ToString();
		}

		// Token: 0x04000028 RID: 40
		private Timer timer;

		// Token: 0x04000029 RID: 41
		private string lastGateway;
	}
}
