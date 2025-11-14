using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L902 - .
/// </summary>
public class FF30L902 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDPMAPID.
        /// </summary>
        public const string PDPMAPID = "PDPMAPID";

        /// <summary>
        /// PDFSCID.
        /// </summary>
        public const string PDFSCID = "PDFSCID";

        /// <summary>
        /// PDDFITM.
        /// </summary>
        public const string PDDFITM = "PDDFITM";

        /// <summary>
        /// PDDFMCU.
        /// </summary>
        public const string PDDFMCU = "PDDFMCU";

        /// <summary>
        /// PDPROID.
        /// </summary>
        public const string PDPROID = "PDPROID";

        /// <summary>
        /// PDPRNA.
        /// </summary>
        public const string PDPRNA = "PDPRNA";

        /// <summary>
        /// PDPRPHTY.
        /// </summary>
        public const string PDPRPHTY = "PDPRPHTY";

        /// <summary>
        /// PDDFLITM.
        /// </summary>
        public const string PDDFLITM = "PDDFLITM";

        /// <summary>
        /// PDDFAITM.
        /// </summary>
        public const string PDDFAITM = "PDDFAITM";

        /// <summary>
        /// PDCELLID.
        /// </summary>
        public const string PDCELLID = "PDCELLID";

        /// <summary>
        /// PDCELLN.
        /// </summary>
        public const string PDCELLN = "PDCELLN";

        /// <summary>
        /// PDPMMST.
        /// </summary>
        public const string PDPMMST = "PDPMMST";

        /// <summary>
        /// PDPMMRT.
        /// </summary>
        public const string PDPMMRT = "PDPMMRT";

        /// <summary>
        /// PDPMMMT.
        /// </summary>
        public const string PDPMMMT = "PDPMMMT";

        /// <summary>
        /// PDPMLST.
        /// </summary>
        public const string PDPMLST = "PDPMLST";

        /// <summary>
        /// PDPMLRT.
        /// </summary>
        public const string PDPMLRT = "PDPMLRT";

        /// <summary>
        /// PDPMLMT.
        /// </summary>
        public const string PDPMLMT = "PDPMLMT";

        /// <summary>
        /// PDADJDC.
        /// </summary>
        public const string PDADJDC = "PDADJDC";

        /// <summary>
        /// PDWCDS.
        /// </summary>
        public const string PDWCDS = "PDWCDS";

        /// <summary>
        /// PDSSOEID.
        /// </summary>
        public const string PDSSOEID = "PDSSOEID";

        /// <summary>
        /// PDSSOEN.
        /// </summary>
        public const string PDSSOEN = "PDSSOEN";

        /// <summary>
        /// PDURCD.
        /// </summary>
        public const string PDURCD = "PDURCD";

        /// <summary>
        /// PDURDT.
        /// </summary>
        public const string PDURDT = "PDURDT";

        /// <summary>
        /// PDURAT.
        /// </summary>
        public const string PDURAT = "PDURAT";

        /// <summary>
        /// PDURAB.
        /// </summary>
        public const string PDURAB = "PDURAB";

        /// <summary>
        /// PDURRF.
        /// </summary>
        public const string PDURRF = "PDURRF";

        /// <summary>
        /// PDUSER.
        /// </summary>
        public const string PDUSER = "PDUSER";

        /// <summary>
        /// PDPID.
        /// </summary>
        public const string PDPID = "PDPID";

        /// <summary>
        /// PDMKEY.
        /// </summary>
        public const string PDMKEY = "PDMKEY";

        /// <summary>
        /// PDUUPMJ.
        /// </summary>
        public const string PDUUPMJ = "PDUUPMJ";

        /// <summary>
        /// PDDLWC.
        /// </summary>
        public const string PDDLWC = "PDDLWC";

        /// <summary>
        /// PDDMWC.
        /// </summary>
        public const string PDDMWC = "PDDMWC";

        /// <summary>
        /// PDCOPPC.
        /// </summary>
        public const string PDCOPPC = "PDCOPPC";

        /// <summary>
        /// PDCSCPC.
        /// </summary>
        public const string PDCSCPC = "PDCSCPC";

        /// <summary>
        /// PDCTPPC.
        /// </summary>
        public const string PDCTPPC = "PDCTPPC";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L902";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDPMAPID", "PDPMAPID", JdeDataType.Numeric, null, true, true),
        new JdeField("PDFSCID", "PDFSCID", JdeDataType.Numeric),
        new JdeField("PDDFITM", "PDDFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PDDFMCU", "PDDFMCU", JdeDataType.String, 24, true, true),
        new JdeField("PDPROID", "PDPROID", JdeDataType.Numeric, null, true, true),
        new JdeField("PDPRNA", "PDPRNA", JdeDataType.String, 60),
        new JdeField("PDPRPHTY", "PDPRPHTY", JdeDataType.String, 4),
        new JdeField("PDDFLITM", "PDDFLITM", JdeDataType.String, 50),
        new JdeField("PDDFAITM", "PDDFAITM", JdeDataType.String, 50),
        new JdeField("PDCELLID", "PDCELLID", JdeDataType.Numeric),
        new JdeField("PDCELLN", "PDCELLN", JdeDataType.String, 30),
        new JdeField("PDPMMST", "PDPMMST", JdeDataType.Numeric),
        new JdeField("PDPMMRT", "PDPMMRT", JdeDataType.Numeric),
        new JdeField("PDPMMMT", "PDPMMMT", JdeDataType.Numeric),
        new JdeField("PDPMLST", "PDPMLST", JdeDataType.Numeric),
        new JdeField("PDPMLRT", "PDPMLRT", JdeDataType.Numeric),
        new JdeField("PDPMLMT", "PDPMLMT", JdeDataType.Numeric),
        new JdeField("PDADJDC", "PDADJDC", JdeDataType.Numeric),
        new JdeField("PDWCDS", "PDWCDS", JdeDataType.String, 6),
        new JdeField("PDSSOEID", "PDSSOEID", JdeDataType.Numeric),
        new JdeField("PDSSOEN", "PDSSOEN", JdeDataType.String, 60),
        new JdeField("PDURCD", "PDURCD", JdeDataType.String, 4),
        new JdeField("PDURDT", "PDURDT", JdeDataType.Numeric),
        new JdeField("PDURAT", "PDURAT", JdeDataType.Numeric),
        new JdeField("PDURAB", "PDURAB", JdeDataType.Numeric),
        new JdeField("PDURRF", "PDURRF", JdeDataType.String, 30),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20),
        new JdeField("PDMKEY", "PDMKEY", JdeDataType.String, 30),
        new JdeField("PDUUPMJ", "PDUUPMJ", JdeDataType.Date),
        new JdeField("PDDLWC", "PDDLWC", JdeDataType.Numeric),
        new JdeField("PDDMWC", "PDDMWC", JdeDataType.Numeric),
        new JdeField("PDCOPPC", "PDCOPPC", JdeDataType.Numeric),
        new JdeField("PDCSCPC", "PDCSCPC", JdeDataType.Numeric),
        new JdeField("PDCTPPC", "PDCTPPC", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L902_0", "Primary Key on PDPMAPID, PDDFITM, PDDFMCU, PDPROID", new[] { "PDPMAPID", "PDDFITM", "PDDFMCU", "PDPROID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L902_2", "Index on PDFSCID, PDPRNA, PDDFITM, PDCELLN", new[] { "PDFSCID", "PDPRNA", "PDDFITM", "PDCELLN" }),
        new JdeIndex("FF30L902_3", "Index on PDPMAPID", new[] { "PDPMAPID" })
    };
}
