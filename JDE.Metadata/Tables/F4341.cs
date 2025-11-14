using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4341 - .
/// </summary>
public class F4341 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RLAN8.
        /// </summary>
        public const string RLAN8 = "RLAN8";

        /// <summary>
        /// RLAGSQ.
        /// </summary>
        public const string RLAGSQ = "RLAGSQ";

        /// <summary>
        /// RLTAMT.
        /// </summary>
        public const string RLTAMT = "RLTAMT";

        /// <summary>
        /// RLTQTY.
        /// </summary>
        public const string RLTQTY = "RLTQTY";

        /// <summary>
        /// RLREBA.
        /// </summary>
        public const string RLREBA = "RLREBA";

        /// <summary>
        /// RLREBP.
        /// </summary>
        public const string RLREBP = "RLREBP";
    }

    /// <inheritdoc />
    public override string TableName => "F4341";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RLAN8", "RLAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RLAGSQ", "RLAGSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("RLTAMT", "RLTAMT", JdeDataType.Numeric, null, true, true),
        new JdeField("RLTQTY", "RLTQTY", JdeDataType.Numeric, null, true, true),
        new JdeField("RLREBA", "RLREBA", JdeDataType.Numeric),
        new JdeField("RLREBP", "RLREBP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4341_0", "Primary Key on RLAN8, RLAGSQ, RLTAMT, RLTQTY", new[] { "RLAN8", "RLAGSQ", "RLTAMT", "RLTQTY" }, isUnique: true, isPrimaryKey: true)
    };
}
