using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76M930 - .
/// </summary>
public class F76M930 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// APPYID.
        /// </summary>
        public const string APPYID = "APPYID";

        /// <summary>
        /// APRC5.
        /// </summary>
        public const string APRC5 = "APRC5";

        /// <summary>
        /// APLNID.
        /// </summary>
        public const string APLNID = "APLNID";

        /// <summary>
        /// APDCTM.
        /// </summary>
        public const string APDCTM = "APDCTM";

        /// <summary>
        /// APDOC.
        /// </summary>
        public const string APDOC = "APDOC";

        /// <summary>
        /// APDCT.
        /// </summary>
        public const string APDCT = "APDCT";

        /// <summary>
        /// APKCO.
        /// </summary>
        public const string APKCO = "APKCO";

        /// <summary>
        /// APSFX.
        /// </summary>
        public const string APSFX = "APSFX";

        /// <summary>
        /// APSFXE.
        /// </summary>
        public const string APSFXE = "APSFXE";

        /// <summary>
        /// APM76JEKCO.
        /// </summary>
        public const string APM76JEKCO = "APM76JEKCO";

        /// <summary>
        /// APM76JEDCT.
        /// </summary>
        public const string APM76JEDCT = "APM76JEDCT";

        /// <summary>
        /// APM76JEDOC.
        /// </summary>
        public const string APM76JEDOC = "APM76JEDOC";

        /// <summary>
        /// APM76JELN.
        /// </summary>
        public const string APM76JELN = "APM76JELN";

        /// <summary>
        /// APM76JEDGJ.
        /// </summary>
        public const string APM76JEDGJ = "APM76JEDGJ";

        /// <summary>
        /// APM76JELT.
        /// </summary>
        public const string APM76JELT = "APM76JELT";

        /// <summary>
        /// APM76EXTL.
        /// </summary>
        public const string APM76EXTL = "APM76EXTL";

        /// <summary>
        /// APCO.
        /// </summary>
        public const string APCO = "APCO";

        /// <summary>
        /// APICU.
        /// </summary>
        public const string APICU = "APICU";

        /// <summary>
        /// APICUT.
        /// </summary>
        public const string APICUT = "APICUT";

        /// <summary>
        /// APM76GLTA.
        /// </summary>
        public const string APM76GLTA = "APM76GLTA";

        /// <summary>
        /// APM76GLVA.
        /// </summary>
        public const string APM76GLVA = "APM76GLVA";

        /// <summary>
        /// APBCRC.
        /// </summary>
        public const string APBCRC = "APBCRC";

        /// <summary>
        /// APUSER.
        /// </summary>
        public const string APUSER = "APUSER";

        /// <summary>
        /// APPID.
        /// </summary>
        public const string APPID = "APPID";

        /// <summary>
        /// APUPMJ.
        /// </summary>
        public const string APUPMJ = "APUPMJ";

        /// <summary>
        /// APUPMT.
        /// </summary>
        public const string APUPMT = "APUPMT";

        /// <summary>
        /// APJOBN.
        /// </summary>
        public const string APJOBN = "APJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76M930";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("APPYID", "APPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("APRC5", "APRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("APLNID", "APLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("APDCTM", "APDCTM", JdeDataType.String, 4),
        new JdeField("APDOC", "APDOC", JdeDataType.Numeric),
        new JdeField("APDCT", "APDCT", JdeDataType.String, 4),
        new JdeField("APKCO", "APKCO", JdeDataType.String, 10),
        new JdeField("APSFX", "APSFX", JdeDataType.String, 6),
        new JdeField("APSFXE", "APSFXE", JdeDataType.Numeric),
        new JdeField("APM76JEKCO", "APM76JEKCO", JdeDataType.String, 10),
        new JdeField("APM76JEDCT", "APM76JEDCT", JdeDataType.String, 4),
        new JdeField("APM76JEDOC", "APM76JEDOC", JdeDataType.Numeric),
        new JdeField("APM76JELN", "APM76JELN", JdeDataType.Numeric),
        new JdeField("APM76JEDGJ", "APM76JEDGJ", JdeDataType.Numeric),
        new JdeField("APM76JELT", "APM76JELT", JdeDataType.String, 4),
        new JdeField("APM76EXTL", "APM76EXTL", JdeDataType.String, 4),
        new JdeField("APCO", "APCO", JdeDataType.String, 10),
        new JdeField("APICU", "APICU", JdeDataType.Numeric),
        new JdeField("APICUT", "APICUT", JdeDataType.String, 4),
        new JdeField("APM76GLTA", "APM76GLTA", JdeDataType.Numeric),
        new JdeField("APM76GLVA", "APM76GLVA", JdeDataType.Numeric),
        new JdeField("APBCRC", "APBCRC", JdeDataType.String, 6),
        new JdeField("APUSER", "APUSER", JdeDataType.String, 20),
        new JdeField("APPID", "APPID", JdeDataType.String, 20),
        new JdeField("APUPMJ", "APUPMJ", JdeDataType.Numeric),
        new JdeField("APUPMT", "APUPMT", JdeDataType.Numeric),
        new JdeField("APJOBN", "APJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76M930_0", "Primary Key on APPYID, APRC5, APLNID", new[] { "APPYID", "APRC5", "APLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76M930_2", "Index on APDOC, APDCT, APKCO, APSFX, APSFXE", new[] { "APDOC", "APDCT", "APKCO", "APSFX", "APSFXE" }),
        new JdeIndex("F76M930_3", "Index on APM76JEKCO, APM76JEDCT, APM76JEDOC, APM76JELN, APM76JEDGJ, APM76JELT, APM76EXTL", new[] { "APM76JEKCO", "APM76JEDCT", "APM76JEDOC", "APM76JELN", "APM76JEDGJ", "APM76JELT", "APM76EXTL" })
    };
}
