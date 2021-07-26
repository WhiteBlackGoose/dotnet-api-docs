//<snippet400>
using System;
using System.Configuration;
using System.Web.ClientServices.Providers;

namespace ClientAppServicesDemo.Properties {

    internal sealed class Settings : ApplicationSettingsBase 
    {
        
        private static Settings defaultInstance = 
            (Settings)(ApplicationSettingsBase.Synchronized(new Settings()));
        
        public static Settings Default 
        {
            get 
            {
                return defaultInstance;
            }
        }
        
        [UserScopedSettingAttribute()]
        [SettingsProviderAttribute(typeof(ClientSettingsProvider))]
        [DefaultSettingValueAttribute("DefaultText")]
        public string WebSettingsTestText 
        {
            get 
            {
                return (string)(this["WebSettingsTestText"]);
            }

            set 
            {
                this["WebSettingsTestText"] = value;
            }
        }

        [UserScopedSettingAttribute()]
        [SettingsProviderAttribute(typeof(ClientSettingsProvider))]
        [DefaultSettingValueAttribute("MySetting")]
        public string MySetting
        {
            get
            {
                return (string)(this["MySetting"]);
            }

            set
            {
                this["MySetting"] = value;
            }
        }
    }
}
//</snippet400>