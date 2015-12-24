// Decompiled with JetBrains decompiler
// Type: Employee_Parser.Program
// Assembly: Employee Parser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 65AB8F43-3C27-4711-8C5C-FDB89C897095
// Assembly location: C:\Employee Parser\Employee Parser.exe

using System;
using System.Windows.Forms;

namespace Employee_Parser
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new EmployeeParser());
    }
  }
}
