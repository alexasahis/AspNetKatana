﻿// -----------------------------------------------------------------------
// <copyright file="DirectoryBrowserExtensions.cs" company="Katana contributors">
//   Copyright 2011-2012 Katana contributors
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Owin;

namespace Microsoft.Owin.StaticFiles
{
    public static class DirectoryBrowserExtensions
    {
        public static IAppBuilder UseDirectoryBrowser(this IAppBuilder builder, string path, string directory)
        {
            return builder.UseDirectoryBrowser(new DirectoryBrowserOptions().WithRequestPath(path).WithPhysicalPath(directory));
        }

        public static IAppBuilder UseDirectoryBrowser(this IAppBuilder builder, DirectoryBrowserOptions options)
        {
            if (builder == null)
            {
                throw new ArgumentNullException("builder");
            }

            return builder.Use(typeof(DirectoryBrowserMiddleware), options);
        }
    }
}