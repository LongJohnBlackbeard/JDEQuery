using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I857 - .
/// </summary>
public class F75I857 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
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
        /// CMODOC.
        /// </summary>
        public const string CMODOC = "CMODOC";

        /// <summary>
        /// CMODCT.
        /// </summary>
        public const string CMODCT = "CMODCT";

        /// <summary>
        /// CMOKCO.
        /// </summary>
        public const string CMOKCO = "CMOKCO";

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
        /// CMYFUTDT1.
        /// </summary>
        public const string CMYFUTDT1 = "CMYFUTDT1";

        /// <summary>
        /// CMFUT6.
        /// </summary>
        public const string CMFUT6 = "CMFUT6";

        /// <summary>
        /// CMYT04.
        /// </summary>
        public const string CMYT04 = "CMYT04";

        /// <summary>
        /// CMYFLAG.
        /// </summary>
        public const string CMYFLAG = "CMYFLAG";

        /// <summary>
        /// CMYNUM1.
        /// </summary>
        public const string CMYNUM1 = "CMYNUM1";

        /// <summary>
        /// CMI75RSMT.
        /// </summary>
        public const string CMI75RSMT = "CMI75RSMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I857";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMDOC", "CMDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("CMDCT", "CMDCT", JdeDataType.String, 4, true, true),
        new JdeField("CMKCO", "CMKCO", JdeDataType.String, 10, true, true),
        new JdeField("CMODOC", "CMODOC", JdeDataType.Numeric),
        new JdeField("CMODCT", "CMODCT", JdeDataType.String, 4),
        new JdeField("CMOKCO", "CMOKCO", JdeDataType.String, 10),
        new JdeField("CMUSER", "CMUSER", JdeDataType.String, 20),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20),
        new JdeField("CMJOBN", "CMJOBN", JdeDataType.String, 20),
        new JdeField("CMUPMJ", "CMUPMJ", JdeDataType.Numeric),
        new JdeField("CMUPMT", "CMUPMT", JdeDataType.Numeric),
        new JdeField("CMYFUTDT1", "CMYFUTDT1", JdeDataType.Numeric),
        new JdeField("CMFUT6", "CMFUT6", JdeDataType.String, 60),
        new JdeField("CMYT04", "CMYT04", JdeDataType.String, 2),
        new JdeField("CMYFLAG", "CMYFLAG", JdeDataType.String, 2),
        new JdeField("CMYNUM1", "CMYNUM1", JdeDataType.Numeric),
        new JdeField("CMI75RSMT", "CMI75RSMT", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I857_0", "Primary Key on CMDOC, CMDCT, CMKCO", new[] { "CMDOC", "CMDCT", "CMKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
