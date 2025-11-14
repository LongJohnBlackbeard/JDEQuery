using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA003 - .
/// </summary>
public class F90CA003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SMAN8.
        /// </summary>
        public const string SMAN8 = "SMAN8";

        /// <summary>
        /// SMSLSM.
        /// </summary>
        public const string SMSLSM = "SMSLSM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SMAN8", "SMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SMSLSM", "SMSLSM", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA003_0", "Primary Key on SMAN8, SMSLSM", new[] { "SMAN8", "SMSLSM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CA003_2", "Index on SMAN8", new[] { "SMAN8" }),
        new JdeIndex("F90CA003_3", "Index on SMSLSM", new[] { "SMSLSM" })
    };
}
