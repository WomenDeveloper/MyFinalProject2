﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection servicesCollection)
        {
            servicesCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }
    }
}