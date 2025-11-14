using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1201D - .
/// </summary>
public class F1201D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LJNUMB.
        /// </summary>
        public const string LJNUMB = "LJNUMB";

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
        /// LJDSCC.
        /// </summary>
        public const string LJDSCC = "LJDSCC";
    }

    /// <inheritdoc />
    public override string TableName => "F1201D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LJNUMB", "LJNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("LJLNGP", "LJLNGP", JdeDataType.String, 4, true, true),
        new JdeField("LJDL01", "LJDL01", JdeDataType.String, 60),
        new JdeField("LJDL02", "LJDL02", JdeDataType.String, 60),
        new JdeField("LJDL03", "LJDL03", JdeDataType.String, 60),
        new JdeField("LJDSCC", "LJDSCC", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1201D_0", "Primary Key on LJNUMB, LJLNGP", new[] { "LJNUMB", "LJLNGP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1201D_2", "Index on LJDL01", new[] { "LJDL01" })
    };
}
