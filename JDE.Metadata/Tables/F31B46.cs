using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B46 - .
/// </summary>
public class F31B46 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTWTMPID.
        /// </summary>
        public const string CTWTMPID = "CTWTMPID";

        /// <summary>
        /// CTWTMPLNID.
        /// </summary>
        public const string CTWTMPLNID = "CTWTMPLNID";

        /// <summary>
        /// CTWTMPNM.
        /// </summary>
        public const string CTWTMPNM = "CTWTMPNM";

        /// <summary>
        /// CTWTMPDS.
        /// </summary>
        public const string CTWTMPDS = "CTWTMPDS";

        /// <summary>
        /// CTWTMPST.
        /// </summary>
        public const string CTWTMPST = "CTWTMPST";

        /// <summary>
        /// CTWTMPC1.
        /// </summary>
        public const string CTWTMPC1 = "CTWTMPC1";

        /// <summary>
        /// CTWTMPC2.
        /// </summary>
        public const string CTWTMPC2 = "CTWTMPC2";

        /// <summary>
        /// CTWTMPC3.
        /// </summary>
        public const string CTWTMPC3 = "CTWTMPC3";

        /// <summary>
        /// CTWTMPC4.
        /// </summary>
        public const string CTWTMPC4 = "CTWTMPC4";

        /// <summary>
        /// CTWTMPC5.
        /// </summary>
        public const string CTWTMPC5 = "CTWTMPC5";

        /// <summary>
        /// CTMCU.
        /// </summary>
        public const string CTMCU = "CTMCU";

        /// <summary>
        /// CTITM.
        /// </summary>
        public const string CTITM = "CTITM";

        /// <summary>
        /// CTLOCN.
        /// </summary>
        public const string CTLOCN = "CTLOCN";

        /// <summary>
        /// CTLOTN.
        /// </summary>
        public const string CTLOTN = "CTLOTN";

        /// <summary>
        /// CTECQTY.
        /// </summary>
        public const string CTECQTY = "CTECQTY";

        /// <summary>
        /// CTUOM1.
        /// </summary>
        public const string CTUOM1 = "CTUOM1";

        /// <summary>
        /// CTURAB.
        /// </summary>
        public const string CTURAB = "CTURAB";

        /// <summary>
        /// CTURAT.
        /// </summary>
        public const string CTURAT = "CTURAT";

        /// <summary>
        /// CTURCD.
        /// </summary>
        public const string CTURCD = "CTURCD";

        /// <summary>
        /// CTURDT.
        /// </summary>
        public const string CTURDT = "CTURDT";

        /// <summary>
        /// CTURRF.
        /// </summary>
        public const string CTURRF = "CTURRF";

        /// <summary>
        /// CTWAB.
        /// </summary>
        public const string CTWAB = "CTWAB";

        /// <summary>
        /// CTWCD.
        /// </summary>
        public const string CTWCD = "CTWCD";

        /// <summary>
        /// CTWMDT.
        /// </summary>
        public const string CTWMDT = "CTWMDT";

        /// <summary>
        /// CTWNUM.
        /// </summary>
        public const string CTWNUM = "CTWNUM";

        /// <summary>
        /// CTWRF.
        /// </summary>
        public const string CTWRF = "CTWRF";

        /// <summary>
        /// CTPID.
        /// </summary>
        public const string CTPID = "CTPID";

        /// <summary>
        /// CTMKEY.
        /// </summary>
        public const string CTMKEY = "CTMKEY";

        /// <summary>
        /// CTUPMJ.
        /// </summary>
        public const string CTUPMJ = "CTUPMJ";

        /// <summary>
        /// CTUPMT.
        /// </summary>
        public const string CTUPMT = "CTUPMT";

        /// <summary>
        /// CTUSER.
        /// </summary>
        public const string CTUSER = "CTUSER";

        /// <summary>
        /// CTWCRTR.
        /// </summary>
        public const string CTWCRTR = "CTWCRTR";
    }

    /// <inheritdoc />
    public override string TableName => "F31B46";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTWTMPID", "CTWTMPID", JdeDataType.Numeric, null, true, true),
        new JdeField("CTWTMPLNID", "CTWTMPLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CTWTMPNM", "CTWTMPNM", JdeDataType.String, 60),
        new JdeField("CTWTMPDS", "CTWTMPDS", JdeDataType.String, 60),
        new JdeField("CTWTMPST", "CTWTMPST", JdeDataType.String, 2),
        new JdeField("CTWTMPC1", "CTWTMPC1", JdeDataType.String, 20),
        new JdeField("CTWTMPC2", "CTWTMPC2", JdeDataType.String, 20),
        new JdeField("CTWTMPC3", "CTWTMPC3", JdeDataType.String, 20),
        new JdeField("CTWTMPC4", "CTWTMPC4", JdeDataType.String, 20),
        new JdeField("CTWTMPC5", "CTWTMPC5", JdeDataType.String, 20),
        new JdeField("CTMCU", "CTMCU", JdeDataType.String, 24),
        new JdeField("CTITM", "CTITM", JdeDataType.Numeric),
        new JdeField("CTLOCN", "CTLOCN", JdeDataType.String, 40),
        new JdeField("CTLOTN", "CTLOTN", JdeDataType.String, 60),
        new JdeField("CTECQTY", "CTECQTY", JdeDataType.Numeric),
        new JdeField("CTUOM1", "CTUOM1", JdeDataType.String, 4),
        new JdeField("CTURAB", "CTURAB", JdeDataType.Numeric),
        new JdeField("CTURAT", "CTURAT", JdeDataType.Numeric),
        new JdeField("CTURCD", "CTURCD", JdeDataType.String, 4),
        new JdeField("CTURDT", "CTURDT", JdeDataType.Numeric),
        new JdeField("CTURRF", "CTURRF", JdeDataType.String, 30),
        new JdeField("CTWAB", "CTWAB", JdeDataType.Numeric),
        new JdeField("CTWCD", "CTWCD", JdeDataType.String, 6),
        new JdeField("CTWMDT", "CTWMDT", JdeDataType.Numeric),
        new JdeField("CTWNUM", "CTWNUM", JdeDataType.Numeric),
        new JdeField("CTWRF", "CTWRF", JdeDataType.String, 60),
        new JdeField("CTPID", "CTPID", JdeDataType.String, 20),
        new JdeField("CTMKEY", "CTMKEY", JdeDataType.String, 30),
        new JdeField("CTUPMJ", "CTUPMJ", JdeDataType.Numeric),
        new JdeField("CTUPMT", "CTUPMT", JdeDataType.Numeric),
        new JdeField("CTUSER", "CTUSER", JdeDataType.String, 20),
        new JdeField("CTWCRTR", "CTWCRTR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B46_0", "Primary Key on CTWTMPID, CTWTMPLNID", new[] { "CTWTMPID", "CTWTMPLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B46_2", "Index on CTWTMPNM, CTWTMPLNID", new[] { "CTWTMPNM", "CTWTMPLNID" }),
        new JdeIndex("F31B46_3", "Index on CTWTMPID", new[] { "CTWTMPID" })
    };
}
