using System;
using System.Runtime.InteropServices;

namespace ManagedCOMService
{
    [ComVisible(true)]
    [Guid("026C087A-F5DA-48EC-82E0-04B3B3417129")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICalculator
    {
        [DispId(1)]
        int Add(int num1, int num2);
    }
}
