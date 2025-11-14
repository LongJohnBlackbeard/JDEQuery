using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08117 - .
/// </summary>
public class F08117 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AEPLAN.
        /// </summary>
        public const string AEPLAN = "AEPLAN";

        /// <summary>
        /// AEAOPT.
        /// </summary>
        public const string AEAOPT = "AEAOPT";

        /// <summary>
        /// AEUN.
        /// </summary>
        public const string AEUN = "AEUN";

        /// <summary>
        /// AEPDBA.
        /// </summary>
        public const string AEPDBA = "AEPDBA";

        /// <summary>
        /// AEAN8.
        /// </summary>
        public const string AEAN8 = "AEAN8";

        /// <summary>
        /// AEACLN.
        /// </summary>
        public const string AEACLN = "AEACLN";

        /// <summary>
        /// AEEFT.
        /// </summary>
        public const string AEEFT = "AEEFT";

        /// <summary>
        /// AEEFTE.
        /// </summary>
        public const string AEEFTE = "AEEFTE";

        /// <summary>
        /// AEAOCC.
        /// </summary>
        public const string AEAOCC = "AEAOCC";

        /// <summary>
        /// AEALCP.
        /// </summary>
        public const string AEALCP = "AEALCP";

        /// <summary>
        /// AEASHC.
        /// </summary>
        public const string AEASHC = "AEASHC";

        /// <summary>
        /// AESPASUSF1.
        /// </summary>
        public const string AESPASUSF1 = "AESPASUSF1";

        /// <summary>
        /// AESPASUSF2.
        /// </summary>
        public const string AESPASUSF2 = "AESPASUSF2";

        /// <summary>
        /// AESPASUSF3.
        /// </summary>
        public const string AESPASUSF3 = "AESPASUSF3";

        /// <summary>
        /// AESPASUSF4.
        /// </summary>
        public const string AESPASUSF4 = "AESPASUSF4";

        /// <summary>
        /// AESPANUSF1.
        /// </summary>
        public const string AESPANUSF1 = "AESPANUSF1";

        /// <summary>
        /// AESPANUSF2.
        /// </summary>
        public const string AESPANUSF2 = "AESPANUSF2";

        /// <summary>
        /// AESPANUSF3.
        /// </summary>
        public const string AESPANUSF3 = "AESPANUSF3";

        /// <summary>
        /// AESPANUSF4.
        /// </summary>
        public const string AESPANUSF4 = "AESPANUSF4";

        /// <summary>
        /// AESPADUSF1.
        /// </summary>
        public const string AESPADUSF1 = "AESPADUSF1";

        /// <summary>
        /// AESPADUSF2.
        /// </summary>
        public const string AESPADUSF2 = "AESPADUSF2";

        /// <summary>
        /// AESPADUSF3.
        /// </summary>
        public const string AESPADUSF3 = "AESPADUSF3";

        /// <summary>
        /// AESPADUSF4.
        /// </summary>
        public const string AESPADUSF4 = "AESPADUSF4";

        /// <summary>
        /// AESPACUSF1.
        /// </summary>
        public const string AESPACUSF1 = "AESPACUSF1";

        /// <summary>
        /// AESPACUSF2.
        /// </summary>
        public const string AESPACUSF2 = "AESPACUSF2";

        /// <summary>
        /// AESPACUSF3.
        /// </summary>
        public const string AESPACUSF3 = "AESPACUSF3";

        /// <summary>
        /// AESPACUSF4.
        /// </summary>
        public const string AESPACUSF4 = "AESPACUSF4";

        /// <summary>
        /// AEPID.
        /// </summary>
        public const string AEPID = "AEPID";

        /// <summary>
        /// AEUSER.
        /// </summary>
        public const string AEUSER = "AEUSER";

        /// <summary>
        /// AEJOBN.
        /// </summary>
        public const string AEJOBN = "AEJOBN";

        /// <summary>
        /// AEUPMJ.
        /// </summary>
        public const string AEUPMJ = "AEUPMJ";

        /// <summary>
        /// AEUPMT.
        /// </summary>
        public const string AEUPMT = "AEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08117";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AEPLAN", "AEPLAN", JdeDataType.String, 16, true, true),
        new JdeField("AEAOPT", "AEAOPT", JdeDataType.String, 6, true, true),
        new JdeField("AEUN", "AEUN", JdeDataType.String, 12, true, true),
        new JdeField("AEPDBA", "AEPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("AEAN8", "AEAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AEACLN", "AEACLN", JdeDataType.String, 8, true, true),
        new JdeField("AEEFT", "AEEFT", JdeDataType.Numeric, null, true, true),
        new JdeField("AEEFTE", "AEEFTE", JdeDataType.Numeric),
        new JdeField("AEAOCC", "AEAOCC", JdeDataType.String, 8),
        new JdeField("AEALCP", "AEALCP", JdeDataType.Numeric),
        new JdeField("AEASHC", "AEASHC", JdeDataType.String, 8),
        new JdeField("AESPASUSF1", "AESPASUSF1", JdeDataType.String, 60),
        new JdeField("AESPASUSF2", "AESPASUSF2", JdeDataType.String, 60),
        new JdeField("AESPASUSF3", "AESPASUSF3", JdeDataType.String, 60),
        new JdeField("AESPASUSF4", "AESPASUSF4", JdeDataType.String, 60),
        new JdeField("AESPANUSF1", "AESPANUSF1", JdeDataType.Numeric),
        new JdeField("AESPANUSF2", "AESPANUSF2", JdeDataType.Numeric),
        new JdeField("AESPANUSF3", "AESPANUSF3", JdeDataType.Numeric),
        new JdeField("AESPANUSF4", "AESPANUSF4", JdeDataType.Numeric),
        new JdeField("AESPADUSF1", "AESPADUSF1", JdeDataType.Numeric),
        new JdeField("AESPADUSF2", "AESPADUSF2", JdeDataType.Numeric),
        new JdeField("AESPADUSF3", "AESPADUSF3", JdeDataType.Numeric),
        new JdeField("AESPADUSF4", "AESPADUSF4", JdeDataType.Numeric),
        new JdeField("AESPACUSF1", "AESPACUSF1", JdeDataType.String, 2),
        new JdeField("AESPACUSF2", "AESPACUSF2", JdeDataType.String, 2),
        new JdeField("AESPACUSF3", "AESPACUSF3", JdeDataType.String, 2),
        new JdeField("AESPACUSF4", "AESPACUSF4", JdeDataType.String, 2),
        new JdeField("AEPID", "AEPID", JdeDataType.String, 20),
        new JdeField("AEUSER", "AEUSER", JdeDataType.String, 20),
        new JdeField("AEJOBN", "AEJOBN", JdeDataType.String, 20),
        new JdeField("AEUPMJ", "AEUPMJ", JdeDataType.Numeric),
        new JdeField("AEUPMT", "AEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08117_0", "Primary Key on AEPLAN, AEAOPT, AEUN, AEPDBA, AEAN8, AEACLN, AEEFT", new[] { "AEPLAN", "AEAOPT", "AEUN", "AEPDBA", "AEAN8", "AEACLN", "AEEFT" }, isUnique: true, isPrimaryKey: true)
    };
}
