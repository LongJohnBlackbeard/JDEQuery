using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49010 - .
/// </summary>
public class F49010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VMVEHN.
        /// </summary>
        public const string VMVEHN = "VMVEHN";

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
        /// VMVEHT.
        /// </summary>
        public const string VMVEHT = "VMVEHT";

        /// <summary>
        /// VMMETR.
        /// </summary>
        public const string VMMETR = "VMMETR";

        /// <summary>
        /// VMLDIN.
        /// </summary>
        public const string VMLDIN = "VMLDIN";

        /// <summary>
        /// VMDUMV.
        /// </summary>
        public const string VMDUMV = "VMDUMV";

        /// <summary>
        /// VMVCBP.
        /// </summary>
        public const string VMVCBP = "VMVCBP";

        /// <summary>
        /// VMMLLN.
        /// </summary>
        public const string VMMLLN = "VMMLLN";

        /// <summary>
        /// VMDATY.
        /// </summary>
        public const string VMDATY = "VMDATY";

        /// <summary>
        /// VMVOWN.
        /// </summary>
        public const string VMVOWN = "VMVOWN";

        /// <summary>
        /// VMMOT.
        /// </summary>
        public const string VMMOT = "VMMOT";

        /// <summary>
        /// VMAXLE.
        /// </summary>
        public const string VMAXLE = "VMAXLE";

        /// <summary>
        /// VMWTAX.
        /// </summary>
        public const string VMWTAX = "VMWTAX";

        /// <summary>
        /// VMSEAL.
        /// </summary>
        public const string VMSEAL = "VMSEAL";

        /// <summary>
        /// VMDSGP.
        /// </summary>
        public const string VMDSGP = "VMDSGP";

        /// <summary>
        /// VMDSGS.
        /// </summary>
        public const string VMDSGS = "VMDSGS";

        /// <summary>
        /// VMDSPU.
        /// </summary>
        public const string VMDSPU = "VMDSPU";

        /// <summary>
        /// VMWTEM.
        /// </summary>
        public const string VMWTEM = "VMWTEM";

        /// <summary>
        /// VMWTUM.
        /// </summary>
        public const string VMWTUM = "VMWTUM";

        /// <summary>
        /// VMVLUM.
        /// </summary>
        public const string VMVLUM = "VMVLUM";

        /// <summary>
        /// VMVLCP.
        /// </summary>
        public const string VMVLCP = "VMVLCP";

        /// <summary>
        /// VMVLCS.
        /// </summary>
        public const string VMVLCS = "VMVLCS";

        /// <summary>
        /// VMNCE.
        /// </summary>
        public const string VMNCE = "VMNCE";

        /// <summary>
        /// VMWTCA.
        /// </summary>
        public const string VMWTCA = "VMWTCA";

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
        /// VMTRF1.
        /// </summary>
        public const string VMTRF1 = "VMTRF1";

        /// <summary>
        /// VMTRF2.
        /// </summary>
        public const string VMTRF2 = "VMTRF2";

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
    public override string TableName => "F49010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VMVEHN", "VMVEHN", JdeDataType.Numeric, null, true, true),
        new JdeField("VMVEHI", "VMVEHI", JdeDataType.String, 24),
        new JdeField("VMVEHS", "VMVEHS", JdeDataType.String, 50),
        new JdeField("VMDL01", "VMDL01", JdeDataType.String, 60),
        new JdeField("VMLRFG", "VMLRFG", JdeDataType.String, 2),
        new JdeField("VMMCU", "VMMCU", JdeDataType.String, 24),
        new JdeField("VMVEHT", "VMVEHT", JdeDataType.String, 6),
        new JdeField("VMMETR", "VMMETR", JdeDataType.String, 2),
        new JdeField("VMLDIN", "VMLDIN", JdeDataType.String, 2),
        new JdeField("VMDUMV", "VMDUMV", JdeDataType.String, 2),
        new JdeField("VMVCBP", "VMVCBP", JdeDataType.String, 2),
        new JdeField("VMMLLN", "VMMLLN", JdeDataType.String, 2),
        new JdeField("VMDATY", "VMDATY", JdeDataType.String, 2),
        new JdeField("VMVOWN", "VMVOWN", JdeDataType.Numeric),
        new JdeField("VMMOT", "VMMOT", JdeDataType.String, 6),
        new JdeField("VMAXLE", "VMAXLE", JdeDataType.Numeric),
        new JdeField("VMWTAX", "VMWTAX", JdeDataType.Numeric),
        new JdeField("VMSEAL", "VMSEAL", JdeDataType.Numeric),
        new JdeField("VMDSGP", "VMDSGP", JdeDataType.String, 6),
        new JdeField("VMDSGS", "VMDSGS", JdeDataType.String, 6),
        new JdeField("VMDSPU", "VMDSPU", JdeDataType.String, 4),
        new JdeField("VMWTEM", "VMWTEM", JdeDataType.Numeric),
        new JdeField("VMWTUM", "VMWTUM", JdeDataType.String, 4),
        new JdeField("VMVLUM", "VMVLUM", JdeDataType.String, 4),
        new JdeField("VMVLCP", "VMVLCP", JdeDataType.Numeric),
        new JdeField("VMVLCS", "VMVLCS", JdeDataType.Numeric),
        new JdeField("VMNCE", "VMNCE", JdeDataType.Numeric),
        new JdeField("VMWTCA", "VMWTCA", JdeDataType.Numeric),
        new JdeField("VMLCNT", "VMLCNT", JdeDataType.Numeric),
        new JdeField("VMMXML", "VMMXML", JdeDataType.Numeric),
        new JdeField("VMUMD1", "VMUMD1", JdeDataType.String, 4),
        new JdeField("VMINMG", "VMINMG", JdeDataType.String, 20),
        new JdeField("VMMEST", "VMMEST", JdeDataType.String, 2),
        new JdeField("VMTRF1", "VMTRF1", JdeDataType.String, 20),
        new JdeField("VMTRF2", "VMTRF2", JdeDataType.String, 20),
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
        new JdeIndex("F49010_0", "Primary Key on VMVEHN", new[] { "VMVEHN" }, isUnique: true, isPrimaryKey: true)
    };
}
