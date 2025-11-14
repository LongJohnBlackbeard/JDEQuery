using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06024 - .
/// </summary>
public class F06024 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YJPCNO.
        /// </summary>
        public const string YJPCNO = "YJPCNO";

        /// <summary>
        /// YJPRTT.
        /// </summary>
        public const string YJPRTT = "YJPRTT";

        /// <summary>
        /// YJBDDC.
        /// </summary>
        public const string YJBDDC = "YJBDDC";

        /// <summary>
        /// YJPAN8.
        /// </summary>
        public const string YJPAN8 = "YJPAN8";

        /// <summary>
        /// YJBDCD.
        /// </summary>
        public const string YJBDCD = "YJBDCD";

        /// <summary>
        /// YJOWNC.
        /// </summary>
        public const string YJOWNC = "YJOWNC";

        /// <summary>
        /// YJBDRC.
        /// </summary>
        public const string YJBDRC = "YJBDRC";

        /// <summary>
        /// YJBDOA.
        /// </summary>
        public const string YJBDOA = "YJBDOA";

        /// <summary>
        /// YJBDOM.
        /// </summary>
        public const string YJBDOM = "YJBDOM";

        /// <summary>
        /// YJEFTE.
        /// </summary>
        public const string YJEFTE = "YJEFTE";

        /// <summary>
        /// YJEFTB.
        /// </summary>
        public const string YJEFTB = "YJEFTB";

        /// <summary>
        /// YJREL.
        /// </summary>
        public const string YJREL = "YJREL";
    }

    /// <inheritdoc />
    public override string TableName => "F06024";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YJPCNO", "YJPCNO", JdeDataType.Numeric, null, true, true),
        new JdeField("YJPRTT", "YJPRTT", JdeDataType.String, 2, true, true),
        new JdeField("YJBDDC", "YJBDDC", JdeDataType.Numeric),
        new JdeField("YJPAN8", "YJPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YJBDCD", "YJBDCD", JdeDataType.String, 6),
        new JdeField("YJOWNC", "YJOWNC", JdeDataType.String, 2),
        new JdeField("YJBDRC", "YJBDRC", JdeDataType.String, 2),
        new JdeField("YJBDOA", "YJBDOA", JdeDataType.Numeric),
        new JdeField("YJBDOM", "YJBDOM", JdeDataType.String, 2),
        new JdeField("YJEFTE", "YJEFTE", JdeDataType.Numeric),
        new JdeField("YJEFTB", "YJEFTB", JdeDataType.Numeric),
        new JdeField("YJREL", "YJREL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06024_0", "Primary Key on YJPCNO, YJPRTT, YJPAN8", new[] { "YJPCNO", "YJPRTT", "YJPAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06024_2", "Index on YJPAN8", new[] { "YJPAN8" })
    };
}
