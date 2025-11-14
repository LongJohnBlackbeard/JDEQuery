using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CF16A - .
/// </summary>
public class F90CF16A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCQUSTID.
        /// </summary>
        public const string CCQUSTID = "CCQUSTID";

        /// <summary>
        /// CCSCRPTID.
        /// </summary>
        public const string CCSCRPTID = "CCSCRPTID";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCUDTTM.
        /// </summary>
        public const string CCUDTTM = "CCUDTTM";

        /// <summary>
        /// CCMKEY.
        /// </summary>
        public const string CCMKEY = "CCMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F90CF16A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCQUSTID", "CCQUSTID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCSCRPTID", "CCSCRPTID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCUDTTM", "CCUDTTM", JdeDataType.Date),
        new JdeField("CCMKEY", "CCMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CF16A_0", "Primary Key on CCQUSTID, CCSCRPTID", new[] { "CCQUSTID", "CCSCRPTID" }, isUnique: true, isPrimaryKey: true)
    };
}
