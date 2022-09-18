// Decompiled with JetBrains decompiler
// Type: KeyAuth.Program
// Assembly: Loader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5D07A1EC-42C3-426D-8F3E-4E083BF3DB7C
// Assembly location: C:\Users\xande\Desktop\32 bit spy\Loader.exe

using System;
using System.Windows.Forms;

namespace KeyAuth
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Login());
    }
  }
}
