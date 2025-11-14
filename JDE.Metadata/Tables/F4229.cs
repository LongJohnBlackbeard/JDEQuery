using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4229 - .
/// </summary>
public class F4229 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SSDCTO.
        /// </summary>
        public const string SSDCTO = "SSDCTO";

        /// <summary>
        /// SSLNTY.
        /// </summary>
        public const string SSLNTY = "SSLNTY";

        /// <summary>
        /// SSAN8.
        /// </summary>
        public const string SSAN8 = "SSAN8";

        /// <summary>
        /// SSITM.
        /// </summary>
        public const string SSITM = "SSITM";

        /// <summary>
        /// SSLITM.
        /// </summary>
        public const string SSLITM = "SSLITM";

        /// <summary>
        /// SSAITM.
        /// </summary>
        public const string SSAITM = "SSAITM";

        /// <summary>
        /// SSMCU.
        /// </summary>
        public const string SSMCU = "SSMCU";

        /// <summary>
        /// SSSRP1.
        /// </summary>
        public const string SSSRP1 = "SSSRP1";

        /// <summary>
        /// SSSRP2.
        /// </summary>
        public const string SSSRP2 = "SSSRP2";

        /// <summary>
        /// SSSRP3.
        /// </summary>
        public const string SSSRP3 = "SSSRP3";

        /// <summary>
        /// SSSRP4.
        /// </summary>
        public const string SSSRP4 = "SSSRP4";

        /// <summary>
        /// SSSRP5.
        /// </summary>
        public const string SSSRP5 = "SSSRP5";

        /// <summary>
        /// SSCTRY.
        /// </summary>
        public const string SSCTRY = "SSCTRY";

        /// <summary>
        /// SSFY.
        /// </summary>
        public const string SSFY = "SSFY";

        /// <summary>
        /// SSFQ.
        /// </summary>
        public const string SSFQ = "SSFQ";

        /// <summary>
        /// SSCMS.
        /// </summary>
        public const string SSCMS = "SSCMS";

        /// <summary>
        /// SSCMC.
        /// </summary>
        public const string SSCMC = "SSCMC";

        /// <summary>
        /// SSCYS.
        /// </summary>
        public const string SSCYS = "SSCYS";

        /// <summary>
        /// SSCYC.
        /// </summary>
        public const string SSCYC = "SSCYC";

        /// <summary>
        /// SSPYES.
        /// </summary>
        public const string SSPYES = "SSPYES";

        /// <summary>
        /// SSPYEC.
        /// </summary>
        public const string SSPYEC = "SSPYEC";

        /// <summary>
        /// SSQS01.
        /// </summary>
        public const string SSQS01 = "SSQS01";

        /// <summary>
        /// SSQS02.
        /// </summary>
        public const string SSQS02 = "SSQS02";

        /// <summary>
        /// SSQS03.
        /// </summary>
        public const string SSQS03 = "SSQS03";

        /// <summary>
        /// SSQS04.
        /// </summary>
        public const string SSQS04 = "SSQS04";

        /// <summary>
        /// SSQS05.
        /// </summary>
        public const string SSQS05 = "SSQS05";

        /// <summary>
        /// SSQS06.
        /// </summary>
        public const string SSQS06 = "SSQS06";

        /// <summary>
        /// SSQS07.
        /// </summary>
        public const string SSQS07 = "SSQS07";

        /// <summary>
        /// SSQS08.
        /// </summary>
        public const string SSQS08 = "SSQS08";

        /// <summary>
        /// SSQS09.
        /// </summary>
        public const string SSQS09 = "SSQS09";

        /// <summary>
        /// SSQS10.
        /// </summary>
        public const string SSQS10 = "SSQS10";

        /// <summary>
        /// SSQS11.
        /// </summary>
        public const string SSQS11 = "SSQS11";

        /// <summary>
        /// SSQS12.
        /// </summary>
        public const string SSQS12 = "SSQS12";

        /// <summary>
        /// SSQS13.
        /// </summary>
        public const string SSQS13 = "SSQS13";

        /// <summary>
        /// SSQS14.
        /// </summary>
        public const string SSQS14 = "SSQS14";

        /// <summary>
        /// SSCI01.
        /// </summary>
        public const string SSCI01 = "SSCI01";

        /// <summary>
        /// SSCI02.
        /// </summary>
        public const string SSCI02 = "SSCI02";

        /// <summary>
        /// SSCI03.
        /// </summary>
        public const string SSCI03 = "SSCI03";

        /// <summary>
        /// SSCI04.
        /// </summary>
        public const string SSCI04 = "SSCI04";

        /// <summary>
        /// SSCI05.
        /// </summary>
        public const string SSCI05 = "SSCI05";

        /// <summary>
        /// SSCI06.
        /// </summary>
        public const string SSCI06 = "SSCI06";

        /// <summary>
        /// SSCI07.
        /// </summary>
        public const string SSCI07 = "SSCI07";

        /// <summary>
        /// SSCI08.
        /// </summary>
        public const string SSCI08 = "SSCI08";

        /// <summary>
        /// SSCI09.
        /// </summary>
        public const string SSCI09 = "SSCI09";

        /// <summary>
        /// SSCI10.
        /// </summary>
        public const string SSCI10 = "SSCI10";

        /// <summary>
        /// SSCI11.
        /// </summary>
        public const string SSCI11 = "SSCI11";

        /// <summary>
        /// SSCI12.
        /// </summary>
        public const string SSCI12 = "SSCI12";

        /// <summary>
        /// SSCI13.
        /// </summary>
        public const string SSCI13 = "SSCI13";

        /// <summary>
        /// SSCI14.
        /// </summary>
        public const string SSCI14 = "SSCI14";

        /// <summary>
        /// SSAS01.
        /// </summary>
        public const string SSAS01 = "SSAS01";

        /// <summary>
        /// SSAS02.
        /// </summary>
        public const string SSAS02 = "SSAS02";

        /// <summary>
        /// SSAS03.
        /// </summary>
        public const string SSAS03 = "SSAS03";

        /// <summary>
        /// SSAS04.
        /// </summary>
        public const string SSAS04 = "SSAS04";

        /// <summary>
        /// SSAS05.
        /// </summary>
        public const string SSAS05 = "SSAS05";

        /// <summary>
        /// SSAS06.
        /// </summary>
        public const string SSAS06 = "SSAS06";

        /// <summary>
        /// SSAS07.
        /// </summary>
        public const string SSAS07 = "SSAS07";

        /// <summary>
        /// SSAS08.
        /// </summary>
        public const string SSAS08 = "SSAS08";

        /// <summary>
        /// SSAS09.
        /// </summary>
        public const string SSAS09 = "SSAS09";

        /// <summary>
        /// SSAS10.
        /// </summary>
        public const string SSAS10 = "SSAS10";

        /// <summary>
        /// SSAS11.
        /// </summary>
        public const string SSAS11 = "SSAS11";

        /// <summary>
        /// SSAS12.
        /// </summary>
        public const string SSAS12 = "SSAS12";

        /// <summary>
        /// SSAS13.
        /// </summary>
        public const string SSAS13 = "SSAS13";

        /// <summary>
        /// SSAS14.
        /// </summary>
        public const string SSAS14 = "SSAS14";

        /// <summary>
        /// SSDLIJ.
        /// </summary>
        public const string SSDLIJ = "SSDLIJ";
    }

    /// <inheritdoc />
    public override string TableName => "F4229";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SSDCTO", "SSDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SSLNTY", "SSLNTY", JdeDataType.String, 4, true, true),
        new JdeField("SSAN8", "SSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SSITM", "SSITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SSLITM", "SSLITM", JdeDataType.String, 50),
        new JdeField("SSAITM", "SSAITM", JdeDataType.String, 50),
        new JdeField("SSMCU", "SSMCU", JdeDataType.String, 24, true, true),
        new JdeField("SSSRP1", "SSSRP1", JdeDataType.String, 6, true, true),
        new JdeField("SSSRP2", "SSSRP2", JdeDataType.String, 6, true, true),
        new JdeField("SSSRP3", "SSSRP3", JdeDataType.String, 6, true, true),
        new JdeField("SSSRP4", "SSSRP4", JdeDataType.String, 6, true, true),
        new JdeField("SSSRP5", "SSSRP5", JdeDataType.String, 6, true, true),
        new JdeField("SSCTRY", "SSCTRY", JdeDataType.Numeric),
        new JdeField("SSFY", "SSFY", JdeDataType.Numeric, null, true, true),
        new JdeField("SSFQ", "SSFQ", JdeDataType.String, 8),
        new JdeField("SSCMS", "SSCMS", JdeDataType.Numeric),
        new JdeField("SSCMC", "SSCMC", JdeDataType.Numeric),
        new JdeField("SSCYS", "SSCYS", JdeDataType.Numeric),
        new JdeField("SSCYC", "SSCYC", JdeDataType.Numeric),
        new JdeField("SSPYES", "SSPYES", JdeDataType.Numeric),
        new JdeField("SSPYEC", "SSPYEC", JdeDataType.Numeric),
        new JdeField("SSQS01", "SSQS01", JdeDataType.Numeric),
        new JdeField("SSQS02", "SSQS02", JdeDataType.Numeric),
        new JdeField("SSQS03", "SSQS03", JdeDataType.Numeric),
        new JdeField("SSQS04", "SSQS04", JdeDataType.Numeric),
        new JdeField("SSQS05", "SSQS05", JdeDataType.Numeric),
        new JdeField("SSQS06", "SSQS06", JdeDataType.Numeric),
        new JdeField("SSQS07", "SSQS07", JdeDataType.Numeric),
        new JdeField("SSQS08", "SSQS08", JdeDataType.Numeric),
        new JdeField("SSQS09", "SSQS09", JdeDataType.Numeric),
        new JdeField("SSQS10", "SSQS10", JdeDataType.Numeric),
        new JdeField("SSQS11", "SSQS11", JdeDataType.Numeric),
        new JdeField("SSQS12", "SSQS12", JdeDataType.Numeric),
        new JdeField("SSQS13", "SSQS13", JdeDataType.Numeric),
        new JdeField("SSQS14", "SSQS14", JdeDataType.Numeric),
        new JdeField("SSCI01", "SSCI01", JdeDataType.Numeric),
        new JdeField("SSCI02", "SSCI02", JdeDataType.Numeric),
        new JdeField("SSCI03", "SSCI03", JdeDataType.Numeric),
        new JdeField("SSCI04", "SSCI04", JdeDataType.Numeric),
        new JdeField("SSCI05", "SSCI05", JdeDataType.Numeric),
        new JdeField("SSCI06", "SSCI06", JdeDataType.Numeric),
        new JdeField("SSCI07", "SSCI07", JdeDataType.Numeric),
        new JdeField("SSCI08", "SSCI08", JdeDataType.Numeric),
        new JdeField("SSCI09", "SSCI09", JdeDataType.Numeric),
        new JdeField("SSCI10", "SSCI10", JdeDataType.Numeric),
        new JdeField("SSCI11", "SSCI11", JdeDataType.Numeric),
        new JdeField("SSCI12", "SSCI12", JdeDataType.Numeric),
        new JdeField("SSCI13", "SSCI13", JdeDataType.Numeric),
        new JdeField("SSCI14", "SSCI14", JdeDataType.Numeric),
        new JdeField("SSAS01", "SSAS01", JdeDataType.Numeric),
        new JdeField("SSAS02", "SSAS02", JdeDataType.Numeric),
        new JdeField("SSAS03", "SSAS03", JdeDataType.Numeric),
        new JdeField("SSAS04", "SSAS04", JdeDataType.Numeric),
        new JdeField("SSAS05", "SSAS05", JdeDataType.Numeric),
        new JdeField("SSAS06", "SSAS06", JdeDataType.Numeric),
        new JdeField("SSAS07", "SSAS07", JdeDataType.Numeric),
        new JdeField("SSAS08", "SSAS08", JdeDataType.Numeric),
        new JdeField("SSAS09", "SSAS09", JdeDataType.Numeric),
        new JdeField("SSAS10", "SSAS10", JdeDataType.Numeric),
        new JdeField("SSAS11", "SSAS11", JdeDataType.Numeric),
        new JdeField("SSAS12", "SSAS12", JdeDataType.Numeric),
        new JdeField("SSAS13", "SSAS13", JdeDataType.Numeric),
        new JdeField("SSAS14", "SSAS14", JdeDataType.Numeric),
        new JdeField("SSDLIJ", "SSDLIJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4229_0", "Primary Key on SSAN8, SSMCU, SSDCTO, SSITM, SSLNTY, SSSRP1, SSSRP2, SSSRP3, SSSRP4, SSSRP5, SSFY", new[] { "SSAN8", "SSMCU", "SSDCTO", "SSITM", "SSLNTY", "SSSRP1", "SSSRP2", "SSSRP3", "SSSRP4", "SSSRP5", "SSFY" }, isUnique: true, isPrimaryKey: true)
    };
}
