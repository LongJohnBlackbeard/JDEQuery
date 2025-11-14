using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0911SW - .
/// </summary>
public class F0911SW : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GSUSER.
        /// </summary>
        public const string GSUSER = "GSUSER";

        /// <summary>
        /// GSUKID.
        /// </summary>
        public const string GSUKID = "GSUKID";

        /// <summary>
        /// GSCO.
        /// </summary>
        public const string GSCO = "GSCO";

        /// <summary>
        /// GSPOST.
        /// </summary>
        public const string GSPOST = "GSPOST";

        /// <summary>
        /// GSCRCD.
        /// </summary>
        public const string GSCRCD = "GSCRCD";

        /// <summary>
        /// GSUM.
        /// </summary>
        public const string GSUM = "GSUM";

        /// <summary>
        /// GSAA.
        /// </summary>
        public const string GSAA = "GSAA";

        /// <summary>
        /// GSU.
        /// </summary>
        public const string GSU = "GSU";

        /// <summary>
        /// GSCDEC.
        /// </summary>
        public const string GSCDEC = "GSCDEC";
    }

    /// <inheritdoc />
    public override string TableName => "F0911SW";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GSUSER", "GSUSER", JdeDataType.String, 20, true, true),
        new JdeField("GSUKID", "GSUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("GSCO", "GSCO", JdeDataType.String, 10, true, true),
        new JdeField("GSPOST", "GSPOST", JdeDataType.String, 2, true, true),
        new JdeField("GSCRCD", "GSCRCD", JdeDataType.String, 6, true, true),
        new JdeField("GSUM", "GSUM", JdeDataType.String, 4, true, true),
        new JdeField("GSAA", "GSAA", JdeDataType.Numeric),
        new JdeField("GSU", "GSU", JdeDataType.Numeric),
        new JdeField("GSCDEC", "GSCDEC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0911SW_0", "Primary Key on GSUSER, GSUKID, GSCO, GSPOST, GSCRCD, GSUM", new[] { "GSUSER", "GSUKID", "GSCO", "GSPOST", "GSCRCD", "GSUM" }, isUnique: true, isPrimaryKey: true)
    };
}
