using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B99 - .
/// </summary>
public class F31B99 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DDLNID.
        /// </summary>
        public const string DDLNID = "DDLNID";

        /// <summary>
        /// DDWVID.
        /// </summary>
        public const string DDWVID = "DDWVID";

        /// <summary>
        /// DDITM.
        /// </summary>
        public const string DDITM = "DDITM";

        /// <summary>
        /// DDMCU.
        /// </summary>
        public const string DDMCU = "DDMCU";

        /// <summary>
        /// DDWOD.
        /// </summary>
        public const string DDWOD = "DDWOD";

        /// <summary>
        /// DDLOCN.
        /// </summary>
        public const string DDLOCN = "DDLOCN";

        /// <summary>
        /// DDLOTN.
        /// </summary>
        public const string DDLOTN = "DDLOTN";

        /// <summary>
        /// DDQTY.
        /// </summary>
        public const string DDQTY = "DDQTY";

        /// <summary>
        /// DDUOM.
        /// </summary>
        public const string DDUOM = "DDUOM";

        /// <summary>
        /// DDURDT.
        /// </summary>
        public const string DDURDT = "DDURDT";

        /// <summary>
        /// DDURRF.
        /// </summary>
        public const string DDURRF = "DDURRF";

        /// <summary>
        /// DDURAT.
        /// </summary>
        public const string DDURAT = "DDURAT";

        /// <summary>
        /// DDURAB.
        /// </summary>
        public const string DDURAB = "DDURAB";

        /// <summary>
        /// DDUSER.
        /// </summary>
        public const string DDUSER = "DDUSER";

        /// <summary>
        /// DDPID.
        /// </summary>
        public const string DDPID = "DDPID";

        /// <summary>
        /// DDJOBN.
        /// </summary>
        public const string DDJOBN = "DDJOBN";

        /// <summary>
        /// DDUPMJ.
        /// </summary>
        public const string DDUPMJ = "DDUPMJ";

        /// <summary>
        /// DDTDAY.
        /// </summary>
        public const string DDTDAY = "DDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31B99";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DDLNID", "DDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("DDWVID", "DDWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("DDITM", "DDITM", JdeDataType.Numeric),
        new JdeField("DDMCU", "DDMCU", JdeDataType.String, 24),
        new JdeField("DDWOD", "DDWOD", JdeDataType.Numeric),
        new JdeField("DDLOCN", "DDLOCN", JdeDataType.String, 40),
        new JdeField("DDLOTN", "DDLOTN", JdeDataType.String, 60),
        new JdeField("DDQTY", "DDQTY", JdeDataType.Numeric),
        new JdeField("DDUOM", "DDUOM", JdeDataType.String, 4),
        new JdeField("DDURDT", "DDURDT", JdeDataType.Numeric),
        new JdeField("DDURRF", "DDURRF", JdeDataType.String, 30),
        new JdeField("DDURAT", "DDURAT", JdeDataType.Numeric),
        new JdeField("DDURAB", "DDURAB", JdeDataType.Numeric),
        new JdeField("DDUSER", "DDUSER", JdeDataType.String, 20),
        new JdeField("DDPID", "DDPID", JdeDataType.String, 20),
        new JdeField("DDJOBN", "DDJOBN", JdeDataType.String, 20),
        new JdeField("DDUPMJ", "DDUPMJ", JdeDataType.Numeric),
        new JdeField("DDTDAY", "DDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B99_0", "Primary Key on DDLNID, DDWVID", new[] { "DDLNID", "DDWVID" }, isUnique: true, isPrimaryKey: true)
    };
}
