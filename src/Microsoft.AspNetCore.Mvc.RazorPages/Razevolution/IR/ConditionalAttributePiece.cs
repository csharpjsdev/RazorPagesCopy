// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics;
using Microsoft.AspNetCore.Razor.CodeGenerators;

namespace Microsoft.AspNetCore.Mvc.RazorPages.Razevolution.IR
{
    [DebuggerDisplay("WriteDynamicAttribute({Prefix}, {Value, nq})]")]
    public class ConditionalAttributePiece : ICSharpSource, ISourceMapped
    {
        public MappingLocation DocumentLocation { get; set; }

        public string Prefix { get; set; }

        public CSharpBlock Value { get; set; }
    }
}
