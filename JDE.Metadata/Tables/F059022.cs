using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F059022 - .
/// </summary>
public class F059022 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCFTC.
        /// </summary>
        public const string PCFTC = "PCFTC";

        /// <summary>
        /// PCCPSC.
        /// </summary>
        public const string PCCPSC = "PCCPSC";

        /// <summary>
        /// PCLCL.
        /// </summary>
        public const string PCLCL = "PCLCL";

        /// <summary>
        /// PCUCL.
        /// </summary>
        public const string PCUCL = "PCUCL";

        /// <summary>
        /// PCCHRV.
        /// </summary>
        public const string PCCHRV = "PCCHRV";

        /// <summary>
        /// PCSXRV.
        /// </summary>
        public const string PCSXRV = "PCSXRV";

        /// <summary>
        /// PCSZRV.
        /// </summary>
        public const string PCSZRV = "PCSZRV";

        /// <summary>
        /// PCNV.
        /// </summary>
        public const string PCNV = "PCNV";

        /// <summary>
        /// PCCMED.
        /// </summary>
        public const string PCCMED = "PCCMED";

        /// <summary>
        /// PCCOPR.
        /// </summary>
        public const string PCCOPR = "PCCOPR";

        /// <summary>
        /// PCEXA.
        /// </summary>
        public const string PCEXA = "PCEXA";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCJOBN.
        /// </summary>
        public const string PCJOBN = "PCJOBN";

        /// <summary>
        /// PCUPMJ.
        /// </summary>
        public const string PCUPMJ = "PCUPMJ";

        /// <summary>
        /// PCUPMT.
        /// </summary>
        public const string PCUPMT = "PCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F059022";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCFTC", "PCFTC", JdeDataType.String, 10, true, true),
        new JdeField("PCCPSC", "PCCPSC", JdeDataType.String, 6, true, true),
        new JdeField("PCLCL", "PCLCL", JdeDataType.Numeric, null, true, true),
        new JdeField("PCUCL", "PCUCL", JdeDataType.Numeric, null, true, true),
        new JdeField("PCCHRV", "PCCHRV", JdeDataType.String, 2, true, true),
        new JdeField("PCSXRV", "PCSXRV", JdeDataType.String, 40, true, true),
        new JdeField("PCSZRV", "PCSZRV", JdeDataType.String, 40, true, true),
        new JdeField("PCNV", "PCNV", JdeDataType.Numeric, null, true, true),
        new JdeField("PCCMED", "PCCMED", JdeDataType.String, 2),
        new JdeField("PCCOPR", "PCCOPR", JdeDataType.Numeric),
        new JdeField("PCEXA", "PCEXA", JdeDataType.String, 60),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCJOBN", "PCJOBN", JdeDataType.String, 20),
        new JdeField("PCUPMJ", "PCUPMJ", JdeDataType.Numeric),
        new JdeField("PCUPMT", "PCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F059022_0", "Primary Key on PCFTC, PCCPSC, PCLCL, PCUCL, PCCHRV, PCSXRV, PCSZRV, PCNV", new[] { "PCFTC", "PCCPSC", "PCLCL", "PCUCL", "PCCHRV", "PCSXRV", "PCSZRV", "PCNV" }, isUnique: true, isPrimaryKey: true)
    };
}
