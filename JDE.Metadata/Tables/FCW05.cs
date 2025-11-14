using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW05 - .
/// </summary>
public class FCW05 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSC9CST.
        /// </summary>
        public const string CSC9CST = "CSC9CST";

        /// <summary>
        /// CSC9LVNO.
        /// </summary>
        public const string CSC9LVNO = "CSC9LVNO";

        /// <summary>
        /// CSSY.
        /// </summary>
        public const string CSSY = "CSSY";

        /// <summary>
        /// CSRT.
        /// </summary>
        public const string CSRT = "CSRT";
    }

    /// <inheritdoc />
    public override string TableName => "FCW05";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSC9CST", "CSC9CST", JdeDataType.String, 6, true, true),
        new JdeField("CSC9LVNO", "CSC9LVNO", JdeDataType.Numeric, null, true, true),
        new JdeField("CSSY", "CSSY", JdeDataType.String, 8),
        new JdeField("CSRT", "CSRT", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW05_0", "Primary Key on CSC9CST, CSC9LVNO", new[] { "CSC9CST", "CSC9LVNO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FCW05_2", "Index on CSC9CST, SYS_NC00005$", new[] { "CSC9CST", "SYS_NC00005$" })
    };
}
