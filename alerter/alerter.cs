using System;
using System.Diagnostics;

namespace AlerterSpace {
    public partial class Alerter {
       public static int alertFailureCount = 0;

        public virtual int networkAlert(float celcius)
        {
            Console.WriteLine("ALERT: Temperature is {0} celcius", celcius);
            // Return 200 for ok
            // Return 500 for not-ok
            // stub always succeeds and returns 200
            if(celcius < 200) return 200;
            else return 500;
        }

       public static void alertInCelcius(float farenheit) 
        {
            Alerter alerter =  new Alerter();
            float celcius = (farenheit - 32) * 5 / 9;
            int returnCode = alerter.networkAlert(celcius);
            if (returnCode != 200) {
                // non-ok response is not an error! Issues happen in life!
                // let us keep a count of failures to report
                // However, this code doesn't count failures!
                // Add a test below to catch this bug. Alter the stub above, if needed.
                Alerter.alertFailureCount ++;
            }
        }
        static void Main(string[] args) {
            aleter_UnitTest.Test_AlerterCelcius_FailureCase();
        }
    }
}