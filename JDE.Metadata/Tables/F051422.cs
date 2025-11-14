using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F051422 - .
/// </summary>
public class F051422 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CWCMPE.
        /// </summary>
        public const string CWCMPE = "CWCMPE";

        /// <summary>
        /// CWCMPC.
        /// </summary>
        public const string CWCMPC = "CWCMPC";

        /// <summary>
        /// CWWORDID.
        /// </summary>
        public const string CWWORDID = "CWWORDID";

        /// <summary>
        /// CWORDER.
        /// </summary>
        public const string CWORDER = "CWORDER";

        /// <summary>
        /// CWUSER.
        /// </summary>
        public const string CWUSER = "CWUSER";

        /// <summary>
        /// CWPID.
        /// </summary>
        public const string CWPID = "CWPID";

        /// <summary>
        /// CWMKEY.
        /// </summary>
        public const string CWMKEY = "CWMKEY";

        /// <summary>
        /// CWUPMJ.
        /// </summary>
        public const string CWUPMJ = "CWUPMJ";

        /// <summary>
        /// CWUPMT.
        /// </summary>
        public const string CWUPMT = "CWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F051422";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CWCMPE", "CWCMPE", JdeDataType.String, 6, true, true),
        new JdeField("CWCMPC", "CWCMPC", JdeDataType.String, 20, true, true),
        new JdeField("CWWORDID", "CWWORDID", JdeDataType.Numeric, null, true, true),
        new JdeField("CWORDER", "CWORDER", JdeDataType.Numeric),
        new JdeField("CWUSER", "CWUSER", JdeDataType.String, 20),
        new JdeField("CWPID", "CWPID", JdeDataType.String, 20),
        new JdeField("CWMKEY", "CWMKEY", JdeDataType.String, 30),
        new JdeField("CWUPMJ", "CWUPMJ", JdeDataType.Numeric),
        new JdeField("CWUPMT", "CWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F051422_0", "Primary Key on CWCMPE, CWCMPC, CWWORDID", new[] { "CWCMPE", "CWCMPC", "CWWORDID" }, isUnique: true, isPrimaryKey: true)
    };
}
