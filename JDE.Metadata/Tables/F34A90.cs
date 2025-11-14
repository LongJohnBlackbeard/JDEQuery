using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34A90 - .
/// </summary>
public class F34A90 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PIKIT.
        /// </summary>
        public const string PIKIT = "PIKIT";

        /// <summary>
        /// PIMMCU.
        /// </summary>
        public const string PIMMCU = "PIMMCU";

        /// <summary>
        /// PIITM.
        /// </summary>
        public const string PIITM = "PIITM";

        /// <summary>
        /// PICMCU.
        /// </summary>
        public const string PICMCU = "PICMCU";

        /// <summary>
        /// PIOPSQ.
        /// </summary>
        public const string PIOPSQ = "PIOPSQ";

        /// <summary>
        /// PIITMR.
        /// </summary>
        public const string PIITMR = "PIITMR";

        /// <summary>
        /// PIWMCU.
        /// </summary>
        public const string PIWMCU = "PIWMCU";

        /// <summary>
        /// PIBQTY.
        /// </summary>
        public const string PIBQTY = "PIBQTY";
    }

    /// <inheritdoc />
    public override string TableName => "F34A90";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PIKIT", "PIKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("PIMMCU", "PIMMCU", JdeDataType.String, 24, true, true),
        new JdeField("PIITM", "PIITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PICMCU", "PICMCU", JdeDataType.String, 24, true, true),
        new JdeField("PIOPSQ", "PIOPSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PIITMR", "PIITMR", JdeDataType.Numeric, null, true, true),
        new JdeField("PIWMCU", "PIWMCU", JdeDataType.String, 24, true, true),
        new JdeField("PIBQTY", "PIBQTY", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34A90_0", "Primary Key on PIKIT, PIMMCU, PIITM, PICMCU, PIOPSQ, PIITMR, PIWMCU, PIBQTY", new[] { "PIKIT", "PIMMCU", "PIITM", "PICMCU", "PIOPSQ", "PIITMR", "PIWMCU", "PIBQTY" }, isUnique: true, isPrimaryKey: true)
    };
}
