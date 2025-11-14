using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA002 - .
/// </summary>
public class F90CA002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OMOPPID.
        /// </summary>
        public const string OMOPPID = "OMOPPID";

        /// <summary>
        /// OMAN8.
        /// </summary>
        public const string OMAN8 = "OMAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OMOPPID", "OMOPPID", JdeDataType.Numeric, null, true, true),
        new JdeField("OMAN8", "OMAN8", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA002_0", "Primary Key on OMOPPID, OMAN8", new[] { "OMOPPID", "OMAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CA002_2", "Index on OMAN8", new[] { "OMAN8" }),
        new JdeIndex("F90CA002_3", "Index on OMOPPID", new[] { "OMOPPID" })
    };
}
