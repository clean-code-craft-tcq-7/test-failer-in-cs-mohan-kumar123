using System;
using System.Diagnostics;

namespace MisalignedSpace {
    public partial class Misaligned {
        public static string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
        public static string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };

        public static int printColorMap()
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
                colorpair = String.Format("{0}  | {1} | {2}", i * 5 + j + 1, Misaligned.majorColors[i], Misaligned.minorColors[j]);
            }
            else
            {
                colorpair = String.Format("{0} | {1} | {2}", i * 5 + j + 1, Misaligned.majorColors[i], Misaligned.minorColors[j]);
            }
            return colorpair;
        }
        static void Main(string[] args)
        {
           Misalinged_UnitTest.Test_printColorMap_SuccessCase();
        }
    }
}