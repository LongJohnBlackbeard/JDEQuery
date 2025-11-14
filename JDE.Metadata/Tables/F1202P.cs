using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1202P - .
/// </summary>
public class F1202P : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FLAID.
        /// </summary>
        public const string FLAID = "FLAID";

        /// <summary>
        /// FLCTRY.
        /// </summary>
        public const string FLCTRY = "FLCTRY";

        /// <summary>
        /// FLFY.
        /// </summary>
        public const string FLFY = "FLFY";

        /// <summary>
        /// FLFQ.
        /// </summary>
        public const string FLFQ = "FLFQ";

        /// <summary>
        /// FLLT.
        /// </summary>
        public const string FLLT = "FLLT";

        /// <summary>
        /// FLSBL.
        /// </summary>
        public const string FLSBL = "FLSBL";

        /// <summary>
        /// FLCO.
        /// </summary>
        public const string FLCO = "FLCO";

        /// <summary>
        /// FLAPYC.
        /// </summary>
        public const string FLAPYC = "FLAPYC";

        /// <summary>
        /// FLAN01.
        /// </summary>
        public const string FLAN01 = "FLAN01";

        /// <summary>
        /// FLAN02.
        /// </summary>
        public const string FLAN02 = "FLAN02";

        /// <summary>
        /// FLAN03.
        /// </summary>
        public const string FLAN03 = "FLAN03";

        /// <summary>
        /// FLAN04.
        /// </summary>
        public const string FLAN04 = "FLAN04";

        /// <summary>
        /// FLAN05.
        /// </summary>
        public const string FLAN05 = "FLAN05";

        /// <summary>
        /// FLAN06.
        /// </summary>
        public const string FLAN06 = "FLAN06";

        /// <summary>
        /// FLAN07.
        /// </summary>
        public const string FLAN07 = "FLAN07";

        /// <summary>
        /// FLAN08.
        /// </summary>
        public const string FLAN08 = "FLAN08";

        /// <summary>
        /// FLAN09.
        /// </summary>
        public const string FLAN09 = "FLAN09";

        /// <summary>
        /// FLAN10.
        /// </summary>
        public const string FLAN10 = "FLAN10";

        /// <summary>
        /// FLAN11.
        /// </summary>
        public const string FLAN11 = "FLAN11";

        /// <summary>
        /// FLAN12.
        /// </summary>
        public const string FLAN12 = "FLAN12";

        /// <summary>
        /// FLAN13.
        /// </summary>
        public const string FLAN13 = "FLAN13";

        /// <summary>
        /// FLAN14.
        /// </summary>
        public const string FLAN14 = "FLAN14";

        /// <summary>
        /// FLAPYN.
        /// </summary>
        public const string FLAPYN = "FLAPYN";

        /// <summary>
        /// FLAWTD.
        /// </summary>
        public const string FLAWTD = "FLAWTD";

        /// <summary>
        /// FLBORG.
        /// </summary>
        public const string FLBORG = "FLBORG";

        /// <summary>
        /// FLPOU.
        /// </summary>
        public const string FLPOU = "FLPOU";

        /// <summary>
        /// FLPC.
        /// </summary>
        public const string FLPC = "FLPC";

        /// <summary>
        /// FLTKER.
        /// </summary>
        public const string FLTKER = "FLTKER";

        /// <summary>
        /// FLBREQ.
        /// </summary>
        public const string FLBREQ = "FLBREQ";

        /// <summary>
        /// FLBAPR.
        /// </summary>
        public const string FLBAPR = "FLBAPR";

        /// <summary>
        /// FLMCU.
        /// </summary>
        public const string FLMCU = "FLMCU";

        /// <summary>
        /// FLOBJ.
        /// </summary>
        public const string FLOBJ = "FLOBJ";

        /// <summary>
        /// FLSUB.
        /// </summary>
        public const string FLSUB = "FLSUB";

        /// <summary>
        /// FLNUMB.
        /// </summary>
        public const string FLNUMB = "FLNUMB";

        /// <summary>
        /// FLADLM.
        /// </summary>
        public const string FLADLM = "FLADLM";

        /// <summary>
        /// FLADM.
        /// </summary>
        public const string FLADM = "FLADM";

        /// <summary>
        /// FLITAC.
        /// </summary>
        public const string FLITAC = "FLITAC";

        /// <summary>
        /// FLADMP.
        /// </summary>
        public const string FLADMP = "FLADMP";

        /// <summary>
        /// FLADSN.
        /// </summary>
        public const string FLADSN = "FLADSN";

        /// <summary>
        /// FLDIR1.
        /// </summary>
        public const string FLDIR1 = "FLDIR1";

        /// <summary>
        /// FLDSD.
        /// </summary>
        public const string FLDSD = "FLDSD";

        /// <summary>
        /// FLUSER.
        /// </summary>
        public const string FLUSER = "FLUSER";

        /// <summary>
        /// FLLCT.
        /// </summary>
        public const string FLLCT = "FLLCT";

        /// <summary>
        /// FLPID.
        /// </summary>
        public const string FLPID = "FLPID";

        /// <summary>
        /// FLSBLT.
        /// </summary>
        public const string FLSBLT = "FLSBLT";

        /// <summary>
        /// FLCRCD.
        /// </summary>
        public const string FLCRCD = "FLCRCD";

        /// <summary>
        /// FLUPMJ.
        /// </summary>
        public const string FLUPMJ = "FLUPMJ";

        /// <summary>
        /// FLJOBN.
        /// </summary>
        public const string FLJOBN = "FLJOBN";

        /// <summary>
        /// FLUPMT.
        /// </summary>
        public const string FLUPMT = "FLUPMT";

        /// <summary>
        /// FLCHCD.
        /// </summary>
        public const string FLCHCD = "FLCHCD";

        /// <summary>
        /// FLDPCF.
        /// </summary>
        public const string FLDPCF = "FLDPCF";

        /// <summary>
        /// FLCBXR.
        /// </summary>
        public const string FLCBXR = "FLCBXR";
    }

    /// <inheritdoc />
    public override string TableName => "F1202P";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FLAID", "FLAID", JdeDataType.String, 16, true, true),
        new JdeField("FLCTRY", "FLCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("FLFY", "FLFY", JdeDataType.Numeric, null, true, true),
        new JdeField("FLFQ", "FLFQ", JdeDataType.String, 8, true, true),
        new JdeField("FLLT", "FLLT", JdeDataType.String, 4, true, true),
        new JdeField("FLSBL", "FLSBL", JdeDataType.String, 16, true, true),
        new JdeField("FLCO", "FLCO", JdeDataType.String, 10),
        new JdeField("FLAPYC", "FLAPYC", JdeDataType.Numeric),
        new JdeField("FLAN01", "FLAN01", JdeDataType.Numeric),
        new JdeField("FLAN02", "FLAN02", JdeDataType.Numeric),
        new JdeField("FLAN03", "FLAN03", JdeDataType.Numeric),
        new JdeField("FLAN04", "FLAN04", JdeDataType.Numeric),
        new JdeField("FLAN05", "FLAN05", JdeDataType.Numeric),
        new JdeField("FLAN06", "FLAN06", JdeDataType.Numeric),
        new JdeField("FLAN07", "FLAN07", JdeDataType.Numeric),
        new JdeField("FLAN08", "FLAN08", JdeDataType.Numeric),
        new JdeField("FLAN09", "FLAN09", JdeDataType.Numeric),
        new JdeField("FLAN10", "FLAN10", JdeDataType.Numeric),
        new JdeField("FLAN11", "FLAN11", JdeDataType.Numeric),
        new JdeField("FLAN12", "FLAN12", JdeDataType.Numeric),
        new JdeField("FLAN13", "FLAN13", JdeDataType.Numeric),
        new JdeField("FLAN14", "FLAN14", JdeDataType.Numeric),
        new JdeField("FLAPYN", "FLAPYN", JdeDataType.Numeric),
        new JdeField("FLAWTD", "FLAWTD", JdeDataType.Numeric),
        new JdeField("FLBORG", "FLBORG", JdeDataType.Numeric),
        new JdeField("FLPOU", "FLPOU", JdeDataType.Numeric),
        new JdeField("FLPC", "FLPC", JdeDataType.Numeric),
        new JdeField("FLTKER", "FLTKER", JdeDataType.Numeric),
        new JdeField("FLBREQ", "FLBREQ", JdeDataType.Numeric),
        new JdeField("FLBAPR", "FLBAPR", JdeDataType.Numeric),
        new JdeField("FLMCU", "FLMCU", JdeDataType.String, 24),
        new JdeField("FLOBJ", "FLOBJ", JdeDataType.String, 12),
        new JdeField("FLSUB", "FLSUB", JdeDataType.String, 16),
        new JdeField("FLNUMB", "FLNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("FLADLM", "FLADLM", JdeDataType.Numeric),
        new JdeField("FLADM", "FLADM", JdeDataType.String, 4),
        new JdeField("FLITAC", "FLITAC", JdeDataType.String, 2),
        new JdeField("FLADMP", "FLADMP", JdeDataType.Numeric),
        new JdeField("FLADSN", "FLADSN", JdeDataType.String, 24),
        new JdeField("FLDIR1", "FLDIR1", JdeDataType.String, 2),
        new JdeField("FLDSD", "FLDSD", JdeDataType.Numeric),
        new JdeField("FLUSER", "FLUSER", JdeDataType.String, 20),
        new JdeField("FLLCT", "FLLCT", JdeDataType.Numeric),
        new JdeField("FLPID", "FLPID", JdeDataType.String, 20),
        new JdeField("FLSBLT", "FLSBLT", JdeDataType.String, 2, true, true),
        new JdeField("FLCRCD", "FLCRCD", JdeDataType.String, 6),
        new JdeField("FLUPMJ", "FLUPMJ", JdeDataType.Numeric),
        new JdeField("FLJOBN", "FLJOBN", JdeDataType.String, 20),
        new JdeField("FLUPMT", "FLUPMT", JdeDataType.Numeric),
        new JdeField("FLCHCD", "FLCHCD", JdeDataType.String, 2),
        new JdeField("FLDPCF", "FLDPCF", JdeDataType.String, 2),
        new JdeField("FLCBXR", "FLCBXR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1202P_0", "Primary Key on FLAID, FLCTRY, FLFY, FLFQ, FLNUMB, FLSBL, FLSBLT, FLLT", new[] { "FLAID", "FLCTRY", "FLFY", "FLFQ", "FLNUMB", "FLSBL", "FLSBLT", "FLLT" }, isUnique: true, isPrimaryKey: true)
    };
}
