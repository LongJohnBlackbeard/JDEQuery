using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74ZUI01 - .
/// </summary>
public class F74ZUI01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CZED0.
        /// </summary>
        public const string CZED0 = "CZED0";

        /// <summary>
        /// CZHTC.
        /// </summary>
        public const string CZHTC = "CZHTC";

        /// <summary>
        /// CZOBJ.
        /// </summary>
        public const string CZOBJ = "CZOBJ";

        /// <summary>
        /// CZSUB.
        /// </summary>
        public const string CZSUB = "CZSUB";

        /// <summary>
        /// CZICUT.
        /// </summary>
        public const string CZICUT = "CZICUT";

        /// <summary>
        /// CZICU.
        /// </summary>
        public const string CZICU = "CZICU";

        /// <summary>
        /// CZAA.
        /// </summary>
        public const string CZAA = "CZAA";
    }

    /// <inheritdoc />
    public override string TableName => "F74ZUI01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CZED0", "CZED0", JdeDataType.String, 2, true, true),
        new JdeField("CZHTC", "CZHTC", JdeDataType.String, 2, true, true),
        new JdeField("CZOBJ", "CZOBJ", JdeDataType.String, 12, true, true),
        new JdeField("CZSUB", "CZSUB", JdeDataType.String, 16, true, true),
        new JdeField("CZICUT", "CZICUT", JdeDataType.String, 4, true, true),
        new JdeField("CZICU", "CZICU", JdeDataType.Numeric, null, true, true),
        new JdeField("CZAA", "CZAA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74ZUI01_0", "Primary Key on CZED0, CZHTC, CZOBJ, CZSUB, CZICUT, CZICU", new[] { "CZED0", "CZHTC", "CZOBJ", "CZSUB", "CZICUT", "CZICU" }, isUnique: true, isPrimaryKey: true)
    };
}
