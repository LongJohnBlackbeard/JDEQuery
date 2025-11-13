using JDE.Abstractions;
using JDE.Abstractions.Configuration;
using JDE.Providers.Oracle;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace JDE.Client;

/// <summary>
/// Extension methods for configuring JDE services in dependency injection.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds JDE Query services to the service collection.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="configuration">The configuration instance.</param>
    /// <param name="sectionName">The configuration section name (default: "JdeQuery").</param>
    /// <returns>The service collection for chaining.</returns>
    public static IServiceCollection AddJdeQuery(
        this IServiceCollection services,
        IConfiguration configuration,
        string sectionName = "JdeQuery")
    {
        if (services == null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        if (configuration == null)
        {
            throw new ArgumentNullException(nameof(configuration));
        }

        // Bind configuration
        services.Configure<JdeOptions>(options =>
        {
            configuration.GetSection(sectionName).Bind(options);
        });

        // Register services
        services.AddSingleton<IJdeConfiguration>(sp =>
        {
            var options = sp.GetRequiredService<IOptions<JdeOptions>>().Value;
            options.Validate();
            return options;
        });

        // Register provider based on configuration
        services.AddSingleton<ISqlDialect>(sp =>
        {
            var config = sp.GetRequiredService<IJdeConfiguration>();
            return config.Provider.ToLowerInvariant() switch
            {
                "oracle" => new OracleSqlDialect(),
                _ => throw new NotSupportedException($"Database provider '{config.Provider}' is not supported.")
            };
        });

        services.AddSingleton<IDbProvider>(sp =>
        {
            var config = sp.GetRequiredService<IJdeConfiguration>();
            return config.Provider.ToLowerInvariant() switch
            {
                "oracle" => new OracleDbProvider(config),
                _ => throw new NotSupportedException($"Database provider '{config.Provider}' is not supported.")
            };
        });

        services.AddSingleton<JdeClient>();

        return services;
    }

    /// <summary>
    /// Adds JDE Query services with explicit options configuration.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="configureOptions">Action to configure JDE options.</param>
    /// <returns>The service collection for chaining.</returns>
    public static IServiceCollection AddJdeQuery(
        this IServiceCollection services,
        Action<JdeOptions> configureOptions)
    {
        if (services == null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        if (configureOptions == null)
        {
            throw new ArgumentNullException(nameof(configureOptions));
        }

        // Configure options
        services.Configure(configureOptions);

        // Register services
        services.AddSingleton<IJdeConfiguration>(sp =>
        {
            var options = sp.GetRequiredService<IOptions<JdeOptions>>().Value;
            options.Validate();
            return options;
        });

        // Register provider based on configuration
        services.AddSingleton<ISqlDialect>(sp =>
        {
            var config = sp.GetRequiredService<IJdeConfiguration>();
            return config.Provider.ToLowerInvariant() switch
            {
                "oracle" => new OracleSqlDialect(),
                _ => throw new NotSupportedException($"Database provider '{config.Provider}' is not supported.")
            };
        });

        services.AddSingleton<IDbProvider>(sp =>
        {
            var config = sp.GetRequiredService<IJdeConfiguration>();
            return config.Provider.ToLowerInvariant() switch
            {
                "oracle" => new OracleDbProvider(config),
                _ => throw new NotSupportedException($"Database provider '{config.Provider}' is not supported.")
            };
        });

        services.AddSingleton<JdeClient>();

        return services;
    }

    /// <summary>
    /// Adds JDE Query services for Oracle with connection string.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="connectionString">The Oracle connection string.</param>
    /// <param name="schema">The JDE schema name.</param>
    /// <param name="environment">Optional environment name.</param>
    /// <returns>The service collection for chaining.</returns>
    public static IServiceCollection AddJdeQueryOracle(
        this IServiceCollection services,
        string connectionString,
        string schema,
        string? environment = null)
    {
        if (services == null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new ArgumentException("Connection string cannot be null or whitespace.", nameof(connectionString));
        }

        if (string.IsNullOrWhiteSpace(schema))
        {
            throw new ArgumentException("Schema cannot be null or whitespace.", nameof(schema));
        }

        return services.AddJdeQuery(options =>
        {
            options.ConnectionString = connectionString;
            options.Schema = schema;
            options.Provider = "Oracle";
            options.Environment = environment;
        });
    }
}
