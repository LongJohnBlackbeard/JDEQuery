using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B01 - .
/// </summary>
public class F31B01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WIMCU.
        /// </summary>
        public const string WIMCU = "WIMCU";

        /// <summary>
        /// WIWID.
        /// </summary>
        public const string WIWID = "WIWID";

        /// <summary>
        /// WIDL01.
        /// </summary>
        public const string WIDL01 = "WIDL01";

        /// <summary>
        /// WIADD1.
        /// </summary>
        public const string WIADD1 = "WIADD1";

        /// <summary>
        /// WIADD2.
        /// </summary>
        public const string WIADD2 = "WIADD2";

        /// <summary>
        /// WICTY1.
        /// </summary>
        public const string WICTY1 = "WICTY1";

        /// <summary>
        /// WIADDS.
        /// </summary>
        public const string WIADDS = "WIADDS";

        /// <summary>
        /// WIADDZ.
        /// </summary>
        public const string WIADDZ = "WIADDZ";

        /// <summary>
        /// WICTR.
        /// </summary>
        public const string WICTR = "WICTR";

        /// <summary>
        /// WIAN8.
        /// </summary>
        public const string WIAN8 = "WIAN8";

        /// <summary>
        /// WITPOF.
        /// </summary>
        public const string WITPOF = "WITPOF";

        /// <summary>
        /// WITPCD.
        /// </summary>
        public const string WITPCD = "WITPCD";

        /// <summary>
        /// WIBWID.
        /// </summary>
        public const string WIBWID = "WIBWID";

        /// <summary>
        /// WIWSTU.
        /// </summary>
        public const string WIWSTU = "WIWSTU";

        /// <summary>
        /// WIWCC1.
        /// </summary>
        public const string WIWCC1 = "WIWCC1";

        /// <summary>
        /// WIWCC3.
        /// </summary>
        public const string WIWCC3 = "WIWCC3";

        /// <summary>
        /// WIWCC4.
        /// </summary>
        public const string WIWCC4 = "WIWCC4";

        /// <summary>
        /// WIWCC2.
        /// </summary>
        public const string WIWCC2 = "WIWCC2";

        /// <summary>
        /// WIWCC5.
        /// </summary>
        public const string WIWCC5 = "WIWCC5";

        /// <summary>
        /// WIWCC6.
        /// </summary>
        public const string WIWCC6 = "WIWCC6";

        /// <summary>
        /// WIWCC7.
        /// </summary>
        public const string WIWCC7 = "WIWCC7";

        /// <summary>
        /// WIWCC8.
        /// </summary>
        public const string WIWCC8 = "WIWCC8";

        /// <summary>
        /// WIWCC9.
        /// </summary>
        public const string WIWCC9 = "WIWCC9";

        /// <summary>
        /// WIWCC10.
        /// </summary>
        public const string WIWCC10 = "WIWCC10";

        /// <summary>
        /// WIWCP1.
        /// </summary>
        public const string WIWCP1 = "WIWCP1";

        /// <summary>
        /// WIWCP2.
        /// </summary>
        public const string WIWCP2 = "WIWCP2";

        /// <summary>
        /// WIWCP3.
        /// </summary>
        public const string WIWCP3 = "WIWCP3";

        /// <summary>
        /// WIWCP4.
        /// </summary>
        public const string WIWCP4 = "WIWCP4";

        /// <summary>
        /// WIWCP5.
        /// </summary>
        public const string WIWCP5 = "WIWCP5";

        /// <summary>
        /// WIWCP6.
        /// </summary>
        public const string WIWCP6 = "WIWCP6";

        /// <summary>
        /// WIWCP7.
        /// </summary>
        public const string WIWCP7 = "WIWCP7";

        /// <summary>
        /// WIWCP8.
        /// </summary>
        public const string WIWCP8 = "WIWCP8";

        /// <summary>
        /// WIWCP9.
        /// </summary>
        public const string WIWCP9 = "WIWCP9";

        /// <summary>
        /// WIWCP10.
        /// </summary>
        public const string WIWCP10 = "WIWCP10";

        /// <summary>
        /// WIUSER.
        /// </summary>
        public const string WIUSER = "WIUSER";

        /// <summary>
        /// WIPID.
        /// </summary>
        public const string WIPID = "WIPID";

        /// <summary>
        /// WIJOBN.
        /// </summary>
        public const string WIJOBN = "WIJOBN";

        /// <summary>
        /// WIUPMJ.
        /// </summary>
        public const string WIUPMJ = "WIUPMJ";

        /// <summary>
        /// WIUPMT.
        /// </summary>
        public const string WIUPMT = "WIUPMT";

        /// <summary>
        /// WIURCD.
        /// </summary>
        public const string WIURCD = "WIURCD";

        /// <summary>
        /// WIURDT.
        /// </summary>
        public const string WIURDT = "WIURDT";

        /// <summary>
        /// WIURAT.
        /// </summary>
        public const string WIURAT = "WIURAT";

        /// <summary>
        /// WIURRF.
        /// </summary>
        public const string WIURRF = "WIURRF";

        /// <summary>
        /// WIURAB.
        /// </summary>
        public const string WIURAB = "WIURAB";

        /// <summary>
        /// WISPAFLG.
        /// </summary>
        public const string WISPAFLG = "WISPAFLG";
    }

    /// <inheritdoc />
    public override string TableName => "F31B01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WIMCU", "WIMCU", JdeDataType.String, 24, true, true),
        new JdeField("WIWID", "WIWID", JdeDataType.String, 24),
        new JdeField("WIDL01", "WIDL01", JdeDataType.String, 60),
        new JdeField("WIADD1", "WIADD1", JdeDataType.String, 80),
        new JdeField("WIADD2", "WIADD2", JdeDataType.String, 80),
        new JdeField("WICTY1", "WICTY1", JdeDataType.String, 50),
        new JdeField("WIADDS", "WIADDS", JdeDataType.String, 6),
        new JdeField("WIADDZ", "WIADDZ", JdeDataType.String, 24),
        new JdeField("WICTR", "WICTR", JdeDataType.String, 6),
        new JdeField("WIAN8", "WIAN8", JdeDataType.Numeric),
        new JdeField("WITPOF", "WITPOF", JdeDataType.String, 6),
        new JdeField("WITPCD", "WITPCD", JdeDataType.String, 2),
        new JdeField("WIBWID", "WIBWID", JdeDataType.String, 40),
        new JdeField("WIWSTU", "WIWSTU", JdeDataType.String, 2),
        new JdeField("WIWCC1", "WIWCC1", JdeDataType.String, 6),
        new JdeField("WIWCC3", "WIWCC3", JdeDataType.String, 6),
        new JdeField("WIWCC4", "WIWCC4", JdeDataType.String, 6),
        new JdeField("WIWCC2", "WIWCC2", JdeDataType.String, 6),
        new JdeField("WIWCC5", "WIWCC5", JdeDataType.String, 6),
        new JdeField("WIWCC6", "WIWCC6", JdeDataType.String, 6),
        new JdeField("WIWCC7", "WIWCC7", JdeDataType.String, 6),
        new JdeField("WIWCC8", "WIWCC8", JdeDataType.String, 6),
        new JdeField("WIWCC9", "WIWCC9", JdeDataType.String, 6),
        new JdeField("WIWCC10", "WIWCC10", JdeDataType.String, 6),
        new JdeField("WIWCP1", "WIWCP1", JdeDataType.String, 24),
        new JdeField("WIWCP2", "WIWCP2", JdeDataType.String, 24),
        new JdeField("WIWCP3", "WIWCP3", JdeDataType.String, 24),
        new JdeField("WIWCP4", "WIWCP4", JdeDataType.String, 24),
        new JdeField("WIWCP5", "WIWCP5", JdeDataType.String, 24),
        new JdeField("WIWCP6", "WIWCP6", JdeDataType.String, 24),
        new JdeField("WIWCP7", "WIWCP7", JdeDataType.String, 24),
        new JdeField("WIWCP8", "WIWCP8", JdeDataType.String, 24),
        new JdeField("WIWCP9", "WIWCP9", JdeDataType.String, 24),
        new JdeField("WIWCP10", "WIWCP10", JdeDataType.String, 24),
        new JdeField("WIUSER", "WIUSER", JdeDataType.String, 20),
        new JdeField("WIPID", "WIPID", JdeDataType.String, 20),
        new JdeField("WIJOBN", "WIJOBN", JdeDataType.String, 20),
        new JdeField("WIUPMJ", "WIUPMJ", JdeDataType.Numeric),
        new JdeField("WIUPMT", "WIUPMT", JdeDataType.Numeric),
        new JdeField("WIURCD", "WIURCD", JdeDataType.String, 4),
        new JdeField("WIURDT", "WIURDT", JdeDataType.Numeric),
        new JdeField("WIURAT", "WIURAT", JdeDataType.Numeric),
        new JdeField("WIURRF", "WIURRF", JdeDataType.String, 30),
        new JdeField("WIURAB", "WIURAB", JdeDataType.Numeric),
        new JdeField("WISPAFLG", "WISPAFLG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B01_0", "Primary Key on WIMCU", new[] { "WIMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B01_2", "Index on WIWID", new[] { "WIWID" })
    };
}
