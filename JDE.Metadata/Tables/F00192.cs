using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00192 - .
/// </summary>
public class F00192 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CFSY.
        /// </summary>
        public const string CFSY = "CFSY";

        /// <summary>
        /// CFRT.
        /// </summary>
        public const string CFRT = "CFRT";

        /// <summary>
        /// CFKY.
        /// </summary>
        public const string CFKY = "CFKY";

        /// <summary>
        /// CFLINS.
        /// </summary>
        public const string CFLINS = "CFLINS";

        /// <summary>
        /// CFDS80.
        /// </summary>
        public const string CFDS80 = "CFDS80";
    }

    /// <inheritdoc />
    public override string TableName => "F00192";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CFSY", "CFSY", JdeDataType.String, 8, true, true),
        new JdeField("CFRT", "CFRT", JdeDataType.String, 4, true, true),
        new JdeField("CFKY", "CFKY", JdeDataType.String, 20, true, true),
        new JdeField("CFLINS", "CFLINS", JdeDataType.Numeric, null, true, true),
        new JdeField("CFDS80", "CFDS80", JdeDataType.String, 160)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00192_0", "Primary Key on CFSY, CFRT, CFKY, CFLINS", new[] { "CFSY", "CFRT", "CFKY", "CFLINS" }, isUnique: true, isPrimaryKey: true)
    };
}
