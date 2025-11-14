using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF31011 - .
/// </summary>
public class FF31011 : JdeTable
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
        /// EHTRSID.
        /// </summary>
        public const string EHTRSID = "EHTRSID";

        /// <summary>
        /// EHMTID.
        /// </summary>
        public const string EHMTID = "EHMTID";

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
        /// EHSOQS.
        /// </summary>
        public const string EHSOQS = "EHSOQS";

        /// <summary>
        /// EHSOCN.
        /// </summary>
        public const string EHSOCN = "EHSOCN";

        /// <summary>
        /// EHUM.
        /// </summary>
        public const string EHUM = "EHUM";

        /// <summary>
        /// EHTRQTY.
        /// </summary>
        public const string EHTRQTY = "EHTRQTY";

        /// <summary>
        /// EHUOM.
        /// </summary>
        public const string EHUOM = "EHUOM";

        /// <summary>
        /// EHLBOM.
        /// </summary>
        public const string EHLBOM = "EHLBOM";

        /// <summary>
        /// EHKIT.
        /// </summary>
        public const string EHKIT = "EHKIT";

        /// <summary>
        /// EHLTDATE.
        /// </summary>
        public const string EHLTDATE = "EHLTDATE";

        /// <summary>
        /// EHUCNDJ.
        /// </summary>
        public const string EHUCNDJ = "EHUCNDJ";

        /// <summary>
        /// EHBRVN.
        /// </summary>
        public const string EHBRVN = "EHBRVN";

        /// <summary>
        /// EHRRVN.
        /// </summary>
        public const string EHRRVN = "EHRRVN";

        /// <summary>
        /// EHAN8.
        /// </summary>
        public const string EHAN8 = "EHAN8";

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
        /// EHSLREF.
        /// </summary>
        public const string EHSLREF = "EHSLREF";

        /// <summary>
        /// EHTMODE.
        /// </summary>
        public const string EHTMODE = "EHTMODE";

        /// <summary>
        /// EHTRSTS.
        /// </summary>
        public const string EHTRSTS = "EHTRSTS";

        /// <summary>
        /// EHDFMLINE.
        /// </summary>
        public const string EHDFMLINE = "EHDFMLINE";

        /// <summary>
        /// EHDESC.
        /// </summary>
        public const string EHDESC = "EHDESC";

        /// <summary>
        /// EHDCT0.
        /// </summary>
        public const string EHDCT0 = "EHDCT0";

        /// <summary>
        /// EHDCT.
        /// </summary>
        public const string EHDCT = "EHDCT";

        /// <summary>
        /// EHMMCU.
        /// </summary>
        public const string EHMMCU = "EHMMCU";

        /// <summary>
        /// EHACTFG.
        /// </summary>
        public const string EHACTFG = "EHACTFG";

        /// <summary>
        /// EHMCU.
        /// </summary>
        public const string EHMCU = "EHMCU";

        /// <summary>
        /// EHCTS1.
        /// </summary>
        public const string EHCTS1 = "EHCTS1";

        /// <summary>
        /// EHLEDG.
        /// </summary>
        public const string EHLEDG = "EHLEDG";

        /// <summary>
        /// EHSUB.
        /// </summary>
        public const string EHSUB = "EHSUB";

        /// <summary>
        /// EHPPFG.
        /// </summary>
        public const string EHPPFG = "EHPPFG";

        /// <summary>
        /// EHCO.
        /// </summary>
        public const string EHCO = "EHCO";

        /// <summary>
        /// EHTUSER.
        /// </summary>
        public const string EHTUSER = "EHTUSER";

        /// <summary>
        /// EHCUSER.
        /// </summary>
        public const string EHCUSER = "EHCUSER";

        /// <summary>
        /// EHPID.
        /// </summary>
        public const string EHPID = "EHPID";

        /// <summary>
        /// EHUSER.
        /// </summary>
        public const string EHUSER = "EHUSER";

        /// <summary>
        /// EHMKEY.
        /// </summary>
        public const string EHMKEY = "EHMKEY";

        /// <summary>
        /// EHUUPMJ.
        /// </summary>
        public const string EHUUPMJ = "EHUUPMJ";

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
    }

    /// <inheritdoc />
    public override string TableName => "FF31011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EHUKID", "EHUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("EHPRODF31", "EHPRODF31", JdeDataType.Numeric),
        new JdeField("EHTRSID", "EHTRSID", JdeDataType.Numeric),
        new JdeField("EHMTID", "EHMTID", JdeDataType.Numeric),
        new JdeField("EHITM", "EHITM", JdeDataType.Numeric),
        new JdeField("EHLITM", "EHLITM", JdeDataType.String, 50),
        new JdeField("EHAITM", "EHAITM", JdeDataType.String, 50),
        new JdeField("EHSOQS", "EHSOQS", JdeDataType.Numeric),
        new JdeField("EHSOCN", "EHSOCN", JdeDataType.Numeric),
        new JdeField("EHUM", "EHUM", JdeDataType.String, 4),
        new JdeField("EHTRQTY", "EHTRQTY", JdeDataType.Numeric),
        new JdeField("EHUOM", "EHUOM", JdeDataType.String, 4),
        new JdeField("EHLBOM", "EHLBOM", JdeDataType.Numeric),
        new JdeField("EHKIT", "EHKIT", JdeDataType.Numeric),
        new JdeField("EHLTDATE", "EHLTDATE", JdeDataType.Date),
        new JdeField("EHUCNDJ", "EHUCNDJ", JdeDataType.Date),
        new JdeField("EHBRVN", "EHBRVN", JdeDataType.Numeric),
        new JdeField("EHRRVN", "EHRRVN", JdeDataType.Numeric),
        new JdeField("EHAN8", "EHAN8", JdeDataType.Numeric),
        new JdeField("EHSHFT", "EHSHFT", JdeDataType.String, 2),
        new JdeField("EHLOCN", "EHLOCN", JdeDataType.String, 40),
        new JdeField("EHLOTN", "EHLOTN", JdeDataType.String, 60),
        new JdeField("EHSLREF", "EHSLREF", JdeDataType.Numeric),
        new JdeField("EHTMODE", "EHTMODE", JdeDataType.String, 2),
        new JdeField("EHTRSTS", "EHTRSTS", JdeDataType.String, 4),
        new JdeField("EHDFMLINE", "EHDFMLINE", JdeDataType.String, 24),
        new JdeField("EHDESC", "EHDESC", JdeDataType.String, 60),
        new JdeField("EHDCT0", "EHDCT0", JdeDataType.String, 4),
        new JdeField("EHDCT", "EHDCT", JdeDataType.String, 4),
        new JdeField("EHMMCU", "EHMMCU", JdeDataType.String, 24),
        new JdeField("EHACTFG", "EHACTFG", JdeDataType.String, 2),
        new JdeField("EHMCU", "EHMCU", JdeDataType.String, 24),
        new JdeField("EHCTS1", "EHCTS1", JdeDataType.Numeric),
        new JdeField("EHLEDG", "EHLEDG", JdeDataType.String, 4),
        new JdeField("EHSUB", "EHSUB", JdeDataType.String, 16),
        new JdeField("EHPPFG", "EHPPFG", JdeDataType.String, 2),
        new JdeField("EHCO", "EHCO", JdeDataType.String, 10),
        new JdeField("EHTUSER", "EHTUSER", JdeDataType.String, 20),
        new JdeField("EHCUSER", "EHCUSER", JdeDataType.String, 20),
        new JdeField("EHPID", "EHPID", JdeDataType.String, 20),
        new JdeField("EHUSER", "EHUSER", JdeDataType.String, 20),
        new JdeField("EHMKEY", "EHMKEY", JdeDataType.String, 30),
        new JdeField("EHUUPMJ", "EHUUPMJ", JdeDataType.Date),
        new JdeField("EHURCD", "EHURCD", JdeDataType.String, 4),
        new JdeField("EHURDT", "EHURDT", JdeDataType.Numeric),
        new JdeField("EHURAT", "EHURAT", JdeDataType.Numeric),
        new JdeField("EHURAB", "EHURAB", JdeDataType.Numeric),
        new JdeField("EHURRF", "EHURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF31011_0", "Primary Key on EHUKID", new[] { "EHUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF31011_2", "Index on EHPRODF31, EHTRSID", new[] { "EHPRODF31", "EHTRSID" }),
        new JdeIndex("FF31011_3", "Index on EHTRSID", new[] { "EHTRSID" }),
        new JdeIndex("FF31011_4", "Index on EHPRODF31, EHMTID", new[] { "EHPRODF31", "EHMTID" })
    };
}
