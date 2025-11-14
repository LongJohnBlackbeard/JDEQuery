using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7430035 - .
/// </summary>
public class F7430035 : JdeTable
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
        /// PIK74TAXC.
        /// </summary>
        public const string PIK74TAXC = "PIK74TAXC";

        /// <summary>
        /// PICRCD.
        /// </summary>
        public const string PICRCD = "PICRCD";

        /// <summary>
        /// PITXR1.
        /// </summary>
        public const string PITXR1 = "PITXR1";

        /// <summary>
        /// PIAA.
        /// </summary>
        public const string PIAA = "PIAA";
    }

    /// <inheritdoc />
    public override string TableName => "F7430035";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PIKCO", "PIKCO", JdeDataType.String, 10, true, true),
        new JdeField("PIDCT", "PIDCT", JdeDataType.String, 4, true, true),
        new JdeField("PIDOC", "PIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PISEQ", "PISEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PIK74TAXC", "PIK74TAXC", JdeDataType.String, 20, true, true),
        new JdeField("PICRCD", "PICRCD", JdeDataType.String, 6),
        new JdeField("PITXR1", "PITXR1", JdeDataType.Numeric),
        new JdeField("PIAA", "PIAA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7430035_0", "Primary Key on PIKCO, PIDCT, PIDOC, PISEQ, PIK74TAXC", new[] { "PIKCO", "PIDCT", "PIDOC", "PISEQ", "PIK74TAXC" }, isUnique: true, isPrimaryKey: true)
    };
}
