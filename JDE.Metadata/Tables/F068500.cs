using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F068500 - .
/// </summary>
public class F068500 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YZPID.
        /// </summary>
        public const string YZPID = "YZPID";

        /// <summary>
        /// YZPPED.
        /// </summary>
        public const string YZPPED = "YZPPED";

        /// <summary>
        /// YZPTAX.
        /// </summary>
        public const string YZPTAX = "YZPTAX";

        /// <summary>
        /// YZTARA.
        /// </summary>
        public const string YZTARA = "YZTARA";

        /// <summary>
        /// YZBW01.
        /// </summary>
        public const string YZBW01 = "YZBW01";

        /// <summary>
        /// YZBE01.
        /// </summary>
        public const string YZBE01 = "YZBE01";

        /// <summary>
        /// YZBX01.
        /// </summary>
        public const string YZBX01 = "YZBX01";

        /// <summary>
        /// YZBY01.
        /// </summary>
        public const string YZBY01 = "YZBY01";

        /// <summary>
        /// YZDTSP.
        /// </summary>
        public const string YZDTSP = "YZDTSP";

        /// <summary>
        /// YZVERS.
        /// </summary>
        public const string YZVERS = "YZVERS";

        /// <summary>
        /// YZHMCO.
        /// </summary>
        public const string YZHMCO = "YZHMCO";

        /// <summary>
        /// YZTAXX.
        /// </summary>
        public const string YZTAXX = "YZTAXX";
    }

    /// <inheritdoc />
    public override string TableName => "F068500";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YZPID", "YZPID", JdeDataType.String, 20),
        new JdeField("YZPPED", "YZPPED", JdeDataType.Numeric),
        new JdeField("YZPTAX", "YZPTAX", JdeDataType.String, 4, true, true),
        new JdeField("YZTARA", "YZTARA", JdeDataType.String, 20),
        new JdeField("YZBW01", "YZBW01", JdeDataType.Numeric),
        new JdeField("YZBE01", "YZBE01", JdeDataType.Numeric),
        new JdeField("YZBX01", "YZBX01", JdeDataType.Numeric),
        new JdeField("YZBY01", "YZBY01", JdeDataType.Numeric),
        new JdeField("YZDTSP", "YZDTSP", JdeDataType.Numeric, null, true, true),
        new JdeField("YZVERS", "YZVERS", JdeDataType.String, 20, true, true),
        new JdeField("YZHMCO", "YZHMCO", JdeDataType.String, 10, true, true),
        new JdeField("YZTAXX", "YZTAXX", JdeDataType.String, 40, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F068500_0", "Primary Key on YZHMCO, YZPTAX, YZTAXX, YZDTSP, YZVERS", new[] { "YZHMCO", "YZPTAX", "YZTAXX", "YZDTSP", "YZVERS" }, isUnique: true, isPrimaryKey: true)
    };
}
