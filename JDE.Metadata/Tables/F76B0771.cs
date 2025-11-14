using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0771 - .
/// </summary>
public class F76B0771 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IPCO.
        /// </summary>
        public const string IPCO = "IPCO";

        /// <summary>
        /// IPCTRY.
        /// </summary>
        public const string IPCTRY = "IPCTRY";

        /// <summary>
        /// IPFY.
        /// </summary>
        public const string IPFY = "IPFY";

        /// <summary>
        /// IPPN.
        /// </summary>
        public const string IPPN = "IPPN";

        /// <summary>
        /// IPB76IPIT.
        /// </summary>
        public const string IPB76IPIT = "IPB76IPIT";

        /// <summary>
        /// IPUSER.
        /// </summary>
        public const string IPUSER = "IPUSER";

        /// <summary>
        /// IPPID.
        /// </summary>
        public const string IPPID = "IPPID";

        /// <summary>
        /// IPJOBN.
        /// </summary>
        public const string IPJOBN = "IPJOBN";

        /// <summary>
        /// IPUPMJ.
        /// </summary>
        public const string IPUPMJ = "IPUPMJ";

        /// <summary>
        /// IPUPMT.
        /// </summary>
        public const string IPUPMT = "IPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0771";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IPCO", "IPCO", JdeDataType.String, 10, true, true),
        new JdeField("IPCTRY", "IPCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("IPFY", "IPFY", JdeDataType.Numeric, null, true, true),
        new JdeField("IPPN", "IPPN", JdeDataType.Numeric, null, true, true),
        new JdeField("IPB76IPIT", "IPB76IPIT", JdeDataType.Numeric),
        new JdeField("IPUSER", "IPUSER", JdeDataType.String, 20),
        new JdeField("IPPID", "IPPID", JdeDataType.String, 20),
        new JdeField("IPJOBN", "IPJOBN", JdeDataType.String, 20),
        new JdeField("IPUPMJ", "IPUPMJ", JdeDataType.Numeric),
        new JdeField("IPUPMT", "IPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0771_0", "Primary Key on IPCO, IPCTRY, IPFY, IPPN", new[] { "IPCO", "IPCTRY", "IPFY", "IPPN" }, isUnique: true, isPrimaryKey: true)
    };
}
