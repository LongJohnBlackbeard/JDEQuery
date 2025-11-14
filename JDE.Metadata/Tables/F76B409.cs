using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B409 - .
/// </summary>
public class F76B409 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSBRTXTP.
        /// </summary>
        public const string CSBRTXTP = "CSBRTXTP";

        /// <summary>
        /// CSB76CTYC.
        /// </summary>
        public const string CSB76CTYC = "CSB76CTYC";

        /// <summary>
        /// CSB76SVTC.
        /// </summary>
        public const string CSB76SVTC = "CSB76SVTC";

        /// <summary>
        /// CSEFTJ.
        /// </summary>
        public const string CSEFTJ = "CSEFTJ";

        /// <summary>
        /// CSBRALQ.
        /// </summary>
        public const string CSBRALQ = "CSBRALQ";

        /// <summary>
        /// CSEFDJ.
        /// </summary>
        public const string CSEFDJ = "CSEFDJ";

        /// <summary>
        /// CSGLC.
        /// </summary>
        public const string CSGLC = "CSGLC";

        /// <summary>
        /// CSBRRTA.
        /// </summary>
        public const string CSBRRTA = "CSBRRTA";

        /// <summary>
        /// CSUSER.
        /// </summary>
        public const string CSUSER = "CSUSER";

        /// <summary>
        /// CSJOBN.
        /// </summary>
        public const string CSJOBN = "CSJOBN";

        /// <summary>
        /// CSPID.
        /// </summary>
        public const string CSPID = "CSPID";

        /// <summary>
        /// CSUPMJ.
        /// </summary>
        public const string CSUPMJ = "CSUPMJ";

        /// <summary>
        /// CSUPMT.
        /// </summary>
        public const string CSUPMT = "CSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B409";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSBRTXTP", "CSBRTXTP", JdeDataType.String, 4, true, true),
        new JdeField("CSB76CTYC", "CSB76CTYC", JdeDataType.String, 20, true, true),
        new JdeField("CSB76SVTC", "CSB76SVTC", JdeDataType.String, 20, true, true),
        new JdeField("CSEFTJ", "CSEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CSBRALQ", "CSBRALQ", JdeDataType.Numeric),
        new JdeField("CSEFDJ", "CSEFDJ", JdeDataType.Numeric),
        new JdeField("CSGLC", "CSGLC", JdeDataType.String, 8),
        new JdeField("CSBRRTA", "CSBRRTA", JdeDataType.String, 2),
        new JdeField("CSUSER", "CSUSER", JdeDataType.String, 20),
        new JdeField("CSJOBN", "CSJOBN", JdeDataType.String, 20),
        new JdeField("CSPID", "CSPID", JdeDataType.String, 20),
        new JdeField("CSUPMJ", "CSUPMJ", JdeDataType.Numeric),
        new JdeField("CSUPMT", "CSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B409_0", "Primary Key on CSBRTXTP, CSB76CTYC, CSEFTJ, CSB76SVTC", new[] { "CSBRTXTP", "CSB76CTYC", "CSEFTJ", "CSB76SVTC" }, isUnique: true, isPrimaryKey: true)
    };
}
