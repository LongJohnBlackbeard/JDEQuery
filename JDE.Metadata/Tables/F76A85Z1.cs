using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A85Z1 - .
/// </summary>
public class F76A85Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BEEDUS.
        /// </summary>
        public const string BEEDUS = "BEEDUS";

        /// <summary>
        /// BEEDBT.
        /// </summary>
        public const string BEEDBT = "BEEDBT";

        /// <summary>
        /// BEEDTN.
        /// </summary>
        public const string BEEDTN = "BEEDTN";

        /// <summary>
        /// BEVLDT.
        /// </summary>
        public const string BEVLDT = "BEVLDT";

        /// <summary>
        /// BEAOTT.
        /// </summary>
        public const string BEAOTT = "BEAOTT";

        /// <summary>
        /// BEPYID.
        /// </summary>
        public const string BEPYID = "BEPYID";

        /// <summary>
        /// BEPAAP.
        /// </summary>
        public const string BEPAAP = "BEPAAP";

        /// <summary>
        /// BEAG.
        /// </summary>
        public const string BEAG = "BEAG";

        /// <summary>
        /// BEAAP.
        /// </summary>
        public const string BEAAP = "BEAAP";

        /// <summary>
        /// BEACR.
        /// </summary>
        public const string BEACR = "BEACR";

        /// <summary>
        /// BEPFAP.
        /// </summary>
        public const string BEPFAP = "BEPFAP";

        /// <summary>
        /// BEFAP.
        /// </summary>
        public const string BEFAP = "BEFAP";

        /// <summary>
        /// BEDGJ.
        /// </summary>
        public const string BEDGJ = "BEDGJ";

        /// <summary>
        /// BECRR1.
        /// </summary>
        public const string BECRR1 = "BECRR1";

        /// <summary>
        /// BEDATE01.
        /// </summary>
        public const string BEDATE01 = "BEDATE01";

        /// <summary>
        /// BEDATE02.
        /// </summary>
        public const string BEDATE02 = "BEDATE02";

        /// <summary>
        /// BEMATH01.
        /// </summary>
        public const string BEMATH01 = "BEMATH01";

        /// <summary>
        /// BEMATH02.
        /// </summary>
        public const string BEMATH02 = "BEMATH02";

        /// <summary>
        /// BEMATH03.
        /// </summary>
        public const string BEMATH03 = "BEMATH03";

        /// <summary>
        /// BEMATH04.
        /// </summary>
        public const string BEMATH04 = "BEMATH04";

        /// <summary>
        /// BEAC01.
        /// </summary>
        public const string BEAC01 = "BEAC01";

        /// <summary>
        /// BEAC02.
        /// </summary>
        public const string BEAC02 = "BEAC02";

        /// <summary>
        /// BEAC03.
        /// </summary>
        public const string BEAC03 = "BEAC03";

        /// <summary>
        /// BEAC04.
        /// </summary>
        public const string BEAC04 = "BEAC04";

        /// <summary>
        /// BEEV01.
        /// </summary>
        public const string BEEV01 = "BEEV01";

        /// <summary>
        /// BEEV02.
        /// </summary>
        public const string BEEV02 = "BEEV02";

        /// <summary>
        /// BEEV03.
        /// </summary>
        public const string BEEV03 = "BEEV03";

        /// <summary>
        /// BERMK.
        /// </summary>
        public const string BERMK = "BERMK";

        /// <summary>
        /// BEVINV.
        /// </summary>
        public const string BEVINV = "BEVINV";

        /// <summary>
        /// BECTID.
        /// </summary>
        public const string BECTID = "BECTID";

        /// <summary>
        /// BEJOBS.
        /// </summary>
        public const string BEJOBS = "BEJOBS";

        /// <summary>
        /// BEJOBN.
        /// </summary>
        public const string BEJOBN = "BEJOBN";

        /// <summary>
        /// BEPID.
        /// </summary>
        public const string BEPID = "BEPID";

        /// <summary>
        /// BEUSER.
        /// </summary>
        public const string BEUSER = "BEUSER";

        /// <summary>
        /// BEUPMJ.
        /// </summary>
        public const string BEUPMJ = "BEUPMJ";

        /// <summary>
        /// BEUPMT.
        /// </summary>
        public const string BEUPMT = "BEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76A85Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BEEDUS", "BEEDUS", JdeDataType.String, 20, true, true),
        new JdeField("BEEDBT", "BEEDBT", JdeDataType.String, 30, true, true),
        new JdeField("BEEDTN", "BEEDTN", JdeDataType.String, 44, true, true),
        new JdeField("BEVLDT", "BEVLDT", JdeDataType.Numeric),
        new JdeField("BEAOTT", "BEAOTT", JdeDataType.String, 2),
        new JdeField("BEPYID", "BEPYID", JdeDataType.Numeric),
        new JdeField("BEPAAP", "BEPAAP", JdeDataType.Numeric),
        new JdeField("BEAG", "BEAG", JdeDataType.Numeric),
        new JdeField("BEAAP", "BEAAP", JdeDataType.Numeric),
        new JdeField("BEACR", "BEACR", JdeDataType.Numeric),
        new JdeField("BEPFAP", "BEPFAP", JdeDataType.Numeric),
        new JdeField("BEFAP", "BEFAP", JdeDataType.Numeric),
        new JdeField("BEDGJ", "BEDGJ", JdeDataType.Numeric),
        new JdeField("BECRR1", "BECRR1", JdeDataType.Numeric),
        new JdeField("BEDATE01", "BEDATE01", JdeDataType.Numeric),
        new JdeField("BEDATE02", "BEDATE02", JdeDataType.Numeric),
        new JdeField("BEMATH01", "BEMATH01", JdeDataType.Numeric),
        new JdeField("BEMATH02", "BEMATH02", JdeDataType.Numeric),
        new JdeField("BEMATH03", "BEMATH03", JdeDataType.Numeric),
        new JdeField("BEMATH04", "BEMATH04", JdeDataType.Numeric),
        new JdeField("BEAC01", "BEAC01", JdeDataType.String, 6),
        new JdeField("BEAC02", "BEAC02", JdeDataType.String, 6),
        new JdeField("BEAC03", "BEAC03", JdeDataType.String, 6),
        new JdeField("BEAC04", "BEAC04", JdeDataType.String, 6),
        new JdeField("BEEV01", "BEEV01", JdeDataType.String, 2),
        new JdeField("BEEV02", "BEEV02", JdeDataType.String, 2),
        new JdeField("BEEV03", "BEEV03", JdeDataType.String, 2),
        new JdeField("BERMK", "BERMK", JdeDataType.String, 60),
        new JdeField("BEVINV", "BEVINV", JdeDataType.String, 50),
        new JdeField("BECTID", "BECTID", JdeDataType.String, 30),
        new JdeField("BEJOBS", "BEJOBS", JdeDataType.Numeric),
        new JdeField("BEJOBN", "BEJOBN", JdeDataType.String, 20),
        new JdeField("BEPID", "BEPID", JdeDataType.String, 20),
        new JdeField("BEUSER", "BEUSER", JdeDataType.String, 20),
        new JdeField("BEUPMJ", "BEUPMJ", JdeDataType.Numeric),
        new JdeField("BEUPMT", "BEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A85Z1_0", "Primary Key on BEEDUS, BEEDBT, BEEDTN", new[] { "BEEDUS", "BEEDBT", "BEEDTN" }, isUnique: true, isPrimaryKey: true)
    };
}
