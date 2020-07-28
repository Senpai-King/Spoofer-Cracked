﻿using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows;

namespace Auth.GG_Winform_Example
{
	// Token: 0x02000007 RID: 7
	internal class OnProgramStart
	{
		// Token: 0x0600003D RID: 61 RVA: 0x000025E0 File Offset: 0x000007E0
		public static void Initialize(string name, string aid, string secret, string version)
		{
			bool flag = string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(aid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version);
			if (flag)
			{
				MessageBox.Show("Invalid application information!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
				Process.GetCurrentProcess().Kill();
			}
			OnProgramStart.AID = aid;
			OnProgramStart.Secret = secret;
			OnProgramStart.Version = version;
			OnProgramStart.Name = name;
			string[] array = new string[0];
			using (WebClient webClient = new WebClient())
			{
				try
				{
					webClient.Proxy = null;
					Security.Start();
					Encoding @default = Encoding.Default;
					WebClient webClient2 = webClient;
					string apiUrl = Constants.ApiUrl;
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["token"] = Encryption.EncryptService(Constants.Token);
					nameValueCollection["timestamp"] = Encryption.EncryptService(DateTime.Now.ToString());
					nameValueCollection["aid"] = Encryption.APIService(OnProgramStart.AID);
					nameValueCollection["session_id"] = Constants.IV;
					nameValueCollection["api_id"] = Constants.APIENCRYPTSALT;
					nameValueCollection["api_key"] = Constants.APIENCRYPTKEY;
					nameValueCollection["session_key"] = Constants.Key;
					nameValueCollection["secret"] = Encryption.APIService(OnProgramStart.Secret);
					nameValueCollection["type"] = Encryption.APIService("start");
					array = Encryption.DecryptService(@default.GetString(webClient2.UploadValues(apiUrl, nameValueCollection))).Split("|".ToCharArray());
					bool flag2 = Security.MaliciousCheck(array[1]);
					if (flag2)
					{
						MessageBox.Show("Possible malicious activity detected!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Exclamation);
						Process.GetCurrentProcess().Kill();
					}
					bool breached = Constants.Breached;
					if (breached)
					{
						MessageBox.Show("Possible malicious activity detected!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Exclamation);
						Process.GetCurrentProcess().Kill();
					}
					bool flag3 = array[0] != Constants.Token;
					if (flag3)
					{
						MessageBox.Show("Security error has been triggered!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
						Process.GetCurrentProcess().Kill();
					}
					string text = array[2];
					string text2 = text;
					if (text2 != null)
					{
						if (!(text2 == "success"))
						{
							if (text2 == "binderror")
							{
								MessageBox.Show(Encryption.Decode("RmFpbGVkIHRvIGJpbmQgdG8gc2VydmVyLCBjaGVjayB5b3VyIEFJRCAmIFNlY3JldCBpbiB5b3VyIGNvZGUh"), OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
								Process.GetCurrentProcess().Kill();
								return;
							}
							if (text2 == "banned")
							{
								MessageBox.Show("This application has been banned for violating the TOS" + Environment.NewLine + "Contact us at support@auth.gg", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
								Process.GetCurrentProcess().Kill();
								return;
							}
						}
						else
						{
							Constants.Initialized = true;
							bool flag4 = array[3] == "Enabled";
							if (flag4)
							{
								ApplicationSettings.Status = true;
							}
							bool flag5 = array[4] == "Enabled";
							if (flag5)
							{
								ApplicationSettings.DeveloperMode = true;
							}
							ApplicationSettings.Hash = array[5];
							ApplicationSettings.Version = array[6];
							ApplicationSettings.Update_Link = array[7];
							bool flag6 = array[8] == "Enabled";
							if (flag6)
							{
								ApplicationSettings.Freemode = true;
							}
							bool flag7 = array[9] == "Enabled";
							if (flag7)
							{
								ApplicationSettings.Login = true;
							}
							ApplicationSettings.Name = array[10];
							bool flag8 = array[11] == "Enabled";
							if (flag8)
							{
								ApplicationSettings.Register = true;
							}
							bool developerMode = ApplicationSettings.DeveloperMode;
							if (developerMode)
							{
								MessageBox.Show("Application is in Developer Mode, bypassing integrity and update check!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Exclamation);
								File.Create(Environment.CurrentDirectory + "/integrity.log").Close();
								string contents = Security.Integrity(Process.GetCurrentProcess().MainModule.FileName);
								File.WriteAllText(Environment.CurrentDirectory + "/integrity.log", contents);
								MessageBox.Show("Your applications hash has been saved to integrity.txt, please refer to this when your application is ready for release!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Asterisk);
							}
							else
							{
								bool flag9 = array[12] == "Enabled";
								if (flag9)
								{
									bool flag10 = ApplicationSettings.Hash != Security.Integrity(Process.GetCurrentProcess().MainModule.FileName);
									if (flag10)
									{
										MessageBox.Show("File has been tampered with, couldn't verify integrity!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
										Process.GetCurrentProcess().Kill();
									}
								}
								bool flag11 = ApplicationSettings.Version != OnProgramStart.Version;
								if (flag11)
								{
									MessageBox.Show("Update " + ApplicationSettings.Version + " available, redirecting to update!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
									Process.Start(ApplicationSettings.Update_Link);
									Process.GetCurrentProcess().Kill();
								}
							}
							bool flag12 = !ApplicationSettings.Status;
							if (flag12)
							{
								MessageBox.Show("Looks like this application is disabled, please try again later!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
								Process.GetCurrentProcess().Kill();
							}
						}
					}
					Security.End();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
					Process.GetCurrentProcess().Kill();
				}
			}
		}

		// Token: 0x04000022 RID: 34
		public static string AID = null;

		// Token: 0x04000023 RID: 35
		public static string Secret = null;

		// Token: 0x04000024 RID: 36
		public static string Version = null;

		// Token: 0x04000025 RID: 37
		public static string Name = null;

		// Token: 0x04000026 RID: 38
		public static string Salt = null;
	}
}
