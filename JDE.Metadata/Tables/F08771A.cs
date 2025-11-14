using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08771A - .
/// </summary>
public class F08771A : JdeTable
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
        /// XGMSEB.
        /// </summary>
        public const string XGMSEB = "XGMSEB";

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
    public override string TableName => "F08771A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XGHMCO", "XGHMCO", JdeDataType.String, 10, true, true),
        new JdeField("XGMSEB", "XGMSEB", JdeDataType.String, 2),
        new JdeField("XGUSER", "XGUSER", JdeDataType.String, 20),
        new JdeField("XGPID", "XGPID", JdeDataType.String, 20),
        new JdeField("XGJOBN", "XGJOBN", JdeDataType.String, 20),
        new JdeField("XGUPMJ", "XGUPMJ", JdeDataType.Numeric),
        new JdeField("XGUPMT", "XGUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08771A_0", "Primary Key on XGHMCO", new[] { "XGHMCO" }, isUnique: true, isPrimaryKey: true)
    };
}
