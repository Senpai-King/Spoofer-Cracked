using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Authenticate;
using Guna.UI2.WinForms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace Auth.GG_Winform_Example
{
	// Token: 0x0200000C RID: 12
	public partial class Main : Form
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00004A2A File Offset: 0x00002C2A
		public Main()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00004A42 File Offset: 0x00002C42
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004A45 File Offset: 0x00002C45
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004A50 File Offset: 0x00002C50
		private void siticoneRoundedButton2_Click(object sender, EventArgs e)
		{
			string text = App.GrabVariable(this.variable.Text);
			MessageBox.Show(text);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00004A78 File Offset: 0x00002C78
		private void Main_Load(object sender, EventArgs e)
		{
			this.userid.Text = "ID: " + User.ID;
			this.username.Text = "Username: " + User.Username;
			this.email.Text = "Email: " + User.Email;
			this.hwid.Text = "HWID: " + User.HWID;
			this.uservariable.Text = "User Variable: " + User.UserVariable;
			this.userrank.Text = "Rank: " + User.Rank;
			this.ip.Text = "IP: " + User.IP;
			this.expiry.Text = "Expiry: " + User.Expiry;
			this.lastlogin.Text = "Last Login: " + User.LastLogin;
			this.registerdate.Text = "Register Date: " + User.RegisterDate;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00004B94 File Offset: 0x00002D94
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00004B97 File Offset: 0x00002D97
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00004B9A File Offset: 0x00002D9A
		private void label9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00004B9D File Offset: 0x00002D9D
		private void guna2ToggleSwitch7_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00004BA0 File Offset: 0x00002DA0
		private void label15_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00004BA3 File Offset: 0x00002DA3
		private void guna2ToggleSwitch12_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004BA6 File Offset: 0x00002DA6
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			Spoofer.Spoof();
			MessageBox.Show("HWID Spoofed");
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00004BBA File Offset: 0x00002DBA
		private void label17_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00004BBD File Offset: 0x00002DBD
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004BC0 File Offset: 0x00002DC0
		private void pictureBox2_Click(object sender, EventArgs e)
		{
		}
	}
}
