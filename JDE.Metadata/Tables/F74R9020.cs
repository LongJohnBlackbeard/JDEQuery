using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R9020 - .
/// </summary>
public class F74R9020 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SER74REPN.
        /// </summary>
        public const string SER74REPN = "SER74REPN";

        /// <summary>
        /// SER74REPT.
        /// </summary>
        public const string SER74REPT = "SER74REPT";

        /// <summary>
        /// SER74ACCT.
        /// </summary>
        public const string SER74ACCT = "SER74ACCT";

        /// <summary>
        /// SEURAB.
        /// </summary>
        public const string SEURAB = "SEURAB";

        /// <summary>
        /// SEURAT.
        /// </summary>
        public const string SEURAT = "SEURAT";

        /// <summary>
        /// SEURDT.
        /// </summary>
        public const string SEURDT = "SEURDT";

        /// <summary>
        /// SEURCD.
        /// </summary>
        public const string SEURCD = "SEURCD";

        /// <summary>
        /// SEURRF.
        /// </summary>
        public const string SEURRF = "SEURRF";

        /// <summary>
        /// SEUSER.
        /// </summary>
        public const string SEUSER = "SEUSER";

        /// <summary>
        /// SEPID.
        /// </summary>
        public const string SEPID = "SEPID";

        /// <summary>
        /// SEJOBN.
        /// </summary>
        public const string SEJOBN = "SEJOBN";

        /// <summary>
        /// SEUPMJ.
        /// </summary>
        public const string SEUPMJ = "SEUPMJ";

        /// <summary>
        /// SEUPMT.
        /// </summary>
        public const string SEUPMT = "SEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R9020";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SER74REPN", "SER74REPN", JdeDataType.String, 40, true, true),
        new JdeField("SER74REPT", "SER74REPT", JdeDataType.String, 4),
        new JdeField("SER74ACCT", "SER74ACCT", JdeDataType.String, 4),
        new JdeField("SEURAB", "SEURAB", JdeDataType.Numeric),
        new JdeField("SEURAT", "SEURAT", JdeDataType.Numeric),
        new JdeField("SEURDT", "SEURDT", JdeDataType.Numeric),
        new JdeField("SEURCD", "SEURCD", JdeDataType.String, 4),
        new JdeField("SEURRF", "SEURRF", JdeDataType.String, 30),
        new JdeField("SEUSER", "SEUSER", JdeDataType.String, 20),
        new JdeField("SEPID", "SEPID", JdeDataType.String, 20),
        new JdeField("SEJOBN", "SEJOBN", JdeDataType.String, 20),
        new JdeField("SEUPMJ", "SEUPMJ", JdeDataType.Numeric),
        new JdeField("SEUPMT", "SEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R9020_0", "Primary Key on SER74REPN", new[] { "SER74REPN" }, isUnique: true, isPrimaryKey: true)
    };
}
