using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A8081 - .
/// </summary>
public class F76A8081 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRCO.
        /// </summary>
        public const string CRCO = "CRCO";

        /// <summary>
        /// CRDCT.
        /// </summary>
        public const string CRDCT = "CRDCT";

        /// <summary>
        /// CRKCO.
        /// </summary>
        public const string CRKCO = "CRKCO";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";

        /// <summary>
        /// CRUPMJ.
        /// </summary>
        public const string CRUPMJ = "CRUPMJ";

        /// <summary>
        /// CRUPMT.
        /// </summary>
        public const string CRUPMT = "CRUPMT";

        /// <summary>
        /// CRJOBN.
        /// </summary>
        public const string CRJOBN = "CRJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76A8081";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRCO", "CRCO", JdeDataType.String, 10, true, true),
        new JdeField("CRDCT", "CRDCT", JdeDataType.String, 4, true, true),
        new JdeField("CRKCO", "CRKCO", JdeDataType.String, 10),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20),
        new JdeField("CRUPMJ", "CRUPMJ", JdeDataType.Numeric),
        new JdeField("CRUPMT", "CRUPMT", JdeDataType.Numeric),
        new JdeField("CRJOBN", "CRJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A8081_0", "Primary Key on CRCO, CRDCT", new[] { "CRCO", "CRDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
