using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46LUI02 - .
/// </summary>
public class F46LUI02 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LPJOBS.
        /// </summary>
        public const string LPJOBS = "LPJOBS";

        /// <summary>
        /// LPLPNU.
        /// </summary>
        public const string LPLPNU = "LPLPNU";

        /// <summary>
        /// LPPLPNU.
        /// </summary>
        public const string LPPLPNU = "LPPLPNU";

        /// <summary>
        /// LPPQOH.
        /// </summary>
        public const string LPPQOH = "LPPQOH";

        /// <summary>
        /// LPUOM.
        /// </summary>
        public const string LPUOM = "LPUOM";

        /// <summary>
        /// LPEQTY.
        /// </summary>
        public const string LPEQTY = "LPEQTY";
    }

    /// <inheritdoc />
    public override string TableName => "F46LUI02";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LPJOBS", "LPJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("LPLPNU", "LPLPNU", JdeDataType.String, 80, true, true),
        new JdeField("LPPLPNU", "LPPLPNU", JdeDataType.String, 80),
        new JdeField("LPPQOH", "LPPQOH", JdeDataType.Numeric),
        new JdeField("LPUOM", "LPUOM", JdeDataType.String, 4),
        new JdeField("LPEQTY", "LPEQTY", JdeDataType.String, 10)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46LUI02_0", "Primary Key on LPJOBS, LPLPNU", new[] { "LPJOBS", "LPLPNU" }, isUnique: true, isPrimaryKey: true)
    };
}
