// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Microsoft.CodeAnalysis;

namespace Microsoft.AspNetCore.Mvc.RazorPages.Compilation
{
    public abstract class ReferenceManager
    {
        public abstract IReadOnlyList<MetadataReference> References { get; }
    }
}
