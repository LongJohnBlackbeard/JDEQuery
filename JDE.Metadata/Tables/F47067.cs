using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47067 - .
/// </summary>
public class F47067 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MYEDTY.
        /// </summary>
        public const string MYEDTY = "MYEDTY";

        /// <summary>
        /// MYEDSQ.
        /// </summary>
        public const string MYEDSQ = "MYEDSQ";

        /// <summary>
        /// MYEKCO.
        /// </summary>
        public const string MYEKCO = "MYEKCO";

        /// <summary>
        /// MYEDOC.
        /// </summary>
        public const string MYEDOC = "MYEDOC";

        /// <summary>
        /// MYEDCT.
        /// </summary>
        public const string MYEDCT = "MYEDCT";

        /// <summary>
        /// MYEDLN.
        /// </summary>
        public const string MYEDLN = "MYEDLN";

        /// <summary>
        /// MYEDST.
        /// </summary>
        public const string MYEDST = "MYEDST";

        /// <summary>
        /// MYEDFT.
        /// </summary>
        public const string MYEDFT = "MYEDFT";

        /// <summary>
        /// MYEDDT.
        /// </summary>
        public const string MYEDDT = "MYEDDT";

        /// <summary>
        /// MYEDER.
        /// </summary>
        public const string MYEDER = "MYEDER";

        /// <summary>
        /// MYEDDL.
        /// </summary>
        public const string MYEDDL = "MYEDDL";

        /// <summary>
        /// MYEDSP.
        /// </summary>
        public const string MYEDSP = "MYEDSP";

        /// <summary>
        /// MYEDBT.
        /// </summary>
        public const string MYEDBT = "MYEDBT";

        /// <summary>
        /// MYPNID.
        /// </summary>
        public const string MYPNID = "MYPNID";

        /// <summary>
        /// MYITM.
        /// </summary>
        public const string MYITM = "MYITM";

        /// <summary>
        /// MYLITM.
        /// </summary>
        public const string MYLITM = "MYLITM";

        /// <summary>
        /// MYAITM.
        /// </summary>
        public const string MYAITM = "MYAITM";

        /// <summary>
        /// MYCITM.
        /// </summary>
        public const string MYCITM = "MYCITM";

        /// <summary>
        /// MYDSC1.
        /// </summary>
        public const string MYDSC1 = "MYDSC1";

        /// <summary>
        /// MYMCU.
        /// </summary>
        public const string MYMCU = "MYMCU";

        /// <summary>
        /// MYUOM.
        /// </summary>
        public const string MYUOM = "MYUOM";

        /// <summary>
        /// MYUPRC.
        /// </summary>
        public const string MYUPRC = "MYUPRC";

        /// <summary>
        /// MYPUOM.
        /// </summary>
        public const string MYPUOM = "MYPUOM";

        /// <summary>
        /// MYFAM.
        /// </summary>
        public const string MYFAM = "MYFAM";

        /// <summary>
        /// MYFQT.
        /// </summary>
        public const string MYFQT = "MYFQT";

        /// <summary>
        /// MYDRQJ.
        /// </summary>
        public const string MYDRQJ = "MYDRQJ";

        /// <summary>
        /// MYTYPF.
        /// </summary>
        public const string MYTYPF = "MYTYPF";

        /// <summary>
        /// MYURCD.
        /// </summary>
        public const string MYURCD = "MYURCD";

        /// <summary>
        /// MYURDT.
        /// </summary>
        public const string MYURDT = "MYURDT";

        /// <summary>
        /// MYURAT.
        /// </summary>
        public const string MYURAT = "MYURAT";

        /// <summary>
        /// MYURAB.
        /// </summary>
        public const string MYURAB = "MYURAB";

        /// <summary>
        /// MYURRF.
        /// </summary>
        public const string MYURRF = "MYURRF";

        /// <summary>
        /// MYTORG.
        /// </summary>
        public const string MYTORG = "MYTORG";

        /// <summary>
        /// MYUSER.
        /// </summary>
        public const string MYUSER = "MYUSER";

        /// <summary>
        /// MYPID.
        /// </summary>
        public const string MYPID = "MYPID";

        /// <summary>
        /// MYJOBN.
        /// </summary>
        public const string MYJOBN = "MYJOBN";

        /// <summary>
        /// MYUPMJ.
        /// </summary>
        public const string MYUPMJ = "MYUPMJ";

        /// <summary>
        /// MYTDAY.
        /// </summary>
        public const string MYTDAY = "MYTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F47067";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MYEDTY", "MYEDTY", JdeDataType.String, 2),
        new JdeField("MYEDSQ", "MYEDSQ", JdeDataType.Numeric),
        new JdeField("MYEKCO", "MYEKCO", JdeDataType.String, 10, true, true),
        new JdeField("MYEDOC", "MYEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("MYEDCT", "MYEDCT", JdeDataType.String, 4, true, true),
        new JdeField("MYEDLN", "MYEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("MYEDST", "MYEDST", JdeDataType.String, 12),
        new JdeField("MYEDFT", "MYEDFT", JdeDataType.String, 20),
        new JdeField("MYEDDT", "MYEDDT", JdeDataType.Numeric),
        new JdeField("MYEDER", "MYEDER", JdeDataType.String, 2),
        new JdeField("MYEDDL", "MYEDDL", JdeDataType.Numeric),
        new JdeField("MYEDSP", "MYEDSP", JdeDataType.String, 2),
        new JdeField("MYEDBT", "MYEDBT", JdeDataType.String, 30),
        new JdeField("MYPNID", "MYPNID", JdeDataType.String, 30),
        new JdeField("MYITM", "MYITM", JdeDataType.Numeric),
        new JdeField("MYLITM", "MYLITM", JdeDataType.String, 50),
        new JdeField("MYAITM", "MYAITM", JdeDataType.String, 50),
        new JdeField("MYCITM", "MYCITM", JdeDataType.String, 50),
        new JdeField("MYDSC1", "MYDSC1", JdeDataType.String, 60),
        new JdeField("MYMCU", "MYMCU", JdeDataType.String, 24),
        new JdeField("MYUOM", "MYUOM", JdeDataType.String, 4),
        new JdeField("MYUPRC", "MYUPRC", JdeDataType.Numeric),
        new JdeField("MYPUOM", "MYPUOM", JdeDataType.String, 4),
        new JdeField("MYFAM", "MYFAM", JdeDataType.Numeric),
        new JdeField("MYFQT", "MYFQT", JdeDataType.Numeric),
        new JdeField("MYDRQJ", "MYDRQJ", JdeDataType.Numeric),
        new JdeField("MYTYPF", "MYTYPF", JdeDataType.String, 4),
        new JdeField("MYURCD", "MYURCD", JdeDataType.String, 4),
        new JdeField("MYURDT", "MYURDT", JdeDataType.Numeric),
        new JdeField("MYURAT", "MYURAT", JdeDataType.Numeric),
        new JdeField("MYURAB", "MYURAB", JdeDataType.Numeric),
        new JdeField("MYURRF", "MYURRF", JdeDataType.String, 30),
        new JdeField("MYTORG", "MYTORG", JdeDataType.String, 20),
        new JdeField("MYUSER", "MYUSER", JdeDataType.String, 20),
        new JdeField("MYPID", "MYPID", JdeDataType.String, 20),
        new JdeField("MYJOBN", "MYJOBN", JdeDataType.String, 20),
        new JdeField("MYUPMJ", "MYUPMJ", JdeDataType.Numeric),
        new JdeField("MYTDAY", "MYTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47067_0", "Primary Key on MYEDOC, MYEDCT, MYEKCO, MYEDLN", new[] { "MYEDOC", "MYEDCT", "MYEKCO", "MYEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
