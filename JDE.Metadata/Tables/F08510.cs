using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08510 - .
/// </summary>
public class F08510 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BCEECD.
        /// </summary>
        public const string BCEECD = "BCEECD";

        /// <summary>
        /// BCSBGR.
        /// </summary>
        public const string BCSBGR = "BCSBGR";

        /// <summary>
        /// BCADCE.
        /// </summary>
        public const string BCADCE = "BCADCE";

        /// <summary>
        /// BCPID.
        /// </summary>
        public const string BCPID = "BCPID";

        /// <summary>
        /// BCUPMJ.
        /// </summary>
        public const string BCUPMJ = "BCUPMJ";

        /// <summary>
        /// BCTME0.
        /// </summary>
        public const string BCTME0 = "BCTME0";

        /// <summary>
        /// BCUSER.
        /// </summary>
        public const string BCUSER = "BCUSER";

        /// <summary>
        /// BCJOBN.
        /// </summary>
        public const string BCJOBN = "BCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F08510";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BCEECD", "BCEECD", JdeDataType.String, 6, true, true),
        new JdeField("BCSBGR", "BCSBGR", JdeDataType.String, 20, true, true),
        new JdeField("BCADCE", "BCADCE", JdeDataType.String, 2),
        new JdeField("BCPID", "BCPID", JdeDataType.String, 20),
        new JdeField("BCUPMJ", "BCUPMJ", JdeDataType.Numeric),
        new JdeField("BCTME0", "BCTME0", JdeDataType.Numeric),
        new JdeField("BCUSER", "BCUSER", JdeDataType.String, 20),
        new JdeField("BCJOBN", "BCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08510_0", "Primary Key on BCEECD, BCSBGR", new[] { "BCEECD", "BCSBGR" }, isUnique: true, isPrimaryKey: true)
    };
}
