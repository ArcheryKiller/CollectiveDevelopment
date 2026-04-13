using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectiveDevelopment
{
    public static class DrawingUtils
    {
        public static void DrawAll(List<IDrawable> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
