using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L950 - .
/// </summary>
public class FF30L950 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ODOPDFID.
        /// </summary>
        public const string ODOPDFID = "ODOPDFID";

        /// <summary>
        /// ODDFLNID.
        /// </summary>
        public const string ODDFLNID = "ODDFLNID";

        /// <summary>
        /// ODLNDSID.
        /// </summary>
        public const string ODLNDSID = "ODLNDSID";

        /// <summary>
        /// ODPROID.
        /// </summary>
        public const string ODPROID = "ODPROID";

        /// <summary>
        /// ODCELLID.
        /// </summary>
        public const string ODCELLID = "ODCELLID";

        /// <summary>
        /// ODDFMCU.
        /// </summary>
        public const string ODDFMCU = "ODDFMCU";

        /// <summary>
        /// ODDFITM.
        /// </summary>
        public const string ODDFITM = "ODDFITM";

        /// <summary>
        /// ODFSCID.
        /// </summary>
        public const string ODFSCID = "ODFSCID";

        /// <summary>
        /// ODSOEAT.
        /// </summary>
        public const string ODSOEAT = "ODSOEAT";

        /// <summary>
        /// ODOPINDX.
        /// </summary>
        public const string ODOPINDX = "ODOPINDX";

        /// <summary>
        /// ODTLPRC.
        /// </summary>
        public const string ODTLPRC = "ODTLPRC";

        /// <summary>
        /// ODBALTEC.
        /// </summary>
        public const string ODBALTEC = "ODBALTEC";

        /// <summary>
        /// ODDFEPH.
        /// </summary>
        public const string ODDFEPH = "ODDFEPH";

        /// <summary>
        /// ODLNTAKT.
        /// </summary>
        public const string ODLNTAKT = "ODLNTAKT";

        /// <summary>
        /// ODDFATWL.
        /// </summary>
        public const string ODDFATWL = "ODDFATWL";

        /// <summary>
        /// ODDFATWM.
        /// </summary>
        public const string ODDFATWM = "ODDFATWM";

        /// <summary>
        /// ODLDNOLA.
        /// </summary>
        public const string ODLDNOLA = "ODLDNOLA";

        /// <summary>
        /// ODLDNOMA.
        /// </summary>
        public const string ODLDNOMA = "ODLDNOMA";

        /// <summary>
        /// ODLDNOLD.
        /// </summary>
        public const string ODLDNOLD = "ODLDNOLD";

        /// <summary>
        /// ODLDNOMD.
        /// </summary>
        public const string ODLDNOMD = "ODLDNOMD";

        /// <summary>
        /// ODWCDS.
        /// </summary>
        public const string ODWCDS = "ODWCDS";

        /// <summary>
        /// ODODDTCA.
        /// </summary>
        public const string ODODDTCA = "ODODDTCA";

        /// <summary>
        /// ODODCALF.
        /// </summary>
        public const string ODODCALF = "ODODCALF";

        /// <summary>
        /// ODURCD.
        /// </summary>
        public const string ODURCD = "ODURCD";

        /// <summary>
        /// ODURDT.
        /// </summary>
        public const string ODURDT = "ODURDT";

        /// <summary>
        /// ODURAT.
        /// </summary>
        public const string ODURAT = "ODURAT";

        /// <summary>
        /// ODURAB.
        /// </summary>
        public const string ODURAB = "ODURAB";

        /// <summary>
        /// ODURRF.
        /// </summary>
        public const string ODURRF = "ODURRF";

        /// <summary>
        /// ODTORG.
        /// </summary>
        public const string ODTORG = "ODTORG";

        /// <summary>
        /// ODUSER.
        /// </summary>
        public const string ODUSER = "ODUSER";

        /// <summary>
        /// ODPID.
        /// </summary>
        public const string ODPID = "ODPID";

        /// <summary>
        /// ODMKEY.
        /// </summary>
        public const string ODMKEY = "ODMKEY";

        /// <summary>
        /// ODUUPMJ.
        /// </summary>
        public const string ODUUPMJ = "ODUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L950";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ODOPDFID", "ODOPDFID", JdeDataType.Numeric, null, true, true),
        new JdeField("ODDFLNID", "ODDFLNID", JdeDataType.Numeric),
        new JdeField("ODLNDSID", "ODLNDSID", JdeDataType.Numeric),
        new JdeField("ODPROID", "ODPROID", JdeDataType.Numeric),
        new JdeField("ODCELLID", "ODCELLID", JdeDataType.Numeric),
        new JdeField("ODDFMCU", "ODDFMCU", JdeDataType.String, 24),
        new JdeField("ODDFITM", "ODDFITM", JdeDataType.Numeric),
        new JdeField("ODFSCID", "ODFSCID", JdeDataType.Numeric),
        new JdeField("ODSOEAT", "ODSOEAT", JdeDataType.Numeric),
        new JdeField("ODOPINDX", "ODOPINDX", JdeDataType.Numeric),
        new JdeField("ODTLPRC", "ODTLPRC", JdeDataType.Numeric),
        new JdeField("ODBALTEC", "ODBALTEC", JdeDataType.String, 6),
        new JdeField("ODDFEPH", "ODDFEPH", JdeDataType.Numeric),
        new JdeField("ODLNTAKT", "ODLNTAKT", JdeDataType.Numeric),
        new JdeField("ODDFATWL", "ODDFATWL", JdeDataType.Numeric),
        new JdeField("ODDFATWM", "ODDFATWM", JdeDataType.Numeric),
        new JdeField("ODLDNOLA", "ODLDNOLA", JdeDataType.Numeric),
        new JdeField("ODLDNOMA", "ODLDNOMA", JdeDataType.Numeric),
        new JdeField("ODLDNOLD", "ODLDNOLD", JdeDataType.Numeric),
        new JdeField("ODLDNOMD", "ODLDNOMD", JdeDataType.Numeric),
        new JdeField("ODWCDS", "ODWCDS", JdeDataType.String, 6),
        new JdeField("ODODDTCA", "ODODDTCA", JdeDataType.Date),
        new JdeField("ODODCALF", "ODODCALF", JdeDataType.String, 4),
        new JdeField("ODURCD", "ODURCD", JdeDataType.String, 4),
        new JdeField("ODURDT", "ODURDT", JdeDataType.Numeric),
        new JdeField("ODURAT", "ODURAT", JdeDataType.Numeric),
        new JdeField("ODURAB", "ODURAB", JdeDataType.Numeric),
        new JdeField("ODURRF", "ODURRF", JdeDataType.String, 30),
        new JdeField("ODTORG", "ODTORG", JdeDataType.String, 20),
        new JdeField("ODUSER", "ODUSER", JdeDataType.String, 20),
        new JdeField("ODPID", "ODPID", JdeDataType.String, 20),
        new JdeField("ODMKEY", "ODMKEY", JdeDataType.String, 30),
        new JdeField("ODUUPMJ", "ODUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L950_0", "Primary Key on ODOPDFID", new[] { "ODOPDFID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L950_2", "Index on ODFSCID", new[] { "ODFSCID" }),
        new JdeIndex("FF30L950_3", "Index on ODDFLNID, ODLNDSID, ODPROID, ODCELLID, ODDFMCU, ODDFITM", new[] { "ODDFLNID", "ODLNDSID", "ODPROID", "ODCELLID", "ODDFMCU", "ODDFITM" }),
        new JdeIndex("FF30L950_4", "Index on ODPROID, ODDFMCU, ODDFITM, ODFSCID", new[] { "ODPROID", "ODDFMCU", "ODDFITM", "ODFSCID" })
    };
}
