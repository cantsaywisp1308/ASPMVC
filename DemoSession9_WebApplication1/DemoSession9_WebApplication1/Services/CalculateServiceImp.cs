using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession9_WebApplication1.Services
{
    public class CalculateServiceImp : CalculateService
    {
        int CalculateService.Add(int a, int b)
        {
            return a + b;
        }

        int CalculateService.Mul(int a, int b)
        {
            return a * b;
        }
    }
}
