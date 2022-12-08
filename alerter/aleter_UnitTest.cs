using System;
using System.Diagnostics;

namespace AlerterSpace
{
    public partial class aleter_UnitTest
    {
        public static void Test_AlerterCelcius_FailureCase()
        {
            Alerter.alertInCelcius(400.5f);
            Alerter.alertInCelcius(303.6f);
            Debug.Assert(Alerter.alertFailureCount > 0);
            Console.WriteLine("{0} alerts failed.", Alerter.alertFailureCount);
            Console.WriteLine("All is well (maybe!)\n");

            StubAlerter stubAlerter = new StubAlerter();
            stubAlerter.alertInCelcius(400.5f);
            stubAlerter.alertInCelcius(392f);
            stubAlerter.alertInCelcius(303.6f);
        }
    }
}