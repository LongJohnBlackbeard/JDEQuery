using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48S001 - .
/// </summary>
public class F48S001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WLDCTI.
        /// </summary>
        public const string WLDCTI = "WLDCTI";

        /// <summary>
        /// WLDCT.
        /// </summary>
        public const string WLDCT = "WLDCT";

        /// <summary>
        /// WLUSER.
        /// </summary>
        public const string WLUSER = "WLUSER";

        /// <summary>
        /// WLPID.
        /// </summary>
        public const string WLPID = "WLPID";

        /// <summary>
        /// WLJOBN.
        /// </summary>
        public const string WLJOBN = "WLJOBN";

        /// <summary>
        /// WLUPMJ.
        /// </summary>
        public const string WLUPMJ = "WLUPMJ";

        /// <summary>
        /// WLUPMT.
        /// </summary>
        public const string WLUPMT = "WLUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F48S001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WLDCTI", "WLDCTI", JdeDataType.String, 4, true, true),
        new JdeField("WLDCT", "WLDCT", JdeDataType.String, 4),
        new JdeField("WLUSER", "WLUSER", JdeDataType.String, 20),
        new JdeField("WLPID", "WLPID", JdeDataType.String, 20),
        new JdeField("WLJOBN", "WLJOBN", JdeDataType.String, 20),
        new JdeField("WLUPMJ", "WLUPMJ", JdeDataType.Numeric),
        new JdeField("WLUPMT", "WLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48S001_0", "Primary Key on WLDCTI", new[] { "WLDCTI" }, isUnique: true, isPrimaryKey: true)
    };
}
