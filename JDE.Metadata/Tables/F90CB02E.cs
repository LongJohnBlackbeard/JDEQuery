using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB02E - .
/// </summary>
public class F90CB02E : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OEOPPID.
        /// </summary>
        public const string OEOPPID = "OEOPPID";

        /// <summary>
        /// OEEMAN8.
        /// </summary>
        public const string OEEMAN8 = "OEEMAN8";

        /// <summary>
        /// OEALPH.
        /// </summary>
        public const string OEALPH = "OEALPH";

        /// <summary>
        /// OEPCNTG.
        /// </summary>
        public const string OEPCNTG = "OEPCNTG";

        /// <summary>
        /// OEOWNFLG.
        /// </summary>
        public const string OEOWNFLG = "OEOWNFLG";

        /// <summary>
        /// OERTYPE.
        /// </summary>
        public const string OERTYPE = "OERTYPE";

        /// <summary>
        /// OESTMBDT.
        /// </summary>
        public const string OESTMBDT = "OESTMBDT";

        /// <summary>
        /// OESTMEDT.
        /// </summary>
        public const string OESTMEDT = "OESTMEDT";

        /// <summary>
        /// OEENTDBY.
        /// </summary>
        public const string OEENTDBY = "OEENTDBY";

        /// <summary>
        /// OEEDATE.
        /// </summary>
        public const string OEEDATE = "OEEDATE";

        /// <summary>
        /// OEEXVAR0.
        /// </summary>
        public const string OEEXVAR0 = "OEEXVAR0";

        /// <summary>
        /// OEEXVAR1.
        /// </summary>
        public const string OEEXVAR1 = "OEEXVAR1";

        /// <summary>
        /// OEEXVAR4.
        /// </summary>
        public const string OEEXVAR4 = "OEEXVAR4";

        /// <summary>
        /// OEEXVAR5.
        /// </summary>
        public const string OEEXVAR5 = "OEEXVAR5";

        /// <summary>
        /// OEEXVAR6.
        /// </summary>
        public const string OEEXVAR6 = "OEEXVAR6";

        /// <summary>
        /// OEEXVAR7.
        /// </summary>
        public const string OEEXVAR7 = "OEEXVAR7";

        /// <summary>
        /// OEEXVAR12.
        /// </summary>
        public const string OEEXVAR12 = "OEEXVAR12";

        /// <summary>
        /// OEEXVAR13.
        /// </summary>
        public const string OEEXVAR13 = "OEEXVAR13";

        /// <summary>
        /// OEEXNM0.
        /// </summary>
        public const string OEEXNM0 = "OEEXNM0";

        /// <summary>
        /// OEEXNM1.
        /// </summary>
        public const string OEEXNM1 = "OEEXNM1";

        /// <summary>
        /// OEEXNM2.
        /// </summary>
        public const string OEEXNM2 = "OEEXNM2";

        /// <summary>
        /// OEEXNMP0.
        /// </summary>
        public const string OEEXNMP0 = "OEEXNMP0";

        /// <summary>
        /// OEEXNMP1.
        /// </summary>
        public const string OEEXNMP1 = "OEEXNMP1";

        /// <summary>
        /// OEEXNMP2.
        /// </summary>
        public const string OEEXNMP2 = "OEEXNMP2";

        /// <summary>
        /// OEEXDT0.
        /// </summary>
        public const string OEEXDT0 = "OEEXDT0";

        /// <summary>
        /// OEEXDT1.
        /// </summary>
        public const string OEEXDT1 = "OEEXDT1";

        /// <summary>
        /// OEEXDT2.
        /// </summary>
        public const string OEEXDT2 = "OEEXDT2";

        /// <summary>
        /// OESTSUDT.
        /// </summary>
        public const string OESTSUDT = "OESTSUDT";

        /// <summary>
        /// OEACTIND.
        /// </summary>
        public const string OEACTIND = "OEACTIND";

        /// <summary>
        /// OEUSER.
        /// </summary>
        public const string OEUSER = "OEUSER";

        /// <summary>
        /// OEPID.
        /// </summary>
        public const string OEPID = "OEPID";

        /// <summary>
        /// OEVID.
        /// </summary>
        public const string OEVID = "OEVID";

        /// <summary>
        /// OEMKEY.
        /// </summary>
        public const string OEMKEY = "OEMKEY";

        /// <summary>
        /// OEUDTTM.
        /// </summary>
        public const string OEUDTTM = "OEUDTTM";

        /// <summary>
        /// OESEQNU.
        /// </summary>
        public const string OESEQNU = "OESEQNU";

        /// <summary>
        /// OECOMMYN.
        /// </summary>
        public const string OECOMMYN = "OECOMMYN";

        /// <summary>
        /// OECO.
        /// </summary>
        public const string OECO = "OECO";

        /// <summary>
        /// OECMLN.
        /// </summary>
        public const string OECMLN = "OECMLN";

        /// <summary>
        /// OECUAN8.
        /// </summary>
        public const string OECUAN8 = "OECUAN8";

        /// <summary>
        /// OEEFFS.
        /// </summary>
        public const string OEEFFS = "OEEFFS";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB02E";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OEOPPID", "OEOPPID", JdeDataType.Numeric, null, true, true),
        new JdeField("OEEMAN8", "OEEMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("OEALPH", "OEALPH", JdeDataType.String, 80),
        new JdeField("OEPCNTG", "OEPCNTG", JdeDataType.Numeric),
        new JdeField("OEOWNFLG", "OEOWNFLG", JdeDataType.String, 2),
        new JdeField("OERTYPE", "OERTYPE", JdeDataType.String, 10),
        new JdeField("OESTMBDT", "OESTMBDT", JdeDataType.Date),
        new JdeField("OESTMEDT", "OESTMEDT", JdeDataType.Date),
        new JdeField("OEENTDBY", "OEENTDBY", JdeDataType.Numeric),
        new JdeField("OEEDATE", "OEEDATE", JdeDataType.Date),
        new JdeField("OEEXVAR0", "OEEXVAR0", JdeDataType.String, 510),
        new JdeField("OEEXVAR1", "OEEXVAR1", JdeDataType.String, 510),
        new JdeField("OEEXVAR4", "OEEXVAR4", JdeDataType.String, 100),
        new JdeField("OEEXVAR5", "OEEXVAR5", JdeDataType.String, 100),
        new JdeField("OEEXVAR6", "OEEXVAR6", JdeDataType.String, 100),
        new JdeField("OEEXVAR7", "OEEXVAR7", JdeDataType.String, 100),
        new JdeField("OEEXVAR12", "OEEXVAR12", JdeDataType.String, 50),
        new JdeField("OEEXVAR13", "OEEXVAR13", JdeDataType.String, 50),
        new JdeField("OEEXNM0", "OEEXNM0", JdeDataType.Numeric),
        new JdeField("OEEXNM1", "OEEXNM1", JdeDataType.Numeric),
        new JdeField("OEEXNM2", "OEEXNM2", JdeDataType.Numeric),
        new JdeField("OEEXNMP0", "OEEXNMP0", JdeDataType.Numeric),
        new JdeField("OEEXNMP1", "OEEXNMP1", JdeDataType.Numeric),
        new JdeField("OEEXNMP2", "OEEXNMP2", JdeDataType.Numeric),
        new JdeField("OEEXDT0", "OEEXDT0", JdeDataType.Date),
        new JdeField("OEEXDT1", "OEEXDT1", JdeDataType.Date),
        new JdeField("OEEXDT2", "OEEXDT2", JdeDataType.Date),
        new JdeField("OESTSUDT", "OESTSUDT", JdeDataType.Date),
        new JdeField("OEACTIND", "OEACTIND", JdeDataType.String, 2),
        new JdeField("OEUSER", "OEUSER", JdeDataType.String, 20),
        new JdeField("OEPID", "OEPID", JdeDataType.String, 20),
        new JdeField("OEVID", "OEVID", JdeDataType.String, 20),
        new JdeField("OEMKEY", "OEMKEY", JdeDataType.String, 30),
        new JdeField("OEUDTTM", "OEUDTTM", JdeDataType.Date),
        new JdeField("OESEQNU", "OESEQNU", JdeDataType.Numeric, null, true, true),
        new JdeField("OECOMMYN", "OECOMMYN", JdeDataType.String, 2),
        new JdeField("OECO", "OECO", JdeDataType.String, 10),
        new JdeField("OECMLN", "OECMLN", JdeDataType.Numeric),
        new JdeField("OECUAN8", "OECUAN8", JdeDataType.Numeric),
        new JdeField("OEEFFS", "OEEFFS", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB02E_0", "Primary Key on OEOPPID, OEEMAN8, OESEQNU", new[] { "OEOPPID", "OEEMAN8", "OESEQNU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CB02E_2", "Index on OEEMAN8, OEOPPID", new[] { "OEEMAN8", "OEOPPID" }),
        new JdeIndex("F90CB02E_3", "Index on OEOPPID", new[] { "OEOPPID" })
    };
}
