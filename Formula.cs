using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Korelskiy.NextBlazor
{
    public static class Formula
    {
        public static float Extension(float coef, int voices)
        {
            return (float)Math.Round(coef * voices / 100, 0);
        }
    }
}
