using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42UI130 - .
/// </summary>
public class F42UI130 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZCTCID.
        /// </summary>
        public const string ZCTCID = "ZCTCID";

        /// <summary>
        /// ZCPEID.
        /// </summary>
        public const string ZCPEID = "ZCPEID";

        /// <summary>
        /// ZCCTID.
        /// </summary>
        public const string ZCCTID = "ZCCTID";

        /// <summary>
        /// ZCJOBS.
        /// </summary>
        public const string ZCJOBS = "ZCJOBS";

        /// <summary>
        /// ZCXLIN.
        /// </summary>
        public const string ZCXLIN = "ZCXLIN";

        /// <summary>
        /// ZCDOCO.
        /// </summary>
        public const string ZCDOCO = "ZCDOCO";

        /// <summary>
        /// ZCDCTO.
        /// </summary>
        public const string ZCDCTO = "ZCDCTO";

        /// <summary>
        /// ZCKCOO.
        /// </summary>
        public const string ZCKCOO = "ZCKCOO";

        /// <summary>
        /// ZCLNID.
        /// </summary>
        public const string ZCLNID = "ZCLNID";

        /// <summary>
        /// ZCSEQ.
        /// </summary>
        public const string ZCSEQ = "ZCSEQ";

        /// <summary>
        /// ZCEDTY.
        /// </summary>
        public const string ZCEDTY = "ZCEDTY";

        /// <summary>
        /// ZCITM.
        /// </summary>
        public const string ZCITM = "ZCITM";

        /// <summary>
        /// ZCMCU.
        /// </summary>
        public const string ZCMCU = "ZCMCU";

        /// <summary>
        /// ZCUOM.
        /// </summary>
        public const string ZCUOM = "ZCUOM";

        /// <summary>
        /// ZCPDDJ.
        /// </summary>
        public const string ZCPDDJ = "ZCPDDJ";

        /// <summary>
        /// ZCSOQS.
        /// </summary>
        public const string ZCSOQS = "ZCSOQS";

        /// <summary>
        /// ZCSOBK.
        /// </summary>
        public const string ZCSOBK = "ZCSOBK";

        /// <summary>
        /// ZCSOCN.
        /// </summary>
        public const string ZCSOCN = "ZCSOCN";

        /// <summary>
        /// ZCLOCN.
        /// </summary>
        public const string ZCLOCN = "ZCLOCN";

        /// <summary>
        /// ZCLOTN.
        /// </summary>
        public const string ZCLOTN = "ZCLOTN";

        /// <summary>
        /// ZCSHCM.
        /// </summary>
        public const string ZCSHCM = "ZCSHCM";

        /// <summary>
        /// ZCSHCN.
        /// </summary>
        public const string ZCSHCN = "ZCSHCN";

        /// <summary>
        /// ZCSRP1.
        /// </summary>
        public const string ZCSRP1 = "ZCSRP1";

        /// <summary>
        /// ZCSRP2.
        /// </summary>
        public const string ZCSRP2 = "ZCSRP2";

        /// <summary>
        /// ZCSRP3.
        /// </summary>
        public const string ZCSRP3 = "ZCSRP3";

        /// <summary>
        /// ZCSRP4.
        /// </summary>
        public const string ZCSRP4 = "ZCSRP4";

        /// <summary>
        /// ZCSRP5.
        /// </summary>
        public const string ZCSRP5 = "ZCSRP5";

        /// <summary>
        /// ZCPRP1.
        /// </summary>
        public const string ZCPRP1 = "ZCPRP1";

        /// <summary>
        /// ZCPRP2.
        /// </summary>
        public const string ZCPRP2 = "ZCPRP2";

        /// <summary>
        /// ZCPRP3.
        /// </summary>
        public const string ZCPRP3 = "ZCPRP3";

        /// <summary>
        /// ZCPRP4.
        /// </summary>
        public const string ZCPRP4 = "ZCPRP4";

        /// <summary>
        /// ZCPRP5.
        /// </summary>
        public const string ZCPRP5 = "ZCPRP5";

        /// <summary>
        /// ZCRPRC.
        /// </summary>
        public const string ZCRPRC = "ZCRPRC";

        /// <summary>
        /// ZCORPR.
        /// </summary>
        public const string ZCORPR = "ZCORPR";

        /// <summary>
        /// ZCVEND.
        /// </summary>
        public const string ZCVEND = "ZCVEND";

        /// <summary>
        /// ZCBUYR.
        /// </summary>
        public const string ZCBUYR = "ZCBUYR";

        /// <summary>
        /// ZCCARS.
        /// </summary>
        public const string ZCCARS = "ZCCARS";

        /// <summary>
        /// ZCINMG.
        /// </summary>
        public const string ZCINMG = "ZCINMG";

        /// <summary>
        /// ZCPRGR.
        /// </summary>
        public const string ZCPRGR = "ZCPRGR";

        /// <summary>
        /// ZCSTKT.
        /// </summary>
        public const string ZCSTKT = "ZCSTKT";

        /// <summary>
        /// ZCTAX1.
        /// </summary>
        public const string ZCTAX1 = "ZCTAX1";

        /// <summary>
        /// ZCLNTY.
        /// </summary>
        public const string ZCLNTY = "ZCLNTY";

        /// <summary>
        /// ZCMOT.
        /// </summary>
        public const string ZCMOT = "ZCMOT";

        /// <summary>
        /// ZCROUT.
        /// </summary>
        public const string ZCROUT = "ZCROUT";

        /// <summary>
        /// ZCUNCS.
        /// </summary>
        public const string ZCUNCS = "ZCUNCS";

        /// <summary>
        /// ZCCOMM.
        /// </summary>
        public const string ZCCOMM = "ZCCOMM";

        /// <summary>
        /// ZCRSDJ.
        /// </summary>
        public const string ZCRSDJ = "ZCRSDJ";

        /// <summary>
        /// ZCFRGD.
        /// </summary>
        public const string ZCFRGD = "ZCFRGD";

        /// <summary>
        /// ZCTHGD.
        /// </summary>
        public const string ZCTHGD = "ZCTHGD";

        /// <summary>
        /// ZCFRMP.
        /// </summary>
        public const string ZCFRMP = "ZCFRMP";

        /// <summary>
        /// ZCTHRP.
        /// </summary>
        public const string ZCTHRP = "ZCTHRP";

        /// <summary>
        /// ZCCPQS.
        /// </summary>
        public const string ZCCPQS = "ZCCPQS";

        /// <summary>
        /// ZCCPBK.
        /// </summary>
        public const string ZCCPBK = "ZCCPBK";

        /// <summary>
        /// ZCCPCN.
        /// </summary>
        public const string ZCCPCN = "ZCCPCN";

        /// <summary>
        /// ZCEDCK.
        /// </summary>
        public const string ZCEDCK = "ZCEDCK";

        /// <summary>
        /// ZCSBCK.
        /// </summary>
        public const string ZCSBCK = "ZCSBCK";

        /// <summary>
        /// ZCCMDM.
        /// </summary>
        public const string ZCCMDM = "ZCCMDM";

        /// <summary>
        /// ZCBBCK.
        /// </summary>
        public const string ZCBBCK = "ZCBBCK";

        /// <summary>
        /// ZCSQOR.
        /// </summary>
        public const string ZCSQOR = "ZCSQOR";

        /// <summary>
        /// ZCSONE.
        /// </summary>
        public const string ZCSONE = "ZCSONE";

        /// <summary>
        /// ZCGENSTR.
        /// </summary>
        public const string ZCGENSTR = "ZCGENSTR";

        /// <summary>
        /// ZCPPDJ.
        /// </summary>
        public const string ZCPPDJ = "ZCPPDJ";

        /// <summary>
        /// ZCALLOC.
        /// </summary>
        public const string ZCALLOC = "ZCALLOC";
    }

    /// <inheritdoc />
    public override string TableName => "F42UI130";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZCTCID", "ZCTCID", JdeDataType.Numeric, null, true, true),
        new JdeField("ZCPEID", "ZCPEID", JdeDataType.Numeric, null, true, true),
        new JdeField("ZCCTID", "ZCCTID", JdeDataType.String, 30, true, true),
        new JdeField("ZCJOBS", "ZCJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ZCXLIN", "ZCXLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("ZCDOCO", "ZCDOCO", JdeDataType.Numeric),
        new JdeField("ZCDCTO", "ZCDCTO", JdeDataType.String, 4),
        new JdeField("ZCKCOO", "ZCKCOO", JdeDataType.String, 10),
        new JdeField("ZCLNID", "ZCLNID", JdeDataType.Numeric),
        new JdeField("ZCSEQ", "ZCSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ZCEDTY", "ZCEDTY", JdeDataType.String, 2),
        new JdeField("ZCITM", "ZCITM", JdeDataType.Numeric),
        new JdeField("ZCMCU", "ZCMCU", JdeDataType.String, 24),
        new JdeField("ZCUOM", "ZCUOM", JdeDataType.String, 4),
        new JdeField("ZCPDDJ", "ZCPDDJ", JdeDataType.Numeric),
        new JdeField("ZCSOQS", "ZCSOQS", JdeDataType.Numeric),
        new JdeField("ZCSOBK", "ZCSOBK", JdeDataType.Numeric),
        new JdeField("ZCSOCN", "ZCSOCN", JdeDataType.Numeric),
        new JdeField("ZCLOCN", "ZCLOCN", JdeDataType.String, 40),
        new JdeField("ZCLOTN", "ZCLOTN", JdeDataType.String, 60),
        new JdeField("ZCSHCM", "ZCSHCM", JdeDataType.String, 6),
        new JdeField("ZCSHCN", "ZCSHCN", JdeDataType.String, 6),
        new JdeField("ZCSRP1", "ZCSRP1", JdeDataType.String, 6),
        new JdeField("ZCSRP2", "ZCSRP2", JdeDataType.String, 6),
        new JdeField("ZCSRP3", "ZCSRP3", JdeDataType.String, 6),
        new JdeField("ZCSRP4", "ZCSRP4", JdeDataType.String, 6),
        new JdeField("ZCSRP5", "ZCSRP5", JdeDataType.String, 6),
        new JdeField("ZCPRP1", "ZCPRP1", JdeDataType.String, 6),
        new JdeField("ZCPRP2", "ZCPRP2", JdeDataType.String, 6),
        new JdeField("ZCPRP3", "ZCPRP3", JdeDataType.String, 6),
        new JdeField("ZCPRP4", "ZCPRP4", JdeDataType.String, 6),
        new JdeField("ZCPRP5", "ZCPRP5", JdeDataType.String, 6),
        new JdeField("ZCRPRC", "ZCRPRC", JdeDataType.String, 16),
        new JdeField("ZCORPR", "ZCORPR", JdeDataType.String, 16),
        new JdeField("ZCVEND", "ZCVEND", JdeDataType.Numeric),
        new JdeField("ZCBUYR", "ZCBUYR", JdeDataType.Numeric),
        new JdeField("ZCCARS", "ZCCARS", JdeDataType.Numeric),
        new JdeField("ZCINMG", "ZCINMG", JdeDataType.String, 20),
        new JdeField("ZCPRGR", "ZCPRGR", JdeDataType.String, 16),
        new JdeField("ZCSTKT", "ZCSTKT", JdeDataType.String, 2),
        new JdeField("ZCTAX1", "ZCTAX1", JdeDataType.String, 2),
        new JdeField("ZCLNTY", "ZCLNTY", JdeDataType.String, 4),
        new JdeField("ZCMOT", "ZCMOT", JdeDataType.String, 6),
        new JdeField("ZCROUT", "ZCROUT", JdeDataType.String, 6),
        new JdeField("ZCUNCS", "ZCUNCS", JdeDataType.Numeric),
        new JdeField("ZCCOMM", "ZCCOMM", JdeDataType.String, 2),
        new JdeField("ZCRSDJ", "ZCRSDJ", JdeDataType.Numeric),
        new JdeField("ZCFRGD", "ZCFRGD", JdeDataType.String, 6),
        new JdeField("ZCTHGD", "ZCTHGD", JdeDataType.String, 6),
        new JdeField("ZCFRMP", "ZCFRMP", JdeDataType.Numeric),
        new JdeField("ZCTHRP", "ZCTHRP", JdeDataType.Numeric),
        new JdeField("ZCCPQS", "ZCCPQS", JdeDataType.Numeric),
        new JdeField("ZCCPBK", "ZCCPBK", JdeDataType.Numeric),
        new JdeField("ZCCPCN", "ZCCPCN", JdeDataType.Numeric),
        new JdeField("ZCEDCK", "ZCEDCK", JdeDataType.String, 2),
        new JdeField("ZCSBCK", "ZCSBCK", JdeDataType.String, 2),
        new JdeField("ZCCMDM", "ZCCMDM", JdeDataType.String, 2),
        new JdeField("ZCBBCK", "ZCBBCK", JdeDataType.String, 2),
        new JdeField("ZCSQOR", "ZCSQOR", JdeDataType.Numeric),
        new JdeField("ZCSONE", "ZCSONE", JdeDataType.Numeric),
        new JdeField("ZCGENSTR", "ZCGENSTR", JdeDataType.String, 60),
        new JdeField("ZCPPDJ", "ZCPPDJ", JdeDataType.Numeric),
        new JdeField("ZCALLOC", "ZCALLOC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42UI130_0", "Primary Key on ZCCTID, ZCPEID, ZCTCID, ZCJOBS, ZCXLIN, ZCSEQ", new[] { "ZCCTID", "ZCPEID", "ZCTCID", "ZCJOBS", "ZCXLIN", "ZCSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42UI130_2", "Unique Index on ZCPEID, ZCCTID, ZCTCID, ZCJOBS, ZCXLIN, ZCEDTY, ZCITM, ZCMCU, ZCLOCN, ZCLOTN, ZCSEQ", new[] { "ZCPEID", "ZCCTID", "ZCTCID", "ZCJOBS", "ZCXLIN", "ZCEDTY", "ZCITM", "ZCMCU", "ZCLOCN", "ZCLOTN", "ZCSEQ" }, isUnique: true)
    };
}
