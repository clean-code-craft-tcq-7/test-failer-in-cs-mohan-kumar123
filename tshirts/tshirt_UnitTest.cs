using System;
using System.Diagnostics;

namespace TshirtSpace {
   
    public partial class tshirt_UnitTest
	{
		public static void Test_TshirtSize_SuccessCase()
		{
			//Arrange & Act & Assert
			Debug.Assert(Tshirt.Size(37) == "S");
			Debug.Assert(Tshirt.Size(40) == "M");
			Debug.Assert(Tshirt.Size(43) == "L");
			Debug.Assert(Tshirt.Size(38) == "S");
			Debug.Assert(Tshirt.Size(42) == "L");
			Console.WriteLine("All is well (maybe!)");
		}
	}
}