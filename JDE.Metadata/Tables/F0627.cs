using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0627 - .
/// </summary>
public class F0627 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JHAN8.
        /// </summary>
        public const string JHAN8 = "JHAN8";

        /// <summary>
        /// JHTARA.
        /// </summary>
        public const string JHTARA = "JHTARA";

        /// <summary>
        /// JHPTAX.
        /// </summary>
        public const string JHPTAX = "JHPTAX";

        /// <summary>
        /// JHWCMP.
        /// </summary>
        public const string JHWCMP = "JHWCMP";

        /// <summary>
        /// JHWET.
        /// </summary>
        public const string JHWET = "JHWET";

        /// <summary>
        /// JHHMCO.
        /// </summary>
        public const string JHHMCO = "JHHMCO";

        /// <summary>
        /// JHEFTB.
        /// </summary>
        public const string JHEFTB = "JHEFTB";

        /// <summary>
        /// JHDTEY.
        /// </summary>
        public const string JHDTEY = "JHDTEY";

        /// <summary>
        /// JHCTRY.
        /// </summary>
        public const string JHCTRY = "JHCTRY";

        /// <summary>
        /// JHTAXX.
        /// </summary>
        public const string JHTAXX = "JHTAXX";

        /// <summary>
        /// JHWA01.
        /// </summary>
        public const string JHWA01 = "JHWA01";

        /// <summary>
        /// JHWA02.
        /// </summary>
        public const string JHWA02 = "JHWA02";

        /// <summary>
        /// JHWA03.
        /// </summary>
        public const string JHWA03 = "JHWA03";

        /// <summary>
        /// JHWA04.
        /// </summary>
        public const string JHWA04 = "JHWA04";

        /// <summary>
        /// JHWA05.
        /// </summary>
        public const string JHWA05 = "JHWA05";

        /// <summary>
        /// JHWA06.
        /// </summary>
        public const string JHWA06 = "JHWA06";

        /// <summary>
        /// JHWA07.
        /// </summary>
        public const string JHWA07 = "JHWA07";

        /// <summary>
        /// JHWA08.
        /// </summary>
        public const string JHWA08 = "JHWA08";

        /// <summary>
        /// JHWA09.
        /// </summary>
        public const string JHWA09 = "JHWA09";

        /// <summary>
        /// JHWA10.
        /// </summary>
        public const string JHWA10 = "JHWA10";

        /// <summary>
        /// JHWA11.
        /// </summary>
        public const string JHWA11 = "JHWA11";

        /// <summary>
        /// JHWA12.
        /// </summary>
        public const string JHWA12 = "JHWA12";

        /// <summary>
        /// JHWO01.
        /// </summary>
        public const string JHWO01 = "JHWO01";

        /// <summary>
        /// JHWO02.
        /// </summary>
        public const string JHWO02 = "JHWO02";

        /// <summary>
        /// JHWO03.
        /// </summary>
        public const string JHWO03 = "JHWO03";

        /// <summary>
        /// JHWO04.
        /// </summary>
        public const string JHWO04 = "JHWO04";

        /// <summary>
        /// JHWO05.
        /// </summary>
        public const string JHWO05 = "JHWO05";

        /// <summary>
        /// JHWO06.
        /// </summary>
        public const string JHWO06 = "JHWO06";

        /// <summary>
        /// JHWO07.
        /// </summary>
        public const string JHWO07 = "JHWO07";

        /// <summary>
        /// JHWO08.
        /// </summary>
        public const string JHWO08 = "JHWO08";

        /// <summary>
        /// JHWO09.
        /// </summary>
        public const string JHWO09 = "JHWO09";

        /// <summary>
        /// JHWO10.
        /// </summary>
        public const string JHWO10 = "JHWO10";

        /// <summary>
        /// JHWO11.
        /// </summary>
        public const string JHWO11 = "JHWO11";

        /// <summary>
        /// JHWO12.
        /// </summary>
        public const string JHWO12 = "JHWO12";

        /// <summary>
        /// JHWC01.
        /// </summary>
        public const string JHWC01 = "JHWC01";

        /// <summary>
        /// JHWC02.
        /// </summary>
        public const string JHWC02 = "JHWC02";

        /// <summary>
        /// JHWC03.
        /// </summary>
        public const string JHWC03 = "JHWC03";

        /// <summary>
        /// JHWC04.
        /// </summary>
        public const string JHWC04 = "JHWC04";

        /// <summary>
        /// JHWC05.
        /// </summary>
        public const string JHWC05 = "JHWC05";

        /// <summary>
        /// JHWC06.
        /// </summary>
        public const string JHWC06 = "JHWC06";

        /// <summary>
        /// JHWC07.
        /// </summary>
        public const string JHWC07 = "JHWC07";

        /// <summary>
        /// JHWC08.
        /// </summary>
        public const string JHWC08 = "JHWC08";

        /// <summary>
        /// JHWC09.
        /// </summary>
        public const string JHWC09 = "JHWC09";

        /// <summary>
        /// JHWC10.
        /// </summary>
        public const string JHWC10 = "JHWC10";

        /// <summary>
        /// JHWC11.
        /// </summary>
        public const string JHWC11 = "JHWC11";

        /// <summary>
        /// JHWC12.
        /// </summary>
        public const string JHWC12 = "JHWC12";

        /// <summary>
        /// JHWB01.
        /// </summary>
        public const string JHWB01 = "JHWB01";

        /// <summary>
        /// JHWB02.
        /// </summary>
        public const string JHWB02 = "JHWB02";

        /// <summary>
        /// JHWB03.
        /// </summary>
        public const string JHWB03 = "JHWB03";

        /// <summary>
        /// JHWB04.
        /// </summary>
        public const string JHWB04 = "JHWB04";

        /// <summary>
        /// JHWB05.
        /// </summary>
        public const string JHWB05 = "JHWB05";

        /// <summary>
        /// JHWB06.
        /// </summary>
        public const string JHWB06 = "JHWB06";

        /// <summary>
        /// JHWB07.
        /// </summary>
        public const string JHWB07 = "JHWB07";

        /// <summary>
        /// JHWB08.
        /// </summary>
        public const string JHWB08 = "JHWB08";

        /// <summary>
        /// JHWB09.
        /// </summary>
        public const string JHWB09 = "JHWB09";

        /// <summary>
        /// JHWB10.
        /// </summary>
        public const string JHWB10 = "JHWB10";

        /// <summary>
        /// JHWB11.
        /// </summary>
        public const string JHWB11 = "JHWB11";

        /// <summary>
        /// JHWB12.
        /// </summary>
        public const string JHWB12 = "JHWB12";

        /// <summary>
        /// JHWI01.
        /// </summary>
        public const string JHWI01 = "JHWI01";

        /// <summary>
        /// JHWI02.
        /// </summary>
        public const string JHWI02 = "JHWI02";

        /// <summary>
        /// JHWI03.
        /// </summary>
        public const string JHWI03 = "JHWI03";

        /// <summary>
        /// JHWI04.
        /// </summary>
        public const string JHWI04 = "JHWI04";

        /// <summary>
        /// JHWI05.
        /// </summary>
        public const string JHWI05 = "JHWI05";

        /// <summary>
        /// JHWI06.
        /// </summary>
        public const string JHWI06 = "JHWI06";

        /// <summary>
        /// JHWI07.
        /// </summary>
        public const string JHWI07 = "JHWI07";

        /// <summary>
        /// JHWI08.
        /// </summary>
        public const string JHWI08 = "JHWI08";

        /// <summary>
        /// JHWI09.
        /// </summary>
        public const string JHWI09 = "JHWI09";

        /// <summary>
        /// JHWI10.
        /// </summary>
        public const string JHWI10 = "JHWI10";

        /// <summary>
        /// JHWI11.
        /// </summary>
        public const string JHWI11 = "JHWI11";

        /// <summary>
        /// JHWI12.
        /// </summary>
        public const string JHWI12 = "JHWI12";

        /// <summary>
        /// JHWM01.
        /// </summary>
        public const string JHWM01 = "JHWM01";

        /// <summary>
        /// JHWM02.
        /// </summary>
        public const string JHWM02 = "JHWM02";

        /// <summary>
        /// JHWM03.
        /// </summary>
        public const string JHWM03 = "JHWM03";

        /// <summary>
        /// JHWM04.
        /// </summary>
        public const string JHWM04 = "JHWM04";

        /// <summary>
        /// JHWM05.
        /// </summary>
        public const string JHWM05 = "JHWM05";

        /// <summary>
        /// JHWM06.
        /// </summary>
        public const string JHWM06 = "JHWM06";

        /// <summary>
        /// JHWM07.
        /// </summary>
        public const string JHWM07 = "JHWM07";

        /// <summary>
        /// JHWM08.
        /// </summary>
        public const string JHWM08 = "JHWM08";

        /// <summary>
        /// JHWM09.
        /// </summary>
        public const string JHWM09 = "JHWM09";

        /// <summary>
        /// JHWM10.
        /// </summary>
        public const string JHWM10 = "JHWM10";

        /// <summary>
        /// JHWM11.
        /// </summary>
        public const string JHWM11 = "JHWM11";

        /// <summary>
        /// JHWM12.
        /// </summary>
        public const string JHWM12 = "JHWM12";

        /// <summary>
        /// JHPBFP.
        /// </summary>
        public const string JHPBFP = "JHPBFP";

        /// <summary>
        /// JHCCPR.
        /// </summary>
        public const string JHCCPR = "JHCCPR";

        /// <summary>
        /// JHUSER.
        /// </summary>
        public const string JHUSER = "JHUSER";

        /// <summary>
        /// JHPID.
        /// </summary>
        public const string JHPID = "JHPID";

        /// <summary>
        /// JHUPMJ.
        /// </summary>
        public const string JHUPMJ = "JHUPMJ";

        /// <summary>
        /// JHDTSP.
        /// </summary>
        public const string JHDTSP = "JHDTSP";

        /// <summary>
        /// JHWCE01.
        /// </summary>
        public const string JHWCE01 = "JHWCE01";

        /// <summary>
        /// JHWCE02.
        /// </summary>
        public const string JHWCE02 = "JHWCE02";

        /// <summary>
        /// JHWCE03.
        /// </summary>
        public const string JHWCE03 = "JHWCE03";

        /// <summary>
        /// JHWCE04.
        /// </summary>
        public const string JHWCE04 = "JHWCE04";

        /// <summary>
        /// JHWCE05.
        /// </summary>
        public const string JHWCE05 = "JHWCE05";

        /// <summary>
        /// JHWCE06.
        /// </summary>
        public const string JHWCE06 = "JHWCE06";

        /// <summary>
        /// JHWCE07.
        /// </summary>
        public const string JHWCE07 = "JHWCE07";

        /// <summary>
        /// JHWCE08.
        /// </summary>
        public const string JHWCE08 = "JHWCE08";

        /// <summary>
        /// JHWCE09.
        /// </summary>
        public const string JHWCE09 = "JHWCE09";

        /// <summary>
        /// JHWCE10.
        /// </summary>
        public const string JHWCE10 = "JHWCE10";

        /// <summary>
        /// JHWCE11.
        /// </summary>
        public const string JHWCE11 = "JHWCE11";

        /// <summary>
        /// JHWCE12.
        /// </summary>
        public const string JHWCE12 = "JHWCE12";
    }

    /// <inheritdoc />
    public override string TableName => "F0627";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JHAN8", "JHAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JHTARA", "JHTARA", JdeDataType.String, 20, true, true),
        new JdeField("JHPTAX", "JHPTAX", JdeDataType.String, 4, true, true),
        new JdeField("JHWCMP", "JHWCMP", JdeDataType.String, 8, true, true),
        new JdeField("JHWET", "JHWET", JdeDataType.String, 2, true, true),
        new JdeField("JHHMCO", "JHHMCO", JdeDataType.String, 10, true, true),
        new JdeField("JHEFTB", "JHEFTB", JdeDataType.Numeric),
        new JdeField("JHDTEY", "JHDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("JHCTRY", "JHCTRY", JdeDataType.Numeric),
        new JdeField("JHTAXX", "JHTAXX", JdeDataType.String, 40),
        new JdeField("JHWA01", "JHWA01", JdeDataType.Numeric),
        new JdeField("JHWA02", "JHWA02", JdeDataType.Numeric),
        new JdeField("JHWA03", "JHWA03", JdeDataType.Numeric),
        new JdeField("JHWA04", "JHWA04", JdeDataType.Numeric),
        new JdeField("JHWA05", "JHWA05", JdeDataType.Numeric),
        new JdeField("JHWA06", "JHWA06", JdeDataType.Numeric),
        new JdeField("JHWA07", "JHWA07", JdeDataType.Numeric),
        new JdeField("JHWA08", "JHWA08", JdeDataType.Numeric),
        new JdeField("JHWA09", "JHWA09", JdeDataType.Numeric),
        new JdeField("JHWA10", "JHWA10", JdeDataType.Numeric),
        new JdeField("JHWA11", "JHWA11", JdeDataType.Numeric),
        new JdeField("JHWA12", "JHWA12", JdeDataType.Numeric),
        new JdeField("JHWO01", "JHWO01", JdeDataType.Numeric),
        new JdeField("JHWO02", "JHWO02", JdeDataType.Numeric),
        new JdeField("JHWO03", "JHWO03", JdeDataType.Numeric),
        new JdeField("JHWO04", "JHWO04", JdeDataType.Numeric),
        new JdeField("JHWO05", "JHWO05", JdeDataType.Numeric),
        new JdeField("JHWO06", "JHWO06", JdeDataType.Numeric),
        new JdeField("JHWO07", "JHWO07", JdeDataType.Numeric),
        new JdeField("JHWO08", "JHWO08", JdeDataType.Numeric),
        new JdeField("JHWO09", "JHWO09", JdeDataType.Numeric),
        new JdeField("JHWO10", "JHWO10", JdeDataType.Numeric),
        new JdeField("JHWO11", "JHWO11", JdeDataType.Numeric),
        new JdeField("JHWO12", "JHWO12", JdeDataType.Numeric),
        new JdeField("JHWC01", "JHWC01", JdeDataType.Numeric),
        new JdeField("JHWC02", "JHWC02", JdeDataType.Numeric),
        new JdeField("JHWC03", "JHWC03", JdeDataType.Numeric),
        new JdeField("JHWC04", "JHWC04", JdeDataType.Numeric),
        new JdeField("JHWC05", "JHWC05", JdeDataType.Numeric),
        new JdeField("JHWC06", "JHWC06", JdeDataType.Numeric),
        new JdeField("JHWC07", "JHWC07", JdeDataType.Numeric),
        new JdeField("JHWC08", "JHWC08", JdeDataType.Numeric),
        new JdeField("JHWC09", "JHWC09", JdeDataType.Numeric),
        new JdeField("JHWC10", "JHWC10", JdeDataType.Numeric),
        new JdeField("JHWC11", "JHWC11", JdeDataType.Numeric),
        new JdeField("JHWC12", "JHWC12", JdeDataType.Numeric),
        new JdeField("JHWB01", "JHWB01", JdeDataType.Numeric),
        new JdeField("JHWB02", "JHWB02", JdeDataType.Numeric),
        new JdeField("JHWB03", "JHWB03", JdeDataType.Numeric),
        new JdeField("JHWB04", "JHWB04", JdeDataType.Numeric),
        new JdeField("JHWB05", "JHWB05", JdeDataType.Numeric),
        new JdeField("JHWB06", "JHWB06", JdeDataType.Numeric),
        new JdeField("JHWB07", "JHWB07", JdeDataType.Numeric),
        new JdeField("JHWB08", "JHWB08", JdeDataType.Numeric),
        new JdeField("JHWB09", "JHWB09", JdeDataType.Numeric),
        new JdeField("JHWB10", "JHWB10", JdeDataType.Numeric),
        new JdeField("JHWB11", "JHWB11", JdeDataType.Numeric),
        new JdeField("JHWB12", "JHWB12", JdeDataType.Numeric),
        new JdeField("JHWI01", "JHWI01", JdeDataType.Numeric),
        new JdeField("JHWI02", "JHWI02", JdeDataType.Numeric),
        new JdeField("JHWI03", "JHWI03", JdeDataType.Numeric),
        new JdeField("JHWI04", "JHWI04", JdeDataType.Numeric),
        new JdeField("JHWI05", "JHWI05", JdeDataType.Numeric),
        new JdeField("JHWI06", "JHWI06", JdeDataType.Numeric),
        new JdeField("JHWI07", "JHWI07", JdeDataType.Numeric),
        new JdeField("JHWI08", "JHWI08", JdeDataType.Numeric),
        new JdeField("JHWI09", "JHWI09", JdeDataType.Numeric),
        new JdeField("JHWI10", "JHWI10", JdeDataType.Numeric),
        new JdeField("JHWI11", "JHWI11", JdeDataType.Numeric),
        new JdeField("JHWI12", "JHWI12", JdeDataType.Numeric),
        new JdeField("JHWM01", "JHWM01", JdeDataType.Numeric),
        new JdeField("JHWM02", "JHWM02", JdeDataType.Numeric),
        new JdeField("JHWM03", "JHWM03", JdeDataType.Numeric),
        new JdeField("JHWM04", "JHWM04", JdeDataType.Numeric),
        new JdeField("JHWM05", "JHWM05", JdeDataType.Numeric),
        new JdeField("JHWM06", "JHWM06", JdeDataType.Numeric),
        new JdeField("JHWM07", "JHWM07", JdeDataType.Numeric),
        new JdeField("JHWM08", "JHWM08", JdeDataType.Numeric),
        new JdeField("JHWM09", "JHWM09", JdeDataType.Numeric),
        new JdeField("JHWM10", "JHWM10", JdeDataType.Numeric),
        new JdeField("JHWM11", "JHWM11", JdeDataType.Numeric),
        new JdeField("JHWM12", "JHWM12", JdeDataType.Numeric),
        new JdeField("JHPBFP", "JHPBFP", JdeDataType.Numeric),
        new JdeField("JHCCPR", "JHCCPR", JdeDataType.String, 6),
        new JdeField("JHUSER", "JHUSER", JdeDataType.String, 20),
        new JdeField("JHPID", "JHPID", JdeDataType.String, 20),
        new JdeField("JHUPMJ", "JHUPMJ", JdeDataType.Numeric),
        new JdeField("JHDTSP", "JHDTSP", JdeDataType.Numeric),
        new JdeField("JHWCE01", "JHWCE01", JdeDataType.Numeric),
        new JdeField("JHWCE02", "JHWCE02", JdeDataType.Numeric),
        new JdeField("JHWCE03", "JHWCE03", JdeDataType.Numeric),
        new JdeField("JHWCE04", "JHWCE04", JdeDataType.Numeric),
        new JdeField("JHWCE05", "JHWCE05", JdeDataType.Numeric),
        new JdeField("JHWCE06", "JHWCE06", JdeDataType.Numeric),
        new JdeField("JHWCE07", "JHWCE07", JdeDataType.Numeric),
        new JdeField("JHWCE08", "JHWCE08", JdeDataType.Numeric),
        new JdeField("JHWCE09", "JHWCE09", JdeDataType.Numeric),
        new JdeField("JHWCE10", "JHWCE10", JdeDataType.Numeric),
        new JdeField("JHWCE11", "JHWCE11", JdeDataType.Numeric),
        new JdeField("JHWCE12", "JHWCE12", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0627_0", "Primary Key on JHAN8, JHDTEY, JHTARA, JHPTAX, JHWCMP, JHWET, JHHMCO", new[] { "JHAN8", "JHDTEY", "JHTARA", "JHPTAX", "JHWCMP", "JHWET", "JHHMCO" }, isUnique: true, isPrimaryKey: true)
    };
}
