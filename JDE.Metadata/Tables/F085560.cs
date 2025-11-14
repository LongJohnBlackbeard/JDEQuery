using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F085560 - .
/// </summary>
public class F085560 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NPAN8.
        /// </summary>
        public const string NPAN8 = "NPAN8";

        /// <summary>
        /// NPSBGR.
        /// </summary>
        public const string NPSBGR = "NPSBGR";

        /// <summary>
        /// NPNOPT.
        /// </summary>
        public const string NPNOPT = "NPNOPT";
    }

    /// <inheritdoc />
    public override string TableName => "F085560";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NPAN8", "NPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("NPSBGR", "NPSBGR", JdeDataType.String, 20, true, true),
        new JdeField("NPNOPT", "NPNOPT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F085560_0", "Primary Key on NPAN8, NPSBGR", new[] { "NPAN8", "NPSBGR" }, isUnique: true, isPrimaryKey: true)
    };
}
