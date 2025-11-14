using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A41 - .
/// </summary>
public class F76A41 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LDICU.
        /// </summary>
        public const string LDICU = "LDICU";

        /// <summary>
        /// LDRQNU.
        /// </summary>
        public const string LDRQNU = "LDRQNU";

        /// <summary>
        /// LDDCT.
        /// </summary>
        public const string LDDCT = "LDDCT";

        /// <summary>
        /// LDDOC.
        /// </summary>
        public const string LDDOC = "LDDOC";

        /// <summary>
        /// LDKCO.
        /// </summary>
        public const string LDKCO = "LDKCO";

        /// <summary>
        /// LDDGJ.
        /// </summary>
        public const string LDDGJ = "LDDGJ";

        /// <summary>
        /// LDJELN.
        /// </summary>
        public const string LDJELN = "LDJELN";

        /// <summary>
        /// LDLT.
        /// </summary>
        public const string LDLT = "LDLT";

        /// <summary>
        /// LDEXTL.
        /// </summary>
        public const string LDEXTL = "LDEXTL";

        /// <summary>
        /// LDUPMJ.
        /// </summary>
        public const string LDUPMJ = "LDUPMJ";

        /// <summary>
        /// LDUSER.
        /// </summary>
        public const string LDUSER = "LDUSER";

        /// <summary>
        /// LDJOBN.
        /// </summary>
        public const string LDJOBN = "LDJOBN";

        /// <summary>
        /// LDPID.
        /// </summary>
        public const string LDPID = "LDPID";

        /// <summary>
        /// LDTDAY.
        /// </summary>
        public const string LDTDAY = "LDTDAY";

        /// <summary>
        /// LDEFTJ.
        /// </summary>
        public const string LDEFTJ = "LDEFTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76A41";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LDICU", "LDICU", JdeDataType.Numeric),
        new JdeField("LDRQNU", "LDRQNU", JdeDataType.Numeric),
        new JdeField("LDDCT", "LDDCT", JdeDataType.String, 4, true, true),
        new JdeField("LDDOC", "LDDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("LDKCO", "LDKCO", JdeDataType.String, 10, true, true),
        new JdeField("LDDGJ", "LDDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("LDJELN", "LDJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("LDLT", "LDLT", JdeDataType.String, 4, true, true),
        new JdeField("LDEXTL", "LDEXTL", JdeDataType.String, 4, true, true),
        new JdeField("LDUPMJ", "LDUPMJ", JdeDataType.Numeric),
        new JdeField("LDUSER", "LDUSER", JdeDataType.String, 20),
        new JdeField("LDJOBN", "LDJOBN", JdeDataType.String, 20),
        new JdeField("LDPID", "LDPID", JdeDataType.String, 20),
        new JdeField("LDTDAY", "LDTDAY", JdeDataType.Numeric),
        new JdeField("LDEFTJ", "LDEFTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A41_0", "Primary Key on LDDCT, LDDOC, LDKCO, LDDGJ, LDJELN, LDLT, LDEXTL", new[] { "LDDCT", "LDDOC", "LDKCO", "LDDGJ", "LDJELN", "LDLT", "LDEXTL" }, isUnique: true, isPrimaryKey: true)
    };
}
