using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I828 - .
/// </summary>
public class F75I828 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// APDOCO.
        /// </summary>
        public const string APDOCO = "APDOCO";

        /// <summary>
        /// APDCTO.
        /// </summary>
        public const string APDCTO = "APDCTO";

        /// <summary>
        /// APKCOO.
        /// </summary>
        public const string APKCOO = "APKCOO";

        /// <summary>
        /// APLNID.
        /// </summary>
        public const string APLNID = "APLNID";

        /// <summary>
        /// API75INVNO.
        /// </summary>
        public const string API75INVNO = "API75INVNO";

        /// <summary>
        /// APPYID.
        /// </summary>
        public const string APPYID = "APPYID";

        /// <summary>
        /// APRC5.
        /// </summary>
        public const string APRC5 = "APRC5";

        /// <summary>
        /// APCKNU.
        /// </summary>
        public const string APCKNU = "APCKNU";

        /// <summary>
        /// APUSER.
        /// </summary>
        public const string APUSER = "APUSER";

        /// <summary>
        /// APPID.
        /// </summary>
        public const string APPID = "APPID";

        /// <summary>
        /// APJOBN.
        /// </summary>
        public const string APJOBN = "APJOBN";

        /// <summary>
        /// APUPMJ.
        /// </summary>
        public const string APUPMJ = "APUPMJ";

        /// <summary>
        /// APUPMT.
        /// </summary>
        public const string APUPMT = "APUPMT";

        /// <summary>
        /// APYFUTDT1.
        /// </summary>
        public const string APYFUTDT1 = "APYFUTDT1";

        /// <summary>
        /// APFUT6.
        /// </summary>
        public const string APFUT6 = "APFUT6";

        /// <summary>
        /// APYT04.
        /// </summary>
        public const string APYT04 = "APYT04";

        /// <summary>
        /// APYFLAG.
        /// </summary>
        public const string APYFLAG = "APYFLAG";

        /// <summary>
        /// APYNUM1.
        /// </summary>
        public const string APYNUM1 = "APYNUM1";

        /// <summary>
        /// APICU.
        /// </summary>
        public const string APICU = "APICU";

        /// <summary>
        /// APICUT.
        /// </summary>
        public const string APICUT = "APICUT";

        /// <summary>
        /// API75IGSTA.
        /// </summary>
        public const string API75IGSTA = "API75IGSTA";

        /// <summary>
        /// API75CGSTA.
        /// </summary>
        public const string API75CGSTA = "API75CGSTA";

        /// <summary>
        /// API75SGSTA.
        /// </summary>
        public const string API75SGSTA = "API75SGSTA";

        /// <summary>
        /// API75CESSA.
        /// </summary>
        public const string API75CESSA = "API75CESSA";

        /// <summary>
        /// API75ATX2A.
        /// </summary>
        public const string API75ATX2A = "API75ATX2A";

        /// <summary>
        /// API75ATX1A.
        /// </summary>
        public const string API75ATX1A = "API75ATX1A";

        /// <summary>
        /// API75ATX3A.
        /// </summary>
        public const string API75ATX3A = "API75ATX3A";

        /// <summary>
        /// API75AT4A.
        /// </summary>
        public const string API75AT4A = "API75AT4A";

        /// <summary>
        /// APDE.
        /// </summary>
        public const string APDE = "APDE";
    }

    /// <inheritdoc />
    public override string TableName => "F75I828";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("APDOCO", "APDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("APDCTO", "APDCTO", JdeDataType.String, 4, true, true),
        new JdeField("APKCOO", "APKCOO", JdeDataType.String, 10, true, true),
        new JdeField("APLNID", "APLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("API75INVNO", "API75INVNO", JdeDataType.String, 50),
        new JdeField("APPYID", "APPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("APRC5", "APRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("APCKNU", "APCKNU", JdeDataType.String, 50),
        new JdeField("APUSER", "APUSER", JdeDataType.String, 20),
        new JdeField("APPID", "APPID", JdeDataType.String, 20),
        new JdeField("APJOBN", "APJOBN", JdeDataType.String, 20),
        new JdeField("APUPMJ", "APUPMJ", JdeDataType.Numeric),
        new JdeField("APUPMT", "APUPMT", JdeDataType.Numeric),
        new JdeField("APYFUTDT1", "APYFUTDT1", JdeDataType.Numeric),
        new JdeField("APFUT6", "APFUT6", JdeDataType.String, 60),
        new JdeField("APYT04", "APYT04", JdeDataType.String, 2),
        new JdeField("APYFLAG", "APYFLAG", JdeDataType.String, 2),
        new JdeField("APYNUM1", "APYNUM1", JdeDataType.Numeric),
        new JdeField("APICU", "APICU", JdeDataType.Numeric),
        new JdeField("APICUT", "APICUT", JdeDataType.String, 4),
        new JdeField("API75IGSTA", "API75IGSTA", JdeDataType.Numeric),
        new JdeField("API75CGSTA", "API75CGSTA", JdeDataType.Numeric),
        new JdeField("API75SGSTA", "API75SGSTA", JdeDataType.Numeric),
        new JdeField("API75CESSA", "API75CESSA", JdeDataType.Numeric),
        new JdeField("API75ATX2A", "API75ATX2A", JdeDataType.Numeric),
        new JdeField("API75ATX1A", "API75ATX1A", JdeDataType.Numeric),
        new JdeField("API75ATX3A", "API75ATX3A", JdeDataType.Numeric),
        new JdeField("API75AT4A", "API75AT4A", JdeDataType.Numeric),
        new JdeField("APDE", "APDE", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I828_0", "Primary Key on APDOCO, APDCTO, APKCOO, APLNID, APPYID, APRC5", new[] { "APDOCO", "APDCTO", "APKCOO", "APLNID", "APPYID", "APRC5" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I828_2", "Index on APPYID, APRC5", new[] { "APPYID", "APRC5" })
    };
}
