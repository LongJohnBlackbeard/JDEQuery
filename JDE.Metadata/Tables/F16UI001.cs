using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F16UI001 - .
/// </summary>
public class F16UI001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CACTID.
        /// </summary>
        public const string CACTID = "CACTID";

        /// <summary>
        /// CAJOBS.
        /// </summary>
        public const string CAJOBS = "CAJOBS";

        /// <summary>
        /// CALNID.
        /// </summary>
        public const string CALNID = "CALNID";

        /// <summary>
        /// CADTAI.
        /// </summary>
        public const string CADTAI = "CADTAI";

        /// <summary>
        /// CADL01.
        /// </summary>
        public const string CADL01 = "CADL01";
    }

    /// <inheritdoc />
    public override string TableName => "F16UI001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CACTID", "CACTID", JdeDataType.String, 30, true, true),
        new JdeField("CAJOBS", "CAJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("CALNID", "CALNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CADTAI", "CADTAI", JdeDataType.String, 20),
        new JdeField("CADL01", "CADL01", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F16UI001_0", "Primary Key on CACTID, CAJOBS, CALNID", new[] { "CACTID", "CAJOBS", "CALNID" }, isUnique: true, isPrimaryKey: true)
    };
}
