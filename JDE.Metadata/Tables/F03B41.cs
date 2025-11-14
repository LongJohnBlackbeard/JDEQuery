using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B41 - .
/// </summary>
public class F03B41 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RCDCID.
        /// </summary>
        public const string RCDCID = "RCDCID";

        /// <summary>
        /// RCLNID.
        /// </summary>
        public const string RCLNID = "RCLNID";

        /// <summary>
        /// RCDDSC.
        /// </summary>
        public const string RCDDSC = "RCDDSC";

        /// <summary>
        /// RCDDDA.
        /// </summary>
        public const string RCDDDA = "RCDDDA";

        /// <summary>
        /// RCFDA.
        /// </summary>
        public const string RCFDA = "RCFDA";

        /// <summary>
        /// RCTDDA.
        /// </summary>
        public const string RCTDDA = "RCTDDA";

        /// <summary>
        /// RCDSPJ.
        /// </summary>
        public const string RCDSPJ = "RCDSPJ";

        /// <summary>
        /// RCDPYD.
        /// </summary>
        public const string RCDPYD = "RCDPYD";

        /// <summary>
        /// RCDRC5.
        /// </summary>
        public const string RCDRC5 = "RCDRC5";

        /// <summary>
        /// RCRC52.
        /// </summary>
        public const string RCRC52 = "RCRC52";

        /// <summary>
        /// RCBCRC.
        /// </summary>
        public const string RCBCRC = "RCBCRC";

        /// <summary>
        /// RCCRCD.
        /// </summary>
        public const string RCCRCD = "RCCRCD";

        /// <summary>
        /// RCTCRC.
        /// </summary>
        public const string RCTCRC = "RCTCRC";

        /// <summary>
        /// RCCO.
        /// </summary>
        public const string RCCO = "RCCO";

        /// <summary>
        /// RCDGJ.
        /// </summary>
        public const string RCDGJ = "RCDGJ";

        /// <summary>
        /// RCGLC.
        /// </summary>
        public const string RCGLC = "RCGLC";

        /// <summary>
        /// RCVRE.
        /// </summary>
        public const string RCVRE = "RCVRE";

        /// <summary>
        /// RCNFVD.
        /// </summary>
        public const string RCNFVD = "RCNFVD";

        /// <summary>
        /// RCUSER.
        /// </summary>
        public const string RCUSER = "RCUSER";

        /// <summary>
        /// RCPID.
        /// </summary>
        public const string RCPID = "RCPID";

        /// <summary>
        /// RCJOBN.
        /// </summary>
        public const string RCJOBN = "RCJOBN";

        /// <summary>
        /// RCUPMJ.
        /// </summary>
        public const string RCUPMJ = "RCUPMJ";

        /// <summary>
        /// RCUPMT.
        /// </summary>
        public const string RCUPMT = "RCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F03B41";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RCDCID", "RCDCID", JdeDataType.Numeric, null, true, true),
        new JdeField("RCLNID", "RCLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("RCDDSC", "RCDDSC", JdeDataType.String, 4),
        new JdeField("RCDDDA", "RCDDDA", JdeDataType.Numeric),
        new JdeField("RCFDA", "RCFDA", JdeDataType.Numeric),
        new JdeField("RCTDDA", "RCTDDA", JdeDataType.Numeric),
        new JdeField("RCDSPJ", "RCDSPJ", JdeDataType.Numeric),
        new JdeField("RCDPYD", "RCDPYD", JdeDataType.Numeric),
        new JdeField("RCDRC5", "RCDRC5", JdeDataType.Numeric),
        new JdeField("RCRC52", "RCRC52", JdeDataType.Numeric),
        new JdeField("RCBCRC", "RCBCRC", JdeDataType.String, 6),
        new JdeField("RCCRCD", "RCCRCD", JdeDataType.String, 6),
        new JdeField("RCTCRC", "RCTCRC", JdeDataType.String, 6),
        new JdeField("RCCO", "RCCO", JdeDataType.String, 10),
        new JdeField("RCDGJ", "RCDGJ", JdeDataType.Numeric),
        new JdeField("RCGLC", "RCGLC", JdeDataType.String, 8),
        new JdeField("RCVRE", "RCVRE", JdeDataType.String, 6),
        new JdeField("RCNFVD", "RCNFVD", JdeDataType.String, 2),
        new JdeField("RCUSER", "RCUSER", JdeDataType.String, 20),
        new JdeField("RCPID", "RCPID", JdeDataType.String, 20),
        new JdeField("RCJOBN", "RCJOBN", JdeDataType.String, 20),
        new JdeField("RCUPMJ", "RCUPMJ", JdeDataType.Numeric),
        new JdeField("RCUPMT", "RCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B41_0", "Primary Key on RCDCID, RCLNID", new[] { "RCDCID", "RCLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B41_4", "Index on RCDCID, SYS_NC00024$", new[] { "RCDCID", "SYS_NC00024$" })
    };
}
