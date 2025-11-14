using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74UCW03 - .
/// </summary>
public class F74UCW03 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VMKCO.
        /// </summary>
        public const string VMKCO = "VMKCO";

        /// <summary>
        /// VMDOC.
        /// </summary>
        public const string VMDOC = "VMDOC";

        /// <summary>
        /// VMDCT.
        /// </summary>
        public const string VMDCT = "VMDCT";

        /// <summary>
        /// VMPST.
        /// </summary>
        public const string VMPST = "VMPST";

        /// <summary>
        /// VMEV01.
        /// </summary>
        public const string VMEV01 = "VMEV01";

        /// <summary>
        /// VMUKTVPS.
        /// </summary>
        public const string VMUKTVPS = "VMUKTVPS";

        /// <summary>
        /// VMURRF.
        /// </summary>
        public const string VMURRF = "VMURRF";

        /// <summary>
        /// VMURCD.
        /// </summary>
        public const string VMURCD = "VMURCD";

        /// <summary>
        /// VMURAT.
        /// </summary>
        public const string VMURAT = "VMURAT";

        /// <summary>
        /// VMURAB.
        /// </summary>
        public const string VMURAB = "VMURAB";

        /// <summary>
        /// VMURDT.
        /// </summary>
        public const string VMURDT = "VMURDT";

        /// <summary>
        /// VMUSER.
        /// </summary>
        public const string VMUSER = "VMUSER";

        /// <summary>
        /// VMPID.
        /// </summary>
        public const string VMPID = "VMPID";

        /// <summary>
        /// VMJOBN.
        /// </summary>
        public const string VMJOBN = "VMJOBN";

        /// <summary>
        /// VMUPMJ.
        /// </summary>
        public const string VMUPMJ = "VMUPMJ";

        /// <summary>
        /// VMUPMT.
        /// </summary>
        public const string VMUPMT = "VMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74UCW03";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VMKCO", "VMKCO", JdeDataType.String, 10, true, true),
        new JdeField("VMDOC", "VMDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("VMDCT", "VMDCT", JdeDataType.String, 4, true, true),
        new JdeField("VMPST", "VMPST", JdeDataType.String, 2),
        new JdeField("VMEV01", "VMEV01", JdeDataType.String, 2),
        new JdeField("VMUKTVPS", "VMUKTVPS", JdeDataType.String, 2),
        new JdeField("VMURRF", "VMURRF", JdeDataType.String, 30),
        new JdeField("VMURCD", "VMURCD", JdeDataType.String, 4),
        new JdeField("VMURAT", "VMURAT", JdeDataType.Numeric),
        new JdeField("VMURAB", "VMURAB", JdeDataType.Numeric),
        new JdeField("VMURDT", "VMURDT", JdeDataType.Numeric),
        new JdeField("VMUSER", "VMUSER", JdeDataType.String, 20),
        new JdeField("VMPID", "VMPID", JdeDataType.String, 20),
        new JdeField("VMJOBN", "VMJOBN", JdeDataType.String, 20),
        new JdeField("VMUPMJ", "VMUPMJ", JdeDataType.Numeric),
        new JdeField("VMUPMT", "VMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74UCW03_0", "Primary Key on VMKCO, VMDOC, VMDCT", new[] { "VMKCO", "VMDOC", "VMDCT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74UCW03_2", "Index on VMUSER, VMJOBN, VMUPMJ", new[] { "VMUSER", "VMJOBN", "VMUPMJ" })
    };
}
