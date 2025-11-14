using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09E114 - .
/// </summary>
public class F09E114 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EREXRTID.
        /// </summary>
        public const string EREXRTID = "EREXRTID";

        /// <summary>
        /// ERPMTMETH.
        /// </summary>
        public const string ERPMTMETH = "ERPMTMETH";

        /// <summary>
        /// ERDL01.
        /// </summary>
        public const string ERDL01 = "ERDL01";

        /// <summary>
        /// ERAN8.
        /// </summary>
        public const string ERAN8 = "ERAN8";

        /// <summary>
        /// ERRATEFAC.
        /// </summary>
        public const string ERRATEFAC = "ERRATEFAC";

        /// <summary>
        /// ERUSER.
        /// </summary>
        public const string ERUSER = "ERUSER";

        /// <summary>
        /// ERPID.
        /// </summary>
        public const string ERPID = "ERPID";

        /// <summary>
        /// ERJOBN.
        /// </summary>
        public const string ERJOBN = "ERJOBN";

        /// <summary>
        /// ERUPMJ.
        /// </summary>
        public const string ERUPMJ = "ERUPMJ";

        /// <summary>
        /// ERUPMT.
        /// </summary>
        public const string ERUPMT = "ERUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F09E114";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EREXRTID", "EREXRTID", JdeDataType.String, 4, true, true),
        new JdeField("ERPMTMETH", "ERPMTMETH", JdeDataType.String, 6, true, true),
        new JdeField("ERDL01", "ERDL01", JdeDataType.String, 60),
        new JdeField("ERAN8", "ERAN8", JdeDataType.Numeric),
        new JdeField("ERRATEFAC", "ERRATEFAC", JdeDataType.Numeric),
        new JdeField("ERUSER", "ERUSER", JdeDataType.String, 20),
        new JdeField("ERPID", "ERPID", JdeDataType.String, 20),
        new JdeField("ERJOBN", "ERJOBN", JdeDataType.String, 20),
        new JdeField("ERUPMJ", "ERUPMJ", JdeDataType.Numeric),
        new JdeField("ERUPMT", "ERUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09E114_0", "Primary Key on EREXRTID, ERPMTMETH", new[] { "EREXRTID", "ERPMTMETH" }, isUnique: true, isPrimaryKey: true)
    };
}
