// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Mvc.RazorPages.Razevolution
{
    public abstract class RazorEngineBuilder
    {
        public static IRazorEngineBuilder Create()
        {
            return new Builder();
        }

        public static RazorEngine Build(Action<IRazorEngineBuilder> action)
        {
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            var builder = Create();
            action(builder);
            return builder.Build();
        }

        private class Builder : IRazorEngineBuilder
        {
            public Builder()
            {
                Features = new List<IRazorEngineFeature>();
                Phases = new List<IRazorEnginePhase>();
            }

            public ICollection<IRazorEngineFeature> Features { get; }

            public IList<IRazorEnginePhase> Phases { get; }

            public RazorEngine Build()
            {
                var features = new IRazorEngineFeature[Features.Count];
                Features.CopyTo(features, arrayIndex: 0);

                var phases = new IRazorEnginePhase[Phases.Count];
                Phases.CopyTo(phases, arrayIndex: 0);

                return new DefaultRazorEngine(features, phases);
            }
        }
    }
}
