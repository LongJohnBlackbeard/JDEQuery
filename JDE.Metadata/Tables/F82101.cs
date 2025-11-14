using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F82101 - .
/// </summary>
public class F82101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A1QRYG.
        /// </summary>
        public const string A1QRYG = "A1QRYG";

        /// <summary>
        /// A1QRYN.
        /// </summary>
        public const string A1QRYN = "A1QRYN";

        /// <summary>
        /// A1QFIL.
        /// </summary>
        public const string A1QFIL = "A1QFIL";

        /// <summary>
        /// A1QLIB.
        /// </summary>
        public const string A1QLIB = "A1QLIB";

        /// <summary>
        /// A1QMBR.
        /// </summary>
        public const string A1QMBR = "A1QMBR";

        /// <summary>
        /// A1QFMT.
        /// </summary>
        public const string A1QFMT = "A1QFMT";

        /// <summary>
        /// A1MD.
        /// </summary>
        public const string A1MD = "A1MD";

        /// <summary>
        /// A1IDF.
        /// </summary>
        public const string A1IDF = "A1IDF";

        /// <summary>
        /// A1IDFI.
        /// </summary>
        public const string A1IDFI = "A1IDFI";

        /// <summary>
        /// A1JDEF.
        /// </summary>
        public const string A1JDEF = "A1JDEF";
    }

    /// <inheritdoc />
    public override string TableName => "F82101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A1QRYG", "A1QRYG", JdeDataType.String, 20, true, true),
        new JdeField("A1QRYN", "A1QRYN", JdeDataType.String, 20),
        new JdeField("A1QFIL", "A1QFIL", JdeDataType.String, 20),
        new JdeField("A1QLIB", "A1QLIB", JdeDataType.String, 20),
        new JdeField("A1QMBR", "A1QMBR", JdeDataType.String, 20),
        new JdeField("A1QFMT", "A1QFMT", JdeDataType.String, 20),
        new JdeField("A1MD", "A1MD", JdeDataType.String, 120),
        new JdeField("A1IDF", "A1IDF", JdeDataType.String, 6),
        new JdeField("A1IDFI", "A1IDFI", JdeDataType.Numeric),
        new JdeField("A1JDEF", "A1JDEF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F82101_0", "Primary Key on A1QRYG", new[] { "A1QRYG" }, isUnique: true, isPrimaryKey: true)
    };
}
