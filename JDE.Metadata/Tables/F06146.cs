using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06146 - .
/// </summary>
public class F06146 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YNAN8.
        /// </summary>
        public const string YNAN8 = "YNAN8";

        /// <summary>
        /// YNPDBA.
        /// </summary>
        public const string YNPDBA = "YNPDBA";

        /// <summary>
        /// YNDISO.
        /// </summary>
        public const string YNDISO = "YNDISO";

        /// <summary>
        /// YNCTRY.
        /// </summary>
        public const string YNCTRY = "YNCTRY";

        /// <summary>
        /// YNDTEY.
        /// </summary>
        public const string YNDTEY = "YNDTEY";

        /// <summary>
        /// YNPBFP.
        /// </summary>
        public const string YNPBFP = "YNPBFP";

        /// <summary>
        /// YNHMCO.
        /// </summary>
        public const string YNHMCO = "YNHMCO";

        /// <summary>
        /// YNTAXX.
        /// </summary>
        public const string YNTAXX = "YNTAXX";

        /// <summary>
        /// YNBWBB.
        /// </summary>
        public const string YNBWBB = "YNBWBB";

        /// <summary>
        /// YNBWPY.
        /// </summary>
        public const string YNBWPY = "YNBWPY";

        /// <summary>
        /// YNBW01.
        /// </summary>
        public const string YNBW01 = "YNBW01";

        /// <summary>
        /// YNBW02.
        /// </summary>
        public const string YNBW02 = "YNBW02";

        /// <summary>
        /// YNBW03.
        /// </summary>
        public const string YNBW03 = "YNBW03";

        /// <summary>
        /// YNBW04.
        /// </summary>
        public const string YNBW04 = "YNBW04";

        /// <summary>
        /// YNBW05.
        /// </summary>
        public const string YNBW05 = "YNBW05";

        /// <summary>
        /// YNBW06.
        /// </summary>
        public const string YNBW06 = "YNBW06";

        /// <summary>
        /// YNBW07.
        /// </summary>
        public const string YNBW07 = "YNBW07";

        /// <summary>
        /// YNBW08.
        /// </summary>
        public const string YNBW08 = "YNBW08";

        /// <summary>
        /// YNBW09.
        /// </summary>
        public const string YNBW09 = "YNBW09";

        /// <summary>
        /// YNBW10.
        /// </summary>
        public const string YNBW10 = "YNBW10";

        /// <summary>
        /// YNBW11.
        /// </summary>
        public const string YNBW11 = "YNBW11";

        /// <summary>
        /// YNBW12.
        /// </summary>
        public const string YNBW12 = "YNBW12";

        /// <summary>
        /// YNARRA.
        /// </summary>
        public const string YNARRA = "YNARRA";

        /// <summary>
        /// YNBHBB.
        /// </summary>
        public const string YNBHBB = "YNBHBB";

        /// <summary>
        /// YNBHPY.
        /// </summary>
        public const string YNBHPY = "YNBHPY";

        /// <summary>
        /// YNBH01.
        /// </summary>
        public const string YNBH01 = "YNBH01";

        /// <summary>
        /// YNBH02.
        /// </summary>
        public const string YNBH02 = "YNBH02";

        /// <summary>
        /// YNBH03.
        /// </summary>
        public const string YNBH03 = "YNBH03";

        /// <summary>
        /// YNBH04.
        /// </summary>
        public const string YNBH04 = "YNBH04";

        /// <summary>
        /// YNBH05.
        /// </summary>
        public const string YNBH05 = "YNBH05";

        /// <summary>
        /// YNBH06.
        /// </summary>
        public const string YNBH06 = "YNBH06";

        /// <summary>
        /// YNBH07.
        /// </summary>
        public const string YNBH07 = "YNBH07";

        /// <summary>
        /// YNBH08.
        /// </summary>
        public const string YNBH08 = "YNBH08";

        /// <summary>
        /// YNBH09.
        /// </summary>
        public const string YNBH09 = "YNBH09";

        /// <summary>
        /// YNBH10.
        /// </summary>
        public const string YNBH10 = "YNBH10";

        /// <summary>
        /// YNBH11.
        /// </summary>
        public const string YNBH11 = "YNBH11";

        /// <summary>
        /// YNBH12.
        /// </summary>
        public const string YNBH12 = "YNBH12";

        /// <summary>
        /// YNBIBB.
        /// </summary>
        public const string YNBIBB = "YNBIBB";

        /// <summary>
        /// YNBIPY.
        /// </summary>
        public const string YNBIPY = "YNBIPY";

        /// <summary>
        /// YNBI01.
        /// </summary>
        public const string YNBI01 = "YNBI01";

        /// <summary>
        /// YNBI02.
        /// </summary>
        public const string YNBI02 = "YNBI02";

        /// <summary>
        /// YNBI03.
        /// </summary>
        public const string YNBI03 = "YNBI03";

        /// <summary>
        /// YNBI04.
        /// </summary>
        public const string YNBI04 = "YNBI04";

        /// <summary>
        /// YNBI05.
        /// </summary>
        public const string YNBI05 = "YNBI05";

        /// <summary>
        /// YNBI06.
        /// </summary>
        public const string YNBI06 = "YNBI06";

        /// <summary>
        /// YNBI07.
        /// </summary>
        public const string YNBI07 = "YNBI07";

        /// <summary>
        /// YNBI08.
        /// </summary>
        public const string YNBI08 = "YNBI08";

        /// <summary>
        /// YNBI09.
        /// </summary>
        public const string YNBI09 = "YNBI09";

        /// <summary>
        /// YNBI10.
        /// </summary>
        public const string YNBI10 = "YNBI10";

        /// <summary>
        /// YNBI11.
        /// </summary>
        public const string YNBI11 = "YNBI11";

        /// <summary>
        /// YNBI12.
        /// </summary>
        public const string YNBI12 = "YNBI12";

        /// <summary>
        /// YNAD.
        /// </summary>
        public const string YNAD = "YNAD";

        /// <summary>
        /// YNNP.
        /// </summary>
        public const string YNNP = "YNNP";

        /// <summary>
        /// YNUSER.
        /// </summary>
        public const string YNUSER = "YNUSER";

        /// <summary>
        /// YNPID.
        /// </summary>
        public const string YNPID = "YNPID";

        /// <summary>
        /// YNUPMJ.
        /// </summary>
        public const string YNUPMJ = "YNUPMJ";

        /// <summary>
        /// YNPAYG.
        /// </summary>
        public const string YNPAYG = "YNPAYG";

        /// <summary>
        /// YNPAYN.
        /// </summary>
        public const string YNPAYN = "YNPAYN";

        /// <summary>
        /// YNDTSP.
        /// </summary>
        public const string YNDTSP = "YNDTSP";

        /// <summary>
        /// YNTHTY.
        /// </summary>
        public const string YNTHTY = "YNTHTY";
    }

    /// <inheritdoc />
    public override string TableName => "F06146";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YNAN8", "YNAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YNPDBA", "YNPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("YNDISO", "YNDISO", JdeDataType.String, 2),
        new JdeField("YNCTRY", "YNCTRY", JdeDataType.Numeric),
        new JdeField("YNDTEY", "YNDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("YNPBFP", "YNPBFP", JdeDataType.Numeric),
        new JdeField("YNHMCO", "YNHMCO", JdeDataType.String, 10, true, true),
        new JdeField("YNTAXX", "YNTAXX", JdeDataType.String, 40, true, true),
        new JdeField("YNBWBB", "YNBWBB", JdeDataType.Numeric),
        new JdeField("YNBWPY", "YNBWPY", JdeDataType.Numeric),
        new JdeField("YNBW01", "YNBW01", JdeDataType.Numeric),
        new JdeField("YNBW02", "YNBW02", JdeDataType.Numeric),
        new JdeField("YNBW03", "YNBW03", JdeDataType.Numeric),
        new JdeField("YNBW04", "YNBW04", JdeDataType.Numeric),
        new JdeField("YNBW05", "YNBW05", JdeDataType.Numeric),
        new JdeField("YNBW06", "YNBW06", JdeDataType.Numeric),
        new JdeField("YNBW07", "YNBW07", JdeDataType.Numeric),
        new JdeField("YNBW08", "YNBW08", JdeDataType.Numeric),
        new JdeField("YNBW09", "YNBW09", JdeDataType.Numeric),
        new JdeField("YNBW10", "YNBW10", JdeDataType.Numeric),
        new JdeField("YNBW11", "YNBW11", JdeDataType.Numeric),
        new JdeField("YNBW12", "YNBW12", JdeDataType.Numeric),
        new JdeField("YNARRA", "YNARRA", JdeDataType.Numeric),
        new JdeField("YNBHBB", "YNBHBB", JdeDataType.Numeric),
        new JdeField("YNBHPY", "YNBHPY", JdeDataType.Numeric),
        new JdeField("YNBH01", "YNBH01", JdeDataType.Numeric),
        new JdeField("YNBH02", "YNBH02", JdeDataType.Numeric),
        new JdeField("YNBH03", "YNBH03", JdeDataType.Numeric),
        new JdeField("YNBH04", "YNBH04", JdeDataType.Numeric),
        new JdeField("YNBH05", "YNBH05", JdeDataType.Numeric),
        new JdeField("YNBH06", "YNBH06", JdeDataType.Numeric),
        new JdeField("YNBH07", "YNBH07", JdeDataType.Numeric),
        new JdeField("YNBH08", "YNBH08", JdeDataType.Numeric),
        new JdeField("YNBH09", "YNBH09", JdeDataType.Numeric),
        new JdeField("YNBH10", "YNBH10", JdeDataType.Numeric),
        new JdeField("YNBH11", "YNBH11", JdeDataType.Numeric),
        new JdeField("YNBH12", "YNBH12", JdeDataType.Numeric),
        new JdeField("YNBIBB", "YNBIBB", JdeDataType.Numeric),
        new JdeField("YNBIPY", "YNBIPY", JdeDataType.Numeric),
        new JdeField("YNBI01", "YNBI01", JdeDataType.Numeric),
        new JdeField("YNBI02", "YNBI02", JdeDataType.Numeric),
        new JdeField("YNBI03", "YNBI03", JdeDataType.Numeric),
        new JdeField("YNBI04", "YNBI04", JdeDataType.Numeric),
        new JdeField("YNBI05", "YNBI05", JdeDataType.Numeric),
        new JdeField("YNBI06", "YNBI06", JdeDataType.Numeric),
        new JdeField("YNBI07", "YNBI07", JdeDataType.Numeric),
        new JdeField("YNBI08", "YNBI08", JdeDataType.Numeric),
        new JdeField("YNBI09", "YNBI09", JdeDataType.Numeric),
        new JdeField("YNBI10", "YNBI10", JdeDataType.Numeric),
        new JdeField("YNBI11", "YNBI11", JdeDataType.Numeric),
        new JdeField("YNBI12", "YNBI12", JdeDataType.Numeric),
        new JdeField("YNAD", "YNAD", JdeDataType.Numeric),
        new JdeField("YNNP", "YNNP", JdeDataType.Numeric),
        new JdeField("YNUSER", "YNUSER", JdeDataType.String, 20),
        new JdeField("YNPID", "YNPID", JdeDataType.String, 20),
        new JdeField("YNUPMJ", "YNUPMJ", JdeDataType.Numeric),
        new JdeField("YNPAYG", "YNPAYG", JdeDataType.String, 2),
        new JdeField("YNPAYN", "YNPAYN", JdeDataType.String, 2),
        new JdeField("YNDTSP", "YNDTSP", JdeDataType.Numeric),
        new JdeField("YNTHTY", "YNTHTY", JdeDataType.String, 2, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06146_0", "Primary Key on YNAN8, YNTHTY, YNPDBA, YNDTEY, YNTAXX, YNHMCO", new[] { "YNAN8", "YNTHTY", "YNPDBA", "YNDTEY", "YNTAXX", "YNHMCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06146_10", "Index on YNAN8, YNPDBA, YNHMCO", new[] { "YNAN8", "YNPDBA", "YNHMCO" }),
        new JdeIndex("F06146_11", "Index on YNAN8, YNHMCO", new[] { "YNAN8", "YNHMCO" }),
        new JdeIndex("F06146_12", "Index on YNPDBA, YNDTEY", new[] { "YNPDBA", "YNDTEY" }),
        new JdeIndex("F06146_2", "Index on YNAN8, YNDTEY, YNTAXX, YNPDBA", new[] { "YNAN8", "YNDTEY", "YNTAXX", "YNPDBA" }),
        new JdeIndex("F06146_3", "Index on YNAN8, YNDTEY, YNHMCO, YNTAXX, YNTHTY, YNPDBA", new[] { "YNAN8", "YNDTEY", "YNHMCO", "YNTAXX", "YNTHTY", "YNPDBA" }),
        new JdeIndex("F06146_4", "Index on YNDTEY, YNHMCO, YNAN8, YNTHTY, YNPDBA", new[] { "YNDTEY", "YNHMCO", "YNAN8", "YNTHTY", "YNPDBA" }),
        new JdeIndex("F06146_5", "Index on YNDTEY, YNHMCO, YNPDBA, YNAN8, YNTHTY", new[] { "YNDTEY", "YNHMCO", "YNPDBA", "YNAN8", "YNTHTY" }),
        new JdeIndex("F06146_6", "Index on YNAN8, YNDTEY, YNTAXX, YNTHTY, YNPDBA", new[] { "YNAN8", "YNDTEY", "YNTAXX", "YNTHTY", "YNPDBA" }),
        new JdeIndex("F06146_7", "Index on YNDTEY, YNAN8, YNHMCO, YNTHTY, YNPDBA", new[] { "YNDTEY", "YNAN8", "YNHMCO", "YNTHTY", "YNPDBA" }),
        new JdeIndex("F06146_8", "Index on YNDTEY, YNAN8, YNTHTY, YNPDBA, YNTAXX, YNHMCO", new[] { "YNDTEY", "YNAN8", "YNTHTY", "YNPDBA", "YNTAXX", "YNHMCO" }),
        new JdeIndex("F06146_9", "Index on YNAN8, YNPDBA, YNDTEY, YNTAXX, YNHMCO", new[] { "YNAN8", "YNPDBA", "YNDTEY", "YNTAXX", "YNHMCO" })
    };
}
