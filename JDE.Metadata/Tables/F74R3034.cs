using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R3034 - .
/// </summary>
public class F74R3034 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UMUOM.
        /// </summary>
        public const string UMUOM = "UMUOM";

        /// <summary>
        /// UMR74DCD.
        /// </summary>
        public const string UMR74DCD = "UMR74DCD";

        /// <summary>
        /// UMR74DCN.
        /// </summary>
        public const string UMR74DCN = "UMR74DCN";

        /// <summary>
        /// UMR74CDNA.
        /// </summary>
        public const string UMR74CDNA = "UMR74CDNA";

        /// <summary>
        /// UMR74CDIN.
        /// </summary>
        public const string UMR74CDIN = "UMR74CDIN";

        /// <summary>
        /// UMR74SYIN.
        /// </summary>
        public const string UMR74SYIN = "UMR74SYIN";

        /// <summary>
        /// UMR74DCDN.
        /// </summary>
        public const string UMR74DCDN = "UMR74DCDN";

        /// <summary>
        /// UMUSER.
        /// </summary>
        public const string UMUSER = "UMUSER";

        /// <summary>
        /// UMPID.
        /// </summary>
        public const string UMPID = "UMPID";

        /// <summary>
        /// UMJOBN.
        /// </summary>
        public const string UMJOBN = "UMJOBN";

        /// <summary>
        /// UMUPMT.
        /// </summary>
        public const string UMUPMT = "UMUPMT";

        /// <summary>
        /// UMUPMJ.
        /// </summary>
        public const string UMUPMJ = "UMUPMJ";

        /// <summary>
        /// UMURCD.
        /// </summary>
        public const string UMURCD = "UMURCD";

        /// <summary>
        /// UMURDT.
        /// </summary>
        public const string UMURDT = "UMURDT";

        /// <summary>
        /// UMURAT.
        /// </summary>
        public const string UMURAT = "UMURAT";

        /// <summary>
        /// UMURAB.
        /// </summary>
        public const string UMURAB = "UMURAB";

        /// <summary>
        /// UMURRF.
        /// </summary>
        public const string UMURRF = "UMURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F74R3034";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UMUOM", "UMUOM", JdeDataType.String, 4, true, true),
        new JdeField("UMR74DCD", "UMR74DCD", JdeDataType.String, 6),
        new JdeField("UMR74DCN", "UMR74DCN", JdeDataType.String, 200),
        new JdeField("UMR74CDNA", "UMR74CDNA", JdeDataType.String, 20),
        new JdeField("UMR74CDIN", "UMR74CDIN", JdeDataType.String, 20),
        new JdeField("UMR74SYIN", "UMR74SYIN", JdeDataType.String, 20),
        new JdeField("UMR74DCDN", "UMR74DCDN", JdeDataType.String, 20),
        new JdeField("UMUSER", "UMUSER", JdeDataType.String, 20),
        new JdeField("UMPID", "UMPID", JdeDataType.String, 20),
        new JdeField("UMJOBN", "UMJOBN", JdeDataType.String, 20),
        new JdeField("UMUPMT", "UMUPMT", JdeDataType.Numeric),
        new JdeField("UMUPMJ", "UMUPMJ", JdeDataType.Numeric),
        new JdeField("UMURCD", "UMURCD", JdeDataType.String, 4),
        new JdeField("UMURDT", "UMURDT", JdeDataType.Numeric),
        new JdeField("UMURAT", "UMURAT", JdeDataType.Numeric),
        new JdeField("UMURAB", "UMURAB", JdeDataType.Numeric),
        new JdeField("UMURRF", "UMURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R3034_0", "Primary Key on UMUOM", new[] { "UMUOM" }, isUnique: true, isPrimaryKey: true)
    };
}
