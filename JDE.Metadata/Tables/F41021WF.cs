using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41021WF - .
/// </summary>
public class F41021WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LWJOBS.
        /// </summary>
        public const string LWJOBS = "LWJOBS";

        /// <summary>
        /// LWCTID.
        /// </summary>
        public const string LWCTID = "LWCTID";

        /// <summary>
        /// LWUKID.
        /// </summary>
        public const string LWUKID = "LWUKID";

        /// <summary>
        /// LWPIDP.
        /// </summary>
        public const string LWPIDP = "LWPIDP";

        /// <summary>
        /// LWITM.
        /// </summary>
        public const string LWITM = "LWITM";

        /// <summary>
        /// LWMCU.
        /// </summary>
        public const string LWMCU = "LWMCU";

        /// <summary>
        /// LWLOCN.
        /// </summary>
        public const string LWLOCN = "LWLOCN";

        /// <summary>
        /// LWLOTN.
        /// </summary>
        public const string LWLOTN = "LWLOTN";

        /// <summary>
        /// LWMODE.
        /// </summary>
        public const string LWMODE = "LWMODE";

        /// <summary>
        /// LWPBIN.
        /// </summary>
        public const string LWPBIN = "LWPBIN";

        /// <summary>
        /// LWGLPT.
        /// </summary>
        public const string LWGLPT = "LWGLPT";

        /// <summary>
        /// LWLOTS.
        /// </summary>
        public const string LWLOTS = "LWLOTS";

        /// <summary>
        /// LWLRCJ.
        /// </summary>
        public const string LWLRCJ = "LWLRCJ";

        /// <summary>
        /// LWPQOH.
        /// </summary>
        public const string LWPQOH = "LWPQOH";

        /// <summary>
        /// LWPBCK.
        /// </summary>
        public const string LWPBCK = "LWPBCK";

        /// <summary>
        /// LWPREQ.
        /// </summary>
        public const string LWPREQ = "LWPREQ";

        /// <summary>
        /// LWQWBO.
        /// </summary>
        public const string LWQWBO = "LWQWBO";

        /// <summary>
        /// LWOT1P.
        /// </summary>
        public const string LWOT1P = "LWOT1P";

        /// <summary>
        /// LWOT2P.
        /// </summary>
        public const string LWOT2P = "LWOT2P";

        /// <summary>
        /// LWOT1A.
        /// </summary>
        public const string LWOT1A = "LWOT1A";

        /// <summary>
        /// LWHCOM.
        /// </summary>
        public const string LWHCOM = "LWHCOM";

        /// <summary>
        /// LWPCOM.
        /// </summary>
        public const string LWPCOM = "LWPCOM";

        /// <summary>
        /// LWFCOM.
        /// </summary>
        public const string LWFCOM = "LWFCOM";

        /// <summary>
        /// LWFUN1.
        /// </summary>
        public const string LWFUN1 = "LWFUN1";

        /// <summary>
        /// LWQOWO.
        /// </summary>
        public const string LWQOWO = "LWQOWO";

        /// <summary>
        /// LWQTTR.
        /// </summary>
        public const string LWQTTR = "LWQTTR";

        /// <summary>
        /// LWQTIN.
        /// </summary>
        public const string LWQTIN = "LWQTIN";

        /// <summary>
        /// LWQONL.
        /// </summary>
        public const string LWQONL = "LWQONL";

        /// <summary>
        /// LWQTRI.
        /// </summary>
        public const string LWQTRI = "LWQTRI";

        /// <summary>
        /// LWQTRO.
        /// </summary>
        public const string LWQTRO = "LWQTRO";

        /// <summary>
        /// LWQTO1.
        /// </summary>
        public const string LWQTO1 = "LWQTO1";

        /// <summary>
        /// LWQTO2.
        /// </summary>
        public const string LWQTO2 = "LWQTO2";

        /// <summary>
        /// LWNCDJ.
        /// </summary>
        public const string LWNCDJ = "LWNCDJ";

        /// <summary>
        /// LWQTY1.
        /// </summary>
        public const string LWQTY1 = "LWQTY1";

        /// <summary>
        /// LWQTY2.
        /// </summary>
        public const string LWQTY2 = "LWQTY2";

        /// <summary>
        /// LWURAB.
        /// </summary>
        public const string LWURAB = "LWURAB";

        /// <summary>
        /// LWURRF.
        /// </summary>
        public const string LWURRF = "LWURRF";

        /// <summary>
        /// LWURAT.
        /// </summary>
        public const string LWURAT = "LWURAT";

        /// <summary>
        /// LWURCD.
        /// </summary>
        public const string LWURCD = "LWURCD";

        /// <summary>
        /// LWURDT.
        /// </summary>
        public const string LWURDT = "LWURDT";

        /// <summary>
        /// LWJOBN.
        /// </summary>
        public const string LWJOBN = "LWJOBN";

        /// <summary>
        /// LWPID.
        /// </summary>
        public const string LWPID = "LWPID";

        /// <summary>
        /// LWUPMJ.
        /// </summary>
        public const string LWUPMJ = "LWUPMJ";

        /// <summary>
        /// LWUSER.
        /// </summary>
        public const string LWUSER = "LWUSER";

        /// <summary>
        /// LWTDAY.
        /// </summary>
        public const string LWTDAY = "LWTDAY";

        /// <summary>
        /// LWHCMS.
        /// </summary>
        public const string LWHCMS = "LWHCMS";

        /// <summary>
        /// LWPJCM.
        /// </summary>
        public const string LWPJCM = "LWPJCM";

        /// <summary>
        /// LWPJDM.
        /// </summary>
        public const string LWPJDM = "LWPJDM";

        /// <summary>
        /// LWSCMS.
        /// </summary>
        public const string LWSCMS = "LWSCMS";

        /// <summary>
        /// LWSIBW.
        /// </summary>
        public const string LWSIBW = "LWSIBW";

        /// <summary>
        /// LWSOBW.
        /// </summary>
        public const string LWSOBW = "LWSOBW";

        /// <summary>
        /// LWSQOH.
        /// </summary>
        public const string LWSQOH = "LWSQOH";

        /// <summary>
        /// LWSQWO.
        /// </summary>
        public const string LWSQWO = "LWSQWO";

        /// <summary>
        /// LWSREQ.
        /// </summary>
        public const string LWSREQ = "LWSREQ";

        /// <summary>
        /// LWSWHC.
        /// </summary>
        public const string LWSWHC = "LWSWHC";

        /// <summary>
        /// LWSWSC.
        /// </summary>
        public const string LWSWSC = "LWSWSC";

        /// <summary>
        /// LWLOTC.
        /// </summary>
        public const string LWLOTC = "LWLOTC";

        /// <summary>
        /// LWCFGSID.
        /// </summary>
        public const string LWCFGSID = "LWCFGSID";
    }

    /// <inheritdoc />
    public override string TableName => "F41021WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LWJOBS", "LWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("LWCTID", "LWCTID", JdeDataType.String, 30, true, true),
        new JdeField("LWUKID", "LWUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("LWPIDP", "LWPIDP", JdeDataType.String, 20, true, true),
        new JdeField("LWITM", "LWITM", JdeDataType.Numeric, null, true, true),
        new JdeField("LWMCU", "LWMCU", JdeDataType.String, 24, true, true),
        new JdeField("LWLOCN", "LWLOCN", JdeDataType.String, 40, true, true),
        new JdeField("LWLOTN", "LWLOTN", JdeDataType.String, 60, true, true),
        new JdeField("LWMODE", "LWMODE", JdeDataType.String, 2),
        new JdeField("LWPBIN", "LWPBIN", JdeDataType.String, 2),
        new JdeField("LWGLPT", "LWGLPT", JdeDataType.String, 8),
        new JdeField("LWLOTS", "LWLOTS", JdeDataType.String, 2),
        new JdeField("LWLRCJ", "LWLRCJ", JdeDataType.Numeric),
        new JdeField("LWPQOH", "LWPQOH", JdeDataType.Numeric),
        new JdeField("LWPBCK", "LWPBCK", JdeDataType.Numeric),
        new JdeField("LWPREQ", "LWPREQ", JdeDataType.Numeric),
        new JdeField("LWQWBO", "LWQWBO", JdeDataType.Numeric),
        new JdeField("LWOT1P", "LWOT1P", JdeDataType.Numeric),
        new JdeField("LWOT2P", "LWOT2P", JdeDataType.Numeric),
        new JdeField("LWOT1A", "LWOT1A", JdeDataType.Numeric),
        new JdeField("LWHCOM", "LWHCOM", JdeDataType.Numeric),
        new JdeField("LWPCOM", "LWPCOM", JdeDataType.Numeric),
        new JdeField("LWFCOM", "LWFCOM", JdeDataType.Numeric),
        new JdeField("LWFUN1", "LWFUN1", JdeDataType.Numeric),
        new JdeField("LWQOWO", "LWQOWO", JdeDataType.Numeric),
        new JdeField("LWQTTR", "LWQTTR", JdeDataType.Numeric),
        new JdeField("LWQTIN", "LWQTIN", JdeDataType.Numeric),
        new JdeField("LWQONL", "LWQONL", JdeDataType.Numeric),
        new JdeField("LWQTRI", "LWQTRI", JdeDataType.Numeric),
        new JdeField("LWQTRO", "LWQTRO", JdeDataType.Numeric),
        new JdeField("LWQTO1", "LWQTO1", JdeDataType.Numeric),
        new JdeField("LWQTO2", "LWQTO2", JdeDataType.Numeric),
        new JdeField("LWNCDJ", "LWNCDJ", JdeDataType.Numeric),
        new JdeField("LWQTY1", "LWQTY1", JdeDataType.Numeric),
        new JdeField("LWQTY2", "LWQTY2", JdeDataType.Numeric),
        new JdeField("LWURAB", "LWURAB", JdeDataType.Numeric),
        new JdeField("LWURRF", "LWURRF", JdeDataType.String, 30),
        new JdeField("LWURAT", "LWURAT", JdeDataType.Numeric),
        new JdeField("LWURCD", "LWURCD", JdeDataType.String, 4),
        new JdeField("LWURDT", "LWURDT", JdeDataType.Numeric),
        new JdeField("LWJOBN", "LWJOBN", JdeDataType.String, 20),
        new JdeField("LWPID", "LWPID", JdeDataType.String, 20),
        new JdeField("LWUPMJ", "LWUPMJ", JdeDataType.Numeric),
        new JdeField("LWUSER", "LWUSER", JdeDataType.String, 20),
        new JdeField("LWTDAY", "LWTDAY", JdeDataType.Numeric),
        new JdeField("LWHCMS", "LWHCMS", JdeDataType.Numeric),
        new JdeField("LWPJCM", "LWPJCM", JdeDataType.Numeric),
        new JdeField("LWPJDM", "LWPJDM", JdeDataType.Numeric),
        new JdeField("LWSCMS", "LWSCMS", JdeDataType.Numeric),
        new JdeField("LWSIBW", "LWSIBW", JdeDataType.Numeric),
        new JdeField("LWSOBW", "LWSOBW", JdeDataType.Numeric),
        new JdeField("LWSQOH", "LWSQOH", JdeDataType.Numeric),
        new JdeField("LWSQWO", "LWSQWO", JdeDataType.Numeric),
        new JdeField("LWSREQ", "LWSREQ", JdeDataType.Numeric),
        new JdeField("LWSWHC", "LWSWHC", JdeDataType.Numeric),
        new JdeField("LWSWSC", "LWSWSC", JdeDataType.Numeric),
        new JdeField("LWLOTC", "LWLOTC", JdeDataType.String, 6),
        new JdeField("LWCFGSID", "LWCFGSID", JdeDataType.String, 64)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41021WF_0", "Primary Key on LWJOBS, LWCTID, LWUKID, LWPIDP, LWITM, LWMCU, LWLOCN, LWLOTN", new[] { "LWJOBS", "LWCTID", "LWUKID", "LWPIDP", "LWITM", "LWMCU", "LWLOCN", "LWLOTN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41021WF_9", "Index on LWTDAY, LWMODE", new[] { "LWTDAY", "LWMODE" })
    };
}
