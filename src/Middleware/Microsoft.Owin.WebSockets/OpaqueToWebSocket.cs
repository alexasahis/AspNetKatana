﻿// -----------------------------------------------------------------------
// <copyright file="OpaqueToWebSocket.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Owin;

namespace Microsoft.Owin.WebSockets
{
    using AppFunc = Func<IDictionary<string, object>, Task>;
    using OpaqueUpgrade =
        Action<IDictionary<string, object>, // Opaque Upgrade parameters
            Func<IDictionary<string, object>, // Opaque environment
                Task>>; // Complete 
    // Complete
    using WebSocketAccept =
        Action<IDictionary<string, object>, // WebSocket Accept parameters
            Func<IDictionary<string, object>, // WebSocket environment
                Task>>; // Complete
    using WebSocketFunc =
        Func<IDictionary<string, object>, // WebSocket environment
            Task>; // Complete

    // This class demonstrates how to support WebSockets on a server that only supports opaque streams.
    // WebSocket Extension v0.4 is currently implemented.
    public static class OpaqueToWebSocket
    {
        public static IAppBuilder UseWebSockets(this IAppBuilder builder)
        {
            return builder.UseFunc<AppFunc>(OpaqueToWebSocket.Middleware);
        }

        public static AppFunc Middleware(AppFunc app)
        {
            return env =>
            {
                string opaqueSupport = env.Get<string>("opaque.Support");
                OpaqueUpgrade opaqueUpgrade = env.Get<OpaqueUpgrade>("opaque.Upgrade");
                WebSocketAccept webSocketAccept = env.Get<WebSocketAccept>(Constants.WebSocketAcceptKey);

                if (opaqueSupport == "opaque.Upgrade" // If we have opaque support
                    && opaqueUpgrade != null
                    && webSocketAccept == null) // and this request is a websocket request...
                {
                    if (IsWebSocketRequest(env))
                    {
                        IDictionary<string, object> acceptOptions = null;
                        WebSocketFunc webSocketFunc = null;

                        // Announce websocket support
                        env[Constants.WebSocketAcceptKey] = new WebSocketAccept(
                            (options, callback) =>
                            {
                                acceptOptions = options;
                                webSocketFunc = callback;
                                env[Constants.ResponseStatusCodeKey] = 101;
                            });

                        return app(env).Then(() =>
                        {
                            if (env.Get<int>(Constants.ResponseStatusCodeKey) == 101
                                && webSocketFunc != null)
                            {
                                SetWebSocketResponseHeaders(env, acceptOptions);

                                opaqueUpgrade(acceptOptions, opaqueEnv =>
                                {
                                    WebSocketLayer webSocket = new WebSocketLayer(opaqueEnv);
                                    return webSocketFunc(webSocket.Environment)
                                        .Then(() => webSocket.CleanupAsync());
                                });
                            }
                        });
                    }
                }

                // else
                return app(env);
            };
        }

        // Inspect the method and headers to see if this is a valid websocket request.
        // See RFC 6455 section 4.2.1.
        private static bool IsWebSocketRequest(IDictionary<string, object> env)
        {
            throw new NotImplementedException();
        }

        // Se the websocket response headers.
        // See RFC 6455 section 4.2.2.
        private static void SetWebSocketResponseHeaders(IDictionary<string, object> env, IDictionary<string, object> acceptOptions)
        {
            throw new NotImplementedException();
        }
    }
}