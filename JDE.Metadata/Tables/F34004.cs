using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34004 - .
/// </summary>
public class F34004 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MGMVER.
        /// </summary>
        public const string MGMVER = "MGMVER";

        /// <summary>
        /// MGDCTO.
        /// </summary>
        public const string MGDCTO = "MGDCTO";

        /// <summary>
        /// MGLNTY.
        /// </summary>
        public const string MGLNTY = "MGLNTY";

        /// <summary>
        /// MGTRTY.
        /// </summary>
        public const string MGTRTY = "MGTRTY";
    }

    /// <inheritdoc />
    public override string TableName => "F34004";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MGMVER", "MGMVER", JdeDataType.String, 6, true, true),
        new JdeField("MGDCTO", "MGDCTO", JdeDataType.String, 4, true, true),
        new JdeField("MGLNTY", "MGLNTY", JdeDataType.String, 4, true, true),
        new JdeField("MGTRTY", "MGTRTY", JdeDataType.String, 6, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34004_0", "Primary Key on MGMVER, MGDCTO, MGLNTY, MGTRTY", new[] { "MGMVER", "MGDCTO", "MGLNTY", "MGTRTY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F34004_4", "Index on MGDCTO, MGLNTY, MGTRTY", new[] { "MGDCTO", "MGLNTY", "MGTRTY" }),
        new JdeIndex("F34004_5", "Index on MGDCTO, MGTRTY", new[] { "MGDCTO", "MGTRTY" })
    };
}
