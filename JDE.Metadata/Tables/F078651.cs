using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F078651 - .
/// </summary>
public class F078651 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RMW2RM.
        /// </summary>
        public const string RMW2RM = "RMW2RM";

        /// <summary>
        /// RMUKID.
        /// </summary>
        public const string RMUKID = "RMUKID";

        /// <summary>
        /// RMIDYE.
        /// </summary>
        public const string RMIDYE = "RMIDYE";

        /// <summary>
        /// RMYR.
        /// </summary>
        public const string RMYR = "RMYR";
    }

    /// <inheritdoc />
    public override string TableName => "F078651";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RMW2RM", "RMW2RM", JdeDataType.String, 1024),
        new JdeField("RMUKID", "RMUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("RMIDYE", "RMIDYE", JdeDataType.String, 20, true, true),
        new JdeField("RMYR", "RMYR", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F078651_0", "Primary Key on RMUKID, RMIDYE, RMYR", new[] { "RMUKID", "RMIDYE", "RMYR" }, isUnique: true, isPrimaryKey: true)
    };
}
