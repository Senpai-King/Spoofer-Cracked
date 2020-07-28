namespace Auth.GG_Winform_Example
{
	// Token: 0x0200000D RID: 13
	public partial class Register : global::System.Windows.Forms.Form
	{
		// Token: 0x06000075 RID: 117 RVA: 0x00008590 File Offset: 0x00006790
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			bool flag2 = flag;
			if (flag2)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000085CC File Offset: 0x000067CC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Siticone.UI.AnimatorNS.Animation animation = new global::Siticone.UI.AnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Auth.GG_Winform_Example.Register));
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneTransition1 = new global::Siticone.UI.WinForms.SiticoneTransition();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.siticoneRoundedButton1 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneRoundedButton2 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneImageButton1 = new global::Siticone.UI.WinForms.SiticoneImageButton();
			this.email = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.password = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.username = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.license = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.siticoneShadowForm = new global::Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.siticoneDragControl1.TargetControl = this;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BorderRadius = 10;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.siticoneControlBox1.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(232, 17, 35);
			this.siticoneControlBox1.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(275, 4);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox1.TabIndex = 1;
			this.siticoneControlBox1.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.BorderRadius = 10;
			this.siticoneControlBox2.ControlBoxType = global::Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(230, 4);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox2.TabIndex = 2;
			this.siticoneTransition1.AnimationType = global::Siticone.UI.AnimatorNS.AnimationType.Rotate;
			this.siticoneTransition1.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation4.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation4.MosaicCoeff");
			animation.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation4.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new global::System.Windows.Forms.Padding(50);
			animation.RotateCoeff = 1f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation4.ScaleCoeff");
			animation.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation4.SlideCoeff");
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 1f;
			this.siticoneTransition1.DefaultAnimation = animation;
			this.label1.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Light", 10f);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(-1, 136);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0, 19);
			this.label1.TabIndex = 22;
			this.label2.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10.2f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new global::System.Drawing.Point(10, 11);
			this.label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(106, 19);
			this.label2.TabIndex = 27;
			this.label2.Text = "Retro | Register";
			this.siticoneRoundedButton1.BorderColor = global::System.Drawing.Color.DodgerBlue;
			this.siticoneRoundedButton1.BorderThickness = 1;
			this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneRoundedButton1.FillColor = global::System.Drawing.Color.FromArgb(7, 127, 243);
			this.siticoneRoundedButton1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton1.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton1.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.Location = new global::System.Drawing.Point(34, 284);
			this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
			this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.Size = new global::System.Drawing.Size(255, 27);
			this.siticoneRoundedButton1.TabIndex = 26;
			this.siticoneRoundedButton1.Text = "Back to Login";
			this.siticoneRoundedButton1.Click += new global::System.EventHandler(this.siticoneRoundedButton1_Click);
			this.siticoneRoundedButton2.BorderColor = global::System.Drawing.Color.DodgerBlue;
			this.siticoneRoundedButton2.BorderThickness = 1;
			this.siticoneRoundedButton2.CheckedState.Parent = this.siticoneRoundedButton2;
			this.siticoneRoundedButton2.CustomImages.Parent = this.siticoneRoundedButton2;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneRoundedButton2.FillColor = global::System.Drawing.Color.FromArgb(7, 127, 243);
			this.siticoneRoundedButton2.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton2.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton2.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton2.HoveredState.Parent = this.siticoneRoundedButton2;
			this.siticoneRoundedButton2.Location = new global::System.Drawing.Point(34, 250);
			this.siticoneRoundedButton2.Name = "siticoneRoundedButton2";
			this.siticoneRoundedButton2.ShadowDecoration.Parent = this.siticoneRoundedButton2;
			this.siticoneRoundedButton2.Size = new global::System.Drawing.Size(255, 27);
			this.siticoneRoundedButton2.TabIndex = 28;
			this.siticoneRoundedButton2.Text = "Register";
			this.siticoneRoundedButton2.Click += new global::System.EventHandler(this.siticoneRoundedButton2_Click);
			this.siticoneImageButton1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneImageButton1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.siticoneImageButton1.CheckedState.Parent = this.siticoneImageButton1;
			this.siticoneTransition1.SetDecoration(this.siticoneImageButton1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneImageButton1.Enabled = false;
			this.siticoneImageButton1.HoveredState.ImageSize = new global::System.Drawing.Size(200, 100);
			this.siticoneImageButton1.HoveredState.Parent = this.siticoneImageButton1;
			this.siticoneImageButton1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("siticoneImageButton1.Image");
			this.siticoneImageButton1.ImageSize = new global::System.Drawing.Size(200, 100);
			this.siticoneImageButton1.Location = new global::System.Drawing.Point(7, 35);
			this.siticoneImageButton1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.siticoneImageButton1.Name = "siticoneImageButton1";
			this.siticoneImageButton1.PressedState.ImageSize = new global::System.Drawing.Size(200, 100);
			this.siticoneImageButton1.PressedState.Parent = this.siticoneImageButton1;
			this.siticoneImageButton1.Size = new global::System.Drawing.Size(304, 54);
			this.siticoneImageButton1.TabIndex = 33;
			this.siticoneImageButton1.Visible = false;
			this.email.AllowDrop = true;
			this.email.BorderColor = global::System.Drawing.Color.FromArgb(7, 127, 243);
			this.email.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.email, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.email.DefaultText = "Email";
			this.email.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.email.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.email.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.email.DisabledState.Parent = this.email;
			this.email.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.email.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.email.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.email.FocusedState.Parent = this.email;
			this.email.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.email.HoveredState.Parent = this.email;
			this.email.Location = new global::System.Drawing.Point(42, 167);
			this.email.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.email.Name = "email";
			this.email.PasswordChar = '\0';
			this.email.PlaceholderText = "";
			this.email.SelectedText = "";
			this.email.ShadowDecoration.Parent = this.email;
			this.email.Size = new global::System.Drawing.Size(236, 30);
			this.email.TabIndex = 34;
			this.email.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.password.AllowDrop = true;
			this.password.BorderColor = global::System.Drawing.Color.FromArgb(7, 127, 243);
			this.password.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.password, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.password.DefaultText = "Password";
			this.password.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.password.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.password.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.password.DisabledState.Parent = this.password;
			this.password.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.password.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.password.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.password.FocusedState.Parent = this.password;
			this.password.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.password.HoveredState.Parent = this.password;
			this.password.Location = new global::System.Drawing.Point(42, 132);
			this.password.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.password.Name = "password";
			this.password.PasswordChar = '\0';
			this.password.PlaceholderText = "";
			this.password.SelectedText = "";
			this.password.ShadowDecoration.Parent = this.password;
			this.password.Size = new global::System.Drawing.Size(236, 30);
			this.password.TabIndex = 35;
			this.password.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.username.AllowDrop = true;
			this.username.BorderColor = global::System.Drawing.Color.FromArgb(7, 127, 243);
			this.username.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.username, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.username.DefaultText = "Username";
			this.username.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.username.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.username.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.username.DisabledState.Parent = this.username;
			this.username.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.username.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.username.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.username.FocusedState.Parent = this.username;
			this.username.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.username.HoveredState.Parent = this.username;
			this.username.Location = new global::System.Drawing.Point(42, 94);
			this.username.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.username.Name = "username";
			this.username.PasswordChar = '\0';
			this.username.PlaceholderText = "";
			this.username.SelectedText = "";
			this.username.ShadowDecoration.Parent = this.username;
			this.username.Size = new global::System.Drawing.Size(236, 30);
			this.username.TabIndex = 36;
			this.username.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.license.AllowDrop = true;
			this.license.BorderColor = global::System.Drawing.Color.FromArgb(7, 127, 243);
			this.license.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.license, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.license.DefaultText = "License";
			this.license.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.license.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.license.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.license.DisabledState.Parent = this.license;
			this.license.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.license.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.license.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.license.FocusedState.Parent = this.license;
			this.license.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.license.HoveredState.Parent = this.license;
			this.license.Location = new global::System.Drawing.Point(42, 206);
			this.license.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.license.Name = "license";
			this.license.PasswordChar = '\0';
			this.license.PlaceholderText = "";
			this.license.SelectedText = "";
			this.license.ShadowDecoration.Parent = this.license;
			this.license.Size = new global::System.Drawing.Size(236, 30);
			this.license.TabIndex = 37;
			this.license.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.siticoneTransition1.SetDecoration(this.pictureBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(42, 39);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(236, 50);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 38;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			base.ClientSize = new global::System.Drawing.Size(324, 321);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.license);
			base.Controls.Add(this.username);
			base.Controls.Add(this.password);
			base.Controls.Add(this.email);
			base.Controls.Add(this.siticoneImageButton1);
			base.Controls.Add(this.siticoneRoundedButton2);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.siticoneRoundedButton1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.siticoneControlBox2);
			base.Controls.Add(this.siticoneControlBox1);
			this.siticoneTransition1.SetDecoration(this, global::Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Register";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " ";
			base.TransparencyKey = global::System.Drawing.Color.Maroon;
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400005F RID: 95
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000060 RID: 96
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000061 RID: 97
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000062 RID: 98
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x04000063 RID: 99
		private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000066 RID: 102
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;

		// Token: 0x04000067 RID: 103
		private global::Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;

		// Token: 0x04000068 RID: 104
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton2;

		// Token: 0x04000069 RID: 105
		private global::Siticone.UI.WinForms.SiticoneImageButton siticoneImageButton1;

		// Token: 0x0400006A RID: 106
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox license;

		// Token: 0x0400006B RID: 107
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox username;

		// Token: 0x0400006C RID: 108
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox password;

		// Token: 0x0400006D RID: 109
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox email;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
