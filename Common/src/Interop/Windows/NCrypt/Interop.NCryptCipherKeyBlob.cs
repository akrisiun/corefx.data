// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

internal static partial class Interop
{
    internal static partial class NCrypt
    {
        internal const string NCRYPT_CIPHER_KEY_BLOB = "CipherKeyBlob";
        internal const int NCRYPT_CIPHER_KEY_BLOB_MAGIC = 0x52485043;  //'CPHR'
    }
}
