using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7420033 - .
/// </summary>
public class F7420033 : JdeTable
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
        /// PIDSC1.
        /// </summary>
        public const string PIDSC1 = "PIDSC1";

        /// <summary>
        /// PIDSC2.
        /// </summary>
        public const string PIDSC2 = "PIDSC2";

        /// <summary>
        /// PILOTN.
        /// </summary>
        public const string PILOTN = "PILOTN";

        /// <summary>
        /// PISOQS.
        /// </summary>
        public const string PISOQS = "PISOQS";

        /// <summary>
        /// PIUOM.
        /// </summary>
        public const string PIUOM = "PIUOM";

        /// <summary>
        /// PICRCD.
        /// </summary>
        public const string PICRCD = "PICRCD";

        /// <summary>
        /// PILPRC.
        /// </summary>
        public const string PILPRC = "PILPRC";

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
        /// PIWTUM.
        /// </summary>
        public const string PIWTUM = "PIWTUM";

        /// <summary>
        /// PIITWT.
        /// </summary>
        public const string PIITWT = "PIITWT";

        /// <summary>
        /// PIVLUM.
        /// </summary>
        public const string PIVLUM = "PIVLUM";

        /// <summary>
        /// PIITVL.
        /// </summary>
        public const string PIITVL = "PIITVL";

        /// <summary>
        /// PITRDJ.
        /// </summary>
        public const string PITRDJ = "PITRDJ";

        /// <summary>
        /// PIADDJ.
        /// </summary>
        public const string PIADDJ = "PIADDJ";
    }

    /// <inheritdoc />
    public override string TableName => "F7420033";

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
        new JdeField("PIDSC1", "PIDSC1", JdeDataType.String, 60),
        new JdeField("PIDSC2", "PIDSC2", JdeDataType.String, 60),
        new JdeField("PILOTN", "PILOTN", JdeDataType.String, 60),
        new JdeField("PISOQS", "PISOQS", JdeDataType.Numeric),
        new JdeField("PIUOM", "PIUOM", JdeDataType.String, 4),
        new JdeField("PICRCD", "PICRCD", JdeDataType.String, 6),
        new JdeField("PILPRC", "PILPRC", JdeDataType.Numeric),
        new JdeField("PIUPRC", "PIUPRC", JdeDataType.Numeric),
        new JdeField("PIUOM4", "PIUOM4", JdeDataType.String, 4),
        new JdeField("PIAEXP", "PIAEXP", JdeDataType.Numeric),
        new JdeField("PITAX1", "PITAX1", JdeDataType.String, 2),
        new JdeField("PIWTUM", "PIWTUM", JdeDataType.String, 4),
        new JdeField("PIITWT", "PIITWT", JdeDataType.Numeric),
        new JdeField("PIVLUM", "PIVLUM", JdeDataType.String, 4),
        new JdeField("PIITVL", "PIITVL", JdeDataType.Numeric),
        new JdeField("PITRDJ", "PITRDJ", JdeDataType.Numeric),
        new JdeField("PIADDJ", "PIADDJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7420033_0", "Primary Key on PIKCO, PIDCT, PIDOC, PISEQ", new[] { "PIKCO", "PIDCT", "PIDOC", "PISEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
