using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46014 - .
/// </summary>
public class F46014 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RGMCU.
        /// </summary>
        public const string RGMCU = "RGMCU";

        /// <summary>
        /// RGMRG.
        /// </summary>
        public const string RGMRG = "RGMRG";

        /// <summary>
        /// RGSEQ.
        /// </summary>
        public const string RGSEQ = "RGSEQ";

        /// <summary>
        /// RGTYFL.
        /// </summary>
        public const string RGTYFL = "RGTYFL";

        /// <summary>
        /// RGSRUL.
        /// </summary>
        public const string RGSRUL = "RGSRUL";

        /// <summary>
        /// RGGZON.
        /// </summary>
        public const string RGGZON = "RGGZON";

        /// <summary>
        /// RGAYN.
        /// </summary>
        public const string RGAYN = "RGAYN";

        /// <summary>
        /// RGEF1.
        /// </summary>
        public const string RGEF1 = "RGEF1";

        /// <summary>
        /// RGET1.
        /// </summary>
        public const string RGET1 = "RGET1";

        /// <summary>
        /// RGUSER.
        /// </summary>
        public const string RGUSER = "RGUSER";

        /// <summary>
        /// RGPID.
        /// </summary>
        public const string RGPID = "RGPID";

        /// <summary>
        /// RGUPMJ.
        /// </summary>
        public const string RGUPMJ = "RGUPMJ";

        /// <summary>
        /// RGTDAY.
        /// </summary>
        public const string RGTDAY = "RGTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46014";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RGMCU", "RGMCU", JdeDataType.String, 24, true, true),
        new JdeField("RGMRG", "RGMRG", JdeDataType.String, 12, true, true),
        new JdeField("RGSEQ", "RGSEQ", JdeDataType.Numeric),
        new JdeField("RGTYFL", "RGTYFL", JdeDataType.String, 2, true, true),
        new JdeField("RGSRUL", "RGSRUL", JdeDataType.String, 12, true, true),
        new JdeField("RGGZON", "RGGZON", JdeDataType.String, 12, true, true),
        new JdeField("RGAYN", "RGAYN", JdeDataType.String, 2),
        new JdeField("RGEF1", "RGEF1", JdeDataType.Numeric, null, true, true),
        new JdeField("RGET1", "RGET1", JdeDataType.Numeric, null, true, true),
        new JdeField("RGUSER", "RGUSER", JdeDataType.String, 20),
        new JdeField("RGPID", "RGPID", JdeDataType.String, 20),
        new JdeField("RGUPMJ", "RGUPMJ", JdeDataType.Numeric),
        new JdeField("RGTDAY", "RGTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46014_0", "Primary Key on RGMCU, RGMRG, RGSRUL, RGGZON, RGEF1, RGET1, RGTYFL", new[] { "RGMCU", "RGMRG", "RGSRUL", "RGGZON", "RGEF1", "RGET1", "RGTYFL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46014_2", "Index on RGMCU, RGMRG", new[] { "RGMCU", "RGMRG" })
    };
}
