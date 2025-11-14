using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G103 - .
/// </summary>
public class F40G103 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IUGRECID.
        /// </summary>
        public const string IUGRECID = "IUGRECID";

        /// <summary>
        /// IUTYPEHB.
        /// </summary>
        public const string IUTYPEHB = "IUTYPEHB";

        /// <summary>
        /// IULNID.
        /// </summary>
        public const string IULNID = "IULNID";

        /// <summary>
        /// IUEURID.
        /// </summary>
        public const string IUEURID = "IUEURID";

        /// <summary>
        /// IUEURSCD.
        /// </summary>
        public const string IUEURSCD = "IUEURSCD";

        /// <summary>
        /// IUBRAND.
        /// </summary>
        public const string IUBRAND = "IUBRAND";

        /// <summary>
        /// IUTYPEBF.
        /// </summary>
        public const string IUTYPEBF = "IUTYPEBF";

        /// <summary>
        /// IUEURBAL.
        /// </summary>
        public const string IUEURBAL = "IUEURBAL";

        /// <summary>
        /// IUEURPRTY.
        /// </summary>
        public const string IUEURPRTY = "IUEURPRTY";

        /// <summary>
        /// IUEURFIXED.
        /// </summary>
        public const string IUEURFIXED = "IUEURFIXED";

        /// <summary>
        /// IURECQTY.
        /// </summary>
        public const string IURECQTY = "IURECQTY";

        /// <summary>
        /// IUUOM.
        /// </summary>
        public const string IUUOM = "IUUOM";

        /// <summary>
        /// IUSITEC.
        /// </summary>
        public const string IUSITEC = "IUSITEC";

        /// <summary>
        /// IUSITEP.
        /// </summary>
        public const string IUSITEP = "IUSITEP";

        /// <summary>
        /// IUURCD.
        /// </summary>
        public const string IUURCD = "IUURCD";

        /// <summary>
        /// IUURDT.
        /// </summary>
        public const string IUURDT = "IUURDT";

        /// <summary>
        /// IUURRF.
        /// </summary>
        public const string IUURRF = "IUURRF";

        /// <summary>
        /// IUURAT.
        /// </summary>
        public const string IUURAT = "IUURAT";

        /// <summary>
        /// IUURAB.
        /// </summary>
        public const string IUURAB = "IUURAB";

        /// <summary>
        /// IUPID.
        /// </summary>
        public const string IUPID = "IUPID";

        /// <summary>
        /// IUTORG.
        /// </summary>
        public const string IUTORG = "IUTORG";

        /// <summary>
        /// IUUSER.
        /// </summary>
        public const string IUUSER = "IUUSER";

        /// <summary>
        /// IUJOBN.
        /// </summary>
        public const string IUJOBN = "IUJOBN";

        /// <summary>
        /// IUUUPMJ.
        /// </summary>
        public const string IUUUPMJ = "IUUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40G103";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IUGRECID", "IUGRECID", JdeDataType.Numeric, null, true, true),
        new JdeField("IUTYPEHB", "IUTYPEHB", JdeDataType.String, 2, true, true),
        new JdeField("IULNID", "IULNID", JdeDataType.Numeric, null, true, true),
        new JdeField("IUEURID", "IUEURID", JdeDataType.Numeric),
        new JdeField("IUEURSCD", "IUEURSCD", JdeDataType.String, 20),
        new JdeField("IUBRAND", "IUBRAND", JdeDataType.String, 20),
        new JdeField("IUTYPEBF", "IUTYPEBF", JdeDataType.String, 2),
        new JdeField("IUEURBAL", "IUEURBAL", JdeDataType.Numeric),
        new JdeField("IUEURPRTY", "IUEURPRTY", JdeDataType.Numeric),
        new JdeField("IUEURFIXED", "IUEURFIXED", JdeDataType.Numeric),
        new JdeField("IURECQTY", "IURECQTY", JdeDataType.Numeric),
        new JdeField("IUUOM", "IUUOM", JdeDataType.String, 4),
        new JdeField("IUSITEC", "IUSITEC", JdeDataType.String, 24),
        new JdeField("IUSITEP", "IUSITEP", JdeDataType.String, 24),
        new JdeField("IUURCD", "IUURCD", JdeDataType.String, 4),
        new JdeField("IUURDT", "IUURDT", JdeDataType.Numeric),
        new JdeField("IUURRF", "IUURRF", JdeDataType.String, 30),
        new JdeField("IUURAT", "IUURAT", JdeDataType.Numeric),
        new JdeField("IUURAB", "IUURAB", JdeDataType.Numeric),
        new JdeField("IUPID", "IUPID", JdeDataType.String, 20),
        new JdeField("IUTORG", "IUTORG", JdeDataType.String, 20),
        new JdeField("IUUSER", "IUUSER", JdeDataType.String, 20),
        new JdeField("IUJOBN", "IUJOBN", JdeDataType.String, 20),
        new JdeField("IUUUPMJ", "IUUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G103_0", "Primary Key on IUTYPEHB, IUGRECID, IULNID", new[] { "IUTYPEHB", "IUGRECID", "IULNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40G103_2", "Index on IUTYPEHB, IUGRECID, IUTYPEBF, IUEURPRTY, IULNID", new[] { "IUTYPEHB", "IUGRECID", "IUTYPEBF", "IUEURPRTY", "IULNID" })
    };
}
