using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06136A - .
/// </summary>
public class F06136A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YZAN8.
        /// </summary>
        public const string YZAN8 = "YZAN8";

        /// <summary>
        /// YZTHTY.
        /// </summary>
        public const string YZTHTY = "YZTHTY";

        /// <summary>
        /// YZTARA.
        /// </summary>
        public const string YZTARA = "YZTARA";

        /// <summary>
        /// YZPTAX.
        /// </summary>
        public const string YZPTAX = "YZPTAX";

        /// <summary>
        /// YZDTEY.
        /// </summary>
        public const string YZDTEY = "YZDTEY";

        /// <summary>
        /// YZTAXX.
        /// </summary>
        public const string YZTAXX = "YZTAXX";

        /// <summary>
        /// YZHMCO.
        /// </summary>
        public const string YZHMCO = "YZHMCO";

        /// <summary>
        /// YZSCDC.
        /// </summary>
        public const string YZSCDC = "YZSCDC";

        /// <summary>
        /// YZTACC.
        /// </summary>
        public const string YZTACC = "YZTACC";

        /// <summary>
        /// YZSSN.
        /// </summary>
        public const string YZSSN = "YZSSN";

        /// <summary>
        /// YZSCOD.
        /// </summary>
        public const string YZSCOD = "YZSCOD";

        /// <summary>
        /// YZCTRY.
        /// </summary>
        public const string YZCTRY = "YZCTRY";

        /// <summary>
        /// YZPBFP.
        /// </summary>
        public const string YZPBFP = "YZPBFP";

        /// <summary>
        /// YZDESC.
        /// </summary>
        public const string YZDESC = "YZDESC";

        /// <summary>
        /// YZDL01.
        /// </summary>
        public const string YZDL01 = "YZDL01";

        /// <summary>
        /// YZBW01.
        /// </summary>
        public const string YZBW01 = "YZBW01";

        /// <summary>
        /// YZBW02.
        /// </summary>
        public const string YZBW02 = "YZBW02";

        /// <summary>
        /// YZBW03.
        /// </summary>
        public const string YZBW03 = "YZBW03";

        /// <summary>
        /// YZBW04.
        /// </summary>
        public const string YZBW04 = "YZBW04";

        /// <summary>
        /// YZBW05.
        /// </summary>
        public const string YZBW05 = "YZBW05";

        /// <summary>
        /// YZBW06.
        /// </summary>
        public const string YZBW06 = "YZBW06";

        /// <summary>
        /// YZBW07.
        /// </summary>
        public const string YZBW07 = "YZBW07";

        /// <summary>
        /// YZBW08.
        /// </summary>
        public const string YZBW08 = "YZBW08";

        /// <summary>
        /// YZBW09.
        /// </summary>
        public const string YZBW09 = "YZBW09";

        /// <summary>
        /// YZBW10.
        /// </summary>
        public const string YZBW10 = "YZBW10";

        /// <summary>
        /// YZBW11.
        /// </summary>
        public const string YZBW11 = "YZBW11";

        /// <summary>
        /// YZBW12.
        /// </summary>
        public const string YZBW12 = "YZBW12";

        /// <summary>
        /// YZBX01.
        /// </summary>
        public const string YZBX01 = "YZBX01";

        /// <summary>
        /// YZBX02.
        /// </summary>
        public const string YZBX02 = "YZBX02";

        /// <summary>
        /// YZBX03.
        /// </summary>
        public const string YZBX03 = "YZBX03";

        /// <summary>
        /// YZBX04.
        /// </summary>
        public const string YZBX04 = "YZBX04";

        /// <summary>
        /// YZBX05.
        /// </summary>
        public const string YZBX05 = "YZBX05";

        /// <summary>
        /// YZBX06.
        /// </summary>
        public const string YZBX06 = "YZBX06";

        /// <summary>
        /// YZBX07.
        /// </summary>
        public const string YZBX07 = "YZBX07";

        /// <summary>
        /// YZBX08.
        /// </summary>
        public const string YZBX08 = "YZBX08";

        /// <summary>
        /// YZBX09.
        /// </summary>
        public const string YZBX09 = "YZBX09";

        /// <summary>
        /// YZBX10.
        /// </summary>
        public const string YZBX10 = "YZBX10";

        /// <summary>
        /// YZBX11.
        /// </summary>
        public const string YZBX11 = "YZBX11";

        /// <summary>
        /// YZBX12.
        /// </summary>
        public const string YZBX12 = "YZBX12";

        /// <summary>
        /// YZBE01.
        /// </summary>
        public const string YZBE01 = "YZBE01";

        /// <summary>
        /// YZBE02.
        /// </summary>
        public const string YZBE02 = "YZBE02";

        /// <summary>
        /// YZBE03.
        /// </summary>
        public const string YZBE03 = "YZBE03";

        /// <summary>
        /// YZBE04.
        /// </summary>
        public const string YZBE04 = "YZBE04";

        /// <summary>
        /// YZBE05.
        /// </summary>
        public const string YZBE05 = "YZBE05";

        /// <summary>
        /// YZBE06.
        /// </summary>
        public const string YZBE06 = "YZBE06";

        /// <summary>
        /// YZBE07.
        /// </summary>
        public const string YZBE07 = "YZBE07";

        /// <summary>
        /// YZBE08.
        /// </summary>
        public const string YZBE08 = "YZBE08";

        /// <summary>
        /// YZBE09.
        /// </summary>
        public const string YZBE09 = "YZBE09";

        /// <summary>
        /// YZBE10.
        /// </summary>
        public const string YZBE10 = "YZBE10";

        /// <summary>
        /// YZBE11.
        /// </summary>
        public const string YZBE11 = "YZBE11";

        /// <summary>
        /// YZBE12.
        /// </summary>
        public const string YZBE12 = "YZBE12";

        /// <summary>
        /// YZBY01.
        /// </summary>
        public const string YZBY01 = "YZBY01";

        /// <summary>
        /// YZBY02.
        /// </summary>
        public const string YZBY02 = "YZBY02";

        /// <summary>
        /// YZBY03.
        /// </summary>
        public const string YZBY03 = "YZBY03";

        /// <summary>
        /// YZBY04.
        /// </summary>
        public const string YZBY04 = "YZBY04";

        /// <summary>
        /// YZBY05.
        /// </summary>
        public const string YZBY05 = "YZBY05";

        /// <summary>
        /// YZBY06.
        /// </summary>
        public const string YZBY06 = "YZBY06";

        /// <summary>
        /// YZBY07.
        /// </summary>
        public const string YZBY07 = "YZBY07";

        /// <summary>
        /// YZBY08.
        /// </summary>
        public const string YZBY08 = "YZBY08";

        /// <summary>
        /// YZBY09.
        /// </summary>
        public const string YZBY09 = "YZBY09";

        /// <summary>
        /// YZBY10.
        /// </summary>
        public const string YZBY10 = "YZBY10";

        /// <summary>
        /// YZBY11.
        /// </summary>
        public const string YZBY11 = "YZBY11";

        /// <summary>
        /// YZBY12.
        /// </summary>
        public const string YZBY12 = "YZBY12";

        /// <summary>
        /// YZUPMJ.
        /// </summary>
        public const string YZUPMJ = "YZUPMJ";

        /// <summary>
        /// YZUPMT.
        /// </summary>
        public const string YZUPMT = "YZUPMT";

        /// <summary>
        /// YZPID.
        /// </summary>
        public const string YZPID = "YZPID";

        /// <summary>
        /// YZJOBN.
        /// </summary>
        public const string YZJOBN = "YZJOBN";

        /// <summary>
        /// YZUSER.
        /// </summary>
        public const string YZUSER = "YZUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F06136A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YZAN8", "YZAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YZTHTY", "YZTHTY", JdeDataType.String, 2, true, true),
        new JdeField("YZTARA", "YZTARA", JdeDataType.String, 20, true, true),
        new JdeField("YZPTAX", "YZPTAX", JdeDataType.String, 4, true, true),
        new JdeField("YZDTEY", "YZDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("YZTAXX", "YZTAXX", JdeDataType.String, 40, true, true),
        new JdeField("YZHMCO", "YZHMCO", JdeDataType.String, 10, true, true),
        new JdeField("YZSCDC", "YZSCDC", JdeDataType.Numeric, null, true, true),
        new JdeField("YZTACC", "YZTACC", JdeDataType.String, 4, true, true),
        new JdeField("YZSSN", "YZSSN", JdeDataType.String, 40),
        new JdeField("YZSCOD", "YZSCOD", JdeDataType.String, 6),
        new JdeField("YZCTRY", "YZCTRY", JdeDataType.Numeric),
        new JdeField("YZPBFP", "YZPBFP", JdeDataType.Numeric),
        new JdeField("YZDESC", "YZDESC", JdeDataType.String, 60),
        new JdeField("YZDL01", "YZDL01", JdeDataType.String, 60),
        new JdeField("YZBW01", "YZBW01", JdeDataType.Numeric),
        new JdeField("YZBW02", "YZBW02", JdeDataType.Numeric),
        new JdeField("YZBW03", "YZBW03", JdeDataType.Numeric),
        new JdeField("YZBW04", "YZBW04", JdeDataType.Numeric),
        new JdeField("YZBW05", "YZBW05", JdeDataType.Numeric),
        new JdeField("YZBW06", "YZBW06", JdeDataType.Numeric),
        new JdeField("YZBW07", "YZBW07", JdeDataType.Numeric),
        new JdeField("YZBW08", "YZBW08", JdeDataType.Numeric),
        new JdeField("YZBW09", "YZBW09", JdeDataType.Numeric),
        new JdeField("YZBW10", "YZBW10", JdeDataType.Numeric),
        new JdeField("YZBW11", "YZBW11", JdeDataType.Numeric),
        new JdeField("YZBW12", "YZBW12", JdeDataType.Numeric),
        new JdeField("YZBX01", "YZBX01", JdeDataType.Numeric),
        new JdeField("YZBX02", "YZBX02", JdeDataType.Numeric),
        new JdeField("YZBX03", "YZBX03", JdeDataType.Numeric),
        new JdeField("YZBX04", "YZBX04", JdeDataType.Numeric),
        new JdeField("YZBX05", "YZBX05", JdeDataType.Numeric),
        new JdeField("YZBX06", "YZBX06", JdeDataType.Numeric),
        new JdeField("YZBX07", "YZBX07", JdeDataType.Numeric),
        new JdeField("YZBX08", "YZBX08", JdeDataType.Numeric),
        new JdeField("YZBX09", "YZBX09", JdeDataType.Numeric),
        new JdeField("YZBX10", "YZBX10", JdeDataType.Numeric),
        new JdeField("YZBX11", "YZBX11", JdeDataType.Numeric),
        new JdeField("YZBX12", "YZBX12", JdeDataType.Numeric),
        new JdeField("YZBE01", "YZBE01", JdeDataType.Numeric),
        new JdeField("YZBE02", "YZBE02", JdeDataType.Numeric),
        new JdeField("YZBE03", "YZBE03", JdeDataType.Numeric),
        new JdeField("YZBE04", "YZBE04", JdeDataType.Numeric),
        new JdeField("YZBE05", "YZBE05", JdeDataType.Numeric),
        new JdeField("YZBE06", "YZBE06", JdeDataType.Numeric),
        new JdeField("YZBE07", "YZBE07", JdeDataType.Numeric),
        new JdeField("YZBE08", "YZBE08", JdeDataType.Numeric),
        new JdeField("YZBE09", "YZBE09", JdeDataType.Numeric),
        new JdeField("YZBE10", "YZBE10", JdeDataType.Numeric),
        new JdeField("YZBE11", "YZBE11", JdeDataType.Numeric),
        new JdeField("YZBE12", "YZBE12", JdeDataType.Numeric),
        new JdeField("YZBY01", "YZBY01", JdeDataType.Numeric),
        new JdeField("YZBY02", "YZBY02", JdeDataType.Numeric),
        new JdeField("YZBY03", "YZBY03", JdeDataType.Numeric),
        new JdeField("YZBY04", "YZBY04", JdeDataType.Numeric),
        new JdeField("YZBY05", "YZBY05", JdeDataType.Numeric),
        new JdeField("YZBY06", "YZBY06", JdeDataType.Numeric),
        new JdeField("YZBY07", "YZBY07", JdeDataType.Numeric),
        new JdeField("YZBY08", "YZBY08", JdeDataType.Numeric),
        new JdeField("YZBY09", "YZBY09", JdeDataType.Numeric),
        new JdeField("YZBY10", "YZBY10", JdeDataType.Numeric),
        new JdeField("YZBY11", "YZBY11", JdeDataType.Numeric),
        new JdeField("YZBY12", "YZBY12", JdeDataType.Numeric),
        new JdeField("YZUPMJ", "YZUPMJ", JdeDataType.Numeric),
        new JdeField("YZUPMT", "YZUPMT", JdeDataType.Numeric),
        new JdeField("YZPID", "YZPID", JdeDataType.String, 20),
        new JdeField("YZJOBN", "YZJOBN", JdeDataType.String, 20),
        new JdeField("YZUSER", "YZUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06136A_0", "Primary Key on YZAN8, YZTHTY, YZTARA, YZPTAX, YZDTEY, YZTAXX, YZHMCO, YZSCDC, YZTACC", new[] { "YZAN8", "YZTHTY", "YZTARA", "YZPTAX", "YZDTEY", "YZTAXX", "YZHMCO", "YZSCDC", "YZTACC" }, isUnique: true, isPrimaryKey: true)
    };
}
