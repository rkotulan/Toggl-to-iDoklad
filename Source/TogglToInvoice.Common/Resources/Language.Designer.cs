﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TogglToInvoice.Common.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Language {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Language() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TogglToInvoice.Common.Resources.Language", typeof(Language).Assembly);
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
        ///   Looks up a localized string similar to Kč.
        /// </summary>
        internal static string CurrencyEnum_CZK {
            get {
                return ResourceManager.GetString("CurrencyEnum_CZK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EUR.
        /// </summary>
        internal static string CurrencyEnum_EUR {
            get {
                return ResourceManager.GetString("CurrencyEnum_EUR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to klientů.
        /// </summary>
        internal static string GroupTimeEntryBy_Clients {
            get {
                return ResourceManager.GetString("GroupTimeEntryBy_Clients", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to projektů.
        /// </summary>
        internal static string GroupTimeEntryBy_Projects {
            get {
                return ResourceManager.GetString("GroupTimeEntryBy_Projects", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to jen základ.
        /// </summary>
        internal static string PriceType_OnlyBase {
            get {
                return ResourceManager.GetString("PriceType_OnlyBase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to bez daně.
        /// </summary>
        internal static string PriceType_WithoutVat {
            get {
                return ResourceManager.GetString("PriceType_WithoutVat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to s daní.
        /// </summary>
        internal static string PriceType_WithVat {
            get {
                return ResourceManager.GetString("PriceType_WithVat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to základní.
        /// </summary>
        internal static string VatRateType_Basic {
            get {
                return ResourceManager.GetString("VatRateType_Basic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to snížená.
        /// </summary>
        internal static string VatRateType_Reduced1 {
            get {
                return ResourceManager.GetString("VatRateType_Reduced1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to snížená 2.
        /// </summary>
        internal static string VatRateType_Reduced2 {
            get {
                return ResourceManager.GetString("VatRateType_Reduced2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to nulová.
        /// </summary>
        internal static string VatRateType_Zero {
            get {
                return ResourceManager.GetString("VatRateType_Zero", resourceCulture);
            }
        }
    }
}
