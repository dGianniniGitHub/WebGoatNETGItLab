using System;
using OWASP.WebGoat.NET.App_Code.DB;
using System.IO;

namespace OWASP.WebGoat.NET.App_Code
{
    public class Settings
    {
        public static readonly string DefaultConfigName = string.Format("Default.{0}", DbConstants.CONFIG_EXT);
        
        public static void Init()
        {
            string configPath = Path.Combine(ParentConfigPath, DefaultConfigName);
            configPath = Path.Combine(Environment.CurrentDirectory, configPath);
            
            CurrentDbProvider = DbProviderFactory.Create(configPath);
        }
        
        public static IDbProvider CurrentDbProvider { get; set; }

        public static string ParentConfigPath { get { return "Configuration"; } }

    }
}