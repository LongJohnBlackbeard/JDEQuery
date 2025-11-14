using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4808 - .
/// </summary>
public class F4808 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CAMMCU.
        /// </summary>
        public const string CAMMCU = "CAMMCU";

        /// <summary>
        /// CADCTO.
        /// </summary>
        public const string CADCTO = "CADCTO";

        /// <summary>
        /// CAGRPG.
        /// </summary>
        public const string CAGRPG = "CAGRPG";

        /// <summary>
        /// CAOSEQ.
        /// </summary>
        public const string CAOSEQ = "CAOSEQ";

        /// <summary>
        /// CAAN8.
        /// </summary>
        public const string CAAN8 = "CAAN8";

        /// <summary>
        /// CAUSER.
        /// </summary>
        public const string CAUSER = "CAUSER";

        /// <summary>
        /// CAPID.
        /// </summary>
        public const string CAPID = "CAPID";

        /// <summary>
        /// CAUPMJ.
        /// </summary>
        public const string CAUPMJ = "CAUPMJ";

        /// <summary>
        /// CAJOBN.
        /// </summary>
        public const string CAJOBN = "CAJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F4808";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CAMMCU", "CAMMCU", JdeDataType.String, 24, true, true),
        new JdeField("CADCTO", "CADCTO", JdeDataType.String, 4, true, true),
        new JdeField("CAGRPG", "CAGRPG", JdeDataType.Numeric, null, true, true),
        new JdeField("CAOSEQ", "CAOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CAAN8", "CAAN8", JdeDataType.Numeric),
        new JdeField("CAUSER", "CAUSER", JdeDataType.String, 20),
        new JdeField("CAPID", "CAPID", JdeDataType.String, 20),
        new JdeField("CAUPMJ", "CAUPMJ", JdeDataType.Numeric),
        new JdeField("CAJOBN", "CAJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4808_0", "Primary Key on CADCTO, CAMMCU, CAGRPG, CAOSEQ", new[] { "CADCTO", "CAMMCU", "CAGRPG", "CAOSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
