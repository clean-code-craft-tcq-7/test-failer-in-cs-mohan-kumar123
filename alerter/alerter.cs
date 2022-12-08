using System;
using System.Diagnostics;

namespace AlerterSpace {
    public partial class Alerter {
        public static int alertFailureCount = 0;
        static string env;
        public virtual int networkAlert(float celcius)
        {
            Console.WriteLine("ALERT: Temperature is {0} celcius", celcius);
            if(celcius < 200) return 200;
            else return 500;
        }

        //For Prod Environment
        public static void alertInCelcius(float farenheit) 
        {
            Alerter alerter =  new Alerter();
            float celcius = (farenheit - 32) * 5 / 9;
            int returnCode = alerter.networkAlert(celcius);
            if (returnCode != 200) {
              
                Alerter.alertFailureCount ++;
            }
        }

        static void Main(string[] args) {
            if (args.Length > 0)
            {
                env = args[0];
            }
            else
            {
                env = "dev";
            }
            aleter_UnitTest.Test_AlerterCelcius_FailureCase(env);
        }
    }
}