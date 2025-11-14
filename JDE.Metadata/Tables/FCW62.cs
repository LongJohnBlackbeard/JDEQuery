using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW62 - .
/// </summary>
public class FCW62 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFC9ITM.
        /// </summary>
        public const string WFC9ITM = "WFC9ITM";

        /// <summary>
        /// WFEV01.
        /// </summary>
        public const string WFEV01 = "WFEV01";

        /// <summary>
        /// WFC9CMP.
        /// </summary>
        public const string WFC9CMP = "WFC9CMP";

        /// <summary>
        /// WFC9SEQ.
        /// </summary>
        public const string WFC9SEQ = "WFC9SEQ";

        /// <summary>
        /// WFC9PERC.
        /// </summary>
        public const string WFC9PERC = "WFC9PERC";

        /// <summary>
        /// WFC9MAT.
        /// </summary>
        public const string WFC9MAT = "WFC9MAT";
    }

    /// <inheritdoc />
    public override string TableName => "FCW62";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFC9ITM", "WFC9ITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WFEV01", "WFEV01", JdeDataType.String, 2, true, true),
        new JdeField("WFC9CMP", "WFC9CMP", JdeDataType.String, 20, true, true),
        new JdeField("WFC9SEQ", "WFC9SEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("WFC9PERC", "WFC9PERC", JdeDataType.Numeric),
        new JdeField("WFC9MAT", "WFC9MAT", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW62_0", "Primary Key on WFC9ITM, WFEV01, WFC9CMP, WFC9SEQ", new[] { "WFC9ITM", "WFEV01", "WFC9CMP", "WFC9SEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
