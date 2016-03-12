// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

internal partial class Interop
{
    internal partial class mincore
    {
        [DllImport(Libraries.Console_L2, CharSet = CharSet.Unicode, SetLastError = true, EntryPoint = "SetConsoleTitleW")]
        internal static extern bool SetConsoleTitle(string title);
    }
}
