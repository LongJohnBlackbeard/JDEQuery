using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F080434A - .
/// </summary>
public class F080434A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VTSVER.
        /// </summary>
        public const string VTSVER = "VTSVER";

        /// <summary>
        /// VTPRNM.
        /// </summary>
        public const string VTPRNM = "VTPRNM";

        /// <summary>
        /// VTVRBY.
        /// </summary>
        public const string VTVRBY = "VTVRBY";

        /// <summary>
        /// VTWSST.
        /// </summary>
        public const string VTWSST = "VTWSST";

        /// <summary>
        /// VTTPOS.
        /// </summary>
        public const string VTTPOS = "VTTPOS";

        /// <summary>
        /// VTDOCP.
        /// </summary>
        public const string VTDOCP = "VTDOCP";

        /// <summary>
        /// VTCONAME.
        /// </summary>
        public const string VTCONAME = "VTCONAME";

        /// <summary>
        /// VTCOMNT1.
        /// </summary>
        public const string VTCOMNT1 = "VTCOMNT1";

        /// <summary>
        /// VTOFC.
        /// </summary>
        public const string VTOFC = "VTOFC";

        /// <summary>
        /// VTTSKD1.
        /// </summary>
        public const string VTTSKD1 = "VTTSKD1";

        /// <summary>
        /// VTSTAC.
        /// </summary>
        public const string VTSTAC = "VTSTAC";

        /// <summary>
        /// VTCUCD.
        /// </summary>
        public const string VTCUCD = "VTCUCD";

        /// <summary>
        /// VTNEWVAL.
        /// </summary>
        public const string VTNEWVAL = "VTNEWVAL";

        /// <summary>
        /// VTCOMNT2.
        /// </summary>
        public const string VTCOMNT2 = "VTCOMNT2";

        /// <summary>
        /// VTNME.
        /// </summary>
        public const string VTNME = "VTNME";

        /// <summary>
        /// VTWCPL.
        /// </summary>
        public const string VTWCPL = "VTWCPL";

        /// <summary>
        /// VTCTAX.
        /// </summary>
        public const string VTCTAX = "VTCTAX";

        /// <summary>
        /// VTNRSD.
        /// </summary>
        public const string VTNRSD = "VTNRSD";

        /// <summary>
        /// VTCMPC.
        /// </summary>
        public const string VTCMPC = "VTCMPC";

        /// <summary>
        /// VTINSTY.
        /// </summary>
        public const string VTINSTY = "VTINSTY";

        /// <summary>
        /// VTADDN.
        /// </summary>
        public const string VTADDN = "VTADDN";

        /// <summary>
        /// VTETAX.
        /// </summary>
        public const string VTETAX = "VTETAX";

        /// <summary>
        /// VTEE01.
        /// </summary>
        public const string VTEE01 = "VTEE01";

        /// <summary>
        /// VTEE02.
        /// </summary>
        public const string VTEE02 = "VTEE02";

        /// <summary>
        /// VTEE03.
        /// </summary>
        public const string VTEE03 = "VTEE03";

        /// <summary>
        /// VTEE04.
        /// </summary>
        public const string VTEE04 = "VTEE04";

        /// <summary>
        /// VTEE05.
        /// </summary>
        public const string VTEE05 = "VTEE05";

        /// <summary>
        /// VTEE06.
        /// </summary>
        public const string VTEE06 = "VTEE06";

        /// <summary>
        /// VTEE07.
        /// </summary>
        public const string VTEE07 = "VTEE07";

        /// <summary>
        /// VTEE08.
        /// </summary>
        public const string VTEE08 = "VTEE08";

        /// <summary>
        /// VTEE09.
        /// </summary>
        public const string VTEE09 = "VTEE09";

        /// <summary>
        /// VTEE10.
        /// </summary>
        public const string VTEE10 = "VTEE10";

        /// <summary>
        /// VTEE11.
        /// </summary>
        public const string VTEE11 = "VTEE11";

        /// <summary>
        /// VTEE12.
        /// </summary>
        public const string VTEE12 = "VTEE12";

        /// <summary>
        /// VTEE13.
        /// </summary>
        public const string VTEE13 = "VTEE13";

        /// <summary>
        /// VTEE14.
        /// </summary>
        public const string VTEE14 = "VTEE14";

        /// <summary>
        /// VTEE15.
        /// </summary>
        public const string VTEE15 = "VTEE15";

        /// <summary>
        /// VTEE16.
        /// </summary>
        public const string VTEE16 = "VTEE16";

        /// <summary>
        /// VTEE17.
        /// </summary>
        public const string VTEE17 = "VTEE17";

        /// <summary>
        /// VTEE18.
        /// </summary>
        public const string VTEE18 = "VTEE18";

        /// <summary>
        /// VTEE19.
        /// </summary>
        public const string VTEE19 = "VTEE19";

        /// <summary>
        /// VTEE20.
        /// </summary>
        public const string VTEE20 = "VTEE20";

        /// <summary>
        /// VTEE21.
        /// </summary>
        public const string VTEE21 = "VTEE21";

        /// <summary>
        /// VTEE22.
        /// </summary>
        public const string VTEE22 = "VTEE22";

        /// <summary>
        /// VTEE23.
        /// </summary>
        public const string VTEE23 = "VTEE23";

        /// <summary>
        /// VTEE24.
        /// </summary>
        public const string VTEE24 = "VTEE24";

        /// <summary>
        /// VTEE25.
        /// </summary>
        public const string VTEE25 = "VTEE25";

        /// <summary>
        /// VTEE26.
        /// </summary>
        public const string VTEE26 = "VTEE26";

        /// <summary>
        /// VTEE27.
        /// </summary>
        public const string VTEE27 = "VTEE27";

        /// <summary>
        /// VTEE28.
        /// </summary>
        public const string VTEE28 = "VTEE28";

        /// <summary>
        /// VTEE29.
        /// </summary>
        public const string VTEE29 = "VTEE29";

        /// <summary>
        /// VTEE30.
        /// </summary>
        public const string VTEE30 = "VTEE30";

        /// <summary>
        /// VTEE31.
        /// </summary>
        public const string VTEE31 = "VTEE31";

        /// <summary>
        /// VTEE32.
        /// </summary>
        public const string VTEE32 = "VTEE32";

        /// <summary>
        /// VTEE33.
        /// </summary>
        public const string VTEE33 = "VTEE33";

        /// <summary>
        /// VTEE34.
        /// </summary>
        public const string VTEE34 = "VTEE34";

        /// <summary>
        /// VTEE35.
        /// </summary>
        public const string VTEE35 = "VTEE35";

        /// <summary>
        /// VTEE36.
        /// </summary>
        public const string VTEE36 = "VTEE36";

        /// <summary>
        /// VTEE37.
        /// </summary>
        public const string VTEE37 = "VTEE37";

        /// <summary>
        /// VTEE38.
        /// </summary>
        public const string VTEE38 = "VTEE38";

        /// <summary>
        /// VTEE39.
        /// </summary>
        public const string VTEE39 = "VTEE39";

        /// <summary>
        /// VTEE40.
        /// </summary>
        public const string VTEE40 = "VTEE40";

        /// <summary>
        /// VTEE41.
        /// </summary>
        public const string VTEE41 = "VTEE41";

        /// <summary>
        /// VTEE42.
        /// </summary>
        public const string VTEE42 = "VTEE42";

        /// <summary>
        /// VTEE43.
        /// </summary>
        public const string VTEE43 = "VTEE43";

        /// <summary>
        /// VTEE44.
        /// </summary>
        public const string VTEE44 = "VTEE44";

        /// <summary>
        /// VTEE45.
        /// </summary>
        public const string VTEE45 = "VTEE45";

        /// <summary>
        /// VTEE46.
        /// </summary>
        public const string VTEE46 = "VTEE46";

        /// <summary>
        /// VTEE47.
        /// </summary>
        public const string VTEE47 = "VTEE47";

        /// <summary>
        /// VTEE48.
        /// </summary>
        public const string VTEE48 = "VTEE48";

        /// <summary>
        /// VTEE49.
        /// </summary>
        public const string VTEE49 = "VTEE49";

        /// <summary>
        /// VTEE50.
        /// </summary>
        public const string VTEE50 = "VTEE50";

        /// <summary>
        /// VTBN01.
        /// </summary>
        public const string VTBN01 = "VTBN01";

        /// <summary>
        /// VTBN02.
        /// </summary>
        public const string VTBN02 = "VTBN02";

        /// <summary>
        /// VTBN03.
        /// </summary>
        public const string VTBN03 = "VTBN03";

        /// <summary>
        /// VTBN04.
        /// </summary>
        public const string VTBN04 = "VTBN04";

        /// <summary>
        /// VTBN05.
        /// </summary>
        public const string VTBN05 = "VTBN05";

        /// <summary>
        /// VTBN06.
        /// </summary>
        public const string VTBN06 = "VTBN06";

        /// <summary>
        /// VTBN07.
        /// </summary>
        public const string VTBN07 = "VTBN07";

        /// <summary>
        /// VTBN08.
        /// </summary>
        public const string VTBN08 = "VTBN08";

        /// <summary>
        /// VTBN09.
        /// </summary>
        public const string VTBN09 = "VTBN09";

        /// <summary>
        /// VTBN10.
        /// </summary>
        public const string VTBN10 = "VTBN10";

        /// <summary>
        /// VTBN11.
        /// </summary>
        public const string VTBN11 = "VTBN11";

        /// <summary>
        /// VTBN12.
        /// </summary>
        public const string VTBN12 = "VTBN12";

        /// <summary>
        /// VTBN13.
        /// </summary>
        public const string VTBN13 = "VTBN13";

        /// <summary>
        /// VTN001.
        /// </summary>
        public const string VTN001 = "VTN001";

        /// <summary>
        /// VTN002.
        /// </summary>
        public const string VTN002 = "VTN002";

        /// <summary>
        /// VTN003.
        /// </summary>
        public const string VTN003 = "VTN003";

        /// <summary>
        /// VTN004.
        /// </summary>
        public const string VTN004 = "VTN004";

        /// <summary>
        /// VTN005.
        /// </summary>
        public const string VTN005 = "VTN005";

        /// <summary>
        /// VTN006.
        /// </summary>
        public const string VTN006 = "VTN006";

        /// <summary>
        /// VTN007.
        /// </summary>
        public const string VTN007 = "VTN007";

        /// <summary>
        /// VTN008.
        /// </summary>
        public const string VTN008 = "VTN008";

        /// <summary>
        /// VTN009.
        /// </summary>
        public const string VTN009 = "VTN009";

        /// <summary>
        /// VTN010.
        /// </summary>
        public const string VTN010 = "VTN010";

        /// <summary>
        /// VTDC01.
        /// </summary>
        public const string VTDC01 = "VTDC01";

        /// <summary>
        /// VTDC02.
        /// </summary>
        public const string VTDC02 = "VTDC02";

        /// <summary>
        /// VTDC03.
        /// </summary>
        public const string VTDC03 = "VTDC03";

        /// <summary>
        /// VTDC04.
        /// </summary>
        public const string VTDC04 = "VTDC04";

        /// <summary>
        /// VTDC05.
        /// </summary>
        public const string VTDC05 = "VTDC05";

        /// <summary>
        /// VTDC06.
        /// </summary>
        public const string VTDC06 = "VTDC06";

        /// <summary>
        /// VTDC07.
        /// </summary>
        public const string VTDC07 = "VTDC07";

        /// <summary>
        /// VTDC08.
        /// </summary>
        public const string VTDC08 = "VTDC08";

        /// <summary>
        /// VTDC09.
        /// </summary>
        public const string VTDC09 = "VTDC09";
    }

    /// <inheritdoc />
    public override string TableName => "F080434A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VTSVER", "VTSVER", JdeDataType.String, 20, true, true),
        new JdeField("VTPRNM", "VTPRNM", JdeDataType.String, 40, true, true),
        new JdeField("VTVRBY", "VTVRBY", JdeDataType.String, 16, true, true),
        new JdeField("VTWSST", "VTWSST", JdeDataType.String, 2),
        new JdeField("VTTPOS", "VTTPOS", JdeDataType.String, 6),
        new JdeField("VTDOCP", "VTDOCP", JdeDataType.Numeric),
        new JdeField("VTCONAME", "VTCONAME", JdeDataType.String, 80),
        new JdeField("VTCOMNT1", "VTCOMNT1", JdeDataType.String, 80),
        new JdeField("VTOFC", "VTOFC", JdeDataType.String, 40),
        new JdeField("VTTSKD1", "VTTSKD1", JdeDataType.String, 40),
        new JdeField("VTSTAC", "VTSTAC", JdeDataType.String, 4),
        new JdeField("VTCUCD", "VTCUCD", JdeDataType.String, 20),
        new JdeField("VTNEWVAL", "VTNEWVAL", JdeDataType.String, 40, true, true),
        new JdeField("VTCOMNT2", "VTCOMNT2", JdeDataType.String, 80),
        new JdeField("VTNME", "VTNME", JdeDataType.String, 80),
        new JdeField("VTWCPL", "VTWCPL", JdeDataType.String, 40),
        new JdeField("VTCTAX", "VTCTAX", JdeDataType.String, 40),
        new JdeField("VTNRSD", "VTNRSD", JdeDataType.String, 4),
        new JdeField("VTCMPC", "VTCMPC", JdeDataType.String, 20),
        new JdeField("VTINSTY", "VTINSTY", JdeDataType.String, 20),
        new JdeField("VTADDN", "VTADDN", JdeDataType.String, 40),
        new JdeField("VTETAX", "VTETAX", JdeDataType.String, 40),
        new JdeField("VTEE01", "VTEE01", JdeDataType.Numeric),
        new JdeField("VTEE02", "VTEE02", JdeDataType.Numeric),
        new JdeField("VTEE03", "VTEE03", JdeDataType.Numeric),
        new JdeField("VTEE04", "VTEE04", JdeDataType.Numeric),
        new JdeField("VTEE05", "VTEE05", JdeDataType.Numeric),
        new JdeField("VTEE06", "VTEE06", JdeDataType.Numeric),
        new JdeField("VTEE07", "VTEE07", JdeDataType.Numeric),
        new JdeField("VTEE08", "VTEE08", JdeDataType.Numeric),
        new JdeField("VTEE09", "VTEE09", JdeDataType.Numeric),
        new JdeField("VTEE10", "VTEE10", JdeDataType.Numeric),
        new JdeField("VTEE11", "VTEE11", JdeDataType.Numeric),
        new JdeField("VTEE12", "VTEE12", JdeDataType.Numeric),
        new JdeField("VTEE13", "VTEE13", JdeDataType.Numeric),
        new JdeField("VTEE14", "VTEE14", JdeDataType.Numeric),
        new JdeField("VTEE15", "VTEE15", JdeDataType.Numeric),
        new JdeField("VTEE16", "VTEE16", JdeDataType.Numeric),
        new JdeField("VTEE17", "VTEE17", JdeDataType.Numeric),
        new JdeField("VTEE18", "VTEE18", JdeDataType.Numeric),
        new JdeField("VTEE19", "VTEE19", JdeDataType.Numeric),
        new JdeField("VTEE20", "VTEE20", JdeDataType.Numeric),
        new JdeField("VTEE21", "VTEE21", JdeDataType.Numeric),
        new JdeField("VTEE22", "VTEE22", JdeDataType.Numeric),
        new JdeField("VTEE23", "VTEE23", JdeDataType.Numeric),
        new JdeField("VTEE24", "VTEE24", JdeDataType.Numeric),
        new JdeField("VTEE25", "VTEE25", JdeDataType.Numeric),
        new JdeField("VTEE26", "VTEE26", JdeDataType.Numeric),
        new JdeField("VTEE27", "VTEE27", JdeDataType.Numeric),
        new JdeField("VTEE28", "VTEE28", JdeDataType.Numeric),
        new JdeField("VTEE29", "VTEE29", JdeDataType.Numeric),
        new JdeField("VTEE30", "VTEE30", JdeDataType.Numeric),
        new JdeField("VTEE31", "VTEE31", JdeDataType.Numeric),
        new JdeField("VTEE32", "VTEE32", JdeDataType.Numeric),
        new JdeField("VTEE33", "VTEE33", JdeDataType.Numeric),
        new JdeField("VTEE34", "VTEE34", JdeDataType.Numeric),
        new JdeField("VTEE35", "VTEE35", JdeDataType.Numeric),
        new JdeField("VTEE36", "VTEE36", JdeDataType.Numeric),
        new JdeField("VTEE37", "VTEE37", JdeDataType.Numeric),
        new JdeField("VTEE38", "VTEE38", JdeDataType.Numeric),
        new JdeField("VTEE39", "VTEE39", JdeDataType.Numeric),
        new JdeField("VTEE40", "VTEE40", JdeDataType.Numeric),
        new JdeField("VTEE41", "VTEE41", JdeDataType.Numeric),
        new JdeField("VTEE42", "VTEE42", JdeDataType.Numeric),
        new JdeField("VTEE43", "VTEE43", JdeDataType.Numeric),
        new JdeField("VTEE44", "VTEE44", JdeDataType.Numeric),
        new JdeField("VTEE45", "VTEE45", JdeDataType.Numeric),
        new JdeField("VTEE46", "VTEE46", JdeDataType.Numeric),
        new JdeField("VTEE47", "VTEE47", JdeDataType.Numeric),
        new JdeField("VTEE48", "VTEE48", JdeDataType.Numeric),
        new JdeField("VTEE49", "VTEE49", JdeDataType.Numeric),
        new JdeField("VTEE50", "VTEE50", JdeDataType.Numeric),
        new JdeField("VTBN01", "VTBN01", JdeDataType.Numeric),
        new JdeField("VTBN02", "VTBN02", JdeDataType.Numeric),
        new JdeField("VTBN03", "VTBN03", JdeDataType.Numeric),
        new JdeField("VTBN04", "VTBN04", JdeDataType.Numeric),
        new JdeField("VTBN05", "VTBN05", JdeDataType.Numeric),
        new JdeField("VTBN06", "VTBN06", JdeDataType.Numeric),
        new JdeField("VTBN07", "VTBN07", JdeDataType.Numeric),
        new JdeField("VTBN08", "VTBN08", JdeDataType.Numeric),
        new JdeField("VTBN09", "VTBN09", JdeDataType.Numeric),
        new JdeField("VTBN10", "VTBN10", JdeDataType.Numeric),
        new JdeField("VTBN11", "VTBN11", JdeDataType.Numeric),
        new JdeField("VTBN12", "VTBN12", JdeDataType.Numeric),
        new JdeField("VTBN13", "VTBN13", JdeDataType.Numeric),
        new JdeField("VTN001", "VTN001", JdeDataType.Numeric),
        new JdeField("VTN002", "VTN002", JdeDataType.Numeric),
        new JdeField("VTN003", "VTN003", JdeDataType.Numeric),
        new JdeField("VTN004", "VTN004", JdeDataType.Numeric),
        new JdeField("VTN005", "VTN005", JdeDataType.Numeric),
        new JdeField("VTN006", "VTN006", JdeDataType.Numeric),
        new JdeField("VTN007", "VTN007", JdeDataType.Numeric),
        new JdeField("VTN008", "VTN008", JdeDataType.Numeric),
        new JdeField("VTN009", "VTN009", JdeDataType.Numeric),
        new JdeField("VTN010", "VTN010", JdeDataType.Numeric),
        new JdeField("VTDC01", "VTDC01", JdeDataType.Numeric),
        new JdeField("VTDC02", "VTDC02", JdeDataType.Numeric),
        new JdeField("VTDC03", "VTDC03", JdeDataType.Numeric),
        new JdeField("VTDC04", "VTDC04", JdeDataType.Numeric),
        new JdeField("VTDC05", "VTDC05", JdeDataType.Numeric),
        new JdeField("VTDC06", "VTDC06", JdeDataType.Numeric),
        new JdeField("VTDC07", "VTDC07", JdeDataType.Numeric),
        new JdeField("VTDC08", "VTDC08", JdeDataType.Numeric),
        new JdeField("VTDC09", "VTDC09", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F080434A_0", "Primary Key on VTSVER, VTPRNM, VTVRBY, VTNEWVAL", new[] { "VTSVER", "VTPRNM", "VTVRBY", "VTNEWVAL" }, isUnique: true, isPrimaryKey: true)
    };
}
