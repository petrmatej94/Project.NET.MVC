﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project.NET.MVC.Resources {
    using System;
    
    
    /// <summary>
    ///   Třída prostředků se silnými typy pro vyhledávání lokalizovaných řetězců atp.
    /// </summary>
    // Tato třída byla automaticky generována třídou StronglyTypedResourceBuilder
    // pomocí nástroje podobného aplikaci ResGen nebo Visual Studio.
    // Chcete-li přidat nebo odebrat člena, upravte souboru .ResX a pak znovu spusťte aplikaci ResGen
    // s parametrem /str nebo znovu sestavte projekt aplikace Visual Studio.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Translation {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Translation() {
        }
        
        /// <summary>
        ///   Vrací instanci ResourceManager uloženou v mezipaměti použitou touto třídou.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Project.NET.MVC.Resources.Translation", typeof(Translation).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Potlačí vlastnost CurrentUICulture aktuálního vlákna pro všechna
        ///   vyhledání prostředků pomocí třídy prostředků se silnými typy.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Vyhledá lokalizovaný řetězec podobný Min. 3 chars, Max. 30 chars.
        /// </summary>
        public static string LengthError {
            get {
                return ResourceManager.GetString("LengthError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Vyhledá lokalizovaný řetězec podobný Login Name.
        /// </summary>
        public static string Login {
            get {
                return ResourceManager.GetString("Login", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Vyhledá lokalizovaný řetězec podobný Login must be filled in.
        /// </summary>
        public static string LoginErrorMessage {
            get {
                return ResourceManager.GetString("LoginErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Vyhledá lokalizovaný řetězec podobný Please Sign In.
        /// </summary>
        public static string LoginMessage {
            get {
                return ResourceManager.GetString("LoginMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Vyhledá lokalizovaný řetězec podobný Enter your Login.
        /// </summary>
        public static string LoginPlaceholder {
            get {
                return ResourceManager.GetString("LoginPlaceholder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Vyhledá lokalizovaný řetězec podobný Password.
        /// </summary>
        public static string Password {
            get {
                return ResourceManager.GetString("Password", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Vyhledá lokalizovaný řetězec podobný Password must be filled in.
        /// </summary>
        public static string PasswordErrorMessage {
            get {
                return ResourceManager.GetString("PasswordErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Vyhledá lokalizovaný řetězec podobný Enter your Password.
        /// </summary>
        public static string PasswordPlaceholder {
            get {
                return ResourceManager.GetString("PasswordPlaceholder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Vyhledá lokalizovaný řetězec podobný Log In.
        /// </summary>
        public static string SignIn {
            get {
                return ResourceManager.GetString("SignIn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Vyhledá lokalizovaný řetězec podobný Wrong Login Details.
        /// </summary>
        public static string WrongDetails {
            get {
                return ResourceManager.GetString("WrongDetails", resourceCulture);
            }
        }
    }
}