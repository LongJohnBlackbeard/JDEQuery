using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H3B20 - .
/// </summary>
public class F76H3B20 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADH76LECO.
        /// </summary>
        public const string ADH76LECO = "ADH76LECO";

        /// <summary>
        /// ADH76LEDT.
        /// </summary>
        public const string ADH76LEDT = "ADH76LEDT";

        /// <summary>
        /// ADH76EMS.
        /// </summary>
        public const string ADH76EMS = "ADH76EMS";

        /// <summary>
        /// ADH76LENU.
        /// </summary>
        public const string ADH76LENU = "ADH76LENU";

        /// <summary>
        /// ADH76CNDT.
        /// </summary>
        public const string ADH76CNDT = "ADH76CNDT";

        /// <summary>
        /// ADH76CNCD.
        /// </summary>
        public const string ADH76CNCD = "ADH76CNCD";

        /// <summary>
        /// ADH76CNDE.
        /// </summary>
        public const string ADH76CNDE = "ADH76CNDE";

        /// <summary>
        /// ADH76IRPT.
        /// </summary>
        public const string ADH76IRPT = "ADH76IRPT";

        /// <summary>
        /// ADH76IDPR.
        /// </summary>
        public const string ADH76IDPR = "ADH76IDPR";

        /// <summary>
        /// ADH76IRMA.
        /// </summary>
        public const string ADH76IRMA = "ADH76IRMA";

        /// <summary>
        /// ADH76IDRM.
        /// </summary>
        public const string ADH76IDRM = "ADH76IDRM";

        /// <summary>
        /// ADOKCO.
        /// </summary>
        public const string ADOKCO = "ADOKCO";

        /// <summary>
        /// ADODCT.
        /// </summary>
        public const string ADODCT = "ADODCT";

        /// <summary>
        /// ADODOC.
        /// </summary>
        public const string ADODOC = "ADODOC";

        /// <summary>
        /// ADUSER.
        /// </summary>
        public const string ADUSER = "ADUSER";

        /// <summary>
        /// ADPID.
        /// </summary>
        public const string ADPID = "ADPID";

        /// <summary>
        /// ADJOBN.
        /// </summary>
        public const string ADJOBN = "ADJOBN";

        /// <summary>
        /// ADUPMJ.
        /// </summary>
        public const string ADUPMJ = "ADUPMJ";

        /// <summary>
        /// ADUPMT.
        /// </summary>
        public const string ADUPMT = "ADUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H3B20";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADH76LECO", "ADH76LECO", JdeDataType.String, 10, true, true),
        new JdeField("ADH76LEDT", "ADH76LEDT", JdeDataType.String, 6, true, true),
        new JdeField("ADH76EMS", "ADH76EMS", JdeDataType.String, 8, true, true),
        new JdeField("ADH76LENU", "ADH76LENU", JdeDataType.Numeric, null, true, true),
        new JdeField("ADH76CNDT", "ADH76CNDT", JdeDataType.Numeric),
        new JdeField("ADH76CNCD", "ADH76CNCD", JdeDataType.String, 20),
        new JdeField("ADH76CNDE", "ADH76CNDE", JdeDataType.String, 60),
        new JdeField("ADH76IRPT", "ADH76IRPT", JdeDataType.String, 2),
        new JdeField("ADH76IDPR", "ADH76IDPR", JdeDataType.Numeric),
        new JdeField("ADH76IRMA", "ADH76IRMA", JdeDataType.String, 2),
        new JdeField("ADH76IDRM", "ADH76IDRM", JdeDataType.Numeric),
        new JdeField("ADOKCO", "ADOKCO", JdeDataType.String, 10),
        new JdeField("ADODCT", "ADODCT", JdeDataType.String, 4),
        new JdeField("ADODOC", "ADODOC", JdeDataType.Numeric),
        new JdeField("ADUSER", "ADUSER", JdeDataType.String, 20),
        new JdeField("ADPID", "ADPID", JdeDataType.String, 20),
        new JdeField("ADJOBN", "ADJOBN", JdeDataType.String, 20),
        new JdeField("ADUPMJ", "ADUPMJ", JdeDataType.Numeric),
        new JdeField("ADUPMT", "ADUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H3B20_0", "Primary Key on ADH76LECO, ADH76LEDT, ADH76EMS, ADH76LENU", new[] { "ADH76LECO", "ADH76LEDT", "ADH76EMS", "ADH76LENU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76H3B20_3", "Index on ADH76CNDT, ADH76LECO, ADH76LEDT, ADH76EMS, ADH76LENU", new[] { "ADH76CNDT", "ADH76LECO", "ADH76LEDT", "ADH76EMS", "ADH76LENU" }),
        new JdeIndex("F76H3B20_4", "Index on ADOKCO, ADODCT, ADODOC, ADH76LECO, ADH76LEDT, ADH76EMS, ADH76LENU", new[] { "ADOKCO", "ADODCT", "ADODOC", "ADH76LECO", "ADH76LEDT", "ADH76EMS", "ADH76LENU" }),
        new JdeIndex("F76H3B20_5", "Index on ADOKCO, ADODCT, ADODOC, ADH76CNDT", new[] { "ADOKCO", "ADODCT", "ADODOC", "ADH76CNDT" }),
        new JdeIndex("F76H3B20_6", "Index on ADOKCO, ADODCT, ADODOC, ADH76LECO, ADH76LEDT, SYS_NC00020$, SYS_NC00021$", new[] { "ADOKCO", "ADODCT", "ADODOC", "ADH76LECO", "ADH76LEDT", "SYS_NC00020$", "SYS_NC00021$" })
    };
}
