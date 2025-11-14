using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B920C - .
/// </summary>
public class F03B920C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZDCRTC.
        /// </summary>
        public const string ZDCRTC = "ZDCRTC";

        /// <summary>
        /// ZDUKID.
        /// </summary>
        public const string ZDUKID = "ZDUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F03B920C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZDCRTC", "ZDCRTC", JdeDataType.String, 600),
        new JdeField("ZDUKID", "ZDUKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B920C_0", "Primary Key on ZDUKID", new[] { "ZDUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
