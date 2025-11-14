using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0006D - .
/// </summary>
public class F0006D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LJMCU.
        /// </summary>
        public const string LJMCU = "LJMCU";

        /// <summary>
        /// LJLNGP.
        /// </summary>
        public const string LJLNGP = "LJLNGP";

        /// <summary>
        /// LJDL01.
        /// </summary>
        public const string LJDL01 = "LJDL01";

        /// <summary>
        /// LJDL02.
        /// </summary>
        public const string LJDL02 = "LJDL02";

        /// <summary>
        /// LJDL03.
        /// </summary>
        public const string LJDL03 = "LJDL03";

        /// <summary>
        /// LJDL04.
        /// </summary>
        public const string LJDL04 = "LJDL04";

        /// <summary>
        /// LJDC.
        /// </summary>
        public const string LJDC = "LJDC";
    }

    /// <inheritdoc />
    public override string TableName => "F0006D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LJMCU", "LJMCU", JdeDataType.String, 24, true, true),
        new JdeField("LJLNGP", "LJLNGP", JdeDataType.String, 4, true, true),
        new JdeField("LJDL01", "LJDL01", JdeDataType.String, 60),
        new JdeField("LJDL02", "LJDL02", JdeDataType.String, 60),
        new JdeField("LJDL03", "LJDL03", JdeDataType.String, 60),
        new JdeField("LJDL04", "LJDL04", JdeDataType.String, 60),
        new JdeField("LJDC", "LJDC", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0006D_0", "Primary Key on LJMCU, LJLNGP", new[] { "LJMCU", "LJLNGP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0006D_2", "Index on LJDL01", new[] { "LJDL01" })
    };
}
