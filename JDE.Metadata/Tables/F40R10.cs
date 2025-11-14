using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40R10 - .
/// </summary>
public class F40R10 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DHUKID.
        /// </summary>
        public const string DHUKID = "DHUKID";

        /// <summary>
        /// DHMCU.
        /// </summary>
        public const string DHMCU = "DHMCU";

        /// <summary>
        /// DHAN8.
        /// </summary>
        public const string DHAN8 = "DHAN8";

        /// <summary>
        /// DHSHAN.
        /// </summary>
        public const string DHSHAN = "DHSHAN";

        /// <summary>
        /// DHITM.
        /// </summary>
        public const string DHITM = "DHITM";

        /// <summary>
        /// DHLITM.
        /// </summary>
        public const string DHLITM = "DHLITM";

        /// <summary>
        /// DHAITM.
        /// </summary>
        public const string DHAITM = "DHAITM";

        /// <summary>
        /// DHDFTCSTPO.
        /// </summary>
        public const string DHDFTCSTPO = "DHDFTCSTPO";

        /// <summary>
        /// DHDFTITMRV.
        /// </summary>
        public const string DHDFTITMRV = "DHDFTITMRV";

        /// <summary>
        /// DHDBT.
        /// </summary>
        public const string DHDBT = "DHDBT";

        /// <summary>
        /// DHDMDBTHNO.
        /// </summary>
        public const string DHDMDBTHNO = "DHDMDBTHNO";

        /// <summary>
        /// DHLCRCVDJ.
        /// </summary>
        public const string DHLCRCVDJ = "DHLCRCVDJ";

        /// <summary>
        /// DHLCRCVQTY.
        /// </summary>
        public const string DHLCRCVQTY = "DHLCRCVQTY";

        /// <summary>
        /// DHLCRCVTM.
        /// </summary>
        public const string DHLCRCVTM = "DHLCRCVTM";

        /// <summary>
        /// DHLCRCVUOM.
        /// </summary>
        public const string DHLCRCVUOM = "DHLCRCVUOM";

        /// <summary>
        /// DHLCSHPDJ.
        /// </summary>
        public const string DHLCSHPDJ = "DHLCSHPDJ";

        /// <summary>
        /// DHLCSHPTM.
        /// </summary>
        public const string DHLCSHPTM = "DHLCSHPTM";

        /// <summary>
        /// DHLCSHPQTY.
        /// </summary>
        public const string DHLCSHPQTY = "DHLCSHPQTY";

        /// <summary>
        /// DHLCSHPUOM.
        /// </summary>
        public const string DHLCSHPUOM = "DHLCSHPUOM";

        /// <summary>
        /// DHLASTSID.
        /// </summary>
        public const string DHLASTSID = "DHLASTSID";

        /// <summary>
        /// DHRNDSTDPK.
        /// </summary>
        public const string DHRNDSTDPK = "DHRNDSTDPK";

        /// <summary>
        /// DHRDSTDPKP.
        /// </summary>
        public const string DHRDSTDPKP = "DHRDSTDPKP";

        /// <summary>
        /// DHSDID.
        /// </summary>
        public const string DHSDID = "DHSDID";

        /// <summary>
        /// DHVNPART.
        /// </summary>
        public const string DHVNPART = "DHVNPART";

        /// <summary>
        /// DHDMD01.
        /// </summary>
        public const string DHDMD01 = "DHDMD01";

        /// <summary>
        /// DHDMD02.
        /// </summary>
        public const string DHDMD02 = "DHDMD02";

        /// <summary>
        /// DHDMD03.
        /// </summary>
        public const string DHDMD03 = "DHDMD03";

        /// <summary>
        /// DHDMD04.
        /// </summary>
        public const string DHDMD04 = "DHDMD04";

        /// <summary>
        /// DHDMD05.
        /// </summary>
        public const string DHDMD05 = "DHDMD05";

        /// <summary>
        /// DHRAN81.
        /// </summary>
        public const string DHRAN81 = "DHRAN81";

        /// <summary>
        /// DHRAN82.
        /// </summary>
        public const string DHRAN82 = "DHRAN82";

        /// <summary>
        /// DHINVADV.
        /// </summary>
        public const string DHINVADV = "DHINVADV";

        /// <summary>
        /// DHURCD.
        /// </summary>
        public const string DHURCD = "DHURCD";

        /// <summary>
        /// DHURDT.
        /// </summary>
        public const string DHURDT = "DHURDT";

        /// <summary>
        /// DHURAT.
        /// </summary>
        public const string DHURAT = "DHURAT";

        /// <summary>
        /// DHURAB.
        /// </summary>
        public const string DHURAB = "DHURAB";

        /// <summary>
        /// DHURRF.
        /// </summary>
        public const string DHURRF = "DHURRF";

        /// <summary>
        /// DHUSER.
        /// </summary>
        public const string DHUSER = "DHUSER";

        /// <summary>
        /// DHPID.
        /// </summary>
        public const string DHPID = "DHPID";

        /// <summary>
        /// DHJOBN.
        /// </summary>
        public const string DHJOBN = "DHJOBN";

        /// <summary>
        /// DHUPMJ.
        /// </summary>
        public const string DHUPMJ = "DHUPMJ";

        /// <summary>
        /// DHTDAY.
        /// </summary>
        public const string DHTDAY = "DHTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40R10";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DHUKID", "DHUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("DHMCU", "DHMCU", JdeDataType.String, 24),
        new JdeField("DHAN8", "DHAN8", JdeDataType.Numeric),
        new JdeField("DHSHAN", "DHSHAN", JdeDataType.Numeric),
        new JdeField("DHITM", "DHITM", JdeDataType.Numeric),
        new JdeField("DHLITM", "DHLITM", JdeDataType.String, 50),
        new JdeField("DHAITM", "DHAITM", JdeDataType.String, 50),
        new JdeField("DHDFTCSTPO", "DHDFTCSTPO", JdeDataType.String, 60),
        new JdeField("DHDFTITMRV", "DHDFTITMRV", JdeDataType.String, 40),
        new JdeField("DHDBT", "DHDBT", JdeDataType.Numeric),
        new JdeField("DHDMDBTHNO", "DHDMDBTHNO", JdeDataType.Numeric),
        new JdeField("DHLCRCVDJ", "DHLCRCVDJ", JdeDataType.Numeric),
        new JdeField("DHLCRCVQTY", "DHLCRCVQTY", JdeDataType.Numeric),
        new JdeField("DHLCRCVTM", "DHLCRCVTM", JdeDataType.Numeric),
        new JdeField("DHLCRCVUOM", "DHLCRCVUOM", JdeDataType.String, 4),
        new JdeField("DHLCSHPDJ", "DHLCSHPDJ", JdeDataType.Numeric),
        new JdeField("DHLCSHPTM", "DHLCSHPTM", JdeDataType.Numeric),
        new JdeField("DHLCSHPQTY", "DHLCSHPQTY", JdeDataType.Numeric),
        new JdeField("DHLCSHPUOM", "DHLCSHPUOM", JdeDataType.String, 4),
        new JdeField("DHLASTSID", "DHLASTSID", JdeDataType.String, 32),
        new JdeField("DHRNDSTDPK", "DHRNDSTDPK", JdeDataType.String, 2),
        new JdeField("DHRDSTDPKP", "DHRDSTDPKP", JdeDataType.String, 2),
        new JdeField("DHSDID", "DHSDID", JdeDataType.Numeric),
        new JdeField("DHVNPART", "DHVNPART", JdeDataType.String, 60),
        new JdeField("DHDMD01", "DHDMD01", JdeDataType.String, 6),
        new JdeField("DHDMD02", "DHDMD02", JdeDataType.String, 6),
        new JdeField("DHDMD03", "DHDMD03", JdeDataType.String, 6),
        new JdeField("DHDMD04", "DHDMD04", JdeDataType.String, 6),
        new JdeField("DHDMD05", "DHDMD05", JdeDataType.String, 6),
        new JdeField("DHRAN81", "DHRAN81", JdeDataType.Numeric),
        new JdeField("DHRAN82", "DHRAN82", JdeDataType.Numeric),
        new JdeField("DHINVADV", "DHINVADV", JdeDataType.String, 2),
        new JdeField("DHURCD", "DHURCD", JdeDataType.String, 4),
        new JdeField("DHURDT", "DHURDT", JdeDataType.Numeric),
        new JdeField("DHURAT", "DHURAT", JdeDataType.Numeric),
        new JdeField("DHURAB", "DHURAB", JdeDataType.Numeric),
        new JdeField("DHURRF", "DHURRF", JdeDataType.String, 30),
        new JdeField("DHUSER", "DHUSER", JdeDataType.String, 20),
        new JdeField("DHPID", "DHPID", JdeDataType.String, 20),
        new JdeField("DHJOBN", "DHJOBN", JdeDataType.String, 20),
        new JdeField("DHUPMJ", "DHUPMJ", JdeDataType.Numeric),
        new JdeField("DHTDAY", "DHTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40R10_0", "Primary Key on DHUKID", new[] { "DHUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40R10_2", "Unique Index on DHMCU, DHAN8, DHSHAN, DHITM", new[] { "DHMCU", "DHAN8", "DHSHAN", "DHITM" }, isUnique: true),
        new JdeIndex("F40R10_3", "Index on DHDMDBTHNO", new[] { "DHDMDBTHNO" }),
        new JdeIndex("F40R10_4", "Index on DHSDID", new[] { "DHSDID" })
    };
}
