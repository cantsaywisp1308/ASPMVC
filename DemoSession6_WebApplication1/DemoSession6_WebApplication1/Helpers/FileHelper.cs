using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession6_WebApplication1.Helper
{
    public class FileHelper
    {
        public static string GenerateFileName(string contentType)
        {
            var guid = Guid.NewGuid().ToString().Replace("-","");
            var ext = contentType.Split(new char[] { '/' })[1];
            return guid + "." + ext;
        }
    }
}
