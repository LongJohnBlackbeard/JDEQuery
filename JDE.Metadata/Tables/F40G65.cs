using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G65 - .
/// </summary>
public class F40G65 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FOWOPID.
        /// </summary>
        public const string FOWOPID = "FOWOPID";

        /// <summary>
        /// FOWCFGID.
        /// </summary>
        public const string FOWCFGID = "FOWCFGID";

        /// <summary>
        /// FOITM.
        /// </summary>
        public const string FOITM = "FOITM";

        /// <summary>
        /// FOLITM.
        /// </summary>
        public const string FOLITM = "FOLITM";

        /// <summary>
        /// FOMCU.
        /// </summary>
        public const string FOMCU = "FOMCU";

        /// <summary>
        /// FOTARGORG.
        /// </summary>
        public const string FOTARGORG = "FOTARGORG";

        /// <summary>
        /// FOPLTAREA.
        /// </summary>
        public const string FOPLTAREA = "FOPLTAREA";

        /// <summary>
        /// FOTRTAREA.
        /// </summary>
        public const string FOTRTAREA = "FOTRTAREA";

        /// <summary>
        /// FOAREAUOM.
        /// </summary>
        public const string FOAREAUOM = "FOAREAUOM";

        /// <summary>
        /// FOHARACT.
        /// </summary>
        public const string FOHARACT = "FOHARACT";

        /// <summary>
        /// FOHAWUOMT.
        /// </summary>
        public const string FOHAWUOMT = "FOHAWUOMT";

        /// <summary>
        /// FOPRACT.
        /// </summary>
        public const string FOPRACT = "FOPRACT";

        /// <summary>
        /// FOPAWUOMT.
        /// </summary>
        public const string FOPAWUOMT = "FOPAWUOMT";

        /// <summary>
        /// FOREBLK.
        /// </summary>
        public const string FOREBLK = "FOREBLK";

        /// <summary>
        /// FOREWUOMT.
        /// </summary>
        public const string FOREWUOMT = "FOREWUOMT";

        /// <summary>
        /// FOSUBACT.
        /// </summary>
        public const string FOSUBACT = "FOSUBACT";

        /// <summary>
        /// FOSAWUOMT.
        /// </summary>
        public const string FOSAWUOMT = "FOSAWUOMT";

        /// <summary>
        /// FOVALHAR.
        /// </summary>
        public const string FOVALHAR = "FOVALHAR";

        /// <summary>
        /// FOVALPRR.
        /// </summary>
        public const string FOVALPRR = "FOVALPRR";

        /// <summary>
        /// FOVALREN.
        /// </summary>
        public const string FOVALREN = "FOVALREN";

        /// <summary>
        /// FOVALSUB.
        /// </summary>
        public const string FOVALSUB = "FOVALSUB";

        /// <summary>
        /// FOWOSPRAY.
        /// </summary>
        public const string FOWOSPRAY = "FOWOSPRAY";

        /// <summary>
        /// FOSPMETH.
        /// </summary>
        public const string FOSPMETH = "FOSPMETH";

        /// <summary>
        /// FOSPTYPE.
        /// </summary>
        public const string FOSPTYPE = "FOSPTYPE";

        /// <summary>
        /// FOCHEMCDE.
        /// </summary>
        public const string FOCHEMCDE = "FOCHEMCDE";

        /// <summary>
        /// FOSPLNUM.
        /// </summary>
        public const string FOSPLNUM = "FOSPLNUM";

        /// <summary>
        /// FOPRDTYPE.
        /// </summary>
        public const string FOPRDTYPE = "FOPRDTYPE";

        /// <summary>
        /// FOSITECDE.
        /// </summary>
        public const string FOSITECDE = "FOSITECDE";

        /// <summary>
        /// FOABCRTOR.
        /// </summary>
        public const string FOABCRTOR = "FOABCRTOR";

        /// <summary>
        /// FODTCRT.
        /// </summary>
        public const string FODTCRT = "FODTCRT";

        /// <summary>
        /// FOOPER.
        /// </summary>
        public const string FOOPER = "FOOPER";

        /// <summary>
        /// FOIMCU.
        /// </summary>
        public const string FOIMCU = "FOIMCU";

        /// <summary>
        /// FODTPERF.
        /// </summary>
        public const string FODTPERF = "FODTPERF";

        /// <summary>
        /// FOFARMCDE.
        /// </summary>
        public const string FOFARMCDE = "FOFARMCDE";

        /// <summary>
        /// FOFARMDSC.
        /// </summary>
        public const string FOFARMDSC = "FOFARMDSC";

        /// <summary>
        /// FOFARMVAL.
        /// </summary>
        public const string FOFARMVAL = "FOFARMVAL";

        /// <summary>
        /// FOGRWOPER.
        /// </summary>
        public const string FOGRWOPER = "FOGRWOPER";

        /// <summary>
        /// FOFARMUOM.
        /// </summary>
        public const string FOFARMUOM = "FOFARMUOM";

        /// <summary>
        /// FOURCD.
        /// </summary>
        public const string FOURCD = "FOURCD";

        /// <summary>
        /// FOURDT.
        /// </summary>
        public const string FOURDT = "FOURDT";

        /// <summary>
        /// FOURRF.
        /// </summary>
        public const string FOURRF = "FOURRF";

        /// <summary>
        /// FOURAT.
        /// </summary>
        public const string FOURAT = "FOURAT";

        /// <summary>
        /// FOURAB.
        /// </summary>
        public const string FOURAB = "FOURAB";

        /// <summary>
        /// FOUSER.
        /// </summary>
        public const string FOUSER = "FOUSER";

        /// <summary>
        /// FOTORG.
        /// </summary>
        public const string FOTORG = "FOTORG";

        /// <summary>
        /// FOJOBN.
        /// </summary>
        public const string FOJOBN = "FOJOBN";

        /// <summary>
        /// FOPID.
        /// </summary>
        public const string FOPID = "FOPID";

        /// <summary>
        /// FOUUPMJ.
        /// </summary>
        public const string FOUUPMJ = "FOUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40G65";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FOWOPID", "FOWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("FOWCFGID", "FOWCFGID", JdeDataType.Numeric),
        new JdeField("FOITM", "FOITM", JdeDataType.Numeric),
        new JdeField("FOLITM", "FOLITM", JdeDataType.String, 50),
        new JdeField("FOMCU", "FOMCU", JdeDataType.String, 24),
        new JdeField("FOTARGORG", "FOTARGORG", JdeDataType.String, 100),
        new JdeField("FOPLTAREA", "FOPLTAREA", JdeDataType.Numeric),
        new JdeField("FOTRTAREA", "FOTRTAREA", JdeDataType.Numeric),
        new JdeField("FOAREAUOM", "FOAREAUOM", JdeDataType.String, 4),
        new JdeField("FOHARACT", "FOHARACT", JdeDataType.Numeric),
        new JdeField("FOHAWUOMT", "FOHAWUOMT", JdeDataType.String, 2),
        new JdeField("FOPRACT", "FOPRACT", JdeDataType.Numeric),
        new JdeField("FOPAWUOMT", "FOPAWUOMT", JdeDataType.String, 2),
        new JdeField("FOREBLK", "FOREBLK", JdeDataType.Numeric),
        new JdeField("FOREWUOMT", "FOREWUOMT", JdeDataType.String, 2),
        new JdeField("FOSUBACT", "FOSUBACT", JdeDataType.Numeric),
        new JdeField("FOSAWUOMT", "FOSAWUOMT", JdeDataType.String, 2),
        new JdeField("FOVALHAR", "FOVALHAR", JdeDataType.String, 2),
        new JdeField("FOVALPRR", "FOVALPRR", JdeDataType.String, 2),
        new JdeField("FOVALREN", "FOVALREN", JdeDataType.String, 2),
        new JdeField("FOVALSUB", "FOVALSUB", JdeDataType.String, 2),
        new JdeField("FOWOSPRAY", "FOWOSPRAY", JdeDataType.String, 2),
        new JdeField("FOSPMETH", "FOSPMETH", JdeDataType.String, 4),
        new JdeField("FOSPTYPE", "FOSPTYPE", JdeDataType.String, 4),
        new JdeField("FOCHEMCDE", "FOCHEMCDE", JdeDataType.String, 16),
        new JdeField("FOSPLNUM", "FOSPLNUM", JdeDataType.String, 60),
        new JdeField("FOPRDTYPE", "FOPRDTYPE", JdeDataType.String, 4),
        new JdeField("FOSITECDE", "FOSITECDE", JdeDataType.String, 4),
        new JdeField("FOABCRTOR", "FOABCRTOR", JdeDataType.Numeric),
        new JdeField("FODTCRT", "FODTCRT", JdeDataType.Date),
        new JdeField("FOOPER", "FOOPER", JdeDataType.Numeric),
        new JdeField("FOIMCU", "FOIMCU", JdeDataType.String, 24),
        new JdeField("FODTPERF", "FODTPERF", JdeDataType.Date),
        new JdeField("FOFARMCDE", "FOFARMCDE", JdeDataType.String, 20),
        new JdeField("FOFARMDSC", "FOFARMDSC", JdeDataType.String, 60),
        new JdeField("FOFARMVAL", "FOFARMVAL", JdeDataType.Numeric),
        new JdeField("FOGRWOPER", "FOGRWOPER", JdeDataType.String, 30),
        new JdeField("FOFARMUOM", "FOFARMUOM", JdeDataType.String, 4),
        new JdeField("FOURCD", "FOURCD", JdeDataType.String, 4),
        new JdeField("FOURDT", "FOURDT", JdeDataType.Numeric),
        new JdeField("FOURRF", "FOURRF", JdeDataType.String, 30),
        new JdeField("FOURAT", "FOURAT", JdeDataType.Numeric),
        new JdeField("FOURAB", "FOURAB", JdeDataType.Numeric),
        new JdeField("FOUSER", "FOUSER", JdeDataType.String, 20),
        new JdeField("FOTORG", "FOTORG", JdeDataType.String, 20),
        new JdeField("FOJOBN", "FOJOBN", JdeDataType.String, 20),
        new JdeField("FOPID", "FOPID", JdeDataType.String, 20),
        new JdeField("FOUUPMJ", "FOUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G65_0", "Primary Key on FOWOPID", new[] { "FOWOPID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40G65_2", "Index on FOWOPID, FOWCFGID", new[] { "FOWOPID", "FOWCFGID" })
    };
}
