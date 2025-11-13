using JDE.Client;
using JDE.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace JDE.Samples.QueryExamples;

class Program
{
    static async Task Main(string[] args)
    {
        // Build configuration
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false)
            .AddCommandLine(args)
            .Build();

        // Build host with dependency injection
        var host = Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                // Register JDE Query library
                services.AddJdeQuery(configuration, "JdeQuery");
            })
            .Build();

        var jdeClient = host.Services.GetRequiredService<JdeClient>();
        var logger = host.Services.GetRequiredService<ILogger<Program>>();

        logger.LogInformation("=== JDE Query Library - Sample Examples ===");
        logger.LogInformation("Provider: {Provider}", jdeClient.ProviderName);
        logger.LogInformation("Schema: {Schema}", jdeClient.Schema);
        logger.LogInformation("Environment: {Environment}", jdeClient.Environment ?? "Not specified");
        logger.LogInformation("");

        try
        {
            // Test connection
            logger.LogInformation("Testing database connection...");
            var connectionOk = await jdeClient.TestConnectionAsync();
            if (!connectionOk)
            {
                logger.LogError("Failed to connect to the database. Please check your connection string.");
                return;
            }
            logger.LogInformation("Connection successful!");
            logger.LogInformation("");

            // Run example queries
            await Example1_BasicQuery(jdeClient, logger);
            await Example2_ColumnSelection(jdeClient, logger);
            await Example3_ComparisonOperators(jdeClient, logger);
            await Example4_FieldPaddingHandling(jdeClient, logger);
            await Example5_Pagination(jdeClient, logger);
            await Example6_ItemMasterQueries(jdeClient, logger);
            await Example7_MultipleConditions(jdeClient, logger);

            logger.LogInformation("");
            logger.LogInformation("=== All examples completed successfully! ===");
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "An error occurred while running the examples");
        }
    }

    static async Task Example1_BasicQuery(JdeClient client, ILogger logger)
    {
        logger.LogInformation("--- Example 1: Basic Query (Single Record) ---");
        try
        {
            var customer = await client.Query<F0101Model>("F0101")
                .Where("ABAN8", 1001)
                .FetchSingleAsync();

            if (customer != null)
            {
                logger.LogInformation("Found customer: {ABAN8} - {ABALPH}", customer.ABAN8, customer.ABALPH?.Trim());
            }
            else
            {
                logger.LogWarning("Customer 1001 not found");
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error in Example 1");
        }
        logger.LogInformation("");
    }

    static async Task Example2_ColumnSelection(JdeClient client, ILogger logger)
    {
        logger.LogInformation("--- Example 2: Column Selection (Performance) ---");
        try
        {
            var customers = await client.Query<F0101Model>("F0101")
                .SelectFields("ABAN8", "ABALPH", "ABAT1", "ABAC01")
                .Where("ABAT1", "C")
                .Take(5)
                .FetchManyAsync();

            logger.LogInformation("Found {Count} customers (Type 'C'):", customers.Count());
            foreach (var customer in customers)
            {
                logger.LogInformation("  {ABAN8} - {ABALPH} (Category: {ABAC01})",
                    customer.ABAN8,
                    customer.ABALPH?.Trim(),
                    customer.ABAC01?.Trim());
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error in Example 2");
        }
        logger.LogInformation("");
    }

    static async Task Example3_ComparisonOperators(JdeClient client, ILogger logger)
    {
        logger.LogInformation("--- Example 3: Comparison Operators ---");
        try
        {
            // Greater than
            logger.LogInformation("Finding address book numbers > 10000:");
            var highNumbers = await client.Query<F0101Model>("F0101")
                .SelectFields("ABAN8", "ABALPH", "ABAT1")
                .WhereGreaterThan("ABAN8", 10000)
                .Take(3)
                .FetchManyAsync();

            foreach (var record in highNumbers)
            {
                logger.LogInformation("  {ABAN8} - {ABALPH} (Type: {ABAT1})",
                    record.ABAN8,
                    record.ABALPH?.Trim(),
                    record.ABAT1?.Trim());
            }

            // Range query
            logger.LogInformation("Finding address book numbers between 1000 and 2000:");
            var rangeResults = await client.Query<F0101Model>("F0101")
                .SelectFields("ABAN8", "ABALPH")
                .WhereGreaterThanOrEqual("ABAN8", 1000)
                .WhereLessThanOrEqual("ABAN8", 2000)
                .Take(3)
                .FetchManyAsync();

            foreach (var record in rangeResults)
            {
                logger.LogInformation("  {ABAN8} - {ABALPH}",
                    record.ABAN8,
                    record.ABALPH?.Trim());
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error in Example 3");
        }
        logger.LogInformation("");
    }

    static async Task Example4_FieldPaddingHandling(JdeClient client, ILogger logger)
    {
        logger.LogInformation("--- Example 4: Field Padding Handling ---");
        try
        {
            // Using LIKE for pattern matching
            logger.LogInformation("Finding customers with names starting with 'A':");
            var likeResults = await client.Query<F0101Model>("F0101")
                .SelectFields("ABAN8", "ABALPH", "ABAT1")
                .WhereLike("ABALPH", "A%")
                .Take(3)
                .FetchManyAsync();

            foreach (var record in likeResults)
            {
                logger.LogInformation("  {ABAN8} - {ABALPH}",
                    record.ABAN8,
                    record.ABALPH?.Trim());
            }

            // Using trimmed equal for exact match (ignoring padding)
            // Note: Replace "ACME CORP" with an actual value from your database
            logger.LogInformation("Finding customer with trimmed name match:");
            var trimmedResult = await client.Query<F0101Model>("F0101")
                .SelectFields("ABAN8", "ABALPH", "ABAT1")
                .WhereTrimmedEqual("ABALPH", "Test")  // Replace with actual name
                .FetchSingleAsync();

            if (trimmedResult != null)
            {
                logger.LogInformation("  Found: {ABAN8} - {ABALPH}",
                    trimmedResult.ABAN8,
                    trimmedResult.ABALPH?.Trim());
            }
            else
            {
                logger.LogInformation("  No match found (try changing the search value)");
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error in Example 4");
        }
        logger.LogInformation("");
    }

    static async Task Example5_Pagination(JdeClient client, ILogger logger)
    {
        logger.LogInformation("--- Example 5: Pagination ---");
        try
        {
            const int pageSize = 5;

            // Page 1
            logger.LogInformation("Fetching page 1 (first {PageSize} customers):", pageSize);
            var page1 = await client.Query<F0101Model>("F0101")
                .SelectFields("ABAN8", "ABALPH", "ABAT1")
                .Where("ABAT1", "C")
                .Take(pageSize)
                .FetchManyAsync();

            foreach (var record in page1)
            {
                logger.LogInformation("  {ABAN8} - {ABALPH}",
                    record.ABAN8,
                    record.ABALPH?.Trim());
            }

            // Page 2
            logger.LogInformation("Fetching page 2 (next {PageSize} customers):", pageSize);
            var page2 = await client.Query<F0101Model>("F0101")
                .SelectFields("ABAN8", "ABALPH", "ABAT1")
                .Where("ABAT1", "C")
                .Skip(pageSize)
                .Take(pageSize)
                .FetchManyAsync();

            foreach (var record in page2)
            {
                logger.LogInformation("  {ABAN8} - {ABALPH}",
                    record.ABAN8,
                    record.ABALPH?.Trim());
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error in Example 5");
        }
        logger.LogInformation("");
    }

    static async Task Example6_ItemMasterQueries(JdeClient client, ILogger logger)
    {
        logger.LogInformation("--- Example 6: Item Master (F4101) Queries ---");
        try
        {
            // Query items by product code
            logger.LogInformation("Finding items by product code:");
            var items = await client.Query<F4101Model>("F4101")
                .SelectFields("IMITM", "IMDSC1", "IMSRP1", "IMSRP2", "IMSTKT")
                .Where("IMSRP1", "ABC")  // Replace with actual product code
                .Take(3)
                .FetchManyAsync();

            if (items.Any())
            {
                foreach (var item in items)
                {
                    logger.LogInformation("  Item: {IMITM} - {IMDSC1}",
                        item.IMITM,
                        item.IMDSC1?.Trim());
                    logger.LogInformation("    Product: {IMSRP1}/{IMSRP2}, Stock Type: {IMSTKT}",
                        item.IMSRP1?.Trim(),
                        item.IMSRP2?.Trim(),
                        item.IMSTKT?.Trim());
                }
            }
            else
            {
                logger.LogInformation("  No items found (try changing the product code filter)");
            }

            // Query specific item by number
            logger.LogInformation("Finding specific item by number:");
            var specificItem = await client.Query<F4101Model>("F4101")
                .Where("IMITM", 1000)  // Replace with actual item number
                .FetchSingleAsync();

            if (specificItem != null)
            {
                logger.LogInformation("  {IMITM} - {IMDSC1}",
                    specificItem.IMITM,
                    specificItem.IMDSC1?.Trim());
                logger.LogInformation("  Description 2: {IMDSC2}",
                    specificItem.IMDSC2?.Trim());
            }
            else
            {
                logger.LogInformation("  Item 1000 not found (try a different item number)");
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error in Example 6");
        }
        logger.LogInformation("");
    }

    static async Task Example7_MultipleConditions(JdeClient client, ILogger logger)
    {
        logger.LogInformation("--- Example 7: Multiple WHERE Conditions ---");
        try
        {
            logger.LogInformation("Finding customers with Type='C' AND ABAN8 > 1000:");
            var results = await client.Query<F0101Model>("F0101")
                .SelectFields("ABAN8", "ABALPH", "ABAT1", "ABAC01")
                .Where("ABAT1", "C")
                .WhereGreaterThan("ABAN8", 1000)
                .Take(5)
                .FetchManyAsync();

            logger.LogInformation("Found {Count} records:", results.Count());
            foreach (var record in results)
            {
                logger.LogInformation("  {ABAN8} - {ABALPH} (Category: {ABAC01})",
                    record.ABAN8,
                    record.ABALPH?.Trim(),
                    record.ABAC01?.Trim());
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error in Example 7");
        }
        logger.LogInformation("");
    }
}
