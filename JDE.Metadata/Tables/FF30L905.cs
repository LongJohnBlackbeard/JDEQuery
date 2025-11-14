using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L905 - .
/// </summary>
public class FF30L905 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMCELLID.
        /// </summary>
        public const string CMCELLID = "CMCELLID";

        /// <summary>
        /// CMCELLN.
        /// </summary>
        public const string CMCELLN = "CMCELLN";

        /// <summary>
        /// CMDFMCU.
        /// </summary>
        public const string CMDFMCU = "CMDFMCU";

        /// <summary>
        /// CMFSCID.
        /// </summary>
        public const string CMFSCID = "CMFSCID";

        /// <summary>
        /// CMPID.
        /// </summary>
        public const string CMPID = "CMPID";

        /// <summary>
        /// CMUSER.
        /// </summary>
        public const string CMUSER = "CMUSER";

        /// <summary>
        /// CMUPMJ.
        /// </summary>
        public const string CMUPMJ = "CMUPMJ";

        /// <summary>
        /// CMUPMT.
        /// </summary>
        public const string CMUPMT = "CMUPMT";

        /// <summary>
        /// CMMKEY.
        /// </summary>
        public const string CMMKEY = "CMMKEY";

        /// <summary>
        /// CMDFMMCU.
        /// </summary>
        public const string CMDFMMCU = "CMDFMMCU";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L905";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMCELLID", "CMCELLID", JdeDataType.Numeric, null, true, true),
        new JdeField("CMCELLN", "CMCELLN", JdeDataType.String, 30),
        new JdeField("CMDFMCU", "CMDFMCU", JdeDataType.String, 24),
        new JdeField("CMFSCID", "CMFSCID", JdeDataType.Numeric),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20),
        new JdeField("CMUSER", "CMUSER", JdeDataType.String, 20),
        new JdeField("CMUPMJ", "CMUPMJ", JdeDataType.Numeric),
        new JdeField("CMUPMT", "CMUPMT", JdeDataType.Numeric),
        new JdeField("CMMKEY", "CMMKEY", JdeDataType.String, 30),
        new JdeField("CMDFMMCU", "CMDFMMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L905_0", "Primary Key on CMCELLID", new[] { "CMCELLID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L905_2", "Index on CMCELLN, CMFSCID", new[] { "CMCELLN", "CMFSCID" }),
        new JdeIndex("FF30L905_3", "Index on CMFSCID, CMDFMCU, CMDFMMCU", new[] { "CMFSCID", "CMDFMCU", "CMDFMMCU" })
    };
}
