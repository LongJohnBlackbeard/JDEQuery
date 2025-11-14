using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F82109 - .
/// </summary>
public class F82109 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A3QRYG.
        /// </summary>
        public const string A3QRYG = "A3QRYG";

        /// <summary>
        /// A3QRYN.
        /// </summary>
        public const string A3QRYN = "A3QRYN";

        /// <summary>
        /// A3TSF.
        /// </summary>
        public const string A3TSF = "A3TSF";

        /// <summary>
        /// A3TSFI.
        /// </summary>
        public const string A3TSFI = "A3TSFI";

        /// <summary>
        /// A3DSCR.
        /// </summary>
        public const string A3DSCR = "A3DSCR";

        /// <summary>
        /// A3FSF.
        /// </summary>
        public const string A3FSF = "A3FSF";

        /// <summary>
        /// A3FSFI.
        /// </summary>
        public const string A3FSFI = "A3FSFI";
    }

    /// <inheritdoc />
    public override string TableName => "F82109";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A3QRYG", "A3QRYG", JdeDataType.String, 20, true, true),
        new JdeField("A3QRYN", "A3QRYN", JdeDataType.String, 20, true, true),
        new JdeField("A3TSF", "A3TSF", JdeDataType.String, 20, true, true),
        new JdeField("A3TSFI", "A3TSFI", JdeDataType.Numeric, null, true, true),
        new JdeField("A3DSCR", "A3DSCR", JdeDataType.String, 80),
        new JdeField("A3FSF", "A3FSF", JdeDataType.String, 20),
        new JdeField("A3FSFI", "A3FSFI", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F82109_0", "Primary Key on A3QRYG, A3QRYN, A3TSF, A3TSFI", new[] { "A3QRYG", "A3QRYN", "A3TSF", "A3TSFI" }, isUnique: true, isPrimaryKey: true)
    };
}
