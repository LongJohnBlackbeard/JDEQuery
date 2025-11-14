using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0113 - .
/// </summary>
public class F0113 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZZAN8.
        /// </summary>
        public const string ZZAN8 = "ZZAN8";

        /// <summary>
        /// ZZALPH.
        /// </summary>
        public const string ZZALPH = "ZZALPH";

        /// <summary>
        /// ZZDTI.
        /// </summary>
        public const string ZZDTI = "ZZDTI";

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
        /// ZZCFRM.
        /// </summary>
        public const string ZZCFRM = "ZZCFRM";

        /// <summary>
        /// ZZCCO.
        /// </summary>
        public const string ZZCCO = "ZZCCO";

        /// <summary>
        /// ZZCPH.
        /// </summary>
        public const string ZZCPH = "ZZCPH";

        /// <summary>
        /// ZZPXT1.
        /// </summary>
        public const string ZZPXT1 = "ZZPXT1";

        /// <summary>
        /// ZZEXPL.
        /// </summary>
        public const string ZZEXPL = "ZZEXPL";

        /// <summary>
        /// ZZMSGA.
        /// </summary>
        public const string ZZMSGA = "ZZMSGA";

        /// <summary>
        /// ZZENTT.
        /// </summary>
        public const string ZZENTT = "ZZENTT";

        /// <summary>
        /// ZZUSER.
        /// </summary>
        public const string ZZUSER = "ZZUSER";

        /// <summary>
        /// ZZPID.
        /// </summary>
        public const string ZZPID = "ZZPID";

        /// <summary>
        /// ZZUPMJ.
        /// </summary>
        public const string ZZUPMJ = "ZZUPMJ";

        /// <summary>
        /// ZZJOBN.
        /// </summary>
        public const string ZZJOBN = "ZZJOBN";

        /// <summary>
        /// ZZUPMT.
        /// </summary>
        public const string ZZUPMT = "ZZUPMT";

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
    }

    /// <inheritdoc />
    public override string TableName => "F0113";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZZAN8", "ZZAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ZZALPH", "ZZALPH", JdeDataType.String, 80),
        new JdeField("ZZDTI", "ZZDTI", JdeDataType.Numeric),
        new JdeField("ZZTCNT", "ZZTCNT", JdeDataType.String, 2),
        new JdeField("ZZCMPR", "ZZCMPR", JdeDataType.String, 2),
        new JdeField("ZZMSG", "ZZMSG", JdeDataType.String, 2),
        new JdeField("ZZCFRM", "ZZCFRM", JdeDataType.String, 60),
        new JdeField("ZZCCO", "ZZCCO", JdeDataType.String, 60),
        new JdeField("ZZCPH", "ZZCPH", JdeDataType.String, 40),
        new JdeField("ZZPXT1", "ZZPXT1", JdeDataType.String, 10),
        new JdeField("ZZEXPL", "ZZEXPL", JdeDataType.String, 2400),
        new JdeField("ZZMSGA", "ZZMSGA", JdeDataType.String, 2),
        new JdeField("ZZENTT", "ZZENTT", JdeDataType.Numeric, null, true, true),
        new JdeField("ZZUSER", "ZZUSER", JdeDataType.String, 20),
        new JdeField("ZZPID", "ZZPID", JdeDataType.String, 20),
        new JdeField("ZZUPMJ", "ZZUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("ZZJOBN", "ZZJOBN", JdeDataType.String, 20),
        new JdeField("ZZUPMT", "ZZUPMT", JdeDataType.Numeric),
        new JdeField("ZZBASE", "ZZBASE", JdeDataType.String, 20),
        new JdeField("ZZSY", "ZZSY", JdeDataType.String, 8),
        new JdeField("ZZDOCO", "ZZDOCO", JdeDataType.Numeric),
        new JdeField("ZZSFXO", "ZZSFXO", JdeDataType.String, 6),
        new JdeField("ZZDCTO", "ZZDCTO", JdeDataType.String, 4),
        new JdeField("ZZLNID", "ZZLNID", JdeDataType.Numeric),
        new JdeField("ZZKCOO", "ZZKCOO", JdeDataType.String, 10)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0113_0", "Primary Key on ZZAN8, ZZUPMJ, ZZENTT", new[] { "ZZAN8", "ZZUPMJ", "ZZENTT" }, isUnique: true, isPrimaryKey: true)
    };
}
