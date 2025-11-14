using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F080434B - .
/// </summary>
public class F080434B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VESVER.
        /// </summary>
        public const string VESVER = "VESVER";

        /// <summary>
        /// VEPRNM.
        /// </summary>
        public const string VEPRNM = "VEPRNM";

        /// <summary>
        /// VEVRBY.
        /// </summary>
        public const string VEVRBY = "VEVRBY";

        /// <summary>
        /// VEWSST.
        /// </summary>
        public const string VEWSST = "VEWSST";

        /// <summary>
        /// VETPOS.
        /// </summary>
        public const string VETPOS = "VETPOS";

        /// <summary>
        /// VEDOCP.
        /// </summary>
        public const string VEDOCP = "VEDOCP";

        /// <summary>
        /// VECONAME.
        /// </summary>
        public const string VECONAME = "VECONAME";

        /// <summary>
        /// VECOMNT1.
        /// </summary>
        public const string VECOMNT1 = "VECOMNT1";

        /// <summary>
        /// VEOFC.
        /// </summary>
        public const string VEOFC = "VEOFC";

        /// <summary>
        /// VETSKD1.
        /// </summary>
        public const string VETSKD1 = "VETSKD1";

        /// <summary>
        /// VESTAC.
        /// </summary>
        public const string VESTAC = "VESTAC";

        /// <summary>
        /// VECUCD.
        /// </summary>
        public const string VECUCD = "VECUCD";

        /// <summary>
        /// VENEWVAL.
        /// </summary>
        public const string VENEWVAL = "VENEWVAL";

        /// <summary>
        /// VECOMNT2.
        /// </summary>
        public const string VECOMNT2 = "VECOMNT2";

        /// <summary>
        /// VENME.
        /// </summary>
        public const string VENME = "VENME";

        /// <summary>
        /// VEWCPL.
        /// </summary>
        public const string VEWCPL = "VEWCPL";

        /// <summary>
        /// VECTAX.
        /// </summary>
        public const string VECTAX = "VECTAX";

        /// <summary>
        /// VENRSD.
        /// </summary>
        public const string VENRSD = "VENRSD";

        /// <summary>
        /// VECMPC.
        /// </summary>
        public const string VECMPC = "VECMPC";

        /// <summary>
        /// VEINSTY.
        /// </summary>
        public const string VEINSTY = "VEINSTY";

        /// <summary>
        /// VEADDN.
        /// </summary>
        public const string VEADDN = "VEADDN";

        /// <summary>
        /// VEETAX.
        /// </summary>
        public const string VEETAX = "VEETAX";

        /// <summary>
        /// VEEE01.
        /// </summary>
        public const string VEEE01 = "VEEE01";

        /// <summary>
        /// VEEE02.
        /// </summary>
        public const string VEEE02 = "VEEE02";

        /// <summary>
        /// VEEE03.
        /// </summary>
        public const string VEEE03 = "VEEE03";

        /// <summary>
        /// VEEE04.
        /// </summary>
        public const string VEEE04 = "VEEE04";

        /// <summary>
        /// VEEE05.
        /// </summary>
        public const string VEEE05 = "VEEE05";

        /// <summary>
        /// VEEE06.
        /// </summary>
        public const string VEEE06 = "VEEE06";

        /// <summary>
        /// VEEE07.
        /// </summary>
        public const string VEEE07 = "VEEE07";

        /// <summary>
        /// VEEE08.
        /// </summary>
        public const string VEEE08 = "VEEE08";

        /// <summary>
        /// VEEE09.
        /// </summary>
        public const string VEEE09 = "VEEE09";

        /// <summary>
        /// VEEE10.
        /// </summary>
        public const string VEEE10 = "VEEE10";

        /// <summary>
        /// VEEE11.
        /// </summary>
        public const string VEEE11 = "VEEE11";

        /// <summary>
        /// VEEE12.
        /// </summary>
        public const string VEEE12 = "VEEE12";

        /// <summary>
        /// VEEE13.
        /// </summary>
        public const string VEEE13 = "VEEE13";

        /// <summary>
        /// VEEE14.
        /// </summary>
        public const string VEEE14 = "VEEE14";

        /// <summary>
        /// VEEE15.
        /// </summary>
        public const string VEEE15 = "VEEE15";

        /// <summary>
        /// VEEE16.
        /// </summary>
        public const string VEEE16 = "VEEE16";

        /// <summary>
        /// VEEE17.
        /// </summary>
        public const string VEEE17 = "VEEE17";

        /// <summary>
        /// VEEE18.
        /// </summary>
        public const string VEEE18 = "VEEE18";

        /// <summary>
        /// VEEE19.
        /// </summary>
        public const string VEEE19 = "VEEE19";

        /// <summary>
        /// VEEE20.
        /// </summary>
        public const string VEEE20 = "VEEE20";

        /// <summary>
        /// VEEE21.
        /// </summary>
        public const string VEEE21 = "VEEE21";

        /// <summary>
        /// VEEE22.
        /// </summary>
        public const string VEEE22 = "VEEE22";

        /// <summary>
        /// VEEE23.
        /// </summary>
        public const string VEEE23 = "VEEE23";

        /// <summary>
        /// VEEE24.
        /// </summary>
        public const string VEEE24 = "VEEE24";

        /// <summary>
        /// VEEE25.
        /// </summary>
        public const string VEEE25 = "VEEE25";

        /// <summary>
        /// VEEE26.
        /// </summary>
        public const string VEEE26 = "VEEE26";

        /// <summary>
        /// VEEE27.
        /// </summary>
        public const string VEEE27 = "VEEE27";

        /// <summary>
        /// VEEE28.
        /// </summary>
        public const string VEEE28 = "VEEE28";

        /// <summary>
        /// VEEE29.
        /// </summary>
        public const string VEEE29 = "VEEE29";

        /// <summary>
        /// VEEE30.
        /// </summary>
        public const string VEEE30 = "VEEE30";

        /// <summary>
        /// VEEE31.
        /// </summary>
        public const string VEEE31 = "VEEE31";

        /// <summary>
        /// VEEE32.
        /// </summary>
        public const string VEEE32 = "VEEE32";

        /// <summary>
        /// VEEE33.
        /// </summary>
        public const string VEEE33 = "VEEE33";

        /// <summary>
        /// VEEE34.
        /// </summary>
        public const string VEEE34 = "VEEE34";

        /// <summary>
        /// VEEE35.
        /// </summary>
        public const string VEEE35 = "VEEE35";

        /// <summary>
        /// VEEE36.
        /// </summary>
        public const string VEEE36 = "VEEE36";

        /// <summary>
        /// VEEE37.
        /// </summary>
        public const string VEEE37 = "VEEE37";

        /// <summary>
        /// VEEE38.
        /// </summary>
        public const string VEEE38 = "VEEE38";

        /// <summary>
        /// VEEE39.
        /// </summary>
        public const string VEEE39 = "VEEE39";

        /// <summary>
        /// VEEE40.
        /// </summary>
        public const string VEEE40 = "VEEE40";

        /// <summary>
        /// VEEE41.
        /// </summary>
        public const string VEEE41 = "VEEE41";

        /// <summary>
        /// VEEE42.
        /// </summary>
        public const string VEEE42 = "VEEE42";

        /// <summary>
        /// VEEE43.
        /// </summary>
        public const string VEEE43 = "VEEE43";

        /// <summary>
        /// VEEE44.
        /// </summary>
        public const string VEEE44 = "VEEE44";

        /// <summary>
        /// VEEE45.
        /// </summary>
        public const string VEEE45 = "VEEE45";

        /// <summary>
        /// VEEE46.
        /// </summary>
        public const string VEEE46 = "VEEE46";

        /// <summary>
        /// VEEE47.
        /// </summary>
        public const string VEEE47 = "VEEE47";

        /// <summary>
        /// VEEE48.
        /// </summary>
        public const string VEEE48 = "VEEE48";

        /// <summary>
        /// VEEE49.
        /// </summary>
        public const string VEEE49 = "VEEE49";

        /// <summary>
        /// VEEE50.
        /// </summary>
        public const string VEEE50 = "VEEE50";

        /// <summary>
        /// VEBN01.
        /// </summary>
        public const string VEBN01 = "VEBN01";

        /// <summary>
        /// VEBN02.
        /// </summary>
        public const string VEBN02 = "VEBN02";

        /// <summary>
        /// VEBN03.
        /// </summary>
        public const string VEBN03 = "VEBN03";

        /// <summary>
        /// VEBN04.
        /// </summary>
        public const string VEBN04 = "VEBN04";

        /// <summary>
        /// VEBN05.
        /// </summary>
        public const string VEBN05 = "VEBN05";

        /// <summary>
        /// VEBN06.
        /// </summary>
        public const string VEBN06 = "VEBN06";

        /// <summary>
        /// VEBN07.
        /// </summary>
        public const string VEBN07 = "VEBN07";

        /// <summary>
        /// VEBN08.
        /// </summary>
        public const string VEBN08 = "VEBN08";

        /// <summary>
        /// VEBN09.
        /// </summary>
        public const string VEBN09 = "VEBN09";

        /// <summary>
        /// VEBN10.
        /// </summary>
        public const string VEBN10 = "VEBN10";

        /// <summary>
        /// VEBN11.
        /// </summary>
        public const string VEBN11 = "VEBN11";

        /// <summary>
        /// VEBN12.
        /// </summary>
        public const string VEBN12 = "VEBN12";

        /// <summary>
        /// VEBN13.
        /// </summary>
        public const string VEBN13 = "VEBN13";

        /// <summary>
        /// VEN001.
        /// </summary>
        public const string VEN001 = "VEN001";

        /// <summary>
        /// VEN002.
        /// </summary>
        public const string VEN002 = "VEN002";

        /// <summary>
        /// VEN003.
        /// </summary>
        public const string VEN003 = "VEN003";

        /// <summary>
        /// VEN004.
        /// </summary>
        public const string VEN004 = "VEN004";

        /// <summary>
        /// VEN005.
        /// </summary>
        public const string VEN005 = "VEN005";

        /// <summary>
        /// VEN006.
        /// </summary>
        public const string VEN006 = "VEN006";

        /// <summary>
        /// VEN007.
        /// </summary>
        public const string VEN007 = "VEN007";

        /// <summary>
        /// VEN008.
        /// </summary>
        public const string VEN008 = "VEN008";

        /// <summary>
        /// VEN009.
        /// </summary>
        public const string VEN009 = "VEN009";

        /// <summary>
        /// VEN010.
        /// </summary>
        public const string VEN010 = "VEN010";

        /// <summary>
        /// VEDC01.
        /// </summary>
        public const string VEDC01 = "VEDC01";

        /// <summary>
        /// VEDC02.
        /// </summary>
        public const string VEDC02 = "VEDC02";

        /// <summary>
        /// VEDC03.
        /// </summary>
        public const string VEDC03 = "VEDC03";

        /// <summary>
        /// VEDC04.
        /// </summary>
        public const string VEDC04 = "VEDC04";

        /// <summary>
        /// VEDC05.
        /// </summary>
        public const string VEDC05 = "VEDC05";

        /// <summary>
        /// VEDC06.
        /// </summary>
        public const string VEDC06 = "VEDC06";

        /// <summary>
        /// VEDC07.
        /// </summary>
        public const string VEDC07 = "VEDC07";

        /// <summary>
        /// VEDC08.
        /// </summary>
        public const string VEDC08 = "VEDC08";

        /// <summary>
        /// VEDC09.
        /// </summary>
        public const string VEDC09 = "VEDC09";

        /// <summary>
        /// VEAN8CM01.
        /// </summary>
        public const string VEAN8CM01 = "VEAN8CM01";

        /// <summary>
        /// VEAN8CM02.
        /// </summary>
        public const string VEAN8CM02 = "VEAN8CM02";

        /// <summary>
        /// VEAN8CM03.
        /// </summary>
        public const string VEAN8CM03 = "VEAN8CM03";

        /// <summary>
        /// VEAN8CM04.
        /// </summary>
        public const string VEAN8CM04 = "VEAN8CM04";

        /// <summary>
        /// VEAN8CM05.
        /// </summary>
        public const string VEAN8CM05 = "VEAN8CM05";

        /// <summary>
        /// VEAN8CM06.
        /// </summary>
        public const string VEAN8CM06 = "VEAN8CM06";

        /// <summary>
        /// VEAN8CM07.
        /// </summary>
        public const string VEAN8CM07 = "VEAN8CM07";

        /// <summary>
        /// VEAN8CM08.
        /// </summary>
        public const string VEAN8CM08 = "VEAN8CM08";

        /// <summary>
        /// VEAN8CM09.
        /// </summary>
        public const string VEAN8CM09 = "VEAN8CM09";

        /// <summary>
        /// VEAN8CM10.
        /// </summary>
        public const string VEAN8CM10 = "VEAN8CM10";

        /// <summary>
        /// VEAN8CM11.
        /// </summary>
        public const string VEAN8CM11 = "VEAN8CM11";

        /// <summary>
        /// VEAN8CM12.
        /// </summary>
        public const string VEAN8CM12 = "VEAN8CM12";

        /// <summary>
        /// VEAN8CM13.
        /// </summary>
        public const string VEAN8CM13 = "VEAN8CM13";

        /// <summary>
        /// VEAN8CM14.
        /// </summary>
        public const string VEAN8CM14 = "VEAN8CM14";

        /// <summary>
        /// VEAN8CM15.
        /// </summary>
        public const string VEAN8CM15 = "VEAN8CM15";

        /// <summary>
        /// VEAN8CM16.
        /// </summary>
        public const string VEAN8CM16 = "VEAN8CM16";

        /// <summary>
        /// VEAN8CM17.
        /// </summary>
        public const string VEAN8CM17 = "VEAN8CM17";

        /// <summary>
        /// VEAN8CM18.
        /// </summary>
        public const string VEAN8CM18 = "VEAN8CM18";

        /// <summary>
        /// VEAN8CM19.
        /// </summary>
        public const string VEAN8CM19 = "VEAN8CM19";

        /// <summary>
        /// VEAN8CM20.
        /// </summary>
        public const string VEAN8CM20 = "VEAN8CM20";

        /// <summary>
        /// VEANSM01.
        /// </summary>
        public const string VEANSM01 = "VEANSM01";

        /// <summary>
        /// VEANSM02.
        /// </summary>
        public const string VEANSM02 = "VEANSM02";

        /// <summary>
        /// VEANSM03.
        /// </summary>
        public const string VEANSM03 = "VEANSM03";

        /// <summary>
        /// VEANSM04.
        /// </summary>
        public const string VEANSM04 = "VEANSM04";

        /// <summary>
        /// VEANSM05.
        /// </summary>
        public const string VEANSM05 = "VEANSM05";

        /// <summary>
        /// VEANSM06.
        /// </summary>
        public const string VEANSM06 = "VEANSM06";

        /// <summary>
        /// VEANSM07.
        /// </summary>
        public const string VEANSM07 = "VEANSM07";

        /// <summary>
        /// VEANSM08.
        /// </summary>
        public const string VEANSM08 = "VEANSM08";

        /// <summary>
        /// VEANSM09.
        /// </summary>
        public const string VEANSM09 = "VEANSM09";

        /// <summary>
        /// VEANSM10.
        /// </summary>
        public const string VEANSM10 = "VEANSM10";
    }

    /// <inheritdoc />
    public override string TableName => "F080434B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VESVER", "VESVER", JdeDataType.String, 20, true, true),
        new JdeField("VEPRNM", "VEPRNM", JdeDataType.String, 40, true, true),
        new JdeField("VEVRBY", "VEVRBY", JdeDataType.String, 16, true, true),
        new JdeField("VEWSST", "VEWSST", JdeDataType.String, 2),
        new JdeField("VETPOS", "VETPOS", JdeDataType.String, 6),
        new JdeField("VEDOCP", "VEDOCP", JdeDataType.Numeric),
        new JdeField("VECONAME", "VECONAME", JdeDataType.String, 80),
        new JdeField("VECOMNT1", "VECOMNT1", JdeDataType.String, 80),
        new JdeField("VEOFC", "VEOFC", JdeDataType.String, 40),
        new JdeField("VETSKD1", "VETSKD1", JdeDataType.String, 40),
        new JdeField("VESTAC", "VESTAC", JdeDataType.String, 4),
        new JdeField("VECUCD", "VECUCD", JdeDataType.String, 20),
        new JdeField("VENEWVAL", "VENEWVAL", JdeDataType.String, 40, true, true),
        new JdeField("VECOMNT2", "VECOMNT2", JdeDataType.String, 80),
        new JdeField("VENME", "VENME", JdeDataType.String, 80),
        new JdeField("VEWCPL", "VEWCPL", JdeDataType.String, 40),
        new JdeField("VECTAX", "VECTAX", JdeDataType.String, 40),
        new JdeField("VENRSD", "VENRSD", JdeDataType.String, 4),
        new JdeField("VECMPC", "VECMPC", JdeDataType.String, 20),
        new JdeField("VEINSTY", "VEINSTY", JdeDataType.String, 20),
        new JdeField("VEADDN", "VEADDN", JdeDataType.String, 40),
        new JdeField("VEETAX", "VEETAX", JdeDataType.String, 40),
        new JdeField("VEEE01", "VEEE01", JdeDataType.Numeric),
        new JdeField("VEEE02", "VEEE02", JdeDataType.Numeric),
        new JdeField("VEEE03", "VEEE03", JdeDataType.Numeric),
        new JdeField("VEEE04", "VEEE04", JdeDataType.Numeric),
        new JdeField("VEEE05", "VEEE05", JdeDataType.Numeric),
        new JdeField("VEEE06", "VEEE06", JdeDataType.Numeric),
        new JdeField("VEEE07", "VEEE07", JdeDataType.Numeric),
        new JdeField("VEEE08", "VEEE08", JdeDataType.Numeric),
        new JdeField("VEEE09", "VEEE09", JdeDataType.Numeric),
        new JdeField("VEEE10", "VEEE10", JdeDataType.Numeric),
        new JdeField("VEEE11", "VEEE11", JdeDataType.Numeric),
        new JdeField("VEEE12", "VEEE12", JdeDataType.Numeric),
        new JdeField("VEEE13", "VEEE13", JdeDataType.Numeric),
        new JdeField("VEEE14", "VEEE14", JdeDataType.Numeric),
        new JdeField("VEEE15", "VEEE15", JdeDataType.Numeric),
        new JdeField("VEEE16", "VEEE16", JdeDataType.Numeric),
        new JdeField("VEEE17", "VEEE17", JdeDataType.Numeric),
        new JdeField("VEEE18", "VEEE18", JdeDataType.Numeric),
        new JdeField("VEEE19", "VEEE19", JdeDataType.Numeric),
        new JdeField("VEEE20", "VEEE20", JdeDataType.Numeric),
        new JdeField("VEEE21", "VEEE21", JdeDataType.Numeric),
        new JdeField("VEEE22", "VEEE22", JdeDataType.Numeric),
        new JdeField("VEEE23", "VEEE23", JdeDataType.Numeric),
        new JdeField("VEEE24", "VEEE24", JdeDataType.Numeric),
        new JdeField("VEEE25", "VEEE25", JdeDataType.Numeric),
        new JdeField("VEEE26", "VEEE26", JdeDataType.Numeric),
        new JdeField("VEEE27", "VEEE27", JdeDataType.Numeric),
        new JdeField("VEEE28", "VEEE28", JdeDataType.Numeric),
        new JdeField("VEEE29", "VEEE29", JdeDataType.Numeric),
        new JdeField("VEEE30", "VEEE30", JdeDataType.Numeric),
        new JdeField("VEEE31", "VEEE31", JdeDataType.Numeric),
        new JdeField("VEEE32", "VEEE32", JdeDataType.Numeric),
        new JdeField("VEEE33", "VEEE33", JdeDataType.Numeric),
        new JdeField("VEEE34", "VEEE34", JdeDataType.Numeric),
        new JdeField("VEEE35", "VEEE35", JdeDataType.Numeric),
        new JdeField("VEEE36", "VEEE36", JdeDataType.Numeric),
        new JdeField("VEEE37", "VEEE37", JdeDataType.Numeric),
        new JdeField("VEEE38", "VEEE38", JdeDataType.Numeric),
        new JdeField("VEEE39", "VEEE39", JdeDataType.Numeric),
        new JdeField("VEEE40", "VEEE40", JdeDataType.Numeric),
        new JdeField("VEEE41", "VEEE41", JdeDataType.Numeric),
        new JdeField("VEEE42", "VEEE42", JdeDataType.Numeric),
        new JdeField("VEEE43", "VEEE43", JdeDataType.Numeric),
        new JdeField("VEEE44", "VEEE44", JdeDataType.Numeric),
        new JdeField("VEEE45", "VEEE45", JdeDataType.Numeric),
        new JdeField("VEEE46", "VEEE46", JdeDataType.Numeric),
        new JdeField("VEEE47", "VEEE47", JdeDataType.Numeric),
        new JdeField("VEEE48", "VEEE48", JdeDataType.Numeric),
        new JdeField("VEEE49", "VEEE49", JdeDataType.Numeric),
        new JdeField("VEEE50", "VEEE50", JdeDataType.Numeric),
        new JdeField("VEBN01", "VEBN01", JdeDataType.Numeric),
        new JdeField("VEBN02", "VEBN02", JdeDataType.Numeric),
        new JdeField("VEBN03", "VEBN03", JdeDataType.Numeric),
        new JdeField("VEBN04", "VEBN04", JdeDataType.Numeric),
        new JdeField("VEBN05", "VEBN05", JdeDataType.Numeric),
        new JdeField("VEBN06", "VEBN06", JdeDataType.Numeric),
        new JdeField("VEBN07", "VEBN07", JdeDataType.Numeric),
        new JdeField("VEBN08", "VEBN08", JdeDataType.Numeric),
        new JdeField("VEBN09", "VEBN09", JdeDataType.Numeric),
        new JdeField("VEBN10", "VEBN10", JdeDataType.Numeric),
        new JdeField("VEBN11", "VEBN11", JdeDataType.Numeric),
        new JdeField("VEBN12", "VEBN12", JdeDataType.Numeric),
        new JdeField("VEBN13", "VEBN13", JdeDataType.Numeric),
        new JdeField("VEN001", "VEN001", JdeDataType.Numeric),
        new JdeField("VEN002", "VEN002", JdeDataType.Numeric),
        new JdeField("VEN003", "VEN003", JdeDataType.Numeric),
        new JdeField("VEN004", "VEN004", JdeDataType.Numeric),
        new JdeField("VEN005", "VEN005", JdeDataType.Numeric),
        new JdeField("VEN006", "VEN006", JdeDataType.Numeric),
        new JdeField("VEN007", "VEN007", JdeDataType.Numeric),
        new JdeField("VEN008", "VEN008", JdeDataType.Numeric),
        new JdeField("VEN009", "VEN009", JdeDataType.Numeric),
        new JdeField("VEN010", "VEN010", JdeDataType.Numeric),
        new JdeField("VEDC01", "VEDC01", JdeDataType.Numeric),
        new JdeField("VEDC02", "VEDC02", JdeDataType.Numeric),
        new JdeField("VEDC03", "VEDC03", JdeDataType.Numeric),
        new JdeField("VEDC04", "VEDC04", JdeDataType.Numeric),
        new JdeField("VEDC05", "VEDC05", JdeDataType.Numeric),
        new JdeField("VEDC06", "VEDC06", JdeDataType.Numeric),
        new JdeField("VEDC07", "VEDC07", JdeDataType.Numeric),
        new JdeField("VEDC08", "VEDC08", JdeDataType.Numeric),
        new JdeField("VEDC09", "VEDC09", JdeDataType.Numeric),
        new JdeField("VEAN8CM01", "VEAN8CM01", JdeDataType.Numeric),
        new JdeField("VEAN8CM02", "VEAN8CM02", JdeDataType.Numeric),
        new JdeField("VEAN8CM03", "VEAN8CM03", JdeDataType.Numeric),
        new JdeField("VEAN8CM04", "VEAN8CM04", JdeDataType.Numeric),
        new JdeField("VEAN8CM05", "VEAN8CM05", JdeDataType.Numeric),
        new JdeField("VEAN8CM06", "VEAN8CM06", JdeDataType.Numeric),
        new JdeField("VEAN8CM07", "VEAN8CM07", JdeDataType.Numeric),
        new JdeField("VEAN8CM08", "VEAN8CM08", JdeDataType.Numeric),
        new JdeField("VEAN8CM09", "VEAN8CM09", JdeDataType.Numeric),
        new JdeField("VEAN8CM10", "VEAN8CM10", JdeDataType.Numeric),
        new JdeField("VEAN8CM11", "VEAN8CM11", JdeDataType.Numeric),
        new JdeField("VEAN8CM12", "VEAN8CM12", JdeDataType.Numeric),
        new JdeField("VEAN8CM13", "VEAN8CM13", JdeDataType.Numeric),
        new JdeField("VEAN8CM14", "VEAN8CM14", JdeDataType.Numeric),
        new JdeField("VEAN8CM15", "VEAN8CM15", JdeDataType.Numeric),
        new JdeField("VEAN8CM16", "VEAN8CM16", JdeDataType.Numeric),
        new JdeField("VEAN8CM17", "VEAN8CM17", JdeDataType.Numeric),
        new JdeField("VEAN8CM18", "VEAN8CM18", JdeDataType.Numeric),
        new JdeField("VEAN8CM19", "VEAN8CM19", JdeDataType.Numeric),
        new JdeField("VEAN8CM20", "VEAN8CM20", JdeDataType.Numeric),
        new JdeField("VEANSM01", "VEANSM01", JdeDataType.Numeric),
        new JdeField("VEANSM02", "VEANSM02", JdeDataType.Numeric),
        new JdeField("VEANSM03", "VEANSM03", JdeDataType.Numeric),
        new JdeField("VEANSM04", "VEANSM04", JdeDataType.Numeric),
        new JdeField("VEANSM05", "VEANSM05", JdeDataType.Numeric),
        new JdeField("VEANSM06", "VEANSM06", JdeDataType.Numeric),
        new JdeField("VEANSM07", "VEANSM07", JdeDataType.Numeric),
        new JdeField("VEANSM08", "VEANSM08", JdeDataType.Numeric),
        new JdeField("VEANSM09", "VEANSM09", JdeDataType.Numeric),
        new JdeField("VEANSM10", "VEANSM10", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F080434B_0", "Primary Key on VESVER, VEPRNM, VEVRBY, VENEWVAL", new[] { "VESVER", "VEPRNM", "VEVRBY", "VENEWVAL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F080434B_2", "Index on VESVER, VEPRNM, VEVRBY, VECONAME", new[] { "VESVER", "VEPRNM", "VEVRBY", "VECONAME" })
    };
}
