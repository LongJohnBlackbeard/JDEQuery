using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F060120 - .
/// </summary>
public class F060120 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YAAN8.
        /// </summary>
        public const string YAAN8 = "YAAN8";

        /// <summary>
        /// YAMSA.
        /// </summary>
        public const string YAMSA = "YAMSA";

        /// <summary>
        /// YACTBB.
        /// </summary>
        public const string YACTBB = "YACTBB";

        /// <summary>
        /// YACTB1.
        /// </summary>
        public const string YACTB1 = "YACTB1";

        /// <summary>
        /// YACTB2.
        /// </summary>
        public const string YACTB2 = "YACTB2";

        /// <summary>
        /// YACTB3.
        /// </summary>
        public const string YACTB3 = "YACTB3";

        /// <summary>
        /// YADPSC.
        /// </summary>
        public const string YADPSC = "YADPSC";

        /// <summary>
        /// YADPSD.
        /// </summary>
        public const string YADPSD = "YADPSD";

        /// <summary>
        /// YAUPMJ.
        /// </summary>
        public const string YAUPMJ = "YAUPMJ";

        /// <summary>
        /// YAUSER.
        /// </summary>
        public const string YAUSER = "YAUSER";

        /// <summary>
        /// YAJBCX.
        /// </summary>
        public const string YAJBCX = "YAJBCX";

        /// <summary>
        /// YACDIJ.
        /// </summary>
        public const string YACDIJ = "YACDIJ";

        /// <summary>
        /// YAORMCU.
        /// </summary>
        public const string YAORMCU = "YAORMCU";

        /// <summary>
        /// YALSRD.
        /// </summary>
        public const string YALSRD = "YALSRD";

        /// <summary>
        /// YANSRD.
        /// </summary>
        public const string YANSRD = "YANSRD";

        /// <summary>
        /// YAPAPL.
        /// </summary>
        public const string YAPAPL = "YAPAPL";

        /// <summary>
        /// YATIRNK.
        /// </summary>
        public const string YATIRNK = "YATIRNK";

        /// <summary>
        /// YATRNKD.
        /// </summary>
        public const string YATRNKD = "YATRNKD";

        /// <summary>
        /// YAJBPCTRQD.
        /// </summary>
        public const string YAJBPCTRQD = "YAJBPCTRQD";

        /// <summary>
        /// YALTJCRW.
        /// </summary>
        public const string YALTJCRW = "YALTJCRW";

        /// <summary>
        /// YADATRVW.
        /// </summary>
        public const string YADATRVW = "YADATRVW";

        /// <summary>
        /// YARWTYP.
        /// </summary>
        public const string YARWTYP = "YARWTYP";

        /// <summary>
        /// YAMNTR.
        /// </summary>
        public const string YAMNTR = "YAMNTR";

        /// <summary>
        /// YATEAM.
        /// </summary>
        public const string YATEAM = "YATEAM";

        /// <summary>
        /// YASERK.
        /// </summary>
        public const string YASERK = "YASERK";

        /// <summary>
        /// YATINCL.
        /// </summary>
        public const string YATINCL = "YATINCL";

        /// <summary>
        /// YASAGE.
        /// </summary>
        public const string YASAGE = "YASAGE";

        /// <summary>
        /// YASDOB.
        /// </summary>
        public const string YASDOB = "YASDOB";

        /// <summary>
        /// YASLAMT.
        /// </summary>
        public const string YASLAMT = "YASLAMT";
    }

    /// <inheritdoc />
    public override string TableName => "F060120";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YAAN8", "YAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YAMSA", "YAMSA", JdeDataType.String, 2),
        new JdeField("YACTBB", "YACTBB", JdeDataType.String, 6),
        new JdeField("YACTB1", "YACTB1", JdeDataType.String, 6),
        new JdeField("YACTB2", "YACTB2", JdeDataType.String, 6),
        new JdeField("YACTB3", "YACTB3", JdeDataType.String, 6),
        new JdeField("YADPSC", "YADPSC", JdeDataType.String, 6),
        new JdeField("YADPSD", "YADPSD", JdeDataType.Numeric),
        new JdeField("YAUPMJ", "YAUPMJ", JdeDataType.Numeric),
        new JdeField("YAUSER", "YAUSER", JdeDataType.String, 20),
        new JdeField("YAJBCX", "YAJBCX", JdeDataType.String, 60),
        new JdeField("YACDIJ", "YACDIJ", JdeDataType.Numeric),
        new JdeField("YAORMCU", "YAORMCU", JdeDataType.String, 24),
        new JdeField("YALSRD", "YALSRD", JdeDataType.Numeric),
        new JdeField("YANSRD", "YANSRD", JdeDataType.Numeric),
        new JdeField("YAPAPL", "YAPAPL", JdeDataType.Numeric),
        new JdeField("YATIRNK", "YATIRNK", JdeDataType.Numeric),
        new JdeField("YATRNKD", "YATRNKD", JdeDataType.Numeric),
        new JdeField("YAJBPCTRQD", "YAJBPCTRQD", JdeDataType.Numeric),
        new JdeField("YALTJCRW", "YALTJCRW", JdeDataType.Numeric),
        new JdeField("YADATRVW", "YADATRVW", JdeDataType.Numeric),
        new JdeField("YARWTYP", "YARWTYP", JdeDataType.String, 2),
        new JdeField("YAMNTR", "YAMNTR", JdeDataType.Numeric),
        new JdeField("YATEAM", "YATEAM", JdeDataType.String, 20),
        new JdeField("YASERK", "YASERK", JdeDataType.Numeric),
        new JdeField("YATINCL", "YATINCL", JdeDataType.String, 2),
        new JdeField("YASAGE", "YASAGE", JdeDataType.Numeric),
        new JdeField("YASDOB", "YASDOB", JdeDataType.Numeric),
        new JdeField("YASLAMT", "YASLAMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F060120_0", "Primary Key on YAAN8", new[] { "YAAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
