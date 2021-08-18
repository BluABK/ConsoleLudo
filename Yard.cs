using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLudo
{
    class Yard : Drawable
    {
        const char WallBlock = '#';

        int left = 0;
        int top = 0;
        ConsoleColor backgroundColor;
        ConsoleColor foregroundColor;

        public Yard() { }

        public void Setup(int leftOffset, int topOffset, ConsoleColor fgColor, ConsoleColor bgColor)
        {
            foregroundColor = fgColor;
            backgroundColor = bgColor;
            left = leftOffset;
            top = topOffset;
        }

        internal static string GetWallBlocks(int amount)
        {
            string blocks = "";

            for (int i = 0; i < amount; i++)
            {
                blocks += WallBlock;
            }

            return blocks;
        }

        internal new void Draw()
        {
            Console.ForegroundColor = foregroundColor;
            DrawLine(left, top, GetWallBlocks(6));
            DrawLine(left, top + 1, GetWallBlocks(1));
            DrawLine(left + 5, top + 1, GetWallBlocks(1));
            DrawLine(left, top + 2, GetWallBlocks(1));
            DrawLine(left + 5, top + 2, GetWallBlocks(1));
            DrawLine(left, top + 3, GetWallBlocks(1));
            DrawLine(left + 5, top + 3, GetWallBlocks(1));
            DrawLine(left, top + 4, GetWallBlocks(6));

        }
    }
}
