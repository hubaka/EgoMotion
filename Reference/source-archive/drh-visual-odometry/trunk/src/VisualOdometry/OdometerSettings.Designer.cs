﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VisualOdometry {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class OdometerSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static OdometerSettings defaultInstance = ((OdometerSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new OdometerSettings())));
        
        public static OdometerSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int GroundRegionTop {
            get {
                return ((int)(this["GroundRegionTop"]));
            }
            set {
                this["GroundRegionTop"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("150")]
        public int SkyRegionBottom {
            get {
                return ((int)(this["SkyRegionBottom"]));
            }
            set {
                this["SkyRegionBottom"] = value;
            }
        }
    }
}
