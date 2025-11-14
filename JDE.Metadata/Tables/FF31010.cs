using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF31010 - .
/// </summary>
public class FF31010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EHUKID.
        /// </summary>
        public const string EHUKID = "EHUKID";

        /// <summary>
        /// EHPRODF31.
        /// </summary>
        public const string EHPRODF31 = "EHPRODF31";

        /// <summary>
        /// EHITM.
        /// </summary>
        public const string EHITM = "EHITM";

        /// <summary>
        /// EHLITM.
        /// </summary>
        public const string EHLITM = "EHLITM";

        /// <summary>
        /// EHAITM.
        /// </summary>
        public const string EHAITM = "EHAITM";

        /// <summary>
        /// EHMMCU.
        /// </summary>
        public const string EHMMCU = "EHMMCU";

        /// <summary>
        /// EHDFMLINE.
        /// </summary>
        public const string EHDFMLINE = "EHDFMLINE";

        /// <summary>
        /// EHSHFT.
        /// </summary>
        public const string EHSHFT = "EHSHFT";

        /// <summary>
        /// EHLOCN.
        /// </summary>
        public const string EHLOCN = "EHLOCN";

        /// <summary>
        /// EHLOTN.
        /// </summary>
        public const string EHLOTN = "EHLOTN";

        /// <summary>
        /// EHSTTSL.
        /// </summary>
        public const string EHSTTSL = "EHSTTSL";

        /// <summary>
        /// EHDOCO.
        /// </summary>
        public const string EHDOCO = "EHDOCO";

        /// <summary>
        /// EHDCTO.
        /// </summary>
        public const string EHDCTO = "EHDCTO";

        /// <summary>
        /// EHLNID.
        /// </summary>
        public const string EHLNID = "EHLNID";

        /// <summary>
        /// EHSOQTY.
        /// </summary>
        public const string EHSOQTY = "EHSOQTY";

        /// <summary>
        /// EHPPDJ.
        /// </summary>
        public const string EHPPDJ = "EHPPDJ";

        /// <summary>
        /// EHCUPRT.
        /// </summary>
        public const string EHCUPRT = "EHCUPRT";

        /// <summary>
        /// EHKCOO.
        /// </summary>
        public const string EHKCOO = "EHKCOO";

        /// <summary>
        /// EHTRANDATE.
        /// </summary>
        public const string EHTRANDATE = "EHTRANDATE";

        /// <summary>
        /// EHPCDATE.
        /// </summary>
        public const string EHPCDATE = "EHPCDATE";

        /// <summary>
        /// EHPLQTY.
        /// </summary>
        public const string EHPLQTY = "EHPLQTY";

        /// <summary>
        /// EHACCQTY.
        /// </summary>
        public const string EHACCQTY = "EHACCQTY";

        /// <summary>
        /// EHACSCQTY.
        /// </summary>
        public const string EHACSCQTY = "EHACSCQTY";

        /// <summary>
        /// EHUOM.
        /// </summary>
        public const string EHUOM = "EHUOM";

        /// <summary>
        /// EHACQNTY.
        /// </summary>
        public const string EHACQNTY = "EHACQNTY";

        /// <summary>
        /// EHASQNTY.
        /// </summary>
        public const string EHASQNTY = "EHASQNTY";

        /// <summary>
        /// EHUM.
        /// </summary>
        public const string EHUM = "EHUM";

        /// <summary>
        /// EHAN8.
        /// </summary>
        public const string EHAN8 = "EHAN8";

        /// <summary>
        /// EHLORG.
        /// </summary>
        public const string EHLORG = "EHLORG";

        /// <summary>
        /// EHLPREP.
        /// </summary>
        public const string EHLPREP = "EHLPREP";

        /// <summary>
        /// EHMCU.
        /// </summary>
        public const string EHMCU = "EHMCU";

        /// <summary>
        /// EHTBM.
        /// </summary>
        public const string EHTBM = "EHTBM";

        /// <summary>
        /// EHTRT.
        /// </summary>
        public const string EHTRT = "EHTRT";

        /// <summary>
        /// EHBRVN.
        /// </summary>
        public const string EHBRVN = "EHBRVN";

        /// <summary>
        /// EHRRVN.
        /// </summary>
        public const string EHRRVN = "EHRRVN";

        /// <summary>
        /// EHDCT.
        /// </summary>
        public const string EHDCT = "EHDCT";

        /// <summary>
        /// EHACTFG.
        /// </summary>
        public const string EHACTFG = "EHACTFG";

        /// <summary>
        /// EHLEDG.
        /// </summary>
        public const string EHLEDG = "EHLEDG";

        /// <summary>
        /// EHDECTY.
        /// </summary>
        public const string EHDECTY = "EHDECTY";

        /// <summary>
        /// EHRDECTY.
        /// </summary>
        public const string EHRDECTY = "EHRDECTY";

        /// <summary>
        /// EHURCD.
        /// </summary>
        public const string EHURCD = "EHURCD";

        /// <summary>
        /// EHURDT.
        /// </summary>
        public const string EHURDT = "EHURDT";

        /// <summary>
        /// EHURAT.
        /// </summary>
        public const string EHURAT = "EHURAT";

        /// <summary>
        /// EHURAB.
        /// </summary>
        public const string EHURAB = "EHURAB";

        /// <summary>
        /// EHURRF.
        /// </summary>
        public const string EHURRF = "EHURRF";

        /// <summary>
        /// EHUSER.
        /// </summary>
        public const string EHUSER = "EHUSER";

        /// <summary>
        /// EHPID.
        /// </summary>
        public const string EHPID = "EHPID";

        /// <summary>
        /// EHMKEY.
        /// </summary>
        public const string EHMKEY = "EHMKEY";

        /// <summary>
        /// EHUUPMJ.
        /// </summary>
        public const string EHUUPMJ = "EHUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF31010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EHUKID", "EHUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("EHPRODF31", "EHPRODF31", JdeDataType.Numeric),
        new JdeField("EHITM", "EHITM", JdeDataType.Numeric),
        new JdeField("EHLITM", "EHLITM", JdeDataType.String, 50),
        new JdeField("EHAITM", "EHAITM", JdeDataType.String, 50),
        new JdeField("EHMMCU", "EHMMCU", JdeDataType.String, 24),
        new JdeField("EHDFMLINE", "EHDFMLINE", JdeDataType.String, 24),
        new JdeField("EHSHFT", "EHSHFT", JdeDataType.String, 2),
        new JdeField("EHLOCN", "EHLOCN", JdeDataType.String, 40),
        new JdeField("EHLOTN", "EHLOTN", JdeDataType.String, 60),
        new JdeField("EHSTTSL", "EHSTTSL", JdeDataType.String, 4),
        new JdeField("EHDOCO", "EHDOCO", JdeDataType.Numeric),
        new JdeField("EHDCTO", "EHDCTO", JdeDataType.String, 4),
        new JdeField("EHLNID", "EHLNID", JdeDataType.Numeric),
        new JdeField("EHSOQTY", "EHSOQTY", JdeDataType.Numeric),
        new JdeField("EHPPDJ", "EHPPDJ", JdeDataType.Numeric),
        new JdeField("EHCUPRT", "EHCUPRT", JdeDataType.Numeric),
        new JdeField("EHKCOO", "EHKCOO", JdeDataType.String, 10),
        new JdeField("EHTRANDATE", "EHTRANDATE", JdeDataType.Date),
        new JdeField("EHPCDATE", "EHPCDATE", JdeDataType.Date),
        new JdeField("EHPLQTY", "EHPLQTY", JdeDataType.Numeric),
        new JdeField("EHACCQTY", "EHACCQTY", JdeDataType.Numeric),
        new JdeField("EHACSCQTY", "EHACSCQTY", JdeDataType.Numeric),
        new JdeField("EHUOM", "EHUOM", JdeDataType.String, 4),
        new JdeField("EHACQNTY", "EHACQNTY", JdeDataType.Numeric),
        new JdeField("EHASQNTY", "EHASQNTY", JdeDataType.Numeric),
        new JdeField("EHUM", "EHUM", JdeDataType.String, 4),
        new JdeField("EHAN8", "EHAN8", JdeDataType.Numeric),
        new JdeField("EHLORG", "EHLORG", JdeDataType.String, 2),
        new JdeField("EHLPREP", "EHLPREP", JdeDataType.String, 2),
        new JdeField("EHMCU", "EHMCU", JdeDataType.String, 24),
        new JdeField("EHTBM", "EHTBM", JdeDataType.String, 6),
        new JdeField("EHTRT", "EHTRT", JdeDataType.String, 6),
        new JdeField("EHBRVN", "EHBRVN", JdeDataType.Numeric),
        new JdeField("EHRRVN", "EHRRVN", JdeDataType.Numeric),
        new JdeField("EHDCT", "EHDCT", JdeDataType.String, 4),
        new JdeField("EHACTFG", "EHACTFG", JdeDataType.String, 2),
        new JdeField("EHLEDG", "EHLEDG", JdeDataType.String, 4),
        new JdeField("EHDECTY", "EHDECTY", JdeDataType.Numeric),
        new JdeField("EHRDECTY", "EHRDECTY", JdeDataType.Numeric),
        new JdeField("EHURCD", "EHURCD", JdeDataType.String, 4),
        new JdeField("EHURDT", "EHURDT", JdeDataType.Numeric),
        new JdeField("EHURAT", "EHURAT", JdeDataType.Numeric),
        new JdeField("EHURAB", "EHURAB", JdeDataType.Numeric),
        new JdeField("EHURRF", "EHURRF", JdeDataType.String, 30),
        new JdeField("EHUSER", "EHUSER", JdeDataType.String, 20),
        new JdeField("EHPID", "EHPID", JdeDataType.String, 20),
        new JdeField("EHMKEY", "EHMKEY", JdeDataType.String, 30),
        new JdeField("EHUUPMJ", "EHUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF31010_0", "Primary Key on EHUKID", new[] { "EHUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF31010_2", "Index on EHPRODF31", new[] { "EHPRODF31" }),
        new JdeIndex("FF31010_3", "Index on EHMMCU, EHDFMLINE, EHSHFT", new[] { "EHMMCU", "EHDFMLINE", "EHSHFT" }),
        new JdeIndex("FF31010_4", "Index on EHPCDATE, EHPPDJ", new[] { "EHPCDATE", "EHPPDJ" }),
        new JdeIndex("FF31010_5", "Index on EHMMCU, EHITM, EHPRODF31", new[] { "EHMMCU", "EHITM", "EHPRODF31" })
    };
}
