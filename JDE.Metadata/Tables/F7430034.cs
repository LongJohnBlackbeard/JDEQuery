using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7430034 - .
/// </summary>
public class F7430034 : JdeTable
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
        /// PIK74TXTY.
        /// </summary>
        public const string PIK74TXTY = "PIK74TXTY";

        /// <summary>
        /// PIMGTX.
        /// </summary>
        public const string PIMGTX = "PIMGTX";

        /// <summary>
        /// PIK74PN.
        /// </summary>
        public const string PIK74PN = "PIK74PN";
    }

    /// <inheritdoc />
    public override string TableName => "F7430034";

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
        new JdeField("PIK74TXTY", "PIK74TXTY", JdeDataType.String, 6),
        new JdeField("PIMGTX", "PIMGTX", JdeDataType.String, 400),
        new JdeField("PIK74PN", "PIK74PN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7430034_0", "Primary Key on PIKCO, PIDCT, PIDOC, PISEQ, PILNID", new[] { "PIKCO", "PIDCT", "PIDOC", "PISEQ", "PILNID" }, isUnique: true, isPrimaryKey: true)
    };
}
