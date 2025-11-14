using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0012D - .
/// </summary>
public class F0012D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LJITEM.
        /// </summary>
        public const string LJITEM = "LJITEM";

        /// <summary>
        /// LJCO.
        /// </summary>
        public const string LJCO = "LJCO";

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
        /// LJDL05.
        /// </summary>
        public const string LJDL05 = "LJDL05";
    }

    /// <inheritdoc />
    public override string TableName => "F0012D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LJITEM", "LJITEM", JdeDataType.String, 12, true, true),
        new JdeField("LJCO", "LJCO", JdeDataType.String, 10, true, true),
        new JdeField("LJLNGP", "LJLNGP", JdeDataType.String, 4, true, true),
        new JdeField("LJDL01", "LJDL01", JdeDataType.String, 60),
        new JdeField("LJDL02", "LJDL02", JdeDataType.String, 60),
        new JdeField("LJDL03", "LJDL03", JdeDataType.String, 60),
        new JdeField("LJDL04", "LJDL04", JdeDataType.String, 60),
        new JdeField("LJDL05", "LJDL05", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0012D_0", "Primary Key on LJITEM, LJCO, LJLNGP", new[] { "LJITEM", "LJCO", "LJLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
