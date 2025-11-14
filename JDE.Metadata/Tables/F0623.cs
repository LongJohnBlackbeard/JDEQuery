using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0623 - .
/// </summary>
public class F0623 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JLAN8.
        /// </summary>
        public const string JLAN8 = "JLAN8";

        /// <summary>
        /// JLMCU.
        /// </summary>
        public const string JLMCU = "JLMCU";

        /// <summary>
        /// JLSBL.
        /// </summary>
        public const string JLSBL = "JLSBL";

        /// <summary>
        /// JLSBLT.
        /// </summary>
        public const string JLSBLT = "JLSBLT";

        /// <summary>
        /// JLRILT.
        /// </summary>
        public const string JLRILT = "JLRILT";

        /// <summary>
        /// JLITM.
        /// </summary>
        public const string JLITM = "JLITM";

        /// <summary>
        /// JLUM.
        /// </summary>
        public const string JLUM = "JLUM";

        /// <summary>
        /// JLCTRY.
        /// </summary>
        public const string JLCTRY = "JLCTRY";

        /// <summary>
        /// JLDTEY.
        /// </summary>
        public const string JLDTEY = "JLDTEY";

        /// <summary>
        /// JLHMCO.
        /// </summary>
        public const string JLHMCO = "JLHMCO";

        /// <summary>
        /// JLTAXX.
        /// </summary>
        public const string JLTAXX = "JLTAXX";

        /// <summary>
        /// JLBIBB.
        /// </summary>
        public const string JLBIBB = "JLBIBB";

        /// <summary>
        /// JLBIPY.
        /// </summary>
        public const string JLBIPY = "JLBIPY";

        /// <summary>
        /// JLBI01.
        /// </summary>
        public const string JLBI01 = "JLBI01";

        /// <summary>
        /// JLBI02.
        /// </summary>
        public const string JLBI02 = "JLBI02";

        /// <summary>
        /// JLBI03.
        /// </summary>
        public const string JLBI03 = "JLBI03";

        /// <summary>
        /// JLBI04.
        /// </summary>
        public const string JLBI04 = "JLBI04";

        /// <summary>
        /// JLBI05.
        /// </summary>
        public const string JLBI05 = "JLBI05";

        /// <summary>
        /// JLBI06.
        /// </summary>
        public const string JLBI06 = "JLBI06";

        /// <summary>
        /// JLBI07.
        /// </summary>
        public const string JLBI07 = "JLBI07";

        /// <summary>
        /// JLBI08.
        /// </summary>
        public const string JLBI08 = "JLBI08";

        /// <summary>
        /// JLBI09.
        /// </summary>
        public const string JLBI09 = "JLBI09";

        /// <summary>
        /// JLBI10.
        /// </summary>
        public const string JLBI10 = "JLBI10";

        /// <summary>
        /// JLBI11.
        /// </summary>
        public const string JLBI11 = "JLBI11";

        /// <summary>
        /// JLBI12.
        /// </summary>
        public const string JLBI12 = "JLBI12";

        /// <summary>
        /// JLBHBB.
        /// </summary>
        public const string JLBHBB = "JLBHBB";

        /// <summary>
        /// JLBHPY.
        /// </summary>
        public const string JLBHPY = "JLBHPY";

        /// <summary>
        /// JLBH01.
        /// </summary>
        public const string JLBH01 = "JLBH01";

        /// <summary>
        /// JLBH02.
        /// </summary>
        public const string JLBH02 = "JLBH02";

        /// <summary>
        /// JLBH03.
        /// </summary>
        public const string JLBH03 = "JLBH03";

        /// <summary>
        /// JLBH04.
        /// </summary>
        public const string JLBH04 = "JLBH04";

        /// <summary>
        /// JLBH05.
        /// </summary>
        public const string JLBH05 = "JLBH05";

        /// <summary>
        /// JLBH06.
        /// </summary>
        public const string JLBH06 = "JLBH06";

        /// <summary>
        /// JLBH07.
        /// </summary>
        public const string JLBH07 = "JLBH07";

        /// <summary>
        /// JLBH08.
        /// </summary>
        public const string JLBH08 = "JLBH08";

        /// <summary>
        /// JLBH09.
        /// </summary>
        public const string JLBH09 = "JLBH09";

        /// <summary>
        /// JLBH10.
        /// </summary>
        public const string JLBH10 = "JLBH10";

        /// <summary>
        /// JLBH11.
        /// </summary>
        public const string JLBH11 = "JLBH11";

        /// <summary>
        /// JLBH12.
        /// </summary>
        public const string JLBH12 = "JLBH12";

        /// <summary>
        /// JLBWBB.
        /// </summary>
        public const string JLBWBB = "JLBWBB";

        /// <summary>
        /// JLBWPY.
        /// </summary>
        public const string JLBWPY = "JLBWPY";

        /// <summary>
        /// JLBW01.
        /// </summary>
        public const string JLBW01 = "JLBW01";

        /// <summary>
        /// JLBW02.
        /// </summary>
        public const string JLBW02 = "JLBW02";

        /// <summary>
        /// JLBW03.
        /// </summary>
        public const string JLBW03 = "JLBW03";

        /// <summary>
        /// JLBW04.
        /// </summary>
        public const string JLBW04 = "JLBW04";

        /// <summary>
        /// JLBW05.
        /// </summary>
        public const string JLBW05 = "JLBW05";

        /// <summary>
        /// JLBW06.
        /// </summary>
        public const string JLBW06 = "JLBW06";

        /// <summary>
        /// JLBW07.
        /// </summary>
        public const string JLBW07 = "JLBW07";

        /// <summary>
        /// JLBW08.
        /// </summary>
        public const string JLBW08 = "JLBW08";

        /// <summary>
        /// JLBW09.
        /// </summary>
        public const string JLBW09 = "JLBW09";

        /// <summary>
        /// JLBW10.
        /// </summary>
        public const string JLBW10 = "JLBW10";

        /// <summary>
        /// JLBW11.
        /// </summary>
        public const string JLBW11 = "JLBW11";

        /// <summary>
        /// JLBW12.
        /// </summary>
        public const string JLBW12 = "JLBW12";

        /// <summary>
        /// JLUSER.
        /// </summary>
        public const string JLUSER = "JLUSER";

        /// <summary>
        /// JLPID.
        /// </summary>
        public const string JLPID = "JLPID";

        /// <summary>
        /// JLUPMJ.
        /// </summary>
        public const string JLUPMJ = "JLUPMJ";

        /// <summary>
        /// JLUUSR.
        /// </summary>
        public const string JLUUSR = "JLUUSR";

        /// <summary>
        /// JLUUPM.
        /// </summary>
        public const string JLUUPM = "JLUUPM";

        /// <summary>
        /// JLDTSP.
        /// </summary>
        public const string JLDTSP = "JLDTSP";
    }

    /// <inheritdoc />
    public override string TableName => "F0623";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JLAN8", "JLAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JLMCU", "JLMCU", JdeDataType.String, 24, true, true),
        new JdeField("JLSBL", "JLSBL", JdeDataType.String, 16, true, true),
        new JdeField("JLSBLT", "JLSBLT", JdeDataType.String, 2, true, true),
        new JdeField("JLRILT", "JLRILT", JdeDataType.String, 2),
        new JdeField("JLITM", "JLITM", JdeDataType.Numeric, null, true, true),
        new JdeField("JLUM", "JLUM", JdeDataType.String, 4, true, true),
        new JdeField("JLCTRY", "JLCTRY", JdeDataType.Numeric),
        new JdeField("JLDTEY", "JLDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("JLHMCO", "JLHMCO", JdeDataType.String, 10),
        new JdeField("JLTAXX", "JLTAXX", JdeDataType.String, 40),
        new JdeField("JLBIBB", "JLBIBB", JdeDataType.Numeric),
        new JdeField("JLBIPY", "JLBIPY", JdeDataType.Numeric),
        new JdeField("JLBI01", "JLBI01", JdeDataType.Numeric),
        new JdeField("JLBI02", "JLBI02", JdeDataType.Numeric),
        new JdeField("JLBI03", "JLBI03", JdeDataType.Numeric),
        new JdeField("JLBI04", "JLBI04", JdeDataType.Numeric),
        new JdeField("JLBI05", "JLBI05", JdeDataType.Numeric),
        new JdeField("JLBI06", "JLBI06", JdeDataType.Numeric),
        new JdeField("JLBI07", "JLBI07", JdeDataType.Numeric),
        new JdeField("JLBI08", "JLBI08", JdeDataType.Numeric),
        new JdeField("JLBI09", "JLBI09", JdeDataType.Numeric),
        new JdeField("JLBI10", "JLBI10", JdeDataType.Numeric),
        new JdeField("JLBI11", "JLBI11", JdeDataType.Numeric),
        new JdeField("JLBI12", "JLBI12", JdeDataType.Numeric),
        new JdeField("JLBHBB", "JLBHBB", JdeDataType.Numeric),
        new JdeField("JLBHPY", "JLBHPY", JdeDataType.Numeric),
        new JdeField("JLBH01", "JLBH01", JdeDataType.Numeric),
        new JdeField("JLBH02", "JLBH02", JdeDataType.Numeric),
        new JdeField("JLBH03", "JLBH03", JdeDataType.Numeric),
        new JdeField("JLBH04", "JLBH04", JdeDataType.Numeric),
        new JdeField("JLBH05", "JLBH05", JdeDataType.Numeric),
        new JdeField("JLBH06", "JLBH06", JdeDataType.Numeric),
        new JdeField("JLBH07", "JLBH07", JdeDataType.Numeric),
        new JdeField("JLBH08", "JLBH08", JdeDataType.Numeric),
        new JdeField("JLBH09", "JLBH09", JdeDataType.Numeric),
        new JdeField("JLBH10", "JLBH10", JdeDataType.Numeric),
        new JdeField("JLBH11", "JLBH11", JdeDataType.Numeric),
        new JdeField("JLBH12", "JLBH12", JdeDataType.Numeric),
        new JdeField("JLBWBB", "JLBWBB", JdeDataType.Numeric),
        new JdeField("JLBWPY", "JLBWPY", JdeDataType.Numeric),
        new JdeField("JLBW01", "JLBW01", JdeDataType.Numeric),
        new JdeField("JLBW02", "JLBW02", JdeDataType.Numeric),
        new JdeField("JLBW03", "JLBW03", JdeDataType.Numeric),
        new JdeField("JLBW04", "JLBW04", JdeDataType.Numeric),
        new JdeField("JLBW05", "JLBW05", JdeDataType.Numeric),
        new JdeField("JLBW06", "JLBW06", JdeDataType.Numeric),
        new JdeField("JLBW07", "JLBW07", JdeDataType.Numeric),
        new JdeField("JLBW08", "JLBW08", JdeDataType.Numeric),
        new JdeField("JLBW09", "JLBW09", JdeDataType.Numeric),
        new JdeField("JLBW10", "JLBW10", JdeDataType.Numeric),
        new JdeField("JLBW11", "JLBW11", JdeDataType.Numeric),
        new JdeField("JLBW12", "JLBW12", JdeDataType.Numeric),
        new JdeField("JLUSER", "JLUSER", JdeDataType.String, 20),
        new JdeField("JLPID", "JLPID", JdeDataType.String, 20),
        new JdeField("JLUPMJ", "JLUPMJ", JdeDataType.Numeric),
        new JdeField("JLUUSR", "JLUUSR", JdeDataType.String, 20),
        new JdeField("JLUUPM", "JLUUPM", JdeDataType.Numeric),
        new JdeField("JLDTSP", "JLDTSP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0623_0", "Primary Key on JLAN8, JLDTEY, JLMCU, JLSBL, JLSBLT, JLITM, JLUM", new[] { "JLAN8", "JLDTEY", "JLMCU", "JLSBL", "JLSBLT", "JLITM", "JLUM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0623_2", "Index on JLDTEY, JLMCU, JLSBLT, JLSBL, JLITM, JLUM", new[] { "JLDTEY", "JLMCU", "JLSBLT", "JLSBL", "JLITM", "JLUM" })
    };
}
