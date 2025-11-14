using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I4074 - .
/// </summary>
public class F75I4074 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ALDOCO.
        /// </summary>
        public const string ALDOCO = "ALDOCO";

        /// <summary>
        /// ALDCTO.
        /// </summary>
        public const string ALDCTO = "ALDCTO";

        /// <summary>
        /// ALKCOO.
        /// </summary>
        public const string ALKCOO = "ALKCOO";

        /// <summary>
        /// ALSFXO.
        /// </summary>
        public const string ALSFXO = "ALSFXO";

        /// <summary>
        /// ALLNID.
        /// </summary>
        public const string ALLNID = "ALLNID";

        /// <summary>
        /// ALAKID.
        /// </summary>
        public const string ALAKID = "ALAKID";

        /// <summary>
        /// ALSRCFD.
        /// </summary>
        public const string ALSRCFD = "ALSRCFD";

        /// <summary>
        /// ALOSEQ.
        /// </summary>
        public const string ALOSEQ = "ALOSEQ";

        /// <summary>
        /// ALSUBSEQ.
        /// </summary>
        public const string ALSUBSEQ = "ALSUBSEQ";

        /// <summary>
        /// ALTIER.
        /// </summary>
        public const string ALTIER = "ALTIER";

        /// <summary>
        /// ALPA04.
        /// </summary>
        public const string ALPA04 = "ALPA04";

        /// <summary>
        /// ALRAMT.
        /// </summary>
        public const string ALRAMT = "ALRAMT";

        /// <summary>
        /// ALCRCD.
        /// </summary>
        public const string ALCRCD = "ALCRCD";

        /// <summary>
        /// ALACR.
        /// </summary>
        public const string ALACR = "ALACR";

        /// <summary>
        /// ALI75TXRG.
        /// </summary>
        public const string ALI75TXRG = "ALI75TXRG";

        /// <summary>
        /// ALI75TXTY.
        /// </summary>
        public const string ALI75TXTY = "ALI75TXTY";

        /// <summary>
        /// ALUSER.
        /// </summary>
        public const string ALUSER = "ALUSER";

        /// <summary>
        /// ALUPMJ.
        /// </summary>
        public const string ALUPMJ = "ALUPMJ";

        /// <summary>
        /// ALPID.
        /// </summary>
        public const string ALPID = "ALPID";

        /// <summary>
        /// ALJOBN.
        /// </summary>
        public const string ALJOBN = "ALJOBN";

        /// <summary>
        /// ALUPMT.
        /// </summary>
        public const string ALUPMT = "ALUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I4074";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ALDOCO", "ALDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ALDCTO", "ALDCTO", JdeDataType.String, 4, true, true),
        new JdeField("ALKCOO", "ALKCOO", JdeDataType.String, 10, true, true),
        new JdeField("ALSFXO", "ALSFXO", JdeDataType.String, 6, true, true),
        new JdeField("ALLNID", "ALLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ALAKID", "ALAKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ALSRCFD", "ALSRCFD", JdeDataType.String, 4, true, true),
        new JdeField("ALOSEQ", "ALOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ALSUBSEQ", "ALSUBSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ALTIER", "ALTIER", JdeDataType.Numeric, null, true, true),
        new JdeField("ALPA04", "ALPA04", JdeDataType.String, 2, true, true),
        new JdeField("ALRAMT", "ALRAMT", JdeDataType.Numeric),
        new JdeField("ALCRCD", "ALCRCD", JdeDataType.String, 6),
        new JdeField("ALACR", "ALACR", JdeDataType.Numeric),
        new JdeField("ALI75TXRG", "ALI75TXRG", JdeDataType.String, 10),
        new JdeField("ALI75TXTY", "ALI75TXTY", JdeDataType.String, 10),
        new JdeField("ALUSER", "ALUSER", JdeDataType.String, 20),
        new JdeField("ALUPMJ", "ALUPMJ", JdeDataType.Numeric),
        new JdeField("ALPID", "ALPID", JdeDataType.String, 20),
        new JdeField("ALJOBN", "ALJOBN", JdeDataType.String, 20),
        new JdeField("ALUPMT", "ALUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I4074_0", "Primary Key on ALDOCO, ALDCTO, ALKCOO, ALSFXO, ALLNID, ALAKID, ALSRCFD, ALOSEQ, ALSUBSEQ, ALTIER, ALPA04", new[] { "ALDOCO", "ALDCTO", "ALKCOO", "ALSFXO", "ALLNID", "ALAKID", "ALSRCFD", "ALOSEQ", "ALSUBSEQ", "ALTIER", "ALPA04" }, isUnique: true, isPrimaryKey: true)
    };
}
