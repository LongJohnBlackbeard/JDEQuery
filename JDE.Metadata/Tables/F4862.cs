using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4862 - .
/// </summary>
public class F4862 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AFCBSS.
        /// </summary>
        public const string AFCBSS = "AFCBSS";

        /// <summary>
        /// AFCTBL.
        /// </summary>
        public const string AFCTBL = "AFCTBL";

        /// <summary>
        /// AFEFTB.
        /// </summary>
        public const string AFEFTB = "AFEFTB";

        /// <summary>
        /// AFCCOD.
        /// </summary>
        public const string AFCCOD = "AFCCOD";

        /// <summary>
        /// AFCRCD.
        /// </summary>
        public const string AFCRCD = "AFCRCD";
    }

    /// <inheritdoc />
    public override string TableName => "F4862";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AFCBSS", "AFCBSS", JdeDataType.String, 10, true, true),
        new JdeField("AFCTBL", "AFCTBL", JdeDataType.String, 20, true, true),
        new JdeField("AFEFTB", "AFEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("AFCCOD", "AFCCOD", JdeDataType.String, 10, true, true),
        new JdeField("AFCRCD", "AFCRCD", JdeDataType.String, 6, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4862_0", "Primary Key on AFCTBL, AFCRCD, AFEFTB, AFCBSS, AFCCOD", new[] { "AFCTBL", "AFCRCD", "AFEFTB", "AFCBSS", "AFCCOD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4862_2", "Index on AFCTBL, AFCRCD, AFEFTB, AFCBSS", new[] { "AFCTBL", "AFCRCD", "AFEFTB", "AFCBSS" }),
        new JdeIndex("F4862_3", "Index on AFCTBL, AFCRCD, AFCBSS", new[] { "AFCTBL", "AFCRCD", "AFCBSS" })
    };
}
