using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Converters;
using Portal.Common.JsonConverter;
using Portal.Database.Context;
using Portal.Database.Repositories;
using Serilog;

namespace Portal.Extensions;

public static class WebApplicationBuilderProviderExtensions
{
    public static WebApplicationBuilder ConfigurePortalServices(this WebApplicationBuilder builder, string policyName)
    {
        var config = builder.Configuration;
        
        var serviceCollection = builder.Services;
        
        serviceCollection.AddControllers()
            .AddNewtonsoftJson(options =>
            {
                var systemConfig = config.GetRequiredSection("SystemConfiguration");
                var dateFormat = systemConfig.GetValue<string>("Date");
                var timeFormat = systemConfig.GetValue<string>("Time");
                
                options.SerializerSettings.Converters.Add(new StringEnumConverter());
                options.SerializerSettings.Converters.Add(new CustomDateOnlyConverter(dateFormat!));
                options.SerializerSettings.Converters.Add(new CustomTimeOnlyConverter(timeFormat!));
            });
        // order is vital, this *must* be called *after* AddNewtonsoftJson()
        serviceCollection.AddSwaggerGenNewtonsoftSupport();
        
        serviceCollection.AddPortalCors(policyName);
        serviceCollection.AddPortalJwtAuthentication(config);
        serviceCollection.AddPortalSwaggerGen(config);
        serviceCollection.AddPortalGraphql(config);
        
        serviceCollection.AddDbContext<PortalDbContext>(
            opt => opt.UseNpgsql(config.GetConnectionString("DefaultConnection")),
            ServiceLifetime.Transient,
            ServiceLifetime.Transient);
        
        serviceCollection.AddPortalNpgsqlRepositories(config);
        serviceCollection.AddPortalService(config);
        
        return builder;
    }
    
    public static WebApplicationBuilder ConfigureSerilog(this WebApplicationBuilder builder)
    {
        builder.Host.UseSerilog((hostContext, configuration) =>
        {
            configuration.ReadFrom.Configuration(hostContext.Configuration);
        });
    
        return builder;
    }
}