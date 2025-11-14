using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L117 - .
/// </summary>
public class FF30L117 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ESESTID.
        /// </summary>
        public const string ESESTID = "ESESTID";

        /// <summary>
        /// ESFSCID.
        /// </summary>
        public const string ESFSCID = "ESFSCID";

        /// <summary>
        /// ESSSOEID.
        /// </summary>
        public const string ESSSOEID = "ESSSOEID";

        /// <summary>
        /// ESSOEID.
        /// </summary>
        public const string ESSOEID = "ESSOEID";

        /// <summary>
        /// ESDFITM.
        /// </summary>
        public const string ESDFITM = "ESDFITM";

        /// <summary>
        /// ESDFMCU.
        /// </summary>
        public const string ESDFMCU = "ESDFMCU";

        /// <summary>
        /// ESPROID.
        /// </summary>
        public const string ESPROID = "ESPROID";

        /// <summary>
        /// ESETLT.
        /// </summary>
        public const string ESETLT = "ESETLT";

        /// <summary>
        /// ESETMT.
        /// </summary>
        public const string ESETMT = "ESETMT";

        /// <summary>
        /// ESETOTF.
        /// </summary>
        public const string ESETOTF = "ESETOTF";

        /// <summary>
        /// ESTIMEUOM.
        /// </summary>
        public const string ESTIMEUOM = "ESTIMEUOM";

        /// <summary>
        /// ESURCD.
        /// </summary>
        public const string ESURCD = "ESURCD";

        /// <summary>
        /// ESURDT.
        /// </summary>
        public const string ESURDT = "ESURDT";

        /// <summary>
        /// ESURAT.
        /// </summary>
        public const string ESURAT = "ESURAT";

        /// <summary>
        /// ESURAB.
        /// </summary>
        public const string ESURAB = "ESURAB";

        /// <summary>
        /// ESURRF.
        /// </summary>
        public const string ESURRF = "ESURRF";

        /// <summary>
        /// ESUSER.
        /// </summary>
        public const string ESUSER = "ESUSER";

        /// <summary>
        /// ESPID.
        /// </summary>
        public const string ESPID = "ESPID";

        /// <summary>
        /// ESMKEY.
        /// </summary>
        public const string ESMKEY = "ESMKEY";

        /// <summary>
        /// ESUUPMJ.
        /// </summary>
        public const string ESUUPMJ = "ESUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L117";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ESESTID", "ESESTID", JdeDataType.Numeric, null, true, true),
        new JdeField("ESFSCID", "ESFSCID", JdeDataType.Numeric),
        new JdeField("ESSSOEID", "ESSSOEID", JdeDataType.Numeric),
        new JdeField("ESSOEID", "ESSOEID", JdeDataType.Numeric),
        new JdeField("ESDFITM", "ESDFITM", JdeDataType.Numeric),
        new JdeField("ESDFMCU", "ESDFMCU", JdeDataType.String, 24),
        new JdeField("ESPROID", "ESPROID", JdeDataType.Numeric),
        new JdeField("ESETLT", "ESETLT", JdeDataType.Numeric),
        new JdeField("ESETMT", "ESETMT", JdeDataType.Numeric),
        new JdeField("ESETOTF", "ESETOTF", JdeDataType.Numeric),
        new JdeField("ESTIMEUOM", "ESTIMEUOM", JdeDataType.String, 2),
        new JdeField("ESURCD", "ESURCD", JdeDataType.String, 4),
        new JdeField("ESURDT", "ESURDT", JdeDataType.Numeric),
        new JdeField("ESURAT", "ESURAT", JdeDataType.Numeric),
        new JdeField("ESURAB", "ESURAB", JdeDataType.Numeric),
        new JdeField("ESURRF", "ESURRF", JdeDataType.String, 30),
        new JdeField("ESUSER", "ESUSER", JdeDataType.String, 20),
        new JdeField("ESPID", "ESPID", JdeDataType.String, 20),
        new JdeField("ESMKEY", "ESMKEY", JdeDataType.String, 30),
        new JdeField("ESUUPMJ", "ESUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L117_0", "Primary Key on ESESTID", new[] { "ESESTID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L117_2", "Index on ESFSCID, ESSSOEID", new[] { "ESFSCID", "ESSSOEID" }),
        new JdeIndex("FF30L117_3", "Index on ESFSCID, ESSOEID", new[] { "ESFSCID", "ESSOEID" }),
        new JdeIndex("FF30L117_4", "Index on ESFSCID, ESDFITM, ESDFMCU, ESPROID", new[] { "ESFSCID", "ESDFITM", "ESDFMCU", "ESPROID" })
    };
}
