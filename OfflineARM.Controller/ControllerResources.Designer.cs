﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OfflineARM.Controller {
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
    internal class ControllerResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ControllerResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OfflineARM.Controller.ControllerResources", typeof(ControllerResources).Assembly);
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
        ///   Looks up a localized string similar to Значение для элемента с ключом &quot;{0}&quot; в холдере {1} не может быть заменено.
        /// </summary>
        internal static string HolderCannotReplaceValueFormat {
            get {
                return ResourceManager.GetString("HolderCannotReplaceValueFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Остаток {0} р..
        /// </summary>
        internal static string OrderEditController_AmountBalance {
            get {
                return ResourceManager.GetString("OrderEditController_AmountBalance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Итого заказа {0} р..
        /// </summary>
        internal static string OrderEditController_AmountOrder {
            get {
                return ResourceManager.GetString("OrderEditController_AmountOrder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Оплачено {0} р..
        /// </summary>
        internal static string OrderEditController_AmountPayments {
            get {
                return ResourceManager.GetString("OrderEditController_AmountPayments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Заказа не сохранен! Произошла ошибка: &quot;{0}&quot;!.
        /// </summary>
        internal static string OrderEditController_ErrorSave {
            get {
                return ResourceManager.GetString("OrderEditController_ErrorSave", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Файла не сущесмтвует: &quot;{0}&quot;!.
        /// </summary>
        internal static string OrderEditController_FileDownloadedNotExists {
            get {
                return ResourceManager.GetString("OrderEditController_FileDownloadedNotExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Карта.
        /// </summary>
        internal static string OrderPayControl_CardPaymentType {
            get {
                return ResourceManager.GetString("OrderPayControl_CardPaymentType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Наличными.
        /// </summary>
        internal static string OrderPayControl_CashPaymentType {
            get {
                return ResourceManager.GetString("OrderPayControl_CashPaymentType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Кредит.
        /// </summary>
        internal static string OrderPayControl_CreditPaymentType {
            get {
                return ResourceManager.GetString("OrderPayControl_CreditPaymentType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Не найден конфигурационный файл OfflineARM.config!.
        /// </summary>
        internal static string SettingApplicationController_ConfigFileNotFounded {
            get {
                return ResourceManager.GetString("SettingApplicationController_ConfigFileNotFounded", resourceCulture);
            }
        }
    }
}
