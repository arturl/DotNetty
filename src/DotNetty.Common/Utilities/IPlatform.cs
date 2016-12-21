﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DotNetty.Common
{
    using System;
    public interface IPlatform
    {
        int GetCurrentProcessId();

        byte[] GetDefaultDeviceID();
    }
}