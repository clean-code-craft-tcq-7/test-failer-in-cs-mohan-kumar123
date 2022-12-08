﻿using System;
using System.Diagnostics;

namespace TshirtSpace {
    class Tshirt {
        static string Size(int cms) {
            if(cms < 38) {
                return "S";
            } else if(cms > 38 && cms < 42) {
                return "M";
            } else {
                return "L";
            }
        }
        static void Main(string[] args) {
            Tshirt_Test tshirt_Test = new Tshirt_Test();
            tshirt_Test.Test_TshirtSize_SuccessCase();
           // Debug.Assert(Size(38) == "S");
            //Debug.Assert(Size(42) == "M");
            //Debug.Assert(Size(41) == "L");
            //Console.WriteLine( "All is well (maybe!)");
        }
    }

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