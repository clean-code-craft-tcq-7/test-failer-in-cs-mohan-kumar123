using System;
using System.Diagnostics;

namespace AlerterSpace
{
    public partial class aleter_UnitTest
    {
        public static void Test_AlerterCelcius_FailureCase(string env)
        {
            if (env == "dev")
            {
                StubAlerter stubAlerter = new StubAlerter();
                
                stubAlerter.alertInCelcius(400.5f);
                Console.WriteLine("Executed on stub level....");
                Console.WriteLine("{0} alerts Success.", 400.5f);
               
                stubAlerter.alertInCelcius(392f);
                Console.WriteLine("{0} alerts Success.", 392f);
              
                stubAlerter.alertInCelcius(303.6f);
                Console.WriteLine("{0} alerts Success.", 303.6f);
                Console.WriteLine("All is well (maybe!)\n");
            }
            else
            {
                Alerter.alertInCelcius(400.5f);
                Console.WriteLine("{0} alerts failed.", Alerter.alertFailureCount);
                Alerter.alertInCelcius(392f);
                Console.WriteLine("{0} alerts failed.", Alerter.alertFailureCount);
                Alerter.alertInCelcius(303.6f);
                Console.WriteLine("{0} alerts Success.", 303.6f);
                Debug.Assert(Alerter.alertFailureCount > 0);
            }
        }
    }
}