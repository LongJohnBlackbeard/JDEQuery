using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4930 - .
/// </summary>
public class F4930 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VMVEHI.
        /// </summary>
        public const string VMVEHI = "VMVEHI";

        /// <summary>
        /// VMVEHS.
        /// </summary>
        public const string VMVEHS = "VMVEHS";

        /// <summary>
        /// VMDL01.
        /// </summary>
        public const string VMDL01 = "VMDL01";

        /// <summary>
        /// VMLRFG.
        /// </summary>
        public const string VMLRFG = "VMLRFG";

        /// <summary>
        /// VMMCU.
        /// </summary>
        public const string VMMCU = "VMMCU";

        /// <summary>
        /// VMVTYP.
        /// </summary>
        public const string VMVTYP = "VMVTYP";

        /// <summary>
        /// VMDUMV.
        /// </summary>
        public const string VMDUMV = "VMDUMV";

        /// <summary>
        /// VMVOWN.
        /// </summary>
        public const string VMVOWN = "VMVOWN";

        /// <summary>
        /// VMNCE.
        /// </summary>
        public const string VMNCE = "VMNCE";

        /// <summary>
        /// VMWTEM.
        /// </summary>
        public const string VMWTEM = "VMWTEM";

        /// <summary>
        /// VMWTCA.
        /// </summary>
        public const string VMWTCA = "VMWTCA";

        /// <summary>
        /// VMWTUM.
        /// </summary>
        public const string VMWTUM = "VMWTUM";

        /// <summary>
        /// VMVLCP.
        /// </summary>
        public const string VMVLCP = "VMVLCP";

        /// <summary>
        /// VMVLCS.
        /// </summary>
        public const string VMVLCS = "VMVLCS";

        /// <summary>
        /// VMVLUM.
        /// </summary>
        public const string VMVLUM = "VMVLUM";

        /// <summary>
        /// VMCVOL.
        /// </summary>
        public const string VMCVOL = "VMCVOL";

        /// <summary>
        /// VMCVUM.
        /// </summary>
        public const string VMCVUM = "VMCVUM";

        /// <summary>
        /// VMLCNT.
        /// </summary>
        public const string VMLCNT = "VMLCNT";

        /// <summary>
        /// VMMXML.
        /// </summary>
        public const string VMMXML = "VMMXML";

        /// <summary>
        /// VMUMD1.
        /// </summary>
        public const string VMUMD1 = "VMUMD1";

        /// <summary>
        /// VMINMG.
        /// </summary>
        public const string VMINMG = "VMINMG";

        /// <summary>
        /// VMMEST.
        /// </summary>
        public const string VMMEST = "VMMEST";

        /// <summary>
        /// VMVEHN.
        /// </summary>
        public const string VMVEHN = "VMVEHN";

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
    public override string TableName => "F4930";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VMVEHI", "VMVEHI", JdeDataType.String, 24, true, true),
        new JdeField("VMVEHS", "VMVEHS", JdeDataType.String, 50),
        new JdeField("VMDL01", "VMDL01", JdeDataType.String, 60),
        new JdeField("VMLRFG", "VMLRFG", JdeDataType.String, 2),
        new JdeField("VMMCU", "VMMCU", JdeDataType.String, 24),
        new JdeField("VMVTYP", "VMVTYP", JdeDataType.String, 24),
        new JdeField("VMDUMV", "VMDUMV", JdeDataType.String, 2),
        new JdeField("VMVOWN", "VMVOWN", JdeDataType.Numeric),
        new JdeField("VMNCE", "VMNCE", JdeDataType.Numeric),
        new JdeField("VMWTEM", "VMWTEM", JdeDataType.Numeric),
        new JdeField("VMWTCA", "VMWTCA", JdeDataType.Numeric),
        new JdeField("VMWTUM", "VMWTUM", JdeDataType.String, 4),
        new JdeField("VMVLCP", "VMVLCP", JdeDataType.Numeric),
        new JdeField("VMVLCS", "VMVLCS", JdeDataType.Numeric),
        new JdeField("VMVLUM", "VMVLUM", JdeDataType.String, 4),
        new JdeField("VMCVOL", "VMCVOL", JdeDataType.Numeric),
        new JdeField("VMCVUM", "VMCVUM", JdeDataType.String, 4),
        new JdeField("VMLCNT", "VMLCNT", JdeDataType.Numeric),
        new JdeField("VMMXML", "VMMXML", JdeDataType.Numeric),
        new JdeField("VMUMD1", "VMUMD1", JdeDataType.String, 4),
        new JdeField("VMINMG", "VMINMG", JdeDataType.String, 20),
        new JdeField("VMMEST", "VMMEST", JdeDataType.String, 2),
        new JdeField("VMVEHN", "VMVEHN", JdeDataType.Numeric),
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
        new JdeIndex("F4930_0", "Primary Key on VMVEHI", new[] { "VMVEHI" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4930_2", "Index on VMVEHS", new[] { "VMVEHS" })
    };
}
