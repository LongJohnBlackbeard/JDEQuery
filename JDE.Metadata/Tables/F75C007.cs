using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C007 - .
/// </summary>
public class F75C007 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CACO.
        /// </summary>
        public const string CACO = "CACO";

        /// <summary>
        /// CAC75NAC.
        /// </summary>
        public const string CAC75NAC = "CAC75NAC";

        /// <summary>
        /// CAC75NDES.
        /// </summary>
        public const string CAC75NDES = "CAC75NDES";

        /// <summary>
        /// CAC75OPN.
        /// </summary>
        public const string CAC75OPN = "CAC75OPN";

        /// <summary>
        /// CAC75MRMT.
        /// </summary>
        public const string CAC75MRMT = "CAC75MRMT";

        /// <summary>
        /// CAC75ACTY.
        /// </summary>
        public const string CAC75ACTY = "CAC75ACTY";

        /// <summary>
        /// CACRCD.
        /// </summary>
        public const string CACRCD = "CACRCD";

        /// <summary>
        /// CAC75ACLV.
        /// </summary>
        public const string CAC75ACLV = "CAC75ACLV";

        /// <summary>
        /// CAJOBN.
        /// </summary>
        public const string CAJOBN = "CAJOBN";

        /// <summary>
        /// CAPID.
        /// </summary>
        public const string CAPID = "CAPID";

        /// <summary>
        /// CAUPMT.
        /// </summary>
        public const string CAUPMT = "CAUPMT";

        /// <summary>
        /// CAUPMJ.
        /// </summary>
        public const string CAUPMJ = "CAUPMJ";

        /// <summary>
        /// CAUSER.
        /// </summary>
        public const string CAUSER = "CAUSER";

        /// <summary>
        /// CADL01.
        /// </summary>
        public const string CADL01 = "CADL01";

        /// <summary>
        /// CADL02.
        /// </summary>
        public const string CADL02 = "CADL02";

        /// <summary>
        /// CAMATH01.
        /// </summary>
        public const string CAMATH01 = "CAMATH01";

        /// <summary>
        /// CAMATH02.
        /// </summary>
        public const string CAMATH02 = "CAMATH02";

        /// <summary>
        /// CAFLAG.
        /// </summary>
        public const string CAFLAG = "CAFLAG";
    }

    /// <inheritdoc />
    public override string TableName => "F75C007";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CACO", "CACO", JdeDataType.String, 10, true, true),
        new JdeField("CAC75NAC", "CAC75NAC", JdeDataType.String, 60, true, true),
        new JdeField("CAC75NDES", "CAC75NDES", JdeDataType.String, 120),
        new JdeField("CAC75OPN", "CAC75OPN", JdeDataType.String, 2),
        new JdeField("CAC75MRMT", "CAC75MRMT", JdeDataType.String, 20),
        new JdeField("CAC75ACTY", "CAC75ACTY", JdeDataType.String, 40),
        new JdeField("CACRCD", "CACRCD", JdeDataType.String, 6),
        new JdeField("CAC75ACLV", "CAC75ACLV", JdeDataType.Numeric),
        new JdeField("CAJOBN", "CAJOBN", JdeDataType.String, 20),
        new JdeField("CAPID", "CAPID", JdeDataType.String, 20),
        new JdeField("CAUPMT", "CAUPMT", JdeDataType.Numeric),
        new JdeField("CAUPMJ", "CAUPMJ", JdeDataType.Numeric),
        new JdeField("CAUSER", "CAUSER", JdeDataType.String, 20),
        new JdeField("CADL01", "CADL01", JdeDataType.String, 60),
        new JdeField("CADL02", "CADL02", JdeDataType.String, 60),
        new JdeField("CAMATH01", "CAMATH01", JdeDataType.Numeric),
        new JdeField("CAMATH02", "CAMATH02", JdeDataType.Numeric),
        new JdeField("CAFLAG", "CAFLAG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C007_0", "Primary Key on CACO, CAC75NAC", new[] { "CACO", "CAC75NAC" }, isUnique: true, isPrimaryKey: true)
    };
}
