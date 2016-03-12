// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

internal partial class Interop
{
    internal partial class mincore
    {
        [DllImport(Libraries.Kernel32_L1, CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern int SetThreadIdealProcessor(SafeThreadHandle handle, int processor);
    }
}
