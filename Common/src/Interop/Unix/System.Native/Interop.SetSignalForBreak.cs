// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Sys
    {
        [DllImport(Libraries.SystemNative, EntryPoint = "SystemNative_GetSignalForBreak")]
        internal static extern bool GetSignalForBreak();

        [DllImport(Libraries.SystemNative, EntryPoint = "SystemNative_SetSignalForBreak")]
        internal static extern bool SetSignalForBreak(bool signalForBreak);
    }
}
