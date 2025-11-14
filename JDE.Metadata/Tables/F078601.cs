using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F078601 - .
/// </summary>
public class F078601 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RFW2RF.
        /// </summary>
        public const string RFW2RF = "RFW2RF";

        /// <summary>
        /// RFUKID.
        /// </summary>
        public const string RFUKID = "RFUKID";

        /// <summary>
        /// RFIDYE.
        /// </summary>
        public const string RFIDYE = "RFIDYE";

        /// <summary>
        /// RFDTEY.
        /// </summary>
        public const string RFDTEY = "RFDTEY";
    }

    /// <inheritdoc />
    public override string TableName => "F078601";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RFW2RF", "RFW2RF", JdeDataType.String, 550),
        new JdeField("RFUKID", "RFUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("RFIDYE", "RFIDYE", JdeDataType.String, 20, true, true),
        new JdeField("RFDTEY", "RFDTEY", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F078601_0", "Primary Key on RFUKID, RFIDYE, RFDTEY", new[] { "RFUKID", "RFIDYE", "RFDTEY" }, isUnique: true, isPrimaryKey: true)
    };
}
