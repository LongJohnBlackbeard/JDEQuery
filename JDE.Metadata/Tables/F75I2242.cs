using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I2242 - .
/// </summary>
public class F75I2242 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DAKCOO.
        /// </summary>
        public const string DAKCOO = "DAKCOO";

        /// <summary>
        /// DADOCO.
        /// </summary>
        public const string DADOCO = "DADOCO";

        /// <summary>
        /// DADCTO.
        /// </summary>
        public const string DADCTO = "DADCTO";

        /// <summary>
        /// DALNID.
        /// </summary>
        public const string DALNID = "DALNID";

        /// <summary>
        /// DANLIN.
        /// </summary>
        public const string DANLIN = "DANLIN";

        /// <summary>
        /// DADOC.
        /// </summary>
        public const string DADOC = "DADOC";

        /// <summary>
        /// DAMCU.
        /// </summary>
        public const string DAMCU = "DAMCU";

        /// <summary>
        /// DAI75DTBG.
        /// </summary>
        public const string DAI75DTBG = "DAI75DTBG";

        /// <summary>
        /// DAI75DFPD.
        /// </summary>
        public const string DAI75DFPD = "DAI75DFPD";

        /// <summary>
        /// DAI75DTEN.
        /// </summary>
        public const string DAI75DTEN = "DAI75DTEN";

        /// <summary>
        /// DAAA.
        /// </summary>
        public const string DAAA = "DAAA";

        /// <summary>
        /// DAUSER.
        /// </summary>
        public const string DAUSER = "DAUSER";

        /// <summary>
        /// DAJOBN.
        /// </summary>
        public const string DAJOBN = "DAJOBN";

        /// <summary>
        /// DAPID.
        /// </summary>
        public const string DAPID = "DAPID";

        /// <summary>
        /// DAUPMJ.
        /// </summary>
        public const string DAUPMJ = "DAUPMJ";

        /// <summary>
        /// DATDAY.
        /// </summary>
        public const string DATDAY = "DATDAY";

        /// <summary>
        /// DAYRM.
        /// </summary>
        public const string DAYRM = "DAYRM";

        /// <summary>
        /// DAAA1.
        /// </summary>
        public const string DAAA1 = "DAAA1";

        /// <summary>
        /// DAFLAG.
        /// </summary>
        public const string DAFLAG = "DAFLAG";

        /// <summary>
        /// DAAA2.
        /// </summary>
        public const string DAAA2 = "DAAA2";
    }

    /// <inheritdoc />
    public override string TableName => "F75I2242";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DAKCOO", "DAKCOO", JdeDataType.String, 10, true, true),
        new JdeField("DADOCO", "DADOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("DADCTO", "DADCTO", JdeDataType.String, 4, true, true),
        new JdeField("DALNID", "DALNID", JdeDataType.Numeric, null, true, true),
        new JdeField("DANLIN", "DANLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("DADOC", "DADOC", JdeDataType.Numeric, null, true, true),
        new JdeField("DAMCU", "DAMCU", JdeDataType.String, 24),
        new JdeField("DAI75DTBG", "DAI75DTBG", JdeDataType.Numeric),
        new JdeField("DAI75DFPD", "DAI75DFPD", JdeDataType.Numeric),
        new JdeField("DAI75DTEN", "DAI75DTEN", JdeDataType.Numeric),
        new JdeField("DAAA", "DAAA", JdeDataType.Numeric),
        new JdeField("DAUSER", "DAUSER", JdeDataType.String, 20),
        new JdeField("DAJOBN", "DAJOBN", JdeDataType.String, 20),
        new JdeField("DAPID", "DAPID", JdeDataType.String, 20),
        new JdeField("DAUPMJ", "DAUPMJ", JdeDataType.Numeric),
        new JdeField("DATDAY", "DATDAY", JdeDataType.Numeric),
        new JdeField("DAYRM", "DAYRM", JdeDataType.Numeric),
        new JdeField("DAAA1", "DAAA1", JdeDataType.Numeric),
        new JdeField("DAFLAG", "DAFLAG", JdeDataType.String, 2),
        new JdeField("DAAA2", "DAAA2", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I2242_0", "Primary Key on DAKCOO, DADOCO, DADCTO, DALNID, DANLIN, DADOC", new[] { "DAKCOO", "DADOCO", "DADCTO", "DALNID", "DANLIN", "DADOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I2242_2", "Index on DAKCOO, DAMCU", new[] { "DAKCOO", "DAMCU" })
    };
}
