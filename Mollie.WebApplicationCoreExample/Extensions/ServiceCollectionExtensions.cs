﻿using Microsoft.Extensions.DependencyInjection;
using Mollie.Api.Client;
using Mollie.Api.Client.Abstract;

namespace Mollie.WebApplicationCoreExample.Extensions {
    public static class ServiceCollectionExtensions {
        public static IServiceCollection AddMollieApi(this IServiceCollection services, string apiKey) {
            services.AddSingleton<IPaymentClient, PaymentClient>(x => new PaymentClient(apiKey));

            return services;
        }
    }
}