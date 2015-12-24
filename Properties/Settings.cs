// Decompiled with JetBrains decompiler
// Type: Employee_Parser.Properties.Settings
// Assembly: Employee Parser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 65AB8F43-3C27-4711-8C5C-FDB89C897095
// Assembly location: C:\Employee Parser\Employee Parser.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Employee_Parser.Properties
{
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
  [CompilerGenerated]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        return Settings.defaultInstance;
      }
    }
  }
}
