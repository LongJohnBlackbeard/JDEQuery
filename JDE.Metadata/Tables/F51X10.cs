using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51X10 - .
/// </summary>
public class F51X10 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EXUSER.
        /// </summary>
        public const string EXUSER = "EXUSER";

        /// <summary>
        /// EXJOBS.
        /// </summary>
        public const string EXJOBS = "EXJOBS";

        /// <summary>
        /// EX51XRTY.
        /// </summary>
        public const string EX51XRTY = "EX51XRTY";

        /// <summary>
        /// EX51XTC.
        /// </summary>
        public const string EX51XTC = "EX51XTC";

        /// <summary>
        /// EX51XTCD.
        /// </summary>
        public const string EX51XTCD = "EX51XTCD";

        /// <summary>
        /// EXMCU.
        /// </summary>
        public const string EXMCU = "EXMCU";

        /// <summary>
        /// EX51XCT1.
        /// </summary>
        public const string EX51XCT1 = "EX51XCT1";

        /// <summary>
        /// EX51XCT2.
        /// </summary>
        public const string EX51XCT2 = "EX51XCT2";

        /// <summary>
        /// EX51XSEQ.
        /// </summary>
        public const string EX51XSEQ = "EX51XSEQ";

        /// <summary>
        /// EX51XSQT.
        /// </summary>
        public const string EX51XSQT = "EX51XSQT";

        /// <summary>
        /// EXCO.
        /// </summary>
        public const string EXCO = "EXCO";

        /// <summary>
        /// EXMCUS.
        /// </summary>
        public const string EXMCUS = "EXMCUS";

        /// <summary>
        /// EXDL01.
        /// </summary>
        public const string EXDL01 = "EXDL01";

        /// <summary>
        /// EXAID.
        /// </summary>
        public const string EXAID = "EXAID";

        /// <summary>
        /// EXCRCD.
        /// </summary>
        public const string EXCRCD = "EXCRCD";

        /// <summary>
        /// EX51XZBA.
        /// </summary>
        public const string EX51XZBA = "EX51XZBA";

        /// <summary>
        /// EX51XHA.
        /// </summary>
        public const string EX51XHA = "EX51XHA";

        /// <summary>
        /// EX51XC01.
        /// </summary>
        public const string EX51XC01 = "EX51XC01";

        /// <summary>
        /// EX51XC02.
        /// </summary>
        public const string EX51XC02 = "EX51XC02";

        /// <summary>
        /// EX51XC03.
        /// </summary>
        public const string EX51XC03 = "EX51XC03";

        /// <summary>
        /// EX51XC04.
        /// </summary>
        public const string EX51XC04 = "EX51XC04";

        /// <summary>
        /// EX51XC05.
        /// </summary>
        public const string EX51XC05 = "EX51XC05";

        /// <summary>
        /// EX51XC06.
        /// </summary>
        public const string EX51XC06 = "EX51XC06";

        /// <summary>
        /// EX51XC07.
        /// </summary>
        public const string EX51XC07 = "EX51XC07";

        /// <summary>
        /// EX51XC08.
        /// </summary>
        public const string EX51XC08 = "EX51XC08";

        /// <summary>
        /// EX51XC09.
        /// </summary>
        public const string EX51XC09 = "EX51XC09";

        /// <summary>
        /// EX51XC10.
        /// </summary>
        public const string EX51XC10 = "EX51XC10";

        /// <summary>
        /// EX51XC11.
        /// </summary>
        public const string EX51XC11 = "EX51XC11";

        /// <summary>
        /// EX51XC12.
        /// </summary>
        public const string EX51XC12 = "EX51XC12";

        /// <summary>
        /// EX51XC13.
        /// </summary>
        public const string EX51XC13 = "EX51XC13";

        /// <summary>
        /// EX51XC14.
        /// </summary>
        public const string EX51XC14 = "EX51XC14";

        /// <summary>
        /// EX51XC15.
        /// </summary>
        public const string EX51XC15 = "EX51XC15";

        /// <summary>
        /// EX51XC16.
        /// </summary>
        public const string EX51XC16 = "EX51XC16";

        /// <summary>
        /// EX51XC17.
        /// </summary>
        public const string EX51XC17 = "EX51XC17";

        /// <summary>
        /// EX51XC18.
        /// </summary>
        public const string EX51XC18 = "EX51XC18";

        /// <summary>
        /// EX51XC19.
        /// </summary>
        public const string EX51XC19 = "EX51XC19";

        /// <summary>
        /// EX51XC20.
        /// </summary>
        public const string EX51XC20 = "EX51XC20";

        /// <summary>
        /// EX51XC21.
        /// </summary>
        public const string EX51XC21 = "EX51XC21";

        /// <summary>
        /// EX51XC22.
        /// </summary>
        public const string EX51XC22 = "EX51XC22";

        /// <summary>
        /// EX51XC23.
        /// </summary>
        public const string EX51XC23 = "EX51XC23";

        /// <summary>
        /// EX51XC24.
        /// </summary>
        public const string EX51XC24 = "EX51XC24";

        /// <summary>
        /// EX51XC25.
        /// </summary>
        public const string EX51XC25 = "EX51XC25";

        /// <summary>
        /// EX51XC26.
        /// </summary>
        public const string EX51XC26 = "EX51XC26";

        /// <summary>
        /// EX51XC27.
        /// </summary>
        public const string EX51XC27 = "EX51XC27";

        /// <summary>
        /// EX51XC28.
        /// </summary>
        public const string EX51XC28 = "EX51XC28";

        /// <summary>
        /// EX51XC29.
        /// </summary>
        public const string EX51XC29 = "EX51XC29";

        /// <summary>
        /// EX51XC30.
        /// </summary>
        public const string EX51XC30 = "EX51XC30";

        /// <summary>
        /// EX51XC31.
        /// </summary>
        public const string EX51XC31 = "EX51XC31";

        /// <summary>
        /// EX51XC32.
        /// </summary>
        public const string EX51XC32 = "EX51XC32";

        /// <summary>
        /// EX51XC33.
        /// </summary>
        public const string EX51XC33 = "EX51XC33";

        /// <summary>
        /// EX51XC34.
        /// </summary>
        public const string EX51XC34 = "EX51XC34";

        /// <summary>
        /// EX51XC35.
        /// </summary>
        public const string EX51XC35 = "EX51XC35";

        /// <summary>
        /// EX51XC36.
        /// </summary>
        public const string EX51XC36 = "EX51XC36";

        /// <summary>
        /// EX51XC37.
        /// </summary>
        public const string EX51XC37 = "EX51XC37";

        /// <summary>
        /// EX51XC38.
        /// </summary>
        public const string EX51XC38 = "EX51XC38";

        /// <summary>
        /// EX51XC39.
        /// </summary>
        public const string EX51XC39 = "EX51XC39";

        /// <summary>
        /// EX51XC40.
        /// </summary>
        public const string EX51XC40 = "EX51XC40";

        /// <summary>
        /// EXSTYL.
        /// </summary>
        public const string EXSTYL = "EXSTYL";

        /// <summary>
        /// EXPECC.
        /// </summary>
        public const string EXPECC = "EXPECC";

        /// <summary>
        /// EXDOCO.
        /// </summary>
        public const string EXDOCO = "EXDOCO";

        /// <summary>
        /// EXPCTN.
        /// </summary>
        public const string EXPCTN = "EXPCTN";

        /// <summary>
        /// EXCLNU.
        /// </summary>
        public const string EXCLNU = "EXCLNU";

        /// <summary>
        /// EXADDS.
        /// </summary>
        public const string EXADDS = "EXADDS";

        /// <summary>
        /// EXAN8O.
        /// </summary>
        public const string EXAN8O = "EXAN8O";

        /// <summary>
        /// EXAN8GCA1.
        /// </summary>
        public const string EXAN8GCA1 = "EXAN8GCA1";

        /// <summary>
        /// EXAN8GCA2.
        /// </summary>
        public const string EXAN8GCA2 = "EXAN8GCA2";

        /// <summary>
        /// EXAN8GCA3.
        /// </summary>
        public const string EXAN8GCA3 = "EXAN8GCA3";

        /// <summary>
        /// EXAN8GCA4.
        /// </summary>
        public const string EXAN8GCA4 = "EXAN8GCA4";

        /// <summary>
        /// EXAN8GCA5.
        /// </summary>
        public const string EXAN8GCA5 = "EXAN8GCA5";

        /// <summary>
        /// EXANPA.
        /// </summary>
        public const string EXANPA = "EXANPA";

        /// <summary>
        /// EXCT.
        /// </summary>
        public const string EXCT = "EXCT";

        /// <summary>
        /// EXD1J.
        /// </summary>
        public const string EXD1J = "EXD1J";

        /// <summary>
        /// EXD2J.
        /// </summary>
        public const string EXD2J = "EXD2J";

        /// <summary>
        /// EXD3J.
        /// </summary>
        public const string EXD3J = "EXD3J";

        /// <summary>
        /// EXD4J.
        /// </summary>
        public const string EXD4J = "EXD4J";

        /// <summary>
        /// EXD5J.
        /// </summary>
        public const string EXD5J = "EXD5J";

        /// <summary>
        /// EXD6J.
        /// </summary>
        public const string EXD6J = "EXD6J";

        /// <summary>
        /// EXRP01.
        /// </summary>
        public const string EXRP01 = "EXRP01";

        /// <summary>
        /// EXRP02.
        /// </summary>
        public const string EXRP02 = "EXRP02";

        /// <summary>
        /// EXRP03.
        /// </summary>
        public const string EXRP03 = "EXRP03";

        /// <summary>
        /// EXRP04.
        /// </summary>
        public const string EXRP04 = "EXRP04";

        /// <summary>
        /// EXRP05.
        /// </summary>
        public const string EXRP05 = "EXRP05";

        /// <summary>
        /// EXRP06.
        /// </summary>
        public const string EXRP06 = "EXRP06";

        /// <summary>
        /// EXRP07.
        /// </summary>
        public const string EXRP07 = "EXRP07";

        /// <summary>
        /// EXRP08.
        /// </summary>
        public const string EXRP08 = "EXRP08";

        /// <summary>
        /// EXRP09.
        /// </summary>
        public const string EXRP09 = "EXRP09";

        /// <summary>
        /// EXRP10.
        /// </summary>
        public const string EXRP10 = "EXRP10";

        /// <summary>
        /// EXRP11.
        /// </summary>
        public const string EXRP11 = "EXRP11";

        /// <summary>
        /// EXRP12.
        /// </summary>
        public const string EXRP12 = "EXRP12";

        /// <summary>
        /// EXRP13.
        /// </summary>
        public const string EXRP13 = "EXRP13";

        /// <summary>
        /// EXRP14.
        /// </summary>
        public const string EXRP14 = "EXRP14";

        /// <summary>
        /// EXRP15.
        /// </summary>
        public const string EXRP15 = "EXRP15";

        /// <summary>
        /// EXRP16.
        /// </summary>
        public const string EXRP16 = "EXRP16";

        /// <summary>
        /// EXRP17.
        /// </summary>
        public const string EXRP17 = "EXRP17";

        /// <summary>
        /// EXRP18.
        /// </summary>
        public const string EXRP18 = "EXRP18";

        /// <summary>
        /// EXRP19.
        /// </summary>
        public const string EXRP19 = "EXRP19";

        /// <summary>
        /// EXRP20.
        /// </summary>
        public const string EXRP20 = "EXRP20";

        /// <summary>
        /// EXRP21.
        /// </summary>
        public const string EXRP21 = "EXRP21";

        /// <summary>
        /// EXRP22.
        /// </summary>
        public const string EXRP22 = "EXRP22";

        /// <summary>
        /// EXRP23.
        /// </summary>
        public const string EXRP23 = "EXRP23";

        /// <summary>
        /// EXRP24.
        /// </summary>
        public const string EXRP24 = "EXRP24";

        /// <summary>
        /// EXRP25.
        /// </summary>
        public const string EXRP25 = "EXRP25";

        /// <summary>
        /// EXRP26.
        /// </summary>
        public const string EXRP26 = "EXRP26";

        /// <summary>
        /// EXRP27.
        /// </summary>
        public const string EXRP27 = "EXRP27";

        /// <summary>
        /// EXRP28.
        /// </summary>
        public const string EXRP28 = "EXRP28";

        /// <summary>
        /// EXRP29.
        /// </summary>
        public const string EXRP29 = "EXRP29";

        /// <summary>
        /// EXRP30.
        /// </summary>
        public const string EXRP30 = "EXRP30";

        /// <summary>
        /// EXRP31.
        /// </summary>
        public const string EXRP31 = "EXRP31";

        /// <summary>
        /// EXRP32.
        /// </summary>
        public const string EXRP32 = "EXRP32";

        /// <summary>
        /// EXRP33.
        /// </summary>
        public const string EXRP33 = "EXRP33";

        /// <summary>
        /// EXRP34.
        /// </summary>
        public const string EXRP34 = "EXRP34";

        /// <summary>
        /// EXRP35.
        /// </summary>
        public const string EXRP35 = "EXRP35";

        /// <summary>
        /// EXRP36.
        /// </summary>
        public const string EXRP36 = "EXRP36";

        /// <summary>
        /// EXRP37.
        /// </summary>
        public const string EXRP37 = "EXRP37";

        /// <summary>
        /// EXRP38.
        /// </summary>
        public const string EXRP38 = "EXRP38";

        /// <summary>
        /// EXRP39.
        /// </summary>
        public const string EXRP39 = "EXRP39";

        /// <summary>
        /// EXRP40.
        /// </summary>
        public const string EXRP40 = "EXRP40";

        /// <summary>
        /// EXRP41.
        /// </summary>
        public const string EXRP41 = "EXRP41";

        /// <summary>
        /// EXRP42.
        /// </summary>
        public const string EXRP42 = "EXRP42";

        /// <summary>
        /// EXRP43.
        /// </summary>
        public const string EXRP43 = "EXRP43";

        /// <summary>
        /// EXRP44.
        /// </summary>
        public const string EXRP44 = "EXRP44";

        /// <summary>
        /// EXRP45.
        /// </summary>
        public const string EXRP45 = "EXRP45";

        /// <summary>
        /// EXRP46.
        /// </summary>
        public const string EXRP46 = "EXRP46";

        /// <summary>
        /// EXRP47.
        /// </summary>
        public const string EXRP47 = "EXRP47";

        /// <summary>
        /// EXRP48.
        /// </summary>
        public const string EXRP48 = "EXRP48";

        /// <summary>
        /// EXRP49.
        /// </summary>
        public const string EXRP49 = "EXRP49";

        /// <summary>
        /// EXRP50.
        /// </summary>
        public const string EXRP50 = "EXRP50";

        /// <summary>
        /// EX51XACD.
        /// </summary>
        public const string EX51XACD = "EX51XACD";

        /// <summary>
        /// EXLDA.
        /// </summary>
        public const string EXLDA = "EXLDA";

        /// <summary>
        /// EXPEC.
        /// </summary>
        public const string EXPEC = "EXPEC";

        /// <summary>
        /// EXUM.
        /// </summary>
        public const string EXUM = "EXUM";

        /// <summary>
        /// EXSUBA.
        /// </summary>
        public const string EXSUBA = "EXSUBA";

        /// <summary>
        /// EXR001.
        /// </summary>
        public const string EXR001 = "EXR001";

        /// <summary>
        /// EXR002.
        /// </summary>
        public const string EXR002 = "EXR002";

        /// <summary>
        /// EXR003.
        /// </summary>
        public const string EXR003 = "EXR003";

        /// <summary>
        /// EXR004.
        /// </summary>
        public const string EXR004 = "EXR004";

        /// <summary>
        /// EXR005.
        /// </summary>
        public const string EXR005 = "EXR005";

        /// <summary>
        /// EXR006.
        /// </summary>
        public const string EXR006 = "EXR006";

        /// <summary>
        /// EXR007.
        /// </summary>
        public const string EXR007 = "EXR007";

        /// <summary>
        /// EXR008.
        /// </summary>
        public const string EXR008 = "EXR008";

        /// <summary>
        /// EXR009.
        /// </summary>
        public const string EXR009 = "EXR009";

        /// <summary>
        /// EXR010.
        /// </summary>
        public const string EXR010 = "EXR010";

        /// <summary>
        /// EXR011.
        /// </summary>
        public const string EXR011 = "EXR011";

        /// <summary>
        /// EXR012.
        /// </summary>
        public const string EXR012 = "EXR012";

        /// <summary>
        /// EXR013.
        /// </summary>
        public const string EXR013 = "EXR013";

        /// <summary>
        /// EXR014.
        /// </summary>
        public const string EXR014 = "EXR014";

        /// <summary>
        /// EXR015.
        /// </summary>
        public const string EXR015 = "EXR015";

        /// <summary>
        /// EXR016.
        /// </summary>
        public const string EXR016 = "EXR016";

        /// <summary>
        /// EXR017.
        /// </summary>
        public const string EXR017 = "EXR017";

        /// <summary>
        /// EXR018.
        /// </summary>
        public const string EXR018 = "EXR018";

        /// <summary>
        /// EXR019.
        /// </summary>
        public const string EXR019 = "EXR019";

        /// <summary>
        /// EXR020.
        /// </summary>
        public const string EXR020 = "EXR020";

        /// <summary>
        /// EXR021.
        /// </summary>
        public const string EXR021 = "EXR021";

        /// <summary>
        /// EXR022.
        /// </summary>
        public const string EXR022 = "EXR022";

        /// <summary>
        /// EXR023.
        /// </summary>
        public const string EXR023 = "EXR023";

        /// <summary>
        /// EXR024.
        /// </summary>
        public const string EXR024 = "EXR024";

        /// <summary>
        /// EXR025.
        /// </summary>
        public const string EXR025 = "EXR025";

        /// <summary>
        /// EXR026.
        /// </summary>
        public const string EXR026 = "EXR026";

        /// <summary>
        /// EXR027.
        /// </summary>
        public const string EXR027 = "EXR027";

        /// <summary>
        /// EXR028.
        /// </summary>
        public const string EXR028 = "EXR028";

        /// <summary>
        /// EXR029.
        /// </summary>
        public const string EXR029 = "EXR029";

        /// <summary>
        /// EXR030.
        /// </summary>
        public const string EXR030 = "EXR030";

        /// <summary>
        /// EXR031.
        /// </summary>
        public const string EXR031 = "EXR031";

        /// <summary>
        /// EXR032.
        /// </summary>
        public const string EXR032 = "EXR032";

        /// <summary>
        /// EXR033.
        /// </summary>
        public const string EXR033 = "EXR033";

        /// <summary>
        /// EXR034.
        /// </summary>
        public const string EXR034 = "EXR034";

        /// <summary>
        /// EXR035.
        /// </summary>
        public const string EXR035 = "EXR035";

        /// <summary>
        /// EXR036.
        /// </summary>
        public const string EXR036 = "EXR036";

        /// <summary>
        /// EXR037.
        /// </summary>
        public const string EXR037 = "EXR037";

        /// <summary>
        /// EXR038.
        /// </summary>
        public const string EXR038 = "EXR038";

        /// <summary>
        /// EXR039.
        /// </summary>
        public const string EXR039 = "EXR039";

        /// <summary>
        /// EXR040.
        /// </summary>
        public const string EXR040 = "EXR040";

        /// <summary>
        /// EXR041.
        /// </summary>
        public const string EXR041 = "EXR041";

        /// <summary>
        /// EXR042.
        /// </summary>
        public const string EXR042 = "EXR042";

        /// <summary>
        /// EXR043.
        /// </summary>
        public const string EXR043 = "EXR043";

        /// <summary>
        /// EXCCT.
        /// </summary>
        public const string EXCCT = "EXCCT";
    }

    /// <inheritdoc />
    public override string TableName => "F51X10";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EXUSER", "EXUSER", JdeDataType.String, 20, true, true),
        new JdeField("EXJOBS", "EXJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("EX51XRTY", "EX51XRTY", JdeDataType.String, 2, true, true),
        new JdeField("EX51XTC", "EX51XTC", JdeDataType.String, 24, true, true),
        new JdeField("EX51XTCD", "EX51XTCD", JdeDataType.String, 60),
        new JdeField("EXMCU", "EXMCU", JdeDataType.String, 24, true, true),
        new JdeField("EX51XCT1", "EX51XCT1", JdeDataType.String, 16, true, true),
        new JdeField("EX51XCT2", "EX51XCT2", JdeDataType.String, 16, true, true),
        new JdeField("EX51XSEQ", "EX51XSEQ", JdeDataType.Numeric),
        new JdeField("EX51XSQT", "EX51XSQT", JdeDataType.String, 2),
        new JdeField("EXCO", "EXCO", JdeDataType.String, 10),
        new JdeField("EXMCUS", "EXMCUS", JdeDataType.String, 24),
        new JdeField("EXDL01", "EXDL01", JdeDataType.String, 60),
        new JdeField("EXAID", "EXAID", JdeDataType.String, 16),
        new JdeField("EXCRCD", "EXCRCD", JdeDataType.String, 6),
        new JdeField("EX51XZBA", "EX51XZBA", JdeDataType.String, 2),
        new JdeField("EX51XHA", "EX51XHA", JdeDataType.String, 2),
        new JdeField("EX51XC01", "EX51XC01", JdeDataType.Numeric),
        new JdeField("EX51XC02", "EX51XC02", JdeDataType.Numeric),
        new JdeField("EX51XC03", "EX51XC03", JdeDataType.Numeric),
        new JdeField("EX51XC04", "EX51XC04", JdeDataType.Numeric),
        new JdeField("EX51XC05", "EX51XC05", JdeDataType.Numeric),
        new JdeField("EX51XC06", "EX51XC06", JdeDataType.Numeric),
        new JdeField("EX51XC07", "EX51XC07", JdeDataType.Numeric),
        new JdeField("EX51XC08", "EX51XC08", JdeDataType.Numeric),
        new JdeField("EX51XC09", "EX51XC09", JdeDataType.Numeric),
        new JdeField("EX51XC10", "EX51XC10", JdeDataType.Numeric),
        new JdeField("EX51XC11", "EX51XC11", JdeDataType.Numeric),
        new JdeField("EX51XC12", "EX51XC12", JdeDataType.Numeric),
        new JdeField("EX51XC13", "EX51XC13", JdeDataType.Numeric),
        new JdeField("EX51XC14", "EX51XC14", JdeDataType.Numeric),
        new JdeField("EX51XC15", "EX51XC15", JdeDataType.Numeric),
        new JdeField("EX51XC16", "EX51XC16", JdeDataType.Numeric),
        new JdeField("EX51XC17", "EX51XC17", JdeDataType.Numeric),
        new JdeField("EX51XC18", "EX51XC18", JdeDataType.Numeric),
        new JdeField("EX51XC19", "EX51XC19", JdeDataType.Numeric),
        new JdeField("EX51XC20", "EX51XC20", JdeDataType.Numeric),
        new JdeField("EX51XC21", "EX51XC21", JdeDataType.Numeric),
        new JdeField("EX51XC22", "EX51XC22", JdeDataType.Numeric),
        new JdeField("EX51XC23", "EX51XC23", JdeDataType.Numeric),
        new JdeField("EX51XC24", "EX51XC24", JdeDataType.Numeric),
        new JdeField("EX51XC25", "EX51XC25", JdeDataType.Numeric),
        new JdeField("EX51XC26", "EX51XC26", JdeDataType.Numeric),
        new JdeField("EX51XC27", "EX51XC27", JdeDataType.Numeric),
        new JdeField("EX51XC28", "EX51XC28", JdeDataType.Numeric),
        new JdeField("EX51XC29", "EX51XC29", JdeDataType.Numeric),
        new JdeField("EX51XC30", "EX51XC30", JdeDataType.Numeric),
        new JdeField("EX51XC31", "EX51XC31", JdeDataType.Numeric),
        new JdeField("EX51XC32", "EX51XC32", JdeDataType.Numeric),
        new JdeField("EX51XC33", "EX51XC33", JdeDataType.Numeric),
        new JdeField("EX51XC34", "EX51XC34", JdeDataType.Numeric),
        new JdeField("EX51XC35", "EX51XC35", JdeDataType.Numeric),
        new JdeField("EX51XC36", "EX51XC36", JdeDataType.Numeric),
        new JdeField("EX51XC37", "EX51XC37", JdeDataType.Numeric),
        new JdeField("EX51XC38", "EX51XC38", JdeDataType.Numeric),
        new JdeField("EX51XC39", "EX51XC39", JdeDataType.Numeric),
        new JdeField("EX51XC40", "EX51XC40", JdeDataType.Numeric),
        new JdeField("EXSTYL", "EXSTYL", JdeDataType.String, 4),
        new JdeField("EXPECC", "EXPECC", JdeDataType.String, 2),
        new JdeField("EXDOCO", "EXDOCO", JdeDataType.Numeric),
        new JdeField("EXPCTN", "EXPCTN", JdeDataType.Numeric),
        new JdeField("EXCLNU", "EXCLNU", JdeDataType.Numeric),
        new JdeField("EXADDS", "EXADDS", JdeDataType.String, 6),
        new JdeField("EXAN8O", "EXAN8O", JdeDataType.Numeric),
        new JdeField("EXAN8GCA1", "EXAN8GCA1", JdeDataType.Numeric),
        new JdeField("EXAN8GCA2", "EXAN8GCA2", JdeDataType.Numeric),
        new JdeField("EXAN8GCA3", "EXAN8GCA3", JdeDataType.Numeric),
        new JdeField("EXAN8GCA4", "EXAN8GCA4", JdeDataType.Numeric),
        new JdeField("EXAN8GCA5", "EXAN8GCA5", JdeDataType.Numeric),
        new JdeField("EXANPA", "EXANPA", JdeDataType.Numeric),
        new JdeField("EXCT", "EXCT", JdeDataType.String, 8),
        new JdeField("EXD1J", "EXD1J", JdeDataType.Numeric),
        new JdeField("EXD2J", "EXD2J", JdeDataType.Numeric),
        new JdeField("EXD3J", "EXD3J", JdeDataType.Numeric),
        new JdeField("EXD4J", "EXD4J", JdeDataType.Numeric),
        new JdeField("EXD5J", "EXD5J", JdeDataType.Numeric),
        new JdeField("EXD6J", "EXD6J", JdeDataType.Numeric),
        new JdeField("EXRP01", "EXRP01", JdeDataType.String, 6),
        new JdeField("EXRP02", "EXRP02", JdeDataType.String, 6),
        new JdeField("EXRP03", "EXRP03", JdeDataType.String, 6),
        new JdeField("EXRP04", "EXRP04", JdeDataType.String, 6),
        new JdeField("EXRP05", "EXRP05", JdeDataType.String, 6),
        new JdeField("EXRP06", "EXRP06", JdeDataType.String, 6),
        new JdeField("EXRP07", "EXRP07", JdeDataType.String, 6),
        new JdeField("EXRP08", "EXRP08", JdeDataType.String, 6),
        new JdeField("EXRP09", "EXRP09", JdeDataType.String, 6),
        new JdeField("EXRP10", "EXRP10", JdeDataType.String, 6),
        new JdeField("EXRP11", "EXRP11", JdeDataType.String, 6),
        new JdeField("EXRP12", "EXRP12", JdeDataType.String, 6),
        new JdeField("EXRP13", "EXRP13", JdeDataType.String, 6),
        new JdeField("EXRP14", "EXRP14", JdeDataType.String, 6),
        new JdeField("EXRP15", "EXRP15", JdeDataType.String, 6),
        new JdeField("EXRP16", "EXRP16", JdeDataType.String, 6),
        new JdeField("EXRP17", "EXRP17", JdeDataType.String, 6),
        new JdeField("EXRP18", "EXRP18", JdeDataType.String, 6),
        new JdeField("EXRP19", "EXRP19", JdeDataType.String, 6),
        new JdeField("EXRP20", "EXRP20", JdeDataType.String, 6),
        new JdeField("EXRP21", "EXRP21", JdeDataType.String, 20),
        new JdeField("EXRP22", "EXRP22", JdeDataType.String, 20),
        new JdeField("EXRP23", "EXRP23", JdeDataType.String, 20),
        new JdeField("EXRP24", "EXRP24", JdeDataType.String, 20),
        new JdeField("EXRP25", "EXRP25", JdeDataType.String, 20),
        new JdeField("EXRP26", "EXRP26", JdeDataType.String, 20),
        new JdeField("EXRP27", "EXRP27", JdeDataType.String, 20),
        new JdeField("EXRP28", "EXRP28", JdeDataType.String, 20),
        new JdeField("EXRP29", "EXRP29", JdeDataType.String, 20),
        new JdeField("EXRP30", "EXRP30", JdeDataType.String, 20),
        new JdeField("EXRP31", "EXRP31", JdeDataType.String, 20),
        new JdeField("EXRP32", "EXRP32", JdeDataType.String, 20),
        new JdeField("EXRP33", "EXRP33", JdeDataType.String, 20),
        new JdeField("EXRP34", "EXRP34", JdeDataType.String, 20),
        new JdeField("EXRP35", "EXRP35", JdeDataType.String, 20),
        new JdeField("EXRP36", "EXRP36", JdeDataType.String, 20),
        new JdeField("EXRP37", "EXRP37", JdeDataType.String, 20),
        new JdeField("EXRP38", "EXRP38", JdeDataType.String, 20),
        new JdeField("EXRP39", "EXRP39", JdeDataType.String, 20),
        new JdeField("EXRP40", "EXRP40", JdeDataType.String, 20),
        new JdeField("EXRP41", "EXRP41", JdeDataType.String, 20),
        new JdeField("EXRP42", "EXRP42", JdeDataType.String, 20),
        new JdeField("EXRP43", "EXRP43", JdeDataType.String, 20),
        new JdeField("EXRP44", "EXRP44", JdeDataType.String, 20),
        new JdeField("EXRP45", "EXRP45", JdeDataType.String, 20),
        new JdeField("EXRP46", "EXRP46", JdeDataType.String, 20),
        new JdeField("EXRP47", "EXRP47", JdeDataType.String, 20),
        new JdeField("EXRP48", "EXRP48", JdeDataType.String, 20),
        new JdeField("EXRP49", "EXRP49", JdeDataType.String, 20),
        new JdeField("EXRP50", "EXRP50", JdeDataType.String, 20),
        new JdeField("EX51XACD", "EX51XACD", JdeDataType.String, 60),
        new JdeField("EXLDA", "EXLDA", JdeDataType.String, 2),
        new JdeField("EXPEC", "EXPEC", JdeDataType.String, 2),
        new JdeField("EXUM", "EXUM", JdeDataType.String, 4),
        new JdeField("EXSUBA", "EXSUBA", JdeDataType.String, 16),
        new JdeField("EXR001", "EXR001", JdeDataType.String, 6),
        new JdeField("EXR002", "EXR002", JdeDataType.String, 6),
        new JdeField("EXR003", "EXR003", JdeDataType.String, 6),
        new JdeField("EXR004", "EXR004", JdeDataType.String, 6),
        new JdeField("EXR005", "EXR005", JdeDataType.String, 6),
        new JdeField("EXR006", "EXR006", JdeDataType.String, 6),
        new JdeField("EXR007", "EXR007", JdeDataType.String, 6),
        new JdeField("EXR008", "EXR008", JdeDataType.String, 6),
        new JdeField("EXR009", "EXR009", JdeDataType.String, 6),
        new JdeField("EXR010", "EXR010", JdeDataType.String, 6),
        new JdeField("EXR011", "EXR011", JdeDataType.String, 6),
        new JdeField("EXR012", "EXR012", JdeDataType.String, 6),
        new JdeField("EXR013", "EXR013", JdeDataType.String, 6),
        new JdeField("EXR014", "EXR014", JdeDataType.String, 6),
        new JdeField("EXR015", "EXR015", JdeDataType.String, 6),
        new JdeField("EXR016", "EXR016", JdeDataType.String, 6),
        new JdeField("EXR017", "EXR017", JdeDataType.String, 6),
        new JdeField("EXR018", "EXR018", JdeDataType.String, 6),
        new JdeField("EXR019", "EXR019", JdeDataType.String, 6),
        new JdeField("EXR020", "EXR020", JdeDataType.String, 6),
        new JdeField("EXR021", "EXR021", JdeDataType.String, 20),
        new JdeField("EXR022", "EXR022", JdeDataType.String, 20),
        new JdeField("EXR023", "EXR023", JdeDataType.String, 20),
        new JdeField("EXR024", "EXR024", JdeDataType.String, 20),
        new JdeField("EXR025", "EXR025", JdeDataType.String, 20),
        new JdeField("EXR026", "EXR026", JdeDataType.String, 20),
        new JdeField("EXR027", "EXR027", JdeDataType.String, 20),
        new JdeField("EXR028", "EXR028", JdeDataType.String, 20),
        new JdeField("EXR029", "EXR029", JdeDataType.String, 20),
        new JdeField("EXR030", "EXR030", JdeDataType.String, 20),
        new JdeField("EXR031", "EXR031", JdeDataType.String, 20),
        new JdeField("EXR032", "EXR032", JdeDataType.String, 20),
        new JdeField("EXR033", "EXR033", JdeDataType.String, 20),
        new JdeField("EXR034", "EXR034", JdeDataType.String, 20),
        new JdeField("EXR035", "EXR035", JdeDataType.String, 20),
        new JdeField("EXR036", "EXR036", JdeDataType.String, 20),
        new JdeField("EXR037", "EXR037", JdeDataType.String, 20),
        new JdeField("EXR038", "EXR038", JdeDataType.String, 20),
        new JdeField("EXR039", "EXR039", JdeDataType.String, 20),
        new JdeField("EXR040", "EXR040", JdeDataType.String, 20),
        new JdeField("EXR041", "EXR041", JdeDataType.String, 20),
        new JdeField("EXR042", "EXR042", JdeDataType.String, 20),
        new JdeField("EXR043", "EXR043", JdeDataType.String, 20),
        new JdeField("EXCCT", "EXCCT", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51X10_0", "Primary Key on EXUSER, EXJOBS, EX51XRTY, EX51XTC, EXMCU, EX51XCT1, EX51XCT2", new[] { "EXUSER", "EXJOBS", "EX51XRTY", "EX51XTC", "EXMCU", "EX51XCT1", "EX51XCT2" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F51X10_2", "Index on EXUSER, EXJOBS, EX51XRTY, EXMCU", new[] { "EXUSER", "EXJOBS", "EX51XRTY", "EXMCU" }),
        new JdeIndex("F51X10_3", "Index on EXUSER, EXJOBS, EXMCU", new[] { "EXUSER", "EXJOBS", "EXMCU" })
    };
}
