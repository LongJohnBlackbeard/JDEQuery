using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B116 - .
/// </summary>
public class F31B116 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CHWCCID.
        /// </summary>
        public const string CHWCCID = "CHWCCID";

        /// <summary>
        /// CHWCCNAME.
        /// </summary>
        public const string CHWCCNAME = "CHWCCNAME";

        /// <summary>
        /// CHWCCDESC.
        /// </summary>
        public const string CHWCCDESC = "CHWCCDESC";

        /// <summary>
        /// CHWCRTR.
        /// </summary>
        public const string CHWCRTR = "CHWCRTR";

        /// <summary>
        /// CHSTDTEMP.
        /// </summary>
        public const string CHSTDTEMP = "CHSTDTEMP";

        /// <summary>
        /// CHTEMPUOM.
        /// </summary>
        public const string CHTEMPUOM = "CHTEMPUOM";

        /// <summary>
        /// CHURAB.
        /// </summary>
        public const string CHURAB = "CHURAB";

        /// <summary>
        /// CHURAT.
        /// </summary>
        public const string CHURAT = "CHURAT";

        /// <summary>
        /// CHURCD.
        /// </summary>
        public const string CHURCD = "CHURCD";

        /// <summary>
        /// CHURDT.
        /// </summary>
        public const string CHURDT = "CHURDT";

        /// <summary>
        /// CHURRF.
        /// </summary>
        public const string CHURRF = "CHURRF";

        /// <summary>
        /// CHWAB.
        /// </summary>
        public const string CHWAB = "CHWAB";

        /// <summary>
        /// CHWNUM.
        /// </summary>
        public const string CHWNUM = "CHWNUM";

        /// <summary>
        /// CHWCD.
        /// </summary>
        public const string CHWCD = "CHWCD";

        /// <summary>
        /// CHWMDT.
        /// </summary>
        public const string CHWMDT = "CHWMDT";

        /// <summary>
        /// CHWRF.
        /// </summary>
        public const string CHWRF = "CHWRF";

        /// <summary>
        /// CHUSER.
        /// </summary>
        public const string CHUSER = "CHUSER";

        /// <summary>
        /// CHUPMJ.
        /// </summary>
        public const string CHUPMJ = "CHUPMJ";

        /// <summary>
        /// CHUPMT.
        /// </summary>
        public const string CHUPMT = "CHUPMT";

        /// <summary>
        /// CHJOBN.
        /// </summary>
        public const string CHJOBN = "CHJOBN";

        /// <summary>
        /// CHMKEY.
        /// </summary>
        public const string CHMKEY = "CHMKEY";

        /// <summary>
        /// CHPID.
        /// </summary>
        public const string CHPID = "CHPID";
    }

    /// <inheritdoc />
    public override string TableName => "F31B116";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CHWCCID", "CHWCCID", JdeDataType.Numeric, null, true, true),
        new JdeField("CHWCCNAME", "CHWCCNAME", JdeDataType.String, 60),
        new JdeField("CHWCCDESC", "CHWCCDESC", JdeDataType.String, 60),
        new JdeField("CHWCRTR", "CHWCRTR", JdeDataType.Numeric),
        new JdeField("CHSTDTEMP", "CHSTDTEMP", JdeDataType.Numeric),
        new JdeField("CHTEMPUOM", "CHTEMPUOM", JdeDataType.String, 4),
        new JdeField("CHURAB", "CHURAB", JdeDataType.Numeric),
        new JdeField("CHURAT", "CHURAT", JdeDataType.Numeric),
        new JdeField("CHURCD", "CHURCD", JdeDataType.String, 4),
        new JdeField("CHURDT", "CHURDT", JdeDataType.Numeric),
        new JdeField("CHURRF", "CHURRF", JdeDataType.String, 30),
        new JdeField("CHWAB", "CHWAB", JdeDataType.Numeric),
        new JdeField("CHWNUM", "CHWNUM", JdeDataType.Numeric),
        new JdeField("CHWCD", "CHWCD", JdeDataType.String, 6),
        new JdeField("CHWMDT", "CHWMDT", JdeDataType.Numeric),
        new JdeField("CHWRF", "CHWRF", JdeDataType.String, 60),
        new JdeField("CHUSER", "CHUSER", JdeDataType.String, 20),
        new JdeField("CHUPMJ", "CHUPMJ", JdeDataType.Numeric),
        new JdeField("CHUPMT", "CHUPMT", JdeDataType.Numeric),
        new JdeField("CHJOBN", "CHJOBN", JdeDataType.String, 20),
        new JdeField("CHMKEY", "CHMKEY", JdeDataType.String, 30),
        new JdeField("CHPID", "CHPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B116_0", "Primary Key on CHWCCID", new[] { "CHWCCID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B116_3", "Unique Index on CHWCCNAME", new[] { "CHWCCNAME" }, isUnique: true)
    };
}
