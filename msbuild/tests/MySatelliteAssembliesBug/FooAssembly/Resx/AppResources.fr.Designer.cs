﻿// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace FooAssembly.Resx {
    using System;
    using System.Reflection;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AppResources_fr {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppResources_fr() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("FooAssembly.Resx.AppResources.fr", typeof(AppResources_fr).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string NotesLabel {
            get {
                return ResourceManager.GetString("NotesLabel", resourceCulture);
            }
        }
        
        internal static string NotesPlaceholder {
            get {
                return ResourceManager.GetString("NotesPlaceholder", resourceCulture);
            }
        }
        
        internal static string AddButton {
            get {
                return ResourceManager.GetString("AddButton", resourceCulture);
            }
        }
    }
}
