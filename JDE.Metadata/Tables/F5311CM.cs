using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5311CM - .
/// </summary>
public class F5311CM : JdeTable
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
        /// CMCMCRDS.
        /// </summary>
        public const string CMCMCRDS = "CMCMCRDS";

        /// <summary>
        /// CMMCU.
        /// </summary>
        public const string CMMCU = "CMMCU";

        /// <summary>
        /// CMBSTC.
        /// </summary>
        public const string CMBSTC = "CMBSTC";

        /// <summary>
        /// CMSCOS.
        /// </summary>
        public const string CMSCOS = "CMSCOS";

        /// <summary>
        /// CMSSUB.
        /// </summary>
        public const string CMSSUB = "CMSSUB";

        /// <summary>
        /// CMUPMJ.
        /// </summary>
        public const string CMUPMJ = "CMUPMJ";

        /// <summary>
        /// CMUPMT.
        /// </summary>
        public const string CMUPMT = "CMUPMT";

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
    }

    /// <inheritdoc />
    public override string TableName => "F5311CM";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMEXSYSINS", "CMEXSYSINS", JdeDataType.String, 400, true, true),
        new JdeField("CMCMCRDS", "CMCMCRDS", JdeDataType.String, 4, true, true),
        new JdeField("CMMCU", "CMMCU", JdeDataType.String, 24, true, true),
        new JdeField("CMBSTC", "CMBSTC", JdeDataType.String, 2),
        new JdeField("CMSCOS", "CMSCOS", JdeDataType.String, 4),
        new JdeField("CMSSUB", "CMSSUB", JdeDataType.String, 4),
        new JdeField("CMUPMJ", "CMUPMJ", JdeDataType.Numeric),
        new JdeField("CMUPMT", "CMUPMT", JdeDataType.Numeric),
        new JdeField("CMUSER", "CMUSER", JdeDataType.String, 20),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20),
        new JdeField("CMMKEY", "CMMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5311CM_0", "Primary Key on CMEXSYSINS, CMCMCRDS, CMMCU", new[] { "CMEXSYSINS", "CMCMCRDS", "CMMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
