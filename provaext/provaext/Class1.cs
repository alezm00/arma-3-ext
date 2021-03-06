﻿using System.Text;
using System.Runtime.InteropServices;
using RGiesecke.DllExport;

class provaext
{

#if WIN64
        [DllExport("RVExtensionVersion", CallingConvention = CallingConvention.Winapi)]
#else
    [DllExport("_RVExtensionVersion@8", CallingConvention = CallingConvention.Winapi)]
#endif
    public static void RvExtensionVersion(StringBuilder output, int outputSize)
    {
        output.Append("Test-Extension v1.0");
    }

#if WIN64
        [DllExport("RVExtension", CallingConvention = CallingConvention.Winapi)]
#else
    [DllExport("_RVExtension@12", CallingConvention = CallingConvention.Winapi)]
#endif
    public static void RvExtension(StringBuilder output, int outputSize,
        [MarshalAs(UnmanagedType.LPStr)] string function)
    {
        output.Append(function);
    }

#if WIN64
        [DllExport("RVExtensionArgs", CallingConvention = CallingConvention.Winapi)]
#else
    [DllExport("_RVExtensionArgs@20", CallingConvention = CallingConvention.Winapi)]
#endif
    public static int RvExtensionArgs(StringBuilder output, int outputSize,
        [MarshalAs(UnmanagedType.LPStr)] string function,
        [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr, SizeParamIndex = 4)] string[] args, int argCount)
    {
        foreach (var arg in args)
        {
            output.Append(arg);
        }
        return 0;
    }
}