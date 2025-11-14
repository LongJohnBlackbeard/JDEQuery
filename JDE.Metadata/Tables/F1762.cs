using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1762 - .
/// </summary>
public class F1762 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCDOCO.
        /// </summary>
        public const string SCDOCO = "SCDOCO";

        /// <summary>
        /// SCLNID.
        /// </summary>
        public const string SCLNID = "SCLNID";

        /// <summary>
        /// SCSTPBD.
        /// </summary>
        public const string SCSTPBD = "SCSTPBD";

        /// <summary>
        /// SCSTPED.
        /// </summary>
        public const string SCSTPED = "SCSTPED";

        /// <summary>
        /// SCSTPBT.
        /// </summary>
        public const string SCSTPBT = "SCSTPBT";

        /// <summary>
        /// SCSTPET.
        /// </summary>
        public const string SCSTPET = "SCSTPET";

        /// <summary>
        /// SCSTPRC.
        /// </summary>
        public const string SCSTPRC = "SCSTPRC";

        /// <summary>
        /// SCSTPEX.
        /// </summary>
        public const string SCSTPEX = "SCSTPEX";
    }

    /// <inheritdoc />
    public override string TableName => "F1762";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCDOCO", "SCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SCLNID", "SCLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SCSTPBD", "SCSTPBD", JdeDataType.Numeric),
        new JdeField("SCSTPED", "SCSTPED", JdeDataType.Numeric),
        new JdeField("SCSTPBT", "SCSTPBT", JdeDataType.Numeric),
        new JdeField("SCSTPET", "SCSTPET", JdeDataType.Numeric),
        new JdeField("SCSTPRC", "SCSTPRC", JdeDataType.String, 6),
        new JdeField("SCSTPEX", "SCSTPEX", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1762_0", "Primary Key on SCDOCO, SCLNID", new[] { "SCDOCO", "SCLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
