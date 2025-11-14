using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW66 - .
/// </summary>
public class FCW66 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRC9LANC.
        /// </summary>
        public const string CRC9LANC = "CRC9LANC";

        /// <summary>
        /// CRDOCO.
        /// </summary>
        public const string CRDOCO = "CRDOCO";

        /// <summary>
        /// CRLITM.
        /// </summary>
        public const string CRLITM = "CRLITM";

        /// <summary>
        /// CRUORG.
        /// </summary>
        public const string CRUORG = "CRUORG";
    }

    /// <inheritdoc />
    public override string TableName => "FCW66";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRC9LANC", "CRC9LANC", JdeDataType.Numeric, null, true, true),
        new JdeField("CRDOCO", "CRDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CRLITM", "CRLITM", JdeDataType.String, 50),
        new JdeField("CRUORG", "CRUORG", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW66_0", "Primary Key on CRC9LANC, CRDOCO", new[] { "CRC9LANC", "CRDOCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FCW66_2", "Index on CRDOCO", new[] { "CRDOCO" })
    };
}
