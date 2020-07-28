using System;
using System.Windows.Forms;

namespace Auth.GG_Winform_Example
{
	// Token: 0x0200000F RID: 15
	internal static class Program
	{
		// Token: 0x0600007E RID: 126 RVA: 0x0000ABC2 File Offset: 0x00008DC2
		[STAThread]
		private static void Main()
		{
			OnProgramStart.Initialize("retrospoof", "47744", "nf9D2IQYEH48sWppn2oony9uMsYWB1mC3zz", "1.0");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}
	}
}
