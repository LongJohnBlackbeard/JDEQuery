using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H3B35 - .
/// </summary>
public class F76H3B35 : JdeTable
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
        /// PIACNT.
        /// </summary>
        public const string PIACNT = "PIACNT";

        /// <summary>
        /// PICRCD.
        /// </summary>
        public const string PICRCD = "PICRCD";

        /// <summary>
        /// PIAST.
        /// </summary>
        public const string PIAST = "PIAST";

        /// <summary>
        /// PIDL01.
        /// </summary>
        public const string PIDL01 = "PIDL01";

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
    }

    /// <inheritdoc />
    public override string TableName => "F76H3B35";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PIKCO", "PIKCO", JdeDataType.String, 10, true, true),
        new JdeField("PIDCT", "PIDCT", JdeDataType.String, 4, true, true),
        new JdeField("PIDOC", "PIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PISEQ", "PISEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PIACNT", "PIACNT", JdeDataType.String, 2),
        new JdeField("PICRCD", "PICRCD", JdeDataType.String, 6),
        new JdeField("PIAST", "PIAST", JdeDataType.String, 16),
        new JdeField("PIDL01", "PIDL01", JdeDataType.String, 60),
        new JdeField("PIUPRC", "PIUPRC", JdeDataType.Numeric),
        new JdeField("PIUOM4", "PIUOM4", JdeDataType.String, 4),
        new JdeField("PIAEXP", "PIAEXP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H3B35_0", "Primary Key on PIKCO, PIDCT, PIDOC, PISEQ", new[] { "PIKCO", "PIDCT", "PIDOC", "PISEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
