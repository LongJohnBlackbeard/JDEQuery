# JDE Query Library - Sample Applications

This folder contains sample applications demonstrating how to use the JDE Query Library.

## JDE.Samples.QueryExamples

A comprehensive console application showcasing various query patterns and features.

### Prerequisites

- .NET 8.0 SDK
- Access to a JDE Oracle database (DV920, PY920, or PROD920)
- Valid connection credentials

### Setup

1. **Update Connection Settings**

   Edit `appsettings.json` and configure your database connection:

   ```json
   {
     "JdeQuery": {
       "Provider": "Oracle",
       "ConnectionString": "User Id=YOUR_USER;Password=YOUR_PASSWORD;Data Source=YOUR_SERVER",
       "Schema": "DV920",
       "Environment": "Development"
     }
   }
   ```

2. **Build the Sample**

   ```bash
   cd samples/JDE.Samples.QueryExamples
   dotnet build
   ```

3. **Run the Sample**

   ```bash
   dotnet run
   ```

### What It Demonstrates

The sample application includes 7 examples:

1. **Basic Query** - Single record retrieval with WHERE clause
2. **Column Selection** - Performance optimization by selecting specific fields
3. **Comparison Operators** - Using >, <, >=, <=, != operators
4. **Field Padding Handling** - Using WhereLike() and WhereTrimmedEqual()
5. **Pagination** - Skip/Take for large result sets
6. **Item Master Queries** - Working with F4101 (Item Master)
7. **Multiple Conditions** - Combining multiple WHERE clauses

### Example Output

```
=== JDE Query Library - Sample Examples ===
Provider: Oracle
Schema: DV920
Environment: Development

Testing database connection...
Connection successful!

--- Example 1: Basic Query (Single Record) ---
Found customer: 1001 - ACME CORPORATION

--- Example 2: Column Selection (Performance) ---
Found 5 customers (Type 'C'):
  1001 - ACME CORPORATION (Category: ABC)
  1002 - XYZ COMPANY (Category: DEF)
  ...
```

### Configuration for Different Environments

The `appsettings.json` includes configurations for:

- **Dev** (DV920) - Non-production development schema
- **Test** (PY920) - Non-production test schema
- **Prod** (PROD920) - Production schema

Switch between environments by changing the `JdeQuery` section or using command-line arguments.

### Troubleshooting

**Connection Errors:**
- Verify your Oracle connection string
- Ensure the JDE schema name is correct (DV920, PY920, PROD920, etc.)
- Check that your user has SELECT permissions on JDE tables

**No Data Returned:**
- Some example queries use hardcoded values (e.g., ABAN8=1001)
- Modify the WHERE clause values to match data in your environment
- Check the comments in Program.cs for fields to customize

**Build Errors:**
- Ensure all NuGet packages are restored: `dotnet restore`
- Verify you're using .NET 8.0: `dotnet --version`

### Customizing Examples

The sample code includes comments indicating where to replace placeholder values:

```csharp
// Replace with actual item number from your database
.Where("IMITM", 1000)

// Replace with actual product code
.Where("IMSRP1", "ABC")

// Replace with actual customer name
.WhereTrimmedEqual("ABALPH", "Test")
```

Update these values to match data in your specific JDE environment.

### Next Steps

After running the samples:
1. Experiment with different query combinations
2. Try querying other JDE tables
3. Add your own custom query examples
4. Use the patterns in your own applications

### Support

For issues or questions:
- Check the main README.md in the repository root
- Review the XML documentation in the JDE.Client namespace
- Open an issue on GitHub
