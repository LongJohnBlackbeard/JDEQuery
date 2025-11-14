using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3212 - .
/// </summary>
public class F3212 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RCCFGID.
        /// </summary>
        public const string RCCFGID = "RCCFGID";

        /// <summary>
        /// RCCFGCID.
        /// </summary>
        public const string RCCFGCID = "RCCFGCID";

        /// <summary>
        /// RCKIT.
        /// </summary>
        public const string RCKIT = "RCKIT";

        /// <summary>
        /// RCMMCU.
        /// </summary>
        public const string RCMMCU = "RCMMCU";

        /// <summary>
        /// RCITM.
        /// </summary>
        public const string RCITM = "RCITM";

        /// <summary>
        /// RCCMCU.
        /// </summary>
        public const string RCCMCU = "RCCMCU";

        /// <summary>
        /// RCDSC1.
        /// </summary>
        public const string RCDSC1 = "RCDSC1";

        /// <summary>
        /// RCOPSQ.
        /// </summary>
        public const string RCOPSQ = "RCOPSQ";

        /// <summary>
        /// RCOPSC.
        /// </summary>
        public const string RCOPSC = "RCOPSC";

        /// <summary>
        /// RCMCU.
        /// </summary>
        public const string RCMCU = "RCMCU";

        /// <summary>
        /// RCUORG.
        /// </summary>
        public const string RCUORG = "RCUORG";

        /// <summary>
        /// RCATMU.
        /// </summary>
        public const string RCATMU = "RCATMU";

        /// <summary>
        /// RCITC.
        /// </summary>
        public const string RCITC = "RCITC";

        /// <summary>
        /// RCSOCF.
        /// </summary>
        public const string RCSOCF = "RCSOCF";

        /// <summary>
        /// RCURCD.
        /// </summary>
        public const string RCURCD = "RCURCD";

        /// <summary>
        /// RCURDT.
        /// </summary>
        public const string RCURDT = "RCURDT";

        /// <summary>
        /// RCURAT.
        /// </summary>
        public const string RCURAT = "RCURAT";

        /// <summary>
        /// RCURAB.
        /// </summary>
        public const string RCURAB = "RCURAB";

        /// <summary>
        /// RCURRF.
        /// </summary>
        public const string RCURRF = "RCURRF";

        /// <summary>
        /// RCUSER.
        /// </summary>
        public const string RCUSER = "RCUSER";

        /// <summary>
        /// RCPID.
        /// </summary>
        public const string RCPID = "RCPID";

        /// <summary>
        /// RCJOBN.
        /// </summary>
        public const string RCJOBN = "RCJOBN";

        /// <summary>
        /// RCUPMJ.
        /// </summary>
        public const string RCUPMJ = "RCUPMJ";

        /// <summary>
        /// RCTDAY.
        /// </summary>
        public const string RCTDAY = "RCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F3212";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RCCFGID", "RCCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("RCCFGCID", "RCCFGCID", JdeDataType.Numeric, null, true, true),
        new JdeField("RCKIT", "RCKIT", JdeDataType.Numeric),
        new JdeField("RCMMCU", "RCMMCU", JdeDataType.String, 24),
        new JdeField("RCITM", "RCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("RCCMCU", "RCCMCU", JdeDataType.String, 24, true, true),
        new JdeField("RCDSC1", "RCDSC1", JdeDataType.String, 60),
        new JdeField("RCOPSQ", "RCOPSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("RCOPSC", "RCOPSC", JdeDataType.String, 4),
        new JdeField("RCMCU", "RCMCU", JdeDataType.String, 24),
        new JdeField("RCUORG", "RCUORG", JdeDataType.Numeric),
        new JdeField("RCATMU", "RCATMU", JdeDataType.Numeric),
        new JdeField("RCITC", "RCITC", JdeDataType.String, 2),
        new JdeField("RCSOCF", "RCSOCF", JdeDataType.String, 2),
        new JdeField("RCURCD", "RCURCD", JdeDataType.String, 4),
        new JdeField("RCURDT", "RCURDT", JdeDataType.Numeric),
        new JdeField("RCURAT", "RCURAT", JdeDataType.Numeric),
        new JdeField("RCURAB", "RCURAB", JdeDataType.Numeric),
        new JdeField("RCURRF", "RCURRF", JdeDataType.String, 30),
        new JdeField("RCUSER", "RCUSER", JdeDataType.String, 20),
        new JdeField("RCPID", "RCPID", JdeDataType.String, 20),
        new JdeField("RCJOBN", "RCJOBN", JdeDataType.String, 20),
        new JdeField("RCUPMJ", "RCUPMJ", JdeDataType.Numeric),
        new JdeField("RCTDAY", "RCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3212_0", "Primary Key on RCCFGID, RCCFGCID, RCOPSQ, RCITM, RCCMCU", new[] { "RCCFGID", "RCCFGCID", "RCOPSQ", "RCITM", "RCCMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
