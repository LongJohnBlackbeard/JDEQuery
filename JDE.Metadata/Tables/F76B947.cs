using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B947 - .
/// </summary>
public class F76B947 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SHJOBS.
        /// </summary>
        public const string SHJOBS = "SHJOBS";

        /// <summary>
        /// SHB76ABON.
        /// </summary>
        public const string SHB76ABON = "SHB76ABON";

        /// <summary>
        /// SHPN.
        /// </summary>
        public const string SHPN = "SHPN";

        /// <summary>
        /// SHB76HASH.
        /// </summary>
        public const string SHB76HASH = "SHB76HASH";

        /// <summary>
        /// SHUSER.
        /// </summary>
        public const string SHUSER = "SHUSER";

        /// <summary>
        /// SHPID.
        /// </summary>
        public const string SHPID = "SHPID";

        /// <summary>
        /// SHJOBN.
        /// </summary>
        public const string SHJOBN = "SHJOBN";

        /// <summary>
        /// SHUPMJ.
        /// </summary>
        public const string SHUPMJ = "SHUPMJ";

        /// <summary>
        /// SHUPMT.
        /// </summary>
        public const string SHUPMT = "SHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B947";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SHJOBS", "SHJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("SHB76ABON", "SHB76ABON", JdeDataType.Numeric, null, true, true),
        new JdeField("SHPN", "SHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("SHB76HASH", "SHB76HASH", JdeDataType.String, 80),
        new JdeField("SHUSER", "SHUSER", JdeDataType.String, 20),
        new JdeField("SHPID", "SHPID", JdeDataType.String, 20),
        new JdeField("SHJOBN", "SHJOBN", JdeDataType.String, 20),
        new JdeField("SHUPMJ", "SHUPMJ", JdeDataType.Numeric),
        new JdeField("SHUPMT", "SHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B947_0", "Primary Key on SHJOBS, SHB76ABON, SHPN", new[] { "SHJOBS", "SHB76ABON", "SHPN" }, isUnique: true, isPrimaryKey: true)
    };
}
