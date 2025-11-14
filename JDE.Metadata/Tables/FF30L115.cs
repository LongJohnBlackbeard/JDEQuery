using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L115 - .
/// </summary>
public class FF30L115 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SESOEID.
        /// </summary>
        public const string SESOEID = "SESOEID";

        /// <summary>
        /// SESOELID.
        /// </summary>
        public const string SESOELID = "SESOELID";

        /// <summary>
        /// SEDFSEQ.
        /// </summary>
        public const string SEDFSEQ = "SEDFSEQ";

        /// <summary>
        /// SEOPSP.
        /// </summary>
        public const string SEOPSP = "SEOPSP";

        /// <summary>
        /// SEDFMCU.
        /// </summary>
        public const string SEDFMCU = "SEDFMCU";

        /// <summary>
        /// SEDFITM.
        /// </summary>
        public const string SEDFITM = "SEDFITM";

        /// <summary>
        /// SEPROID.
        /// </summary>
        public const string SEPROID = "SEPROID";

        /// <summary>
        /// SESSOEID.
        /// </summary>
        public const string SESSOEID = "SESSOEID";

        /// <summary>
        /// SERPITM.
        /// </summary>
        public const string SERPITM = "SERPITM";

        /// <summary>
        /// SEFSCID.
        /// </summary>
        public const string SEFSCID = "SEFSCID";

        /// <summary>
        /// SESTSKID.
        /// </summary>
        public const string SESTSKID = "SESTSKID";

        /// <summary>
        /// SERPQTY.
        /// </summary>
        public const string SERPQTY = "SERPQTY";

        /// <summary>
        /// SEINTEXT.
        /// </summary>
        public const string SEINTEXT = "SEINTEXT";

        /// <summary>
        /// SEFEFG.
        /// </summary>
        public const string SEFEFG = "SEFEFG";

        /// <summary>
        /// SEFDPID.
        /// </summary>
        public const string SEFDPID = "SEFDPID";

        /// <summary>
        /// SEFDITM.
        /// </summary>
        public const string SEFDITM = "SEFDITM";

        /// <summary>
        /// SEFDMCU.
        /// </summary>
        public const string SEFDMCU = "SEFDMCU";

        /// <summary>
        /// SECMCONS.
        /// </summary>
        public const string SECMCONS = "SECMCONS";

        /// <summary>
        /// SECMEFT.
        /// </summary>
        public const string SECMEFT = "SECMEFT";

        /// <summary>
        /// SESSOECMP.
        /// </summary>
        public const string SESSOECMP = "SESSOECMP";

        /// <summary>
        /// SEURCD.
        /// </summary>
        public const string SEURCD = "SEURCD";

        /// <summary>
        /// SEURDT.
        /// </summary>
        public const string SEURDT = "SEURDT";

        /// <summary>
        /// SEURAT.
        /// </summary>
        public const string SEURAT = "SEURAT";

        /// <summary>
        /// SEURAB.
        /// </summary>
        public const string SEURAB = "SEURAB";

        /// <summary>
        /// SEURRF.
        /// </summary>
        public const string SEURRF = "SEURRF";

        /// <summary>
        /// SETORG.
        /// </summary>
        public const string SETORG = "SETORG";

        /// <summary>
        /// SEUSER.
        /// </summary>
        public const string SEUSER = "SEUSER";

        /// <summary>
        /// SEPID.
        /// </summary>
        public const string SEPID = "SEPID";

        /// <summary>
        /// SEMKEY.
        /// </summary>
        public const string SEMKEY = "SEMKEY";

        /// <summary>
        /// SEUUPMJ.
        /// </summary>
        public const string SEUUPMJ = "SEUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L115";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SESOEID", "SESOEID", JdeDataType.Numeric, null, true, true),
        new JdeField("SESOELID", "SESOELID", JdeDataType.Numeric, null, true, true),
        new JdeField("SEDFSEQ", "SEDFSEQ", JdeDataType.Numeric),
        new JdeField("SEOPSP", "SEOPSP", JdeDataType.String, 4),
        new JdeField("SEDFMCU", "SEDFMCU", JdeDataType.String, 24),
        new JdeField("SEDFITM", "SEDFITM", JdeDataType.Numeric),
        new JdeField("SEPROID", "SEPROID", JdeDataType.Numeric),
        new JdeField("SESSOEID", "SESSOEID", JdeDataType.Numeric),
        new JdeField("SERPITM", "SERPITM", JdeDataType.Numeric),
        new JdeField("SEFSCID", "SEFSCID", JdeDataType.Numeric),
        new JdeField("SESTSKID", "SESTSKID", JdeDataType.Numeric),
        new JdeField("SERPQTY", "SERPQTY", JdeDataType.Numeric),
        new JdeField("SEINTEXT", "SEINTEXT", JdeDataType.String, 4),
        new JdeField("SEFEFG", "SEFEFG", JdeDataType.String, 20),
        new JdeField("SEFDPID", "SEFDPID", JdeDataType.Numeric),
        new JdeField("SEFDITM", "SEFDITM", JdeDataType.Numeric),
        new JdeField("SEFDMCU", "SEFDMCU", JdeDataType.String, 24),
        new JdeField("SECMCONS", "SECMCONS", JdeDataType.String, 4),
        new JdeField("SECMEFT", "SECMEFT", JdeDataType.Numeric),
        new JdeField("SESSOECMP", "SESSOECMP", JdeDataType.String, 4),
        new JdeField("SEURCD", "SEURCD", JdeDataType.String, 4),
        new JdeField("SEURDT", "SEURDT", JdeDataType.Numeric),
        new JdeField("SEURAT", "SEURAT", JdeDataType.Numeric),
        new JdeField("SEURAB", "SEURAB", JdeDataType.Numeric),
        new JdeField("SEURRF", "SEURRF", JdeDataType.String, 30),
        new JdeField("SETORG", "SETORG", JdeDataType.String, 20),
        new JdeField("SEUSER", "SEUSER", JdeDataType.String, 20),
        new JdeField("SEPID", "SEPID", JdeDataType.String, 20),
        new JdeField("SEMKEY", "SEMKEY", JdeDataType.String, 30),
        new JdeField("SEUUPMJ", "SEUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L115_0", "Primary Key on SESOEID, SESOELID", new[] { "SESOEID", "SESOELID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L115_2", "Index on SEFSCID, SEDFITM, SEDFMCU, SEPROID, SEDFSEQ", new[] { "SEFSCID", "SEDFITM", "SEDFMCU", "SEPROID", "SEDFSEQ" }),
        new JdeIndex("FF30L115_3", "Index on SESTSKID", new[] { "SESTSKID" }),
        new JdeIndex("FF30L115_4", "Index on SEFSCID, SERPITM, SEDFMCU, SEPROID, SESOELID", new[] { "SEFSCID", "SERPITM", "SEDFMCU", "SEPROID", "SESOELID" }),
        new JdeIndex("FF30L115_5", "Index on SESSOEID, SESOELID", new[] { "SESSOEID", "SESOELID" }),
        new JdeIndex("FF30L115_6", "Index on SEFSCID, SERPITM, SEDFMCU, SEPROID, SEDFITM", new[] { "SEFSCID", "SERPITM", "SEDFMCU", "SEPROID", "SEDFITM" }),
        new JdeIndex("FF30L115_7", "Index on SESSOEID, SESOEID", new[] { "SESSOEID", "SESOEID" }),
        new JdeIndex("FF30L115_8", "Index on SEFSCID, SEDFITM, SEDFMCU, SEPROID, SESOEID", new[] { "SEFSCID", "SEDFITM", "SEDFMCU", "SEPROID", "SESOEID" })
    };
}
