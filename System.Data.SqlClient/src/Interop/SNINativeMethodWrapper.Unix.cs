// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Data.SqlClient.SNI;

namespace System.Data.SqlClient
{
    internal static class SNINativeMethodWrapper
    {
        internal enum SniSpecialErrors : uint
        {
            LocalDBErrorCode = SNICommon.LocalDBErrorCode,

            // multi-subnet-failover specific error codes
            MultiSubnetFailoverWithMoreThan64IPs = SNICommon.MultiSubnetFailoverWithMoreThan64IPs,
            MultiSubnetFailoverWithInstanceSpecified = SNICommon.MultiSubnetFailoverWithInstanceSpecified,
            MultiSubnetFailoverWithNonTcpProtocol = SNICommon.MultiSubnetFailoverWithNonTcpProtocol,

            // max error code value
            MaxErrorValue = SNICommon.MaxErrorValue
        }
    }
}

namespace System.Data
{
    internal static class SafeNativeMethods
    {
        internal static IntPtr GetProcAddress(IntPtr HModule, string funcName)
        {
            throw new PlatformNotSupportedException("SafeNativeMethods.GetProcAddress is not supported on non-Windows platforms");
        }
    }
}

namespace System.Data
{
    internal static class Win32NativeMethods
    {
        internal static bool IsTokenRestrictedWrapper(IntPtr token)
        {
            throw new PlatformNotSupportedException("Win32NativeMethods.IsTokenRestrictedWrapper is not supported on non-Windows platforms");
        }
    }
}