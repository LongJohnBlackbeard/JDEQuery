using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42180 - .
/// </summary>
public class F42180 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XREXSYSKEY.
        /// </summary>
        public const string XREXSYSKEY = "XREXSYSKEY";

        /// <summary>
        /// XREXSYSINS.
        /// </summary>
        public const string XREXSYSINS = "XREXSYSINS";

        /// <summary>
        /// XRKCOO.
        /// </summary>
        public const string XRKCOO = "XRKCOO";

        /// <summary>
        /// XRDOCO.
        /// </summary>
        public const string XRDOCO = "XRDOCO";

        /// <summary>
        /// XRDCTO.
        /// </summary>
        public const string XRDCTO = "XRDCTO";
    }

    /// <inheritdoc />
    public override string TableName => "F42180";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XREXSYSKEY", "XREXSYSKEY", JdeDataType.String, 200, true, true),
        new JdeField("XREXSYSINS", "XREXSYSINS", JdeDataType.String, 400, true, true),
        new JdeField("XRKCOO", "XRKCOO", JdeDataType.String, 10, true, true),
        new JdeField("XRDOCO", "XRDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("XRDCTO", "XRDCTO", JdeDataType.String, 4, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42180_0", "Primary Key on XREXSYSKEY, XREXSYSINS, XRKCOO, XRDOCO, XRDCTO", new[] { "XREXSYSKEY", "XREXSYSINS", "XRKCOO", "XRDOCO", "XRDCTO" }, isUnique: true, isPrimaryKey: true)
    };
}
