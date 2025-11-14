using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51006X - .
/// </summary>
public class F51006X : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMMCU.
        /// </summary>
        public const string CMMCU = "CMMCU";

        /// <summary>
        /// CMEXSYSINS.
        /// </summary>
        public const string CMEXSYSINS = "CMEXSYSINS";

        /// <summary>
        /// CMCMPROJNM.
        /// </summary>
        public const string CMCMPROJNM = "CMCMPROJNM";

        /// <summary>
        /// CMEV01.
        /// </summary>
        public const string CMEV01 = "CMEV01";

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
    public override string TableName => "F51006X";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMMCU", "CMMCU", JdeDataType.String, 24, true, true),
        new JdeField("CMEXSYSINS", "CMEXSYSINS", JdeDataType.String, 400, true, true),
        new JdeField("CMCMPROJNM", "CMCMPROJNM", JdeDataType.String, 16),
        new JdeField("CMEV01", "CMEV01", JdeDataType.String, 2),
        new JdeField("CMUSER", "CMUSER", JdeDataType.String, 20),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20),
        new JdeField("CMMKEY", "CMMKEY", JdeDataType.String, 30),
        new JdeField("CMUPMJ", "CMUPMJ", JdeDataType.Numeric),
        new JdeField("CMUPMT", "CMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51006X_0", "Primary Key on CMMCU, CMEXSYSINS", new[] { "CMMCU", "CMEXSYSINS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F51006X_2", "Index on CMCMPROJNM, CMEXSYSINS", new[] { "CMCMPROJNM", "CMEXSYSINS" })
    };
}
