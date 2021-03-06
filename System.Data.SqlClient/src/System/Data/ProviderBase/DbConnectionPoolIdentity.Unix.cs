// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


//------------------------------------------------------------------------------

using System.Security.Principal;


namespace System.Data.ProviderBase
{
    partial class DbConnectionPoolIdentity
    {
        static internal DbConnectionPoolIdentity GetCurrent()
        {
            throw new PlatformNotSupportedException();
        }
    }
}

