using System;
using System.Diagnostics;

namespace MisalignedSpace {
    class Misaligned {
        string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
        string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };

       static int printColorMap()
        {
            int i = 0, j = 0;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.WriteLine(formatColorPair(i, j));
                }
            }
            return i * j;
        }
        public static string formatColorPair(int i, int j)
        {
            string colorpair;
            if (i * 5 + j + 1 < 10)
            {
                colorpair = String.Format("{0}  | {1} | {2}", i * 5 + j + 1, majorColors[i], minorColors[j]);
            }
            else
            {
                colorpair = String.Format("{0} | {1} | {2}", i * 5 + j + 1, majorColors[i], minorColors[j]);
            }
            return colorpair;
        }
        static void Main(string[] args)
        {
            test_ColorPair();
        }
    }
}
