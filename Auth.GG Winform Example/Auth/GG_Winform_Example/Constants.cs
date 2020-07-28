using System;
using System.Linq;
using System.Security.Principal;

namespace Auth.GG_Winform_Example
{
	// Token: 0x02000004 RID: 4
	internal class Constants
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000023BB File Offset: 0x000005BB
		// (set) Token: 0x06000008 RID: 8 RVA: 0x000023C2 File Offset: 0x000005C2
		public static string Token { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000023CA File Offset: 0x000005CA
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000023D1 File Offset: 0x000005D1
		public static string Date { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000023D9 File Offset: 0x000005D9
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000023E0 File Offset: 0x000005E0
		public static string APIENCRYPTKEY { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000023E8 File Offset: 0x000005E8
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000023EF File Offset: 0x000005EF
		public static string APIENCRYPTSALT { get; set; }

		// Token: 0x0600000F RID: 15 RVA: 0x000023F8 File Offset: 0x000005F8
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", length)
			select s[Constants.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002444 File Offset: 0x00000644
		public static string HWID()
		{
			return WindowsIdentity.GetCurrent().User.Value;
		}

		// Token: 0x04000007 RID: 7
		public static bool Breached = false;

		// Token: 0x04000008 RID: 8
		public static bool Started = false;

		// Token: 0x04000009 RID: 9
		public static string IV = null;

		// Token: 0x0400000A RID: 10
		public static string Key = null;

		// Token: 0x0400000B RID: 11
		public static string ApiUrl = "https://api.auth.gg/csharp/";

		// Token: 0x0400000C RID: 12
		public static bool Initialized = false;

		// Token: 0x0400000D RID: 13
		public static Random random = new Random();
	}
}
