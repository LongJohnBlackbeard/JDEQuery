using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F760409A - .
/// </summary>
public class F760409A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// V9USER.
        /// </summary>
        public const string V9USER = "V9USER";

        /// <summary>
        /// V9CO.
        /// </summary>
        public const string V9CO = "V9CO";

        /// <summary>
        /// V9PST.
        /// </summary>
        public const string V9PST = "V9PST";

        /// <summary>
        /// V9APSU.
        /// </summary>
        public const string V9APSU = "V9APSU";

        /// <summary>
        /// V9AAP.
        /// </summary>
        public const string V9AAP = "V9AAP";
    }

    /// <inheritdoc />
    public override string TableName => "F760409A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("V9USER", "V9USER", JdeDataType.String, 20, true, true),
        new JdeField("V9CO", "V9CO", JdeDataType.String, 10, true, true),
        new JdeField("V9PST", "V9PST", JdeDataType.String, 2, true, true),
        new JdeField("V9APSU", "V9APSU", JdeDataType.String, 2, true, true),
        new JdeField("V9AAP", "V9AAP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F760409A_0", "Primary Key on V9USER, V9CO, V9PST, V9APSU", new[] { "V9USER", "V9CO", "V9PST", "V9APSU" }, isUnique: true, isPrimaryKey: true)
    };
}
