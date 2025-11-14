using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I859 - .
/// </summary>
public class F75I859 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EWUKID.
        /// </summary>
        public const string EWUKID = "EWUKID";

        /// <summary>
        /// EWKCOO.
        /// </summary>
        public const string EWKCOO = "EWKCOO";

        /// <summary>
        /// EWDCTO.
        /// </summary>
        public const string EWDCTO = "EWDCTO";

        /// <summary>
        /// EWDOCO.
        /// </summary>
        public const string EWDOCO = "EWDOCO";

        /// <summary>
        /// EWLNID.
        /// </summary>
        public const string EWLNID = "EWLNID";

        /// <summary>
        /// EWKCO.
        /// </summary>
        public const string EWKCO = "EWKCO";

        /// <summary>
        /// EWDCT.
        /// </summary>
        public const string EWDCT = "EWDCT";

        /// <summary>
        /// EWDOC.
        /// </summary>
        public const string EWDOC = "EWDOC";

        /// <summary>
        /// EWSFX.
        /// </summary>
        public const string EWSFX = "EWSFX";

        /// <summary>
        /// EWI75INVNO.
        /// </summary>
        public const string EWI75INVNO = "EWI75INVNO";

        /// <summary>
        /// EWDGL.
        /// </summary>
        public const string EWDGL = "EWDGL";

        /// <summary>
        /// EWI75GSTNP.
        /// </summary>
        public const string EWI75GSTNP = "EWI75GSTNP";

        /// <summary>
        /// EWI75HSNC.
        /// </summary>
        public const string EWI75HSNC = "EWI75HSNC";

        /// <summary>
        /// EWLITM.
        /// </summary>
        public const string EWLITM = "EWLITM";

        /// <summary>
        /// EWITM.
        /// </summary>
        public const string EWITM = "EWITM";

        /// <summary>
        /// EWI75IRSTR.
        /// </summary>
        public const string EWI75IRSTR = "EWI75IRSTR";

        /// <summary>
        /// EWI75ITDOC.
        /// </summary>
        public const string EWI75ITDOC = "EWI75ITDOC";

        /// <summary>
        /// EWI75IVCNO.
        /// </summary>
        public const string EWI75IVCNO = "EWI75IVCNO";

        /// <summary>
        /// EWI75IPOD.
        /// </summary>
        public const string EWI75IPOD = "EWI75IPOD";

        /// <summary>
        /// EWAG.
        /// </summary>
        public const string EWAG = "EWAG";

        /// <summary>
        /// EWUSER.
        /// </summary>
        public const string EWUSER = "EWUSER";

        /// <summary>
        /// EWPID.
        /// </summary>
        public const string EWPID = "EWPID";

        /// <summary>
        /// EWJOBN.
        /// </summary>
        public const string EWJOBN = "EWJOBN";

        /// <summary>
        /// EWUPMJ.
        /// </summary>
        public const string EWUPMJ = "EWUPMJ";

        /// <summary>
        /// EWUPMT.
        /// </summary>
        public const string EWUPMT = "EWUPMT";

        /// <summary>
        /// EWYFUTDT1.
        /// </summary>
        public const string EWYFUTDT1 = "EWYFUTDT1";

        /// <summary>
        /// EWFUT6.
        /// </summary>
        public const string EWFUT6 = "EWFUT6";

        /// <summary>
        /// EWYT04.
        /// </summary>
        public const string EWYT04 = "EWYT04";

        /// <summary>
        /// EWYFLAG.
        /// </summary>
        public const string EWYFLAG = "EWYFLAG";

        /// <summary>
        /// EWYNUM1.
        /// </summary>
        public const string EWYNUM1 = "EWYNUM1";

        /// <summary>
        /// EWI75IDCNO.
        /// </summary>
        public const string EWI75IDCNO = "EWI75IDCNO";

        /// <summary>
        /// EWI75IDCDT.
        /// </summary>
        public const string EWI75IDCDT = "EWI75IDCDT";

        /// <summary>
        /// EWI75SERAC.
        /// </summary>
        public const string EWI75SERAC = "EWI75SERAC";
    }

    /// <inheritdoc />
    public override string TableName => "F75I859";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EWUKID", "EWUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("EWKCOO", "EWKCOO", JdeDataType.String, 10),
        new JdeField("EWDCTO", "EWDCTO", JdeDataType.String, 4),
        new JdeField("EWDOCO", "EWDOCO", JdeDataType.Numeric),
        new JdeField("EWLNID", "EWLNID", JdeDataType.Numeric),
        new JdeField("EWKCO", "EWKCO", JdeDataType.String, 10),
        new JdeField("EWDCT", "EWDCT", JdeDataType.String, 4),
        new JdeField("EWDOC", "EWDOC", JdeDataType.Numeric),
        new JdeField("EWSFX", "EWSFX", JdeDataType.String, 6),
        new JdeField("EWI75INVNO", "EWI75INVNO", JdeDataType.String, 50),
        new JdeField("EWDGL", "EWDGL", JdeDataType.Numeric),
        new JdeField("EWI75GSTNP", "EWI75GSTNP", JdeDataType.String, 50),
        new JdeField("EWI75HSNC", "EWI75HSNC", JdeDataType.String, 40),
        new JdeField("EWLITM", "EWLITM", JdeDataType.String, 50),
        new JdeField("EWITM", "EWITM", JdeDataType.Numeric),
        new JdeField("EWI75IRSTR", "EWI75IRSTR", JdeDataType.String, 4),
        new JdeField("EWI75ITDOC", "EWI75ITDOC", JdeDataType.String, 40),
        new JdeField("EWI75IVCNO", "EWI75IVCNO", JdeDataType.String, 40),
        new JdeField("EWI75IPOD", "EWI75IPOD", JdeDataType.String, 24),
        new JdeField("EWAG", "EWAG", JdeDataType.Numeric),
        new JdeField("EWUSER", "EWUSER", JdeDataType.String, 20),
        new JdeField("EWPID", "EWPID", JdeDataType.String, 20),
        new JdeField("EWJOBN", "EWJOBN", JdeDataType.String, 20),
        new JdeField("EWUPMJ", "EWUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("EWUPMT", "EWUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("EWYFUTDT1", "EWYFUTDT1", JdeDataType.Numeric),
        new JdeField("EWFUT6", "EWFUT6", JdeDataType.String, 60),
        new JdeField("EWYT04", "EWYT04", JdeDataType.String, 2),
        new JdeField("EWYFLAG", "EWYFLAG", JdeDataType.String, 2),
        new JdeField("EWYNUM1", "EWYNUM1", JdeDataType.Numeric),
        new JdeField("EWI75IDCNO", "EWI75IDCNO", JdeDataType.String, 50),
        new JdeField("EWI75IDCDT", "EWI75IDCDT", JdeDataType.Numeric),
        new JdeField("EWI75SERAC", "EWI75SERAC", JdeDataType.String, 40)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I859_0", "Primary Key on EWUKID, EWUPMJ, EWUPMT", new[] { "EWUKID", "EWUPMJ", "EWUPMT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I859_2", "Index on EWDOC, EWDCT, EWKCO", new[] { "EWDOC", "EWDCT", "EWKCO" })
    };
}
