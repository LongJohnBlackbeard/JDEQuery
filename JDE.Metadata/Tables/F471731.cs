using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F471731 - .
/// </summary>
public class F471731 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EPEDTY.
        /// </summary>
        public const string EPEDTY = "EPEDTY";

        /// <summary>
        /// EPEDSQ.
        /// </summary>
        public const string EPEDSQ = "EPEDSQ";

        /// <summary>
        /// EPEKCO.
        /// </summary>
        public const string EPEKCO = "EPEKCO";

        /// <summary>
        /// EPEDOC.
        /// </summary>
        public const string EPEDOC = "EPEDOC";

        /// <summary>
        /// EPEDCT.
        /// </summary>
        public const string EPEDCT = "EPEDCT";

        /// <summary>
        /// EPEDLN.
        /// </summary>
        public const string EPEDLN = "EPEDLN";

        /// <summary>
        /// EPEDST.
        /// </summary>
        public const string EPEDST = "EPEDST";

        /// <summary>
        /// EPEDFT.
        /// </summary>
        public const string EPEDFT = "EPEDFT";

        /// <summary>
        /// EPEDDT.
        /// </summary>
        public const string EPEDDT = "EPEDDT";

        /// <summary>
        /// EPEDER.
        /// </summary>
        public const string EPEDER = "EPEDER";

        /// <summary>
        /// EPEDDL.
        /// </summary>
        public const string EPEDDL = "EPEDDL";

        /// <summary>
        /// EPEDSP.
        /// </summary>
        public const string EPEDSP = "EPEDSP";

        /// <summary>
        /// EPEDBT.
        /// </summary>
        public const string EPEDBT = "EPEDBT";

        /// <summary>
        /// EPEDSLN.
        /// </summary>
        public const string EPEDSLN = "EPEDSLN";

        /// <summary>
        /// EPDMDPKGS.
        /// </summary>
        public const string EPDMDPKGS = "EPDMDPKGS";

        /// <summary>
        /// EPSTPK.
        /// </summary>
        public const string EPSTPK = "EPSTPK";

        /// <summary>
        /// EPUOM.
        /// </summary>
        public const string EPUOM = "EPUOM";

        /// <summary>
        /// EPRETCONT.
        /// </summary>
        public const string EPRETCONT = "EPRETCONT";

        /// <summary>
        /// EPTYPPKGID.
        /// </summary>
        public const string EPTYPPKGID = "EPTYPPKGID";

        /// <summary>
        /// EPPKGWT.
        /// </summary>
        public const string EPPKGWT = "EPPKGWT";

        /// <summary>
        /// EPPKGWTUOM.
        /// </summary>
        public const string EPPKGWTUOM = "EPPKGWTUOM";

        /// <summary>
        /// EPURCD.
        /// </summary>
        public const string EPURCD = "EPURCD";

        /// <summary>
        /// EPURDT.
        /// </summary>
        public const string EPURDT = "EPURDT";

        /// <summary>
        /// EPURAT.
        /// </summary>
        public const string EPURAT = "EPURAT";

        /// <summary>
        /// EPURAB.
        /// </summary>
        public const string EPURAB = "EPURAB";

        /// <summary>
        /// EPURRF.
        /// </summary>
        public const string EPURRF = "EPURRF";

        /// <summary>
        /// EPUSER.
        /// </summary>
        public const string EPUSER = "EPUSER";

        /// <summary>
        /// EPPID.
        /// </summary>
        public const string EPPID = "EPPID";

        /// <summary>
        /// EPJOBN.
        /// </summary>
        public const string EPJOBN = "EPJOBN";

        /// <summary>
        /// EPUPMJ.
        /// </summary>
        public const string EPUPMJ = "EPUPMJ";

        /// <summary>
        /// EPTDAY.
        /// </summary>
        public const string EPTDAY = "EPTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F471731";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EPEDTY", "EPEDTY", JdeDataType.String, 2),
        new JdeField("EPEDSQ", "EPEDSQ", JdeDataType.Numeric),
        new JdeField("EPEKCO", "EPEKCO", JdeDataType.String, 10, true, true),
        new JdeField("EPEDOC", "EPEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("EPEDCT", "EPEDCT", JdeDataType.String, 4, true, true),
        new JdeField("EPEDLN", "EPEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("EPEDST", "EPEDST", JdeDataType.String, 12),
        new JdeField("EPEDFT", "EPEDFT", JdeDataType.String, 20),
        new JdeField("EPEDDT", "EPEDDT", JdeDataType.Numeric),
        new JdeField("EPEDER", "EPEDER", JdeDataType.String, 2),
        new JdeField("EPEDDL", "EPEDDL", JdeDataType.Numeric),
        new JdeField("EPEDSP", "EPEDSP", JdeDataType.String, 2),
        new JdeField("EPEDBT", "EPEDBT", JdeDataType.String, 30),
        new JdeField("EPEDSLN", "EPEDSLN", JdeDataType.Numeric, null, true, true),
        new JdeField("EPDMDPKGS", "EPDMDPKGS", JdeDataType.Numeric),
        new JdeField("EPSTPK", "EPSTPK", JdeDataType.Numeric),
        new JdeField("EPUOM", "EPUOM", JdeDataType.String, 4),
        new JdeField("EPRETCONT", "EPRETCONT", JdeDataType.String, 70),
        new JdeField("EPTYPPKGID", "EPTYPPKGID", JdeDataType.String, 34),
        new JdeField("EPPKGWT", "EPPKGWT", JdeDataType.Numeric),
        new JdeField("EPPKGWTUOM", "EPPKGWTUOM", JdeDataType.String, 6),
        new JdeField("EPURCD", "EPURCD", JdeDataType.String, 4),
        new JdeField("EPURDT", "EPURDT", JdeDataType.Numeric),
        new JdeField("EPURAT", "EPURAT", JdeDataType.Numeric),
        new JdeField("EPURAB", "EPURAB", JdeDataType.Numeric),
        new JdeField("EPURRF", "EPURRF", JdeDataType.String, 30),
        new JdeField("EPUSER", "EPUSER", JdeDataType.String, 20),
        new JdeField("EPPID", "EPPID", JdeDataType.String, 20),
        new JdeField("EPJOBN", "EPJOBN", JdeDataType.String, 20),
        new JdeField("EPUPMJ", "EPUPMJ", JdeDataType.Numeric),
        new JdeField("EPTDAY", "EPTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F471731_0", "Primary Key on EPEDOC, EPEDCT, EPEKCO, EPEDLN, EPEDSLN", new[] { "EPEDOC", "EPEDCT", "EPEKCO", "EPEDLN", "EPEDSLN" }, isUnique: true, isPrimaryKey: true)
    };
}
