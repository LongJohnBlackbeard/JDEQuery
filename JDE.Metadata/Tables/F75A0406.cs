using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A0406 - .
/// </summary>
public class F75A0406 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZHCO.
        /// </summary>
        public const string ZHCO = "ZHCO";

        /// <summary>
        /// ZHWKSE.
        /// </summary>
        public const string ZHWKSE = "ZHWKSE";

        /// <summary>
        /// ZHAN8.
        /// </summary>
        public const string ZHAN8 = "ZHAN8";

        /// <summary>
        /// ZHPDBA.
        /// </summary>
        public const string ZHPDBA = "ZHPDBA";

        /// <summary>
        /// ZHAUSPTHT.
        /// </summary>
        public const string ZHAUSPTHT = "ZHAUSPTHT";

        /// <summary>
        /// ZHAUSPTY.
        /// </summary>
        public const string ZHAUSPTY = "ZHAUSPTY";

        /// <summary>
        /// ZHAUSPTCW.
        /// </summary>
        public const string ZHAUSPTCW = "ZHAUSPTCW";

        /// <summary>
        /// ZHAUSPTJAW.
        /// </summary>
        public const string ZHAUSPTJAW = "ZHAUSPTJAW";

        /// <summary>
        /// ZHAUSPTFBW.
        /// </summary>
        public const string ZHAUSPTFBW = "ZHAUSPTFBW";

        /// <summary>
        /// ZHAUSPTMRW.
        /// </summary>
        public const string ZHAUSPTMRW = "ZHAUSPTMRW";

        /// <summary>
        /// ZHAUSPTAPW.
        /// </summary>
        public const string ZHAUSPTAPW = "ZHAUSPTAPW";

        /// <summary>
        /// ZHAUSPTMYW.
        /// </summary>
        public const string ZHAUSPTMYW = "ZHAUSPTMYW";

        /// <summary>
        /// ZHAUSPTJNW.
        /// </summary>
        public const string ZHAUSPTJNW = "ZHAUSPTJNW";

        /// <summary>
        /// ZHAUSPTJLW.
        /// </summary>
        public const string ZHAUSPTJLW = "ZHAUSPTJLW";

        /// <summary>
        /// ZHAUSPTAUW.
        /// </summary>
        public const string ZHAUSPTAUW = "ZHAUSPTAUW";

        /// <summary>
        /// ZHAUSPTSPW.
        /// </summary>
        public const string ZHAUSPTSPW = "ZHAUSPTSPW";

        /// <summary>
        /// ZHAUSPTOCW.
        /// </summary>
        public const string ZHAUSPTOCW = "ZHAUSPTOCW";

        /// <summary>
        /// ZHAUSPTNVW.
        /// </summary>
        public const string ZHAUSPTNVW = "ZHAUSPTNVW";

        /// <summary>
        /// ZHAUSPTDCW.
        /// </summary>
        public const string ZHAUSPTDCW = "ZHAUSPTDCW";

        /// <summary>
        /// ZHAUSPT1QW.
        /// </summary>
        public const string ZHAUSPT1QW = "ZHAUSPT1QW";

        /// <summary>
        /// ZHAUSPT2QW.
        /// </summary>
        public const string ZHAUSPT2QW = "ZHAUSPT2QW";

        /// <summary>
        /// ZHAUSPT3QW.
        /// </summary>
        public const string ZHAUSPT3QW = "ZHAUSPT3QW";

        /// <summary>
        /// ZHAUSPT4QW.
        /// </summary>
        public const string ZHAUSPT4QW = "ZHAUSPT4QW";

        /// <summary>
        /// ZHAUSPTYW.
        /// </summary>
        public const string ZHAUSPTYW = "ZHAUSPTYW";

        /// <summary>
        /// ZHUSER.
        /// </summary>
        public const string ZHUSER = "ZHUSER";

        /// <summary>
        /// ZHPID.
        /// </summary>
        public const string ZHPID = "ZHPID";

        /// <summary>
        /// ZHUPMJ.
        /// </summary>
        public const string ZHUPMJ = "ZHUPMJ";

        /// <summary>
        /// ZHUPMT.
        /// </summary>
        public const string ZHUPMT = "ZHUPMT";

        /// <summary>
        /// ZHJOBN.
        /// </summary>
        public const string ZHJOBN = "ZHJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75A0406";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZHCO", "ZHCO", JdeDataType.String, 10, true, true),
        new JdeField("ZHWKSE", "ZHWKSE", JdeDataType.String, 6, true, true),
        new JdeField("ZHAN8", "ZHAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ZHPDBA", "ZHPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("ZHAUSPTHT", "ZHAUSPTHT", JdeDataType.String, 4, true, true),
        new JdeField("ZHAUSPTY", "ZHAUSPTY", JdeDataType.Numeric, null, true, true),
        new JdeField("ZHAUSPTCW", "ZHAUSPTCW", JdeDataType.Numeric),
        new JdeField("ZHAUSPTJAW", "ZHAUSPTJAW", JdeDataType.Numeric),
        new JdeField("ZHAUSPTFBW", "ZHAUSPTFBW", JdeDataType.Numeric),
        new JdeField("ZHAUSPTMRW", "ZHAUSPTMRW", JdeDataType.Numeric),
        new JdeField("ZHAUSPTAPW", "ZHAUSPTAPW", JdeDataType.Numeric),
        new JdeField("ZHAUSPTMYW", "ZHAUSPTMYW", JdeDataType.Numeric),
        new JdeField("ZHAUSPTJNW", "ZHAUSPTJNW", JdeDataType.Numeric),
        new JdeField("ZHAUSPTJLW", "ZHAUSPTJLW", JdeDataType.Numeric),
        new JdeField("ZHAUSPTAUW", "ZHAUSPTAUW", JdeDataType.Numeric),
        new JdeField("ZHAUSPTSPW", "ZHAUSPTSPW", JdeDataType.Numeric),
        new JdeField("ZHAUSPTOCW", "ZHAUSPTOCW", JdeDataType.Numeric),
        new JdeField("ZHAUSPTNVW", "ZHAUSPTNVW", JdeDataType.Numeric),
        new JdeField("ZHAUSPTDCW", "ZHAUSPTDCW", JdeDataType.Numeric),
        new JdeField("ZHAUSPT1QW", "ZHAUSPT1QW", JdeDataType.Numeric),
        new JdeField("ZHAUSPT2QW", "ZHAUSPT2QW", JdeDataType.Numeric),
        new JdeField("ZHAUSPT3QW", "ZHAUSPT3QW", JdeDataType.Numeric),
        new JdeField("ZHAUSPT4QW", "ZHAUSPT4QW", JdeDataType.Numeric),
        new JdeField("ZHAUSPTYW", "ZHAUSPTYW", JdeDataType.Numeric),
        new JdeField("ZHUSER", "ZHUSER", JdeDataType.String, 20),
        new JdeField("ZHPID", "ZHPID", JdeDataType.String, 20),
        new JdeField("ZHUPMJ", "ZHUPMJ", JdeDataType.Numeric),
        new JdeField("ZHUPMT", "ZHUPMT", JdeDataType.Numeric),
        new JdeField("ZHJOBN", "ZHJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A0406_0", "Primary Key on ZHCO, ZHWKSE, ZHAN8, ZHPDBA, ZHAUSPTHT, ZHAUSPTY", new[] { "ZHCO", "ZHWKSE", "ZHAN8", "ZHPDBA", "ZHAUSPTHT", "ZHAUSPTY" }, isUnique: true, isPrimaryKey: true)
    };
}
