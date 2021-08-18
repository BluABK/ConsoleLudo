using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLudo
{
    class GameBoard
    {
        const int YardAmount = 4;
        readonly Yard[] yards;
        readonly int[] yardLeftOffsets;
        readonly int[] yardTopOffsets;
        readonly ConsoleColor[] yardForegroundColors;
        readonly ConsoleColor[] yardBackgroundColors;

        public GameBoard(bool autoDraw = true)
        {
            yardLeftOffsets = new int[YardAmount] { 1, 10, 1, 10 };
            yardTopOffsets = new int[YardAmount] { 1, 1, 10, 10 };
            yardForegroundColors = new ConsoleColor[YardAmount] { ConsoleColor.DarkGreen, ConsoleColor.DarkYellow, ConsoleColor.DarkRed, ConsoleColor.DarkBlue };
            yardBackgroundColors = new ConsoleColor[YardAmount] { ConsoleColor.White, ConsoleColor.White, ConsoleColor.White, ConsoleColor.White };

            // Initialize Yard array.
            yards = InitializeArray<Yard>(4);

            // Setup each Yard:
            for (int i = 0; i < yards.Length; i++)
            {
                yards[i].Setup(yardLeftOffsets[i], yardTopOffsets[i], yardForegroundColors[i], yardBackgroundColors[i]);
            }
            
            // Draw if not otherwise told not to.
            if (autoDraw) Draw();
        }

        public Yard[] GetYards()
        {
            return yards;
        }

        public void Draw()
        {
            foreach (Yard yard in yards)
            {
                yard.Draw();
            }

            // Reset colours.
            Console.ResetColor();
        }

        private T[] InitializeArray<T>(int length) where T : new()
        {
            T[] array = new T[length];

            for (int i = 0; i < length; ++i)
            {
                array[i] = new T();
            }

            return array;
        }
    }
}
