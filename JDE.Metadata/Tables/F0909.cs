using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0909 - .
/// </summary>
public class F0909 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACOBJ.
        /// </summary>
        public const string ACOBJ = "ACOBJ";

        /// <summary>
        /// ACCO.
        /// </summary>
        public const string ACCO = "ACCO";

        /// <summary>
        /// ACDL01.
        /// </summary>
        public const string ACDL01 = "ACDL01";

        /// <summary>
        /// ACLDA.
        /// </summary>
        public const string ACLDA = "ACLDA";

        /// <summary>
        /// ACPEC.
        /// </summary>
        public const string ACPEC = "ACPEC";

        /// <summary>
        /// ACUM.
        /// </summary>
        public const string ACUM = "ACUM";
    }

    /// <inheritdoc />
    public override string TableName => "F0909";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACOBJ", "ACOBJ", JdeDataType.String, 12, true, true),
        new JdeField("ACCO", "ACCO", JdeDataType.String, 10),
        new JdeField("ACDL01", "ACDL01", JdeDataType.String, 60),
        new JdeField("ACLDA", "ACLDA", JdeDataType.String, 2),
        new JdeField("ACPEC", "ACPEC", JdeDataType.String, 2),
        new JdeField("ACUM", "ACUM", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0909_0", "Primary Key on ACOBJ", new[] { "ACOBJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0909_2", "Index on ACCO", new[] { "ACCO" })
    };
}
