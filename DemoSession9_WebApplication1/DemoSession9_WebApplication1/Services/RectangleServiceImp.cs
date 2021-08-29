using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession9_WebApplication1.Services
{
    public class RectangleServiceImp : RectangleService
    {
        private CalculateService calculateService;

        public RectangleServiceImp(CalculateService _calculateService)
        {
            calculateService = _calculateService;
        }
        int RectangleService.Area(int a, int b)
        {
            return calculateService.Mul(a, b);
        }

        int RectangleService.Perimeter(int a, int b)
        {
            return calculateService.Mul(calculateService.Add(a, b), 2);
        }
    }
}
