﻿// <copyright file="IMetricsAspNetCoreCoreBuilder.cs" company="Allan Hardy">
// Copyright (c) Allan Hardy. All rights reserved.
// </copyright>

// ReSharper disable CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
    // ReSharper restore CheckNamespace
{
    /// <summary>
    ///     Provides extensiblity on App Metrics middleware e.g. serialization options on supported endpoints.
    /// </summary>
    public interface IMetricsAspNetCoreCoreBuilder
    {
        /// <summary>
        ///     Gets the <see cref="IServiceCollection" /> where essential App Metrics AspNet Core services are configured.
        /// </summary>
        /// <value>
        ///     The <see cref="IServiceCollection" /> where essential App Metrics AspNet Core services are configure.
        /// </value>
        IServiceCollection Services { get; }
    }
}