using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace Auth.GG_Winform_Example
{
	// Token: 0x0200000E RID: 14
	public partial class Login : Form
	{
		// Token: 0x06000077 RID: 119 RVA: 0x00009AAA File Offset: 0x00007CAA
		public Login()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00009AC4 File Offset: 0x00007CC4
		private void siticoneRoundedButton2_Click(object sender, EventArgs e)
		{
			base.Hide();
			Register register = new Register();
			register.Show();
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00009AE6 File Offset: 0x00007CE6
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00009AF0 File Offset: 0x00007CF0
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			bool flag = API.Login(this.username.Text, this.password.Text);
			if (flag)
			{
				MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Main main = new Main();
				main.Show();
				base.Hide();
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00009B46 File Offset: 0x00007D46
		private void Login_Load(object sender, EventArgs e)
		{
		}
	}
}
