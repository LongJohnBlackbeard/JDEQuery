using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L801 - .
/// </summary>
public class FF30L801 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDDFDOCO.
        /// </summary>
        public const string SDDFDOCO = "SDDFDOCO";

        /// <summary>
        /// SDDFKCOO.
        /// </summary>
        public const string SDDFKCOO = "SDDFKCOO";

        /// <summary>
        /// SDDCTO.
        /// </summary>
        public const string SDDCTO = "SDDCTO";

        /// <summary>
        /// SDFSCID.
        /// </summary>
        public const string SDFSCID = "SDFSCID";

        /// <summary>
        /// SDLNID.
        /// </summary>
        public const string SDLNID = "SDLNID";

        /// <summary>
        /// SDCUSN.
        /// </summary>
        public const string SDCUSN = "SDCUSN";

        /// <summary>
        /// SDDFCO.
        /// </summary>
        public const string SDDFCO = "SDDFCO";

        /// <summary>
        /// SDDSC1.
        /// </summary>
        public const string SDDSC1 = "SDDSC1";

        /// <summary>
        /// SDUM.
        /// </summary>
        public const string SDUM = "SDUM";

        /// <summary>
        /// SDDFITM.
        /// </summary>
        public const string SDDFITM = "SDDFITM";

        /// <summary>
        /// SDDFMCU.
        /// </summary>
        public const string SDDFMCU = "SDDFMCU";

        /// <summary>
        /// SDDFNXTR.
        /// </summary>
        public const string SDDFNXTR = "SDDFNXTR";

        /// <summary>
        /// SDUDRQJ.
        /// </summary>
        public const string SDUDRQJ = "SDUDRQJ";

        /// <summary>
        /// SDUPDDJ.
        /// </summary>
        public const string SDUPDDJ = "SDUPDDJ";

        /// <summary>
        /// SDUPPDJ.
        /// </summary>
        public const string SDUPPDJ = "SDUPPDJ";

        /// <summary>
        /// SDUCNDJ.
        /// </summary>
        public const string SDUCNDJ = "SDUCNDJ";

        /// <summary>
        /// SDDFUORG.
        /// </summary>
        public const string SDDFUORG = "SDDFUORG";

        /// <summary>
        /// SDDFUPQT.
        /// </summary>
        public const string SDDFUPQT = "SDDFUPQT";

        /// <summary>
        /// SDDFUSQT.
        /// </summary>
        public const string SDDFUSQT = "SDDFUSQT";

        /// <summary>
        /// SDDFUCQT.
        /// </summary>
        public const string SDDFUCQT = "SDDFUCQT";

        /// <summary>
        /// SDDFUOQT.
        /// </summary>
        public const string SDDFUOQT = "SDDFUOQT";

        /// <summary>
        /// SDURSD.
        /// </summary>
        public const string SDURSD = "SDURSD";

        /// <summary>
        /// SDURCCD.
        /// </summary>
        public const string SDURCCD = "SDURCCD";

        /// <summary>
        /// SDDFPRIO.
        /// </summary>
        public const string SDDFPRIO = "SDDFPRIO";

        /// <summary>
        /// SDAPTS.
        /// </summary>
        public const string SDAPTS = "SDAPTS";

        /// <summary>
        /// SDDFRORN.
        /// </summary>
        public const string SDDFRORN = "SDDFRORN";

        /// <summary>
        /// SDDFRCTO.
        /// </summary>
        public const string SDDFRCTO = "SDDFRCTO";

        /// <summary>
        /// SDURCD.
        /// </summary>
        public const string SDURCD = "SDURCD";

        /// <summary>
        /// SDURDT.
        /// </summary>
        public const string SDURDT = "SDURDT";

        /// <summary>
        /// SDURAT.
        /// </summary>
        public const string SDURAT = "SDURAT";

        /// <summary>
        /// SDURAB.
        /// </summary>
        public const string SDURAB = "SDURAB";

        /// <summary>
        /// SDURRF.
        /// </summary>
        public const string SDURRF = "SDURRF";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDMKEY.
        /// </summary>
        public const string SDMKEY = "SDMKEY";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDUUPMJ.
        /// </summary>
        public const string SDUUPMJ = "SDUUPMJ";

        /// <summary>
        /// SDDFLNIDP.
        /// </summary>
        public const string SDDFLNIDP = "SDDFLNIDP";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L801";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDDFDOCO", "SDDFDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SDDFKCOO", "SDDFKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SDDCTO", "SDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SDFSCID", "SDFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("SDLNID", "SDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SDCUSN", "SDCUSN", JdeDataType.Numeric),
        new JdeField("SDDFCO", "SDDFCO", JdeDataType.String, 10),
        new JdeField("SDDSC1", "SDDSC1", JdeDataType.String, 60),
        new JdeField("SDUM", "SDUM", JdeDataType.String, 4),
        new JdeField("SDDFITM", "SDDFITM", JdeDataType.Numeric),
        new JdeField("SDDFMCU", "SDDFMCU", JdeDataType.String, 24),
        new JdeField("SDDFNXTR", "SDDFNXTR", JdeDataType.String, 6),
        new JdeField("SDUDRQJ", "SDUDRQJ", JdeDataType.Date),
        new JdeField("SDUPDDJ", "SDUPDDJ", JdeDataType.Date),
        new JdeField("SDUPPDJ", "SDUPPDJ", JdeDataType.Date),
        new JdeField("SDUCNDJ", "SDUCNDJ", JdeDataType.Date),
        new JdeField("SDDFUORG", "SDDFUORG", JdeDataType.Numeric),
        new JdeField("SDDFUPQT", "SDDFUPQT", JdeDataType.Numeric),
        new JdeField("SDDFUSQT", "SDDFUSQT", JdeDataType.Numeric),
        new JdeField("SDDFUCQT", "SDDFUCQT", JdeDataType.Numeric),
        new JdeField("SDDFUOQT", "SDDFUOQT", JdeDataType.Numeric),
        new JdeField("SDURSD", "SDURSD", JdeDataType.Date),
        new JdeField("SDURCCD", "SDURCCD", JdeDataType.Date),
        new JdeField("SDDFPRIO", "SDDFPRIO", JdeDataType.String, 2),
        new JdeField("SDAPTS", "SDAPTS", JdeDataType.String, 2),
        new JdeField("SDDFRORN", "SDDFRORN", JdeDataType.String, 16),
        new JdeField("SDDFRCTO", "SDDFRCTO", JdeDataType.String, 4),
        new JdeField("SDURCD", "SDURCD", JdeDataType.String, 4),
        new JdeField("SDURDT", "SDURDT", JdeDataType.Numeric),
        new JdeField("SDURAT", "SDURAT", JdeDataType.Numeric),
        new JdeField("SDURAB", "SDURAB", JdeDataType.Numeric),
        new JdeField("SDURRF", "SDURRF", JdeDataType.String, 30),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDMKEY", "SDMKEY", JdeDataType.String, 30),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDUUPMJ", "SDUUPMJ", JdeDataType.Date),
        new JdeField("SDDFLNIDP", "SDDFLNIDP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L801_0", "Primary Key on SDDFDOCO, SDDFKCOO, SDDCTO, SDFSCID, SDLNID", new[] { "SDDFDOCO", "SDDFKCOO", "SDDCTO", "SDFSCID", "SDLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L801_2", "Index on SDFSCID", new[] { "SDFSCID" }),
        new JdeIndex("FF30L801_3", "Index on SDFSCID, SDDFITM, SDDFMCU", new[] { "SDFSCID", "SDDFITM", "SDDFMCU" }),
        new JdeIndex("FF30L801_4", "Index on SDFSCID, SDCUSN", new[] { "SDFSCID", "SDCUSN" })
    };
}
