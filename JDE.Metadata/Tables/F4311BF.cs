using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4311BF - .
/// </summary>
public class F4311BF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDSADOCO.
        /// </summary>
        public const string PDSADOCO = "PDSADOCO";

        /// <summary>
        /// PDSADCTO.
        /// </summary>
        public const string PDSADCTO = "PDSADCTO";

        /// <summary>
        /// PDSALNID.
        /// </summary>
        public const string PDSALNID = "PDSALNID";

        /// <summary>
        /// PDSAUORG.
        /// </summary>
        public const string PDSAUORG = "PDSAUORG";

        /// <summary>
        /// PDSAITM.
        /// </summary>
        public const string PDSAITM = "PDSAITM";

        /// <summary>
        /// PDSAPRRC.
        /// </summary>
        public const string PDSAPRRC = "PDSAPRRC";

        /// <summary>
        /// PDSADRQJ.
        /// </summary>
        public const string PDSADRQJ = "PDSADRQJ";

        /// <summary>
        /// PDSAADDJ.
        /// </summary>
        public const string PDSAADDJ = "PDSAADDJ";

        /// <summary>
        /// PDSATRDJ.
        /// </summary>
        public const string PDSATRDJ = "PDSATRDJ";
    }

    /// <inheritdoc />
    public override string TableName => "F4311BF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDSADOCO", "PDSADOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PDSADCTO", "PDSADCTO", JdeDataType.String, 4, true, true),
        new JdeField("PDSALNID", "PDSALNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PDSAUORG", "PDSAUORG", JdeDataType.Numeric),
        new JdeField("PDSAITM", "PDSAITM", JdeDataType.Numeric),
        new JdeField("PDSAPRRC", "PDSAPRRC", JdeDataType.Numeric),
        new JdeField("PDSADRQJ", "PDSADRQJ", JdeDataType.Numeric),
        new JdeField("PDSAADDJ", "PDSAADDJ", JdeDataType.Numeric),
        new JdeField("PDSATRDJ", "PDSATRDJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4311BF_0", "Primary Key on PDSADOCO, PDSADCTO, PDSALNID", new[] { "PDSADOCO", "PDSADCTO", "PDSALNID" }, isUnique: true, isPrimaryKey: true)
    };
}
