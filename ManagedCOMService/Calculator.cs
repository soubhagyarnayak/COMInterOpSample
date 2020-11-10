using System;
using System.Configuration;
using System.Runtime.InteropServices;

namespace ManagedCOMService
{
    [Guid("F4D3BC92-0F55-44C6-AAAD-7825E50CD6BA")]
    [ClassInterface(ClassInterfaceType.None)]
    public class Calculator:ICalculator
    {
        public int Add(int num1, int num2)
        {
            Console.WriteLine($"IsServerGC:{System.Runtime.GCSettings.IsServerGC}");
            Console.WriteLine($"GCLatencyMode:{System.Runtime.GCSettings.LatencyMode}");
            Console.WriteLine($"Reading settings from: {ConfigurationManager.AppSettings["SettingsFileName"]}");
            return num1 + num2;
        }
    }
}
