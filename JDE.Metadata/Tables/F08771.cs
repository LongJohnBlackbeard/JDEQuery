using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08771 - .
/// </summary>
public class F08771 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XGHMCO.
        /// </summary>
        public const string XGHMCO = "XGHMCO";

        /// <summary>
        /// XGPACM.
        /// </summary>
        public const string XGPACM = "XGPACM";

        /// <summary>
        /// XGSCLES.
        /// </summary>
        public const string XGSCLES = "XGSCLES";

        /// <summary>
        /// XGREQLS.
        /// </summary>
        public const string XGREQLS = "XGREQLS";

        /// <summary>
        /// XGESARQ.
        /// </summary>
        public const string XGESARQ = "XGESARQ";

        /// <summary>
        /// XGPABM.
        /// </summary>
        public const string XGPABM = "XGPABM";

        /// <summary>
        /// XGSCLEE.
        /// </summary>
        public const string XGSCLEE = "XGSCLEE";

        /// <summary>
        /// XGREQLE.
        /// </summary>
        public const string XGREQLE = "XGREQLE";

        /// <summary>
        /// XGUSER.
        /// </summary>
        public const string XGUSER = "XGUSER";

        /// <summary>
        /// XGPID.
        /// </summary>
        public const string XGPID = "XGPID";

        /// <summary>
        /// XGJOBN.
        /// </summary>
        public const string XGJOBN = "XGJOBN";

        /// <summary>
        /// XGUPMJ.
        /// </summary>
        public const string XGUPMJ = "XGUPMJ";

        /// <summary>
        /// XGUPMT.
        /// </summary>
        public const string XGUPMT = "XGUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08771";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XGHMCO", "XGHMCO", JdeDataType.String, 10, true, true),
        new JdeField("XGPACM", "XGPACM", JdeDataType.String, 2),
        new JdeField("XGSCLES", "XGSCLES", JdeDataType.String, 20),
        new JdeField("XGREQLS", "XGREQLS", JdeDataType.Numeric),
        new JdeField("XGESARQ", "XGESARQ", JdeDataType.String, 2),
        new JdeField("XGPABM", "XGPABM", JdeDataType.String, 2),
        new JdeField("XGSCLEE", "XGSCLEE", JdeDataType.String, 20),
        new JdeField("XGREQLE", "XGREQLE", JdeDataType.Numeric),
        new JdeField("XGUSER", "XGUSER", JdeDataType.String, 20),
        new JdeField("XGPID", "XGPID", JdeDataType.String, 20),
        new JdeField("XGJOBN", "XGJOBN", JdeDataType.String, 20),
        new JdeField("XGUPMJ", "XGUPMJ", JdeDataType.Numeric),
        new JdeField("XGUPMT", "XGUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08771_0", "Primary Key on XGHMCO", new[] { "XGHMCO" }, isUnique: true, isPrimaryKey: true)
    };
}
