using System;
using Autofac;

namespace Ofl.Google.DependencyInjection.Autofac
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Validate parameters.
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            // Bind.
            builder.RegisterType<ConfigurationApiKeyProvider>().As<IApiKeyProvider>();
        }
    }
}
