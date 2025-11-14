using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4101HD - .
/// </summary>
public class F4101HD : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IHOSTP.
        /// </summary>
        public const string IHOSTP = "IHOSTP";

        /// <summary>
        /// IHUKID.
        /// </summary>
        public const string IHUKID = "IHUKID";

        /// <summary>
        /// IHLNGP.
        /// </summary>
        public const string IHLNGP = "IHLNGP";

        /// <summary>
        /// IHDSC1.
        /// </summary>
        public const string IHDSC1 = "IHDSC1";
    }

    /// <inheritdoc />
    public override string TableName => "F4101HD";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IHOSTP", "IHOSTP", JdeDataType.String, 6, true, true),
        new JdeField("IHUKID", "IHUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("IHLNGP", "IHLNGP", JdeDataType.String, 4, true, true),
        new JdeField("IHDSC1", "IHDSC1", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4101HD_0", "Primary Key on IHOSTP, IHUKID, IHLNGP", new[] { "IHOSTP", "IHUKID", "IHLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
