using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Auth.GG_Winform_Example.Properties
{
	// Token: 0x02000011 RID: 17
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0000AC6C File Offset: 0x00008E6C
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x0400007F RID: 127
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
