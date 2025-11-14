using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F82106 - .
/// </summary>
public class F82106 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A2QRYG.
        /// </summary>
        public const string A2QRYG = "A2QRYG";

        /// <summary>
        /// A2QRYN.
        /// </summary>
        public const string A2QRYN = "A2QRYN";

        /// <summary>
        /// A2SLFD.
        /// </summary>
        public const string A2SLFD = "A2SLFD";

        /// <summary>
        /// A2FILI.
        /// </summary>
        public const string A2FILI = "A2FILI";

        /// <summary>
        /// A2SQND.
        /// </summary>
        public const string A2SQND = "A2SQND";

        /// <summary>
        /// A2QSVL.
        /// </summary>
        public const string A2QSVL = "A2QSVL";

        /// <summary>
        /// A2VLL.
        /// </summary>
        public const string A2VLL = "A2VLL";

        /// <summary>
        /// A2SVTY.
        /// </summary>
        public const string A2SVTY = "A2SVTY";
    }

    /// <inheritdoc />
    public override string TableName => "F82106";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A2QRYG", "A2QRYG", JdeDataType.String, 20, true, true),
        new JdeField("A2QRYN", "A2QRYN", JdeDataType.String, 20),
        new JdeField("A2SLFD", "A2SLFD", JdeDataType.String, 20),
        new JdeField("A2FILI", "A2FILI", JdeDataType.Numeric),
        new JdeField("A2SQND", "A2SQND", JdeDataType.Numeric),
        new JdeField("A2QSVL", "A2QSVL", JdeDataType.String, 50),
        new JdeField("A2VLL", "A2VLL", JdeDataType.Numeric),
        new JdeField("A2SVTY", "A2SVTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F82106_0", "Primary Key on A2QRYG", new[] { "A2QRYG" }, isUnique: true, isPrimaryKey: true)
    };
}
