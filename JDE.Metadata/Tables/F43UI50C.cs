using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43UI50C - .
/// </summary>
public class F43UI50C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WCSEQ.
        /// </summary>
        public const string WCSEQ = "WCSEQ";

        /// <summary>
        /// WCSEQN.
        /// </summary>
        public const string WCSEQN = "WCSEQN";

        /// <summary>
        /// WCDOCO.
        /// </summary>
        public const string WCDOCO = "WCDOCO";

        /// <summary>
        /// WCDCTO.
        /// </summary>
        public const string WCDCTO = "WCDCTO";

        /// <summary>
        /// WCKCOO.
        /// </summary>
        public const string WCKCOO = "WCKCOO";

        /// <summary>
        /// WCSFXO.
        /// </summary>
        public const string WCSFXO = "WCSFXO";

        /// <summary>
        /// WCCUKID.
        /// </summary>
        public const string WCCUKID = "WCCUKID";

        /// <summary>
        /// WCINMG.
        /// </summary>
        public const string WCINMG = "WCINMG";

        /// <summary>
        /// WCURCD.
        /// </summary>
        public const string WCURCD = "WCURCD";

        /// <summary>
        /// WCURDT.
        /// </summary>
        public const string WCURDT = "WCURDT";

        /// <summary>
        /// WCURAT.
        /// </summary>
        public const string WCURAT = "WCURAT";

        /// <summary>
        /// WCURAB.
        /// </summary>
        public const string WCURAB = "WCURAB";

        /// <summary>
        /// WCURRF.
        /// </summary>
        public const string WCURRF = "WCURRF";

        /// <summary>
        /// WCCTID.
        /// </summary>
        public const string WCCTID = "WCCTID";

        /// <summary>
        /// WCTORG.
        /// </summary>
        public const string WCTORG = "WCTORG";

        /// <summary>
        /// WCUSER.
        /// </summary>
        public const string WCUSER = "WCUSER";

        /// <summary>
        /// WCPID.
        /// </summary>
        public const string WCPID = "WCPID";

        /// <summary>
        /// WCJOBN.
        /// </summary>
        public const string WCJOBN = "WCJOBN";

        /// <summary>
        /// WCUUPMJ.
        /// </summary>
        public const string WCUUPMJ = "WCUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F43UI50C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WCSEQ", "WCSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("WCSEQN", "WCSEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("WCDOCO", "WCDOCO", JdeDataType.Numeric),
        new JdeField("WCDCTO", "WCDCTO", JdeDataType.String, 4),
        new JdeField("WCKCOO", "WCKCOO", JdeDataType.String, 10),
        new JdeField("WCSFXO", "WCSFXO", JdeDataType.String, 6),
        new JdeField("WCCUKID", "WCCUKID", JdeDataType.Numeric),
        new JdeField("WCINMG", "WCINMG", JdeDataType.String, 20),
        new JdeField("WCURCD", "WCURCD", JdeDataType.String, 4),
        new JdeField("WCURDT", "WCURDT", JdeDataType.Numeric),
        new JdeField("WCURAT", "WCURAT", JdeDataType.Numeric),
        new JdeField("WCURAB", "WCURAB", JdeDataType.Numeric),
        new JdeField("WCURRF", "WCURRF", JdeDataType.String, 30),
        new JdeField("WCCTID", "WCCTID", JdeDataType.String, 30, true, true),
        new JdeField("WCTORG", "WCTORG", JdeDataType.String, 20),
        new JdeField("WCUSER", "WCUSER", JdeDataType.String, 20),
        new JdeField("WCPID", "WCPID", JdeDataType.String, 20),
        new JdeField("WCJOBN", "WCJOBN", JdeDataType.String, 20, true, true),
        new JdeField("WCUUPMJ", "WCUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43UI50C_0", "Primary Key on WCJOBN, WCCTID, WCSEQ, WCSEQN", new[] { "WCJOBN", "WCCTID", "WCSEQ", "WCSEQN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43UI50C_2", "Index on WCCUKID, WCSEQN", new[] { "WCCUKID", "WCSEQN" })
    };
}
