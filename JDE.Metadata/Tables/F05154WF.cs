using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05154WF - .
/// </summary>
public class F05154WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFJOBS.
        /// </summary>
        public const string WFJOBS = "WFJOBS";

        /// <summary>
        /// WFAN8.
        /// </summary>
        public const string WFAN8 = "WFAN8";

        /// <summary>
        /// WFCMPE.
        /// </summary>
        public const string WFCMPE = "WFCMPE";

        /// <summary>
        /// WFCMPC.
        /// </summary>
        public const string WFCMPC = "WFCMPC";

        /// <summary>
        /// WFWORDID.
        /// </summary>
        public const string WFWORDID = "WFWORDID";

        /// <summary>
        /// WFUSER.
        /// </summary>
        public const string WFUSER = "WFUSER";

        /// <summary>
        /// WFPID.
        /// </summary>
        public const string WFPID = "WFPID";

        /// <summary>
        /// WFMKEY.
        /// </summary>
        public const string WFMKEY = "WFMKEY";

        /// <summary>
        /// WFUPMJ.
        /// </summary>
        public const string WFUPMJ = "WFUPMJ";

        /// <summary>
        /// WFUPMT.
        /// </summary>
        public const string WFUPMT = "WFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F05154WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFJOBS", "WFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WFAN8", "WFAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("WFCMPE", "WFCMPE", JdeDataType.String, 6, true, true),
        new JdeField("WFCMPC", "WFCMPC", JdeDataType.String, 20, true, true),
        new JdeField("WFWORDID", "WFWORDID", JdeDataType.Numeric, null, true, true),
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20),
        new JdeField("WFPID", "WFPID", JdeDataType.String, 20),
        new JdeField("WFMKEY", "WFMKEY", JdeDataType.String, 30),
        new JdeField("WFUPMJ", "WFUPMJ", JdeDataType.Numeric),
        new JdeField("WFUPMT", "WFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05154WF_0", "Primary Key on WFJOBS, WFAN8, WFCMPE, WFCMPC, WFWORDID", new[] { "WFJOBS", "WFAN8", "WFCMPE", "WFCMPC", "WFWORDID" }, isUnique: true, isPrimaryKey: true)
    };
}
