using System;
using System.Diagnostics;
using TshirtSpace.TshirtSpace;
/// <summary>
/// Summary description for Class1
/// </summary>
namespace TshirtSpace
{
	public class Tshirt_Test
	{

		public int Test_TshirtSize_SuccessCase()
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
