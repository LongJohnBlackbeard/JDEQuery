using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H3B37 - .
/// </summary>
public class F76H3B37 : JdeTable
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
        /// PICRCD.
        /// </summary>
        public const string PICRCD = "PICRCD";

        /// <summary>
        /// PIRMK.
        /// </summary>
        public const string PIRMK = "PIRMK";

        /// <summary>
        /// PIAA.
        /// </summary>
        public const string PIAA = "PIAA";
    }

    /// <inheritdoc />
    public override string TableName => "F76H3B37";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PIKCO", "PIKCO", JdeDataType.String, 10, true, true),
        new JdeField("PIDCT", "PIDCT", JdeDataType.String, 4, true, true),
        new JdeField("PIDOC", "PIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PISEQ", "PISEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PICRCD", "PICRCD", JdeDataType.String, 6),
        new JdeField("PIRMK", "PIRMK", JdeDataType.String, 60),
        new JdeField("PIAA", "PIAA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H3B37_0", "Primary Key on PIKCO, PIDCT, PIDOC, PISEQ", new[] { "PIKCO", "PIDCT", "PIDOC", "PISEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
