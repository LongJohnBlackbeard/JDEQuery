using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F078652 - .
/// </summary>
public class F078652 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RFW2CRM.
        /// </summary>
        public const string RFW2CRM = "RFW2CRM";

        /// <summary>
        /// RFIDYE.
        /// </summary>
        public const string RFIDYE = "RFIDYE";

        /// <summary>
        /// RFYR.
        /// </summary>
        public const string RFYR = "RFYR";

        /// <summary>
        /// RFUKID.
        /// </summary>
        public const string RFUKID = "RFUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F078652";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RFW2CRM", "RFW2CRM", JdeDataType.String, 2048),
        new JdeField("RFIDYE", "RFIDYE", JdeDataType.String, 20, true, true),
        new JdeField("RFYR", "RFYR", JdeDataType.Numeric, null, true, true),
        new JdeField("RFUKID", "RFUKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F078652_0", "Primary Key on RFIDYE, RFYR, RFUKID", new[] { "RFIDYE", "RFYR", "RFUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
