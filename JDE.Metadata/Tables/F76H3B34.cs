using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H3B34 - .
/// </summary>
public class F76H3B34 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PIKCO.
        /// </summary>
        public const string PIKCO = "PIKCO";

        /// <summary>
        /// PIDCT.
        /// </summary>
        public const string PIDCT = "PIDCT";

        /// <summary>
        /// PIDOC.
        /// </summary>
        public const string PIDOC = "PIDOC";

        /// <summary>
        /// PISEQ.
        /// </summary>
        public const string PISEQ = "PISEQ";

        /// <summary>
        /// PIUITM.
        /// </summary>
        public const string PIUITM = "PIUITM";

        /// <summary>
        /// PIITM.
        /// </summary>
        public const string PIITM = "PIITM";

        /// <summary>
        /// PISOQS.
        /// </summary>
        public const string PISOQS = "PISOQS";

        /// <summary>
        /// PIUOM.
        /// </summary>
        public const string PIUOM = "PIUOM";

        /// <summary>
        /// PIDSC1.
        /// </summary>
        public const string PIDSC1 = "PIDSC1";

        /// <summary>
        /// PIDSC2.
        /// </summary>
        public const string PIDSC2 = "PIDSC2";

        /// <summary>
        /// PICRCD.
        /// </summary>
        public const string PICRCD = "PICRCD";

        /// <summary>
        /// PIUPRC.
        /// </summary>
        public const string PIUPRC = "PIUPRC";

        /// <summary>
        /// PIUOM4.
        /// </summary>
        public const string PIUOM4 = "PIUOM4";

        /// <summary>
        /// PIAEXP.
        /// </summary>
        public const string PIAEXP = "PIAEXP";

        /// <summary>
        /// PITAX1.
        /// </summary>
        public const string PITAX1 = "PITAX1";

        /// <summary>
        /// PITRDJ.
        /// </summary>
        public const string PITRDJ = "PITRDJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76H3B34";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PIKCO", "PIKCO", JdeDataType.String, 10, true, true),
        new JdeField("PIDCT", "PIDCT", JdeDataType.String, 4, true, true),
        new JdeField("PIDOC", "PIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PISEQ", "PISEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PIUITM", "PIUITM", JdeDataType.String, 52),
        new JdeField("PIITM", "PIITM", JdeDataType.Numeric),
        new JdeField("PISOQS", "PISOQS", JdeDataType.Numeric),
        new JdeField("PIUOM", "PIUOM", JdeDataType.String, 4),
        new JdeField("PIDSC1", "PIDSC1", JdeDataType.String, 60),
        new JdeField("PIDSC2", "PIDSC2", JdeDataType.String, 60),
        new JdeField("PICRCD", "PICRCD", JdeDataType.String, 6),
        new JdeField("PIUPRC", "PIUPRC", JdeDataType.Numeric),
        new JdeField("PIUOM4", "PIUOM4", JdeDataType.String, 4),
        new JdeField("PIAEXP", "PIAEXP", JdeDataType.Numeric),
        new JdeField("PITAX1", "PITAX1", JdeDataType.String, 2),
        new JdeField("PITRDJ", "PITRDJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H3B34_0", "Primary Key on PIKCO, PIDCT, PIDOC, PISEQ", new[] { "PIKCO", "PIDCT", "PIDOC", "PISEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
