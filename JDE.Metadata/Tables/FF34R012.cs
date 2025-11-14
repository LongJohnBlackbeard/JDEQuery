using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF34R012 - .
/// </summary>
public class FF34R012 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RSRMSID.
        /// </summary>
        public const string RSRMSID = "RSRMSID";

        /// <summary>
        /// RSRMSD.
        /// </summary>
        public const string RSRMSD = "RSRMSD";

        /// <summary>
        /// RSRMED.
        /// </summary>
        public const string RSRMED = "RSRMED";

        /// <summary>
        /// RSRMSIMN.
        /// </summary>
        public const string RSRMSIMN = "RSRMSIMN";

        /// <summary>
        /// RSDFRCID.
        /// </summary>
        public const string RSDFRCID = "RSDFRCID";

        /// <summary>
        /// RSDFRCNAME.
        /// </summary>
        public const string RSDFRCNAME = "RSDFRCNAME";

        /// <summary>
        /// RSRMVOLS.
        /// </summary>
        public const string RSRMVOLS = "RSRMVOLS";

        /// <summary>
        /// RSFSCID.
        /// </summary>
        public const string RSFSCID = "RSFSCID";

        /// <summary>
        /// RSRMSDLR.
        /// </summary>
        public const string RSRMSDLR = "RSRMSDLR";

        /// <summary>
        /// RSDFLNID.
        /// </summary>
        public const string RSDFLNID = "RSDFLNID";

        /// <summary>
        /// RSDFLNNA.
        /// </summary>
        public const string RSDFLNNA = "RSDFLNNA";

        /// <summary>
        /// RSLNDSID.
        /// </summary>
        public const string RSLNDSID = "RSLNDSID";

        /// <summary>
        /// RSLNDSNA.
        /// </summary>
        public const string RSLNDSNA = "RSLNDSNA";

        /// <summary>
        /// RSUSER.
        /// </summary>
        public const string RSUSER = "RSUSER";

        /// <summary>
        /// RSMKEY.
        /// </summary>
        public const string RSMKEY = "RSMKEY";

        /// <summary>
        /// RSPID.
        /// </summary>
        public const string RSPID = "RSPID";

        /// <summary>
        /// RSUUPMJ.
        /// </summary>
        public const string RSUUPMJ = "RSUUPMJ";

        /// <summary>
        /// RSURCD.
        /// </summary>
        public const string RSURCD = "RSURCD";

        /// <summary>
        /// RSURDT.
        /// </summary>
        public const string RSURDT = "RSURDT";

        /// <summary>
        /// RSURAT.
        /// </summary>
        public const string RSURAT = "RSURAT";

        /// <summary>
        /// RSURAB.
        /// </summary>
        public const string RSURAB = "RSURAB";

        /// <summary>
        /// RSURRF.
        /// </summary>
        public const string RSURRF = "RSURRF";

        /// <summary>
        /// RSRSIMEF.
        /// </summary>
        public const string RSRSIMEF = "RSRSIMEF";
    }

    /// <inheritdoc />
    public override string TableName => "FF34R012";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RSRMSID", "RSRMSID", JdeDataType.Numeric, null, true, true),
        new JdeField("RSRMSD", "RSRMSD", JdeDataType.Numeric),
        new JdeField("RSRMED", "RSRMED", JdeDataType.Numeric),
        new JdeField("RSRMSIMN", "RSRMSIMN", JdeDataType.String, 104),
        new JdeField("RSDFRCID", "RSDFRCID", JdeDataType.Numeric),
        new JdeField("RSDFRCNAME", "RSDFRCNAME", JdeDataType.String, 60),
        new JdeField("RSRMVOLS", "RSRMVOLS", JdeDataType.Numeric),
        new JdeField("RSFSCID", "RSFSCID", JdeDataType.Numeric),
        new JdeField("RSRMSDLR", "RSRMSDLR", JdeDataType.Date),
        new JdeField("RSDFLNID", "RSDFLNID", JdeDataType.Numeric),
        new JdeField("RSDFLNNA", "RSDFLNNA", JdeDataType.String, 60),
        new JdeField("RSLNDSID", "RSLNDSID", JdeDataType.Numeric),
        new JdeField("RSLNDSNA", "RSLNDSNA", JdeDataType.String, 60),
        new JdeField("RSUSER", "RSUSER", JdeDataType.String, 20),
        new JdeField("RSMKEY", "RSMKEY", JdeDataType.String, 30),
        new JdeField("RSPID", "RSPID", JdeDataType.String, 20),
        new JdeField("RSUUPMJ", "RSUUPMJ", JdeDataType.Date),
        new JdeField("RSURCD", "RSURCD", JdeDataType.String, 4),
        new JdeField("RSURDT", "RSURDT", JdeDataType.Numeric),
        new JdeField("RSURAT", "RSURAT", JdeDataType.Numeric),
        new JdeField("RSURAB", "RSURAB", JdeDataType.Numeric),
        new JdeField("RSURRF", "RSURRF", JdeDataType.String, 30),
        new JdeField("RSRSIMEF", "RSRSIMEF", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF34R012_0", "Primary Key on RSRMSID", new[] { "RSRMSID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF34R012_2", "Index on RSFSCID, RSRMSIMN", new[] { "RSFSCID", "RSRMSIMN" })
    };
}
