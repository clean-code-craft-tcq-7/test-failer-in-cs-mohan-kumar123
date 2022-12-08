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
                    Console.WriteLine(formatColorPair(i, i));
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
           Misaligned_Test.Test_printColorMap_SuccessCase();
        }
    }
    public class Misaligned_Test
	{
		public static void Test_printColorMap_SuccessCase()
		{
			//Arrange & Act & Assert
			//string result = Misaligned.formatColorPair(1,2);
        int result = Misaligned.printColorMap();
        Debug.Assert(result == 25);
        Debug.Assert(Misaligned.formatColorPair(1, 1) == "7  | Red | Orange");
        Debug.Assert(Misaligned.formatColorPair(0, 0) == "1  | White | Blue");
        Debug.Assert(Misaligned.formatColorPair(0, 4) == "5  | White | Slate");
        Debug.Assert(Misaligned.formatColorPair(2, 3) == "14 | Black | Brown");
        Console.WriteLine("All is well (maybe!)");
		}
	}
}