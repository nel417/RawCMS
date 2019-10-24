﻿//******************************************************************************
// <copyright file="license.md" company="RawCMS project  (https://github.com/arduosoft/RawCMS)">
// Copyright (c) 2019 RawCMS project  (https://github.com/arduosoft/RawCMS)
// RawCMS project is released under GPL3 terms, see LICENSE file on repository root at  https://github.com/arduosoft/RawCMS .
// </copyright>
// <author>Daniele Fontani, Emanuele Bucarelli, Francesco Mina'</author>
// <autogenerated>true</autogenerated>
//******************************************************************************
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using RawCMS.Library.Core.Extension;
using RawCMS.Plugins.ApiGateway.Classes;
using System.Collections.Generic;

namespace RawCMS.Plugins.ApiGateway.Interfaces
{
    public abstract class GatewayMiddleware : Middleware<ApiGatewayConfig>
    {
        internal IEnumerable<RawHandler> handlers { get; set; }

        public GatewayMiddleware(RequestDelegate requestDelegate, ILogger logger, ApiGatewayConfig config, IEnumerable<RawHandler> handlers) :
            base(requestDelegate, logger, config)
        {
            this.handlers = handlers;
        }
    }
}