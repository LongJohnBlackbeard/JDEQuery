using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7400004 - .
/// </summary>
public class F7400004 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IPK74ISPL.
        /// </summary>
        public const string IPK74ISPL = "IPK74ISPL";

        /// <summary>
        /// IPDL01.
        /// </summary>
        public const string IPDL01 = "IPDL01";

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
    public override string TableName => "F7400004";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IPK74ISPL", "IPK74ISPL", JdeDataType.String, 30, true, true),
        new JdeField("IPDL01", "IPDL01", JdeDataType.String, 60),
        new JdeField("IPUSER", "IPUSER", JdeDataType.String, 20),
        new JdeField("IPPID", "IPPID", JdeDataType.String, 20),
        new JdeField("IPJOBN", "IPJOBN", JdeDataType.String, 20),
        new JdeField("IPUPMJ", "IPUPMJ", JdeDataType.Numeric),
        new JdeField("IPUPMT", "IPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7400004_0", "Primary Key on IPK74ISPL", new[] { "IPK74ISPL" }, isUnique: true, isPrimaryKey: true)
    };
}
