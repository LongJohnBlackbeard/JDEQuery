using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0101 - Address Book Master table metadata.
/// </summary>
public class F0101 : JdeTable
{
    /// <inheritdoc />
    public override string TableName => "F0101";

    /// <inheritdoc />
    public override string Description => "Address Book Master";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        // Primary Key
        new JdeField("ABAN8", "Address Number", JdeDataType.Numeric, null, true, true),

        // Core Fields
        new JdeField("ABALPH", "Alphabetic Name", JdeDataType.String, 40, true),
        new JdeField("ABALKY", "Alpha Name/Search Key", JdeDataType.String, 20),
        new JdeField("ABAT1", "Search Type", JdeDataType.String, 1),
        new JdeField("ABDC", "Description - Compressed", JdeDataType.String, 40),
        new JdeField("ABTAX", "Tax ID", JdeDataType.String, 20),
        new JdeField("ABTAXC", "Tax ID Country", JdeDataType.String, 3),

        // Category Codes
        new JdeField("ABAC01", "Category Code - Address Book 01", JdeDataType.String, 3),
        new JdeField("ABAC02", "Category Code - Address Book 02", JdeDataType.String, 3),
        new JdeField("ABAC03", "Category Code - Address Book 03", JdeDataType.String, 3),
        new JdeField("ABAC04", "Category Code - Address Book 04", JdeDataType.String, 3),
        new JdeField("ABAC05", "Category Code - Address Book 05", JdeDataType.String, 3),
        new JdeField("ABAC06", "Category Code - Address Book 06", JdeDataType.String, 3),
        new JdeField("ABAC07", "Category Code - Address Book 07", JdeDataType.String, 3),
        new JdeField("ABAC08", "Category Code - Address Book 08", JdeDataType.String, 3),
        new JdeField("ABAC09", "Category Code - Address Book 09", JdeDataType.String, 3),
        new JdeField("ABAC10", "Category Code - Address Book 10", JdeDataType.String, 3),

        // Additional Common Fields
        new JdeField("ABMCU", "Business Unit", JdeDataType.String, 12),
        new JdeField("ABSIC", "Standard Industry Class", JdeDataType.String, 10),
        new JdeField("ABLNGP", "Language", JdeDataType.String, 2),
        new JdeField("ABCM", "Credit Message", JdeDataType.String, 2),
        new JdeField("ABALP1", "Alpha Name - Payee", JdeDataType.String, 40),
        new JdeField("ABAC11", "Category Code - Address Book 11", JdeDataType.String, 3),
        new JdeField("ABAC12", "Category Code - Address Book 12", JdeDataType.String, 3),
        new JdeField("ABAC13", "Category Code - Address Book 13", JdeDataType.String, 3),
        new JdeField("ABAC14", "Category Code - Address Book 14", JdeDataType.String, 3),
        new JdeField("ABAC15", "Category Code - Address Book 15", JdeDataType.String, 3),
        new JdeField("ABAC16", "Category Code - Address Book 16", JdeDataType.String, 3),
        new JdeField("ABAC17", "Category Code - Address Book 17", JdeDataType.String, 3),
        new JdeField("ABAC18", "Category Code - Address Book 18", JdeDataType.String, 3),
        new JdeField("ABAC19", "Category Code - Address Book 19", JdeDataType.String, 3),
        new JdeField("ABAC20", "Category Code - Address Book 20", JdeDataType.String, 3),
        new JdeField("ABAC21", "Category Code - Address Book 21", JdeDataType.String, 3),
        new JdeField("ABAC22", "Category Code - Address Book 22", JdeDataType.String, 3),
        new JdeField("ABAC23", "Category Code - Address Book 23", JdeDataType.String, 3),
        new JdeField("ABAC24", "Category Code - Address Book 24", JdeDataType.String, 3),
        new JdeField("ABAC25", "Category Code - Address Book 25", JdeDataType.String, 3),
        new JdeField("ABAC26", "Category Code - Address Book 26", JdeDataType.String, 3),
        new JdeField("ABAC27", "Category Code - Address Book 27", JdeDataType.String, 3),
        new JdeField("ABAC28", "Category Code - Address Book 28", JdeDataType.String, 3),
        new JdeField("ABAC29", "Category Code - Address Book 29", JdeDataType.String, 3),
        new JdeField("ABAC30", "Category Code - Address Book 30", JdeDataType.String, 3),

        // Audit Fields
        new JdeField("ABUSER", "User ID", JdeDataType.String, 10),
        new JdeField("ABPID", "Program ID", JdeDataType.String, 10),
        new JdeField("ABJOBN", "Work Station ID", JdeDataType.String, 10),
        new JdeField("ABUPMJ", "Date - Updated", JdeDataType.Numeric),
        new JdeField("ABUPMT", "Time - Updated", JdeDataType.Numeric),
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex(
            "PK_F0101",
            "Primary Key - Address Number",
            new[] { "ABAN8" },
            isUnique: true,
            isPrimaryKey: true),

        new JdeIndex(
            "IDX_F0101_TYPE_KEY",
            "Index on Search Type and Alpha Name/Key",
            new[] { "ABAT1", "ABALKY" }),

        new JdeIndex(
            "IDX_F0101_ALPH",
            "Index on Alphabetic Name",
            new[] { "ABALPH" }),

        new JdeIndex(
            "IDX_F0101_TAX",
            "Index on Tax ID",
            new[] { "ABTAX" }),
    };
}
