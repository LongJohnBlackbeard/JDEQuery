using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F89LU009 - .
/// </summary>
public class F89LU009 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SGGENCRMID.
        /// </summary>
        public const string SGGENCRMID = "SGGENCRMID";

        /// <summary>
        /// SGSRDESC.
        /// </summary>
        public const string SGSRDESC = "SGSRDESC";

        /// <summary>
        /// SGCALLQ.
        /// </summary>
        public const string SGCALLQ = "SGCALLQ";
    }

    /// <inheritdoc />
    public override string TableName => "F89LU009";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SGGENCRMID", "SGGENCRMID", JdeDataType.Numeric, null, true, true),
        new JdeField("SGSRDESC", "SGSRDESC", JdeDataType.String, 510),
        new JdeField("SGCALLQ", "SGCALLQ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F89LU009_0", "Primary Key on SGGENCRMID", new[] { "SGGENCRMID" }, isUnique: true, isPrimaryKey: true)
    };
}
