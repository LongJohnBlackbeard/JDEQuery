using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46L011 - .
/// </summary>
public class F46L011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LNMCU.
        /// </summary>
        public const string LNMCU = "LNMCU";

        /// <summary>
        /// LNLPMN.
        /// </summary>
        public const string LNLPMN = "LNLPMN";

        /// <summary>
        /// LNEFTJ.
        /// </summary>
        public const string LNEFTJ = "LNEFTJ";

        /// <summary>
        /// LNLPSG.
        /// </summary>
        public const string LNLPSG = "LNLPSG";

        /// <summary>
        /// LNLPINC.
        /// </summary>
        public const string LNLPINC = "LNLPINC";

        /// <summary>
        /// LNLPNN.
        /// </summary>
        public const string LNLPNN = "LNLPNN";

        /// <summary>
        /// LNLPFN.
        /// </summary>
        public const string LNLPFN = "LNLPFN";

        /// <summary>
        /// LNLPTN.
        /// </summary>
        public const string LNLPTN = "LNLPTN";

        /// <summary>
        /// LNURCD.
        /// </summary>
        public const string LNURCD = "LNURCD";

        /// <summary>
        /// LNURDT.
        /// </summary>
        public const string LNURDT = "LNURDT";

        /// <summary>
        /// LNURAT.
        /// </summary>
        public const string LNURAT = "LNURAT";

        /// <summary>
        /// LNURAB.
        /// </summary>
        public const string LNURAB = "LNURAB";

        /// <summary>
        /// LNURRF.
        /// </summary>
        public const string LNURRF = "LNURRF";

        /// <summary>
        /// LNUSER.
        /// </summary>
        public const string LNUSER = "LNUSER";

        /// <summary>
        /// LNPID.
        /// </summary>
        public const string LNPID = "LNPID";

        /// <summary>
        /// LNMKEY.
        /// </summary>
        public const string LNMKEY = "LNMKEY";

        /// <summary>
        /// LNUPMJ.
        /// </summary>
        public const string LNUPMJ = "LNUPMJ";

        /// <summary>
        /// LNTDAY.
        /// </summary>
        public const string LNTDAY = "LNTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46L011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LNMCU", "LNMCU", JdeDataType.String, 24, true, true),
        new JdeField("LNLPMN", "LNLPMN", JdeDataType.String, 24, true, true),
        new JdeField("LNEFTJ", "LNEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("LNLPSG", "LNLPSG", JdeDataType.Numeric, null, true, true),
        new JdeField("LNLPINC", "LNLPINC", JdeDataType.Numeric),
        new JdeField("LNLPNN", "LNLPNN", JdeDataType.Numeric),
        new JdeField("LNLPFN", "LNLPFN", JdeDataType.Numeric),
        new JdeField("LNLPTN", "LNLPTN", JdeDataType.Numeric),
        new JdeField("LNURCD", "LNURCD", JdeDataType.String, 4),
        new JdeField("LNURDT", "LNURDT", JdeDataType.Numeric),
        new JdeField("LNURAT", "LNURAT", JdeDataType.Numeric),
        new JdeField("LNURAB", "LNURAB", JdeDataType.Numeric),
        new JdeField("LNURRF", "LNURRF", JdeDataType.String, 30),
        new JdeField("LNUSER", "LNUSER", JdeDataType.String, 20),
        new JdeField("LNPID", "LNPID", JdeDataType.String, 20),
        new JdeField("LNMKEY", "LNMKEY", JdeDataType.String, 30),
        new JdeField("LNUPMJ", "LNUPMJ", JdeDataType.Numeric),
        new JdeField("LNTDAY", "LNTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46L011_0", "Primary Key on LNMCU, LNLPMN, LNEFTJ, LNLPSG", new[] { "LNMCU", "LNLPMN", "LNEFTJ", "LNLPSG" }, isUnique: true, isPrimaryKey: true)
    };
}
