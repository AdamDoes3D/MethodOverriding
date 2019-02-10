using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach(var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
