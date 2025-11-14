using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F051424 - .
/// </summary>
public class F051424 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDCMPE.
        /// </summary>
        public const string CDCMPE = "CDCMPE";

        /// <summary>
        /// CDDTAI.
        /// </summary>
        public const string CDDTAI = "CDDTAI";

        /// <summary>
        /// CDKY.
        /// </summary>
        public const string CDKY = "CDKY";

        /// <summary>
        /// CDWORDID.
        /// </summary>
        public const string CDWORDID = "CDWORDID";

        /// <summary>
        /// CDORDER.
        /// </summary>
        public const string CDORDER = "CDORDER";

        /// <summary>
        /// CDUSER.
        /// </summary>
        public const string CDUSER = "CDUSER";

        /// <summary>
        /// CDPID.
        /// </summary>
        public const string CDPID = "CDPID";

        /// <summary>
        /// CDMKEY.
        /// </summary>
        public const string CDMKEY = "CDMKEY";

        /// <summary>
        /// CDUPMJ.
        /// </summary>
        public const string CDUPMJ = "CDUPMJ";

        /// <summary>
        /// CDUPMT.
        /// </summary>
        public const string CDUPMT = "CDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F051424";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDCMPE", "CDCMPE", JdeDataType.String, 6, true, true),
        new JdeField("CDDTAI", "CDDTAI", JdeDataType.String, 20, true, true),
        new JdeField("CDKY", "CDKY", JdeDataType.String, 20, true, true),
        new JdeField("CDWORDID", "CDWORDID", JdeDataType.Numeric, null, true, true),
        new JdeField("CDORDER", "CDORDER", JdeDataType.Numeric),
        new JdeField("CDUSER", "CDUSER", JdeDataType.String, 20),
        new JdeField("CDPID", "CDPID", JdeDataType.String, 20),
        new JdeField("CDMKEY", "CDMKEY", JdeDataType.String, 30),
        new JdeField("CDUPMJ", "CDUPMJ", JdeDataType.Numeric),
        new JdeField("CDUPMT", "CDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F051424_0", "Primary Key on CDCMPE, CDDTAI, CDKY, CDWORDID", new[] { "CDCMPE", "CDDTAI", "CDKY", "CDWORDID" }, isUnique: true, isPrimaryKey: true)
    };
}
