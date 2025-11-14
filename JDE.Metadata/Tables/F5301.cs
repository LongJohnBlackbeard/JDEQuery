using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5301 - .
/// </summary>
public class F5301 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DICONO.
        /// </summary>
        public const string DICONO = "DICONO";

        /// <summary>
        /// DIMCU.
        /// </summary>
        public const string DIMCU = "DIMCU";

        /// <summary>
        /// DIDL01.
        /// </summary>
        public const string DIDL01 = "DIDL01";

        /// <summary>
        /// DIRMK.
        /// </summary>
        public const string DIRMK = "DIRMK";

        /// <summary>
        /// DICREF.
        /// </summary>
        public const string DICREF = "DICREF";

        /// <summary>
        /// DICRF2.
        /// </summary>
        public const string DICRF2 = "DICRF2";

        /// <summary>
        /// DICRF3.
        /// </summary>
        public const string DICRF3 = "DICRF3";

        /// <summary>
        /// DIAREQ.
        /// </summary>
        public const string DIAREQ = "DIAREQ";

        /// <summary>
        /// DIANO.
        /// </summary>
        public const string DIANO = "DIANO";

        /// <summary>
        /// DIAPRV.
        /// </summary>
        public const string DIAPRV = "DIAPRV";

        /// <summary>
        /// DIAN8V.
        /// </summary>
        public const string DIAN8V = "DIAN8V";

        /// <summary>
        /// DIBSTC.
        /// </summary>
        public const string DIBSTC = "DIBSTC";

        /// <summary>
        /// DIPRTC.
        /// </summary>
        public const string DIPRTC = "DIPRTC";

        /// <summary>
        /// DITYPB.
        /// </summary>
        public const string DITYPB = "DITYPB";

        /// <summary>
        /// DIREQB.
        /// </summary>
        public const string DIREQB = "DIREQB";

        /// <summary>
        /// DIRQBD.
        /// </summary>
        public const string DIRQBD = "DIRQBD";

        /// <summary>
        /// DIOREQ.
        /// </summary>
        public const string DIOREQ = "DIOREQ";

        /// <summary>
        /// DISUB.
        /// </summary>
        public const string DISUB = "DISUB";

        /// <summary>
        /// DIPONO.
        /// </summary>
        public const string DIPONO = "DIPONO";

        /// <summary>
        /// DIDRQJ.
        /// </summary>
        public const string DIDRQJ = "DIDRQJ";

        /// <summary>
        /// DIAPRD.
        /// </summary>
        public const string DIAPRD = "DIAPRD";

        /// <summary>
        /// DIPNST.
        /// </summary>
        public const string DIPNST = "DIPNST";

        /// <summary>
        /// DIPNFN.
        /// </summary>
        public const string DIPNFN = "DIPNFN";

        /// <summary>
        /// DIUDT1.
        /// </summary>
        public const string DIUDT1 = "DIUDT1";

        /// <summary>
        /// DIUDT2.
        /// </summary>
        public const string DIUDT2 = "DIUDT2";

        /// <summary>
        /// DIUDT3.
        /// </summary>
        public const string DIUDT3 = "DIUDT3";

        /// <summary>
        /// DIRB01.
        /// </summary>
        public const string DIRB01 = "DIRB01";

        /// <summary>
        /// DIRB02.
        /// </summary>
        public const string DIRB02 = "DIRB02";

        /// <summary>
        /// DIRB03.
        /// </summary>
        public const string DIRB03 = "DIRB03";

        /// <summary>
        /// DIRB04.
        /// </summary>
        public const string DIRB04 = "DIRB04";

        /// <summary>
        /// DIRB05.
        /// </summary>
        public const string DIRB05 = "DIRB05";

        /// <summary>
        /// DIRB06.
        /// </summary>
        public const string DIRB06 = "DIRB06";

        /// <summary>
        /// DIRB07.
        /// </summary>
        public const string DIRB07 = "DIRB07";

        /// <summary>
        /// DIRB08.
        /// </summary>
        public const string DIRB08 = "DIRB08";

        /// <summary>
        /// DIRB09.
        /// </summary>
        public const string DIRB09 = "DIRB09";

        /// <summary>
        /// DIRB10.
        /// </summary>
        public const string DIRB10 = "DIRB10";

        /// <summary>
        /// DIUSER.
        /// </summary>
        public const string DIUSER = "DIUSER";

        /// <summary>
        /// DIPID.
        /// </summary>
        public const string DIPID = "DIPID";

        /// <summary>
        /// DIUPMJ.
        /// </summary>
        public const string DIUPMJ = "DIUPMJ";

        /// <summary>
        /// DIJOBN.
        /// </summary>
        public const string DIJOBN = "DIJOBN";

        /// <summary>
        /// DICRFC.
        /// </summary>
        public const string DICRFC = "DICRFC";

        /// <summary>
        /// DIUPMT.
        /// </summary>
        public const string DIUPMT = "DIUPMT";

        /// <summary>
        /// DISBLI.
        /// </summary>
        public const string DISBLI = "DISBLI";
    }

    /// <inheritdoc />
    public override string TableName => "F5301";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DICONO", "DICONO", JdeDataType.Numeric, null, true, true),
        new JdeField("DIMCU", "DIMCU", JdeDataType.String, 24, true, true),
        new JdeField("DIDL01", "DIDL01", JdeDataType.String, 60),
        new JdeField("DIRMK", "DIRMK", JdeDataType.String, 60),
        new JdeField("DICREF", "DICREF", JdeDataType.String, 50),
        new JdeField("DICRF2", "DICRF2", JdeDataType.String, 20),
        new JdeField("DICRF3", "DICRF3", JdeDataType.String, 24),
        new JdeField("DIAREQ", "DIAREQ", JdeDataType.Numeric),
        new JdeField("DIANO", "DIANO", JdeDataType.Numeric),
        new JdeField("DIAPRV", "DIAPRV", JdeDataType.Numeric),
        new JdeField("DIAN8V", "DIAN8V", JdeDataType.Numeric),
        new JdeField("DIBSTC", "DIBSTC", JdeDataType.String, 2),
        new JdeField("DIPRTC", "DIPRTC", JdeDataType.String, 2),
        new JdeField("DITYPB", "DITYPB", JdeDataType.String, 2),
        new JdeField("DIREQB", "DIREQB", JdeDataType.Numeric),
        new JdeField("DIRQBD", "DIRQBD", JdeDataType.Numeric),
        new JdeField("DIOREQ", "DIOREQ", JdeDataType.String, 2),
        new JdeField("DISUB", "DISUB", JdeDataType.String, 16),
        new JdeField("DIPONO", "DIPONO", JdeDataType.Numeric),
        new JdeField("DIDRQJ", "DIDRQJ", JdeDataType.Numeric),
        new JdeField("DIAPRD", "DIAPRD", JdeDataType.Numeric),
        new JdeField("DIPNST", "DIPNST", JdeDataType.Numeric),
        new JdeField("DIPNFN", "DIPNFN", JdeDataType.Numeric),
        new JdeField("DIUDT1", "DIUDT1", JdeDataType.Numeric),
        new JdeField("DIUDT2", "DIUDT2", JdeDataType.Numeric),
        new JdeField("DIUDT3", "DIUDT3", JdeDataType.Numeric),
        new JdeField("DIRB01", "DIRB01", JdeDataType.String, 6),
        new JdeField("DIRB02", "DIRB02", JdeDataType.String, 6),
        new JdeField("DIRB03", "DIRB03", JdeDataType.String, 6),
        new JdeField("DIRB04", "DIRB04", JdeDataType.String, 6),
        new JdeField("DIRB05", "DIRB05", JdeDataType.String, 6),
        new JdeField("DIRB06", "DIRB06", JdeDataType.String, 6),
        new JdeField("DIRB07", "DIRB07", JdeDataType.String, 6),
        new JdeField("DIRB08", "DIRB08", JdeDataType.String, 6),
        new JdeField("DIRB09", "DIRB09", JdeDataType.String, 6),
        new JdeField("DIRB10", "DIRB10", JdeDataType.String, 6),
        new JdeField("DIUSER", "DIUSER", JdeDataType.String, 20),
        new JdeField("DIPID", "DIPID", JdeDataType.String, 20),
        new JdeField("DIUPMJ", "DIUPMJ", JdeDataType.Numeric),
        new JdeField("DIJOBN", "DIJOBN", JdeDataType.String, 20),
        new JdeField("DICRFC", "DICRFC", JdeDataType.String, 40),
        new JdeField("DIUPMT", "DIUPMT", JdeDataType.Numeric),
        new JdeField("DISBLI", "DISBLI", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5301_0", "Primary Key on DIMCU, DICONO", new[] { "DIMCU", "DICONO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F5301_4", "Index on DIMCU, DICONO, DITYPB, DIPRTC", new[] { "DIMCU", "DICONO", "DITYPB", "DIPRTC" }),
        new JdeIndex("F5301_5", "Index on DIANO, DICONO, DIBSTC, DIPRTC", new[] { "DIANO", "DICONO", "DIBSTC", "DIPRTC" }),
        new JdeIndex("F5301_6", "Index on DICRFC, DICONO, DIBSTC, DIPRTC", new[] { "DICRFC", "DICONO", "DIBSTC", "DIPRTC" }),
        new JdeIndex("F5301_7", "Index on DIAPRV, DICONO, DIBSTC, DIPRTC", new[] { "DIAPRV", "DICONO", "DIBSTC", "DIPRTC" }),
        new JdeIndex("F5301_8", "Index on DICRF3, DICONO, DIBSTC, DIPRTC", new[] { "DICRF3", "DICONO", "DIBSTC", "DIPRTC" })
    };
}
