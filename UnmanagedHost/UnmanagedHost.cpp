// UnmanagedHost.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

#include "Objbase.h"

#import "mscorlib.tlb" auto_rename
#import ".\ManagedCOMService.tlb" //raw_interfaces_only

int main()
{
    std::cout << "Hello World!\n";
    HRESULT hr = CoInitialize(NULL);
    ManagedCOMService::ICalculatorPtr ptr;
    hr = CoCreateInstance(
        __uuidof(ManagedCOMService::Calculator), // COM class id 
        NULL, // Outer unknown
        CLSCTX_ALL, // Server INFO 
        __uuidof(ManagedCOMService::ICalculator), // interface id
        (void**)&ptr);  // Returned Interface                                                                                                                   

    if (FAILED(hr))
    {
        _com_error e(hr);
        std::cout << "ERROR!" << std::endl;
        //strErrorMsg.Format("Error: Unable to create COM Visible .NET component. hr = %d. Message = %s", hr, e.ErrorMessage());
        return hr;
    }
    int result = ptr->Add(10, 20);
    std::cout << result << std::endl;
    std::cin >> result;
    CoUninitialize();
    return 0;
}

