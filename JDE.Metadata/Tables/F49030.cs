using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49030 - .
/// </summary>
public class F49030 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VEVEHI.
        /// </summary>
        public const string VEVEHI = "VEVEHI";

        /// <summary>
        /// VEEQPT.
        /// </summary>
        public const string VEEQPT = "VEEQPT";

        /// <summary>
        /// VEUNTN.
        /// </summary>
        public const string VEUNTN = "VEUNTN";

        /// <summary>
        /// VEEFTJ.
        /// </summary>
        public const string VEEFTJ = "VEEFTJ";

        /// <summary>
        /// VEEXDJ.
        /// </summary>
        public const string VEEXDJ = "VEEXDJ";

        /// <summary>
        /// VEUSER.
        /// </summary>
        public const string VEUSER = "VEUSER";

        /// <summary>
        /// VEPID.
        /// </summary>
        public const string VEPID = "VEPID";

        /// <summary>
        /// VEJOBN.
        /// </summary>
        public const string VEJOBN = "VEJOBN";

        /// <summary>
        /// VEUPMJ.
        /// </summary>
        public const string VEUPMJ = "VEUPMJ";

        /// <summary>
        /// VETDAY.
        /// </summary>
        public const string VETDAY = "VETDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49030";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VEVEHI", "VEVEHI", JdeDataType.String, 24),
        new JdeField("VEEQPT", "VEEQPT", JdeDataType.String, 6),
        new JdeField("VEUNTN", "VEUNTN", JdeDataType.Numeric),
        new JdeField("VEEFTJ", "VEEFTJ", JdeDataType.Numeric),
        new JdeField("VEEXDJ", "VEEXDJ", JdeDataType.Numeric),
        new JdeField("VEUSER", "VEUSER", JdeDataType.String, 20),
        new JdeField("VEPID", "VEPID", JdeDataType.String, 20),
        new JdeField("VEJOBN", "VEJOBN", JdeDataType.String, 20),
        new JdeField("VEUPMJ", "VEUPMJ", JdeDataType.Numeric),
        new JdeField("VETDAY", "VETDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49030_4", "Index on VEVEHI, VEEFTJ, VEEQPT", new[] { "VEVEHI", "VEEFTJ", "VEEQPT" })
    };
}
