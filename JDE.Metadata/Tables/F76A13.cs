using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A13 - .
/// </summary>
public class F76A13 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TVATXC.
        /// </summary>
        public const string TVATXC = "TVATXC";

        /// <summary>
        /// TVAN8.
        /// </summary>
        public const string TVAN8 = "TVAN8";

        /// <summary>
        /// TVITM.
        /// </summary>
        public const string TVITM = "TVITM";

        /// <summary>
        /// TVAC20.
        /// </summary>
        public const string TVAC20 = "TVAC20";

        /// <summary>
        /// TVSRP0.
        /// </summary>
        public const string TVSRP0 = "TVSRP0";

        /// <summary>
        /// TVEFTJ.
        /// </summary>
        public const string TVEFTJ = "TVEFTJ";

        /// <summary>
        /// TVEFDJ.
        /// </summary>
        public const string TVEFDJ = "TVEFDJ";

        /// <summary>
        /// TVTXR1.
        /// </summary>
        public const string TVTXR1 = "TVTXR1";

        /// <summary>
        /// TVAUMT.
        /// </summary>
        public const string TVAUMT = "TVAUMT";

        /// <summary>
        /// TVUOM.
        /// </summary>
        public const string TVUOM = "TVUOM";
    }

    /// <inheritdoc />
    public override string TableName => "F76A13";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TVATXC", "TVATXC", JdeDataType.String, 20, true, true),
        new JdeField("TVAN8", "TVAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("TVITM", "TVITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TVAC20", "TVAC20", JdeDataType.String, 6, true, true),
        new JdeField("TVSRP0", "TVSRP0", JdeDataType.String, 12, true, true),
        new JdeField("TVEFTJ", "TVEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TVEFDJ", "TVEFDJ", JdeDataType.Numeric),
        new JdeField("TVTXR1", "TVTXR1", JdeDataType.Numeric),
        new JdeField("TVAUMT", "TVAUMT", JdeDataType.Numeric),
        new JdeField("TVUOM", "TVUOM", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A13_0", "Primary Key on TVATXC, TVAN8, TVITM, TVAC20, TVSRP0, TVEFTJ", new[] { "TVATXC", "TVAN8", "TVITM", "TVAC20", "TVSRP0", "TVEFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
