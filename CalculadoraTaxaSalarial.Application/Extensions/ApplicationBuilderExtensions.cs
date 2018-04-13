﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace CalculadoraTaxaSalarial.Application.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static void UseCorsCustom(this IApplicationBuilder application)
        {
            void CorsPolicy(CorsPolicyBuilder corsPolicy)
            {
                corsPolicy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials();
            }

            application.UseCors(CorsPolicy);
        }
    }
}
