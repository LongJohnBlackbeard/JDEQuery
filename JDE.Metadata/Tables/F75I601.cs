using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I601 - .
/// </summary>
public class F75I601 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TRDOCO.
        /// </summary>
        public const string TRDOCO = "TRDOCO";

        /// <summary>
        /// TRKCOO.
        /// </summary>
        public const string TRKCOO = "TRKCOO";

        /// <summary>
        /// TRLNID.
        /// </summary>
        public const string TRLNID = "TRLNID";

        /// <summary>
        /// TRI75TTN.
        /// </summary>
        public const string TRI75TTN = "TRI75TTN";

        /// <summary>
        /// TRDCTO.
        /// </summary>
        public const string TRDCTO = "TRDCTO";

        /// <summary>
        /// TRAEXP.
        /// </summary>
        public const string TRAEXP = "TRAEXP";

        /// <summary>
        /// TRI75TTR.
        /// </summary>
        public const string TRI75TTR = "TRI75TTR";

        /// <summary>
        /// TRI75TOT.
        /// </summary>
        public const string TRI75TOT = "TRI75TOT";

        /// <summary>
        /// TRCUSTSUP.
        /// </summary>
        public const string TRCUSTSUP = "TRCUSTSUP";

        /// <summary>
        /// TRAVCO.
        /// </summary>
        public const string TRAVCO = "TRAVCO";

        /// <summary>
        /// TRCO.
        /// </summary>
        public const string TRCO = "TRCO";

        /// <summary>
        /// TRDCT.
        /// </summary>
        public const string TRDCT = "TRDCT";

        /// <summary>
        /// TRDGL.
        /// </summary>
        public const string TRDGL = "TRDGL";

        /// <summary>
        /// TRLITM.
        /// </summary>
        public const string TRLITM = "TRLITM";

        /// <summary>
        /// TRDOC.
        /// </summary>
        public const string TRDOC = "TRDOC";

        /// <summary>
        /// TRIVD.
        /// </summary>
        public const string TRIVD = "TRIVD";

        /// <summary>
        /// TRJOBN.
        /// </summary>
        public const string TRJOBN = "TRJOBN";

        /// <summary>
        /// TRKCO.
        /// </summary>
        public const string TRKCO = "TRKCO";

        /// <summary>
        /// TRMCU.
        /// </summary>
        public const string TRMCU = "TRMCU";

        /// <summary>
        /// TRPID.
        /// </summary>
        public const string TRPID = "TRPID";

        /// <summary>
        /// TRSOQS.
        /// </summary>
        public const string TRSOQS = "TRSOQS";

        /// <summary>
        /// TRUPMJ.
        /// </summary>
        public const string TRUPMJ = "TRUPMJ";

        /// <summary>
        /// TRUPMT.
        /// </summary>
        public const string TRUPMT = "TRUPMT";

        /// <summary>
        /// TRUPRC.
        /// </summary>
        public const string TRUPRC = "TRUPRC";

        /// <summary>
        /// TRUSER.
        /// </summary>
        public const string TRUSER = "TRUSER";

        /// <summary>
        /// TRI75CHNO.
        /// </summary>
        public const string TRI75CHNO = "TRI75CHNO";

        /// <summary>
        /// TRI75PYD.
        /// </summary>
        public const string TRI75PYD = "TRI75PYD";

        /// <summary>
        /// TRI75VNBR.
        /// </summary>
        public const string TRI75VNBR = "TRI75VNBR";

        /// <summary>
        /// TRFLAG.
        /// </summary>
        public const string TRFLAG = "TRFLAG";

        /// <summary>
        /// TRAID2.
        /// </summary>
        public const string TRAID2 = "TRAID2";

        /// <summary>
        /// TRVINV.
        /// </summary>
        public const string TRVINV = "TRVINV";

        /// <summary>
        /// TREV01.
        /// </summary>
        public const string TREV01 = "TREV01";

        /// <summary>
        /// TRAN8V.
        /// </summary>
        public const string TRAN8V = "TRAN8V";
    }

    /// <inheritdoc />
    public override string TableName => "F75I601";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TRDOCO", "TRDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TRKCOO", "TRKCOO", JdeDataType.String, 10, true, true),
        new JdeField("TRLNID", "TRLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TRI75TTN", "TRI75TTN", JdeDataType.String, 60, true, true),
        new JdeField("TRDCTO", "TRDCTO", JdeDataType.String, 4, true, true),
        new JdeField("TRAEXP", "TRAEXP", JdeDataType.Numeric),
        new JdeField("TRI75TTR", "TRI75TTR", JdeDataType.Numeric),
        new JdeField("TRI75TOT", "TRI75TOT", JdeDataType.Numeric),
        new JdeField("TRCUSTSUP", "TRCUSTSUP", JdeDataType.Numeric),
        new JdeField("TRAVCO", "TRAVCO", JdeDataType.Numeric),
        new JdeField("TRCO", "TRCO", JdeDataType.String, 10),
        new JdeField("TRDCT", "TRDCT", JdeDataType.String, 4),
        new JdeField("TRDGL", "TRDGL", JdeDataType.Numeric),
        new JdeField("TRLITM", "TRLITM", JdeDataType.String, 50),
        new JdeField("TRDOC", "TRDOC", JdeDataType.Numeric),
        new JdeField("TRIVD", "TRIVD", JdeDataType.Numeric),
        new JdeField("TRJOBN", "TRJOBN", JdeDataType.String, 20),
        new JdeField("TRKCO", "TRKCO", JdeDataType.String, 10),
        new JdeField("TRMCU", "TRMCU", JdeDataType.String, 24),
        new JdeField("TRPID", "TRPID", JdeDataType.String, 20),
        new JdeField("TRSOQS", "TRSOQS", JdeDataType.Numeric),
        new JdeField("TRUPMJ", "TRUPMJ", JdeDataType.Numeric),
        new JdeField("TRUPMT", "TRUPMT", JdeDataType.Numeric),
        new JdeField("TRUPRC", "TRUPRC", JdeDataType.Numeric),
        new JdeField("TRUSER", "TRUSER", JdeDataType.String, 20),
        new JdeField("TRI75CHNO", "TRI75CHNO", JdeDataType.String, 120),
        new JdeField("TRI75PYD", "TRI75PYD", JdeDataType.Numeric),
        new JdeField("TRI75VNBR", "TRI75VNBR", JdeDataType.Numeric),
        new JdeField("TRFLAG", "TRFLAG", JdeDataType.String, 2),
        new JdeField("TRAID2", "TRAID2", JdeDataType.String, 16),
        new JdeField("TRVINV", "TRVINV", JdeDataType.String, 50),
        new JdeField("TREV01", "TREV01", JdeDataType.String, 2),
        new JdeField("TRAN8V", "TRAN8V", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I601_0", "Primary Key on TRDOCO, TRKCOO, TRLNID, TRI75TTN, TRDCTO", new[] { "TRDOCO", "TRKCOO", "TRLNID", "TRI75TTN", "TRDCTO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I601_2", "Index on TRUSER, TRJOBN, TRUPMJ, TRUPMT", new[] { "TRUSER", "TRJOBN", "TRUPMJ", "TRUPMT" })
    };
}
