using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07492 - .
/// </summary>
public class F07492 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JCPAYD.
        /// </summary>
        public const string JCPAYD = "JCPAYD";

        /// <summary>
        /// JCICU.
        /// </summary>
        public const string JCICU = "JCICU";

        /// <summary>
        /// JCANN8.
        /// </summary>
        public const string JCANN8 = "JCANN8";

        /// <summary>
        /// JCAPTF.
        /// </summary>
        public const string JCAPTF = "JCAPTF";

        /// <summary>
        /// JCCTL2.
        /// </summary>
        public const string JCCTL2 = "JCCTL2";

        /// <summary>
        /// JCVCHR.
        /// </summary>
        public const string JCVCHR = "JCVCHR";

        /// <summary>
        /// JCPTC.
        /// </summary>
        public const string JCPTC = "JCPTC";

        /// <summary>
        /// JCDOC.
        /// </summary>
        public const string JCDOC = "JCDOC";

        /// <summary>
        /// JCAG.
        /// </summary>
        public const string JCAG = "JCAG";

        /// <summary>
        /// JCDGJ.
        /// </summary>
        public const string JCDGJ = "JCDGJ";

        /// <summary>
        /// JCUKID.
        /// </summary>
        public const string JCUKID = "JCUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F07492";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JCPAYD", "JCPAYD", JdeDataType.String, 20, true, true),
        new JdeField("JCICU", "JCICU", JdeDataType.Numeric, null, true, true),
        new JdeField("JCANN8", "JCANN8", JdeDataType.Numeric),
        new JdeField("JCAPTF", "JCAPTF", JdeDataType.String, 2),
        new JdeField("JCCTL2", "JCCTL2", JdeDataType.String, 62),
        new JdeField("JCVCHR", "JCVCHR", JdeDataType.String, 4),
        new JdeField("JCPTC", "JCPTC", JdeDataType.String, 6),
        new JdeField("JCDOC", "JCDOC", JdeDataType.Numeric),
        new JdeField("JCAG", "JCAG", JdeDataType.Numeric),
        new JdeField("JCDGJ", "JCDGJ", JdeDataType.Numeric),
        new JdeField("JCUKID", "JCUKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07492_0", "Primary Key on JCPAYD, JCICU, JCUKID", new[] { "JCPAYD", "JCICU", "JCUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07492_2", "Index on JCPAYD, JCICU, JCANN8, JCAPTF, JCCTL2", new[] { "JCPAYD", "JCICU", "JCANN8", "JCAPTF", "JCCTL2" }),
        new JdeIndex("F07492_3", "Index on JCANN8, JCPAYD", new[] { "JCANN8", "JCPAYD" })
    };
}
