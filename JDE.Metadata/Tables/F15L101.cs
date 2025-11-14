using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L101 - .
/// </summary>
public class F15L101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UMMCU.
        /// </summary>
        public const string UMMCU = "UMMCU";

        /// <summary>
        /// UMUNIT.
        /// </summary>
        public const string UMUNIT = "UMUNIT";

        /// <summary>
        /// UMRVNB.
        /// </summary>
        public const string UMRVNB = "UMRVNB";

        /// <summary>
        /// UMMCUS.
        /// </summary>
        public const string UMMCUS = "UMMCUS";

        /// <summary>
        /// UMDESC.
        /// </summary>
        public const string UMDESC = "UMDESC";

        /// <summary>
        /// UMFLOR.
        /// </summary>
        public const string UMFLOR = "UMFLOR";

        /// <summary>
        /// UMOUNT.
        /// </summary>
        public const string UMOUNT = "UMOUNT";

        /// <summary>
        /// UMRENA.
        /// </summary>
        public const string UMRENA = "UMRENA";

        /// <summary>
        /// UMUTTY.
        /// </summary>
        public const string UMUTTY = "UMUTTY";

        /// <summary>
        /// UMEPTY.
        /// </summary>
        public const string UMEPTY = "UMEPTY";

        /// <summary>
        /// UMRL01.
        /// </summary>
        public const string UMRL01 = "UMRL01";

        /// <summary>
        /// UMRL02.
        /// </summary>
        public const string UMRL02 = "UMRL02";

        /// <summary>
        /// UMRL03.
        /// </summary>
        public const string UMRL03 = "UMRL03";

        /// <summary>
        /// UMRL04.
        /// </summary>
        public const string UMRL04 = "UMRL04";

        /// <summary>
        /// UMRL05.
        /// </summary>
        public const string UMRL05 = "UMRL05";

        /// <summary>
        /// UMUR01.
        /// </summary>
        public const string UMUR01 = "UMUR01";

        /// <summary>
        /// UMUR02.
        /// </summary>
        public const string UMUR02 = "UMUR02";

        /// <summary>
        /// UMUR03.
        /// </summary>
        public const string UMUR03 = "UMUR03";

        /// <summary>
        /// UMUR04.
        /// </summary>
        public const string UMUR04 = "UMUR04";

        /// <summary>
        /// UMUR05.
        /// </summary>
        public const string UMUR05 = "UMUR05";

        /// <summary>
        /// UMVREF.
        /// </summary>
        public const string UMVREF = "UMVREF";

        /// <summary>
        /// UMVRED.
        /// </summary>
        public const string UMVRED = "UMVRED";

        /// <summary>
        /// UMDOCO.
        /// </summary>
        public const string UMDOCO = "UMDOCO";

        /// <summary>
        /// UMUM.
        /// </summary>
        public const string UMUM = "UMUM";

        /// <summary>
        /// UMUSEA.
        /// </summary>
        public const string UMUSEA = "UMUSEA";

        /// <summary>
        /// UMSUSA.
        /// </summary>
        public const string UMSUSA = "UMSUSA";

        /// <summary>
        /// UMSPSF.
        /// </summary>
        public const string UMSPSF = "UMSPSF";

        /// <summary>
        /// UMEFTB.
        /// </summary>
        public const string UMEFTB = "UMEFTB";

        /// <summary>
        /// UMEFTE.
        /// </summary>
        public const string UMEFTE = "UMEFTE";

        /// <summary>
        /// UMBELK.
        /// </summary>
        public const string UMBELK = "UMBELK";

        /// <summary>
        /// UMEPRD.
        /// </summary>
        public const string UMEPRD = "UMEPRD";

        /// <summary>
        /// UMEPRE.
        /// </summary>
        public const string UMEPRE = "UMEPRE";

        /// <summary>
        /// UMEPRF.
        /// </summary>
        public const string UMEPRF = "UMEPRF";

        /// <summary>
        /// UMASP1.
        /// </summary>
        public const string UMASP1 = "UMASP1";

        /// <summary>
        /// UMASP2.
        /// </summary>
        public const string UMASP2 = "UMASP2";

        /// <summary>
        /// UMASP3.
        /// </summary>
        public const string UMASP3 = "UMASP3";

        /// <summary>
        /// UMSOID.
        /// </summary>
        public const string UMSOID = "UMSOID";

        /// <summary>
        /// UMSOIE.
        /// </summary>
        public const string UMSOIE = "UMSOIE";

        /// <summary>
        /// UMSOIF.
        /// </summary>
        public const string UMSOIF = "UMSOIF";

        /// <summary>
        /// UMBCRI.
        /// </summary>
        public const string UMBCRI = "UMBCRI";

        /// <summary>
        /// UMBCRJ.
        /// </summary>
        public const string UMBCRJ = "UMBCRJ";

        /// <summary>
        /// UMBCRK.
        /// </summary>
        public const string UMBCRK = "UMBCRK";

        /// <summary>
        /// UMAACT.
        /// </summary>
        public const string UMAACT = "UMAACT";

        /// <summary>
        /// UMAACU.
        /// </summary>
        public const string UMAACU = "UMAACU";

        /// <summary>
        /// UMAACV.
        /// </summary>
        public const string UMAACV = "UMAACV";

        /// <summary>
        /// UMBA01.
        /// </summary>
        public const string UMBA01 = "UMBA01";

        /// <summary>
        /// UMBA02.
        /// </summary>
        public const string UMBA02 = "UMBA02";

        /// <summary>
        /// UMBA03.
        /// </summary>
        public const string UMBA03 = "UMBA03";

        /// <summary>
        /// UMBA04.
        /// </summary>
        public const string UMBA04 = "UMBA04";

        /// <summary>
        /// UMBA05.
        /// </summary>
        public const string UMBA05 = "UMBA05";

        /// <summary>
        /// UMBA06.
        /// </summary>
        public const string UMBA06 = "UMBA06";

        /// <summary>
        /// UMBA07.
        /// </summary>
        public const string UMBA07 = "UMBA07";

        /// <summary>
        /// UMBA08.
        /// </summary>
        public const string UMBA08 = "UMBA08";

        /// <summary>
        /// UMBA09.
        /// </summary>
        public const string UMBA09 = "UMBA09";

        /// <summary>
        /// UMBA10.
        /// </summary>
        public const string UMBA10 = "UMBA10";

        /// <summary>
        /// UMBA11.
        /// </summary>
        public const string UMBA11 = "UMBA11";

        /// <summary>
        /// UMBA12.
        /// </summary>
        public const string UMBA12 = "UMBA12";

        /// <summary>
        /// UMDAJ.
        /// </summary>
        public const string UMDAJ = "UMDAJ";

        /// <summary>
        /// UMDSP.
        /// </summary>
        public const string UMDSP = "UMDSP";

        /// <summary>
        /// UMDEXJ.
        /// </summary>
        public const string UMDEXJ = "UMDEXJ";

        /// <summary>
        /// UMDBDT.
        /// </summary>
        public const string UMDBDT = "UMDBDT";

        /// <summary>
        /// UMDEET.
        /// </summary>
        public const string UMDEET = "UMDEET";

        /// <summary>
        /// UMNUMB.
        /// </summary>
        public const string UMNUMB = "UMNUMB";

        /// <summary>
        /// UMRFL1.
        /// </summary>
        public const string UMRFL1 = "UMRFL1";

        /// <summary>
        /// UMRFL2.
        /// </summary>
        public const string UMRFL2 = "UMRFL2";

        /// <summary>
        /// UMRFL3.
        /// </summary>
        public const string UMRFL3 = "UMRFL3";

        /// <summary>
        /// UMRFL4.
        /// </summary>
        public const string UMRFL4 = "UMRFL4";

        /// <summary>
        /// UMRFL5.
        /// </summary>
        public const string UMRFL5 = "UMRFL5";

        /// <summary>
        /// UMRFL6.
        /// </summary>
        public const string UMRFL6 = "UMRFL6";

        /// <summary>
        /// UMRFL7.
        /// </summary>
        public const string UMRFL7 = "UMRFL7";

        /// <summary>
        /// UMRFL8.
        /// </summary>
        public const string UMRFL8 = "UMRFL8";

        /// <summary>
        /// UMRFL9.
        /// </summary>
        public const string UMRFL9 = "UMRFL9";

        /// <summary>
        /// UMRFL10.
        /// </summary>
        public const string UMRFL10 = "UMRFL10";

        /// <summary>
        /// UMRFL11.
        /// </summary>
        public const string UMRFL11 = "UMRFL11";

        /// <summary>
        /// UMRFL12.
        /// </summary>
        public const string UMRFL12 = "UMRFL12";

        /// <summary>
        /// UMRFL13.
        /// </summary>
        public const string UMRFL13 = "UMRFL13";

        /// <summary>
        /// UMRFL14.
        /// </summary>
        public const string UMRFL14 = "UMRFL14";

        /// <summary>
        /// UMRFL15.
        /// </summary>
        public const string UMRFL15 = "UMRFL15";

        /// <summary>
        /// UMURCD.
        /// </summary>
        public const string UMURCD = "UMURCD";

        /// <summary>
        /// UMURDT.
        /// </summary>
        public const string UMURDT = "UMURDT";

        /// <summary>
        /// UMURAT.
        /// </summary>
        public const string UMURAT = "UMURAT";

        /// <summary>
        /// UMURAB.
        /// </summary>
        public const string UMURAB = "UMURAB";

        /// <summary>
        /// UMURRF.
        /// </summary>
        public const string UMURRF = "UMURRF";

        /// <summary>
        /// UMUSER.
        /// </summary>
        public const string UMUSER = "UMUSER";

        /// <summary>
        /// UMPID.
        /// </summary>
        public const string UMPID = "UMPID";

        /// <summary>
        /// UMUPMJ.
        /// </summary>
        public const string UMUPMJ = "UMUPMJ";

        /// <summary>
        /// UMUPMT.
        /// </summary>
        public const string UMUPMT = "UMUPMT";

        /// <summary>
        /// UMJOBN.
        /// </summary>
        public const string UMJOBN = "UMJOBN";

        /// <summary>
        /// UMTORG.
        /// </summary>
        public const string UMTORG = "UMTORG";

        /// <summary>
        /// UMENTJ.
        /// </summary>
        public const string UMENTJ = "UMENTJ";

        /// <summary>
        /// UMARRID.
        /// </summary>
        public const string UMARRID = "UMARRID";

        /// <summary>
        /// UMRNWFLG.
        /// </summary>
        public const string UMRNWFLG = "UMRNWFLG";

        /// <summary>
        /// UMRNWGPA.
        /// </summary>
        public const string UMRNWGPA = "UMRNWGPA";

        /// <summary>
        /// UMRNWEXT.
        /// </summary>
        public const string UMRNWEXT = "UMRNWEXT";

        /// <summary>
        /// UMRNWDWT.
        /// </summary>
        public const string UMRNWDWT = "UMRNWDWT";

        /// <summary>
        /// UMREMGAP.
        /// </summary>
        public const string UMREMGAP = "UMREMGAP";

        /// <summary>
        /// UMLSVR.
        /// </summary>
        public const string UMLSVR = "UMLSVR";

        /// <summary>
        /// UMUKID.
        /// </summary>
        public const string UMUKID = "UMUKID";

        /// <summary>
        /// UMRNWTTY.
        /// </summary>
        public const string UMRNWTTY = "UMRNWTTY";

        /// <summary>
        /// UMAATF.
        /// </summary>
        public const string UMAATF = "UMAATF";
    }

    /// <inheritdoc />
    public override string TableName => "F15L101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UMMCU", "UMMCU", JdeDataType.String, 24, true, true),
        new JdeField("UMUNIT", "UMUNIT", JdeDataType.String, 16, true, true),
        new JdeField("UMRVNB", "UMRVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("UMMCUS", "UMMCUS", JdeDataType.String, 24),
        new JdeField("UMDESC", "UMDESC", JdeDataType.String, 60),
        new JdeField("UMFLOR", "UMFLOR", JdeDataType.String, 8),
        new JdeField("UMOUNT", "UMOUNT", JdeDataType.String, 16),
        new JdeField("UMRENA", "UMRENA", JdeDataType.Numeric),
        new JdeField("UMUTTY", "UMUTTY", JdeDataType.String, 10),
        new JdeField("UMEPTY", "UMEPTY", JdeDataType.String, 10),
        new JdeField("UMRL01", "UMRL01", JdeDataType.String, 6),
        new JdeField("UMRL02", "UMRL02", JdeDataType.String, 6),
        new JdeField("UMRL03", "UMRL03", JdeDataType.String, 6),
        new JdeField("UMRL04", "UMRL04", JdeDataType.String, 6),
        new JdeField("UMRL05", "UMRL05", JdeDataType.String, 6),
        new JdeField("UMUR01", "UMUR01", JdeDataType.String, 6),
        new JdeField("UMUR02", "UMUR02", JdeDataType.String, 6),
        new JdeField("UMUR03", "UMUR03", JdeDataType.String, 6),
        new JdeField("UMUR04", "UMUR04", JdeDataType.String, 6),
        new JdeField("UMUR05", "UMUR05", JdeDataType.String, 6),
        new JdeField("UMVREF", "UMVREF", JdeDataType.Numeric),
        new JdeField("UMVRED", "UMVRED", JdeDataType.Numeric),
        new JdeField("UMDOCO", "UMDOCO", JdeDataType.Numeric),
        new JdeField("UMUM", "UMUM", JdeDataType.String, 4),
        new JdeField("UMUSEA", "UMUSEA", JdeDataType.Numeric),
        new JdeField("UMSUSA", "UMSUSA", JdeDataType.Numeric),
        new JdeField("UMSPSF", "UMSPSF", JdeDataType.Numeric),
        new JdeField("UMEFTB", "UMEFTB", JdeDataType.Numeric),
        new JdeField("UMEFTE", "UMEFTE", JdeDataType.Numeric),
        new JdeField("UMBELK", "UMBELK", JdeDataType.String, 2),
        new JdeField("UMEPRD", "UMEPRD", JdeDataType.String, 20),
        new JdeField("UMEPRE", "UMEPRE", JdeDataType.String, 20),
        new JdeField("UMEPRF", "UMEPRF", JdeDataType.String, 20),
        new JdeField("UMASP1", "UMASP1", JdeDataType.String, 20),
        new JdeField("UMASP2", "UMASP2", JdeDataType.String, 20),
        new JdeField("UMASP3", "UMASP3", JdeDataType.String, 20),
        new JdeField("UMSOID", "UMSOID", JdeDataType.String, 20),
        new JdeField("UMSOIE", "UMSOIE", JdeDataType.String, 20),
        new JdeField("UMSOIF", "UMSOIF", JdeDataType.String, 20),
        new JdeField("UMBCRI", "UMBCRI", JdeDataType.String, 20),
        new JdeField("UMBCRJ", "UMBCRJ", JdeDataType.String, 20),
        new JdeField("UMBCRK", "UMBCRK", JdeDataType.String, 20),
        new JdeField("UMAACT", "UMAACT", JdeDataType.String, 4),
        new JdeField("UMAACU", "UMAACU", JdeDataType.String, 4),
        new JdeField("UMAACV", "UMAACV", JdeDataType.String, 4),
        new JdeField("UMBA01", "UMBA01", JdeDataType.Numeric),
        new JdeField("UMBA02", "UMBA02", JdeDataType.Numeric),
        new JdeField("UMBA03", "UMBA03", JdeDataType.Numeric),
        new JdeField("UMBA04", "UMBA04", JdeDataType.Numeric),
        new JdeField("UMBA05", "UMBA05", JdeDataType.Numeric),
        new JdeField("UMBA06", "UMBA06", JdeDataType.Numeric),
        new JdeField("UMBA07", "UMBA07", JdeDataType.Numeric),
        new JdeField("UMBA08", "UMBA08", JdeDataType.Numeric),
        new JdeField("UMBA09", "UMBA09", JdeDataType.Numeric),
        new JdeField("UMBA10", "UMBA10", JdeDataType.Numeric),
        new JdeField("UMBA11", "UMBA11", JdeDataType.Numeric),
        new JdeField("UMBA12", "UMBA12", JdeDataType.Numeric),
        new JdeField("UMDAJ", "UMDAJ", JdeDataType.Numeric),
        new JdeField("UMDSP", "UMDSP", JdeDataType.Numeric),
        new JdeField("UMDEXJ", "UMDEXJ", JdeDataType.Numeric),
        new JdeField("UMDBDT", "UMDBDT", JdeDataType.Numeric),
        new JdeField("UMDEET", "UMDEET", JdeDataType.Numeric),
        new JdeField("UMNUMB", "UMNUMB", JdeDataType.Numeric),
        new JdeField("UMRFL1", "UMRFL1", JdeDataType.Numeric),
        new JdeField("UMRFL2", "UMRFL2", JdeDataType.Numeric),
        new JdeField("UMRFL3", "UMRFL3", JdeDataType.Numeric),
        new JdeField("UMRFL4", "UMRFL4", JdeDataType.Numeric),
        new JdeField("UMRFL5", "UMRFL5", JdeDataType.Numeric),
        new JdeField("UMRFL6", "UMRFL6", JdeDataType.Numeric),
        new JdeField("UMRFL7", "UMRFL7", JdeDataType.Numeric),
        new JdeField("UMRFL8", "UMRFL8", JdeDataType.Numeric),
        new JdeField("UMRFL9", "UMRFL9", JdeDataType.Numeric),
        new JdeField("UMRFL10", "UMRFL10", JdeDataType.Numeric),
        new JdeField("UMRFL11", "UMRFL11", JdeDataType.Numeric),
        new JdeField("UMRFL12", "UMRFL12", JdeDataType.Numeric),
        new JdeField("UMRFL13", "UMRFL13", JdeDataType.Numeric),
        new JdeField("UMRFL14", "UMRFL14", JdeDataType.Numeric),
        new JdeField("UMRFL15", "UMRFL15", JdeDataType.Numeric),
        new JdeField("UMURCD", "UMURCD", JdeDataType.String, 4),
        new JdeField("UMURDT", "UMURDT", JdeDataType.Numeric),
        new JdeField("UMURAT", "UMURAT", JdeDataType.Numeric),
        new JdeField("UMURAB", "UMURAB", JdeDataType.Numeric),
        new JdeField("UMURRF", "UMURRF", JdeDataType.String, 30),
        new JdeField("UMUSER", "UMUSER", JdeDataType.String, 20),
        new JdeField("UMPID", "UMPID", JdeDataType.String, 20),
        new JdeField("UMUPMJ", "UMUPMJ", JdeDataType.Numeric),
        new JdeField("UMUPMT", "UMUPMT", JdeDataType.Numeric),
        new JdeField("UMJOBN", "UMJOBN", JdeDataType.String, 20),
        new JdeField("UMTORG", "UMTORG", JdeDataType.String, 20),
        new JdeField("UMENTJ", "UMENTJ", JdeDataType.Numeric),
        new JdeField("UMARRID", "UMARRID", JdeDataType.String, 20),
        new JdeField("UMRNWFLG", "UMRNWFLG", JdeDataType.String, 2),
        new JdeField("UMRNWGPA", "UMRNWGPA", JdeDataType.String, 20),
        new JdeField("UMRNWEXT", "UMRNWEXT", JdeDataType.Numeric),
        new JdeField("UMRNWDWT", "UMRNWDWT", JdeDataType.Numeric),
        new JdeField("UMREMGAP", "UMREMGAP", JdeDataType.String, 2),
        new JdeField("UMLSVR", "UMLSVR", JdeDataType.Numeric),
        new JdeField("UMUKID", "UMUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("UMRNWTTY", "UMRNWTTY", JdeDataType.String, 20),
        new JdeField("UMAATF", "UMAATF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L101_0", "Primary Key on UMMCU, UMUNIT, UMRVNB, UMUKID", new[] { "UMMCU", "UMUNIT", "UMRVNB", "UMUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15L101_2", "Index on UMMCU, UMRVNB, UMOUNT", new[] { "UMMCU", "UMRVNB", "UMOUNT" }),
        new JdeIndex("F15L101_3", "Index on UMRVNB, UMMCUS, UMMCU, UMUNIT, SYS_NC00101$", new[] { "UMRVNB", "UMMCUS", "UMMCU", "UMUNIT", "SYS_NC00101$" }),
        new JdeIndex("F15L101_4", "Index on UMMCU, UMUNIT, UMRVNB, UMDOCO, UMLSVR", new[] { "UMMCU", "UMUNIT", "UMRVNB", "UMDOCO", "UMLSVR" }),
        new JdeIndex("F15L101_5", "Index on UMARRID", new[] { "UMARRID" }),
        new JdeIndex("F15L101_6", "Index on UMMCU, UMUNIT, UMRVNB, SYS_NC00101$", new[] { "UMMCU", "UMUNIT", "UMRVNB", "SYS_NC00101$" }),
        new JdeIndex("F15L101_7", "Index on UMMCU, UMUNIT, UMRVNB", new[] { "UMMCU", "UMUNIT", "UMRVNB" }),
        new JdeIndex("F15L101_8", "Index on UMMCU, UMUNIT, UMRVNB, UMVREF", new[] { "UMMCU", "UMUNIT", "UMRVNB", "UMVREF" }),
        new JdeIndex("F15L101_9", "Index on UMMCU, UMRVNB, UMARRID", new[] { "UMMCU", "UMRVNB", "UMARRID" })
    };
}
