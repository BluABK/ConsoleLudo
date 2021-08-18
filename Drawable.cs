using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLudo
{
    class Drawable
    {
        internal void Draw()
        {
            throw new NotImplementedException();
        }

        internal void DrawLine(int left, int top, string text)
        {
            Console.CursorLeft = left;
            Console.CursorTop = top;
            Console.WriteLine(text);
        }
    }
}
