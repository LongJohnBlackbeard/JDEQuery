using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07860 - .
/// </summary>
public class F07860 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STAN8.
        /// </summary>
        public const string STAN8 = "STAN8";

        /// <summary>
        /// STEFTO.
        /// </summary>
        public const string STEFTO = "STEFTO";

        /// <summary>
        /// STUSER.
        /// </summary>
        public const string STUSER = "STUSER";

        /// <summary>
        /// STJOBN.
        /// </summary>
        public const string STJOBN = "STJOBN";

        /// <summary>
        /// STPID.
        /// </summary>
        public const string STPID = "STPID";

        /// <summary>
        /// STUPMJ.
        /// </summary>
        public const string STUPMJ = "STUPMJ";

        /// <summary>
        /// STUPMT.
        /// </summary>
        public const string STUPMT = "STUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F07860";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STAN8", "STAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("STEFTO", "STEFTO", JdeDataType.Numeric),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STPID", "STPID", JdeDataType.String, 20),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STUPMT", "STUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07860_0", "Primary Key on STAN8", new[] { "STAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
