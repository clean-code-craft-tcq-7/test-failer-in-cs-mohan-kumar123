using System;
using System.Collections.Generic;
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
            string colorpair = "";
            int baseIpt = i * 5 + j + 1;
            try
            {
                colorpair = Misaligned.patternGenerationLogic(baseIpt, Misaligned.majorColors[i], Misaligned.minorColors[j]);
            }
            catch (Exception e)
            {

                colorpair = "Color which your looking for not available please try other color.";
            }
            return colorpair;
        }

        private static string patternGenerationLogic(int baseInput, string majorColor, string minorColor)
        {
            string resultValue = "Colour Not Availibile";
            string mjrLgth = majorColor.ToString().Length.ToString();
            string constructvalue = baseInput < 10 ? "1"+ mjrLgth : "2"+ mjrLgth;

            IDictionary<string, string> myDict = Misaligned.SetDictionaryValues(baseInput, majorColor, minorColor);

            if (myDict.ContainsKey(constructvalue))
            {
                resultValue = myDict[constructvalue];
            }
            
            return resultValue;
        }

        private static IDictionary<string, string> SetDictionaryValues(int baseInput, string majorColor, string minorColor)
        {
            // 5 white  2  = 7
            // 3 red    4  = 7
            // 5 black  2  = 7
            // 6 yellow 1  = 7
            IDictionary<string, string> myDict = new Dictionary<string, string>();
            myDict.Add("15", String.Format("{0}  | {1}  | {2}", baseInput, majorColor, minorColor));
            myDict.Add("13", String.Format("{0}  | {1}    | {2}", baseInput, majorColor, minorColor));
            myDict.Add("25", String.Format("{0} | {1}  | {2}", baseInput, majorColor, minorColor));
            myDict.Add("23", String.Format("{0} | {1}    | {2}", baseInput, majorColor, minorColor));
            myDict.Add("26", String.Format("{0} | {1} | {2}", baseInput, majorColor, minorColor));

            return myDict;
        }

        static void Main(string[] args)
        {
           Misalinged_UnitTest.Test_printColorMap_SuccessCase();
        }
    }
}