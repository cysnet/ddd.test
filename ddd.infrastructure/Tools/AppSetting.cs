using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.infrastructure.Tools
{
    public class AppSetting
    {
        private static IConfigurationSection appsections = null;
        public static void SetAppSettings(IConfigurationSection section)
        {
            appsections = section;
        }

        public static string GetAppSetting(string key)
        {
            string str = string.Empty;
            if (appsections.GetSection(key) != null)
            {
                str = appsections.GetSection(key).Value;
            }
            return str;
        }
    }
}
