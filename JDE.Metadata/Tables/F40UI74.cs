using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40UI74 - .
/// </summary>
public class F40UI74 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AWCTID.
        /// </summary>
        public const string AWCTID = "AWCTID";

        /// <summary>
        /// AWJOBS.
        /// </summary>
        public const string AWJOBS = "AWJOBS";

        /// <summary>
        /// AWPEID.
        /// </summary>
        public const string AWPEID = "AWPEID";

        /// <summary>
        /// AWTCID.
        /// </summary>
        public const string AWTCID = "AWTCID";

        /// <summary>
        /// AWXLIN.
        /// </summary>
        public const string AWXLIN = "AWXLIN";

        /// <summary>
        /// AWAREV.
        /// </summary>
        public const string AWAREV = "AWAREV";

        /// <summary>
        /// AWDOCO.
        /// </summary>
        public const string AWDOCO = "AWDOCO";

        /// <summary>
        /// AWDCTO.
        /// </summary>
        public const string AWDCTO = "AWDCTO";

        /// <summary>
        /// AWKCOO.
        /// </summary>
        public const string AWKCOO = "AWKCOO";

        /// <summary>
        /// AWSFXO.
        /// </summary>
        public const string AWSFXO = "AWSFXO";

        /// <summary>
        /// AWLNID.
        /// </summary>
        public const string AWLNID = "AWLNID";

        /// <summary>
        /// AWAKID.
        /// </summary>
        public const string AWAKID = "AWAKID";

        /// <summary>
        /// AWSRCFD.
        /// </summary>
        public const string AWSRCFD = "AWSRCFD";

        /// <summary>
        /// AWOSEQ.
        /// </summary>
        public const string AWOSEQ = "AWOSEQ";

        /// <summary>
        /// AWSUBSEQ.
        /// </summary>
        public const string AWSUBSEQ = "AWSUBSEQ";

        /// <summary>
        /// AWTIER.
        /// </summary>
        public const string AWTIER = "AWTIER";

        /// <summary>
        /// AWASN.
        /// </summary>
        public const string AWASN = "AWASN";

        /// <summary>
        /// AWAST.
        /// </summary>
        public const string AWAST = "AWAST";

        /// <summary>
        /// AWITM.
        /// </summary>
        public const string AWITM = "AWITM";

        /// <summary>
        /// AWAN8.
        /// </summary>
        public const string AWAN8 = "AWAN8";

        /// <summary>
        /// AWCRCD.
        /// </summary>
        public const string AWCRCD = "AWCRCD";

        /// <summary>
        /// AWUOM.
        /// </summary>
        public const string AWUOM = "AWUOM";

        /// <summary>
        /// AWMNQ.
        /// </summary>
        public const string AWMNQ = "AWMNQ";

        /// <summary>
        /// AWLEDG.
        /// </summary>
        public const string AWLEDG = "AWLEDG";

        /// <summary>
        /// AWFRMN.
        /// </summary>
        public const string AWFRMN = "AWFRMN";

        /// <summary>
        /// AWBSCD.
        /// </summary>
        public const string AWBSCD = "AWBSCD";

        /// <summary>
        /// AWFVTR.
        /// </summary>
        public const string AWFVTR = "AWFVTR";

        /// <summary>
        /// AWABAS.
        /// </summary>
        public const string AWABAS = "AWABAS";

        /// <summary>
        /// AWUPRC.
        /// </summary>
        public const string AWUPRC = "AWUPRC";

        /// <summary>
        /// AWFUP.
        /// </summary>
        public const string AWFUP = "AWFUP";

        /// <summary>
        /// AWGLC.
        /// </summary>
        public const string AWGLC = "AWGLC";

        /// <summary>
        /// AWARSN.
        /// </summary>
        public const string AWARSN = "AWARSN";

        /// <summary>
        /// AWACNT.
        /// </summary>
        public const string AWACNT = "AWACNT";

        /// <summary>
        /// AWSBIF.
        /// </summary>
        public const string AWSBIF = "AWSBIF";

        /// <summary>
        /// AWMDED.
        /// </summary>
        public const string AWMDED = "AWMDED";

        /// <summary>
        /// AWPROV.
        /// </summary>
        public const string AWPROV = "AWPROV";

        /// <summary>
        /// AWATID.
        /// </summary>
        public const string AWATID = "AWATID";

        /// <summary>
        /// AWLITM.
        /// </summary>
        public const string AWLITM = "AWLITM";

        /// <summary>
        /// AWAITM.
        /// </summary>
        public const string AWAITM = "AWAITM";

        /// <summary>
        /// AWDSC1.
        /// </summary>
        public const string AWDSC1 = "AWDSC1";

        /// <summary>
        /// AWLNTY.
        /// </summary>
        public const string AWLNTY = "AWLNTY";

        /// <summary>
        /// AWUORG.
        /// </summary>
        public const string AWUORG = "AWUORG";

        /// <summary>
        /// AWFGY.
        /// </summary>
        public const string AWFGY = "AWFGY";

        /// <summary>
        /// AWORPR.
        /// </summary>
        public const string AWORPR = "AWORPR";

        /// <summary>
        /// AWSO08.
        /// </summary>
        public const string AWSO08 = "AWSO08";

        /// <summary>
        /// AWRPRC.
        /// </summary>
        public const string AWRPRC = "AWRPRC";

        /// <summary>
        /// AWOLVL.
        /// </summary>
        public const string AWOLVL = "AWOLVL";

        /// <summary>
        /// AWCATLG.
        /// </summary>
        public const string AWCATLG = "AWCATLG";

        /// <summary>
        /// AWIGID.
        /// </summary>
        public const string AWIGID = "AWIGID";

        /// <summary>
        /// AWCGID.
        /// </summary>
        public const string AWCGID = "AWCGID";

        /// <summary>
        /// AWOGID.
        /// </summary>
        public const string AWOGID = "AWOGID";

        /// <summary>
        /// AWANPS.
        /// </summary>
        public const string AWANPS = "AWANPS";

        /// <summary>
        /// AWBSDVAL.
        /// </summary>
        public const string AWBSDVAL = "AWBSDVAL";

        /// <summary>
        /// AWSRFLAG.
        /// </summary>
        public const string AWSRFLAG = "AWSRFLAG";

        /// <summary>
        /// AWADJCAL.
        /// </summary>
        public const string AWADJCAL = "AWADJCAL";

        /// <summary>
        /// AWNBRORD.
        /// </summary>
        public const string AWNBRORD = "AWNBRORD";

        /// <summary>
        /// AWUOMVID.
        /// </summary>
        public const string AWUOMVID = "AWUOMVID";

        /// <summary>
        /// AWACCAN8.
        /// </summary>
        public const string AWACCAN8 = "AWACCAN8";

        /// <summary>
        /// AWBNAD.
        /// </summary>
        public const string AWBNAD = "AWBNAD";

        /// <summary>
        /// AWADJGRP.
        /// </summary>
        public const string AWADJGRP = "AWADJGRP";

        /// <summary>
        /// AWMEADJ.
        /// </summary>
        public const string AWMEADJ = "AWMEADJ";

        /// <summary>
        /// AWADJSTS.
        /// </summary>
        public const string AWADJSTS = "AWADJSTS";

        /// <summary>
        /// AWADJREF.
        /// </summary>
        public const string AWADJREF = "AWADJREF";

        /// <summary>
        /// AWFVUM.
        /// </summary>
        public const string AWFVUM = "AWFVUM";

        /// <summary>
        /// AWPDCL.
        /// </summary>
        public const string AWPDCL = "AWPDCL";

        /// <summary>
        /// AWCFGID.
        /// </summary>
        public const string AWCFGID = "AWCFGID";

        /// <summary>
        /// AWCFGCID.
        /// </summary>
        public const string AWCFGCID = "AWCFGCID";

        /// <summary>
        /// AWAPRP1.
        /// </summary>
        public const string AWAPRP1 = "AWAPRP1";

        /// <summary>
        /// AWAPRP2.
        /// </summary>
        public const string AWAPRP2 = "AWAPRP2";

        /// <summary>
        /// AWAPRP3.
        /// </summary>
        public const string AWAPRP3 = "AWAPRP3";

        /// <summary>
        /// AWAPRP4.
        /// </summary>
        public const string AWAPRP4 = "AWAPRP4";

        /// <summary>
        /// AWAPRP5.
        /// </summary>
        public const string AWAPRP5 = "AWAPRP5";

        /// <summary>
        /// AWAPRP6.
        /// </summary>
        public const string AWAPRP6 = "AWAPRP6";

        /// <summary>
        /// AWNDPI.
        /// </summary>
        public const string AWNDPI = "AWNDPI";

        /// <summary>
        /// AWPMTN.
        /// </summary>
        public const string AWPMTN = "AWPMTN";

        /// <summary>
        /// AWRULENAME.
        /// </summary>
        public const string AWRULENAME = "AWRULENAME";

        /// <summary>
        /// AWPA04.
        /// </summary>
        public const string AWPA04 = "AWPA04";

        /// <summary>
        /// AWADJQTY.
        /// </summary>
        public const string AWADJQTY = "AWADJQTY";

        /// <summary>
        /// AWQTYPY.
        /// </summary>
        public const string AWQTYPY = "AWQTYPY";

        /// <summary>
        /// AWSTPRCF.
        /// </summary>
        public const string AWSTPRCF = "AWSTPRCF";

        /// <summary>
        /// AWTSTRSNM.
        /// </summary>
        public const string AWTSTRSNM = "AWTSTRSNM";
    }

    /// <inheritdoc />
    public override string TableName => "F40UI74";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AWCTID", "AWCTID", JdeDataType.String, 30, true, true),
        new JdeField("AWJOBS", "AWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("AWPEID", "AWPEID", JdeDataType.Numeric, null, true, true),
        new JdeField("AWTCID", "AWTCID", JdeDataType.Numeric, null, true, true),
        new JdeField("AWXLIN", "AWXLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("AWAREV", "AWAREV", JdeDataType.Numeric, null, true, true),
        new JdeField("AWDOCO", "AWDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("AWDCTO", "AWDCTO", JdeDataType.String, 4, true, true),
        new JdeField("AWKCOO", "AWKCOO", JdeDataType.String, 10, true, true),
        new JdeField("AWSFXO", "AWSFXO", JdeDataType.String, 6, true, true),
        new JdeField("AWLNID", "AWLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("AWAKID", "AWAKID", JdeDataType.Numeric, null, true, true),
        new JdeField("AWSRCFD", "AWSRCFD", JdeDataType.String, 4, true, true),
        new JdeField("AWOSEQ", "AWOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("AWSUBSEQ", "AWSUBSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("AWTIER", "AWTIER", JdeDataType.Numeric, null, true, true),
        new JdeField("AWASN", "AWASN", JdeDataType.String, 16),
        new JdeField("AWAST", "AWAST", JdeDataType.String, 16),
        new JdeField("AWITM", "AWITM", JdeDataType.Numeric),
        new JdeField("AWAN8", "AWAN8", JdeDataType.Numeric),
        new JdeField("AWCRCD", "AWCRCD", JdeDataType.String, 6),
        new JdeField("AWUOM", "AWUOM", JdeDataType.String, 4),
        new JdeField("AWMNQ", "AWMNQ", JdeDataType.Numeric),
        new JdeField("AWLEDG", "AWLEDG", JdeDataType.String, 4),
        new JdeField("AWFRMN", "AWFRMN", JdeDataType.String, 20),
        new JdeField("AWBSCD", "AWBSCD", JdeDataType.String, 2),
        new JdeField("AWFVTR", "AWFVTR", JdeDataType.Numeric),
        new JdeField("AWABAS", "AWABAS", JdeDataType.String, 2),
        new JdeField("AWUPRC", "AWUPRC", JdeDataType.Numeric),
        new JdeField("AWFUP", "AWFUP", JdeDataType.Numeric),
        new JdeField("AWGLC", "AWGLC", JdeDataType.String, 8),
        new JdeField("AWARSN", "AWARSN", JdeDataType.String, 6),
        new JdeField("AWACNT", "AWACNT", JdeDataType.String, 2),
        new JdeField("AWSBIF", "AWSBIF", JdeDataType.String, 2),
        new JdeField("AWMDED", "AWMDED", JdeDataType.String, 2),
        new JdeField("AWPROV", "AWPROV", JdeDataType.String, 2),
        new JdeField("AWATID", "AWATID", JdeDataType.Numeric),
        new JdeField("AWLITM", "AWLITM", JdeDataType.String, 50),
        new JdeField("AWAITM", "AWAITM", JdeDataType.String, 50),
        new JdeField("AWDSC1", "AWDSC1", JdeDataType.String, 60),
        new JdeField("AWLNTY", "AWLNTY", JdeDataType.String, 4),
        new JdeField("AWUORG", "AWUORG", JdeDataType.Numeric),
        new JdeField("AWFGY", "AWFGY", JdeDataType.String, 2),
        new JdeField("AWORPR", "AWORPR", JdeDataType.String, 16),
        new JdeField("AWSO08", "AWSO08", JdeDataType.String, 2),
        new JdeField("AWRPRC", "AWRPRC", JdeDataType.String, 16),
        new JdeField("AWOLVL", "AWOLVL", JdeDataType.String, 2),
        new JdeField("AWCATLG", "AWCATLG", JdeDataType.String, 20),
        new JdeField("AWIGID", "AWIGID", JdeDataType.Numeric),
        new JdeField("AWCGID", "AWCGID", JdeDataType.Numeric),
        new JdeField("AWOGID", "AWOGID", JdeDataType.Numeric),
        new JdeField("AWANPS", "AWANPS", JdeDataType.Numeric),
        new JdeField("AWBSDVAL", "AWBSDVAL", JdeDataType.Numeric),
        new JdeField("AWSRFLAG", "AWSRFLAG", JdeDataType.String, 2),
        new JdeField("AWADJCAL", "AWADJCAL", JdeDataType.String, 160),
        new JdeField("AWNBRORD", "AWNBRORD", JdeDataType.Numeric),
        new JdeField("AWUOMVID", "AWUOMVID", JdeDataType.String, 4),
        new JdeField("AWACCAN8", "AWACCAN8", JdeDataType.Numeric),
        new JdeField("AWBNAD", "AWBNAD", JdeDataType.Numeric),
        new JdeField("AWADJGRP", "AWADJGRP", JdeDataType.String, 20),
        new JdeField("AWMEADJ", "AWMEADJ", JdeDataType.String, 2),
        new JdeField("AWADJSTS", "AWADJSTS", JdeDataType.String, 2),
        new JdeField("AWADJREF", "AWADJREF", JdeDataType.String, 30),
        new JdeField("AWFVUM", "AWFVUM", JdeDataType.String, 4),
        new JdeField("AWPDCL", "AWPDCL", JdeDataType.String, 2),
        new JdeField("AWCFGID", "AWCFGID", JdeDataType.Numeric),
        new JdeField("AWCFGCID", "AWCFGCID", JdeDataType.Numeric),
        new JdeField("AWAPRP1", "AWAPRP1", JdeDataType.String, 6),
        new JdeField("AWAPRP2", "AWAPRP2", JdeDataType.String, 6),
        new JdeField("AWAPRP3", "AWAPRP3", JdeDataType.String, 6),
        new JdeField("AWAPRP4", "AWAPRP4", JdeDataType.String, 12),
        new JdeField("AWAPRP5", "AWAPRP5", JdeDataType.String, 12),
        new JdeField("AWAPRP6", "AWAPRP6", JdeDataType.String, 12),
        new JdeField("AWNDPI", "AWNDPI", JdeDataType.String, 2),
        new JdeField("AWPMTN", "AWPMTN", JdeDataType.String, 24),
        new JdeField("AWRULENAME", "AWRULENAME", JdeDataType.String, 20),
        new JdeField("AWPA04", "AWPA04", JdeDataType.String, 2),
        new JdeField("AWADJQTY", "AWADJQTY", JdeDataType.String, 2),
        new JdeField("AWQTYPY", "AWQTYPY", JdeDataType.Numeric),
        new JdeField("AWSTPRCF", "AWSTPRCF", JdeDataType.String, 2),
        new JdeField("AWTSTRSNM", "AWTSTRSNM", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40UI74_0", "Primary Key on AWCTID, AWPEID, AWJOBS, AWTCID, AWXLIN, AWDOCO, AWDCTO, AWKCOO, AWSFXO, AWLNID, AWAREV, AWAKID, AWSRCFD, AWOSEQ, AWSUBSEQ, AWTIER", new[] { "AWCTID", "AWPEID", "AWJOBS", "AWTCID", "AWXLIN", "AWDOCO", "AWDCTO", "AWKCOO", "AWSFXO", "AWLNID", "AWAREV", "AWAKID", "AWSRCFD", "AWOSEQ", "AWSUBSEQ", "AWTIER" }, isUnique: true, isPrimaryKey: true)
    };
}
