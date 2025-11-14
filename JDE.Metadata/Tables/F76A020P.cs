using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A020P - .
/// </summary>
public class F76A020P : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HFJOBS.
        /// </summary>
        public const string HFJOBS = "HFJOBS";

        /// <summary>
        /// HFCTID.
        /// </summary>
        public const string HFCTID = "HFCTID";

        /// <summary>
        /// HFDOC.
        /// </summary>
        public const string HFDOC = "HFDOC";

        /// <summary>
        /// HFDCT.
        /// </summary>
        public const string HFDCT = "HFDCT";

        /// <summary>
        /// HFKCO.
        /// </summary>
        public const string HFKCO = "HFKCO";

        /// <summary>
        /// HFARYO.
        /// </summary>
        public const string HFARYO = "HFARYO";

        /// <summary>
        /// HFINTY.
        /// </summary>
        public const string HFINTY = "HFINTY";

        /// <summary>
        /// HFEV01.
        /// </summary>
        public const string HFEV01 = "HFEV01";

        /// <summary>
        /// HFINVC.
        /// </summary>
        public const string HFINVC = "HFINVC";

        /// <summary>
        /// HFEV02.
        /// </summary>
        public const string HFEV02 = "HFEV02";

        /// <summary>
        /// HFACEM.
        /// </summary>
        public const string HFACEM = "HFACEM";

        /// <summary>
        /// HFAINW.
        /// </summary>
        public const string HFAINW = "HFAINW";

        /// <summary>
        /// HFAGRP.
        /// </summary>
        public const string HFAGRP = "HFAGRP";

        /// <summary>
        /// HFDL01.
        /// </summary>
        public const string HFDL01 = "HFDL01";

        /// <summary>
        /// HFDIVJ.
        /// </summary>
        public const string HFDIVJ = "HFDIVJ";

        /// <summary>
        /// HFEFDJ.
        /// </summary>
        public const string HFEFDJ = "HFEFDJ";

        /// <summary>
        /// HFADD1.
        /// </summary>
        public const string HFADD1 = "HFADD1";

        /// <summary>
        /// HFADD2.
        /// </summary>
        public const string HFADD2 = "HFADD2";

        /// <summary>
        /// HFADD3.
        /// </summary>
        public const string HFADD3 = "HFADD3";

        /// <summary>
        /// HFADD4.
        /// </summary>
        public const string HFADD4 = "HFADD4";

        /// <summary>
        /// HFTAX.
        /// </summary>
        public const string HFTAX = "HFTAX";

        /// <summary>
        /// HFTX1.
        /// </summary>
        public const string HFTX1 = "HFTX1";

        /// <summary>
        /// HFAN8.
        /// </summary>
        public const string HFAN8 = "HFAN8";

        /// <summary>
        /// HFADD5.
        /// </summary>
        public const string HFADD5 = "HFADD5";

        /// <summary>
        /// HFADD6.
        /// </summary>
        public const string HFADD6 = "HFADD6";

        /// <summary>
        /// HFADD7.
        /// </summary>
        public const string HFADD7 = "HFADD7";

        /// <summary>
        /// HFADD8.
        /// </summary>
        public const string HFADD8 = "HFADD8";

        /// <summary>
        /// HFTAXX.
        /// </summary>
        public const string HFTAXX = "HFTAXX";

        /// <summary>
        /// HFTX2.
        /// </summary>
        public const string HFTX2 = "HFTX2";

        /// <summary>
        /// HFSHAN.
        /// </summary>
        public const string HFSHAN = "HFSHAN";

        /// <summary>
        /// HFAD1I.
        /// </summary>
        public const string HFAD1I = "HFAD1I";

        /// <summary>
        /// HFAD2I.
        /// </summary>
        public const string HFAD2I = "HFAD2I";

        /// <summary>
        /// HFAD3I.
        /// </summary>
        public const string HFAD3I = "HFAD3I";

        /// <summary>
        /// HFAD4I.
        /// </summary>
        public const string HFAD4I = "HFAD4I";

        /// <summary>
        /// HFPTD.
        /// </summary>
        public const string HFPTD = "HFPTD";

        /// <summary>
        /// HFDEL1.
        /// </summary>
        public const string HFDEL1 = "HFDEL1";

        /// <summary>
        /// HFDEL2.
        /// </summary>
        public const string HFDEL2 = "HFDEL2";

        /// <summary>
        /// HFDOCO.
        /// </summary>
        public const string HFDOCO = "HFDOCO";

        /// <summary>
        /// HFDCTO.
        /// </summary>
        public const string HFDCTO = "HFDCTO";

        /// <summary>
        /// HFKCOO.
        /// </summary>
        public const string HFKCOO = "HFKCOO";

        /// <summary>
        /// HFODOC.
        /// </summary>
        public const string HFODOC = "HFODOC";

        /// <summary>
        /// HFODCT.
        /// </summary>
        public const string HFODCT = "HFODCT";

        /// <summary>
        /// HFTAXA.
        /// </summary>
        public const string HFTAXA = "HFTAXA";

        /// <summary>
        /// HFDL0.
        /// </summary>
        public const string HFDL0 = "HFDL0";

        /// <summary>
        /// HFDL03.
        /// </summary>
        public const string HFDL03 = "HFDL03";

        /// <summary>
        /// HFSTA1.
        /// </summary>
        public const string HFSTA1 = "HFSTA1";

        /// <summary>
        /// HFSTA2.
        /// </summary>
        public const string HFSTA2 = "HFSTA2";

        /// <summary>
        /// HFSTA3.
        /// </summary>
        public const string HFSTA3 = "HFSTA3";

        /// <summary>
        /// HFSTA4.
        /// </summary>
        public const string HFSTA4 = "HFSTA4";

        /// <summary>
        /// HFAG.
        /// </summary>
        public const string HFAG = "HFAG";

        /// <summary>
        /// HFDL02.
        /// </summary>
        public const string HFDL02 = "HFDL02";

        /// <summary>
        /// HFCRR.
        /// </summary>
        public const string HFCRR = "HFCRR";

        /// <summary>
        /// HFADSA.
        /// </summary>
        public const string HFADSA = "HFADSA";

        /// <summary>
        /// HFITWT.
        /// </summary>
        public const string HFITWT = "HFITWT";

        /// <summary>
        /// HFWTUM.
        /// </summary>
        public const string HFWTUM = "HFWTUM";

        /// <summary>
        /// HFITVL.
        /// </summary>
        public const string HFITVL = "HFITVL";

        /// <summary>
        /// HFVLUM.
        /// </summary>
        public const string HFVLUM = "HFVLUM";

        /// <summary>
        /// HFADD0.
        /// </summary>
        public const string HFADD0 = "HFADD0";

        /// <summary>
        /// HFTAXS.
        /// </summary>
        public const string HFTAXS = "HFTAXS";

        /// <summary>
        /// HFAPIT.
        /// </summary>
        public const string HFAPIT = "HFAPIT";

        /// <summary>
        /// HFACAI.
        /// </summary>
        public const string HFACAI = "HFACAI";

        /// <summary>
        /// HFCXPJ.
        /// </summary>
        public const string HFCXPJ = "HFCXPJ";

        /// <summary>
        /// HFRLNO.
        /// </summary>
        public const string HFRLNO = "HFRLNO";

        /// <summary>
        /// HFLDNM.
        /// </summary>
        public const string HFLDNM = "HFLDNM";

        /// <summary>
        /// HFSTUM.
        /// </summary>
        public const string HFSTUM = "HFSTUM";

        /// <summary>
        /// HFBUM6.
        /// </summary>
        public const string HFBUM6 = "HFBUM6";

        /// <summary>
        /// HFPNMG.
        /// </summary>
        public const string HFPNMG = "HFPNMG";

        /// <summary>
        /// HFINMG.
        /// </summary>
        public const string HFINMG = "HFINMG";

        /// <summary>
        /// HFEV03.
        /// </summary>
        public const string HFEV03 = "HFEV03";

        /// <summary>
        /// HFEV04.
        /// </summary>
        public const string HFEV04 = "HFEV04";

        /// <summary>
        /// HFEV05.
        /// </summary>
        public const string HFEV05 = "HFEV05";

        /// <summary>
        /// HFEV06.
        /// </summary>
        public const string HFEV06 = "HFEV06";

        /// <summary>
        /// HFEV07.
        /// </summary>
        public const string HFEV07 = "HFEV07";

        /// <summary>
        /// HFORIG.
        /// </summary>
        public const string HFORIG = "HFORIG";

        /// <summary>
        /// HFICON.
        /// </summary>
        public const string HFICON = "HFICON";

        /// <summary>
        /// HFFLGA.
        /// </summary>
        public const string HFFLGA = "HFFLGA";

        /// <summary>
        /// HFEFT.
        /// </summary>
        public const string HFEFT = "HFEFT";

        /// <summary>
        /// HFURAB.
        /// </summary>
        public const string HFURAB = "HFURAB";

        /// <summary>
        /// HFURAT.
        /// </summary>
        public const string HFURAT = "HFURAT";

        /// <summary>
        /// HFURC1.
        /// </summary>
        public const string HFURC1 = "HFURC1";

        /// <summary>
        /// HFURC2.
        /// </summary>
        public const string HFURC2 = "HFURC2";

        /// <summary>
        /// HFURCD.
        /// </summary>
        public const string HFURCD = "HFURCD";

        /// <summary>
        /// HFURDD.
        /// </summary>
        public const string HFURDD = "HFURDD";

        /// <summary>
        /// HFURDT.
        /// </summary>
        public const string HFURDT = "HFURDT";

        /// <summary>
        /// HFURNUM01.
        /// </summary>
        public const string HFURNUM01 = "HFURNUM01";

        /// <summary>
        /// HFURNUM02.
        /// </summary>
        public const string HFURNUM02 = "HFURNUM02";

        /// <summary>
        /// HFURNUM03.
        /// </summary>
        public const string HFURNUM03 = "HFURNUM03";

        /// <summary>
        /// HFURRF.
        /// </summary>
        public const string HFURRF = "HFURRF";

        /// <summary>
        /// HFADD10.
        /// </summary>
        public const string HFADD10 = "HFADD10";

        /// <summary>
        /// HFADD11.
        /// </summary>
        public const string HFADD11 = "HFADD11";

        /// <summary>
        /// HFADD12.
        /// </summary>
        public const string HFADD12 = "HFADD12";

        /// <summary>
        /// HFADD13.
        /// </summary>
        public const string HFADD13 = "HFADD13";

        /// <summary>
        /// HFCTY1.
        /// </summary>
        public const string HFCTY1 = "HFCTY1";

        /// <summary>
        /// HFADDZ.
        /// </summary>
        public const string HFADDZ = "HFADDZ";

        /// <summary>
        /// HFACEM1.
        /// </summary>
        public const string HFACEM1 = "HFACEM1";
    }

    /// <inheritdoc />
    public override string TableName => "F76A020P";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HFJOBS", "HFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("HFCTID", "HFCTID", JdeDataType.String, 30, true, true),
        new JdeField("HFDOC", "HFDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("HFDCT", "HFDCT", JdeDataType.String, 4, true, true),
        new JdeField("HFKCO", "HFKCO", JdeDataType.String, 10, true, true),
        new JdeField("HFARYO", "HFARYO", JdeDataType.String, 2),
        new JdeField("HFINTY", "HFINTY", JdeDataType.String, 2),
        new JdeField("HFEV01", "HFEV01", JdeDataType.String, 2),
        new JdeField("HFINVC", "HFINVC", JdeDataType.Numeric),
        new JdeField("HFEV02", "HFEV02", JdeDataType.String, 2),
        new JdeField("HFACEM", "HFACEM", JdeDataType.String, 8),
        new JdeField("HFAINW", "HFAINW", JdeDataType.String, 16),
        new JdeField("HFAGRP", "HFAGRP", JdeDataType.String, 2),
        new JdeField("HFDL01", "HFDL01", JdeDataType.String, 60),
        new JdeField("HFDIVJ", "HFDIVJ", JdeDataType.Numeric),
        new JdeField("HFEFDJ", "HFEFDJ", JdeDataType.Numeric),
        new JdeField("HFADD1", "HFADD1", JdeDataType.String, 80),
        new JdeField("HFADD2", "HFADD2", JdeDataType.String, 80),
        new JdeField("HFADD3", "HFADD3", JdeDataType.String, 80),
        new JdeField("HFADD4", "HFADD4", JdeDataType.String, 80),
        new JdeField("HFTAX", "HFTAX", JdeDataType.String, 40),
        new JdeField("HFTX1", "HFTX1", JdeDataType.String, 32),
        new JdeField("HFAN8", "HFAN8", JdeDataType.Numeric),
        new JdeField("HFADD5", "HFADD5", JdeDataType.String, 80),
        new JdeField("HFADD6", "HFADD6", JdeDataType.String, 80),
        new JdeField("HFADD7", "HFADD7", JdeDataType.String, 80),
        new JdeField("HFADD8", "HFADD8", JdeDataType.String, 80),
        new JdeField("HFTAXX", "HFTAXX", JdeDataType.String, 40),
        new JdeField("HFTX2", "HFTX2", JdeDataType.String, 40),
        new JdeField("HFSHAN", "HFSHAN", JdeDataType.Numeric),
        new JdeField("HFAD1I", "HFAD1I", JdeDataType.String, 80),
        new JdeField("HFAD2I", "HFAD2I", JdeDataType.String, 80),
        new JdeField("HFAD3I", "HFAD3I", JdeDataType.String, 80),
        new JdeField("HFAD4I", "HFAD4I", JdeDataType.String, 80),
        new JdeField("HFPTD", "HFPTD", JdeDataType.String, 60),
        new JdeField("HFDEL1", "HFDEL1", JdeDataType.String, 60),
        new JdeField("HFDEL2", "HFDEL2", JdeDataType.String, 60),
        new JdeField("HFDOCO", "HFDOCO", JdeDataType.Numeric),
        new JdeField("HFDCTO", "HFDCTO", JdeDataType.String, 4),
        new JdeField("HFKCOO", "HFKCOO", JdeDataType.String, 10),
        new JdeField("HFODOC", "HFODOC", JdeDataType.Numeric),
        new JdeField("HFODCT", "HFODCT", JdeDataType.String, 4),
        new JdeField("HFTAXA", "HFTAXA", JdeDataType.String, 60),
        new JdeField("HFDL0", "HFDL0", JdeDataType.String, 60),
        new JdeField("HFDL03", "HFDL03", JdeDataType.String, 60),
        new JdeField("HFSTA1", "HFSTA1", JdeDataType.Numeric),
        new JdeField("HFSTA2", "HFSTA2", JdeDataType.Numeric),
        new JdeField("HFSTA3", "HFSTA3", JdeDataType.Numeric),
        new JdeField("HFSTA4", "HFSTA4", JdeDataType.Numeric),
        new JdeField("HFAG", "HFAG", JdeDataType.Numeric),
        new JdeField("HFDL02", "HFDL02", JdeDataType.String, 60),
        new JdeField("HFCRR", "HFCRR", JdeDataType.Numeric),
        new JdeField("HFADSA", "HFADSA", JdeDataType.Numeric),
        new JdeField("HFITWT", "HFITWT", JdeDataType.Numeric),
        new JdeField("HFWTUM", "HFWTUM", JdeDataType.String, 4),
        new JdeField("HFITVL", "HFITVL", JdeDataType.Numeric),
        new JdeField("HFVLUM", "HFVLUM", JdeDataType.String, 4),
        new JdeField("HFADD0", "HFADD0", JdeDataType.String, 80),
        new JdeField("HFTAXS", "HFTAXS", JdeDataType.String, 40),
        new JdeField("HFAPIT", "HFAPIT", JdeDataType.Numeric),
        new JdeField("HFACAI", "HFACAI", JdeDataType.String, 28),
        new JdeField("HFCXPJ", "HFCXPJ", JdeDataType.Numeric),
        new JdeField("HFRLNO", "HFRLNO", JdeDataType.String, 26),
        new JdeField("HFLDNM", "HFLDNM", JdeDataType.Numeric),
        new JdeField("HFSTUM", "HFSTUM", JdeDataType.Numeric),
        new JdeField("HFBUM6", "HFBUM6", JdeDataType.String, 4),
        new JdeField("HFPNMG", "HFPNMG", JdeDataType.String, 20),
        new JdeField("HFINMG", "HFINMG", JdeDataType.String, 20),
        new JdeField("HFEV03", "HFEV03", JdeDataType.String, 2),
        new JdeField("HFEV04", "HFEV04", JdeDataType.String, 2),
        new JdeField("HFEV05", "HFEV05", JdeDataType.String, 2),
        new JdeField("HFEV06", "HFEV06", JdeDataType.String, 2),
        new JdeField("HFEV07", "HFEV07", JdeDataType.String, 2),
        new JdeField("HFORIG", "HFORIG", JdeDataType.String, 6),
        new JdeField("HFICON", "HFICON", JdeDataType.String, 2),
        new JdeField("HFFLGA", "HFFLGA", JdeDataType.String, 2),
        new JdeField("HFEFT", "HFEFT", JdeDataType.Numeric),
        new JdeField("HFURAB", "HFURAB", JdeDataType.Numeric),
        new JdeField("HFURAT", "HFURAT", JdeDataType.Numeric),
        new JdeField("HFURC1", "HFURC1", JdeDataType.String, 6),
        new JdeField("HFURC2", "HFURC2", JdeDataType.String, 20),
        new JdeField("HFURCD", "HFURCD", JdeDataType.String, 4),
        new JdeField("HFURDD", "HFURDD", JdeDataType.Numeric),
        new JdeField("HFURDT", "HFURDT", JdeDataType.Numeric),
        new JdeField("HFURNUM01", "HFURNUM01", JdeDataType.Numeric),
        new JdeField("HFURNUM02", "HFURNUM02", JdeDataType.Numeric),
        new JdeField("HFURNUM03", "HFURNUM03", JdeDataType.Numeric),
        new JdeField("HFURRF", "HFURRF", JdeDataType.String, 30),
        new JdeField("HFADD10", "HFADD10", JdeDataType.String, 80),
        new JdeField("HFADD11", "HFADD11", JdeDataType.String, 80),
        new JdeField("HFADD12", "HFADD12", JdeDataType.String, 80),
        new JdeField("HFADD13", "HFADD13", JdeDataType.String, 80),
        new JdeField("HFCTY1", "HFCTY1", JdeDataType.String, 50),
        new JdeField("HFADDZ", "HFADDZ", JdeDataType.String, 24),
        new JdeField("HFACEM1", "HFACEM1", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A020P_0", "Primary Key on HFJOBS, HFCTID, HFDOC, HFDCT, HFKCO", new[] { "HFJOBS", "HFCTID", "HFDOC", "HFDCT", "HFKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
