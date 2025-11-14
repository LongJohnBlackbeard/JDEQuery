using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G042 - .
/// </summary>
public class F40G042 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SEITM.
        /// </summary>
        public const string SEITM = "SEITM";

        /// <summary>
        /// SEMCU.
        /// </summary>
        public const string SEMCU = "SEMCU";

        /// <summary>
        /// SEEURID.
        /// </summary>
        public const string SEEURID = "SEEURID";

        /// <summary>
        /// SELITM.
        /// </summary>
        public const string SELITM = "SELITM";

        /// <summary>
        /// SEEURSCD2.
        /// </summary>
        public const string SEEURSCD2 = "SEEURSCD2";

        /// <summary>
        /// SEWOPRC.
        /// </summary>
        public const string SEWOPRC = "SEWOPRC";

        /// <summary>
        /// SEGRASDE1.
        /// </summary>
        public const string SEGRASDE1 = "SEGRASDE1";

        /// <summary>
        /// SEGREXPDE1.
        /// </summary>
        public const string SEGREXPDE1 = "SEGREXPDE1";

        /// <summary>
        /// SEURCD.
        /// </summary>
        public const string SEURCD = "SEURCD";

        /// <summary>
        /// SEURDT.
        /// </summary>
        public const string SEURDT = "SEURDT";

        /// <summary>
        /// SEURRF.
        /// </summary>
        public const string SEURRF = "SEURRF";

        /// <summary>
        /// SEURAT.
        /// </summary>
        public const string SEURAT = "SEURAT";

        /// <summary>
        /// SEURAB.
        /// </summary>
        public const string SEURAB = "SEURAB";

        /// <summary>
        /// SEUUPMJ.
        /// </summary>
        public const string SEUUPMJ = "SEUUPMJ";

        /// <summary>
        /// SEPID.
        /// </summary>
        public const string SEPID = "SEPID";

        /// <summary>
        /// SEJOBN.
        /// </summary>
        public const string SEJOBN = "SEJOBN";

        /// <summary>
        /// SEUSER.
        /// </summary>
        public const string SEUSER = "SEUSER";

        /// <summary>
        /// SETORG.
        /// </summary>
        public const string SETORG = "SETORG";
    }

    /// <inheritdoc />
    public override string TableName => "F40G042";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SEITM", "SEITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SEMCU", "SEMCU", JdeDataType.String, 24, true, true),
        new JdeField("SEEURID", "SEEURID", JdeDataType.Numeric, null, true, true),
        new JdeField("SELITM", "SELITM", JdeDataType.String, 50),
        new JdeField("SEEURSCD2", "SEEURSCD2", JdeDataType.String, 20),
        new JdeField("SEWOPRC", "SEWOPRC", JdeDataType.String, 60),
        new JdeField("SEGRASDE1", "SEGRASDE1", JdeDataType.Date),
        new JdeField("SEGREXPDE1", "SEGREXPDE1", JdeDataType.Date),
        new JdeField("SEURCD", "SEURCD", JdeDataType.String, 4),
        new JdeField("SEURDT", "SEURDT", JdeDataType.Numeric),
        new JdeField("SEURRF", "SEURRF", JdeDataType.String, 30),
        new JdeField("SEURAT", "SEURAT", JdeDataType.Numeric),
        new JdeField("SEURAB", "SEURAB", JdeDataType.Numeric),
        new JdeField("SEUUPMJ", "SEUUPMJ", JdeDataType.Date),
        new JdeField("SEPID", "SEPID", JdeDataType.String, 20),
        new JdeField("SEJOBN", "SEJOBN", JdeDataType.String, 20),
        new JdeField("SEUSER", "SEUSER", JdeDataType.String, 20),
        new JdeField("SETORG", "SETORG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G042_0", "Primary Key on SEITM, SEMCU, SEEURID", new[] { "SEITM", "SEMCU", "SEEURID" }, isUnique: true, isPrimaryKey: true)
    };
}
