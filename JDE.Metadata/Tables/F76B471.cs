using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B471 - .
/// </summary>
public class F76B471 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DLBDFLAY.
        /// </summary>
        public const string DLBDFLAY = "DLBDFLAY";

        /// <summary>
        /// DLDL01.
        /// </summary>
        public const string DLDL01 = "DLDL01";

        /// <summary>
        /// DLRECL.
        /// </summary>
        public const string DLRECL = "DLRECL";

        /// <summary>
        /// DLPID.
        /// </summary>
        public const string DLPID = "DLPID";

        /// <summary>
        /// DLJOBN.
        /// </summary>
        public const string DLJOBN = "DLJOBN";

        /// <summary>
        /// DLUSER.
        /// </summary>
        public const string DLUSER = "DLUSER";

        /// <summary>
        /// DLUPMJ.
        /// </summary>
        public const string DLUPMJ = "DLUPMJ";

        /// <summary>
        /// DLUPMT.
        /// </summary>
        public const string DLUPMT = "DLUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B471";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DLBDFLAY", "DLBDFLAY", JdeDataType.String, 20, true, true),
        new JdeField("DLDL01", "DLDL01", JdeDataType.String, 60),
        new JdeField("DLRECL", "DLRECL", JdeDataType.Numeric),
        new JdeField("DLPID", "DLPID", JdeDataType.String, 20),
        new JdeField("DLJOBN", "DLJOBN", JdeDataType.String, 20),
        new JdeField("DLUSER", "DLUSER", JdeDataType.String, 20),
        new JdeField("DLUPMJ", "DLUPMJ", JdeDataType.Numeric),
        new JdeField("DLUPMT", "DLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B471_0", "Primary Key on DLBDFLAY", new[] { "DLBDFLAY" }, isUnique: true, isPrimaryKey: true)
    };
}
