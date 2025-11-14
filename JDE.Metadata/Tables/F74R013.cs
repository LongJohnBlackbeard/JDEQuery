using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R013 - .
/// </summary>
public class F74R013 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CAAID.
        /// </summary>
        public const string CAAID = "CAAID";

        /// <summary>
        /// CAK74ISPL.
        /// </summary>
        public const string CAK74ISPL = "CAK74ISPL";

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
        /// CAUPMT.
        /// </summary>
        public const string CAUPMT = "CAUPMT";

        /// <summary>
        /// CAJOBN.
        /// </summary>
        public const string CAJOBN = "CAJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74R013";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CAAID", "CAAID", JdeDataType.String, 16, true, true),
        new JdeField("CAK74ISPL", "CAK74ISPL", JdeDataType.String, 30),
        new JdeField("CAUSER", "CAUSER", JdeDataType.String, 20),
        new JdeField("CAPID", "CAPID", JdeDataType.String, 20),
        new JdeField("CAUPMJ", "CAUPMJ", JdeDataType.Numeric),
        new JdeField("CAUPMT", "CAUPMT", JdeDataType.Numeric),
        new JdeField("CAJOBN", "CAJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R013_0", "Primary Key on CAAID", new[] { "CAAID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74R013_2", "Index on CAK74ISPL", new[] { "CAK74ISPL" })
    };
}
