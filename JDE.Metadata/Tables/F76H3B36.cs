using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H3B36 - .
/// </summary>
public class F76H3B36 : JdeTable
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
        /// PILNID.
        /// </summary>
        public const string PILNID = "PILNID";

        /// <summary>
        /// PIEV02.
        /// </summary>
        public const string PIEV02 = "PIEV02";

        /// <summary>
        /// PIMGTX.
        /// </summary>
        public const string PIMGTX = "PIMGTX";
    }

    /// <inheritdoc />
    public override string TableName => "F76H3B36";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PIKCO", "PIKCO", JdeDataType.String, 10, true, true),
        new JdeField("PIDCT", "PIDCT", JdeDataType.String, 4, true, true),
        new JdeField("PIDOC", "PIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PISEQ", "PISEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PILNID", "PILNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PIEV02", "PIEV02", JdeDataType.String, 2),
        new JdeField("PIMGTX", "PIMGTX", JdeDataType.String, 400)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H3B36_0", "Primary Key on PIKCO, PIDCT, PIDOC, PISEQ, PILNID", new[] { "PIKCO", "PIDCT", "PIDOC", "PISEQ", "PILNID" }, isUnique: true, isPrimaryKey: true)
    };
}
