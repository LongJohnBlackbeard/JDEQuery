using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0030T - .
/// </summary>
public class F0030T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AZAID.
        /// </summary>
        public const string AZAID = "AZAID";

        /// <summary>
        /// AZAIQ.
        /// </summary>
        public const string AZAIQ = "AZAIQ";

        /// <summary>
        /// AZAII.
        /// </summary>
        public const string AZAII = "AZAII";

        /// <summary>
        /// AZSIQ.
        /// </summary>
        public const string AZSIQ = "AZSIQ";

        /// <summary>
        /// AZSI.
        /// </summary>
        public const string AZSI = "AZSI";

        /// <summary>
        /// AZICI.
        /// </summary>
        public const string AZICI = "AZICI";

        /// <summary>
        /// AZICR.
        /// </summary>
        public const string AZICR = "AZICR";

        /// <summary>
        /// AZASS.
        /// </summary>
        public const string AZASS = "AZASS";

        /// <summary>
        /// AZARR.
        /// </summary>
        public const string AZARR = "AZARR";
    }

    /// <inheritdoc />
    public override string TableName => "F0030T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AZAID", "AZAID", JdeDataType.String, 16, true, true),
        new JdeField("AZAIQ", "AZAIQ", JdeDataType.String, 4),
        new JdeField("AZAII", "AZAII", JdeDataType.String, 20),
        new JdeField("AZSIQ", "AZSIQ", JdeDataType.String, 4),
        new JdeField("AZSI", "AZSI", JdeDataType.String, 20),
        new JdeField("AZICI", "AZICI", JdeDataType.String, 30),
        new JdeField("AZICR", "AZICR", JdeDataType.String, 30),
        new JdeField("AZASS", "AZASS", JdeDataType.String, 30),
        new JdeField("AZARR", "AZARR", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0030T_0", "Primary Key on AZAID", new[] { "AZAID" }, isUnique: true, isPrimaryKey: true)
    };
}
