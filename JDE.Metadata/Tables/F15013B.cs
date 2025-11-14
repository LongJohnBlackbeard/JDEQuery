using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15013B - .
/// </summary>
public class F15013B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NODOCO.
        /// </summary>
        public const string NODOCO = "NODOCO";

        /// <summary>
        /// NOSUSP.
        /// </summary>
        public const string NOSUSP = "NOSUSP";

        /// <summary>
        /// NOVRSC.
        /// </summary>
        public const string NOVRSC = "NOVRSC";

        /// <summary>
        /// NOBCI3.
        /// </summary>
        public const string NOBCI3 = "NOBCI3";

        /// <summary>
        /// NOSUDT.
        /// </summary>
        public const string NOSUDT = "NOSUDT";

        /// <summary>
        /// NOEFTE.
        /// </summary>
        public const string NOEFTE = "NOEFTE";

        /// <summary>
        /// NOEFTB.
        /// </summary>
        public const string NOEFTB = "NOEFTB";

        /// <summary>
        /// NOLSVR.
        /// </summary>
        public const string NOLSVR = "NOLSVR";

        /// <summary>
        /// NOMCU.
        /// </summary>
        public const string NOMCU = "NOMCU";

        /// <summary>
        /// NOUNIT.
        /// </summary>
        public const string NOUNIT = "NOUNIT";

        /// <summary>
        /// NOSTNR.
        /// </summary>
        public const string NOSTNR = "NOSTNR";

        /// <summary>
        /// NOYEOV.
        /// </summary>
        public const string NOYEOV = "NOYEOV";

        /// <summary>
        /// NOBCI.
        /// </summary>
        public const string NOBCI = "NOBCI";

        /// <summary>
        /// NOAN8J.
        /// </summary>
        public const string NOAN8J = "NOAN8J";

        /// <summary>
        /// NOBLFC.
        /// </summary>
        public const string NOBLFC = "NOBLFC";

        /// <summary>
        /// NODCTO.
        /// </summary>
        public const string NODCTO = "NODCTO";

        /// <summary>
        /// NOAN8.
        /// </summary>
        public const string NOAN8 = "NOAN8";

        /// <summary>
        /// NOMCUS.
        /// </summary>
        public const string NOMCUS = "NOMCUS";

        /// <summary>
        /// NOBLMR.
        /// </summary>
        public const string NOBLMR = "NOBLMR";

        /// <summary>
        /// NOCMPM.
        /// </summary>
        public const string NOCMPM = "NOCMPM";

        /// <summary>
        /// NOPROL.
        /// </summary>
        public const string NOPROL = "NOPROL";

        /// <summary>
        /// NOFYMO.
        /// </summary>
        public const string NOFYMO = "NOFYMO";

        /// <summary>
        /// NOFYDY.
        /// </summary>
        public const string NOFYDY = "NOFYDY";

        /// <summary>
        /// NORPFC.
        /// </summary>
        public const string NORPFC = "NORPFC";

        /// <summary>
        /// NORFDY.
        /// </summary>
        public const string NORFDY = "NORFDY";

        /// <summary>
        /// NORADY.
        /// </summary>
        public const string NORADY = "NORADY";

        /// <summary>
        /// NORYEM.
        /// </summary>
        public const string NORYEM = "NORYEM";

        /// <summary>
        /// NOFYR.
        /// </summary>
        public const string NOFYR = "NOFYR";

        /// <summary>
        /// NOBGPN.
        /// </summary>
        public const string NOBGPN = "NOBGPN";

        /// <summary>
        /// NOATDT.
        /// </summary>
        public const string NOATDT = "NOATDT";

        /// <summary>
        /// NOBLGR.
        /// </summary>
        public const string NOBLGR = "NOBLGR";

        /// <summary>
        /// NOULI.
        /// </summary>
        public const string NOULI = "NOULI";

        /// <summary>
        /// NOULI2.
        /// </summary>
        public const string NOULI2 = "NOULI2";

        /// <summary>
        /// NOUSEA.
        /// </summary>
        public const string NOUSEA = "NOUSEA";

        /// <summary>
        /// NOTRAR.
        /// </summary>
        public const string NOTRAR = "NOTRAR";

        /// <summary>
        /// NOBKPT.
        /// </summary>
        public const string NOBKPT = "NOBKPT";

        /// <summary>
        /// NOIBOE.
        /// </summary>
        public const string NOIBOE = "NOIBOE";

        /// <summary>
        /// NOCENTYR.
        /// </summary>
        public const string NOCENTYR = "NOCENTYR";

        /// <summary>
        /// NOGLC.
        /// </summary>
        public const string NOGLC = "NOGLC";

        /// <summary>
        /// NODEAL.
        /// </summary>
        public const string NODEAL = "NODEAL";

        /// <summary>
        /// NOCRCD.
        /// </summary>
        public const string NOCRCD = "NOCRCD";

        /// <summary>
        /// NOTXA1.
        /// </summary>
        public const string NOTXA1 = "NOTXA1";

        /// <summary>
        /// NOEXR1.
        /// </summary>
        public const string NOEXR1 = "NOEXR1";

        /// <summary>
        /// NORM11.
        /// </summary>
        public const string NORM11 = "NORM11";

        /// <summary>
        /// NORM12.
        /// </summary>
        public const string NORM12 = "NORM12";

        /// <summary>
        /// NORM21.
        /// </summary>
        public const string NORM21 = "NORM21";

        /// <summary>
        /// NORM22.
        /// </summary>
        public const string NORM22 = "NORM22";

        /// <summary>
        /// NORM23.
        /// </summary>
        public const string NORM23 = "NORM23";

        /// <summary>
        /// NORF01.
        /// </summary>
        public const string NORF01 = "NORF01";

        /// <summary>
        /// NORF02.
        /// </summary>
        public const string NORF02 = "NORF02";

        /// <summary>
        /// NORF03.
        /// </summary>
        public const string NORF03 = "NORF03";

        /// <summary>
        /// NORF04.
        /// </summary>
        public const string NORF04 = "NORF04";

        /// <summary>
        /// NORF05.
        /// </summary>
        public const string NORF05 = "NORF05";

        /// <summary>
        /// NORF06.
        /// </summary>
        public const string NORF06 = "NORF06";

        /// <summary>
        /// NORF07.
        /// </summary>
        public const string NORF07 = "NORF07";

        /// <summary>
        /// NORF08.
        /// </summary>
        public const string NORF08 = "NORF08";

        /// <summary>
        /// NORF09.
        /// </summary>
        public const string NORF09 = "NORF09";

        /// <summary>
        /// NORF10.
        /// </summary>
        public const string NORF10 = "NORF10";

        /// <summary>
        /// NORF11.
        /// </summary>
        public const string NORF11 = "NORF11";

        /// <summary>
        /// NORF12.
        /// </summary>
        public const string NORF12 = "NORF12";

        /// <summary>
        /// NORF13.
        /// </summary>
        public const string NORF13 = "NORF13";

        /// <summary>
        /// NOBF01.
        /// </summary>
        public const string NOBF01 = "NOBF01";

        /// <summary>
        /// NOBF02.
        /// </summary>
        public const string NOBF02 = "NOBF02";

        /// <summary>
        /// NOBF03.
        /// </summary>
        public const string NOBF03 = "NOBF03";

        /// <summary>
        /// NOBF04.
        /// </summary>
        public const string NOBF04 = "NOBF04";

        /// <summary>
        /// NOBF05.
        /// </summary>
        public const string NOBF05 = "NOBF05";

        /// <summary>
        /// NOBF06.
        /// </summary>
        public const string NOBF06 = "NOBF06";

        /// <summary>
        /// NOBF07.
        /// </summary>
        public const string NOBF07 = "NOBF07";

        /// <summary>
        /// NOBF08.
        /// </summary>
        public const string NOBF08 = "NOBF08";

        /// <summary>
        /// NOBF09.
        /// </summary>
        public const string NOBF09 = "NOBF09";

        /// <summary>
        /// NOBF10.
        /// </summary>
        public const string NOBF10 = "NOBF10";

        /// <summary>
        /// NOBF11.
        /// </summary>
        public const string NOBF11 = "NOBF11";

        /// <summary>
        /// NOBF12.
        /// </summary>
        public const string NOBF12 = "NOBF12";

        /// <summary>
        /// NOBF13.
        /// </summary>
        public const string NOBF13 = "NOBF13";

        /// <summary>
        /// NOURCD.
        /// </summary>
        public const string NOURCD = "NOURCD";

        /// <summary>
        /// NOURDT.
        /// </summary>
        public const string NOURDT = "NOURDT";

        /// <summary>
        /// NOURAT.
        /// </summary>
        public const string NOURAT = "NOURAT";

        /// <summary>
        /// NOURAB.
        /// </summary>
        public const string NOURAB = "NOURAB";

        /// <summary>
        /// NOURRF.
        /// </summary>
        public const string NOURRF = "NOURRF";

        /// <summary>
        /// NOUSER.
        /// </summary>
        public const string NOUSER = "NOUSER";

        /// <summary>
        /// NOPID.
        /// </summary>
        public const string NOPID = "NOPID";

        /// <summary>
        /// NOUPMJ.
        /// </summary>
        public const string NOUPMJ = "NOUPMJ";

        /// <summary>
        /// NOUPMT.
        /// </summary>
        public const string NOUPMT = "NOUPMT";

        /// <summary>
        /// NOJOBN.
        /// </summary>
        public const string NOJOBN = "NOJOBN";

        /// <summary>
        /// NOENTJ.
        /// </summary>
        public const string NOENTJ = "NOENTJ";

        /// <summary>
        /// NOTORG.
        /// </summary>
        public const string NOTORG = "NOTORG";

        /// <summary>
        /// NOCRR.
        /// </summary>
        public const string NOCRR = "NOCRR";

        /// <summary>
        /// NOCRRM.
        /// </summary>
        public const string NOCRRM = "NOCRRM";

        /// <summary>
        /// NOLDUE.
        /// </summary>
        public const string NOLDUE = "NOLDUE";
    }

    /// <inheritdoc />
    public override string TableName => "F15013B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NODOCO", "NODOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NOSUSP", "NOSUSP", JdeDataType.String, 2),
        new JdeField("NOVRSC", "NOVRSC", JdeDataType.String, 2),
        new JdeField("NOBCI3", "NOBCI3", JdeDataType.Numeric),
        new JdeField("NOSUDT", "NOSUDT", JdeDataType.Numeric),
        new JdeField("NOEFTE", "NOEFTE", JdeDataType.Numeric),
        new JdeField("NOEFTB", "NOEFTB", JdeDataType.Numeric),
        new JdeField("NOLSVR", "NOLSVR", JdeDataType.Numeric, null, true, true),
        new JdeField("NOMCU", "NOMCU", JdeDataType.String, 24),
        new JdeField("NOUNIT", "NOUNIT", JdeDataType.String, 16),
        new JdeField("NOSTNR", "NOSTNR", JdeDataType.String, 20),
        new JdeField("NOYEOV", "NOYEOV", JdeDataType.String, 2, true, true),
        new JdeField("NOBCI", "NOBCI", JdeDataType.Numeric),
        new JdeField("NOAN8J", "NOAN8J", JdeDataType.Numeric),
        new JdeField("NOBLFC", "NOBLFC", JdeDataType.String, 2),
        new JdeField("NODCTO", "NODCTO", JdeDataType.String, 4),
        new JdeField("NOAN8", "NOAN8", JdeDataType.Numeric),
        new JdeField("NOMCUS", "NOMCUS", JdeDataType.String, 24),
        new JdeField("NOBLMR", "NOBLMR", JdeDataType.String, 2),
        new JdeField("NOCMPM", "NOCMPM", JdeDataType.String, 2),
        new JdeField("NOPROL", "NOPROL", JdeDataType.String, 2),
        new JdeField("NOFYMO", "NOFYMO", JdeDataType.Numeric),
        new JdeField("NOFYDY", "NOFYDY", JdeDataType.Numeric),
        new JdeField("NORPFC", "NORPFC", JdeDataType.String, 2),
        new JdeField("NORFDY", "NORFDY", JdeDataType.Numeric),
        new JdeField("NORADY", "NORADY", JdeDataType.Numeric),
        new JdeField("NORYEM", "NORYEM", JdeDataType.Numeric),
        new JdeField("NOFYR", "NOFYR", JdeDataType.Numeric),
        new JdeField("NOBGPN", "NOBGPN", JdeDataType.Numeric),
        new JdeField("NOATDT", "NOATDT", JdeDataType.Numeric),
        new JdeField("NOBLGR", "NOBLGR", JdeDataType.String, 24),
        new JdeField("NOULI", "NOULI", JdeDataType.String, 16),
        new JdeField("NOULI2", "NOULI2", JdeDataType.String, 16),
        new JdeField("NOUSEA", "NOUSEA", JdeDataType.Numeric),
        new JdeField("NOTRAR", "NOTRAR", JdeDataType.String, 6),
        new JdeField("NOBKPT", "NOBKPT", JdeDataType.Numeric),
        new JdeField("NOIBOE", "NOIBOE", JdeDataType.String, 2),
        new JdeField("NOCENTYR", "NOCENTYR", JdeDataType.Numeric),
        new JdeField("NOGLC", "NOGLC", JdeDataType.String, 8),
        new JdeField("NODEAL", "NODEAL", JdeDataType.String, 16),
        new JdeField("NOCRCD", "NOCRCD", JdeDataType.String, 6),
        new JdeField("NOTXA1", "NOTXA1", JdeDataType.String, 20),
        new JdeField("NOEXR1", "NOEXR1", JdeDataType.String, 4),
        new JdeField("NORM11", "NORM11", JdeDataType.String, 8),
        new JdeField("NORM12", "NORM12", JdeDataType.String, 8),
        new JdeField("NORM21", "NORM21", JdeDataType.String, 8),
        new JdeField("NORM22", "NORM22", JdeDataType.String, 8),
        new JdeField("NORM23", "NORM23", JdeDataType.String, 8),
        new JdeField("NORF01", "NORF01", JdeDataType.String, 2),
        new JdeField("NORF02", "NORF02", JdeDataType.String, 2),
        new JdeField("NORF03", "NORF03", JdeDataType.String, 2),
        new JdeField("NORF04", "NORF04", JdeDataType.String, 2),
        new JdeField("NORF05", "NORF05", JdeDataType.String, 2),
        new JdeField("NORF06", "NORF06", JdeDataType.String, 2),
        new JdeField("NORF07", "NORF07", JdeDataType.String, 2),
        new JdeField("NORF08", "NORF08", JdeDataType.String, 2),
        new JdeField("NORF09", "NORF09", JdeDataType.String, 2),
        new JdeField("NORF10", "NORF10", JdeDataType.String, 2),
        new JdeField("NORF11", "NORF11", JdeDataType.String, 2),
        new JdeField("NORF12", "NORF12", JdeDataType.String, 2),
        new JdeField("NORF13", "NORF13", JdeDataType.String, 2),
        new JdeField("NOBF01", "NOBF01", JdeDataType.String, 2),
        new JdeField("NOBF02", "NOBF02", JdeDataType.String, 2),
        new JdeField("NOBF03", "NOBF03", JdeDataType.String, 2),
        new JdeField("NOBF04", "NOBF04", JdeDataType.String, 2),
        new JdeField("NOBF05", "NOBF05", JdeDataType.String, 2),
        new JdeField("NOBF06", "NOBF06", JdeDataType.String, 2),
        new JdeField("NOBF07", "NOBF07", JdeDataType.String, 2),
        new JdeField("NOBF08", "NOBF08", JdeDataType.String, 2),
        new JdeField("NOBF09", "NOBF09", JdeDataType.String, 2),
        new JdeField("NOBF10", "NOBF10", JdeDataType.String, 2),
        new JdeField("NOBF11", "NOBF11", JdeDataType.String, 2),
        new JdeField("NOBF12", "NOBF12", JdeDataType.String, 2),
        new JdeField("NOBF13", "NOBF13", JdeDataType.String, 2),
        new JdeField("NOURCD", "NOURCD", JdeDataType.String, 4),
        new JdeField("NOURDT", "NOURDT", JdeDataType.Numeric),
        new JdeField("NOURAT", "NOURAT", JdeDataType.Numeric),
        new JdeField("NOURAB", "NOURAB", JdeDataType.Numeric),
        new JdeField("NOURRF", "NOURRF", JdeDataType.String, 30),
        new JdeField("NOUSER", "NOUSER", JdeDataType.String, 20),
        new JdeField("NOPID", "NOPID", JdeDataType.String, 20),
        new JdeField("NOUPMJ", "NOUPMJ", JdeDataType.Numeric),
        new JdeField("NOUPMT", "NOUPMT", JdeDataType.Numeric),
        new JdeField("NOJOBN", "NOJOBN", JdeDataType.String, 20),
        new JdeField("NOENTJ", "NOENTJ", JdeDataType.Numeric),
        new JdeField("NOTORG", "NOTORG", JdeDataType.String, 20),
        new JdeField("NOCRR", "NOCRR", JdeDataType.Numeric),
        new JdeField("NOCRRM", "NOCRRM", JdeDataType.String, 2),
        new JdeField("NOLDUE", "NOLDUE", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15013B_0", "Primary Key on NODOCO, NOYEOV, NOLSVR", new[] { "NODOCO", "NOYEOV", "NOLSVR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15013B_2", "Index on NOBLFC", new[] { "NOBLFC" }),
        new JdeIndex("F15013B_4", "Index on NODOCO, NOBCI", new[] { "NODOCO", "NOBCI" }),
        new JdeIndex("F15013B_5", "Index on NODOCO, NOLSVR", new[] { "NODOCO", "NOLSVR" }),
        new JdeIndex("F15013B_7", "Index on NODOCO, NOLSVR, NOBCI", new[] { "NODOCO", "NOLSVR", "NOBCI" }),
        new JdeIndex("F15013B_8", "Index on NORPFC", new[] { "NORPFC" })
    };
}
