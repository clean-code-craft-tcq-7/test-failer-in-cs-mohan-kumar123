using System;
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
            Tshirt_Test Tshirt_Test = new Tshirt_Test();
            Tshirt_Test.Test_TshirtSize_SuccessCase();
            Debug.Assert(Size(38) == "S");
            Debug.Assert(Size(42) == "M");
            Debug.Assert(Size(41) == "L");
            Console.WriteLine( "All is well (maybe!)");
        }
    }
}