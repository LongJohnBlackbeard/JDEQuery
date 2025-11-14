using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A14 - .
/// </summary>
public class F79A14 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EWJOBS.
        /// </summary>
        public const string EWJOBS = "EWJOBS";

        /// <summary>
        /// EWUKID.
        /// </summary>
        public const string EWUKID = "EWUKID";

        /// <summary>
        /// EWDTAI.
        /// </summary>
        public const string EWDTAI = "EWDTAI";
    }

    /// <inheritdoc />
    public override string TableName => "F79A14";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EWJOBS", "EWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("EWUKID", "EWUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("EWDTAI", "EWDTAI", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A14_0", "Primary Key on EWJOBS, EWUKID", new[] { "EWJOBS", "EWUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
