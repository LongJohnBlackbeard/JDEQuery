using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B102 - .
/// </summary>
public class F76B102 : JdeTable
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
        /// QDBRACDE.
        /// </summary>
        public const string QDBRACDE = "QDBRACDE";

        /// <summary>
        /// QDTXLN.
        /// </summary>
        public const string QDTXLN = "QDTXLN";

        /// <summary>
        /// QDAEXP.
        /// </summary>
        public const string QDAEXP = "QDAEXP";

        /// <summary>
        /// QDCICTRL.
        /// </summary>
        public const string QDCICTRL = "QDCICTRL";

        /// <summary>
        /// QDUSER.
        /// </summary>
        public const string QDUSER = "QDUSER";

        /// <summary>
        /// QDJOBN.
        /// </summary>
        public const string QDJOBN = "QDJOBN";

        /// <summary>
        /// QDPID.
        /// </summary>
        public const string QDPID = "QDPID";

        /// <summary>
        /// QDUPMJ.
        /// </summary>
        public const string QDUPMJ = "QDUPMJ";

        /// <summary>
        /// QDTDAY.
        /// </summary>
        public const string QDTDAY = "QDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76B102";

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
        new JdeField("QDBRACDE", "QDBRACDE", JdeDataType.String, 6),
        new JdeField("QDTXLN", "QDTXLN", JdeDataType.String, 120),
        new JdeField("QDAEXP", "QDAEXP", JdeDataType.Numeric),
        new JdeField("QDCICTRL", "QDCICTRL", JdeDataType.Numeric),
        new JdeField("QDUSER", "QDUSER", JdeDataType.String, 20),
        new JdeField("QDJOBN", "QDJOBN", JdeDataType.String, 20),
        new JdeField("QDPID", "QDPID", JdeDataType.String, 20),
        new JdeField("QDUPMJ", "QDUPMJ", JdeDataType.Numeric),
        new JdeField("QDTDAY", "QDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B102_0", "Primary Key on QDFCO, QDBRACIM, QDLNID", new[] { "QDFCO", "QDBRACIM", "QDLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
