using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4960 - .
/// </summary>
public class F4960 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TMVMCU.
        /// </summary>
        public const string TMVMCU = "TMVMCU";

        /// <summary>
        /// TMLDNM.
        /// </summary>
        public const string TMLDNM = "TMLDNM";

        /// <summary>
        /// TMNMCU.
        /// </summary>
        public const string TMNMCU = "TMNMCU";

        /// <summary>
        /// TMORGN.
        /// </summary>
        public const string TMORGN = "TMORGN";

        /// <summary>
        /// TMMCUX.
        /// </summary>
        public const string TMMCUX = "TMMCUX";

        /// <summary>
        /// TMANCC.
        /// </summary>
        public const string TMANCC = "TMANCC";

        /// <summary>
        /// TMANID.
        /// </summary>
        public const string TMANID = "TMANID";

        /// <summary>
        /// TMOVOD.
        /// </summary>
        public const string TMOVOD = "TMOVOD";

        /// <summary>
        /// TMCTY1.
        /// </summary>
        public const string TMCTY1 = "TMCTY1";

        /// <summary>
        /// TMADDS.
        /// </summary>
        public const string TMADDS = "TMADDS";

        /// <summary>
        /// TMADDZ.
        /// </summary>
        public const string TMADDZ = "TMADDZ";

        /// <summary>
        /// TMCTR.
        /// </summary>
        public const string TMCTR = "TMCTR";

        /// <summary>
        /// TMZON.
        /// </summary>
        public const string TMZON = "TMZON";

        /// <summary>
        /// TMLDTY.
        /// </summary>
        public const string TMLDTY = "TMLDTY";

        /// <summary>
        /// TMLDLS.
        /// </summary>
        public const string TMLDLS = "TMLDLS";

        /// <summary>
        /// TMLOAD.
        /// </summary>
        public const string TMLOAD = "TMLOAD";

        /// <summary>
        /// TMSHFT.
        /// </summary>
        public const string TMSHFT = "TMSHFT";

        /// <summary>
        /// TMSEQ.
        /// </summary>
        public const string TMSEQ = "TMSEQ";

        /// <summary>
        /// TMTMLS.
        /// </summary>
        public const string TMTMLS = "TMTMLS";

        /// <summary>
        /// TMPPDJ.
        /// </summary>
        public const string TMPPDJ = "TMPPDJ";

        /// <summary>
        /// TMPMDT.
        /// </summary>
        public const string TMPMDT = "TMPMDT";

        /// <summary>
        /// TMADDJ.
        /// </summary>
        public const string TMADDJ = "TMADDJ";

        /// <summary>
        /// TMADTM.
        /// </summary>
        public const string TMADTM = "TMADTM";

        /// <summary>
        /// TMMOT.
        /// </summary>
        public const string TMMOT = "TMMOT";

        /// <summary>
        /// TMOVRM.
        /// </summary>
        public const string TMOVRM = "TMOVRM";

        /// <summary>
        /// TMVTYP.
        /// </summary>
        public const string TMVTYP = "TMVTYP";

        /// <summary>
        /// TMPVEH.
        /// </summary>
        public const string TMPVEH = "TMPVEH";

        /// <summary>
        /// TMRLNO.
        /// </summary>
        public const string TMRLNO = "TMRLNO";

        /// <summary>
        /// TMDUMV.
        /// </summary>
        public const string TMDUMV = "TMDUMV";

        /// <summary>
        /// TMCNNV.
        /// </summary>
        public const string TMCNNV = "TMCNNV";

        /// <summary>
        /// TMCARS.
        /// </summary>
        public const string TMCARS = "TMCARS";

        /// <summary>
        /// TMOVRC.
        /// </summary>
        public const string TMOVRC = "TMOVRC";

        /// <summary>
        /// TMROUT.
        /// </summary>
        public const string TMROUT = "TMROUT";

        /// <summary>
        /// TMRTN.
        /// </summary>
        public const string TMRTN = "TMRTN";

        /// <summary>
        /// TMFRSC.
        /// </summary>
        public const string TMFRSC = "TMFRSC";

        /// <summary>
        /// TMCZON.
        /// </summary>
        public const string TMCZON = "TMCZON";

        /// <summary>
        /// TMDSGP.
        /// </summary>
        public const string TMDSGP = "TMDSGP";

        /// <summary>
        /// TMDATY.
        /// </summary>
        public const string TMDATY = "TMDATY";

        /// <summary>
        /// TMDSCD.
        /// </summary>
        public const string TMDSCD = "TMDSCD";

        /// <summary>
        /// TMLDLE.
        /// </summary>
        public const string TMLDLE = "TMLDLE";

        /// <summary>
        /// TMSEAL.
        /// </summary>
        public const string TMSEAL = "TMSEAL";

        /// <summary>
        /// TMLMCU.
        /// </summary>
        public const string TMLMCU = "TMLMCU";

        /// <summary>
        /// TMLTRP.
        /// </summary>
        public const string TMLTRP = "TMLTRP";

        /// <summary>
        /// TMDSTN.
        /// </summary>
        public const string TMDSTN = "TMDSTN";

        /// <summary>
        /// TMUMD1.
        /// </summary>
        public const string TMUMD1 = "TMUMD1";

        /// <summary>
        /// TMDSRC.
        /// </summary>
        public const string TMDSRC = "TMDSRC";

        /// <summary>
        /// TMODST.
        /// </summary>
        public const string TMODST = "TMODST";

        /// <summary>
        /// TMELTM.
        /// </summary>
        public const string TMELTM = "TMELTM";

        /// <summary>
        /// TMUM.
        /// </summary>
        public const string TMUM = "TMUM";

        /// <summary>
        /// TMCVUM.
        /// </summary>
        public const string TMCVUM = "TMCVUM";

        /// <summary>
        /// TMWTUM.
        /// </summary>
        public const string TMWTUM = "TMWTUM";

        /// <summary>
        /// TMVLUM.
        /// </summary>
        public const string TMVLUM = "TMVLUM";

        /// <summary>
        /// TMVR01.
        /// </summary>
        public const string TMVR01 = "TMVR01";

        /// <summary>
        /// TMNSTP.
        /// </summary>
        public const string TMNSTP = "TMNSTP";

        /// <summary>
        /// TMRRTR.
        /// </summary>
        public const string TMRRTR = "TMRRTR";

        /// <summary>
        /// TMRATR.
        /// </summary>
        public const string TMRATR = "TMRATR";

        /// <summary>
        /// TMFRVC.
        /// </summary>
        public const string TMFRVC = "TMFRVC";

        /// <summary>
        /// TMFRVF.
        /// </summary>
        public const string TMFRVF = "TMFRVF";

        /// <summary>
        /// TMCRCP.
        /// </summary>
        public const string TMCRCP = "TMCRCP";

        /// <summary>
        /// TMIBRS.
        /// </summary>
        public const string TMIBRS = "TMIBRS";

        /// <summary>
        /// TMDKID.
        /// </summary>
        public const string TMDKID = "TMDKID";

        /// <summary>
        /// TMDEPU.
        /// </summary>
        public const string TMDEPU = "TMDEPU";

        /// <summary>
        /// TMDLPU.
        /// </summary>
        public const string TMDLPU = "TMDLPU";

        /// <summary>
        /// TMTPUF.
        /// </summary>
        public const string TMTPUF = "TMTPUF";

        /// <summary>
        /// TMTPUT.
        /// </summary>
        public const string TMTPUT = "TMTPUT";

        /// <summary>
        /// TMLSLT.
        /// </summary>
        public const string TMLSLT = "TMLSLT";

        /// <summary>
        /// TMLSUT.
        /// </summary>
        public const string TMLSUT = "TMLSUT";

        /// <summary>
        /// TMLALT.
        /// </summary>
        public const string TMLALT = "TMLALT";

        /// <summary>
        /// TMLAUT.
        /// </summary>
        public const string TMLAUT = "TMLAUT";

        /// <summary>
        /// TMURCD.
        /// </summary>
        public const string TMURCD = "TMURCD";

        /// <summary>
        /// TMURDT.
        /// </summary>
        public const string TMURDT = "TMURDT";

        /// <summary>
        /// TMURAT.
        /// </summary>
        public const string TMURAT = "TMURAT";

        /// <summary>
        /// TMURAB.
        /// </summary>
        public const string TMURAB = "TMURAB";

        /// <summary>
        /// TMURRF.
        /// </summary>
        public const string TMURRF = "TMURRF";

        /// <summary>
        /// TMUSER.
        /// </summary>
        public const string TMUSER = "TMUSER";

        /// <summary>
        /// TMPID.
        /// </summary>
        public const string TMPID = "TMPID";

        /// <summary>
        /// TMJOBN.
        /// </summary>
        public const string TMJOBN = "TMJOBN";

        /// <summary>
        /// TMUPMJ.
        /// </summary>
        public const string TMUPMJ = "TMUPMJ";

        /// <summary>
        /// TMTDAY.
        /// </summary>
        public const string TMTDAY = "TMTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4960";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TMVMCU", "TMVMCU", JdeDataType.String, 24, true, true),
        new JdeField("TMLDNM", "TMLDNM", JdeDataType.Numeric, null, true, true),
        new JdeField("TMNMCU", "TMNMCU", JdeDataType.String, 24),
        new JdeField("TMORGN", "TMORGN", JdeDataType.Numeric),
        new JdeField("TMMCUX", "TMMCUX", JdeDataType.String, 24),
        new JdeField("TMANCC", "TMANCC", JdeDataType.Numeric),
        new JdeField("TMANID", "TMANID", JdeDataType.Numeric),
        new JdeField("TMOVOD", "TMOVOD", JdeDataType.String, 2),
        new JdeField("TMCTY1", "TMCTY1", JdeDataType.String, 50),
        new JdeField("TMADDS", "TMADDS", JdeDataType.String, 6),
        new JdeField("TMADDZ", "TMADDZ", JdeDataType.String, 24),
        new JdeField("TMCTR", "TMCTR", JdeDataType.String, 6),
        new JdeField("TMZON", "TMZON", JdeDataType.String, 6),
        new JdeField("TMLDTY", "TMLDTY", JdeDataType.String, 4),
        new JdeField("TMLDLS", "TMLDLS", JdeDataType.String, 4),
        new JdeField("TMLOAD", "TMLOAD", JdeDataType.Numeric),
        new JdeField("TMSHFT", "TMSHFT", JdeDataType.String, 2),
        new JdeField("TMSEQ", "TMSEQ", JdeDataType.Numeric),
        new JdeField("TMTMLS", "TMTMLS", JdeDataType.Numeric),
        new JdeField("TMPPDJ", "TMPPDJ", JdeDataType.Numeric),
        new JdeField("TMPMDT", "TMPMDT", JdeDataType.Numeric),
        new JdeField("TMADDJ", "TMADDJ", JdeDataType.Numeric),
        new JdeField("TMADTM", "TMADTM", JdeDataType.Numeric),
        new JdeField("TMMOT", "TMMOT", JdeDataType.String, 6),
        new JdeField("TMOVRM", "TMOVRM", JdeDataType.String, 2),
        new JdeField("TMVTYP", "TMVTYP", JdeDataType.String, 24),
        new JdeField("TMPVEH", "TMPVEH", JdeDataType.String, 24),
        new JdeField("TMRLNO", "TMRLNO", JdeDataType.String, 26),
        new JdeField("TMDUMV", "TMDUMV", JdeDataType.String, 2),
        new JdeField("TMCNNV", "TMCNNV", JdeDataType.String, 2),
        new JdeField("TMCARS", "TMCARS", JdeDataType.Numeric),
        new JdeField("TMOVRC", "TMOVRC", JdeDataType.String, 2),
        new JdeField("TMROUT", "TMROUT", JdeDataType.String, 6),
        new JdeField("TMRTN", "TMRTN", JdeDataType.Numeric),
        new JdeField("TMFRSC", "TMFRSC", JdeDataType.String, 16),
        new JdeField("TMCZON", "TMCZON", JdeDataType.String, 20),
        new JdeField("TMDSGP", "TMDSGP", JdeDataType.String, 6),
        new JdeField("TMDATY", "TMDATY", JdeDataType.String, 2),
        new JdeField("TMDSCD", "TMDSCD", JdeDataType.String, 2),
        new JdeField("TMLDLE", "TMLDLE", JdeDataType.String, 2),
        new JdeField("TMSEAL", "TMSEAL", JdeDataType.Numeric),
        new JdeField("TMLMCU", "TMLMCU", JdeDataType.String, 24),
        new JdeField("TMLTRP", "TMLTRP", JdeDataType.Numeric),
        new JdeField("TMDSTN", "TMDSTN", JdeDataType.Numeric),
        new JdeField("TMUMD1", "TMUMD1", JdeDataType.String, 4),
        new JdeField("TMDSRC", "TMDSRC", JdeDataType.String, 2),
        new JdeField("TMODST", "TMODST", JdeDataType.Numeric),
        new JdeField("TMELTM", "TMELTM", JdeDataType.Numeric),
        new JdeField("TMUM", "TMUM", JdeDataType.String, 4),
        new JdeField("TMCVUM", "TMCVUM", JdeDataType.String, 4),
        new JdeField("TMWTUM", "TMWTUM", JdeDataType.String, 4),
        new JdeField("TMVLUM", "TMVLUM", JdeDataType.String, 4),
        new JdeField("TMVR01", "TMVR01", JdeDataType.String, 50),
        new JdeField("TMNSTP", "TMNSTP", JdeDataType.Numeric),
        new JdeField("TMRRTR", "TMRRTR", JdeDataType.String, 2),
        new JdeField("TMRATR", "TMRATR", JdeDataType.String, 2),
        new JdeField("TMFRVC", "TMFRVC", JdeDataType.Numeric),
        new JdeField("TMFRVF", "TMFRVF", JdeDataType.Numeric),
        new JdeField("TMCRCP", "TMCRCP", JdeDataType.String, 6),
        new JdeField("TMIBRS", "TMIBRS", JdeDataType.String, 2),
        new JdeField("TMDKID", "TMDKID", JdeDataType.String, 40),
        new JdeField("TMDEPU", "TMDEPU", JdeDataType.Numeric),
        new JdeField("TMDLPU", "TMDLPU", JdeDataType.Numeric),
        new JdeField("TMTPUF", "TMTPUF", JdeDataType.Numeric),
        new JdeField("TMTPUT", "TMTPUT", JdeDataType.Numeric),
        new JdeField("TMLSLT", "TMLSLT", JdeDataType.Numeric),
        new JdeField("TMLSUT", "TMLSUT", JdeDataType.Numeric),
        new JdeField("TMLALT", "TMLALT", JdeDataType.Numeric),
        new JdeField("TMLAUT", "TMLAUT", JdeDataType.Numeric),
        new JdeField("TMURCD", "TMURCD", JdeDataType.String, 4),
        new JdeField("TMURDT", "TMURDT", JdeDataType.Numeric),
        new JdeField("TMURAT", "TMURAT", JdeDataType.Numeric),
        new JdeField("TMURAB", "TMURAB", JdeDataType.Numeric),
        new JdeField("TMURRF", "TMURRF", JdeDataType.String, 30),
        new JdeField("TMUSER", "TMUSER", JdeDataType.String, 20),
        new JdeField("TMPID", "TMPID", JdeDataType.String, 20),
        new JdeField("TMJOBN", "TMJOBN", JdeDataType.String, 20),
        new JdeField("TMUPMJ", "TMUPMJ", JdeDataType.Numeric),
        new JdeField("TMTDAY", "TMTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4960_0", "Primary Key on TMVMCU, TMLDNM", new[] { "TMVMCU", "TMLDNM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4960_2", "Index on TMPVEH, TMPPDJ, TMSHFT, TMSEQ", new[] { "TMPVEH", "TMPPDJ", "TMSHFT", "TMSEQ" }),
        new JdeIndex("F4960_3", "Index on TMSHFT, TMPPDJ, TMPVEH", new[] { "TMSHFT", "TMPPDJ", "TMPVEH" }),
        new JdeIndex("F4960_4", "Index on TMPVEH, TMRLNO, SYS_NC00080$, SYS_NC00081$, SYS_NC00082$", new[] { "TMPVEH", "TMRLNO", "SYS_NC00080$", "SYS_NC00081$", "SYS_NC00082$" })
    };
}
