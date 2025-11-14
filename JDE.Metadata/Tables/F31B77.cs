using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B77 - .
/// </summary>
public class F31B77 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VMWCFGID.
        /// </summary>
        public const string VMWCFGID = "VMWCFGID";

        /// <summary>
        /// VMLNID.
        /// </summary>
        public const string VMLNID = "VMLNID";

        /// <summary>
        /// VMMATYP.
        /// </summary>
        public const string VMMATYP = "VMMATYP";

        /// <summary>
        /// VMWCFTF.
        /// </summary>
        public const string VMWCFTF = "VMWCFTF";

        /// <summary>
        /// VMURCD.
        /// </summary>
        public const string VMURCD = "VMURCD";

        /// <summary>
        /// VMURDT.
        /// </summary>
        public const string VMURDT = "VMURDT";

        /// <summary>
        /// VMURAT.
        /// </summary>
        public const string VMURAT = "VMURAT";

        /// <summary>
        /// VMURAB.
        /// </summary>
        public const string VMURAB = "VMURAB";

        /// <summary>
        /// VMURRF.
        /// </summary>
        public const string VMURRF = "VMURRF";

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
        /// VMTDAY.
        /// </summary>
        public const string VMTDAY = "VMTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31B77";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VMWCFGID", "VMWCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("VMLNID", "VMLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("VMMATYP", "VMMATYP", JdeDataType.String, 8),
        new JdeField("VMWCFTF", "VMWCFTF", JdeDataType.String, 2),
        new JdeField("VMURCD", "VMURCD", JdeDataType.String, 4),
        new JdeField("VMURDT", "VMURDT", JdeDataType.Numeric),
        new JdeField("VMURAT", "VMURAT", JdeDataType.Numeric),
        new JdeField("VMURAB", "VMURAB", JdeDataType.Numeric),
        new JdeField("VMURRF", "VMURRF", JdeDataType.String, 30),
        new JdeField("VMUSER", "VMUSER", JdeDataType.String, 20),
        new JdeField("VMPID", "VMPID", JdeDataType.String, 20),
        new JdeField("VMJOBN", "VMJOBN", JdeDataType.String, 20),
        new JdeField("VMUPMJ", "VMUPMJ", JdeDataType.Numeric),
        new JdeField("VMTDAY", "VMTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B77_0", "Primary Key on VMWCFGID, VMLNID", new[] { "VMWCFGID", "VMLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B77_2", "Index on VMWCFGID, VMMATYP", new[] { "VMWCFGID", "VMMATYP" })
    };
}
