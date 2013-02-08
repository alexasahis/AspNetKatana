// <copyright file="DefaultServices.cs" company="Katana contributors">
//   Copyright 2011-2013 Katana contributors
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

using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Owin.Hosting.Builder;
using Microsoft.Owin.Hosting.Loader;
using Microsoft.Owin.Hosting.Settings;
using Microsoft.Owin.Hosting.Starter;
using Microsoft.Owin.Hosting.Tracing;

namespace Microsoft.Owin.Hosting.Services
{
    public static class DefaultServices
    {
        public static IServiceProvider Create()
        {
            return Create(_ => { });
        }

        public static IServiceProvider Create(Action<DefaultServiceProvider> configuration)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException("configuration");
            }

            var services = new DefaultServiceProvider();
            ForEach((service, implementation) => services.Add(service, implementation));
            configuration(services);
            return services;
        }

        public static void ForEach(Action<Type, Type> callback)
        {
            var servicesFile = "Microsoft.Owin.Hosting.config";
            if (File.Exists(servicesFile))
            {
                ForEach(servicesFile, callback);
                return;
            }

            servicesFile = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, servicesFile);
            if (File.Exists(servicesFile))
            {
                ForEach(servicesFile, callback);
                return;
            }

            ForEachDefaultService(callback);
        }

        public static void ForEach(string servicesFile, Action<Type, Type> callback)
        {
            var services = new Dictionary<string, string>(StringComparer.Ordinal);
            using (var streamReader = new StreamReader(servicesFile))
            {
                while (true)
                {
                    var line = streamReader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    if (line.StartsWith("#", StringComparison.Ordinal) ||
                        string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }
                    var delimiterIndex = line.IndexOf('=');
                    var name = line.Substring(0, delimiterIndex).Trim();
                    var value = line.Substring(delimiterIndex + 1).Trim();
                    services.Add(name, value);
                }
            }
            ForEach(services, callback);
        }

        public static void ForEach(IDictionary<string, string> services, Action<Type, Type> callback)
        {
            ForEachDefaultService((service, implementation) =>
            {
                string replacementNames;
                if (services.TryGetValue(service.FullName, out replacementNames))
                {
                    foreach (var replacementName in replacementNames.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        var replacement = Type.GetType(replacementName);
                        callback(service, replacement);
                    }
                }
                else
                {
                    callback(service, implementation);
                }
            });
        }

        public static void ForEachDefaultService(Action<Type, Type> callback)
        {
            if (callback == null)
            {
                throw new ArgumentNullException("callback");
            }

            callback(typeof(IKatanaStarter), typeof(KatanaStarter));
            callback(typeof(IHostingStarterFactory), typeof(DefaultHostingStarterFactory));
            callback(typeof(IHostingStarterActivator), typeof(DefaultHostingStarterActivator));
            callback(typeof(IKatanaEngine), typeof(KatanaEngine));
            callback(typeof(IKatanaSettingsProvider), typeof(DefaultKatanaSettingsProvider));
            callback(typeof(ITraceOutputBinder), typeof(DefaultTraceOutputBinder));
            callback(typeof(IAppLoaderManager), typeof(DefaultAppLoaderManager));
            callback(typeof(IAppLoaderProvider), typeof(DefaultAppLoaderProvider));
            callback(typeof(IAppActivator), typeof(DefaultAppActivator));
            callback(typeof(IAppBuilderFactory), typeof(DefaultAppBuilderFactory));
        }
    }
}