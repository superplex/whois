using System;
using System.IO;
using System.Reflection;

namespace Whois
{
    public class Utils
    {
        public static string GetFullPath(string path)
        {
            var codeBaseUrl = new Uri(Assembly.GetExecutingAssembly().CodeBase);
            var codeBasePath = Uri.UnescapeDataString(codeBaseUrl.AbsolutePath);
            var dirPath = Path.GetDirectoryName(codeBasePath);

            return Path.Combine(dirPath, path);
        }
    }
}