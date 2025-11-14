using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06041 - .
/// </summary>
public class F06041 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JKFILE.
        /// </summary>
        public const string JKFILE = "JKFILE";

        /// <summary>
        /// JKDTAI.
        /// </summary>
        public const string JKDTAI = "JKDTAI";

        /// <summary>
        /// JKICDE.
        /// </summary>
        public const string JKICDE = "JKICDE";
    }

    /// <inheritdoc />
    public override string TableName => "F06041";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JKFILE", "JKFILE", JdeDataType.String, 20, true, true),
        new JdeField("JKDTAI", "JKDTAI", JdeDataType.String, 20, true, true),
        new JdeField("JKICDE", "JKICDE", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06041_0", "Primary Key on JKFILE, JKDTAI", new[] { "JKFILE", "JKDTAI" }, isUnique: true, isPrimaryKey: true)
    };
}
