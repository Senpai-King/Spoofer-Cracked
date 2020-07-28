namespace Auth.GG_Winform_Example
{
	// Token: 0x0200000C RID: 12
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x0600006F RID: 111 RVA: 0x00004BC4 File Offset: 0x00002DC4
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

		// Token: 0x06000070 RID: 112 RVA: 0x00004C00 File Offset: 0x00002E00
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Siticone.UI.AnimatorNS.Animation animation = new global::Siticone.UI.AnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Auth.GG_Winform_Example.Main));
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneTransition1 = new global::Siticone.UI.WinForms.SiticoneTransition();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.siticoneRoundedButton2 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.variable = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.userid = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.username = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.email = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.hwid = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.uservariable = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.userrank = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.ip = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.expiry = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.lastlogin = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.registerdate = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.SpBut = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2ToggleSwitch1 = new global::Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.guna2ToggleSwitch2 = new global::Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.label5 = new global::System.Windows.Forms.Label();
			this.guna2ToggleSwitch3 = new global::Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.label6 = new global::System.Windows.Forms.Label();
			this.guna2ToggleSwitch4 = new global::Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.label7 = new global::System.Windows.Forms.Label();
			this.guna2ToggleSwitch5 = new global::Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.label8 = new global::System.Windows.Forms.Label();
			this.guna2ToggleSwitch6 = new global::Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.label9 = new global::System.Windows.Forms.Label();
			this.guna2ToggleSwitch7 = new global::Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label10 = new global::System.Windows.Forms.Label();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label11 = new global::System.Windows.Forms.Label();
			this.guna2ToggleSwitch8 = new global::Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.label12 = new global::System.Windows.Forms.Label();
			this.guna2ToggleSwitch9 = new global::Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.label13 = new global::System.Windows.Forms.Label();
			this.guna2ToggleSwitch10 = new global::Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.label14 = new global::System.Windows.Forms.Label();
			this.guna2ToggleSwitch11 = new global::Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.label15 = new global::System.Windows.Forms.Label();
			this.guna2ToggleSwitch12 = new global::Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.label16 = new global::System.Windows.Forms.Label();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.label17 = new global::System.Windows.Forms.Label();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.siticoneShadowForm = new global::Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
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
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(520, 4);
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
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(475, 4);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox2.TabIndex = 2;
			this.siticoneTransition1.AnimationType = global::Siticone.UI.AnimatorNS.AnimationType.Rotate;
			this.siticoneTransition1.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.MosaicCoeff");
			animation.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new global::System.Windows.Forms.Padding(50);
			animation.RotateCoeff = 1f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.ScaleCoeff");
			animation.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.SlideCoeff");
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
			this.label2.Size = new global::System.Drawing.Size(87, 19);
			this.label2.TabIndex = 27;
			this.label2.Text = "Retro | Main";
			this.label2.Click += new global::System.EventHandler(this.label2_Click);
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
			this.siticoneRoundedButton2.Location = new global::System.Drawing.Point(535, 127);
			this.siticoneRoundedButton2.Name = "siticoneRoundedButton2";
			this.siticoneRoundedButton2.ShadowDecoration.Parent = this.siticoneRoundedButton2;
			this.siticoneRoundedButton2.Size = new global::System.Drawing.Size(0, 0);
			this.siticoneRoundedButton2.TabIndex = 28;
			this.siticoneRoundedButton2.Text = "Grab Server Variable";
			this.siticoneRoundedButton2.Click += new global::System.EventHandler(this.siticoneRoundedButton2_Click);
			this.variable.AllowDrop = true;
			this.variable.BorderColor = global::System.Drawing.Color.FromArgb(7, 127, 243);
			this.variable.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.variable, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.variable.DefaultText = "Variable Secret";
			this.variable.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.variable.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.variable.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.variable.DisabledState.Parent = this.variable;
			this.variable.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.variable.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.variable.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.variable.FocusedState.Parent = this.variable;
			this.variable.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.variable.HoveredState.Parent = this.variable;
			this.variable.Location = new global::System.Drawing.Point(535, 93);
			this.variable.Margin = new global::System.Windows.Forms.Padding(4);
			this.variable.Name = "variable";
			this.variable.PasswordChar = '\0';
			this.variable.PlaceholderText = "";
			this.variable.SelectedText = "";
			this.variable.ShadowDecoration.Parent = this.variable;
			this.variable.Size = new global::System.Drawing.Size(0, 0);
			this.variable.TabIndex = 36;
			this.variable.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.userid.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.userid.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.userid, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.userid.Enabled = false;
			this.userid.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.userid.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.userid.Location = new global::System.Drawing.Point(20, 69);
			this.userid.Margin = new global::System.Windows.Forms.Padding(2);
			this.userid.Name = "userid";
			this.userid.Size = new global::System.Drawing.Size(69, 14);
			this.userid.TabIndex = 37;
			this.userid.Text = "siticoneLabel1";
			this.userid.Visible = false;
			this.username.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.username, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.username.Enabled = false;
			this.username.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.username.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.username.Location = new global::System.Drawing.Point(20, 80);
			this.username.Margin = new global::System.Windows.Forms.Padding(2);
			this.username.Name = "username";
			this.username.Size = new global::System.Drawing.Size(69, 14);
			this.username.TabIndex = 38;
			this.username.Text = "siticoneLabel2";
			this.username.Visible = false;
			this.email.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.email, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.email.Enabled = false;
			this.email.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.email.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.email.Location = new global::System.Drawing.Point(20, 101);
			this.email.Margin = new global::System.Windows.Forms.Padding(2);
			this.email.Name = "email";
			this.email.Size = new global::System.Drawing.Size(69, 14);
			this.email.TabIndex = 39;
			this.email.Text = "siticoneLabel3";
			this.email.Visible = false;
			this.hwid.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.hwid, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.hwid.Enabled = false;
			this.hwid.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.hwid.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.hwid.Location = new global::System.Drawing.Point(20, 121);
			this.hwid.Margin = new global::System.Windows.Forms.Padding(2);
			this.hwid.Name = "hwid";
			this.hwid.Size = new global::System.Drawing.Size(69, 14);
			this.hwid.TabIndex = 40;
			this.hwid.Text = "siticoneLabel4";
			this.hwid.Visible = false;
			this.uservariable.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.uservariable, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.uservariable.Enabled = false;
			this.uservariable.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.uservariable.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.uservariable.Location = new global::System.Drawing.Point(20, 141);
			this.uservariable.Margin = new global::System.Windows.Forms.Padding(2);
			this.uservariable.Name = "uservariable";
			this.uservariable.Size = new global::System.Drawing.Size(69, 14);
			this.uservariable.TabIndex = 41;
			this.uservariable.Text = "siticoneLabel4";
			this.uservariable.Visible = false;
			this.userrank.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.userrank, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.userrank.Enabled = false;
			this.userrank.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.userrank.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.userrank.Location = new global::System.Drawing.Point(20, 162);
			this.userrank.Margin = new global::System.Windows.Forms.Padding(2);
			this.userrank.Name = "userrank";
			this.userrank.Size = new global::System.Drawing.Size(69, 14);
			this.userrank.TabIndex = 42;
			this.userrank.Text = "siticoneLabel4";
			this.userrank.Visible = false;
			this.ip.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.ip, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.ip.Enabled = false;
			this.ip.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ip.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.ip.Location = new global::System.Drawing.Point(20, 182);
			this.ip.Margin = new global::System.Windows.Forms.Padding(2);
			this.ip.Name = "ip";
			this.ip.Size = new global::System.Drawing.Size(69, 14);
			this.ip.TabIndex = 43;
			this.ip.Text = "siticoneLabel4";
			this.ip.Visible = false;
			this.expiry.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.expiry, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.expiry.Enabled = false;
			this.expiry.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.expiry.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.expiry.Location = new global::System.Drawing.Point(20, 202);
			this.expiry.Margin = new global::System.Windows.Forms.Padding(2);
			this.expiry.Name = "expiry";
			this.expiry.Size = new global::System.Drawing.Size(69, 14);
			this.expiry.TabIndex = 44;
			this.expiry.Text = "siticoneLabel4";
			this.expiry.Visible = false;
			this.lastlogin.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.lastlogin, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.lastlogin.Enabled = false;
			this.lastlogin.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lastlogin.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.lastlogin.Location = new global::System.Drawing.Point(20, 223);
			this.lastlogin.Margin = new global::System.Windows.Forms.Padding(2);
			this.lastlogin.Name = "lastlogin";
			this.lastlogin.Size = new global::System.Drawing.Size(69, 14);
			this.lastlogin.TabIndex = 45;
			this.lastlogin.Text = "siticoneLabel4";
			this.lastlogin.Visible = false;
			this.registerdate.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.registerdate, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.registerdate.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.registerdate.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.registerdate.Location = new global::System.Drawing.Point(20, 243);
			this.registerdate.Margin = new global::System.Windows.Forms.Padding(2);
			this.registerdate.Name = "registerdate";
			this.registerdate.Size = new global::System.Drawing.Size(69, 14);
			this.registerdate.TabIndex = 46;
			this.registerdate.Text = "siticoneLabel4";
			this.registerdate.Visible = false;
			this.textBox1.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.siticoneTransition1.SetDecoration(this.textBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.textBox1.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold);
			this.textBox1.ForeColor = global::System.Drawing.SystemColors.InactiveBorder;
			this.textBox1.Location = new global::System.Drawing.Point(290, 148);
			this.textBox1.Margin = new global::System.Windows.Forms.Padding(2);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(0, 0);
			this.textBox1.TabIndex = 48;
			this.textBox1.Text = componentResourceManager.GetString("textBox1.Text");
			this.textBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.SpBut.Animated = true;
			this.SpBut.AutoRoundedCorners = true;
			this.SpBut.BorderRadius = 21;
			this.SpBut.CheckedState.Parent = this.SpBut;
			this.SpBut.CustomImages.Parent = this.SpBut;
			this.siticoneTransition1.SetDecoration(this.SpBut, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.SpBut.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.SpBut.ForeColor = global::System.Drawing.Color.White;
			this.SpBut.HoverState.Parent = this.SpBut;
			this.SpBut.Location = new global::System.Drawing.Point(17, 38);
			this.SpBut.Name = "SpBut";
			this.SpBut.ShadowDecoration.Parent = this.SpBut;
			this.SpBut.Size = new global::System.Drawing.Size(187, 45);
			this.SpBut.TabIndex = 49;
			this.SpBut.Text = "Apply Spoof";
			this.SpBut.Click += new global::System.EventHandler(this.guna2Button1_Click);
			this.guna2ToggleSwitch1.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch1.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch1.CheckedState.InnerColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch1.CheckedState.Parent = this.guna2ToggleSwitch1;
			this.siticoneTransition1.SetDecoration(this.guna2ToggleSwitch1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.guna2ToggleSwitch1.Location = new global::System.Drawing.Point(493, 80);
			this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
			this.guna2ToggleSwitch1.ShadowDecoration.Parent = this.guna2ToggleSwitch1;
			this.guna2ToggleSwitch1.Size = new global::System.Drawing.Size(35, 20);
			this.guna2ToggleSwitch1.TabIndex = 50;
			this.guna2ToggleSwitch1.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch1.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch1.UncheckedState.InnerColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch1.UncheckedState.Parent = this.guna2ToggleSwitch1;
			this.label3.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label3, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label3.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(347, 80);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(98, 21);
			this.label3.TabIndex = 51;
			this.label3.Text = "Disk Drive(s)";
			this.label3.Click += new global::System.EventHandler(this.label3_Click);
			this.label4.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label4, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label4.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(347, 106);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(68, 21);
			this.label4.TabIndex = 53;
			this.label4.Text = "Serial ID";
			this.guna2ToggleSwitch2.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch2.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch2.CheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch2.CheckedState.InnerColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch2.CheckedState.Parent = this.guna2ToggleSwitch2;
			this.siticoneTransition1.SetDecoration(this.guna2ToggleSwitch2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.guna2ToggleSwitch2.Location = new global::System.Drawing.Point(493, 106);
			this.guna2ToggleSwitch2.Name = "guna2ToggleSwitch2";
			this.guna2ToggleSwitch2.ShadowDecoration.Parent = this.guna2ToggleSwitch2;
			this.guna2ToggleSwitch2.Size = new global::System.Drawing.Size(35, 20);
			this.guna2ToggleSwitch2.TabIndex = 52;
			this.guna2ToggleSwitch2.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch2.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch2.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch2.UncheckedState.InnerColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch2.UncheckedState.Parent = this.guna2ToggleSwitch2;
			this.label5.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label5, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label5.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(347, 134);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(99, 21);
			this.label5.TabIndex = 55;
			this.label5.Text = "Mac Address";
			this.guna2ToggleSwitch3.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch3.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch3.CheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch3.CheckedState.InnerColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch3.CheckedState.Parent = this.guna2ToggleSwitch3;
			this.siticoneTransition1.SetDecoration(this.guna2ToggleSwitch3, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.guna2ToggleSwitch3.Location = new global::System.Drawing.Point(493, 134);
			this.guna2ToggleSwitch3.Name = "guna2ToggleSwitch3";
			this.guna2ToggleSwitch3.ShadowDecoration.Parent = this.guna2ToggleSwitch3;
			this.guna2ToggleSwitch3.Size = new global::System.Drawing.Size(35, 20);
			this.guna2ToggleSwitch3.TabIndex = 54;
			this.guna2ToggleSwitch3.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch3.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch3.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch3.UncheckedState.InnerColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch3.UncheckedState.Parent = this.guna2ToggleSwitch3;
			this.label6.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label6, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label6.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.Color.White;
			this.label6.Location = new global::System.Drawing.Point(347, 162);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(102, 21);
			this.label6.TabIndex = 57;
			this.label6.Text = "Motherboard";
			this.guna2ToggleSwitch4.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch4.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch4.CheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch4.CheckedState.InnerColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch4.CheckedState.Parent = this.guna2ToggleSwitch4;
			this.siticoneTransition1.SetDecoration(this.guna2ToggleSwitch4, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.guna2ToggleSwitch4.Location = new global::System.Drawing.Point(493, 162);
			this.guna2ToggleSwitch4.Name = "guna2ToggleSwitch4";
			this.guna2ToggleSwitch4.ShadowDecoration.Parent = this.guna2ToggleSwitch4;
			this.guna2ToggleSwitch4.Size = new global::System.Drawing.Size(35, 20);
			this.guna2ToggleSwitch4.TabIndex = 56;
			this.guna2ToggleSwitch4.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch4.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch4.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch4.UncheckedState.InnerColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch4.UncheckedState.Parent = this.guna2ToggleSwitch4;
			this.label7.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label7, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label7.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.ForeColor = global::System.Drawing.Color.White;
			this.label7.Location = new global::System.Drawing.Point(347, 188);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(41, 21);
			this.label7.TabIndex = 59;
			this.label7.Text = "GPU";
			this.guna2ToggleSwitch5.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch5.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch5.CheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch5.CheckedState.InnerColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch5.CheckedState.Parent = this.guna2ToggleSwitch5;
			this.siticoneTransition1.SetDecoration(this.guna2ToggleSwitch5, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.guna2ToggleSwitch5.Location = new global::System.Drawing.Point(493, 188);
			this.guna2ToggleSwitch5.Name = "guna2ToggleSwitch5";
			this.guna2ToggleSwitch5.ShadowDecoration.Parent = this.guna2ToggleSwitch5;
			this.guna2ToggleSwitch5.Size = new global::System.Drawing.Size(35, 20);
			this.guna2ToggleSwitch5.TabIndex = 58;
			this.guna2ToggleSwitch5.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch5.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch5.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch5.UncheckedState.InnerColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch5.UncheckedState.Parent = this.guna2ToggleSwitch5;
			this.label8.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label8, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label8.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.ForeColor = global::System.Drawing.Color.White;
			this.label8.Location = new global::System.Drawing.Point(347, 214);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(40, 21);
			this.label8.TabIndex = 61;
			this.label8.Text = "CPU";
			this.guna2ToggleSwitch6.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch6.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch6.CheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch6.CheckedState.InnerColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch6.CheckedState.Parent = this.guna2ToggleSwitch6;
			this.siticoneTransition1.SetDecoration(this.guna2ToggleSwitch6, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.guna2ToggleSwitch6.Location = new global::System.Drawing.Point(493, 214);
			this.guna2ToggleSwitch6.Name = "guna2ToggleSwitch6";
			this.guna2ToggleSwitch6.ShadowDecoration.Parent = this.guna2ToggleSwitch6;
			this.guna2ToggleSwitch6.Size = new global::System.Drawing.Size(35, 20);
			this.guna2ToggleSwitch6.TabIndex = 60;
			this.guna2ToggleSwitch6.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch6.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch6.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch6.UncheckedState.InnerColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch6.UncheckedState.Parent = this.guna2ToggleSwitch6;
			this.label9.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label9, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label9.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label9.ForeColor = global::System.Drawing.Color.White;
			this.label9.Location = new global::System.Drawing.Point(347, 240);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(44, 21);
			this.label9.TabIndex = 63;
			this.label9.Text = "BIOS";
			this.label9.Click += new global::System.EventHandler(this.label9_Click);
			this.guna2ToggleSwitch7.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch7.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch7.CheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch7.CheckedState.InnerColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch7.CheckedState.Parent = this.guna2ToggleSwitch7;
			this.siticoneTransition1.SetDecoration(this.guna2ToggleSwitch7, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.guna2ToggleSwitch7.Location = new global::System.Drawing.Point(493, 240);
			this.guna2ToggleSwitch7.Name = "guna2ToggleSwitch7";
			this.guna2ToggleSwitch7.ShadowDecoration.Parent = this.guna2ToggleSwitch7;
			this.guna2ToggleSwitch7.Size = new global::System.Drawing.Size(35, 20);
			this.guna2ToggleSwitch7.TabIndex = 62;
			this.guna2ToggleSwitch7.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch7.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch7.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch7.UncheckedState.InnerColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch7.UncheckedState.Parent = this.guna2ToggleSwitch7;
			this.guna2ToggleSwitch7.CheckedChanged += new global::System.EventHandler(this.guna2ToggleSwitch7_CheckedChanged);
			this.siticoneTransition1.SetDecoration(this.pictureBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(337, 36);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(28, 25);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 64;
			this.pictureBox1.TabStop = false;
			this.label10.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label10, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label10.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label10.ForeColor = global::System.Drawing.Color.White;
			this.label10.Location = new global::System.Drawing.Point(371, 36);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(157, 25);
			this.label10.TabIndex = 65;
			this.label10.Text = "Manual Spoofing";
			this.panel1.BackColor = global::System.Drawing.Color.White;
			this.siticoneTransition1.SetDecoration(this.panel1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel1.Location = new global::System.Drawing.Point(336, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(192, 3);
			this.panel1.TabIndex = 66;
			this.label11.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label11, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label11.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label11.ForeColor = global::System.Drawing.Color.White;
			this.label11.Location = new global::System.Drawing.Point(23, 136);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(68, 21);
			this.label11.TabIndex = 68;
			this.label11.Text = "Valorant";
			this.guna2ToggleSwitch8.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch8.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch8.CheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch8.CheckedState.InnerColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch8.CheckedState.Parent = this.guna2ToggleSwitch8;
			this.siticoneTransition1.SetDecoration(this.guna2ToggleSwitch8, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.guna2ToggleSwitch8.Location = new global::System.Drawing.Point(169, 136);
			this.guna2ToggleSwitch8.Name = "guna2ToggleSwitch8";
			this.guna2ToggleSwitch8.ShadowDecoration.Parent = this.guna2ToggleSwitch8;
			this.guna2ToggleSwitch8.Size = new global::System.Drawing.Size(35, 20);
			this.guna2ToggleSwitch8.TabIndex = 67;
			this.guna2ToggleSwitch8.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch8.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch8.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch8.UncheckedState.InnerColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch8.UncheckedState.Parent = this.guna2ToggleSwitch8;
			this.label12.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label12, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label12.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label12.ForeColor = global::System.Drawing.Color.White;
			this.label12.Location = new global::System.Drawing.Point(23, 163);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(71, 21);
			this.label12.TabIndex = 70;
			this.label12.Text = "Warzone";
			this.guna2ToggleSwitch9.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch9.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch9.CheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch9.CheckedState.InnerColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch9.CheckedState.Parent = this.guna2ToggleSwitch9;
			this.siticoneTransition1.SetDecoration(this.guna2ToggleSwitch9, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.guna2ToggleSwitch9.Location = new global::System.Drawing.Point(169, 163);
			this.guna2ToggleSwitch9.Name = "guna2ToggleSwitch9";
			this.guna2ToggleSwitch9.ShadowDecoration.Parent = this.guna2ToggleSwitch9;
			this.guna2ToggleSwitch9.Size = new global::System.Drawing.Size(35, 20);
			this.guna2ToggleSwitch9.TabIndex = 69;
			this.guna2ToggleSwitch9.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch9.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch9.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch9.UncheckedState.InnerColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch9.UncheckedState.Parent = this.guna2ToggleSwitch9;
			this.label13.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label13, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label13.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label13.ForeColor = global::System.Drawing.Color.White;
			this.label13.Location = new global::System.Drawing.Point(23, 188);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(64, 21);
			this.label13.TabIndex = 72;
			this.label13.Text = "Fortnite";
			this.guna2ToggleSwitch10.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch10.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch10.CheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch10.CheckedState.InnerColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch10.CheckedState.Parent = this.guna2ToggleSwitch10;
			this.siticoneTransition1.SetDecoration(this.guna2ToggleSwitch10, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.guna2ToggleSwitch10.Location = new global::System.Drawing.Point(169, 188);
			this.guna2ToggleSwitch10.Name = "guna2ToggleSwitch10";
			this.guna2ToggleSwitch10.ShadowDecoration.Parent = this.guna2ToggleSwitch10;
			this.guna2ToggleSwitch10.Size = new global::System.Drawing.Size(35, 20);
			this.guna2ToggleSwitch10.TabIndex = 71;
			this.guna2ToggleSwitch10.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch10.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch10.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch10.UncheckedState.InnerColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch10.UncheckedState.Parent = this.guna2ToggleSwitch10;
			this.label14.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label14, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label14.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label14.ForeColor = global::System.Drawing.Color.White;
			this.label14.Location = new global::System.Drawing.Point(23, 214);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(38, 21);
			this.label14.TabIndex = 74;
			this.label14.Text = "R6S";
			this.guna2ToggleSwitch11.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch11.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch11.CheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch11.CheckedState.InnerColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch11.CheckedState.Parent = this.guna2ToggleSwitch11;
			this.siticoneTransition1.SetDecoration(this.guna2ToggleSwitch11, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.guna2ToggleSwitch11.Location = new global::System.Drawing.Point(169, 214);
			this.guna2ToggleSwitch11.Name = "guna2ToggleSwitch11";
			this.guna2ToggleSwitch11.ShadowDecoration.Parent = this.guna2ToggleSwitch11;
			this.guna2ToggleSwitch11.Size = new global::System.Drawing.Size(35, 20);
			this.guna2ToggleSwitch11.TabIndex = 73;
			this.guna2ToggleSwitch11.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch11.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch11.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch11.UncheckedState.InnerColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch11.UncheckedState.Parent = this.guna2ToggleSwitch11;
			this.label15.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label15, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label15.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label15.ForeColor = global::System.Drawing.Color.White;
			this.label15.Location = new global::System.Drawing.Point(23, 240);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(41, 21);
			this.label15.TabIndex = 76;
			this.label15.Text = "Rust";
			this.label15.Click += new global::System.EventHandler(this.label15_Click);
			this.guna2ToggleSwitch12.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch12.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch12.CheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch12.CheckedState.InnerColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch12.CheckedState.Parent = this.guna2ToggleSwitch12;
			this.siticoneTransition1.SetDecoration(this.guna2ToggleSwitch12, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.guna2ToggleSwitch12.Location = new global::System.Drawing.Point(169, 240);
			this.guna2ToggleSwitch12.Name = "guna2ToggleSwitch12";
			this.guna2ToggleSwitch12.ShadowDecoration.Parent = this.guna2ToggleSwitch12;
			this.guna2ToggleSwitch12.Size = new global::System.Drawing.Size(35, 20);
			this.guna2ToggleSwitch12.TabIndex = 75;
			this.guna2ToggleSwitch12.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch12.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch12.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch12.UncheckedState.InnerColor = global::System.Drawing.Color.White;
			this.guna2ToggleSwitch12.UncheckedState.Parent = this.guna2ToggleSwitch12;
			this.guna2ToggleSwitch12.CheckedChanged += new global::System.EventHandler(this.guna2ToggleSwitch12_CheckedChanged);
			this.label16.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label16, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label16.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label16.ForeColor = global::System.Drawing.Color.White;
			this.label16.Location = new global::System.Drawing.Point(39, 106);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(0, 25);
			this.label16.TabIndex = 77;
			this.panel2.BackColor = global::System.Drawing.Color.White;
			this.siticoneTransition1.SetDecoration(this.panel2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel2.Location = new global::System.Drawing.Point(17, 126);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(192, 3);
			this.panel2.TabIndex = 80;
			this.panel2.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			this.label17.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label17, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label17.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label17.ForeColor = global::System.Drawing.Color.White;
			this.label17.Location = new global::System.Drawing.Point(52, 98);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(157, 25);
			this.label17.TabIndex = 79;
			this.label17.Text = "Spoofing Configs";
			this.label17.Click += new global::System.EventHandler(this.label17_Click);
			this.siticoneTransition1.SetDecoration(this.pictureBox2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.pictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new global::System.Drawing.Point(18, 98);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(28, 25);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 78;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new global::System.EventHandler(this.pictureBox2_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			base.ClientSize = new global::System.Drawing.Size(569, 288);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.label17);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.label16);
			base.Controls.Add(this.label15);
			base.Controls.Add(this.guna2ToggleSwitch12);
			base.Controls.Add(this.label14);
			base.Controls.Add(this.guna2ToggleSwitch11);
			base.Controls.Add(this.label13);
			base.Controls.Add(this.guna2ToggleSwitch10);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.guna2ToggleSwitch9);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.guna2ToggleSwitch8);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.guna2ToggleSwitch7);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.guna2ToggleSwitch6);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.guna2ToggleSwitch5);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.guna2ToggleSwitch4);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.guna2ToggleSwitch3);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.guna2ToggleSwitch2);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.guna2ToggleSwitch1);
			base.Controls.Add(this.SpBut);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.registerdate);
			base.Controls.Add(this.lastlogin);
			base.Controls.Add(this.expiry);
			base.Controls.Add(this.ip);
			base.Controls.Add(this.userrank);
			base.Controls.Add(this.uservariable);
			base.Controls.Add(this.hwid);
			base.Controls.Add(this.email);
			base.Controls.Add(this.username);
			base.Controls.Add(this.userid);
			base.Controls.Add(this.variable);
			base.Controls.Add(this.siticoneRoundedButton2);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.siticoneControlBox2);
			base.Controls.Add(this.siticoneControlBox1);
			this.siticoneTransition1.SetDecoration(this, global::Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Main";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " ";
			base.TransparencyKey = global::System.Drawing.Color.Maroon;
			base.Load += new global::System.EventHandler(this.Main_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400002A RID: 42
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400002B RID: 43
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x0400002C RID: 44
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x0400002D RID: 45
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x0400002E RID: 46
		private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000031 RID: 49
		private global::Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;

		// Token: 0x04000032 RID: 50
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton2;

		// Token: 0x04000033 RID: 51
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox variable;

		// Token: 0x04000034 RID: 52
		private global::Siticone.UI.WinForms.SiticoneLabel hwid;

		// Token: 0x04000035 RID: 53
		private global::Siticone.UI.WinForms.SiticoneLabel email;

		// Token: 0x04000036 RID: 54
		private global::Siticone.UI.WinForms.SiticoneLabel username;

		// Token: 0x04000037 RID: 55
		private global::Siticone.UI.WinForms.SiticoneLabel userid;

		// Token: 0x04000038 RID: 56
		private global::Siticone.UI.WinForms.SiticoneLabel registerdate;

		// Token: 0x04000039 RID: 57
		private global::Siticone.UI.WinForms.SiticoneLabel lastlogin;

		// Token: 0x0400003A RID: 58
		private global::Siticone.UI.WinForms.SiticoneLabel expiry;

		// Token: 0x0400003B RID: 59
		private global::Siticone.UI.WinForms.SiticoneLabel ip;

		// Token: 0x0400003C RID: 60
		private global::Siticone.UI.WinForms.SiticoneLabel userrank;

		// Token: 0x0400003D RID: 61
		private global::Siticone.UI.WinForms.SiticoneLabel uservariable;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000040 RID: 64
		private global::Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;

		// Token: 0x04000041 RID: 65
		private global::Guna.UI2.WinForms.Guna2Button SpBut;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000043 RID: 67
		private global::Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch7;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000045 RID: 69
		private global::Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch6;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000047 RID: 71
		private global::Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch5;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000049 RID: 73
		private global::Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch4;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400004B RID: 75
		private global::Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch3;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400004D RID: 77
		private global::Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch2;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000052 RID: 82
		private global::Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch11;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000054 RID: 84
		private global::Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch10;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000056 RID: 86
		private global::Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch9;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000058 RID: 88
		private global::Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch8;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.Label label15;

		// Token: 0x0400005A RID: 90
		private global::Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch12;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.Label label17;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.Label label16;
	}
}
