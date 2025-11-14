using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G75 - .
/// </summary>
public class F40G75 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACWCFGID.
        /// </summary>
        public const string ACWCFGID = "ACWCFGID";

        /// <summary>
        /// ACFARMCDE.
        /// </summary>
        public const string ACFARMCDE = "ACFARMCDE";

        /// <summary>
        /// ACWCOPCD.
        /// </summary>
        public const string ACWCOPCD = "ACWCOPCD";

        /// <summary>
        /// ACFARMDSC.
        /// </summary>
        public const string ACFARMDSC = "ACFARMDSC";

        /// <summary>
        /// ACFARMVAL.
        /// </summary>
        public const string ACFARMVAL = "ACFARMVAL";

        /// <summary>
        /// ACFARMUOM.
        /// </summary>
        public const string ACFARMUOM = "ACFARMUOM";

        /// <summary>
        /// ACURCD.
        /// </summary>
        public const string ACURCD = "ACURCD";

        /// <summary>
        /// ACURDT.
        /// </summary>
        public const string ACURDT = "ACURDT";

        /// <summary>
        /// ACURRF.
        /// </summary>
        public const string ACURRF = "ACURRF";

        /// <summary>
        /// ACURAT.
        /// </summary>
        public const string ACURAT = "ACURAT";

        /// <summary>
        /// ACURAB.
        /// </summary>
        public const string ACURAB = "ACURAB";

        /// <summary>
        /// ACPID.
        /// </summary>
        public const string ACPID = "ACPID";

        /// <summary>
        /// ACTORG.
        /// </summary>
        public const string ACTORG = "ACTORG";

        /// <summary>
        /// ACUSER.
        /// </summary>
        public const string ACUSER = "ACUSER";

        /// <summary>
        /// ACJOBN.
        /// </summary>
        public const string ACJOBN = "ACJOBN";

        /// <summary>
        /// ACUUPMJ.
        /// </summary>
        public const string ACUUPMJ = "ACUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40G75";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACWCFGID", "ACWCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("ACFARMCDE", "ACFARMCDE", JdeDataType.String, 20, true, true),
        new JdeField("ACWCOPCD", "ACWCOPCD", JdeDataType.String, 20),
        new JdeField("ACFARMDSC", "ACFARMDSC", JdeDataType.String, 60),
        new JdeField("ACFARMVAL", "ACFARMVAL", JdeDataType.Numeric),
        new JdeField("ACFARMUOM", "ACFARMUOM", JdeDataType.String, 4),
        new JdeField("ACURCD", "ACURCD", JdeDataType.String, 4),
        new JdeField("ACURDT", "ACURDT", JdeDataType.Numeric),
        new JdeField("ACURRF", "ACURRF", JdeDataType.String, 30),
        new JdeField("ACURAT", "ACURAT", JdeDataType.Numeric),
        new JdeField("ACURAB", "ACURAB", JdeDataType.Numeric),
        new JdeField("ACPID", "ACPID", JdeDataType.String, 20),
        new JdeField("ACTORG", "ACTORG", JdeDataType.String, 20),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACJOBN", "ACJOBN", JdeDataType.String, 20),
        new JdeField("ACUUPMJ", "ACUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G75_0", "Primary Key on ACWCFGID, ACFARMCDE", new[] { "ACWCFGID", "ACFARMCDE" }, isUnique: true, isPrimaryKey: true)
    };
}
