using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1731 - .
/// </summary>
public class F1731 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LQUKID.
        /// </summary>
        public const string LQUKID = "LQUKID";

        /// <summary>
        /// LQTREC.
        /// </summary>
        public const string LQTREC = "LQTREC";

        /// <summary>
        /// LQNUMB.
        /// </summary>
        public const string LQNUMB = "LQNUMB";

        /// <summary>
        /// LQLANO.
        /// </summary>
        public const string LQLANO = "LQLANO";

        /// <summary>
        /// LQAN8.
        /// </summary>
        public const string LQAN8 = "LQAN8";

        /// <summary>
        /// LQLOC.
        /// </summary>
        public const string LQLOC = "LQLOC";

        /// <summary>
        /// LQDOCO.
        /// </summary>
        public const string LQDOCO = "LQDOCO";

        /// <summary>
        /// LQKCO.
        /// </summary>
        public const string LQKCO = "LQKCO";

        /// <summary>
        /// LQDCTO.
        /// </summary>
        public const string LQDCTO = "LQDCTO";

        /// <summary>
        /// LQAL.
        /// </summary>
        public const string LQAL = "LQAL";

        /// <summary>
        /// LQRMK.
        /// </summary>
        public const string LQRMK = "LQRMK";

        /// <summary>
        /// LQEFTB.
        /// </summary>
        public const string LQEFTB = "LQEFTB";

        /// <summary>
        /// LQDDTS.
        /// </summary>
        public const string LQDDTS = "LQDDTS";

        /// <summary>
        /// LQEND.
        /// </summary>
        public const string LQEND = "LQEND";

        /// <summary>
        /// LQDTSO.
        /// </summary>
        public const string LQDTSO = "LQDTSO";

        /// <summary>
        /// LQTRNN.
        /// </summary>
        public const string LQTRNN = "LQTRNN";

        /// <summary>
        /// LQROS.
        /// </summary>
        public const string LQROS = "LQROS";

        /// <summary>
        /// LQURDT.
        /// </summary>
        public const string LQURDT = "LQURDT";

        /// <summary>
        /// LQURCD.
        /// </summary>
        public const string LQURCD = "LQURCD";

        /// <summary>
        /// LQURAB.
        /// </summary>
        public const string LQURAB = "LQURAB";

        /// <summary>
        /// LQURAT.
        /// </summary>
        public const string LQURAT = "LQURAT";

        /// <summary>
        /// LQURRF.
        /// </summary>
        public const string LQURRF = "LQURRF";

        /// <summary>
        /// LQUSER.
        /// </summary>
        public const string LQUSER = "LQUSER";

        /// <summary>
        /// LQLCT.
        /// </summary>
        public const string LQLCT = "LQLCT";

        /// <summary>
        /// LQUPMJ.
        /// </summary>
        public const string LQUPMJ = "LQUPMJ";

        /// <summary>
        /// LQUPMT.
        /// </summary>
        public const string LQUPMT = "LQUPMT";

        /// <summary>
        /// LQJOBN.
        /// </summary>
        public const string LQJOBN = "LQJOBN";

        /// <summary>
        /// LQPID.
        /// </summary>
        public const string LQPID = "LQPID";
    }

    /// <inheritdoc />
    public override string TableName => "F1731";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LQUKID", "LQUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("LQTREC", "LQTREC", JdeDataType.String, 2),
        new JdeField("LQNUMB", "LQNUMB", JdeDataType.Numeric),
        new JdeField("LQLANO", "LQLANO", JdeDataType.Numeric),
        new JdeField("LQAN8", "LQAN8", JdeDataType.Numeric),
        new JdeField("LQLOC", "LQLOC", JdeDataType.String, 24),
        new JdeField("LQDOCO", "LQDOCO", JdeDataType.Numeric),
        new JdeField("LQKCO", "LQKCO", JdeDataType.String, 10),
        new JdeField("LQDCTO", "LQDCTO", JdeDataType.String, 4),
        new JdeField("LQAL", "LQAL", JdeDataType.String, 2),
        new JdeField("LQRMK", "LQRMK", JdeDataType.String, 60),
        new JdeField("LQEFTB", "LQEFTB", JdeDataType.Numeric),
        new JdeField("LQDDTS", "LQDDTS", JdeDataType.Numeric),
        new JdeField("LQEND", "LQEND", JdeDataType.Numeric),
        new JdeField("LQDTSO", "LQDTSO", JdeDataType.Numeric),
        new JdeField("LQTRNN", "LQTRNN", JdeDataType.String, 24),
        new JdeField("LQROS", "LQROS", JdeDataType.String, 2),
        new JdeField("LQURDT", "LQURDT", JdeDataType.Numeric),
        new JdeField("LQURCD", "LQURCD", JdeDataType.String, 4),
        new JdeField("LQURAB", "LQURAB", JdeDataType.Numeric),
        new JdeField("LQURAT", "LQURAT", JdeDataType.Numeric),
        new JdeField("LQURRF", "LQURRF", JdeDataType.String, 30),
        new JdeField("LQUSER", "LQUSER", JdeDataType.String, 20),
        new JdeField("LQLCT", "LQLCT", JdeDataType.Numeric),
        new JdeField("LQUPMJ", "LQUPMJ", JdeDataType.Numeric),
        new JdeField("LQUPMT", "LQUPMT", JdeDataType.Numeric),
        new JdeField("LQJOBN", "LQJOBN", JdeDataType.String, 20),
        new JdeField("LQPID", "LQPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1731_0", "Primary Key on LQUKID", new[] { "LQUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1731_2", "Index on SYS_NC00029$", new[] { "SYS_NC00029$" }),
        new JdeIndex("F1731_3", "Index on LQNUMB, LQTREC, SYS_NC00029$", new[] { "LQNUMB", "LQTREC", "SYS_NC00029$" })
    };
}
