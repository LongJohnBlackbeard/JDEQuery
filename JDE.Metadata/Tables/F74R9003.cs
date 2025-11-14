using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R9003 - .
/// </summary>
public class F74R9003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMR74RMID.
        /// </summary>
        public const string CMR74RMID = "CMR74RMID";

        /// <summary>
        /// CMICUT.
        /// </summary>
        public const string CMICUT = "CMICUT";

        /// <summary>
        /// CMDCT.
        /// </summary>
        public const string CMDCT = "CMDCT";

        /// <summary>
        /// CMR74CMTH.
        /// </summary>
        public const string CMR74CMTH = "CMR74CMTH";

        /// <summary>
        /// CMR74CPOP.
        /// </summary>
        public const string CMR74CPOP = "CMR74CPOP";

        /// <summary>
        /// CMR74CMA1.
        /// </summary>
        public const string CMR74CMA1 = "CMR74CMA1";

        /// <summary>
        /// CMR74CMA2.
        /// </summary>
        public const string CMR74CMA2 = "CMR74CMA2";

        /// <summary>
        /// CMR74CMA3.
        /// </summary>
        public const string CMR74CMA3 = "CMR74CMA3";

        /// <summary>
        /// CMR74CMA4.
        /// </summary>
        public const string CMR74CMA4 = "CMR74CMA4";

        /// <summary>
        /// CMR74CMA5.
        /// </summary>
        public const string CMR74CMA5 = "CMR74CMA5";

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
    }

    /// <inheritdoc />
    public override string TableName => "F74R9003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMR74RMID", "CMR74RMID", JdeDataType.Numeric, null, true, true),
        new JdeField("CMICUT", "CMICUT", JdeDataType.String, 4),
        new JdeField("CMDCT", "CMDCT", JdeDataType.String, 4),
        new JdeField("CMR74CMTH", "CMR74CMTH", JdeDataType.String, 4),
        new JdeField("CMR74CPOP", "CMR74CPOP", JdeDataType.String, 4),
        new JdeField("CMR74CMA1", "CMR74CMA1", JdeDataType.String, 6),
        new JdeField("CMR74CMA2", "CMR74CMA2", JdeDataType.String, 6),
        new JdeField("CMR74CMA3", "CMR74CMA3", JdeDataType.String, 6),
        new JdeField("CMR74CMA4", "CMR74CMA4", JdeDataType.String, 20),
        new JdeField("CMR74CMA5", "CMR74CMA5", JdeDataType.String, 20),
        new JdeField("CMUSER", "CMUSER", JdeDataType.String, 20),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20),
        new JdeField("CMJOBN", "CMJOBN", JdeDataType.String, 20),
        new JdeField("CMUPMJ", "CMUPMJ", JdeDataType.Numeric),
        new JdeField("CMUPMT", "CMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R9003_0", "Primary Key on CMR74RMID", new[] { "CMR74RMID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74R9003_2", "Index on CMICUT, CMDCT", new[] { "CMICUT", "CMDCT" })
    };
}
