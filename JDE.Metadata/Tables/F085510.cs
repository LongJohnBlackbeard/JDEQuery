using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F085510 - .
/// </summary>
public class F085510 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EREECD.
        /// </summary>
        public const string EREECD = "EREECD";

        /// <summary>
        /// ERSBGR.
        /// </summary>
        public const string ERSBGR = "ERSBGR";

        /// <summary>
        /// ERADCE.
        /// </summary>
        public const string ERADCE = "ERADCE";

        /// <summary>
        /// ERABENCO.
        /// </summary>
        public const string ERABENCO = "ERABENCO";

        /// <summary>
        /// ERPID.
        /// </summary>
        public const string ERPID = "ERPID";

        /// <summary>
        /// ERUPMJ.
        /// </summary>
        public const string ERUPMJ = "ERUPMJ";

        /// <summary>
        /// ERUPMT.
        /// </summary>
        public const string ERUPMT = "ERUPMT";

        /// <summary>
        /// ERUSER.
        /// </summary>
        public const string ERUSER = "ERUSER";

        /// <summary>
        /// ERJOBN.
        /// </summary>
        public const string ERJOBN = "ERJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F085510";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EREECD", "EREECD", JdeDataType.String, 6, true, true),
        new JdeField("ERSBGR", "ERSBGR", JdeDataType.String, 20, true, true),
        new JdeField("ERADCE", "ERADCE", JdeDataType.String, 2),
        new JdeField("ERABENCO", "ERABENCO", JdeDataType.String, 2),
        new JdeField("ERPID", "ERPID", JdeDataType.String, 20),
        new JdeField("ERUPMJ", "ERUPMJ", JdeDataType.Numeric),
        new JdeField("ERUPMT", "ERUPMT", JdeDataType.Numeric),
        new JdeField("ERUSER", "ERUSER", JdeDataType.String, 20),
        new JdeField("ERJOBN", "ERJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F085510_0", "Primary Key on EREECD, ERSBGR", new[] { "EREECD", "ERSBGR" }, isUnique: true, isPrimaryKey: true)
    };
}
