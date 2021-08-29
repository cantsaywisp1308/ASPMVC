using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession9_WebApplication1.Services
{
    public class DemoServiceImp : DemoService
    {
        string DemoService.Hello()
        {
            return "Hello World";
        }

        string DemoService.Hi(string name)
        {
            return "Hi" + name;
        }
    }
}
