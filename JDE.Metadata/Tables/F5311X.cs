using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5311X - .
/// </summary>
public class F5311X : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMEXSYSINS.
        /// </summary>
        public const string CMEXSYSINS = "CMEXSYSINS";

        /// <summary>
        /// CMMCU.
        /// </summary>
        public const string CMMCU = "CMMCU";

        /// <summary>
        /// CMCONO.
        /// </summary>
        public const string CMCONO = "CMCONO";

        /// <summary>
        /// CMREQB.
        /// </summary>
        public const string CMREQB = "CMREQB";

        /// <summary>
        /// CMN001.
        /// </summary>
        public const string CMN001 = "CMN001";

        /// <summary>
        /// CMLNID.
        /// </summary>
        public const string CMLNID = "CMLNID";

        /// <summary>
        /// CMCMCONUM.
        /// </summary>
        public const string CMCMCONUM = "CMCMCONUM";

        /// <summary>
        /// CMCMCOLINE.
        /// </summary>
        public const string CMCMCOLINE = "CMCMCOLINE";

        /// <summary>
        /// CMUSER.
        /// </summary>
        public const string CMUSER = "CMUSER";

        /// <summary>
        /// CMPID.
        /// </summary>
        public const string CMPID = "CMPID";

        /// <summary>
        /// CMMKEY.
        /// </summary>
        public const string CMMKEY = "CMMKEY";

        /// <summary>
        /// CMUPMJ.
        /// </summary>
        public const string CMUPMJ = "CMUPMJ";

        /// <summary>
        /// CMUPMT.
        /// </summary>
        public const string CMUPMT = "CMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F5311X";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMEXSYSINS", "CMEXSYSINS", JdeDataType.String, 400, true, true),
        new JdeField("CMMCU", "CMMCU", JdeDataType.String, 24, true, true),
        new JdeField("CMCONO", "CMCONO", JdeDataType.Numeric, null, true, true),
        new JdeField("CMREQB", "CMREQB", JdeDataType.Numeric, null, true, true),
        new JdeField("CMN001", "CMN001", JdeDataType.Numeric, null, true, true),
        new JdeField("CMLNID", "CMLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CMCMCONUM", "CMCMCONUM", JdeDataType.String, 16),
        new JdeField("CMCMCOLINE", "CMCMCOLINE", JdeDataType.String, 20),
        new JdeField("CMUSER", "CMUSER", JdeDataType.String, 20),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20),
        new JdeField("CMMKEY", "CMMKEY", JdeDataType.String, 30),
        new JdeField("CMUPMJ", "CMUPMJ", JdeDataType.Numeric),
        new JdeField("CMUPMT", "CMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5311X_0", "Primary Key on CMEXSYSINS, CMMCU, CMCONO, CMREQB, CMLNID, CMN001", new[] { "CMEXSYSINS", "CMMCU", "CMCONO", "CMREQB", "CMLNID", "CMN001" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F5311X_2", "Index on CMEXSYSINS, CMMCU, CMCMCONUM, CMN001, CMCMCOLINE", new[] { "CMEXSYSINS", "CMMCU", "CMCMCONUM", "CMN001", "CMCMCOLINE" })
    };
}
