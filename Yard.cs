using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLudo
{
    class Yard : Drawable
    {
        static Encoding e = Encoding.GetEncoding("iso-8859-1");

        //const char WallBlock = (char)220;
        //const char WallBlock = (char)0xB0;
        //const char WallBlock = (char)0x25BA;
        //const char WallBlock = '□';
        //const char WallBlock = (char)0x25A1;
        //string WallBlock = e.GetString(new byte[] { 189 });
        //string WallBlock = e.GetString(new byte[] { 19 });
        const char WallBlock = '#';

        int left = 0;
        int top = 0;
        ConsoleColor backgroundColor;
        ConsoleColor foregroundColor;
        //ConsoleColor color;

        public Yard() { }

        public void PrintASCIITable()
        {
            int count = 0;
            int colCount = 8;
            for (int i = 0; i < 256; i++)
            {
                Console.Write($"{i}: { e.GetString(new byte[] { (byte)i }) }\t");

                if (count == colCount)
                {
                    Console.WriteLine();
                    count = 0;
                }

                count++;
            }
        }

        public void Setup(int leftOffset, int topOffset, ConsoleColor fgColor, ConsoleColor bgColor)
        {
            foregroundColor = fgColor;
            backgroundColor = bgColor;
            left = leftOffset;
            top = topOffset;

            //WallBlock = e.GetString(new byte[] { 189 });
        }

        internal string GetWallBlocks(int amount)
        {
            string blocks = "";

            for (int i = 0; i < amount; i++)
            {
                blocks += WallBlock;
            }

            return blocks;
        }

        internal void Draw()
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
