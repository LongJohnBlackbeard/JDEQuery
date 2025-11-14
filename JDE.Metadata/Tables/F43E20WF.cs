using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43E20WF - .
/// </summary>
public class F43E20WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SWUSER.
        /// </summary>
        public const string SWUSER = "SWUSER";

        /// <summary>
        /// SWCOOKIE.
        /// </summary>
        public const string SWCOOKIE = "SWCOOKIE";

        /// <summary>
        /// SWLNID.
        /// </summary>
        public const string SWLNID = "SWLNID";

        /// <summary>
        /// SWAN8V.
        /// </summary>
        public const string SWAN8V = "SWAN8V";

        /// <summary>
        /// SWCMDCDE.
        /// </summary>
        public const string SWCMDCDE = "SWCMDCDE";

        /// <summary>
        /// SWCMDSUP.
        /// </summary>
        public const string SWCMDSUP = "SWCMDSUP";

        /// <summary>
        /// SWITM.
        /// </summary>
        public const string SWITM = "SWITM";

        /// <summary>
        /// SWPRODNM.
        /// </summary>
        public const string SWPRODNM = "SWPRODNM";

        /// <summary>
        /// SWITEMDES.
        /// </summary>
        public const string SWITEMDES = "SWITEMDES";

        /// <summary>
        /// SWSUPITMID.
        /// </summary>
        public const string SWSUPITMID = "SWSUPITMID";

        /// <summary>
        /// SWITMAUXID.
        /// </summary>
        public const string SWITMAUXID = "SWITMAUXID";

        /// <summary>
        /// SWSCITTY.
        /// </summary>
        public const string SWSCITTY = "SWSCITTY";

        /// <summary>
        /// SWUNSPSC.
        /// </summary>
        public const string SWUNSPSC = "SWUNSPSC";

        /// <summary>
        /// SWQTY.
        /// </summary>
        public const string SWQTY = "SWQTY";

        /// <summary>
        /// SWUOM.
        /// </summary>
        public const string SWUOM = "SWUOM";

        /// <summary>
        /// SWFRRC.
        /// </summary>
        public const string SWFRRC = "SWFRRC";

        /// <summary>
        /// SWFEA.
        /// </summary>
        public const string SWFEA = "SWFEA";

        /// <summary>
        /// SWCCD0.
        /// </summary>
        public const string SWCCD0 = "SWCCD0";

        /// <summary>
        /// SWATXA.
        /// </summary>
        public const string SWATXA = "SWATXA";

        /// <summary>
        /// SWSTAM.
        /// </summary>
        public const string SWSTAM = "SWSTAM";

        /// <summary>
        /// SWTAXA.
        /// </summary>
        public const string SWTAXA = "SWTAXA";

        /// <summary>
        /// SWEXR1.
        /// </summary>
        public const string SWEXR1 = "SWEXR1";

        /// <summary>
        /// SWTXR1.
        /// </summary>
        public const string SWTXR1 = "SWTXR1";

        /// <summary>
        /// SWSCAMT.
        /// </summary>
        public const string SWSCAMT = "SWSCAMT";

        /// <summary>
        /// SWSCDESC.
        /// </summary>
        public const string SWSCDESC = "SWSCDESC";

        /// <summary>
        /// SWMGFID.
        /// </summary>
        public const string SWMGFID = "SWMGFID";

        /// <summary>
        /// SWMGFNAME.
        /// </summary>
        public const string SWMGFNAME = "SWMGFNAME";

        /// <summary>
        /// SWMOFLAG.
        /// </summary>
        public const string SWMOFLAG = "SWMOFLAG";

        /// <summary>
        /// SWLNG.
        /// </summary>
        public const string SWLNG = "SWLNG";

        /// <summary>
        /// SWNRCC.
        /// </summary>
        public const string SWNRCC = "SWNRCC";

        /// <summary>
        /// SWCNDJ.
        /// </summary>
        public const string SWCNDJ = "SWCNDJ";

        /// <summary>
        /// SWJOBN.
        /// </summary>
        public const string SWJOBN = "SWJOBN";

        /// <summary>
        /// SWPID.
        /// </summary>
        public const string SWPID = "SWPID";

        /// <summary>
        /// SWUPMT.
        /// </summary>
        public const string SWUPMT = "SWUPMT";

        /// <summary>
        /// SWUPMJ.
        /// </summary>
        public const string SWUPMJ = "SWUPMJ";

        /// <summary>
        /// SWEV01.
        /// </summary>
        public const string SWEV01 = "SWEV01";

        /// <summary>
        /// SWEV02.
        /// </summary>
        public const string SWEV02 = "SWEV02";

        /// <summary>
        /// SWEV03.
        /// </summary>
        public const string SWEV03 = "SWEV03";

        /// <summary>
        /// SWEV04.
        /// </summary>
        public const string SWEV04 = "SWEV04";

        /// <summary>
        /// SWEV05.
        /// </summary>
        public const string SWEV05 = "SWEV05";

        /// <summary>
        /// SWMATH01.
        /// </summary>
        public const string SWMATH01 = "SWMATH01";

        /// <summary>
        /// SWMATH02.
        /// </summary>
        public const string SWMATH02 = "SWMATH02";

        /// <summary>
        /// SWMATH03.
        /// </summary>
        public const string SWMATH03 = "SWMATH03";

        /// <summary>
        /// SWMATH04.
        /// </summary>
        public const string SWMATH04 = "SWMATH04";

        /// <summary>
        /// SWMATH05.
        /// </summary>
        public const string SWMATH05 = "SWMATH05";

        /// <summary>
        /// SWFUTANON3.
        /// </summary>
        public const string SWFUTANON3 = "SWFUTANON3";

        /// <summary>
        /// SWFUTANON4.
        /// </summary>
        public const string SWFUTANON4 = "SWFUTANON4";

        /// <summary>
        /// SWFUTANON5.
        /// </summary>
        public const string SWFUTANON5 = "SWFUTANON5";

        /// <summary>
        /// SWFUTANON6.
        /// </summary>
        public const string SWFUTANON6 = "SWFUTANON6";

        /// <summary>
        /// SWFUTANON7.
        /// </summary>
        public const string SWFUTANON7 = "SWFUTANON7";

        /// <summary>
        /// SWCRSREF01.
        /// </summary>
        public const string SWCRSREF01 = "SWCRSREF01";

        /// <summary>
        /// SWCRSREF02.
        /// </summary>
        public const string SWCRSREF02 = "SWCRSREF02";

        /// <summary>
        /// SWCRSREF03.
        /// </summary>
        public const string SWCRSREF03 = "SWCRSREF03";

        /// <summary>
        /// SWCRSREF04.
        /// </summary>
        public const string SWCRSREF04 = "SWCRSREF04";

        /// <summary>
        /// SWCRSREF05.
        /// </summary>
        public const string SWCRSREF05 = "SWCRSREF05";
    }

    /// <inheritdoc />
    public override string TableName => "F43E20WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SWUSER", "SWUSER", JdeDataType.String, 20, true, true),
        new JdeField("SWCOOKIE", "SWCOOKIE", JdeDataType.String, 400, true, true),
        new JdeField("SWLNID", "SWLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SWAN8V", "SWAN8V", JdeDataType.Numeric),
        new JdeField("SWCMDCDE", "SWCMDCDE", JdeDataType.String, 30),
        new JdeField("SWCMDSUP", "SWCMDSUP", JdeDataType.String, 60),
        new JdeField("SWITM", "SWITM", JdeDataType.Numeric),
        new JdeField("SWPRODNM", "SWPRODNM", JdeDataType.String, 100),
        new JdeField("SWITEMDES", "SWITEMDES", JdeDataType.String, 60),
        new JdeField("SWSUPITMID", "SWSUPITMID", JdeDataType.String, 60),
        new JdeField("SWITMAUXID", "SWITMAUXID", JdeDataType.String, 100),
        new JdeField("SWSCITTY", "SWSCITTY", JdeDataType.String, 2),
        new JdeField("SWUNSPSC", "SWUNSPSC", JdeDataType.String, 16),
        new JdeField("SWQTY", "SWQTY", JdeDataType.Numeric),
        new JdeField("SWUOM", "SWUOM", JdeDataType.String, 4),
        new JdeField("SWFRRC", "SWFRRC", JdeDataType.Numeric),
        new JdeField("SWFEA", "SWFEA", JdeDataType.Numeric),
        new JdeField("SWCCD0", "SWCCD0", JdeDataType.String, 6),
        new JdeField("SWATXA", "SWATXA", JdeDataType.Numeric),
        new JdeField("SWSTAM", "SWSTAM", JdeDataType.Numeric),
        new JdeField("SWTAXA", "SWTAXA", JdeDataType.String, 60),
        new JdeField("SWEXR1", "SWEXR1", JdeDataType.String, 4),
        new JdeField("SWTXR1", "SWTXR1", JdeDataType.Numeric),
        new JdeField("SWSCAMT", "SWSCAMT", JdeDataType.Numeric),
        new JdeField("SWSCDESC", "SWSCDESC", JdeDataType.String, 60),
        new JdeField("SWMGFID", "SWMGFID", JdeDataType.String, 60),
        new JdeField("SWMGFNAME", "SWMGFNAME", JdeDataType.String, 60),
        new JdeField("SWMOFLAG", "SWMOFLAG", JdeDataType.String, 2),
        new JdeField("SWLNG", "SWLNG", JdeDataType.String, 6),
        new JdeField("SWNRCC", "SWNRCC", JdeDataType.String, 6),
        new JdeField("SWCNDJ", "SWCNDJ", JdeDataType.Numeric),
        new JdeField("SWJOBN", "SWJOBN", JdeDataType.String, 20),
        new JdeField("SWPID", "SWPID", JdeDataType.String, 20),
        new JdeField("SWUPMT", "SWUPMT", JdeDataType.Numeric),
        new JdeField("SWUPMJ", "SWUPMJ", JdeDataType.Numeric),
        new JdeField("SWEV01", "SWEV01", JdeDataType.String, 2),
        new JdeField("SWEV02", "SWEV02", JdeDataType.String, 2),
        new JdeField("SWEV03", "SWEV03", JdeDataType.String, 2),
        new JdeField("SWEV04", "SWEV04", JdeDataType.String, 2),
        new JdeField("SWEV05", "SWEV05", JdeDataType.String, 2),
        new JdeField("SWMATH01", "SWMATH01", JdeDataType.Numeric),
        new JdeField("SWMATH02", "SWMATH02", JdeDataType.Numeric),
        new JdeField("SWMATH03", "SWMATH03", JdeDataType.Numeric),
        new JdeField("SWMATH04", "SWMATH04", JdeDataType.Numeric),
        new JdeField("SWMATH05", "SWMATH05", JdeDataType.Numeric),
        new JdeField("SWFUTANON3", "SWFUTANON3", JdeDataType.String, 40),
        new JdeField("SWFUTANON4", "SWFUTANON4", JdeDataType.String, 40),
        new JdeField("SWFUTANON5", "SWFUTANON5", JdeDataType.String, 40),
        new JdeField("SWFUTANON6", "SWFUTANON6", JdeDataType.String, 40),
        new JdeField("SWFUTANON7", "SWFUTANON7", JdeDataType.String, 40),
        new JdeField("SWCRSREF01", "SWCRSREF01", JdeDataType.String, 600),
        new JdeField("SWCRSREF02", "SWCRSREF02", JdeDataType.String, 600),
        new JdeField("SWCRSREF03", "SWCRSREF03", JdeDataType.String, 600),
        new JdeField("SWCRSREF04", "SWCRSREF04", JdeDataType.String, 600),
        new JdeField("SWCRSREF05", "SWCRSREF05", JdeDataType.String, 600)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43E20WF_0", "Primary Key on SWUSER, SWCOOKIE, SWLNID", new[] { "SWUSER", "SWCOOKIE", "SWLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
