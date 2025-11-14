using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74ZUI02 - .
/// </summary>
public class F74ZUI02 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CZITM.
        /// </summary>
        public const string CZITM = "CZITM";

        /// <summary>
        /// CZTXA1.
        /// </summary>
        public const string CZTXA1 = "CZTXA1";

        /// <summary>
        /// CZTXR1.
        /// </summary>
        public const string CZTXR1 = "CZTXR1";

        /// <summary>
        /// CZAG.
        /// </summary>
        public const string CZAG = "CZAG";

        /// <summary>
        /// CZATXA.
        /// </summary>
        public const string CZATXA = "CZATXA";

        /// <summary>
        /// CZSTAM.
        /// </summary>
        public const string CZSTAM = "CZSTAM";

        /// <summary>
        /// CZATXN.
        /// </summary>
        public const string CZATXN = "CZATXN";

        /// <summary>
        /// CZCO.
        /// </summary>
        public const string CZCO = "CZCO";

        /// <summary>
        /// CZDOCO.
        /// </summary>
        public const string CZDOCO = "CZDOCO";

        /// <summary>
        /// CZDCTO.
        /// </summary>
        public const string CZDCTO = "CZDCTO";

        /// <summary>
        /// CZSFXO.
        /// </summary>
        public const string CZSFXO = "CZSFXO";

        /// <summary>
        /// CZLNID.
        /// </summary>
        public const string CZLNID = "CZLNID";

        /// <summary>
        /// CZDGJ.
        /// </summary>
        public const string CZDGJ = "CZDGJ";

        /// <summary>
        /// CZDSVJ.
        /// </summary>
        public const string CZDSVJ = "CZDSVJ";

        /// <summary>
        /// CZAN8.
        /// </summary>
        public const string CZAN8 = "CZAN8";

        /// <summary>
        /// CZJOBS.
        /// </summary>
        public const string CZJOBS = "CZJOBS";

        /// <summary>
        /// CZCTID.
        /// </summary>
        public const string CZCTID = "CZCTID";

        /// <summary>
        /// CZUPMJ.
        /// </summary>
        public const string CZUPMJ = "CZUPMJ";

        /// <summary>
        /// CZUPMT.
        /// </summary>
        public const string CZUPMT = "CZUPMT";

        /// <summary>
        /// CZNHTT.
        /// </summary>
        public const string CZNHTT = "CZNHTT";
    }

    /// <inheritdoc />
    public override string TableName => "F74ZUI02";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CZITM", "CZITM", JdeDataType.Numeric),
        new JdeField("CZTXA1", "CZTXA1", JdeDataType.String, 20, true, true),
        new JdeField("CZTXR1", "CZTXR1", JdeDataType.Numeric),
        new JdeField("CZAG", "CZAG", JdeDataType.Numeric),
        new JdeField("CZATXA", "CZATXA", JdeDataType.Numeric),
        new JdeField("CZSTAM", "CZSTAM", JdeDataType.Numeric),
        new JdeField("CZATXN", "CZATXN", JdeDataType.Numeric),
        new JdeField("CZCO", "CZCO", JdeDataType.String, 10, true, true),
        new JdeField("CZDOCO", "CZDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CZDCTO", "CZDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CZSFXO", "CZSFXO", JdeDataType.String, 6, true, true),
        new JdeField("CZLNID", "CZLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CZDGJ", "CZDGJ", JdeDataType.Numeric),
        new JdeField("CZDSVJ", "CZDSVJ", JdeDataType.Numeric),
        new JdeField("CZAN8", "CZAN8", JdeDataType.Numeric),
        new JdeField("CZJOBS", "CZJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("CZCTID", "CZCTID", JdeDataType.String, 30, true, true),
        new JdeField("CZUPMJ", "CZUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CZUPMT", "CZUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("CZNHTT", "CZNHTT", JdeDataType.String, 2, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74ZUI02_0", "Primary Key on CZCTID, CZJOBS, CZCO, CZDCTO, CZDOCO, CZSFXO, CZLNID, CZUPMJ, CZUPMT, CZTXA1, CZNHTT", new[] { "CZCTID", "CZJOBS", "CZCO", "CZDCTO", "CZDOCO", "CZSFXO", "CZLNID", "CZUPMJ", "CZUPMT", "CZTXA1", "CZNHTT" }, isUnique: true, isPrimaryKey: true)
    };
}
