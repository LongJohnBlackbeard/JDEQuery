using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15013 - .
/// </summary>
public class F15013 : JdeTable
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
        /// NODCTO.
        /// </summary>
        public const string NODCTO = "NODCTO";

        /// <summary>
        /// NOAN8.
        /// </summary>
        public const string NOAN8 = "NOAN8";

        /// <summary>
        /// NOAN8J.
        /// </summary>
        public const string NOAN8J = "NOAN8J";

        /// <summary>
        /// NORPFC.
        /// </summary>
        public const string NORPFC = "NORPFC";

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
        /// NOBLFC.
        /// </summary>
        public const string NOBLFC = "NOBLFC";

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
        /// NORFDY.
        /// </summary>
        public const string NORFDY = "NORFDY";

        /// <summary>
        /// NORADY.
        /// </summary>
        public const string NORADY = "NORADY";

        /// <summary>
        /// NOFYMO.
        /// </summary>
        public const string NOFYMO = "NOFYMO";

        /// <summary>
        /// NOFYDY.
        /// </summary>
        public const string NOFYDY = "NOFYDY";

        /// <summary>
        /// NOMCUS.
        /// </summary>
        public const string NOMCUS = "NOMCUS";

        /// <summary>
        /// NOUNIT.
        /// </summary>
        public const string NOUNIT = "NOUNIT";

        /// <summary>
        /// NOMCU.
        /// </summary>
        public const string NOMCU = "NOMCU";

        /// <summary>
        /// NOBLGR.
        /// </summary>
        public const string NOBLGR = "NOBLGR";

        /// <summary>
        /// NOULI.
        /// </summary>
        public const string NOULI = "NOULI";

        /// <summary>
        /// NOUSEA.
        /// </summary>
        public const string NOUSEA = "NOUSEA";

        /// <summary>
        /// NOTRAR.
        /// </summary>
        public const string NOTRAR = "NOTRAR";

        /// <summary>
        /// NOUSER.
        /// </summary>
        public const string NOUSER = "NOUSER";

        /// <summary>
        /// NOUPMJ.
        /// </summary>
        public const string NOUPMJ = "NOUPMJ";

        /// <summary>
        /// NOPID.
        /// </summary>
        public const string NOPID = "NOPID";

        /// <summary>
        /// NOJOBN.
        /// </summary>
        public const string NOJOBN = "NOJOBN";

        /// <summary>
        /// NOATDT.
        /// </summary>
        public const string NOATDT = "NOATDT";

        /// <summary>
        /// NOCMPM.
        /// </summary>
        public const string NOCMPM = "NOCMPM";

        /// <summary>
        /// NOBKPT.
        /// </summary>
        public const string NOBKPT = "NOBKPT";

        /// <summary>
        /// NOIBOE.
        /// </summary>
        public const string NOIBOE = "NOIBOE";

        /// <summary>
        /// NOGLC.
        /// </summary>
        public const string NOGLC = "NOGLC";

        /// <summary>
        /// NORYEM.
        /// </summary>
        public const string NORYEM = "NORYEM";

        /// <summary>
        /// NOYEOV.
        /// </summary>
        public const string NOYEOV = "NOYEOV";

        /// <summary>
        /// NOBGPN.
        /// </summary>
        public const string NOBGPN = "NOBGPN";

        /// <summary>
        /// NOBGPY.
        /// </summary>
        public const string NOBGPY = "NOBGPY";

        /// <summary>
        /// NOCTRY.
        /// </summary>
        public const string NOCTRY = "NOCTRY";

        /// <summary>
        /// NOYEOY.
        /// </summary>
        public const string NOYEOY = "NOYEOY";

        /// <summary>
        /// NOOVCT.
        /// </summary>
        public const string NOOVCT = "NOOVCT";

        /// <summary>
        /// NOBLMR.
        /// </summary>
        public const string NOBLMR = "NOBLMR";

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
        /// NOBCI.
        /// </summary>
        public const string NOBCI = "NOBCI";

        /// <summary>
        /// NOUPMT.
        /// </summary>
        public const string NOUPMT = "NOUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F15013";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NODOCO", "NODOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NODCTO", "NODCTO", JdeDataType.String, 4),
        new JdeField("NOAN8", "NOAN8", JdeDataType.Numeric),
        new JdeField("NOAN8J", "NOAN8J", JdeDataType.Numeric),
        new JdeField("NORPFC", "NORPFC", JdeDataType.String, 2),
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
        new JdeField("NOBLFC", "NOBLFC", JdeDataType.String, 2),
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
        new JdeField("NORFDY", "NORFDY", JdeDataType.Numeric),
        new JdeField("NORADY", "NORADY", JdeDataType.Numeric),
        new JdeField("NOFYMO", "NOFYMO", JdeDataType.Numeric),
        new JdeField("NOFYDY", "NOFYDY", JdeDataType.Numeric),
        new JdeField("NOMCUS", "NOMCUS", JdeDataType.String, 24),
        new JdeField("NOUNIT", "NOUNIT", JdeDataType.String, 16),
        new JdeField("NOMCU", "NOMCU", JdeDataType.String, 24),
        new JdeField("NOBLGR", "NOBLGR", JdeDataType.String, 24),
        new JdeField("NOULI", "NOULI", JdeDataType.String, 16),
        new JdeField("NOUSEA", "NOUSEA", JdeDataType.Numeric),
        new JdeField("NOTRAR", "NOTRAR", JdeDataType.String, 6),
        new JdeField("NOUSER", "NOUSER", JdeDataType.String, 20),
        new JdeField("NOUPMJ", "NOUPMJ", JdeDataType.Numeric),
        new JdeField("NOPID", "NOPID", JdeDataType.String, 20),
        new JdeField("NOJOBN", "NOJOBN", JdeDataType.String, 20),
        new JdeField("NOATDT", "NOATDT", JdeDataType.Numeric),
        new JdeField("NOCMPM", "NOCMPM", JdeDataType.String, 2),
        new JdeField("NOBKPT", "NOBKPT", JdeDataType.Numeric),
        new JdeField("NOIBOE", "NOIBOE", JdeDataType.String, 2),
        new JdeField("NOGLC", "NOGLC", JdeDataType.String, 8),
        new JdeField("NORYEM", "NORYEM", JdeDataType.Numeric),
        new JdeField("NOYEOV", "NOYEOV", JdeDataType.String, 2, true, true),
        new JdeField("NOBGPN", "NOBGPN", JdeDataType.Numeric),
        new JdeField("NOBGPY", "NOBGPY", JdeDataType.Numeric),
        new JdeField("NOCTRY", "NOCTRY", JdeDataType.Numeric),
        new JdeField("NOYEOY", "NOYEOY", JdeDataType.Numeric),
        new JdeField("NOOVCT", "NOOVCT", JdeDataType.Numeric),
        new JdeField("NOBLMR", "NOBLMR", JdeDataType.String, 2),
        new JdeField("NODEAL", "NODEAL", JdeDataType.String, 16),
        new JdeField("NOCRCD", "NOCRCD", JdeDataType.String, 6),
        new JdeField("NOTXA1", "NOTXA1", JdeDataType.String, 20),
        new JdeField("NOEXR1", "NOEXR1", JdeDataType.String, 4),
        new JdeField("NORM11", "NORM11", JdeDataType.String, 8),
        new JdeField("NORM12", "NORM12", JdeDataType.String, 8),
        new JdeField("NOBCI", "NOBCI", JdeDataType.Numeric),
        new JdeField("NOUPMT", "NOUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15013_0", "Primary Key on NODOCO, NOYEOV", new[] { "NODOCO", "NOYEOV" }, isUnique: true, isPrimaryKey: true)
    };
}
