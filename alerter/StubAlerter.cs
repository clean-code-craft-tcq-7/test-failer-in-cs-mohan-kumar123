using System;
using System.Diagnostics;
using static AlerterSpace.Alerter;

namespace AlerterSpace
{
    public class StubAlerter : Alerter
    {
        // For Test Environment
        public override int networkAlert(float celcius)
        {
            Console.WriteLine("ALERT: Temperature is {0} celcius", celcius);
            Console.WriteLine("code executed in stub level.....");
            // Return 200 for ok
            // Return 500 for not-ok
            // stub always succeeds and returns 200
             return 200;
        }
    }
}