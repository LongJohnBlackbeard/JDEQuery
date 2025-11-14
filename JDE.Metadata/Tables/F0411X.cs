using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0411X - .
/// </summary>
public class F0411X : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMN001.
        /// </summary>
        public const string CMN001 = "CMN001";

        /// <summary>
        /// CMCMAPPN.
        /// </summary>
        public const string CMCMAPPN = "CMCMAPPN";

        /// <summary>
        /// CMDOC.
        /// </summary>
        public const string CMDOC = "CMDOC";

        /// <summary>
        /// CMDCT.
        /// </summary>
        public const string CMDCT = "CMDCT";

        /// <summary>
        /// CMKCO.
        /// </summary>
        public const string CMKCO = "CMKCO";

        /// <summary>
        /// CMEXSYSINS.
        /// </summary>
        public const string CMEXSYSINS = "CMEXSYSINS";

        /// <summary>
        /// CMCMEXP.
        /// </summary>
        public const string CMCMEXP = "CMCMEXP";

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
    public override string TableName => "F0411X";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMN001", "CMN001", JdeDataType.Numeric, null, true, true),
        new JdeField("CMCMAPPN", "CMCMAPPN", JdeDataType.String, 10, true, true),
        new JdeField("CMDOC", "CMDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("CMDCT", "CMDCT", JdeDataType.String, 4, true, true),
        new JdeField("CMKCO", "CMKCO", JdeDataType.String, 10, true, true),
        new JdeField("CMEXSYSINS", "CMEXSYSINS", JdeDataType.String, 400, true, true),
        new JdeField("CMCMEXP", "CMCMEXP", JdeDataType.String, 2),
        new JdeField("CMUSER", "CMUSER", JdeDataType.String, 20),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20),
        new JdeField("CMMKEY", "CMMKEY", JdeDataType.String, 30),
        new JdeField("CMUPMJ", "CMUPMJ", JdeDataType.Numeric),
        new JdeField("CMUPMT", "CMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0411X_0", "Primary Key on CMEXSYSINS, CMN001, CMCMAPPN, CMDOC, CMDCT, CMKCO", new[] { "CMEXSYSINS", "CMN001", "CMCMAPPN", "CMDOC", "CMDCT", "CMKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
