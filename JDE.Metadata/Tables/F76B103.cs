using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B103 - .
/// </summary>
public class F76B103 : JdeTable
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
        /// QDOD1.
        /// </summary>
        public const string QDOD1 = "QDOD1";

        /// <summary>
        /// QDBRADEC.
        /// </summary>
        public const string QDBRADEC = "QDBRADEC";

        /// <summary>
        /// QDBRANGR.
        /// </summary>
        public const string QDBRANGR = "QDBRANGR";

        /// <summary>
        /// QDDSC1.
        /// </summary>
        public const string QDDSC1 = "QDDSC1";

        /// <summary>
        /// QDAEXP.
        /// </summary>
        public const string QDAEXP = "QDAEXP";

        /// <summary>
        /// QDBRADEJ.
        /// </summary>
        public const string QDBRADEJ = "QDBRADEJ";

        /// <summary>
        /// QDBRADLJ.
        /// </summary>
        public const string QDBRADLJ = "QDBRADLJ";

        /// <summary>
        /// QDALPH.
        /// </summary>
        public const string QDALPH = "QDALPH";
    }

    /// <inheritdoc />
    public override string TableName => "F76B103";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QDFCO", "QDFCO", JdeDataType.String, 10, true, true),
        new JdeField("QDBRACIM", "QDBRACIM", JdeDataType.String, 2, true, true),
        new JdeField("QDLNID", "QDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("QDOD1", "QDOD1", JdeDataType.Numeric),
        new JdeField("QDBRADEC", "QDBRADEC", JdeDataType.Numeric),
        new JdeField("QDBRANGR", "QDBRANGR", JdeDataType.Numeric),
        new JdeField("QDDSC1", "QDDSC1", JdeDataType.String, 60),
        new JdeField("QDAEXP", "QDAEXP", JdeDataType.Numeric),
        new JdeField("QDBRADEJ", "QDBRADEJ", JdeDataType.Numeric),
        new JdeField("QDBRADLJ", "QDBRADLJ", JdeDataType.Numeric),
        new JdeField("QDALPH", "QDALPH", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B103_0", "Primary Key on QDFCO, QDBRACIM, QDLNID", new[] { "QDFCO", "QDBRACIM", "QDLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
