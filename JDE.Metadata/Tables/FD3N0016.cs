using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N0016 - .
/// </summary>
public class FD3N0016 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OEA333.
        /// </summary>
        public const string OEA333 = "OEA333";

        /// <summary>
        /// OEMCU.
        /// </summary>
        public const string OEMCU = "OEMCU";

        /// <summary>
        /// OEDOCO.
        /// </summary>
        public const string OEDOCO = "OEDOCO";

        /// <summary>
        /// OEDCTO.
        /// </summary>
        public const string OEDCTO = "OEDCTO";

        /// <summary>
        /// OECPNB.
        /// </summary>
        public const string OECPNB = "OECPNB";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N0016";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OEA333", "OEA333", JdeDataType.String, 1200),
        new JdeField("OEMCU", "OEMCU", JdeDataType.String, 24, true, true),
        new JdeField("OEDOCO", "OEDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("OEDCTO", "OEDCTO", JdeDataType.String, 4, true, true),
        new JdeField("OECPNB", "OECPNB", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N0016_0", "Primary Key on OEMCU, OEDOCO, OEDCTO, OECPNB", new[] { "OEMCU", "OEDOCO", "OEDCTO", "OECPNB" }, isUnique: true, isPrimaryKey: true)
    };
}
