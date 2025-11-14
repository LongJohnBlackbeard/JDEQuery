using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01815 - .
/// </summary>
public class F01815 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ASAN8.
        /// </summary>
        public const string ASAN8 = "ASAN8";

        /// <summary>
        /// ASIDLN.
        /// </summary>
        public const string ASIDLN = "ASIDLN";

        /// <summary>
        /// ASRCK7.
        /// </summary>
        public const string ASRCK7 = "ASRCK7";

        /// <summary>
        /// ASSRCHWRD.
        /// </summary>
        public const string ASSRCHWRD = "ASSRCHWRD";
    }

    /// <inheritdoc />
    public override string TableName => "F01815";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ASAN8", "ASAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ASIDLN", "ASIDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("ASRCK7", "ASRCK7", JdeDataType.Numeric, null, true, true),
        new JdeField("ASSRCHWRD", "ASSRCHWRD", JdeDataType.String, 80, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01815_0", "Primary Key on ASAN8, ASSRCHWRD, ASIDLN, ASRCK7", new[] { "ASAN8", "ASSRCHWRD", "ASIDLN", "ASRCK7" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F01815_2", "Index on ASAN8", new[] { "ASAN8" })
    };
}
