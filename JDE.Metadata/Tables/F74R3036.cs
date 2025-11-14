using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R3036 - .
/// </summary>
public class F74R3036 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// COORIG.
        /// </summary>
        public const string COORIG = "COORIG";

        /// <summary>
        /// COR74CSN.
        /// </summary>
        public const string COR74CSN = "COR74CSN";

        /// <summary>
        /// COR74CFN.
        /// </summary>
        public const string COR74CFN = "COR74CFN";

        /// <summary>
        /// COR74CDC.
        /// </summary>
        public const string COR74CDC = "COR74CDC";

        /// <summary>
        /// COUSER.
        /// </summary>
        public const string COUSER = "COUSER";

        /// <summary>
        /// COPID.
        /// </summary>
        public const string COPID = "COPID";

        /// <summary>
        /// COJOBN.
        /// </summary>
        public const string COJOBN = "COJOBN";

        /// <summary>
        /// COUPMJ.
        /// </summary>
        public const string COUPMJ = "COUPMJ";

        /// <summary>
        /// COUPMT.
        /// </summary>
        public const string COUPMT = "COUPMT";

        /// <summary>
        /// COURCD.
        /// </summary>
        public const string COURCD = "COURCD";

        /// <summary>
        /// COURDT.
        /// </summary>
        public const string COURDT = "COURDT";

        /// <summary>
        /// COURAT.
        /// </summary>
        public const string COURAT = "COURAT";

        /// <summary>
        /// COURAB.
        /// </summary>
        public const string COURAB = "COURAB";

        /// <summary>
        /// COURRF.
        /// </summary>
        public const string COURRF = "COURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F74R3036";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("COORIG", "COORIG", JdeDataType.String, 6, true, true),
        new JdeField("COR74CSN", "COR74CSN", JdeDataType.String, 40),
        new JdeField("COR74CFN", "COR74CFN", JdeDataType.String, 200),
        new JdeField("COR74CDC", "COR74CDC", JdeDataType.Numeric),
        new JdeField("COUSER", "COUSER", JdeDataType.String, 20),
        new JdeField("COPID", "COPID", JdeDataType.String, 20),
        new JdeField("COJOBN", "COJOBN", JdeDataType.String, 20),
        new JdeField("COUPMJ", "COUPMJ", JdeDataType.Numeric),
        new JdeField("COUPMT", "COUPMT", JdeDataType.Numeric),
        new JdeField("COURCD", "COURCD", JdeDataType.String, 4),
        new JdeField("COURDT", "COURDT", JdeDataType.Numeric),
        new JdeField("COURAT", "COURAT", JdeDataType.Numeric),
        new JdeField("COURAB", "COURAB", JdeDataType.Numeric),
        new JdeField("COURRF", "COURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R3036_0", "Primary Key on COORIG", new[] { "COORIG" }, isUnique: true, isPrimaryKey: true)
    };
}
