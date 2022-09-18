// Decompiled with JetBrains decompiler
// Type: KeyAuth.Main
// Assembly: Loader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5D07A1EC-42C3-426D-8F3E-4E083BF3DB7C
// Assembly location: C:\Users\xande\Desktop\32 bit spy\Loader.exe

using Loader.Gui;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;
using Siticone.UI.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace KeyAuth
{
  public class Main : Form
  {
    private Form activateForm = (Form) null;
    private string chatchannel = "testing";
    private IContainer components = (IContainer) null;
    private SiticoneDragControl siticoneDragControl1;
    private SiticoneControlBox siticoneControlBox1;
    private SiticoneControlBox siticoneControlBox2;
    private Label label1;
    private SiticoneShadowForm siticoneShadowForm;
    private SiticoneLabel subscription;
    private SiticoneLabel expiry;
    private Timer timer1;
    private Timer timer2;
    private Panel panel1;
    private SiticoneRoundedButton siticoneRoundedButton1;
    private SiticoneRoundedButton LoginBtn;
    private Label label7;
    private PictureBox pictureBox1;
    private Label label6;
    private Label label4;
    private Label label2;
    private Label label3;
    private Panel pnlDescripion;
    private Label label5;

    private void openChildForm(Form ChildForm)
    {
      if (this.activateForm != null)
        this.activateForm.Close();
      this.activateForm = ChildForm;
      ChildForm.TopLevel = false;
      ChildForm.FormBorderStyle = FormBorderStyle.None;
      ChildForm.Dock = DockStyle.Fill;
      this.pnlDescripion.Controls.Add((Control) ChildForm);
      this.pnlDescripion.Tag = (object) ChildForm;
      ChildForm.BringToFront();
      ChildForm.Show();
    }

    public Main() => this.InitializeComponent();

    private void siticoneControlBox1_Click(object sender, EventArgs e) => Environment.Exit(0);

    private void Main_Load(object sender, EventArgs e)
    {
      Login.KeyAuthApp.check();
      ((Control) this.expiry).Text = "Expiry: " + this.UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.subscriptions[0].expiry)).ToString();
      ((Control) this.subscription).Text = "Subscription: " + Login.KeyAuthApp.user_data.subscriptions[0].subscription;
      foreach (api.users users in Login.KeyAuthApp.fetchOnline())
        ;
    }

    public static bool SubExist(string name, int len)
    {
      for (int index = 0; index < len; ++index)
      {
        if (Login.KeyAuthApp.user_data.subscriptions[index].subscription == name)
          return true;
      }
      return false;
    }

    public DateTime UnixTimeToDateTime(long unixtime) => new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local).AddSeconds((double) unixtime).ToLocalTime();

    private void sendmsg_Click(object sender, EventArgs e)
    {
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      this.timer1.Interval = 15000;
      if (string.IsNullOrEmpty(this.chatchannel))
        return;
      List<api.msg> msgList = Login.KeyAuthApp.chatget(this.chatchannel);
      if (msgList == null)
        return;
      foreach (api.msg msg in msgList)
        ;
    }

    private void panel1_Paint(object sender, PaintEventArgs e) => this.timer1.Start();

    private void timer2_Tick(object sender, EventArgs e) => this.label6.Text = DateTime.Now.ToLongTimeString();

    private void LoginBtn_Click(object sender, EventArgs e) => this.openChildForm((Form) new FiveM());

    private void label5_Click(object sender, EventArgs e)
    {
    }

    private void siticoneRoundedButton1_Click(object sender, EventArgs e) => this.openChildForm((Form) new ggmss());

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Main));
      this.siticoneDragControl1 = new SiticoneDragControl(this.components);
      this.siticoneControlBox1 = new SiticoneControlBox();
      this.siticoneControlBox2 = new SiticoneControlBox();
      this.label1 = new Label();
      this.expiry = new SiticoneLabel();
      this.subscription = new SiticoneLabel();
      this.siticoneShadowForm = new SiticoneShadowForm(this.components);
      this.timer1 = new Timer(this.components);
      this.timer2 = new Timer(this.components);
      this.label3 = new Label();
      this.label2 = new Label();
      this.label4 = new Label();
      this.label6 = new Label();
      this.pictureBox1 = new PictureBox();
      this.label7 = new Label();
      this.LoginBtn = new SiticoneRoundedButton();
      this.siticoneRoundedButton1 = new SiticoneRoundedButton();
      this.panel1 = new Panel();
      this.label5 = new Label();
      this.pnlDescripion = new Panel();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.siticoneDragControl1.TargetControl = (Control) this;
      ((Control) this.siticoneControlBox1).Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.siticoneControlBox1.BorderRadius = 10;
      this.siticoneControlBox1.FillColor = Color.FromArgb(35, 39, 42);
      this.siticoneControlBox1.HoveredState.FillColor = Color.FromArgb(232, 17, 35);
      this.siticoneControlBox1.HoveredState.IconColor = Color.White;
      this.siticoneControlBox1.HoveredState.Parent = (ControlBox) this.siticoneControlBox1;
      this.siticoneControlBox1.IconColor = Color.White;
      ((Control) this.siticoneControlBox1).Location = new Point(581, 4);
      ((Control) this.siticoneControlBox1).Name = "siticoneControlBox1";
      this.siticoneControlBox1.ShadowDecoration.Parent = (Control) this.siticoneControlBox1;
      ((Control) this.siticoneControlBox1).Size = new Size(45, 29);
      ((Control) this.siticoneControlBox1).TabIndex = 1;
      ((Control) this.siticoneControlBox1).Click += new EventHandler(this.siticoneControlBox1_Click);
      ((Control) this.siticoneControlBox2).Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.siticoneControlBox2.BorderRadius = 10;
      this.siticoneControlBox2.ControlBoxType = (ControlBoxType) 0;
      this.siticoneControlBox2.FillColor = Color.FromArgb(35, 39, 42);
      this.siticoneControlBox2.HoveredState.Parent = (ControlBox) this.siticoneControlBox2;
      this.siticoneControlBox2.IconColor = Color.White;
      ((Control) this.siticoneControlBox2).Location = new Point(536, 4);
      ((Control) this.siticoneControlBox2).Name = "siticoneControlBox2";
      this.siticoneControlBox2.ShadowDecoration.Parent = (Control) this.siticoneControlBox2;
      ((Control) this.siticoneControlBox2).Size = new Size(45, 29);
      ((Control) this.siticoneControlBox2).TabIndex = 2;
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Segoe UI Light", 10f);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(-1, 136);
      this.label1.Name = "label1";
      this.label1.Size = new Size(0, 19);
      this.label1.TabIndex = 22;
      ((Control) this.expiry).BackColor = Color.Transparent;
      this.expiry.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.expiry.ForeColor = SystemColors.ButtonHighlight;
      ((Control) this.expiry).Location = new Point(15, 289);
      ((Control) this.expiry).Margin = new Padding(2);
      ((Control) this.expiry).Name = "expiry";
      ((Control) this.expiry).Size = new Size(56, 14);
      ((Control) this.expiry).TabIndex = 38;
      ((Control) this.expiry).Text = "expiryLabel";
      ((Control) this.subscription).BackColor = Color.Transparent;
      this.subscription.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.subscription.ForeColor = SystemColors.ButtonHighlight;
      ((Control) this.subscription).Location = new Point(15, 308);
      ((Control) this.subscription).Margin = new Padding(2);
      ((Control) this.subscription).Name = "subscription";
      ((Control) this.subscription).Size = new Size(84, 14);
      ((Control) this.subscription).TabIndex = 39;
      ((Control) this.subscription).Text = "subscriptionLabel";
      this.timer1.Enabled = true;
      this.timer1.Interval = 1;
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.timer2.Enabled = true;
      this.timer2.Tick += new EventHandler(this.timer2_Tick);
      this.label3.AutoSize = true;
      this.label3.BackColor = Color.Transparent;
      this.label3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.White;
      this.label3.Location = new Point(37, 26);
      this.label3.Name = "label3";
      this.label3.Size = new Size(51, 15);
      this.label3.TabIndex = 3;
      this.label3.Text = "ꜱᴘᴏᴏꜰᴇʀ";
      this.label2.AutoSize = true;
      this.label2.BackColor = Color.Transparent;
      this.label2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.Magenta;
      this.label2.Location = new Point(6, 13);
      this.label2.Name = "label2";
      this.label2.Size = new Size(67, 18);
      this.label2.TabIndex = 0;
      this.label2.Text = "ʟᴇᴛʜᴀʟɪᴛʏ";
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.ForeColor = Color.Red;
      this.label4.Location = new Point(86, 18);
      this.label4.Name = "label4";
      this.label4.Size = new Size(14, 20);
      this.label4.TabIndex = 2;
      this.label4.Text = "|";
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label6.ForeColor = Color.White;
      this.label6.Location = new Point(98, 22);
      this.label6.Name = "label6";
      this.label6.Size = new Size(35, 15);
      this.label6.TabIndex = 5;
      this.label6.Text = "Time";
      this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
      this.pictureBox1.Location = new Point(9, 221);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(41, 33);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 6;
      this.pictureBox1.TabStop = false;
      this.label7.AutoSize = true;
      this.label7.BackColor = Color.Transparent;
      this.label7.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label7.ForeColor = Color.FromArgb(0, 192, 0);
      this.label7.Location = new Point(62, 237);
      this.label7.Name = "label7";
      this.label7.Size = new Size(61, 15);
      this.label7.TabIndex = 8;
      this.label7.Text = "ᴅᴇᴠᴇʟᴏᴘᴇʀ";
      ((SiticoneButton) this.LoginBtn).BorderColor = Color.Red;
      ((SiticoneButton) this.LoginBtn).BorderStyle = DashStyle.DashDotDot;
      ((SiticoneButton) this.LoginBtn).BorderThickness = 1;
      ((SiticoneButton) this.LoginBtn).CheckedState.Parent = (CustomButtonBase) this.LoginBtn;
      ((SiticoneButton) this.LoginBtn).CustomImages.Parent = (CustomButtonBase) this.LoginBtn;
      ((SiticoneButton) this.LoginBtn).FillColor = Color.Black;
      ((Control) this.LoginBtn).Font = new Font("Franklin Gothic Medium", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.LoginBtn).ForeColor = Color.White;
      ((SiticoneButton) this.LoginBtn).HoveredState.BorderColor = Color.FromArgb(213, 218, 223);
      ((SiticoneButton) this.LoginBtn).HoveredState.Parent = (CustomButtonBase) this.LoginBtn;
      ((Control) this.LoginBtn).Location = new Point(40, 89);
      ((Control) this.LoginBtn).Name = "LoginBtn";
      ((SiticoneButton) this.LoginBtn).ShadowDecoration.Parent = (Control) this.LoginBtn;
      ((Control) this.LoginBtn).Size = new Size(110, 40);
      ((Control) this.LoginBtn).TabIndex = 27;
      ((Control) this.LoginBtn).Text = "Games";
      ((Control) this.LoginBtn).Click += new EventHandler(this.LoginBtn_Click);
      ((SiticoneButton) this.siticoneRoundedButton1).BorderColor = Color.Red;
      ((SiticoneButton) this.siticoneRoundedButton1).BorderStyle = DashStyle.DashDotDot;
      ((SiticoneButton) this.siticoneRoundedButton1).BorderThickness = 1;
      ((SiticoneButton) this.siticoneRoundedButton1).CheckedState.Parent = (CustomButtonBase) this.siticoneRoundedButton1;
      ((SiticoneButton) this.siticoneRoundedButton1).CustomImages.Parent = (CustomButtonBase) this.siticoneRoundedButton1;
      ((SiticoneButton) this.siticoneRoundedButton1).FillColor = Color.Black;
      ((Control) this.siticoneRoundedButton1).Font = new Font("Franklin Gothic Medium", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      ((Control) this.siticoneRoundedButton1).ForeColor = Color.White;
      ((SiticoneButton) this.siticoneRoundedButton1).HoveredState.BorderColor = Color.FromArgb(213, 218, 223);
      ((SiticoneButton) this.siticoneRoundedButton1).HoveredState.Parent = (CustomButtonBase) this.siticoneRoundedButton1;
      ((Control) this.siticoneRoundedButton1).Location = new Point(40, 151);
      ((Control) this.siticoneRoundedButton1).Name = "siticoneRoundedButton1";
      ((SiticoneButton) this.siticoneRoundedButton1).ShadowDecoration.Parent = (Control) this.siticoneRoundedButton1;
      ((Control) this.siticoneRoundedButton1).Size = new Size(110, 40);
      ((Control) this.siticoneRoundedButton1).TabIndex = 28;
      ((Control) this.siticoneRoundedButton1).Text = "System";
      ((Control) this.siticoneRoundedButton1).Click += new EventHandler(this.siticoneRoundedButton1_Click);
      this.panel1.BackColor = Color.Black;
      this.panel1.Controls.Add((Control) this.label5);
      this.panel1.Controls.Add((Control) this.siticoneRoundedButton1);
      this.panel1.Controls.Add((Control) this.LoginBtn);
      this.panel1.Controls.Add((Control) this.label7);
      this.panel1.Controls.Add((Control) this.pictureBox1);
      this.panel1.Controls.Add((Control) this.label6);
      this.panel1.Controls.Add((Control) this.label4);
      this.panel1.Controls.Add((Control) this.label2);
      this.panel1.Controls.Add((Control) this.label3);
      this.panel1.Dock = DockStyle.Left;
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.RightToLeft = RightToLeft.No;
      this.panel1.Size = new Size(194, 331);
      this.panel1.TabIndex = 40;
      this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label5.ForeColor = Color.White;
      this.label5.Location = new Point(48, 223);
      this.label5.Name = "label5";
      this.label5.Size = new Size(88, 16);
      this.label5.TabIndex = 30;
      this.label5.Text = "ᴍxᴢ ʟᴇᴛʜᴀʟɪᴛʏ";
      this.pnlDescripion.Location = new Point(195, 0);
      this.pnlDescripion.Name = "pnlDescripion";
      this.pnlDescripion.Size = new Size(432, 331);
      this.pnlDescripion.TabIndex = 41;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.AutoValidate = AutoValidate.Disable;
      this.BackColor = Color.Black;
      this.ClientSize = new Size(630, 331);
      this.Controls.Add((Control) this.subscription);
      this.Controls.Add((Control) this.expiry);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.siticoneControlBox2);
      this.Controls.Add((Control) this.siticoneControlBox1);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.pnlDescripion);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (Main);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Loader";
      this.TransparencyKey = Color.Maroon;
      this.Load += new EventHandler(this.Main_Load);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
