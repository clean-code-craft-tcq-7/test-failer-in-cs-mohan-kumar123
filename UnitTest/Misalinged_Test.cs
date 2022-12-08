using System;
using TshirtSpace.TshirtSpace;
/// <summary>
/// Summary description for Class1
/// </summary>
public class Misalinged_Test
{

	public int Test_ColorMap_SuccessCases()
	{
        //Arrange & Act & Assert
        int result = printColorMap();
        Debug.Assert(result == 25);
        Debug.Assert(formatColorPairFromColorIndex(1, 1) == "7  | Red | Orange");
        Debug.Assert(formatColorPairFromColorIndex(0, 0) == "1  | White | Blue");
        Debug.Assert(formatColorPairFromColorIndex(0, 4) == "5  | White | Slate");
        Debug.Assert(formatColorPairFromColorIndex(2, 3) == "14 | Black | Brown");
        Console.WriteLine("All is well (maybe!)");

    }

}
