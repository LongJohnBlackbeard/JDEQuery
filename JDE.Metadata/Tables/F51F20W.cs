using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51F20W - .
/// </summary>
public class F51F20W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PA51FFID.
        /// </summary>
        public const string PA51FFID = "PA51FFID";

        /// <summary>
        /// PAAID.
        /// </summary>
        public const string PAAID = "PAAID";

        /// <summary>
        /// PAMCU.
        /// </summary>
        public const string PAMCU = "PAMCU";

        /// <summary>
        /// PAOBJ.
        /// </summary>
        public const string PAOBJ = "PAOBJ";

        /// <summary>
        /// PASUB.
        /// </summary>
        public const string PASUB = "PASUB";

        /// <summary>
        /// PACCT.
        /// </summary>
        public const string PACCT = "PACCT";

        /// <summary>
        /// PA51FBLTOT.
        /// </summary>
        public const string PA51FBLTOT = "PA51FBLTOT";

        /// <summary>
        /// PA51FBLNET.
        /// </summary>
        public const string PA51FBLNET = "PA51FBLNET";

        /// <summary>
        /// PA51FBLTAX.
        /// </summary>
        public const string PA51FBLTAX = "PA51FBLTAX";

        /// <summary>
        /// PA51FUNTOT.
        /// </summary>
        public const string PA51FUNTOT = "PA51FUNTOT";

        /// <summary>
        /// PA51FUNNET.
        /// </summary>
        public const string PA51FUNNET = "PA51FUNNET";

        /// <summary>
        /// PA51FUNTAX.
        /// </summary>
        public const string PA51FUNTAX = "PA51FUNTAX";

        /// <summary>
        /// PA51FRECD.
        /// </summary>
        public const string PA51FRECD = "PA51FRECD";

        /// <summary>
        /// PA51FRETN.
        /// </summary>
        public const string PA51FRETN = "PA51FRETN";

        /// <summary>
        /// PA51FTOTA1.
        /// </summary>
        public const string PA51FTOTA1 = "PA51FTOTA1";

        /// <summary>
        /// PA51FTOTU1.
        /// </summary>
        public const string PA51FTOTU1 = "PA51FTOTU1";

        /// <summary>
        /// PA51FCTCR.
        /// </summary>
        public const string PA51FCTCR = "PA51FCTCR";

        /// <summary>
        /// PA51FTWU.
        /// </summary>
        public const string PA51FTWU = "PA51FTWU";

        /// <summary>
        /// PAUKID.
        /// </summary>
        public const string PAUKID = "PAUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F51F20W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PA51FFID", "PA51FFID", JdeDataType.Numeric, null, true, true),
        new JdeField("PAAID", "PAAID", JdeDataType.String, 16, true, true),
        new JdeField("PAMCU", "PAMCU", JdeDataType.String, 24),
        new JdeField("PAOBJ", "PAOBJ", JdeDataType.String, 12),
        new JdeField("PASUB", "PASUB", JdeDataType.String, 16),
        new JdeField("PACCT", "PACCT", JdeDataType.String, 2),
        new JdeField("PA51FBLTOT", "PA51FBLTOT", JdeDataType.Numeric),
        new JdeField("PA51FBLNET", "PA51FBLNET", JdeDataType.Numeric),
        new JdeField("PA51FBLTAX", "PA51FBLTAX", JdeDataType.Numeric),
        new JdeField("PA51FUNTOT", "PA51FUNTOT", JdeDataType.Numeric),
        new JdeField("PA51FUNNET", "PA51FUNNET", JdeDataType.Numeric),
        new JdeField("PA51FUNTAX", "PA51FUNTAX", JdeDataType.Numeric),
        new JdeField("PA51FRECD", "PA51FRECD", JdeDataType.Numeric),
        new JdeField("PA51FRETN", "PA51FRETN", JdeDataType.Numeric),
        new JdeField("PA51FTOTA1", "PA51FTOTA1", JdeDataType.Numeric),
        new JdeField("PA51FTOTU1", "PA51FTOTU1", JdeDataType.Numeric),
        new JdeField("PA51FCTCR", "PA51FCTCR", JdeDataType.Numeric),
        new JdeField("PA51FTWU", "PA51FTWU", JdeDataType.Numeric),
        new JdeField("PAUKID", "PAUKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51F20W_0", "Primary Key on PAUKID, PA51FFID, PAAID", new[] { "PAUKID", "PA51FFID", "PAAID" }, isUnique: true, isPrimaryKey: true)
    };
}
