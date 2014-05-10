﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FreenetTray {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FreenetTray.strings", typeof(strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to open required file &apos;{0}&apos;. Please ensure this tray application is located in the Freenet installation folder..
        /// </summary>
        internal static string FileNotFoundBody {
            get {
                return ResourceManager.GetString("FileNotFoundBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File Missing.
        /// </summary>
        internal static string FileNotFoundTitle {
            get {
                return ResourceManager.GetString("FileNotFoundTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The path is too long. Please install Freenet to a folder with a shorter path..
        /// </summary>
        internal static string PathLengthExceededBody {
            get {
                return ResourceManager.GetString("PathLengthExceededBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path Too Long.
        /// </summary>
        internal static string PathLengthExceededTitle {
            get {
                return ResourceManager.GetString("PathLengthExceededTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown error when launching the wrapper: &apos;{0}&apos; ({1:x}) Please report this to the Freenet developers..
        /// </summary>
        internal static string UnknownWrapperLaunchErrorBody {
            get {
                return ResourceManager.GetString("UnknownWrapperLaunchErrorBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown Error.
        /// </summary>
        internal static string UnknownWrapperLaunchErrorTitle {
            get {
                return ResourceManager.GetString("UnknownWrapperLaunchErrorTitle", resourceCulture);
            }
        }
    }
}
