﻿// <copyright file="GlobalSupressions.cs" company="Katana contributors">
//   Copyright 2011-2012 Katana contributors
// </copyright>
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Owin", Justification = "By design")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2243:AttributeStringLiteralsShouldParseCorrectly", Justification = "Contains prerelease version data")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames", Justification = "Will be delay signed")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.AspNet.WebApi.Owin", Justification = "By design")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Owin.StartupExtensions.#Run(Owin.IAppBuilder,System.Object)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Owin.StartupExtensions.#Build(Owin.IAppBuilder)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Owin.StartupExtensions.#Build`1(Owin.IAppBuilder)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Owin.StartupExtensions.#BuildNew(Owin.IAppBuilder,System.Action`1<Owin.IAppBuilder>)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Owin.StartupExtensions.#BuildNew`1(Owin.IAppBuilder,System.Action`1<Owin.IAppBuilder>)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Owin.StartupExtensions.#UseFunc`1(Owin.IAppBuilder,System.Func`2<!!0,!!0>)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Owin.StartupExtensions.#UseFunc(Owin.IAppBuilder,System.Func`2<System.Func`2<System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.Threading.Tasks.Task>,System.Func`2<System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.Threading.Tasks.Task>>)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Owin.StartupExtensions.#UseFunc`1(Owin.IAppBuilder,System.Func`3<System.Func`2<System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.Threading.Tasks.Task>,!!0,System.Func`2<System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.Threading.Tasks.Task>>,!!0)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Owin.StartupExtensions.#UseFunc`2(Owin.IAppBuilder,System.Func`4<System.Func`2<System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.Threading.Tasks.Task>,!!0,!!1,System.Func`2<System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.Threading.Tasks.Task>>,!!0,!!1)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Owin.StartupExtensions.#UseFunc`3(Owin.IAppBuilder,System.Func`5<System.Func`2<System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.Threading.Tasks.Task>,!!0,!!1,!!2,System.Func`2<System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.Threading.Tasks.Task>>,!!0,!!1,!!2)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Owin.StartupExtensions.#UseFunc`4(Owin.IAppBuilder,System.Func`6<System.Func`2<System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.Threading.Tasks.Task>,!!0,!!1,!!2,!!3,System.Func`2<System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.Threading.Tasks.Task>>,!!0,!!1,!!2,!!3)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Owin.StartupExtensions.#UseFunc`1(Owin.IAppBuilder,System.Func`2<!!0,System.Func`2<System.Func`2<System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.Threading.Tasks.Task>,System.Func`2<System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.Threading.Tasks.Task>>>,!!0)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Owin.StartupExtensions.#UseFunc`2(Owin.IAppBuilder,System.Func`3<!!0,!!1,System.Func`2<System.Func`2<System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.Threading.Tasks.Task>,System.Func`2<System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.Threading.Tasks.Task>>>,!!0,!!1)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Owin.StartupExtensions.#UseFunc`3(Owin.IAppBuilder,System.Func`4<!!0,!!1,!!2,System.Func`2<System.Func`2<System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.Threading.Tasks.Task>,System.Func`2<System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.Threading.Tasks.Task>>>,!!0,!!1,!!2)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Owin.StartupExtensions.#UseFunc`4(Owin.IAppBuilder,System.Func`5<!!0,!!1,!!2,!!3,System.Func`2<System.Func`2<System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.Threading.Tasks.Task>,System.Func`2<System.Collections.Generic.IDictionary`2<System.String,System.Object>,System.Threading.Tasks.Task>>>,!!0,!!1,!!2,!!3)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Owin.StartupExtensions.#UseType`1(Owin.IAppBuilder,System.Object[])", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Owin.StartupExtensions.#UseType(Owin.IAppBuilder,System.Type,System.Object[])", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpers.#FromErrors(System.Collections.Generic.IEnumerable`1<System.Exception>)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpers.#NullResult()", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpers.#Iterate(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>,System.Threading.CancellationToken,System.Boolean)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpers.#RunSynchronously(System.Action,System.Threading.CancellationToken)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpers.#RunSynchronously`1(System.Func`1<!!0>,System.Threading.CancellationToken)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpers.#SetIfTaskFailed`1(System.Threading.Tasks.TaskCompletionSource`1<!!0>,System.Threading.Tasks.Task)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpersExtensions.#Catch(System.Threading.Tasks.Task,System.Func`2<System.Threading.Tasks.CatchInfo,System.Threading.Tasks.CatchInfoBase`1<System.Threading.Tasks.Task>+CatchResult>,System.Threading.CancellationToken)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpersExtensions.#Catch`1(System.Threading.Tasks.Task`1<!!0>,System.Func`2<System.Threading.Tasks.CatchInfo`1<!!0>,System.Threading.Tasks.CatchInfoBase`1<System.Threading.Tasks.Task`1<!!0>>+CatchResult>,System.Threading.CancellationToken)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpersExtensions.#CatchImpl`1(System.Threading.Tasks.Task,System.Func`1<System.Threading.Tasks.Task`1<!!0>>,System.Threading.CancellationToken)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpersExtensions.#CatchImplContinuation`1(System.Threading.Tasks.Task,System.Func`1<System.Threading.Tasks.Task`1<!!0>>)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpersExtensions.#CopyResultToCompletionSource`1(System.Threading.Tasks.Task,System.Threading.Tasks.TaskCompletionSource`1<!!0>,!!0)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpersExtensions.#CopyResultToCompletionSource`1(System.Threading.Tasks.Task`1<!!0>,System.Threading.Tasks.TaskCompletionSource`1<!!0>)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpersExtensions.#CopyResultToCompletionSourceImpl`2(!!0,System.Threading.Tasks.TaskCompletionSource`1<!!1>,System.Func`2<!!0,!!1>)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpersExtensions.#CopyResultToCompletionSourceImplContinuation`2(!!0,System.Threading.Tasks.TaskCompletionSource`1<!!1>,System.Func`2<!!0,!!1>)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpersExtensions.#CastToObject(System.Threading.Tasks.Task)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpersExtensions.#CastToObject`1(System.Threading.Tasks.Task`1<!!0>)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpersExtensions.#CastFromObject`1(System.Threading.Tasks.Task`1<System.Object>)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpersExtensions.#FastUnwrap(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpersExtensions.#Finally`1(System.Threading.Tasks.Task`1<!!0>,System.Action,System.Boolean)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpersExtensions.#Then(System.Threading.Tasks.Task,System.Action,System.Threading.CancellationToken,System.Boolean)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpersExtensions.#Then`1(System.Threading.Tasks.Task`1<!!0>,System.Action`1<!!0>,System.Threading.CancellationToken,System.Boolean)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpersExtensions.#Then`2(System.Threading.Tasks.Task`1<!!0>,System.Func`2<!!0,!!1>,System.Threading.CancellationToken,System.Boolean)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpersExtensions.#Then`2(System.Threading.Tasks.Task`1<!!0>,System.Func`2<!!0,System.Threading.Tasks.Task`1<!!1>>,System.Threading.CancellationToken,System.Boolean)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpersExtensions.#ThrowIfFaulted(System.Threading.Tasks.Task)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.TaskHelpersExtensions.#TryGetResult`1(System.Threading.Tasks.Task`1<!!0>,!!0&)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.CatchInfo.#Handled()", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.CatchInfo.#Task(System.Threading.Tasks.Task)", Justification = "Dependency included by source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Threading.Tasks.CatchInfo.#Throw(System.Exception)", Justification = "Dependency included by source")]