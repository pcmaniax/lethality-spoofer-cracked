// Decompiled with JetBrains decompiler
// Type: KeyAuth.Login
// Assembly: Loader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5D07A1EC-42C3-426D-8F3E-4E083BF3DB7C
// Assembly location: C:\Users\xande\Desktop\32 bit spy\Loader.exe

using Guna.UI2.WinForms;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;
using Siticone.UI.WinForms.Suite;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace KeyAuth
{
  public class Login : Form
  {
    public static api KeyAuthApp = new api("Liscense", "IXcRmpcJ8P", "81a14ebabc7a38df9651755b690dc20b18a4a4f5311b1210310fbae69b9f679b", "1.0");
    private IContainer components = (IContainer) null;
    private SiticoneShadowForm siticoneShadowForm;
    private SiticoneControlBox siticoneControlBox1;
    private SiticoneControlBox siticoneControlBox2;
    private Label label1;
    private Label label2;
    private SiticoneRoundedButton RgstrBtn;
    private SiticoneLabel status;
    private SiticoneDragControl siticoneDragControl1;
    private Guna2TextBox username;
    private Guna2TextBox key;
    private Guna2TextBox password;
    private SiticoneRoundedButton LoginBtn;
    private SiticoneRoundedButton siticoneRoundedButton1;

    public Login() => this.InitializeComponent();

    private void siticoneControlBox1_Click(object sender, EventArgs e) => Environment.Exit(0);

    private void Login_Load(object sender, EventArgs e)
    {
      Login.KeyAuthApp.init();
      if (Login.KeyAuthApp.response.message == "invalidver")
      {
        if (!string.IsNullOrEmpty(Login.KeyAuthApp.app_data.downloadLink))
        {
          switch (MessageBox.Show("Yes to open file in browser\nNo to download file automatically", "Auto update", MessageBoxButtons.YesNo))
          {
            case DialogResult.Yes:
              Process.Start(Login.KeyAuthApp.app_data.downloadLink);
              Environment.Exit(0);
              break;
            case DialogResult.No:
              WebClient webClient = new WebClient();
              string fileName = Application.ExecutablePath.Replace(".exe", "-" + Login.random_string() + ".exe");
              webClient.DownloadFile(Login.KeyAuthApp.app_data.downloadLink, fileName);
              Process.Start(fileName);
              Process.Start(new ProcessStartInfo()
              {
                Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                FileName = "cmd.exe"
              });
              Environment.Exit(0);
              break;
            default:
              int num1 = (int) MessageBox.Show("Invalid option");
              Environment.Exit(0);
              break;
          }
        }
        int num2 = (int) MessageBox.Show("Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer");
        Environment.Exit(0);
      }
      if (!Login.KeyAuthApp.response.success)
      {
        int num = (int) MessageBox.Show(Login.KeyAuthApp.response.message);
        Environment.Exit(0);
      }
      Login.KeyAuthApp.check();
    }

    private static string random_string()
    {
      string str = (string) null;
      Random random = new Random();
      for (int index = 0; index < 5; ++index)
        str += Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0))).ToString();
      return str;
    }

    private void UpgradeBtn_Click(object sender, EventArgs e)
    {
      Login.KeyAuthApp.upgrade(this.username.Text, this.key.Text);
      ((Control) this.status).Text = "Status: " + Login.KeyAuthApp.response.message;
    }

    private void LoginBtn_Click(object sender, EventArgs e)
    {
      Login.KeyAuthApp.login(this.username.Text, this.password.Text);
      if (Login.KeyAuthApp.response.success)
      {
        new Main().Show();
        this.Hide();
      }
      else
        ((Control) this.status).Text = "Status: " + Login.KeyAuthApp.response.message;
    }

    private void RgstrBtn_Click(object sender, EventArgs e)
    {
      Login.KeyAuthApp.register(this.username.Text, this.password.Text, this.key.Text);
      if (Login.KeyAuthApp.response.success)
      {
        new Main().Show();
        this.Hide();
      }
      else
        ((Control) this.status).Text = "Status: " + Login.KeyAuthApp.response.message;
    }

    private void LicBtn_Click(object sender, EventArgs e)
    {
      Login.KeyAuthApp.license(this.key.Text);
      if (Login.KeyAuthApp.response.success)
      {
        new Main().Show();
        this.Hide();
      }
      else
        ((Control) this.status).Text = "Status: " + Login.KeyAuthApp.response.message;
    }

    private void guna2TextBox1_TextChanged(object sender, EventArgs e)
    {
    }

    private void password_TextChanged(object sender, EventArgs e)
    {
    }

    private void siticoneRoundedButton1_Click(object sender, EventArgs e) => Process.Start("https://discord.gg/fivemunbann");

    private void guna2Button1_Click(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.siticoneShadowForm = new SiticoneShadowForm(this.components);
      this.siticoneControlBox1 = new SiticoneControlBox();
      this.siticoneControlBox2 = new SiticoneControlBox();
      this.label1 = new Label();
      this.label2 = new Label();
      this.RgstrBtn = new SiticoneRoundedButton();
      this.status = new SiticoneLabel();
      this.siticoneDragControl1 = new SiticoneDragControl(this.components);
      this.username = new Guna2TextBox();
      this.password = new Guna2TextBox();
      this.key = new Guna2TextBox();
      this.LoginBtn = new SiticoneRoundedButton();
      this.siticoneRoundedButton1 = new SiticoneRoundedButton();
      this.SuspendLayout();
      ((Control) this.siticoneControlBox1).Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.siticoneControlBox1.BorderRadius = 10;
      this.siticoneControlBox1.FillColor = Color.FromArgb(35, 39, 42);
      this.siticoneControlBox1.HoveredState.FillColor = Color.FromArgb(232, 17, 35);
      this.siticoneControlBox1.HoveredState.IconColor = Color.White;
      this.siticoneControlBox1.HoveredState.Parent = (ControlBox) this.siticoneControlBox1;
      this.siticoneControlBox1.IconColor = Color.White;
      ((Control) this.siticoneControlBox1).Location = new Point(283, 4);
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
      ((Control) this.siticoneControlBox2).Location = new Point(237, 4);
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
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Segoe UI Semibold", 10.2f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = SystemColors.ButtonFace;
      this.label2.Location = new Point(14, 11);
      this.label2.Margin = new Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new Size(44, 19);
      this.label2.TabIndex = 27;
      this.label2.Text = nameof (Login);
      ((SiticoneButton) this.RgstrBtn).BorderColor = Color.Red;
      ((SiticoneButton) this.RgstrBtn).BorderThickness = 1;
      ((SiticoneButton) this.RgstrBtn).CheckedState.Parent = (CustomButtonBase) this.RgstrBtn;
      ((SiticoneButton) this.RgstrBtn).CustomImages.Parent = (CustomButtonBase) this.RgstrBtn;
      ((SiticoneButton) this.RgstrBtn).FillColor = Color.Black;
      ((Control) this.RgstrBtn).Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      ((Control) this.RgstrBtn).ForeColor = Color.White;
      ((SiticoneButton) this.RgstrBtn).HoveredState.BorderColor = Color.FromArgb(213, 218, 223);
      ((SiticoneButton) this.RgstrBtn).HoveredState.Parent = (CustomButtonBase) this.RgstrBtn;
      ((Control) this.RgstrBtn).Location = new Point(169, 167);
      ((Control) this.RgstrBtn).Name = "RgstrBtn";
      ((SiticoneButton) this.RgstrBtn).ShadowDecoration.Parent = (Control) this.RgstrBtn;
      ((Control) this.RgstrBtn).Size = new Size(153, 27);
      ((Control) this.RgstrBtn).TabIndex = 35;
      ((Control) this.RgstrBtn).Text = "Register";
      ((Control) this.RgstrBtn).Click += new EventHandler(this.RgstrBtn_Click);
      ((Control) this.status).AutoSize = false;
      ((Control) this.status).BackColor = Color.Transparent;
      ((Control) this.status).Dock = DockStyle.Bottom;
      this.status.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.status.ForeColor = SystemColors.ButtonHighlight;
      ((Control) this.status).Location = new Point(0, 222);
      ((Control) this.status).Margin = new Padding(2);
      ((Control) this.status).Name = "status";
      ((Control) this.status).Size = new Size(332, 42);
      ((Control) this.status).TabIndex = 38;
      ((Control) this.status).Text = "Status: Awaiting login";
      this.status.TextAlignment = ContentAlignment.MiddleCenter;
      this.siticoneDragControl1.TargetControl = (Control) this;
      this.username.AutoRoundedCorners = true;
      this.username.BorderRadius = 14;
      ((Control) this.username).Cursor = Cursors.IBeam;
      this.username.DefaultText = "";
      this.username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
      this.username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
      this.username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
      this.username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
      this.username.FillColor = Color.Black;
      this.username.FocusedState.BorderColor = Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.username.Font = new Font("Segoe UI", 9f);
      this.username.ForeColor = Color.Red;
      this.username.HoverState.BorderColor = Color.FromArgb(94, 148, (int) byte.MaxValue);
      ((Control) this.username).Location = new Point(48, 55);
      ((Control) this.username).Name = "username";
      this.username.PasswordChar = char.MinValue;
      this.username.PlaceholderText = "Username";
      this.username.SelectedText = "";
      ((Control) this.username).Size = new Size(236, 30);
      ((Control) this.username).TabIndex = 39;
      this.username.TextAlign = HorizontalAlignment.Center;
      this.username.TextChanged += new EventHandler(this.guna2TextBox1_TextChanged);
      this.password.AutoRoundedCorners = true;
      this.password.BorderRadius = 14;
      ((Control) this.password).Cursor = Cursors.IBeam;
      this.password.DefaultText = "";
      this.password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
      this.password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
      this.password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
      this.password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
      this.password.FillColor = Color.Black;
      this.password.FocusedState.BorderColor = Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.password.Font = new Font("Segoe UI", 9f);
      this.password.ForeColor = Color.Red;
      this.password.HoverState.BorderColor = Color.FromArgb(94, 148, (int) byte.MaxValue);
      ((Control) this.password).Location = new Point(48, 93);
      ((Control) this.password).Name = "password";
      this.password.PasswordChar = char.MinValue;
      this.password.PlaceholderText = "Password";
      this.password.SelectedText = "";
      ((Control) this.password).Size = new Size(236, 30);
      ((Control) this.password).TabIndex = 40;
      this.password.TextAlign = HorizontalAlignment.Center;
      this.password.TextChanged += new EventHandler(this.password_TextChanged);
      this.key.AutoRoundedCorners = true;
      this.key.BorderRadius = 14;
      ((Control) this.key).Cursor = Cursors.IBeam;
      this.key.DefaultText = "";
      this.key.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
      this.key.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
      this.key.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
      this.key.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
      this.key.FillColor = Color.Black;
      this.key.FocusedState.BorderColor = Color.FromArgb(94, 148, (int) byte.MaxValue);
      this.key.Font = new Font("Segoe UI", 9f);
      this.key.ForeColor = Color.Red;
      this.key.HoverState.BorderColor = Color.FromArgb(94, 148, (int) byte.MaxValue);
      ((Control) this.key).Location = new Point(46, 131);
      ((Control) this.key).Name = "key";
      this.key.PasswordChar = char.MinValue;
      this.key.PlaceholderText = "Key";
      this.key.SelectedText = "";
      ((Control) this.key).Size = new Size(236, 30);
      ((Control) this.key).TabIndex = 41;
      this.key.TextAlign = HorizontalAlignment.Center;
      ((SiticoneButton) this.LoginBtn).BorderColor = Color.Red;
      ((SiticoneButton) this.LoginBtn).BorderThickness = 1;
      ((SiticoneButton) this.LoginBtn).CheckedState.Parent = (CustomButtonBase) this.LoginBtn;
      ((SiticoneButton) this.LoginBtn).CustomImages.Parent = (CustomButtonBase) this.LoginBtn;
      ((SiticoneButton) this.LoginBtn).FillColor = Color.Black;
      ((Control) this.LoginBtn).Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      ((Control) this.LoginBtn).ForeColor = Color.White;
      ((SiticoneButton) this.LoginBtn).HoveredState.BorderColor = Color.FromArgb(213, 218, 223);
      ((SiticoneButton) this.LoginBtn).HoveredState.Parent = (CustomButtonBase) this.LoginBtn;
      ((Control) this.LoginBtn).Location = new Point(12, 167);
      ((Control) this.LoginBtn).Name = "LoginBtn";
      ((SiticoneButton) this.LoginBtn).ShadowDecoration.Parent = (Control) this.LoginBtn;
      ((Control) this.LoginBtn).Size = new Size(151, 27);
      ((Control) this.LoginBtn).TabIndex = 26;
      ((Control) this.LoginBtn).Text = nameof (Login);
      ((Control) this.LoginBtn).Click += new EventHandler(this.LoginBtn_Click);
      ((SiticoneButton) this.siticoneRoundedButton1).BorderColor = Color.White;
      ((SiticoneButton) this.siticoneRoundedButton1).BorderThickness = 1;
      ((SiticoneButton) this.siticoneRoundedButton1).CheckedState.Parent = (CustomButtonBase) this.siticoneRoundedButton1;
      ((SiticoneButton) this.siticoneRoundedButton1).CustomImages.Parent = (CustomButtonBase) this.siticoneRoundedButton1;
      ((SiticoneButton) this.siticoneRoundedButton1).FillColor = Color.DimGray;
      ((Control) this.siticoneRoundedButton1).Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      ((Control) this.siticoneRoundedButton1).ForeColor = Color.Black;
      ((SiticoneButton) this.siticoneRoundedButton1).HoveredState.BorderColor = Color.FromArgb(213, 218, 223);
      ((SiticoneButton) this.siticoneRoundedButton1).HoveredState.Parent = (CustomButtonBase) this.siticoneRoundedButton1;
      ((Control) this.siticoneRoundedButton1).Location = new Point(82, 200);
      ((Control) this.siticoneRoundedButton1).Name = "siticoneRoundedButton1";
      ((SiticoneButton) this.siticoneRoundedButton1).PressedColor = Color.White;
      ((SiticoneButton) this.siticoneRoundedButton1).ShadowDecoration.Parent = (Control) this.siticoneRoundedButton1;
      ((Control) this.siticoneRoundedButton1).Size = new Size(153, 27);
      ((Control) this.siticoneRoundedButton1).TabIndex = 42;
      ((Control) this.siticoneRoundedButton1).Text = "Get Key";
      ((Control) this.siticoneRoundedButton1).Click += new EventHandler(this.siticoneRoundedButton1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.AutoValidate = AutoValidate.Disable;
      this.BackColor = Color.Black;
      this.ClientSize = new Size(332, 264);
      this.Controls.Add((Control) this.siticoneRoundedButton1);
      this.Controls.Add((Control) this.key);
      this.Controls.Add((Control) this.password);
      this.Controls.Add((Control) this.username);
      this.Controls.Add((Control) this.status);
      this.Controls.Add((Control) this.RgstrBtn);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.LoginBtn);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.siticoneControlBox2);
      this.Controls.Add((Control) this.siticoneControlBox1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (Login);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Loader";
      this.TransparencyKey = Color.Maroon;
      this.Load += new EventHandler(this.Login_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
