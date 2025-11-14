using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0030W - .
/// </summary>
public class F0030W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AXAN8.
        /// </summary>
        public const string AXAN8 = "AXAN8";

        /// <summary>
        /// AXBKTP.
        /// </summary>
        public const string AXBKTP = "AXBKTP";
    }

    /// <inheritdoc />
    public override string TableName => "F0030W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AXAN8", "AXAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AXBKTP", "AXBKTP", JdeDataType.String, 2, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0030W_0", "Primary Key on AXAN8, AXBKTP", new[] { "AXAN8", "AXBKTP" }, isUnique: true, isPrimaryKey: true)
    };
}
