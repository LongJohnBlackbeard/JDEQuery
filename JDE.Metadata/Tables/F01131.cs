using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01131 - .
/// </summary>
public class F01131 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZZSERK.
        /// </summary>
        public const string ZZSERK = "ZZSERK";

        /// <summary>
        /// ZZAN8.
        /// </summary>
        public const string ZZAN8 = "ZZAN8";

        /// <summary>
        /// ZZALPH.
        /// </summary>
        public const string ZZALPH = "ZZALPH";

        /// <summary>
        /// ZZSFRM.
        /// </summary>
        public const string ZZSFRM = "ZZSFRM";

        /// <summary>
        /// ZZCCO.
        /// </summary>
        public const string ZZCCO = "ZZCCO";

        /// <summary>
        /// ZZCPH.
        /// </summary>
        public const string ZZCPH = "ZZCPH";

        /// <summary>
        /// ZZMBDS.
        /// </summary>
        public const string ZZMBDS = "ZZMBDS";

        /// <summary>
        /// ZZDTI.
        /// </summary>
        public const string ZZDTI = "ZZDTI";

        /// <summary>
        /// ZZUPMJ.
        /// </summary>
        public const string ZZUPMJ = "ZZUPMJ";

        /// <summary>
        /// ZZUPMT.
        /// </summary>
        public const string ZZUPMT = "ZZUPMT";

        /// <summary>
        /// ZZJOBN.
        /// </summary>
        public const string ZZJOBN = "ZZJOBN";

        /// <summary>
        /// ZZDSS5.
        /// </summary>
        public const string ZZDSS5 = "ZZDSS5";

        /// <summary>
        /// ZZMSGP.
        /// </summary>
        public const string ZZMSGP = "ZZMSGP";

        /// <summary>
        /// ZZPA8.
        /// </summary>
        public const string ZZPA8 = "ZZPA8";

        /// <summary>
        /// ZZMB01.
        /// </summary>
        public const string ZZMB01 = "ZZMB01";

        /// <summary>
        /// ZZMB02.
        /// </summary>
        public const string ZZMB02 = "ZZMB02";

        /// <summary>
        /// ZZTCNT.
        /// </summary>
        public const string ZZTCNT = "ZZTCNT";

        /// <summary>
        /// ZZCMPR.
        /// </summary>
        public const string ZZCMPR = "ZZCMPR";

        /// <summary>
        /// ZZMSG.
        /// </summary>
        public const string ZZMSG = "ZZMSG";

        /// <summary>
        /// ZZUSER.
        /// </summary>
        public const string ZZUSER = "ZZUSER";

        /// <summary>
        /// ZZPID.
        /// </summary>
        public const string ZZPID = "ZZPID";

        /// <summary>
        /// ZZMSGA.
        /// </summary>
        public const string ZZMSGA = "ZZMSGA";

        /// <summary>
        /// ZZENTT.
        /// </summary>
        public const string ZZENTT = "ZZENTT";

        /// <summary>
        /// ZZSTSM.
        /// </summary>
        public const string ZZSTSM = "ZZSTSM";

        /// <summary>
        /// ZZPXT1.
        /// </summary>
        public const string ZZPXT1 = "ZZPXT1";

        /// <summary>
        /// ZZBASE.
        /// </summary>
        public const string ZZBASE = "ZZBASE";

        /// <summary>
        /// ZZSY.
        /// </summary>
        public const string ZZSY = "ZZSY";

        /// <summary>
        /// ZZDOCO.
        /// </summary>
        public const string ZZDOCO = "ZZDOCO";

        /// <summary>
        /// ZZSFXO.
        /// </summary>
        public const string ZZSFXO = "ZZSFXO";

        /// <summary>
        /// ZZDCTO.
        /// </summary>
        public const string ZZDCTO = "ZZDCTO";

        /// <summary>
        /// ZZLNID.
        /// </summary>
        public const string ZZLNID = "ZZLNID";

        /// <summary>
        /// ZZKCOO.
        /// </summary>
        public const string ZZKCOO = "ZZKCOO";

        /// <summary>
        /// ZZTMPI.
        /// </summary>
        public const string ZZTMPI = "ZZTMPI";

        /// <summary>
        /// ZZAB3.
        /// </summary>
        public const string ZZAB3 = "ZZAB3";

        /// <summary>
        /// ZZLV.
        /// </summary>
        public const string ZZLV = "ZZLV";

        /// <summary>
        /// ZZPSRK.
        /// </summary>
        public const string ZZPSRK = "ZZPSRK";

        /// <summary>
        /// ZZVERS.
        /// </summary>
        public const string ZZVERS = "ZZVERS";

        /// <summary>
        /// ZZTSV.
        /// </summary>
        public const string ZZTSV = "ZZTSV";

        /// <summary>
        /// ZZEAP.
        /// </summary>
        public const string ZZEAP = "ZZEAP";

        /// <summary>
        /// ZZFRMI.
        /// </summary>
        public const string ZZFRMI = "ZZFRMI";
    }

    /// <inheritdoc />
    public override string TableName => "F01131";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZZSERK", "ZZSERK", JdeDataType.Numeric, null, true, true),
        new JdeField("ZZAN8", "ZZAN8", JdeDataType.Numeric),
        new JdeField("ZZALPH", "ZZALPH", JdeDataType.String, 80),
        new JdeField("ZZSFRM", "ZZSFRM", JdeDataType.String, 80),
        new JdeField("ZZCCO", "ZZCCO", JdeDataType.String, 60),
        new JdeField("ZZCPH", "ZZCPH", JdeDataType.String, 40),
        new JdeField("ZZMBDS", "ZZMBDS", JdeDataType.String, 4),
        new JdeField("ZZDTI", "ZZDTI", JdeDataType.Numeric),
        new JdeField("ZZUPMJ", "ZZUPMJ", JdeDataType.Numeric),
        new JdeField("ZZUPMT", "ZZUPMT", JdeDataType.Numeric),
        new JdeField("ZZJOBN", "ZZJOBN", JdeDataType.String, 20),
        new JdeField("ZZDSS5", "ZZDSS5", JdeDataType.Numeric),
        new JdeField("ZZMSGP", "ZZMSGP", JdeDataType.String, 80),
        new JdeField("ZZPA8", "ZZPA8", JdeDataType.Numeric),
        new JdeField("ZZMB01", "ZZMB01", JdeDataType.String, 20),
        new JdeField("ZZMB02", "ZZMB02", JdeDataType.String, 20),
        new JdeField("ZZTCNT", "ZZTCNT", JdeDataType.String, 2),
        new JdeField("ZZCMPR", "ZZCMPR", JdeDataType.String, 2),
        new JdeField("ZZMSG", "ZZMSG", JdeDataType.String, 2),
        new JdeField("ZZUSER", "ZZUSER", JdeDataType.String, 20),
        new JdeField("ZZPID", "ZZPID", JdeDataType.String, 20),
        new JdeField("ZZMSGA", "ZZMSGA", JdeDataType.String, 2),
        new JdeField("ZZENTT", "ZZENTT", JdeDataType.Numeric),
        new JdeField("ZZSTSM", "ZZSTSM", JdeDataType.String, 2),
        new JdeField("ZZPXT1", "ZZPXT1", JdeDataType.String, 10),
        new JdeField("ZZBASE", "ZZBASE", JdeDataType.String, 20),
        new JdeField("ZZSY", "ZZSY", JdeDataType.String, 8),
        new JdeField("ZZDOCO", "ZZDOCO", JdeDataType.Numeric),
        new JdeField("ZZSFXO", "ZZSFXO", JdeDataType.String, 6),
        new JdeField("ZZDCTO", "ZZDCTO", JdeDataType.String, 4),
        new JdeField("ZZLNID", "ZZLNID", JdeDataType.Numeric),
        new JdeField("ZZKCOO", "ZZKCOO", JdeDataType.String, 10),
        new JdeField("ZZTMPI", "ZZTMPI", JdeDataType.String, 20),
        new JdeField("ZZAB3", "ZZAB3", JdeDataType.String, 2),
        new JdeField("ZZLV", "ZZLV", JdeDataType.Numeric),
        new JdeField("ZZPSRK", "ZZPSRK", JdeDataType.Numeric),
        new JdeField("ZZVERS", "ZZVERS", JdeDataType.String, 20),
        new JdeField("ZZTSV", "ZZTSV", JdeDataType.String, 2048),
        new JdeField("ZZEAP", "ZZEAP", JdeDataType.String, 20),
        new JdeField("ZZFRMI", "ZZFRMI", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01131_0", "Primary Key on ZZSERK", new[] { "ZZSERK" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F01131_2", "Index on ZZAN8, ZZMBDS, ZZMSGA, ZZPSRK", new[] { "ZZAN8", "ZZMBDS", "ZZMSGA", "ZZPSRK" }),
        new JdeIndex("F01131_3", "Index on ZZAN8, ZZSERK", new[] { "ZZAN8", "ZZSERK" }),
        new JdeIndex("F01131_4", "Index on ZZPA8, ZZMBDS, ZZSTSM", new[] { "ZZPA8", "ZZMBDS", "ZZSTSM" })
    };
}
