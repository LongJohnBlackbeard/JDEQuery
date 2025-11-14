using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F04UI004 - .
/// </summary>
public class F04UI004 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RPPSEL.
        /// </summary>
        public const string RPPSEL = "RPPSEL";

        /// <summary>
        /// RPANI.
        /// </summary>
        public const string RPANI = "RPANI";

        /// <summary>
        /// RPITEM.
        /// </summary>
        public const string RPITEM = "RPITEM";

        /// <summary>
        /// RPCO.
        /// </summary>
        public const string RPCO = "RPCO";

        /// <summary>
        /// RPAAP.
        /// </summary>
        public const string RPAAP = "RPAAP";

        /// <summary>
        /// RPAA.
        /// </summary>
        public const string RPAA = "RPAA";

        /// <summary>
        /// RPDTAI.
        /// </summary>
        public const string RPDTAI = "RPDTAI";
    }

    /// <inheritdoc />
    public override string TableName => "F04UI004";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RPPSEL", "RPPSEL", JdeDataType.Numeric, null, true, true),
        new JdeField("RPANI", "RPANI", JdeDataType.String, 58, true, true),
        new JdeField("RPITEM", "RPITEM", JdeDataType.String, 12, true, true),
        new JdeField("RPCO", "RPCO", JdeDataType.String, 10, true, true),
        new JdeField("RPAAP", "RPAAP", JdeDataType.Numeric),
        new JdeField("RPAA", "RPAA", JdeDataType.Numeric),
        new JdeField("RPDTAI", "RPDTAI", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F04UI004_0", "Primary Key on RPPSEL, RPANI, RPITEM, RPCO", new[] { "RPPSEL", "RPANI", "RPITEM", "RPCO" }, isUnique: true, isPrimaryKey: true)
    };
}
