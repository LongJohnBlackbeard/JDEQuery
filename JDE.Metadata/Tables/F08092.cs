using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08092 - .
/// </summary>
public class F08092 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JZRCOD.
        /// </summary>
        public const string JZRCOD = "JZRCOD";

        /// <summary>
        /// JZTYRC.
        /// </summary>
        public const string JZTYRC = "JZTYRC";

        /// <summary>
        /// JZAN8.
        /// </summary>
        public const string JZAN8 = "JZAN8";

        /// <summary>
        /// JZJBCD.
        /// </summary>
        public const string JZJBCD = "JZJBCD";

        /// <summary>
        /// JZJBST.
        /// </summary>
        public const string JZJBST = "JZJBST";

        /// <summary>
        /// JZKY.
        /// </summary>
        public const string JZKY = "JZKY";

        /// <summary>
        /// JZEFT.
        /// </summary>
        public const string JZEFT = "JZEFT";

        /// <summary>
        /// JZEFTE.
        /// </summary>
        public const string JZEFTE = "JZEFTE";

        /// <summary>
        /// JZTKDT.
        /// </summary>
        public const string JZTKDT = "JZTKDT";

        /// <summary>
        /// JZAMTU.
        /// </summary>
        public const string JZAMTU = "JZAMTU";

        /// <summary>
        /// JZAMTV.
        /// </summary>
        public const string JZAMTV = "JZAMTV";

        /// <summary>
        /// JZRMK.
        /// </summary>
        public const string JZRMK = "JZRMK";

        /// <summary>
        /// JZRMK2.
        /// </summary>
        public const string JZRMK2 = "JZRMK2";

        /// <summary>
        /// JZKYWW.
        /// </summary>
        public const string JZKYWW = "JZKYWW";

        /// <summary>
        /// JZUSER.
        /// </summary>
        public const string JZUSER = "JZUSER";

        /// <summary>
        /// JZUPMJ.
        /// </summary>
        public const string JZUPMJ = "JZUPMJ";

        /// <summary>
        /// JZJOBN.
        /// </summary>
        public const string JZJOBN = "JZJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F08092";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JZRCOD", "JZRCOD", JdeDataType.String, 2, true, true),
        new JdeField("JZTYRC", "JZTYRC", JdeDataType.String, 4, true, true),
        new JdeField("JZAN8", "JZAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JZJBCD", "JZJBCD", JdeDataType.String, 12, true, true),
        new JdeField("JZJBST", "JZJBST", JdeDataType.String, 8, true, true),
        new JdeField("JZKY", "JZKY", JdeDataType.String, 20, true, true),
        new JdeField("JZEFT", "JZEFT", JdeDataType.Numeric, null, true, true),
        new JdeField("JZEFTE", "JZEFTE", JdeDataType.Numeric),
        new JdeField("JZTKDT", "JZTKDT", JdeDataType.Numeric),
        new JdeField("JZAMTU", "JZAMTU", JdeDataType.Numeric),
        new JdeField("JZAMTV", "JZAMTV", JdeDataType.Numeric),
        new JdeField("JZRMK", "JZRMK", JdeDataType.String, 60),
        new JdeField("JZRMK2", "JZRMK2", JdeDataType.String, 60),
        new JdeField("JZKYWW", "JZKYWW", JdeDataType.String, 20),
        new JdeField("JZUSER", "JZUSER", JdeDataType.String, 20),
        new JdeField("JZUPMJ", "JZUPMJ", JdeDataType.Numeric),
        new JdeField("JZJOBN", "JZJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08092_0", "Primary Key on JZRCOD, JZTYRC, JZAN8, JZJBCD, JZJBST, JZKY, JZEFT", new[] { "JZRCOD", "JZTYRC", "JZAN8", "JZJBCD", "JZJBST", "JZKY", "JZEFT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08092_3", "Index on JZRCOD, JZAN8, JZJBCD, JZJBST, JZTYRC, JZKY, JZEFT", new[] { "JZRCOD", "JZAN8", "JZJBCD", "JZJBST", "JZTYRC", "JZKY", "JZEFT" }),
        new JdeIndex("F08092_4", "Index on JZRCOD, JZTYRC, JZKY, SYS_NC00018$, JZAN8, JZJBCD, JZJBST", new[] { "JZRCOD", "JZTYRC", "JZKY", "SYS_NC00018$", "JZAN8", "JZJBCD", "JZJBST" }),
        new JdeIndex("F08092_5", "Index on JZRCOD, JZTYRC, JZAN8, JZJBCD, JZJBST, JZEFT, JZKY", new[] { "JZRCOD", "JZTYRC", "JZAN8", "JZJBCD", "JZJBST", "JZEFT", "JZKY" })
    };
}
