using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06918 - .
/// </summary>
public class F06918 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JNMCU.
        /// </summary>
        public const string JNMCU = "JNMCU";

        /// <summary>
        /// JNUN.
        /// </summary>
        public const string JNUN = "JNUN";

        /// <summary>
        /// JNJBCD.
        /// </summary>
        public const string JNJBCD = "JNJBCD";

        /// <summary>
        /// JNJBST.
        /// </summary>
        public const string JNJBST = "JNJBST";

        /// <summary>
        /// JNSHFT.
        /// </summary>
        public const string JNSHFT = "JNSHFT";

        /// <summary>
        /// JNEFTB.
        /// </summary>
        public const string JNEFTB = "JNEFTB";

        /// <summary>
        /// JNEFTE.
        /// </summary>
        public const string JNEFTE = "JNEFTE";

        /// <summary>
        /// JNITM.
        /// </summary>
        public const string JNITM = "JNITM";

        /// <summary>
        /// JNUM.
        /// </summary>
        public const string JNUM = "JNUM";

        /// <summary>
        /// JNPPRT.
        /// </summary>
        public const string JNPPRT = "JNPPRT";

        /// <summary>
        /// JNRTP1.
        /// </summary>
        public const string JNRTP1 = "JNRTP1";

        /// <summary>
        /// JNRTP2.
        /// </summary>
        public const string JNRTP2 = "JNRTP2";

        /// <summary>
        /// JNRTP3.
        /// </summary>
        public const string JNRTP3 = "JNRTP3";

        /// <summary>
        /// JNRTCD.
        /// </summary>
        public const string JNRTCD = "JNRTCD";

        /// <summary>
        /// JNRILT.
        /// </summary>
        public const string JNRILT = "JNRILT";

        /// <summary>
        /// JNLMTH.
        /// </summary>
        public const string JNLMTH = "JNLMTH";

        /// <summary>
        /// JNLF.
        /// </summary>
        public const string JNLF = "JNLF";

        /// <summary>
        /// JNWCMP.
        /// </summary>
        public const string JNWCMP = "JNWCMP";

        /// <summary>
        /// JNWET.
        /// </summary>
        public const string JNWET = "JNWET";
    }

    /// <inheritdoc />
    public override string TableName => "F06918";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JNMCU", "JNMCU", JdeDataType.String, 24, true, true),
        new JdeField("JNUN", "JNUN", JdeDataType.String, 12, true, true),
        new JdeField("JNJBCD", "JNJBCD", JdeDataType.String, 12, true, true),
        new JdeField("JNJBST", "JNJBST", JdeDataType.String, 8, true, true),
        new JdeField("JNSHFT", "JNSHFT", JdeDataType.String, 2, true, true),
        new JdeField("JNEFTB", "JNEFTB", JdeDataType.Numeric),
        new JdeField("JNEFTE", "JNEFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("JNITM", "JNITM", JdeDataType.Numeric, null, true, true),
        new JdeField("JNUM", "JNUM", JdeDataType.String, 4, true, true),
        new JdeField("JNPPRT", "JNPPRT", JdeDataType.Numeric),
        new JdeField("JNRTP1", "JNRTP1", JdeDataType.Numeric),
        new JdeField("JNRTP2", "JNRTP2", JdeDataType.Numeric),
        new JdeField("JNRTP3", "JNRTP3", JdeDataType.Numeric),
        new JdeField("JNRTCD", "JNRTCD", JdeDataType.String, 2),
        new JdeField("JNRILT", "JNRILT", JdeDataType.String, 2),
        new JdeField("JNLMTH", "JNLMTH", JdeDataType.String, 2),
        new JdeField("JNLF", "JNLF", JdeDataType.Numeric),
        new JdeField("JNWCMP", "JNWCMP", JdeDataType.String, 8),
        new JdeField("JNWET", "JNWET", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06918_0", "Primary Key on JNMCU, JNUN, JNJBCD, JNJBST, JNITM, JNUM, JNSHFT, JNEFTE", new[] { "JNMCU", "JNUN", "JNJBCD", "JNJBST", "JNITM", "JNUM", "JNSHFT", "JNEFTE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06918_2", "Index on JNMCU, JNUN, JNJBCD, JNJBST, JNEFTB, JNITM, JNUM, JNSHFT", new[] { "JNMCU", "JNUN", "JNJBCD", "JNJBST", "JNEFTB", "JNITM", "JNUM", "JNSHFT" })
    };
}
