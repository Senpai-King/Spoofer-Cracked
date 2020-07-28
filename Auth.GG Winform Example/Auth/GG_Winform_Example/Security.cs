using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;

namespace Auth.GG_Winform_Example
{
	// Token: 0x02000009 RID: 9
	internal class Security
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00004030 File Offset: 0x00002230
		public static string Signature(string value)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				byte[] bytes = Encoding.UTF8.GetBytes(value);
				byte[] value2 = md.ComputeHash(bytes);
				result = BitConverter.ToString(value2).Replace("-", "");
			}
			return result;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00004090 File Offset: 0x00002290
		private static string Session(int length)
		{
			Random random = new Random();
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz", length)
			select s[random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000040DC File Offset: 0x000022DC
		public static string Obfuscate(int length)
		{
			Random random = new Random();
			return new string((from s in Enumerable.Repeat<string>("gd8JQ57nxXzLLMPrLylVhxoGnWGCFjO4knKTfRE6mVvdjug2NF/4aptAsZcdIGbAPmcx0O+ftU/KvMIjcfUnH3j+IMdhAW5OpoX3MrjQdf5AAP97tTB5g1wdDSAqKpq9gw06t3VaqMWZHKtPSuAXy0kkZRsc+DicpcY8E9+vWMHXa3jMdbPx4YES0p66GzhqLd/heA2zMvX8iWv4wK7S3QKIW/a9dD4ALZJpmcr9OOE=", length)
			select s[random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00004128 File Offset: 0x00002328
		public static void Start()
		{
			string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
			bool started = Constants.Started;
			if (started)
			{
				MessageBox.Show("A session has already been started, please end the previous one!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Exclamation);
				Process.GetCurrentProcess().Kill();
			}
			else
			{
				using (StreamReader streamReader = new StreamReader(pathRoot + "Windows\\System32\\drivers\\etc\\hosts"))
				{
					string text = streamReader.ReadToEnd();
					bool flag = text.Contains("api.auth.gg");
					if (flag)
					{
						Constants.Breached = true;
						MessageBox.Show("DNS redirecting has been detected!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
						Process.GetCurrentProcess().Kill();
					}
				}
				InfoManager infoManager = new InfoManager();
				infoManager.StartListener();
				Constants.Token = Guid.NewGuid().ToString();
				ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(Security.PinPublicKey));
				Constants.APIENCRYPTKEY = Convert.ToBase64String(Encoding.Default.GetBytes(Security.Session(32)));
				Constants.APIENCRYPTSALT = Convert.ToBase64String(Encoding.Default.GetBytes(Security.Session(16)));
				Constants.IV = Convert.ToBase64String(Encoding.Default.GetBytes(Constants.RandomString(16)));
				Constants.Key = Convert.ToBase64String(Encoding.Default.GetBytes(Constants.RandomString(32)));
				Constants.Started = true;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000042A0 File Offset: 0x000024A0
		public static void End()
		{
			bool flag = !Constants.Started;
			if (flag)
			{
				MessageBox.Show("No session has been started, closing for security reasons!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Exclamation);
				Process.GetCurrentProcess().Kill();
			}
			else
			{
				Constants.Token = null;
				ServicePointManager.ServerCertificateValidationCallback = ((object <p0>, X509Certificate <p1>, X509Chain <p2>, SslPolicyErrors <p3>) => true);
				Constants.APIENCRYPTKEY = null;
				Constants.APIENCRYPTSALT = null;
				Constants.IV = null;
				Constants.Key = null;
				Constants.Started = false;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000432C File Offset: 0x0000252C
		private static bool PinPublicKey(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return certificate != null && certificate.GetPublicKeyString() == "046EECD33E469E9E1958D6BEEDE0A71843202724A5758BD1723F6C340C5E98EDE06FF5C21B35F359C65B850744729B3AA999B0B6392DA69EDB278EB31DBCE85774";
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004354 File Offset: 0x00002554
		public static string Integrity(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					byte[] value = md.ComputeHash(fileStream);
					result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000043D4 File Offset: 0x000025D4
		public static bool MaliciousCheck(string date)
		{
			DateTime d = DateTime.Parse(date);
			DateTime now = DateTime.Now;
			TimeSpan timeSpan = d - now;
			bool flag = Convert.ToInt32(timeSpan.Seconds.ToString().Replace("-", "")) >= 5 || Convert.ToInt32(timeSpan.Minutes.ToString().Replace("-", "")) >= 1;
			bool result;
			if (flag)
			{
				Constants.Breached = true;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x04000027 RID: 39
		private const string _key = "046EECD33E469E9E1958D6BEEDE0A71843202724A5758BD1723F6C340C5E98EDE06FF5C21B35F359C65B850744729B3AA999B0B6392DA69EDB278EB31DBCE85774";
	}
}
