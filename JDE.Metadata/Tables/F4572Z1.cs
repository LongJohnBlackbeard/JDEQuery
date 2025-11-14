using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4572Z1 - .
/// </summary>
public class F4572Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LPEDUS.
        /// </summary>
        public const string LPEDUS = "LPEDUS";

        /// <summary>
        /// LPEDBT.
        /// </summary>
        public const string LPEDBT = "LPEDBT";

        /// <summary>
        /// LPEDTN.
        /// </summary>
        public const string LPEDTN = "LPEDTN";

        /// <summary>
        /// LPEDLN.
        /// </summary>
        public const string LPEDLN = "LPEDLN";

        /// <summary>
        /// LPTNTY.
        /// </summary>
        public const string LPTNTY = "LPTNTY";

        /// <summary>
        /// LPTNAC.
        /// </summary>
        public const string LPTNAC = "LPTNAC";

        /// <summary>
        /// LPEDSP.
        /// </summary>
        public const string LPEDSP = "LPEDSP";

        /// <summary>
        /// LPEDTY.
        /// </summary>
        public const string LPEDTY = "LPEDTY";

        /// <summary>
        /// LPEDSQ.
        /// </summary>
        public const string LPEDSQ = "LPEDSQ";

        /// <summary>
        /// LPEDCT.
        /// </summary>
        public const string LPEDCT = "LPEDCT";

        /// <summary>
        /// LPEDTS.
        /// </summary>
        public const string LPEDTS = "LPEDTS";

        /// <summary>
        /// LPEDFT.
        /// </summary>
        public const string LPEDFT = "LPEDFT";

        /// <summary>
        /// LPEDDT.
        /// </summary>
        public const string LPEDDT = "LPEDDT";

        /// <summary>
        /// LPEDER.
        /// </summary>
        public const string LPEDER = "LPEDER";

        /// <summary>
        /// LPEDDL.
        /// </summary>
        public const string LPEDDL = "LPEDDL";

        /// <summary>
        /// LPDRIN.
        /// </summary>
        public const string LPDRIN = "LPDRIN";

        /// <summary>
        /// LPPLANID.
        /// </summary>
        public const string LPPLANID = "LPPLANID";

        /// <summary>
        /// LPPLNAME.
        /// </summary>
        public const string LPPLNAME = "LPPLNAME";

        /// <summary>
        /// LPPROMID.
        /// </summary>
        public const string LPPROMID = "LPPROMID";

        /// <summary>
        /// LPPRNAME.
        /// </summary>
        public const string LPPRNAME = "LPPRNAME";

        /// <summary>
        /// LPEFTJ.
        /// </summary>
        public const string LPEFTJ = "LPEFTJ";

        /// <summary>
        /// LPEXDJ.
        /// </summary>
        public const string LPEXDJ = "LPEXDJ";

        /// <summary>
        /// LPAN8.
        /// </summary>
        public const string LPAN8 = "LPAN8";

        /// <summary>
        /// LPITM.
        /// </summary>
        public const string LPITM = "LPITM";

        /// <summary>
        /// LPLITM.
        /// </summary>
        public const string LPLITM = "LPLITM";

        /// <summary>
        /// LPAITM.
        /// </summary>
        public const string LPAITM = "LPAITM";

        /// <summary>
        /// LPCRCD.
        /// </summary>
        public const string LPCRCD = "LPCRCD";

        /// <summary>
        /// LPUOM.
        /// </summary>
        public const string LPUOM = "LPUOM";

        /// <summary>
        /// LPCOSTYP.
        /// </summary>
        public const string LPCOSTYP = "LPCOSTYP";

        /// <summary>
        /// LPPROMAA.
        /// </summary>
        public const string LPPROMAA = "LPPROMAA";

        /// <summary>
        /// LPDTAI.
        /// </summary>
        public const string LPDTAI = "LPDTAI";

        /// <summary>
        /// LPPRPURG.
        /// </summary>
        public const string LPPRPURG = "LPPRPURG";

        /// <summary>
        /// LPPRMASK.
        /// </summary>
        public const string LPPRMASK = "LPPRMASK";

        /// <summary>
        /// LPPRCODE.
        /// </summary>
        public const string LPPRCODE = "LPPRCODE";

        /// <summary>
        /// LPPRDAT1.
        /// </summary>
        public const string LPPRDAT1 = "LPPRDAT1";

        /// <summary>
        /// LPPRDAT2.
        /// </summary>
        public const string LPPRDAT2 = "LPPRDAT2";

        /// <summary>
        /// LPPRAMNT.
        /// </summary>
        public const string LPPRAMNT = "LPPRAMNT";

        /// <summary>
        /// LPPRNUMB.
        /// </summary>
        public const string LPPRNUMB = "LPPRNUMB";

        /// <summary>
        /// LPPRREFR.
        /// </summary>
        public const string LPPRREFR = "LPPRREFR";

        /// <summary>
        /// LPPROMFL.
        /// </summary>
        public const string LPPROMFL = "LPPROMFL";

        /// <summary>
        /// LPURRF.
        /// </summary>
        public const string LPURRF = "LPURRF";

        /// <summary>
        /// LPURCD.
        /// </summary>
        public const string LPURCD = "LPURCD";

        /// <summary>
        /// LPURDT.
        /// </summary>
        public const string LPURDT = "LPURDT";

        /// <summary>
        /// LPURAT.
        /// </summary>
        public const string LPURAT = "LPURAT";

        /// <summary>
        /// LPURAB.
        /// </summary>
        public const string LPURAB = "LPURAB";

        /// <summary>
        /// LPTORG.
        /// </summary>
        public const string LPTORG = "LPTORG";

        /// <summary>
        /// LPUSER.
        /// </summary>
        public const string LPUSER = "LPUSER";

        /// <summary>
        /// LPPID.
        /// </summary>
        public const string LPPID = "LPPID";

        /// <summary>
        /// LPJOBN.
        /// </summary>
        public const string LPJOBN = "LPJOBN";

        /// <summary>
        /// LPUPMJ.
        /// </summary>
        public const string LPUPMJ = "LPUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F4572Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LPEDUS", "LPEDUS", JdeDataType.String, 20, true, true),
        new JdeField("LPEDBT", "LPEDBT", JdeDataType.String, 30, true, true),
        new JdeField("LPEDTN", "LPEDTN", JdeDataType.String, 44, true, true),
        new JdeField("LPEDLN", "LPEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("LPTNTY", "LPTNTY", JdeDataType.String, 4),
        new JdeField("LPTNAC", "LPTNAC", JdeDataType.String, 4),
        new JdeField("LPEDSP", "LPEDSP", JdeDataType.String, 2),
        new JdeField("LPEDTY", "LPEDTY", JdeDataType.String, 2),
        new JdeField("LPEDSQ", "LPEDSQ", JdeDataType.Numeric),
        new JdeField("LPEDCT", "LPEDCT", JdeDataType.String, 4),
        new JdeField("LPEDTS", "LPEDTS", JdeDataType.String, 12),
        new JdeField("LPEDFT", "LPEDFT", JdeDataType.String, 20),
        new JdeField("LPEDDT", "LPEDDT", JdeDataType.Numeric),
        new JdeField("LPEDER", "LPEDER", JdeDataType.String, 2),
        new JdeField("LPEDDL", "LPEDDL", JdeDataType.Numeric),
        new JdeField("LPDRIN", "LPDRIN", JdeDataType.String, 2),
        new JdeField("LPPLANID", "LPPLANID", JdeDataType.String, 30),
        new JdeField("LPPLNAME", "LPPLNAME", JdeDataType.String, 100),
        new JdeField("LPPROMID", "LPPROMID", JdeDataType.String, 30),
        new JdeField("LPPRNAME", "LPPRNAME", JdeDataType.String, 100),
        new JdeField("LPEFTJ", "LPEFTJ", JdeDataType.Numeric),
        new JdeField("LPEXDJ", "LPEXDJ", JdeDataType.Numeric),
        new JdeField("LPAN8", "LPAN8", JdeDataType.Numeric),
        new JdeField("LPITM", "LPITM", JdeDataType.Numeric),
        new JdeField("LPLITM", "LPLITM", JdeDataType.String, 50),
        new JdeField("LPAITM", "LPAITM", JdeDataType.String, 50),
        new JdeField("LPCRCD", "LPCRCD", JdeDataType.String, 6),
        new JdeField("LPUOM", "LPUOM", JdeDataType.String, 4),
        new JdeField("LPCOSTYP", "LPCOSTYP", JdeDataType.String, 2),
        new JdeField("LPPROMAA", "LPPROMAA", JdeDataType.Numeric),
        new JdeField("LPDTAI", "LPDTAI", JdeDataType.String, 20),
        new JdeField("LPPRPURG", "LPPRPURG", JdeDataType.String, 2),
        new JdeField("LPPRMASK", "LPPRMASK", JdeDataType.String, 2),
        new JdeField("LPPRCODE", "LPPRCODE", JdeDataType.String, 4),
        new JdeField("LPPRDAT1", "LPPRDAT1", JdeDataType.Numeric),
        new JdeField("LPPRDAT2", "LPPRDAT2", JdeDataType.Numeric),
        new JdeField("LPPRAMNT", "LPPRAMNT", JdeDataType.Numeric),
        new JdeField("LPPRNUMB", "LPPRNUMB", JdeDataType.Numeric),
        new JdeField("LPPRREFR", "LPPRREFR", JdeDataType.String, 60),
        new JdeField("LPPROMFL", "LPPROMFL", JdeDataType.String, 2),
        new JdeField("LPURRF", "LPURRF", JdeDataType.String, 30),
        new JdeField("LPURCD", "LPURCD", JdeDataType.String, 4),
        new JdeField("LPURDT", "LPURDT", JdeDataType.Numeric),
        new JdeField("LPURAT", "LPURAT", JdeDataType.Numeric),
        new JdeField("LPURAB", "LPURAB", JdeDataType.Numeric),
        new JdeField("LPTORG", "LPTORG", JdeDataType.String, 20),
        new JdeField("LPUSER", "LPUSER", JdeDataType.String, 20),
        new JdeField("LPPID", "LPPID", JdeDataType.String, 20),
        new JdeField("LPJOBN", "LPJOBN", JdeDataType.String, 20),
        new JdeField("LPUPMJ", "LPUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4572Z1_0", "Primary Key on LPEDUS, LPEDBT, LPEDTN, LPEDLN", new[] { "LPEDUS", "LPEDBT", "LPEDTN", "LPEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
