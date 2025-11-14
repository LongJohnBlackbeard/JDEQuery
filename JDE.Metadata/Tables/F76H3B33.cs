using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H3B33 - .
/// </summary>
public class F76H3B33 : JdeTable
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
        /// PIH76ITXB.
        /// </summary>
        public const string PIH76ITXB = "PIH76ITXB";

        /// <summary>
        /// PIRMK.
        /// </summary>
        public const string PIRMK = "PIRMK";

        /// <summary>
        /// PICRCD.
        /// </summary>
        public const string PICRCD = "PICRCD";

        /// <summary>
        /// PIAEXP.
        /// </summary>
        public const string PIAEXP = "PIAEXP";
    }

    /// <inheritdoc />
    public override string TableName => "F76H3B33";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PIKCO", "PIKCO", JdeDataType.String, 10, true, true),
        new JdeField("PIDCT", "PIDCT", JdeDataType.String, 4, true, true),
        new JdeField("PIDOC", "PIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PIH76ITXB", "PIH76ITXB", JdeDataType.Numeric, null, true, true),
        new JdeField("PIRMK", "PIRMK", JdeDataType.String, 60),
        new JdeField("PICRCD", "PICRCD", JdeDataType.String, 6),
        new JdeField("PIAEXP", "PIAEXP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H3B33_0", "Primary Key on PIKCO, PIDCT, PIDOC, PIH76ITXB", new[] { "PIKCO", "PIDCT", "PIDOC", "PIH76ITXB" }, isUnique: true, isPrimaryKey: true)
    };
}
