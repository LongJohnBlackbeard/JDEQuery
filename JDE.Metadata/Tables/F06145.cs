using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06145 - .
/// </summary>
public class F06145 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YHAN8.
        /// </summary>
        public const string YHAN8 = "YHAN8";

        /// <summary>
        /// YHPDBA.
        /// </summary>
        public const string YHPDBA = "YHPDBA";

        /// <summary>
        /// YHDISO.
        /// </summary>
        public const string YHDISO = "YHDISO";

        /// <summary>
        /// YHCTRY.
        /// </summary>
        public const string YHCTRY = "YHCTRY";

        /// <summary>
        /// YHDTEY.
        /// </summary>
        public const string YHDTEY = "YHDTEY";

        /// <summary>
        /// YHPBFP.
        /// </summary>
        public const string YHPBFP = "YHPBFP";

        /// <summary>
        /// YHHMCO.
        /// </summary>
        public const string YHHMCO = "YHHMCO";

        /// <summary>
        /// YHTAXX.
        /// </summary>
        public const string YHTAXX = "YHTAXX";

        /// <summary>
        /// YHBWBB.
        /// </summary>
        public const string YHBWBB = "YHBWBB";

        /// <summary>
        /// YHBWPY.
        /// </summary>
        public const string YHBWPY = "YHBWPY";

        /// <summary>
        /// YHBW01.
        /// </summary>
        public const string YHBW01 = "YHBW01";

        /// <summary>
        /// YHBW02.
        /// </summary>
        public const string YHBW02 = "YHBW02";

        /// <summary>
        /// YHBW03.
        /// </summary>
        public const string YHBW03 = "YHBW03";

        /// <summary>
        /// YHBW04.
        /// </summary>
        public const string YHBW04 = "YHBW04";

        /// <summary>
        /// YHBW05.
        /// </summary>
        public const string YHBW05 = "YHBW05";

        /// <summary>
        /// YHBW06.
        /// </summary>
        public const string YHBW06 = "YHBW06";

        /// <summary>
        /// YHBW07.
        /// </summary>
        public const string YHBW07 = "YHBW07";

        /// <summary>
        /// YHBW08.
        /// </summary>
        public const string YHBW08 = "YHBW08";

        /// <summary>
        /// YHBW09.
        /// </summary>
        public const string YHBW09 = "YHBW09";

        /// <summary>
        /// YHBW10.
        /// </summary>
        public const string YHBW10 = "YHBW10";

        /// <summary>
        /// YHBW11.
        /// </summary>
        public const string YHBW11 = "YHBW11";

        /// <summary>
        /// YHBW12.
        /// </summary>
        public const string YHBW12 = "YHBW12";

        /// <summary>
        /// YHBHBB.
        /// </summary>
        public const string YHBHBB = "YHBHBB";

        /// <summary>
        /// YHHWPY.
        /// </summary>
        public const string YHHWPY = "YHHWPY";

        /// <summary>
        /// YHHW01.
        /// </summary>
        public const string YHHW01 = "YHHW01";

        /// <summary>
        /// YHHW02.
        /// </summary>
        public const string YHHW02 = "YHHW02";

        /// <summary>
        /// YHHW03.
        /// </summary>
        public const string YHHW03 = "YHHW03";

        /// <summary>
        /// YHHW04.
        /// </summary>
        public const string YHHW04 = "YHHW04";

        /// <summary>
        /// YHHW05.
        /// </summary>
        public const string YHHW05 = "YHHW05";

        /// <summary>
        /// YHHW06.
        /// </summary>
        public const string YHHW06 = "YHHW06";

        /// <summary>
        /// YHHW07.
        /// </summary>
        public const string YHHW07 = "YHHW07";

        /// <summary>
        /// YHHW08.
        /// </summary>
        public const string YHHW08 = "YHHW08";

        /// <summary>
        /// YHHW09.
        /// </summary>
        public const string YHHW09 = "YHHW09";

        /// <summary>
        /// YHHW10.
        /// </summary>
        public const string YHHW10 = "YHHW10";

        /// <summary>
        /// YHHW11.
        /// </summary>
        public const string YHHW11 = "YHHW11";

        /// <summary>
        /// YHHW12.
        /// </summary>
        public const string YHHW12 = "YHHW12";

        /// <summary>
        /// YHBIBB.
        /// </summary>
        public const string YHBIBB = "YHBIBB";

        /// <summary>
        /// YHPIPY.
        /// </summary>
        public const string YHPIPY = "YHPIPY";

        /// <summary>
        /// YHPI01.
        /// </summary>
        public const string YHPI01 = "YHPI01";

        /// <summary>
        /// YHPI02.
        /// </summary>
        public const string YHPI02 = "YHPI02";

        /// <summary>
        /// YHPI03.
        /// </summary>
        public const string YHPI03 = "YHPI03";

        /// <summary>
        /// YHPI04.
        /// </summary>
        public const string YHPI04 = "YHPI04";

        /// <summary>
        /// YHPI05.
        /// </summary>
        public const string YHPI05 = "YHPI05";

        /// <summary>
        /// YHPI06.
        /// </summary>
        public const string YHPI06 = "YHPI06";

        /// <summary>
        /// YHPI07.
        /// </summary>
        public const string YHPI07 = "YHPI07";

        /// <summary>
        /// YHPI08.
        /// </summary>
        public const string YHPI08 = "YHPI08";

        /// <summary>
        /// YHPI09.
        /// </summary>
        public const string YHPI09 = "YHPI09";

        /// <summary>
        /// YHPI10.
        /// </summary>
        public const string YHPI10 = "YHPI10";

        /// <summary>
        /// YHPI11.
        /// </summary>
        public const string YHPI11 = "YHPI11";

        /// <summary>
        /// YHPI12.
        /// </summary>
        public const string YHPI12 = "YHPI12";

        /// <summary>
        /// YHUSER.
        /// </summary>
        public const string YHUSER = "YHUSER";

        /// <summary>
        /// YHPID.
        /// </summary>
        public const string YHPID = "YHPID";

        /// <summary>
        /// YHUPMJ.
        /// </summary>
        public const string YHUPMJ = "YHUPMJ";

        /// <summary>
        /// YHDTSP.
        /// </summary>
        public const string YHDTSP = "YHDTSP";
    }

    /// <inheritdoc />
    public override string TableName => "F06145";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YHAN8", "YHAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YHPDBA", "YHPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("YHDISO", "YHDISO", JdeDataType.String, 2),
        new JdeField("YHCTRY", "YHCTRY", JdeDataType.Numeric),
        new JdeField("YHDTEY", "YHDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("YHPBFP", "YHPBFP", JdeDataType.Numeric),
        new JdeField("YHHMCO", "YHHMCO", JdeDataType.String, 10, true, true),
        new JdeField("YHTAXX", "YHTAXX", JdeDataType.String, 40, true, true),
        new JdeField("YHBWBB", "YHBWBB", JdeDataType.Numeric),
        new JdeField("YHBWPY", "YHBWPY", JdeDataType.Numeric),
        new JdeField("YHBW01", "YHBW01", JdeDataType.Numeric),
        new JdeField("YHBW02", "YHBW02", JdeDataType.Numeric),
        new JdeField("YHBW03", "YHBW03", JdeDataType.Numeric),
        new JdeField("YHBW04", "YHBW04", JdeDataType.Numeric),
        new JdeField("YHBW05", "YHBW05", JdeDataType.Numeric),
        new JdeField("YHBW06", "YHBW06", JdeDataType.Numeric),
        new JdeField("YHBW07", "YHBW07", JdeDataType.Numeric),
        new JdeField("YHBW08", "YHBW08", JdeDataType.Numeric),
        new JdeField("YHBW09", "YHBW09", JdeDataType.Numeric),
        new JdeField("YHBW10", "YHBW10", JdeDataType.Numeric),
        new JdeField("YHBW11", "YHBW11", JdeDataType.Numeric),
        new JdeField("YHBW12", "YHBW12", JdeDataType.Numeric),
        new JdeField("YHBHBB", "YHBHBB", JdeDataType.Numeric),
        new JdeField("YHHWPY", "YHHWPY", JdeDataType.Numeric),
        new JdeField("YHHW01", "YHHW01", JdeDataType.Numeric),
        new JdeField("YHHW02", "YHHW02", JdeDataType.Numeric),
        new JdeField("YHHW03", "YHHW03", JdeDataType.Numeric),
        new JdeField("YHHW04", "YHHW04", JdeDataType.Numeric),
        new JdeField("YHHW05", "YHHW05", JdeDataType.Numeric),
        new JdeField("YHHW06", "YHHW06", JdeDataType.Numeric),
        new JdeField("YHHW07", "YHHW07", JdeDataType.Numeric),
        new JdeField("YHHW08", "YHHW08", JdeDataType.Numeric),
        new JdeField("YHHW09", "YHHW09", JdeDataType.Numeric),
        new JdeField("YHHW10", "YHHW10", JdeDataType.Numeric),
        new JdeField("YHHW11", "YHHW11", JdeDataType.Numeric),
        new JdeField("YHHW12", "YHHW12", JdeDataType.Numeric),
        new JdeField("YHBIBB", "YHBIBB", JdeDataType.Numeric),
        new JdeField("YHPIPY", "YHPIPY", JdeDataType.Numeric),
        new JdeField("YHPI01", "YHPI01", JdeDataType.Numeric),
        new JdeField("YHPI02", "YHPI02", JdeDataType.Numeric),
        new JdeField("YHPI03", "YHPI03", JdeDataType.Numeric),
        new JdeField("YHPI04", "YHPI04", JdeDataType.Numeric),
        new JdeField("YHPI05", "YHPI05", JdeDataType.Numeric),
        new JdeField("YHPI06", "YHPI06", JdeDataType.Numeric),
        new JdeField("YHPI07", "YHPI07", JdeDataType.Numeric),
        new JdeField("YHPI08", "YHPI08", JdeDataType.Numeric),
        new JdeField("YHPI09", "YHPI09", JdeDataType.Numeric),
        new JdeField("YHPI10", "YHPI10", JdeDataType.Numeric),
        new JdeField("YHPI11", "YHPI11", JdeDataType.Numeric),
        new JdeField("YHPI12", "YHPI12", JdeDataType.Numeric),
        new JdeField("YHUSER", "YHUSER", JdeDataType.String, 20),
        new JdeField("YHPID", "YHPID", JdeDataType.String, 20),
        new JdeField("YHUPMJ", "YHUPMJ", JdeDataType.Numeric),
        new JdeField("YHDTSP", "YHDTSP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06145_0", "Primary Key on YHAN8, YHPDBA, YHDTEY, YHTAXX, YHHMCO", new[] { "YHAN8", "YHPDBA", "YHDTEY", "YHTAXX", "YHHMCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06145_2", "Index on YHDTEY, YHAN8, YHHMCO, YHPDBA", new[] { "YHDTEY", "YHAN8", "YHHMCO", "YHPDBA" }),
        new JdeIndex("F06145_3", "Index on YHAN8, YHDTEY, YHTAXX, YHPDBA", new[] { "YHAN8", "YHDTEY", "YHTAXX", "YHPDBA" })
    };
}
