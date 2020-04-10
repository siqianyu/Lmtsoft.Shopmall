using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lmtsoft.Shopmall.Repository
{
    static class ConfigHelper
    {
        private static IConfiguration _configuration;
        static ConfigHelper()
        {
            var fileName = "appsettings.json";

            var directory = AppContext.BaseDirectory;
            directory = directory.Replace("\\", "/");

            var filePath = $"{directory}/{fileName}";
            if (!File.Exists(filePath))
            {
                var length = directory.IndexOf("/bin");
                filePath = $"{directory.Substring(0, length)}/{fileName}";
            }

            var builder = new ConfigurationBuilder()
                .AddJsonFile(filePath, false, true);

            _configuration = builder.Build();
        }

        public static string GetSectionValue(string key)
        {
            return _configuration.GetSection(key).Value;
        }
        public static string GetConnectionValue()
        {
            return _configuration.GetSection("ConnectionString")["Default"];
        }

        public static string GetConnectionValue(string key)
        {
            return _configuration.GetSection("ConnectionString")[key];
        }
    }

}
