using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F740931 - .
/// </summary>
public class F740931 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HDTCRG.
        /// </summary>
        public const string HDTCRG = "HDTCRG";

        /// <summary>
        /// HDDL01.
        /// </summary>
        public const string HDDL01 = "HDDL01";

        /// <summary>
        /// HDSTAM.
        /// </summary>
        public const string HDSTAM = "HDSTAM";

        /// <summary>
        /// HDCRCD.
        /// </summary>
        public const string HDCRCD = "HDCRCD";

        /// <summary>
        /// HDJOBN.
        /// </summary>
        public const string HDJOBN = "HDJOBN";

        /// <summary>
        /// HDUPMT.
        /// </summary>
        public const string HDUPMT = "HDUPMT";

        /// <summary>
        /// HDUPMJ.
        /// </summary>
        public const string HDUPMJ = "HDUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F740931";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HDTCRG", "HDTCRG", JdeDataType.String, 4, true, true),
        new JdeField("HDDL01", "HDDL01", JdeDataType.String, 60),
        new JdeField("HDSTAM", "HDSTAM", JdeDataType.Numeric),
        new JdeField("HDCRCD", "HDCRCD", JdeDataType.String, 6),
        new JdeField("HDJOBN", "HDJOBN", JdeDataType.String, 20),
        new JdeField("HDUPMT", "HDUPMT", JdeDataType.Numeric),
        new JdeField("HDUPMJ", "HDUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F740931_0", "Primary Key on HDTCRG", new[] { "HDTCRG" }, isUnique: true, isPrimaryKey: true)
    };
}
