using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B104 - .
/// </summary>
public class F76B104 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QDFCO.
        /// </summary>
        public const string QDFCO = "QDFCO";

        /// <summary>
        /// QDBRACIM.
        /// </summary>
        public const string QDBRACIM = "QDBRACIM";

        /// <summary>
        /// QDLNID.
        /// </summary>
        public const string QDLNID = "QDLNID";

        /// <summary>
        /// QDBRADEC.
        /// </summary>
        public const string QDBRADEC = "QDBRADEC";

        /// <summary>
        /// QDOD1.
        /// </summary>
        public const string QDOD1 = "QDOD1";

        /// <summary>
        /// QDTXLN.
        /// </summary>
        public const string QDTXLN = "QDTXLN";
    }

    /// <inheritdoc />
    public override string TableName => "F76B104";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QDFCO", "QDFCO", JdeDataType.String, 10, true, true),
        new JdeField("QDBRACIM", "QDBRACIM", JdeDataType.String, 2, true, true),
        new JdeField("QDLNID", "QDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("QDBRADEC", "QDBRADEC", JdeDataType.Numeric),
        new JdeField("QDOD1", "QDOD1", JdeDataType.Numeric),
        new JdeField("QDTXLN", "QDTXLN", JdeDataType.String, 120)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B104_0", "Primary Key on QDFCO, QDBRACIM, QDLNID", new[] { "QDFCO", "QDBRACIM", "QDLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
