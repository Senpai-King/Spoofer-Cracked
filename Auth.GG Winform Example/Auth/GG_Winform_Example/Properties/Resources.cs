using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Auth.GG_Winform_Example.Properties
{
	// Token: 0x02000010 RID: 16
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600007F RID: 127 RVA: 0x0000ABF7 File Offset: 0x00008DF7
		internal Resources()
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000AC04 File Offset: 0x00008E04
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("Auth.GG_Winform_Example.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000AC4C File Offset: 0x00008E4C
		// (set) Token: 0x06000082 RID: 130 RVA: 0x0000AC63 File Offset: 0x00008E63
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x0400007D RID: 125
		private static ResourceManager resourceMan;

		// Token: 0x0400007E RID: 126
		private static CultureInfo resourceCulture;
	}
}
