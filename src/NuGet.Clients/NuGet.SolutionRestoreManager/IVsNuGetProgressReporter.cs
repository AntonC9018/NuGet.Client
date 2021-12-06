// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using NuGet.Commands;

namespace NuGet.SolutionRestoreManager
{
    public interface IVsNuGetProgressReporter : IRestoreProgressReporter
    {
        void StartSolutionRestore(IReadOnlyList<string> projects);

        void EndSolutionRestore(IReadOnlyList<string> projects);
    }
}
