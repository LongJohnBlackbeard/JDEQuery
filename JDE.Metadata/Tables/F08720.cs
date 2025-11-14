using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08720 - .
/// </summary>
public class F08720 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCSTCI.
        /// </summary>
        public const string SCSTCI = "SCSTCI";

        /// <summary>
        /// SCAN8.
        /// </summary>
        public const string SCAN8 = "SCAN8";

        /// <summary>
        /// SCANPA.
        /// </summary>
        public const string SCANPA = "SCANPA";

        /// <summary>
        /// SCSTCTY.
        /// </summary>
        public const string SCSTCTY = "SCSTCTY";

        /// <summary>
        /// SCSTCSTS.
        /// </summary>
        public const string SCSTCSTS = "SCSTCSTS";

        /// <summary>
        /// SCEFTO.
        /// </summary>
        public const string SCEFTO = "SCEFTO";

        /// <summary>
        /// SCTRS.
        /// </summary>
        public const string SCTRS = "SCTRS";

        /// <summary>
        /// SCANO.
        /// </summary>
        public const string SCANO = "SCANO";

        /// <summary>
        /// SCUPMJ.
        /// </summary>
        public const string SCUPMJ = "SCUPMJ";

        /// <summary>
        /// SCUPMT.
        /// </summary>
        public const string SCUPMT = "SCUPMT";

        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";

        /// <summary>
        /// SCPID.
        /// </summary>
        public const string SCPID = "SCPID";

        /// <summary>
        /// SCJOBN.
        /// </summary>
        public const string SCJOBN = "SCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F08720";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCSTCI", "SCSTCI", JdeDataType.Numeric, null, true, true),
        new JdeField("SCAN8", "SCAN8", JdeDataType.Numeric),
        new JdeField("SCANPA", "SCANPA", JdeDataType.Numeric),
        new JdeField("SCSTCTY", "SCSTCTY", JdeDataType.String, 16, true, true),
        new JdeField("SCSTCSTS", "SCSTCSTS", JdeDataType.String, 4),
        new JdeField("SCEFTO", "SCEFTO", JdeDataType.Numeric),
        new JdeField("SCTRS", "SCTRS", JdeDataType.String, 6),
        new JdeField("SCANO", "SCANO", JdeDataType.Numeric),
        new JdeField("SCUPMJ", "SCUPMJ", JdeDataType.Numeric),
        new JdeField("SCUPMT", "SCUPMT", JdeDataType.Numeric),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20),
        new JdeField("SCJOBN", "SCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08720_0", "Primary Key on SCSTCI, SCSTCTY", new[] { "SCSTCI", "SCSTCTY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08720_2", "Index on SCANPA, SCAN8, SYS_NC00014$, SCSTCTY", new[] { "SCANPA", "SCAN8", "SYS_NC00014$", "SCSTCTY" }),
        new JdeIndex("F08720_3", "Index on SCANPA, SCAN8, SCSTCTY, SYS_NC00014$", new[] { "SCANPA", "SCAN8", "SCSTCTY", "SYS_NC00014$" }),
        new JdeIndex("F08720_4", "Index on SCANO, SCAN8", new[] { "SCANO", "SCAN8" })
    };
}
