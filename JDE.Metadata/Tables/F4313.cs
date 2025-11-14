using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4313 - .
/// </summary>
public class F4313 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PFUKID.
        /// </summary>
        public const string PFUKID = "PFUKID";

        /// <summary>
        /// PFDOCO.
        /// </summary>
        public const string PFDOCO = "PFDOCO";

        /// <summary>
        /// PFDCTO.
        /// </summary>
        public const string PFDCTO = "PFDCTO";

        /// <summary>
        /// PFKCOO.
        /// </summary>
        public const string PFKCOO = "PFKCOO";

        /// <summary>
        /// PFSFXO.
        /// </summary>
        public const string PFSFXO = "PFSFXO";

        /// <summary>
        /// PFLNID.
        /// </summary>
        public const string PFLNID = "PFLNID";

        /// <summary>
        /// PFNLIN.
        /// </summary>
        public const string PFNLIN = "PFNLIN";

        /// <summary>
        /// PFAN8.
        /// </summary>
        public const string PFAN8 = "PFAN8";

        /// <summary>
        /// PFVINV.
        /// </summary>
        public const string PFVINV = "PFVINV";

        /// <summary>
        /// PFDI.
        /// </summary>
        public const string PFDI = "PFDI";

        /// <summary>
        /// PFDDJ.
        /// </summary>
        public const string PFDDJ = "PFDDJ";

        /// <summary>
        /// PFPXTR.
        /// </summary>
        public const string PFPXTR = "PFPXTR";

        /// <summary>
        /// PFFLOQ.
        /// </summary>
        public const string PFFLOQ = "PFFLOQ";

        /// <summary>
        /// PFFLOA.
        /// </summary>
        public const string PFFLOA = "PFFLOA";

        /// <summary>
        /// PFFLAQ.
        /// </summary>
        public const string PFFLAQ = "PFFLAQ";

        /// <summary>
        /// PFFLAA.
        /// </summary>
        public const string PFFLAA = "PFFLAA";

        /// <summary>
        /// PFFLRQ.
        /// </summary>
        public const string PFFLRQ = "PFFLRQ";

        /// <summary>
        /// PFFLRA.
        /// </summary>
        public const string PFFLRA = "PFFLRA";

        /// <summary>
        /// PFCRCD.
        /// </summary>
        public const string PFCRCD = "PFCRCD";

        /// <summary>
        /// PFDOC.
        /// </summary>
        public const string PFDOC = "PFDOC";

        /// <summary>
        /// PFDCT.
        /// </summary>
        public const string PFDCT = "PFDCT";

        /// <summary>
        /// PFKCO.
        /// </summary>
        public const string PFKCO = "PFKCO";

        /// <summary>
        /// PFICU.
        /// </summary>
        public const string PFICU = "PFICU";

        /// <summary>
        /// PFICUT.
        /// </summary>
        public const string PFICUT = "PFICUT";

        /// <summary>
        /// PFUOM.
        /// </summary>
        public const string PFUOM = "PFUOM";

        /// <summary>
        /// PFINV01.
        /// </summary>
        public const string PFINV01 = "PFINV01";

        /// <summary>
        /// PFINV02.
        /// </summary>
        public const string PFINV02 = "PFINV02";

        /// <summary>
        /// PFINV03.
        /// </summary>
        public const string PFINV03 = "PFINV03";

        /// <summary>
        /// PFINV04.
        /// </summary>
        public const string PFINV04 = "PFINV04";

        /// <summary>
        /// PFINV05.
        /// </summary>
        public const string PFINV05 = "PFINV05";

        /// <summary>
        /// PFUSER.
        /// </summary>
        public const string PFUSER = "PFUSER";

        /// <summary>
        /// PFAPPV.
        /// </summary>
        public const string PFAPPV = "PFAPPV";

        /// <summary>
        /// PFPID.
        /// </summary>
        public const string PFPID = "PFPID";

        /// <summary>
        /// PFUPMJ.
        /// </summary>
        public const string PFUPMJ = "PFUPMJ";

        /// <summary>
        /// PFTDAY.
        /// </summary>
        public const string PFTDAY = "PFTDAY";

        /// <summary>
        /// PFMKEY.
        /// </summary>
        public const string PFMKEY = "PFMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F4313";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PFUKID", "PFUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("PFDOCO", "PFDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PFDCTO", "PFDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PFKCOO", "PFKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PFSFXO", "PFSFXO", JdeDataType.String, 6, true, true),
        new JdeField("PFLNID", "PFLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PFNLIN", "PFNLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("PFAN8", "PFAN8", JdeDataType.Numeric),
        new JdeField("PFVINV", "PFVINV", JdeDataType.String, 50),
        new JdeField("PFDI", "PFDI", JdeDataType.Numeric),
        new JdeField("PFDDJ", "PFDDJ", JdeDataType.Numeric),
        new JdeField("PFPXTR", "PFPXTR", JdeDataType.String, 6),
        new JdeField("PFFLOQ", "PFFLOQ", JdeDataType.Numeric),
        new JdeField("PFFLOA", "PFFLOA", JdeDataType.Numeric),
        new JdeField("PFFLAQ", "PFFLAQ", JdeDataType.Numeric),
        new JdeField("PFFLAA", "PFFLAA", JdeDataType.Numeric),
        new JdeField("PFFLRQ", "PFFLRQ", JdeDataType.Numeric),
        new JdeField("PFFLRA", "PFFLRA", JdeDataType.Numeric),
        new JdeField("PFCRCD", "PFCRCD", JdeDataType.String, 6),
        new JdeField("PFDOC", "PFDOC", JdeDataType.Numeric),
        new JdeField("PFDCT", "PFDCT", JdeDataType.String, 4),
        new JdeField("PFKCO", "PFKCO", JdeDataType.String, 10),
        new JdeField("PFICU", "PFICU", JdeDataType.Numeric),
        new JdeField("PFICUT", "PFICUT", JdeDataType.String, 4),
        new JdeField("PFUOM", "PFUOM", JdeDataType.String, 4),
        new JdeField("PFINV01", "PFINV01", JdeDataType.String, 2),
        new JdeField("PFINV02", "PFINV02", JdeDataType.String, 60),
        new JdeField("PFINV03", "PFINV03", JdeDataType.Numeric),
        new JdeField("PFINV04", "PFINV04", JdeDataType.Numeric),
        new JdeField("PFINV05", "PFINV05", JdeDataType.Numeric),
        new JdeField("PFUSER", "PFUSER", JdeDataType.String, 20),
        new JdeField("PFAPPV", "PFAPPV", JdeDataType.String, 20),
        new JdeField("PFPID", "PFPID", JdeDataType.String, 20),
        new JdeField("PFUPMJ", "PFUPMJ", JdeDataType.Numeric),
        new JdeField("PFTDAY", "PFTDAY", JdeDataType.Numeric),
        new JdeField("PFMKEY", "PFMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4313_0", "Primary Key on PFUKID, PFDOCO, PFDCTO, PFKCOO, PFSFXO, PFLNID, PFNLIN", new[] { "PFUKID", "PFDOCO", "PFDCTO", "PFKCOO", "PFSFXO", "PFLNID", "PFNLIN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4313_2", "Index on PFDOCO, PFDCTO, PFKCOO, PFSFXO, PFLNID, PFNLIN", new[] { "PFDOCO", "PFDCTO", "PFKCOO", "PFSFXO", "PFLNID", "PFNLIN" }),
        new JdeIndex("F4313_3", "Index on PFAN8", new[] { "PFAN8" }),
        new JdeIndex("F4313_4", "Index on PFVINV, PFDI", new[] { "PFVINV", "PFDI" }),
        new JdeIndex("F4313_5", "Index on PFPXTR", new[] { "PFPXTR" })
    };
}
