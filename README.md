# COMInterOpSample
Test sample for COM Callable Wrapper
To register the managed dll, use the following command from an elevated command prompt.
It will also generate the required tlb file.
```bash
c:\Windows\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe  ManagedCOMService.dll /codebase /tlb
```
