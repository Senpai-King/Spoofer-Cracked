using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace Auth.GG_Winform_Example
{
	// Token: 0x0200000D RID: 13
	public partial class Register : Form
	{
		// Token: 0x06000071 RID: 113 RVA: 0x000084F3 File Offset: 0x000066F3
		public Register()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000850C File Offset: 0x0000670C
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			base.Hide();
			Login login = new Login();
			login.Show();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000852E File Offset: 0x0000672E
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00008538 File Offset: 0x00006738
		private void siticoneRoundedButton2_Click(object sender, EventArgs e)
		{
			bool flag = API.Register(this.username.Text, this.password.Text, this.email.Text, this.license.Text);
			if (flag)
			{
				MessageBox.Show("Register has been successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}
	}
}
