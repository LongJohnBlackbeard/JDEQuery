using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4310X - .
/// </summary>
public class F4310X : JdeTable
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
        /// CMDOCO.
        /// </summary>
        public const string CMDOCO = "CMDOCO";

        /// <summary>
        /// CMDCTO.
        /// </summary>
        public const string CMDCTO = "CMDCTO";

        /// <summary>
        /// CMKCOO.
        /// </summary>
        public const string CMKCOO = "CMKCOO";

        /// <summary>
        /// CMSFXO.
        /// </summary>
        public const string CMSFXO = "CMSFXO";

        /// <summary>
        /// CMEXSYSINS.
        /// </summary>
        public const string CMEXSYSINS = "CMEXSYSINS";

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
    public override string TableName => "F4310X";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMN001", "CMN001", JdeDataType.Numeric),
        new JdeField("CMDOCO", "CMDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CMDCTO", "CMDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CMKCOO", "CMKCOO", JdeDataType.String, 10, true, true),
        new JdeField("CMSFXO", "CMSFXO", JdeDataType.String, 6, true, true),
        new JdeField("CMEXSYSINS", "CMEXSYSINS", JdeDataType.String, 400, true, true),
        new JdeField("CMUSER", "CMUSER", JdeDataType.String, 20),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20),
        new JdeField("CMMKEY", "CMMKEY", JdeDataType.String, 30),
        new JdeField("CMUPMJ", "CMUPMJ", JdeDataType.Numeric),
        new JdeField("CMUPMT", "CMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4310X_0", "Primary Key on CMDOCO, CMDCTO, CMKCOO, CMSFXO, CMEXSYSINS", new[] { "CMDOCO", "CMDCTO", "CMKCOO", "CMSFXO", "CMEXSYSINS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4310X_2", "Index on CMN001, CMEXSYSINS", new[] { "CMN001", "CMEXSYSINS" })
    };
}
