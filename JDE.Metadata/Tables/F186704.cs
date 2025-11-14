using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F186704 - .
/// </summary>
public class F186704 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RPLRSRRID.
        /// </summary>
        public const string RPLRSRRID = "RPLRSRRID";

        /// <summary>
        /// RPSEQ.
        /// </summary>
        public const string RPSEQ = "RPSEQ";

        /// <summary>
        /// RPAOR1.
        /// </summary>
        public const string RPAOR1 = "RPAOR1";

        /// <summary>
        /// RPLRSFID.
        /// </summary>
        public const string RPLRSFID = "RPLRSFID";

        /// <summary>
        /// RPVALS.
        /// </summary>
        public const string RPVALS = "RPVALS";

        /// <summary>
        /// RPTCSEGV.
        /// </summary>
        public const string RPTCSEGV = "RPTCSEGV";

        /// <summary>
        /// RPUSER.
        /// </summary>
        public const string RPUSER = "RPUSER";

        /// <summary>
        /// RPPID.
        /// </summary>
        public const string RPPID = "RPPID";

        /// <summary>
        /// RPJOBN.
        /// </summary>
        public const string RPJOBN = "RPJOBN";

        /// <summary>
        /// RPUPMJ.
        /// </summary>
        public const string RPUPMJ = "RPUPMJ";

        /// <summary>
        /// RPTDAY.
        /// </summary>
        public const string RPTDAY = "RPTDAY";

        /// <summary>
        /// RPLRSOP.
        /// </summary>
        public const string RPLRSOP = "RPLRSOP";

        /// <summary>
        /// RPLRSCP.
        /// </summary>
        public const string RPLRSCP = "RPLRSCP";
    }

    /// <inheritdoc />
    public override string TableName => "F186704";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RPLRSRRID", "RPLRSRRID", JdeDataType.Numeric, null, true, true),
        new JdeField("RPSEQ", "RPSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("RPAOR1", "RPAOR1", JdeDataType.String, 6),
        new JdeField("RPLRSFID", "RPLRSFID", JdeDataType.Numeric),
        new JdeField("RPVALS", "RPVALS", JdeDataType.String, 4),
        new JdeField("RPTCSEGV", "RPTCSEGV", JdeDataType.String, 80),
        new JdeField("RPUSER", "RPUSER", JdeDataType.String, 20),
        new JdeField("RPPID", "RPPID", JdeDataType.String, 20),
        new JdeField("RPJOBN", "RPJOBN", JdeDataType.String, 20),
        new JdeField("RPUPMJ", "RPUPMJ", JdeDataType.Numeric),
        new JdeField("RPTDAY", "RPTDAY", JdeDataType.Numeric),
        new JdeField("RPLRSOP", "RPLRSOP", JdeDataType.String, 2),
        new JdeField("RPLRSCP", "RPLRSCP", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F186704_0", "Primary Key on RPLRSRRID, RPSEQ", new[] { "RPLRSRRID", "RPSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
