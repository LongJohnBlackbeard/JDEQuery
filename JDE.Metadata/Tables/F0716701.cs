using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0716701 - .
/// </summary>
public class F0716701 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EATSKID.
        /// </summary>
        public const string EATSKID = "EATSKID";

        /// <summary>
        /// EAPDBA.
        /// </summary>
        public const string EAPDBA = "EAPDBA";

        /// <summary>
        /// EAANI.
        /// </summary>
        public const string EAANI = "EAANI";

        /// <summary>
        /// EAJBCD.
        /// </summary>
        public const string EAJBCD = "EAJBCD";

        /// <summary>
        /// EAJBST.
        /// </summary>
        public const string EAJBST = "EAJBST";

        /// <summary>
        /// EAACTB.
        /// </summary>
        public const string EAACTB = "EAACTB";

        /// <summary>
        /// EAABT1.
        /// </summary>
        public const string EAABT1 = "EAABT1";

        /// <summary>
        /// EAABR1.
        /// </summary>
        public const string EAABR1 = "EAABR1";

        /// <summary>
        /// EAABT2.
        /// </summary>
        public const string EAABT2 = "EAABT2";

        /// <summary>
        /// EAABR2.
        /// </summary>
        public const string EAABR2 = "EAABR2";

        /// <summary>
        /// EAABT3.
        /// </summary>
        public const string EAABT3 = "EAABT3";

        /// <summary>
        /// EAABR3.
        /// </summary>
        public const string EAABR3 = "EAABR3";

        /// <summary>
        /// EAABT4.
        /// </summary>
        public const string EAABT4 = "EAABT4";

        /// <summary>
        /// EAABR4.
        /// </summary>
        public const string EAABR4 = "EAABR4";

        /// <summary>
        /// EAUITM.
        /// </summary>
        public const string EAUITM = "EAUITM";

        /// <summary>
        /// EASBL.
        /// </summary>
        public const string EASBL = "EASBL";

        /// <summary>
        /// EASBLT.
        /// </summary>
        public const string EASBLT = "EASBLT";

        /// <summary>
        /// EAOPSQ.
        /// </summary>
        public const string EAOPSQ = "EAOPSQ";

        /// <summary>
        /// EAASII.
        /// </summary>
        public const string EAASII = "EAASII";

        /// <summary>
        /// EAUN.
        /// </summary>
        public const string EAUN = "EAUN";

        /// <summary>
        /// EAPOS.
        /// </summary>
        public const string EAPOS = "EAPOS";

        /// <summary>
        /// EAUAMT.
        /// </summary>
        public const string EAUAMT = "EAUAMT";

        /// <summary>
        /// EASHFT.
        /// </summary>
        public const string EASHFT = "EASHFT";

        /// <summary>
        /// EASHD.
        /// </summary>
        public const string EASHD = "EASHD";

        /// <summary>
        /// EALD.
        /// </summary>
        public const string EALD = "EALD";

        /// <summary>
        /// EAHMCO.
        /// </summary>
        public const string EAHMCO = "EAHMCO";

        /// <summary>
        /// EAHMCU.
        /// </summary>
        public const string EAHMCU = "EAHMCU";

        /// <summary>
        /// EAMCUO.
        /// </summary>
        public const string EAMCUO = "EAMCUO";

        /// <summary>
        /// EATARA.
        /// </summary>
        public const string EATARA = "EATARA";

        /// <summary>
        /// EAITM.
        /// </summary>
        public const string EAITM = "EAITM";

        /// <summary>
        /// EAWR01.
        /// </summary>
        public const string EAWR01 = "EAWR01";

        /// <summary>
        /// EARCCD.
        /// </summary>
        public const string EARCCD = "EARCCD";

        /// <summary>
        /// EAANN8.
        /// </summary>
        public const string EAANN8 = "EAANN8";

        /// <summary>
        /// EAWCMP.
        /// </summary>
        public const string EAWCMP = "EAWCMP";

        /// <summary>
        /// EAWET.
        /// </summary>
        public const string EAWET = "EAWET";

        /// <summary>
        /// EAMAIL.
        /// </summary>
        public const string EAMAIL = "EAMAIL";

        /// <summary>
        /// EAP001.
        /// </summary>
        public const string EAP001 = "EAP001";

        /// <summary>
        /// EAP002.
        /// </summary>
        public const string EAP002 = "EAP002";

        /// <summary>
        /// EAP003.
        /// </summary>
        public const string EAP003 = "EAP003";

        /// <summary>
        /// EAP004.
        /// </summary>
        public const string EAP004 = "EAP004";

        /// <summary>
        /// EAEAASNUMB.
        /// </summary>
        public const string EAEAASNUMB = "EAEAASNUMB";

        /// <summary>
        /// EAERC.
        /// </summary>
        public const string EAERC = "EAERC";

        /// <summary>
        /// EAQOBJ.
        /// </summary>
        public const string EAQOBJ = "EAQOBJ";

        /// <summary>
        /// EAEQRT.
        /// </summary>
        public const string EAEQRT = "EAEQRT";

        /// <summary>
        /// EADOCO.
        /// </summary>
        public const string EADOCO = "EADOCO";

        /// <summary>
        /// EADCTO.
        /// </summary>
        public const string EADCTO = "EADCTO";

        /// <summary>
        /// EATYR.
        /// </summary>
        public const string EATYR = "EATYR";

        /// <summary>
        /// EAUOM.
        /// </summary>
        public const string EAUOM = "EAUOM";

        /// <summary>
        /// EAOPST.
        /// </summary>
        public const string EAOPST = "EAOPST";

        /// <summary>
        /// EAREAC.
        /// </summary>
        public const string EAREAC = "EAREAC";

        /// <summary>
        /// EAKITL.
        /// </summary>
        public const string EAKITL = "EAKITL";

        /// <summary>
        /// EAKITA.
        /// </summary>
        public const string EAKITA = "EAKITA";

        /// <summary>
        /// EADTEREQF.
        /// </summary>
        public const string EADTEREQF = "EADTEREQF";

        /// <summary>
        /// EAEAPAYBS.
        /// </summary>
        public const string EAEAPAYBS = "EAEAPAYBS";

        /// <summary>
        /// EAEAINFLG.
        /// </summary>
        public const string EAEAINFLG = "EAEAINFLG";

        /// <summary>
        /// EAEACTCD01.
        /// </summary>
        public const string EAEACTCD01 = "EAEACTCD01";

        /// <summary>
        /// EAEACTCD02.
        /// </summary>
        public const string EAEACTCD02 = "EAEACTCD02";

        /// <summary>
        /// EAEACTCD03.
        /// </summary>
        public const string EAEACTCD03 = "EAEACTCD03";

        /// <summary>
        /// EAEACTCD04.
        /// </summary>
        public const string EAEACTCD04 = "EAEACTCD04";

        /// <summary>
        /// EAEACTCD05.
        /// </summary>
        public const string EAEACTCD05 = "EAEACTCD05";

        /// <summary>
        /// EAEACTCD06.
        /// </summary>
        public const string EAEACTCD06 = "EAEACTCD06";

        /// <summary>
        /// EAEACTCD07.
        /// </summary>
        public const string EAEACTCD07 = "EAEACTCD07";

        /// <summary>
        /// EAEACTCD08.
        /// </summary>
        public const string EAEACTCD08 = "EAEACTCD08";

        /// <summary>
        /// EAEACTCD09.
        /// </summary>
        public const string EAEACTCD09 = "EAEACTCD09";

        /// <summary>
        /// EAEACTCD10.
        /// </summary>
        public const string EAEACTCD10 = "EAEACTCD10";

        /// <summary>
        /// EAEAURCH1.
        /// </summary>
        public const string EAEAURCH1 = "EAEAURCH1";

        /// <summary>
        /// EAEAURCH2.
        /// </summary>
        public const string EAEAURCH2 = "EAEAURCH2";

        /// <summary>
        /// EAEAURST1.
        /// </summary>
        public const string EAEAURST1 = "EAEAURST1";

        /// <summary>
        /// EAEAURST2.
        /// </summary>
        public const string EAEAURST2 = "EAEAURST2";

        /// <summary>
        /// EAEAURST3.
        /// </summary>
        public const string EAEAURST3 = "EAEAURST3";

        /// <summary>
        /// EAEAURST4.
        /// </summary>
        public const string EAEAURST4 = "EAEAURST4";

        /// <summary>
        /// EAEAURST5.
        /// </summary>
        public const string EAEAURST5 = "EAEAURST5";

        /// <summary>
        /// EAEAURST6.
        /// </summary>
        public const string EAEAURST6 = "EAEAURST6";

        /// <summary>
        /// EAEAURST7.
        /// </summary>
        public const string EAEAURST7 = "EAEAURST7";

        /// <summary>
        /// EAEAURMN1.
        /// </summary>
        public const string EAEAURMN1 = "EAEAURMN1";

        /// <summary>
        /// EAEAURMN2.
        /// </summary>
        public const string EAEAURMN2 = "EAEAURMN2";

        /// <summary>
        /// EAEAURCU1.
        /// </summary>
        public const string EAEAURCU1 = "EAEAURCU1";

        /// <summary>
        /// EAEAURCU2.
        /// </summary>
        public const string EAEAURCU2 = "EAEAURCU2";

        /// <summary>
        /// EAEAURDT1.
        /// </summary>
        public const string EAEAURDT1 = "EAEAURDT1";

        /// <summary>
        /// EAEAURDT2.
        /// </summary>
        public const string EAEAURDT2 = "EAEAURDT2";

        /// <summary>
        /// EAEXR1.
        /// </summary>
        public const string EAEXR1 = "EAEXR1";

        /// <summary>
        /// EATXA1.
        /// </summary>
        public const string EATXA1 = "EATXA1";

        /// <summary>
        /// EAVGCSF.
        /// </summary>
        public const string EAVGCSF = "EAVGCSF";

        /// <summary>
        /// EAVGCOA.
        /// </summary>
        public const string EAVGCOA = "EAVGCOA";

        /// <summary>
        /// EAVVTY.
        /// </summary>
        public const string EAVVTY = "EAVVTY";

        /// <summary>
        /// EAVVTC.
        /// </summary>
        public const string EAVVTC = "EAVVTC";

        /// <summary>
        /// EACRCD.
        /// </summary>
        public const string EACRCD = "EACRCD";

        /// <summary>
        /// EACRDC.
        /// </summary>
        public const string EACRDC = "EACRDC";

        /// <summary>
        /// EARCHGMODE.
        /// </summary>
        public const string EARCHGMODE = "EARCHGMODE";

        /// <summary>
        /// EARCHGCODE.
        /// </summary>
        public const string EARCHGCODE = "EARCHGCODE";

        /// <summary>
        /// EACUSTAN8.
        /// </summary>
        public const string EACUSTAN8 = "EACUSTAN8";

        /// <summary>
        /// EAOTRULECD.
        /// </summary>
        public const string EAOTRULECD = "EAOTRULECD";

        /// <summary>
        /// EAPID.
        /// </summary>
        public const string EAPID = "EAPID";

        /// <summary>
        /// EAUSER.
        /// </summary>
        public const string EAUSER = "EAUSER";

        /// <summary>
        /// EAJOBN.
        /// </summary>
        public const string EAJOBN = "EAJOBN";

        /// <summary>
        /// EAUPMJ.
        /// </summary>
        public const string EAUPMJ = "EAUPMJ";

        /// <summary>
        /// EAUPMT.
        /// </summary>
        public const string EAUPMT = "EAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0716701";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EATSKID", "EATSKID", JdeDataType.Numeric, null, true, true),
        new JdeField("EAPDBA", "EAPDBA", JdeDataType.Numeric),
        new JdeField("EAANI", "EAANI", JdeDataType.String, 58),
        new JdeField("EAJBCD", "EAJBCD", JdeDataType.String, 12),
        new JdeField("EAJBST", "EAJBST", JdeDataType.String, 8),
        new JdeField("EAACTB", "EAACTB", JdeDataType.String, 20),
        new JdeField("EAABT1", "EAABT1", JdeDataType.String, 2),
        new JdeField("EAABR1", "EAABR1", JdeDataType.String, 24),
        new JdeField("EAABT2", "EAABT2", JdeDataType.String, 2),
        new JdeField("EAABR2", "EAABR2", JdeDataType.String, 24),
        new JdeField("EAABT3", "EAABT3", JdeDataType.String, 2),
        new JdeField("EAABR3", "EAABR3", JdeDataType.String, 24),
        new JdeField("EAABT4", "EAABT4", JdeDataType.String, 2),
        new JdeField("EAABR4", "EAABR4", JdeDataType.String, 24),
        new JdeField("EAUITM", "EAUITM", JdeDataType.String, 52),
        new JdeField("EASBL", "EASBL", JdeDataType.String, 16),
        new JdeField("EASBLT", "EASBLT", JdeDataType.String, 2),
        new JdeField("EAOPSQ", "EAOPSQ", JdeDataType.Numeric),
        new JdeField("EAASII", "EAASII", JdeDataType.String, 52),
        new JdeField("EAUN", "EAUN", JdeDataType.String, 12),
        new JdeField("EAPOS", "EAPOS", JdeDataType.String, 16),
        new JdeField("EAUAMT", "EAUAMT", JdeDataType.Numeric),
        new JdeField("EASHFT", "EASHFT", JdeDataType.String, 2),
        new JdeField("EASHD", "EASHD", JdeDataType.Numeric),
        new JdeField("EALD", "EALD", JdeDataType.String, 2),
        new JdeField("EAHMCO", "EAHMCO", JdeDataType.String, 10),
        new JdeField("EAHMCU", "EAHMCU", JdeDataType.String, 24),
        new JdeField("EAMCUO", "EAMCUO", JdeDataType.String, 24),
        new JdeField("EATARA", "EATARA", JdeDataType.String, 20),
        new JdeField("EAITM", "EAITM", JdeDataType.Numeric),
        new JdeField("EAWR01", "EAWR01", JdeDataType.String, 8),
        new JdeField("EARCCD", "EARCCD", JdeDataType.String, 2),
        new JdeField("EAANN8", "EAANN8", JdeDataType.Numeric),
        new JdeField("EAWCMP", "EAWCMP", JdeDataType.String, 8),
        new JdeField("EAWET", "EAWET", JdeDataType.String, 2),
        new JdeField("EAMAIL", "EAMAIL", JdeDataType.String, 20),
        new JdeField("EAP001", "EAP001", JdeDataType.String, 6),
        new JdeField("EAP002", "EAP002", JdeDataType.String, 6),
        new JdeField("EAP003", "EAP003", JdeDataType.String, 6),
        new JdeField("EAP004", "EAP004", JdeDataType.String, 6),
        new JdeField("EAEAASNUMB", "EAEAASNUMB", JdeDataType.String, 52),
        new JdeField("EAERC", "EAERC", JdeDataType.String, 4),
        new JdeField("EAQOBJ", "EAQOBJ", JdeDataType.String, 12),
        new JdeField("EAEQRT", "EAEQRT", JdeDataType.Numeric),
        new JdeField("EADOCO", "EADOCO", JdeDataType.Numeric),
        new JdeField("EADCTO", "EADCTO", JdeDataType.String, 4),
        new JdeField("EATYR", "EATYR", JdeDataType.String, 2),
        new JdeField("EAUOM", "EAUOM", JdeDataType.String, 4),
        new JdeField("EAOPST", "EAOPST", JdeDataType.String, 4),
        new JdeField("EAREAC", "EAREAC", JdeDataType.String, 4),
        new JdeField("EAKITL", "EAKITL", JdeDataType.String, 50),
        new JdeField("EAKITA", "EAKITA", JdeDataType.String, 50),
        new JdeField("EADTEREQF", "EADTEREQF", JdeDataType.String, 2),
        new JdeField("EAEAPAYBS", "EAEAPAYBS", JdeDataType.String, 6),
        new JdeField("EAEAINFLG", "EAEAINFLG", JdeDataType.String, 2),
        new JdeField("EAEACTCD01", "EAEACTCD01", JdeDataType.String, 8),
        new JdeField("EAEACTCD02", "EAEACTCD02", JdeDataType.String, 8),
        new JdeField("EAEACTCD03", "EAEACTCD03", JdeDataType.String, 12),
        new JdeField("EAEACTCD04", "EAEACTCD04", JdeDataType.String, 12),
        new JdeField("EAEACTCD05", "EAEACTCD05", JdeDataType.String, 12),
        new JdeField("EAEACTCD06", "EAEACTCD06", JdeDataType.String, 12),
        new JdeField("EAEACTCD07", "EAEACTCD07", JdeDataType.String, 16),
        new JdeField("EAEACTCD08", "EAEACTCD08", JdeDataType.String, 16),
        new JdeField("EAEACTCD09", "EAEACTCD09", JdeDataType.String, 20),
        new JdeField("EAEACTCD10", "EAEACTCD10", JdeDataType.String, 20),
        new JdeField("EAEAURCH1", "EAEAURCH1", JdeDataType.String, 2),
        new JdeField("EAEAURCH2", "EAEAURCH2", JdeDataType.String, 2),
        new JdeField("EAEAURST1", "EAEAURST1", JdeDataType.String, 10),
        new JdeField("EAEAURST2", "EAEAURST2", JdeDataType.String, 10),
        new JdeField("EAEAURST3", "EAEAURST3", JdeDataType.String, 30),
        new JdeField("EAEAURST4", "EAEAURST4", JdeDataType.String, 30),
        new JdeField("EAEAURST5", "EAEAURST5", JdeDataType.String, 30),
        new JdeField("EAEAURST6", "EAEAURST6", JdeDataType.String, 30),
        new JdeField("EAEAURST7", "EAEAURST7", JdeDataType.String, 60),
        new JdeField("EAEAURMN1", "EAEAURMN1", JdeDataType.Numeric),
        new JdeField("EAEAURMN2", "EAEAURMN2", JdeDataType.Numeric),
        new JdeField("EAEAURCU1", "EAEAURCU1", JdeDataType.Numeric),
        new JdeField("EAEAURCU2", "EAEAURCU2", JdeDataType.Numeric),
        new JdeField("EAEAURDT1", "EAEAURDT1", JdeDataType.Numeric),
        new JdeField("EAEAURDT2", "EAEAURDT2", JdeDataType.Numeric),
        new JdeField("EAEXR1", "EAEXR1", JdeDataType.String, 4),
        new JdeField("EATXA1", "EATXA1", JdeDataType.String, 20),
        new JdeField("EAVGCSF", "EAVGCSF", JdeDataType.String, 20),
        new JdeField("EAVGCOA", "EAVGCOA", JdeDataType.String, 20),
        new JdeField("EAVVTY", "EAVVTY", JdeDataType.String, 12),
        new JdeField("EAVVTC", "EAVVTC", JdeDataType.String, 20),
        new JdeField("EACRCD", "EACRCD", JdeDataType.String, 6),
        new JdeField("EACRDC", "EACRDC", JdeDataType.String, 6),
        new JdeField("EARCHGMODE", "EARCHGMODE", JdeDataType.String, 2),
        new JdeField("EARCHGCODE", "EARCHGCODE", JdeDataType.String, 2),
        new JdeField("EACUSTAN8", "EACUSTAN8", JdeDataType.Numeric),
        new JdeField("EAOTRULECD", "EAOTRULECD", JdeDataType.String, 6),
        new JdeField("EAPID", "EAPID", JdeDataType.String, 20),
        new JdeField("EAUSER", "EAUSER", JdeDataType.String, 20),
        new JdeField("EAJOBN", "EAJOBN", JdeDataType.String, 20),
        new JdeField("EAUPMJ", "EAUPMJ", JdeDataType.Numeric),
        new JdeField("EAUPMT", "EAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0716701_0", "Primary Key on EATSKID", new[] { "EATSKID" }, isUnique: true, isPrimaryKey: true)
    };
}
