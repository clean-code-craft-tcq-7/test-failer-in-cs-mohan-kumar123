using System;
using System.Diagnostics;

namespace MisalignedSpace
{
    public partial class Misalinged_UnitTest
    {
        public static void Test_printColorMap_SuccessCase()
        {
            //Arrange & Act & Assert
            int result = Misaligned.printColorMap();
            Debug.Assert(result == 25);
            Debug.Assert(Misaligned.formatColorPair(1, 1) == "7  | Red    | Orange");
            Debug.Assert(Misaligned.formatColorPair(0, 0) == "1  | White  | Blue");
            Debug.Assert(Misaligned.formatColorPair(0, 4) == "5  | White  | Slate");
            Debug.Assert(Misaligned.formatColorPair(2, 3) == "14 | Black  | Brown");
            Debug.Assert(Misaligned.formatColorPair(5, 6) == "Color which your looking for not available please try other color.");
            Console.WriteLine("All is well (maybe!)");
        }
    }
}