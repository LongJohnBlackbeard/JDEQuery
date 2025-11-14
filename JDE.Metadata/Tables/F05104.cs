using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05104 - .
/// </summary>
public class F05104 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMCMPE.
        /// </summary>
        public const string CMCMPE = "CMCMPE";

        /// <summary>
        /// CMCMPC.
        /// </summary>
        public const string CMCMPC = "CMCMPC";

        /// <summary>
        /// CMCCLS.
        /// </summary>
        public const string CMCCLS = "CMCCLS";

        /// <summary>
        /// CMDL01.
        /// </summary>
        public const string CMDL01 = "CMDL01";

        /// <summary>
        /// CMSCLE.
        /// </summary>
        public const string CMSCLE = "CMSCLE";

        /// <summary>
        /// CMUSER.
        /// </summary>
        public const string CMUSER = "CMUSER";

        /// <summary>
        /// CMPID.
        /// </summary>
        public const string CMPID = "CMPID";

        /// <summary>
        /// CMJOBN.
        /// </summary>
        public const string CMJOBN = "CMJOBN";

        /// <summary>
        /// CMUPMJ.
        /// </summary>
        public const string CMUPMJ = "CMUPMJ";

        /// <summary>
        /// CMUPMT.
        /// </summary>
        public const string CMUPMT = "CMUPMT";

        /// <summary>
        /// CMACCOMP.
        /// </summary>
        public const string CMACCOMP = "CMACCOMP";
    }

    /// <inheritdoc />
    public override string TableName => "F05104";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMCMPE", "CMCMPE", JdeDataType.String, 6, true, true),
        new JdeField("CMCMPC", "CMCMPC", JdeDataType.String, 20, true, true),
        new JdeField("CMCCLS", "CMCCLS", JdeDataType.String, 20),
        new JdeField("CMDL01", "CMDL01", JdeDataType.String, 60),
        new JdeField("CMSCLE", "CMSCLE", JdeDataType.String, 20),
        new JdeField("CMUSER", "CMUSER", JdeDataType.String, 20),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20),
        new JdeField("CMJOBN", "CMJOBN", JdeDataType.String, 20),
        new JdeField("CMUPMJ", "CMUPMJ", JdeDataType.Numeric),
        new JdeField("CMUPMT", "CMUPMT", JdeDataType.Numeric),
        new JdeField("CMACCOMP", "CMACCOMP", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05104_0", "Primary Key on CMCMPE, CMCMPC", new[] { "CMCMPE", "CMCMPC" }, isUnique: true, isPrimaryKey: true)
    };
}
