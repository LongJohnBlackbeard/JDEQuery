using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08041 - .
/// </summary>
public class F08041 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JUFILE.
        /// </summary>
        public const string JUFILE = "JUFILE";

        /// <summary>
        /// JUDTAI.
        /// </summary>
        public const string JUDTAI = "JUDTAI";

        /// <summary>
        /// JUXCOD.
        /// </summary>
        public const string JUXCOD = "JUXCOD";
    }

    /// <inheritdoc />
    public override string TableName => "F08041";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JUFILE", "JUFILE", JdeDataType.String, 20, true, true),
        new JdeField("JUDTAI", "JUDTAI", JdeDataType.String, 20, true, true),
        new JdeField("JUXCOD", "JUXCOD", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08041_0", "Primary Key on JUFILE, JUDTAI", new[] { "JUFILE", "JUDTAI" }, isUnique: true, isPrimaryKey: true)
    };
}
