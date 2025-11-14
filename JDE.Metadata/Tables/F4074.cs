using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4074 - .
/// </summary>
public class F4074 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ALDOCO.
        /// </summary>
        public const string ALDOCO = "ALDOCO";

        /// <summary>
        /// ALDCTO.
        /// </summary>
        public const string ALDCTO = "ALDCTO";

        /// <summary>
        /// ALKCOO.
        /// </summary>
        public const string ALKCOO = "ALKCOO";

        /// <summary>
        /// ALSFXO.
        /// </summary>
        public const string ALSFXO = "ALSFXO";

        /// <summary>
        /// ALLNID.
        /// </summary>
        public const string ALLNID = "ALLNID";

        /// <summary>
        /// ALAKID.
        /// </summary>
        public const string ALAKID = "ALAKID";

        /// <summary>
        /// ALSRCFD.
        /// </summary>
        public const string ALSRCFD = "ALSRCFD";

        /// <summary>
        /// ALOSEQ.
        /// </summary>
        public const string ALOSEQ = "ALOSEQ";

        /// <summary>
        /// ALSUBSEQ.
        /// </summary>
        public const string ALSUBSEQ = "ALSUBSEQ";

        /// <summary>
        /// ALTIER.
        /// </summary>
        public const string ALTIER = "ALTIER";

        /// <summary>
        /// ALASN.
        /// </summary>
        public const string ALASN = "ALASN";

        /// <summary>
        /// ALAST.
        /// </summary>
        public const string ALAST = "ALAST";

        /// <summary>
        /// ALITM.
        /// </summary>
        public const string ALITM = "ALITM";

        /// <summary>
        /// ALAN8.
        /// </summary>
        public const string ALAN8 = "ALAN8";

        /// <summary>
        /// ALCRCD.
        /// </summary>
        public const string ALCRCD = "ALCRCD";

        /// <summary>
        /// ALUOM.
        /// </summary>
        public const string ALUOM = "ALUOM";

        /// <summary>
        /// ALMNQ.
        /// </summary>
        public const string ALMNQ = "ALMNQ";

        /// <summary>
        /// ALLEDG.
        /// </summary>
        public const string ALLEDG = "ALLEDG";

        /// <summary>
        /// ALFRMN.
        /// </summary>
        public const string ALFRMN = "ALFRMN";

        /// <summary>
        /// ALBSCD.
        /// </summary>
        public const string ALBSCD = "ALBSCD";

        /// <summary>
        /// ALFVTR.
        /// </summary>
        public const string ALFVTR = "ALFVTR";

        /// <summary>
        /// ALABAS.
        /// </summary>
        public const string ALABAS = "ALABAS";

        /// <summary>
        /// ALUPRC.
        /// </summary>
        public const string ALUPRC = "ALUPRC";

        /// <summary>
        /// ALFUP.
        /// </summary>
        public const string ALFUP = "ALFUP";

        /// <summary>
        /// ALGLC.
        /// </summary>
        public const string ALGLC = "ALGLC";

        /// <summary>
        /// ALARSN.
        /// </summary>
        public const string ALARSN = "ALARSN";

        /// <summary>
        /// ALACNT.
        /// </summary>
        public const string ALACNT = "ALACNT";

        /// <summary>
        /// ALSBIF.
        /// </summary>
        public const string ALSBIF = "ALSBIF";

        /// <summary>
        /// ALMDED.
        /// </summary>
        public const string ALMDED = "ALMDED";

        /// <summary>
        /// ALPROV.
        /// </summary>
        public const string ALPROV = "ALPROV";

        /// <summary>
        /// ALATID.
        /// </summary>
        public const string ALATID = "ALATID";

        /// <summary>
        /// ALIGID.
        /// </summary>
        public const string ALIGID = "ALIGID";

        /// <summary>
        /// ALCGID.
        /// </summary>
        public const string ALCGID = "ALCGID";

        /// <summary>
        /// ALOGID.
        /// </summary>
        public const string ALOGID = "ALOGID";

        /// <summary>
        /// ALANPS.
        /// </summary>
        public const string ALANPS = "ALANPS";

        /// <summary>
        /// ALBSDVAL.
        /// </summary>
        public const string ALBSDVAL = "ALBSDVAL";

        /// <summary>
        /// ALSRFLAG.
        /// </summary>
        public const string ALSRFLAG = "ALSRFLAG";

        /// <summary>
        /// ALADJCAL.
        /// </summary>
        public const string ALADJCAL = "ALADJCAL";

        /// <summary>
        /// ALNBRORD.
        /// </summary>
        public const string ALNBRORD = "ALNBRORD";

        /// <summary>
        /// ALUOMVID.
        /// </summary>
        public const string ALUOMVID = "ALUOMVID";

        /// <summary>
        /// ALOLVL.
        /// </summary>
        public const string ALOLVL = "ALOLVL";

        /// <summary>
        /// ALADJSTS.
        /// </summary>
        public const string ALADJSTS = "ALADJSTS";

        /// <summary>
        /// ALADJREF.
        /// </summary>
        public const string ALADJREF = "ALADJREF";

        /// <summary>
        /// ALACCAN8.
        /// </summary>
        public const string ALACCAN8 = "ALACCAN8";

        /// <summary>
        /// ALBNAD.
        /// </summary>
        public const string ALBNAD = "ALBNAD";

        /// <summary>
        /// ALADJGRP.
        /// </summary>
        public const string ALADJGRP = "ALADJGRP";

        /// <summary>
        /// ALMEADJ.
        /// </summary>
        public const string ALMEADJ = "ALMEADJ";

        /// <summary>
        /// ALFVUM.
        /// </summary>
        public const string ALFVUM = "ALFVUM";

        /// <summary>
        /// ALPDCL.
        /// </summary>
        public const string ALPDCL = "ALPDCL";

        /// <summary>
        /// ALCFGID.
        /// </summary>
        public const string ALCFGID = "ALCFGID";

        /// <summary>
        /// ALCFGCID.
        /// </summary>
        public const string ALCFGCID = "ALCFGCID";

        /// <summary>
        /// ALAPRP1.
        /// </summary>
        public const string ALAPRP1 = "ALAPRP1";

        /// <summary>
        /// ALAPRP2.
        /// </summary>
        public const string ALAPRP2 = "ALAPRP2";

        /// <summary>
        /// ALAPRP3.
        /// </summary>
        public const string ALAPRP3 = "ALAPRP3";

        /// <summary>
        /// ALAPRP4.
        /// </summary>
        public const string ALAPRP4 = "ALAPRP4";

        /// <summary>
        /// ALAPRP5.
        /// </summary>
        public const string ALAPRP5 = "ALAPRP5";

        /// <summary>
        /// ALAPRP6.
        /// </summary>
        public const string ALAPRP6 = "ALAPRP6";

        /// <summary>
        /// ALNDPI.
        /// </summary>
        public const string ALNDPI = "ALNDPI";

        /// <summary>
        /// ALUSER.
        /// </summary>
        public const string ALUSER = "ALUSER";

        /// <summary>
        /// ALPID.
        /// </summary>
        public const string ALPID = "ALPID";

        /// <summary>
        /// ALJOBN.
        /// </summary>
        public const string ALJOBN = "ALJOBN";

        /// <summary>
        /// ALUPMJ.
        /// </summary>
        public const string ALUPMJ = "ALUPMJ";

        /// <summary>
        /// ALTDAY.
        /// </summary>
        public const string ALTDAY = "ALTDAY";

        /// <summary>
        /// ALPMTN.
        /// </summary>
        public const string ALPMTN = "ALPMTN";

        /// <summary>
        /// ALRULENAME.
        /// </summary>
        public const string ALRULENAME = "ALRULENAME";

        /// <summary>
        /// ALPA04.
        /// </summary>
        public const string ALPA04 = "ALPA04";

        /// <summary>
        /// ALADJQTY.
        /// </summary>
        public const string ALADJQTY = "ALADJQTY";

        /// <summary>
        /// ALQTYPY.
        /// </summary>
        public const string ALQTYPY = "ALQTYPY";

        /// <summary>
        /// ALSTPRCF.
        /// </summary>
        public const string ALSTPRCF = "ALSTPRCF";

        /// <summary>
        /// ALTSTRSNM.
        /// </summary>
        public const string ALTSTRSNM = "ALTSTRSNM";
    }

    /// <inheritdoc />
    public override string TableName => "F4074";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ALDOCO", "ALDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ALDCTO", "ALDCTO", JdeDataType.String, 4, true, true),
        new JdeField("ALKCOO", "ALKCOO", JdeDataType.String, 10, true, true),
        new JdeField("ALSFXO", "ALSFXO", JdeDataType.String, 6, true, true),
        new JdeField("ALLNID", "ALLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ALAKID", "ALAKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ALSRCFD", "ALSRCFD", JdeDataType.String, 4, true, true),
        new JdeField("ALOSEQ", "ALOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ALSUBSEQ", "ALSUBSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ALTIER", "ALTIER", JdeDataType.Numeric, null, true, true),
        new JdeField("ALASN", "ALASN", JdeDataType.String, 16),
        new JdeField("ALAST", "ALAST", JdeDataType.String, 16),
        new JdeField("ALITM", "ALITM", JdeDataType.Numeric),
        new JdeField("ALAN8", "ALAN8", JdeDataType.Numeric),
        new JdeField("ALCRCD", "ALCRCD", JdeDataType.String, 6),
        new JdeField("ALUOM", "ALUOM", JdeDataType.String, 4),
        new JdeField("ALMNQ", "ALMNQ", JdeDataType.Numeric),
        new JdeField("ALLEDG", "ALLEDG", JdeDataType.String, 4),
        new JdeField("ALFRMN", "ALFRMN", JdeDataType.String, 20),
        new JdeField("ALBSCD", "ALBSCD", JdeDataType.String, 2),
        new JdeField("ALFVTR", "ALFVTR", JdeDataType.Numeric),
        new JdeField("ALABAS", "ALABAS", JdeDataType.String, 2),
        new JdeField("ALUPRC", "ALUPRC", JdeDataType.Numeric),
        new JdeField("ALFUP", "ALFUP", JdeDataType.Numeric),
        new JdeField("ALGLC", "ALGLC", JdeDataType.String, 8),
        new JdeField("ALARSN", "ALARSN", JdeDataType.String, 6),
        new JdeField("ALACNT", "ALACNT", JdeDataType.String, 2),
        new JdeField("ALSBIF", "ALSBIF", JdeDataType.String, 2),
        new JdeField("ALMDED", "ALMDED", JdeDataType.String, 2),
        new JdeField("ALPROV", "ALPROV", JdeDataType.String, 2),
        new JdeField("ALATID", "ALATID", JdeDataType.Numeric),
        new JdeField("ALIGID", "ALIGID", JdeDataType.Numeric),
        new JdeField("ALCGID", "ALCGID", JdeDataType.Numeric),
        new JdeField("ALOGID", "ALOGID", JdeDataType.Numeric),
        new JdeField("ALANPS", "ALANPS", JdeDataType.Numeric),
        new JdeField("ALBSDVAL", "ALBSDVAL", JdeDataType.Numeric),
        new JdeField("ALSRFLAG", "ALSRFLAG", JdeDataType.String, 2),
        new JdeField("ALADJCAL", "ALADJCAL", JdeDataType.String, 160),
        new JdeField("ALNBRORD", "ALNBRORD", JdeDataType.Numeric),
        new JdeField("ALUOMVID", "ALUOMVID", JdeDataType.String, 4),
        new JdeField("ALOLVL", "ALOLVL", JdeDataType.String, 2),
        new JdeField("ALADJSTS", "ALADJSTS", JdeDataType.String, 2),
        new JdeField("ALADJREF", "ALADJREF", JdeDataType.String, 30),
        new JdeField("ALACCAN8", "ALACCAN8", JdeDataType.Numeric),
        new JdeField("ALBNAD", "ALBNAD", JdeDataType.Numeric),
        new JdeField("ALADJGRP", "ALADJGRP", JdeDataType.String, 20),
        new JdeField("ALMEADJ", "ALMEADJ", JdeDataType.String, 2),
        new JdeField("ALFVUM", "ALFVUM", JdeDataType.String, 4),
        new JdeField("ALPDCL", "ALPDCL", JdeDataType.String, 2),
        new JdeField("ALCFGID", "ALCFGID", JdeDataType.Numeric),
        new JdeField("ALCFGCID", "ALCFGCID", JdeDataType.Numeric),
        new JdeField("ALAPRP1", "ALAPRP1", JdeDataType.String, 6),
        new JdeField("ALAPRP2", "ALAPRP2", JdeDataType.String, 6),
        new JdeField("ALAPRP3", "ALAPRP3", JdeDataType.String, 6),
        new JdeField("ALAPRP4", "ALAPRP4", JdeDataType.String, 12),
        new JdeField("ALAPRP5", "ALAPRP5", JdeDataType.String, 12),
        new JdeField("ALAPRP6", "ALAPRP6", JdeDataType.String, 12),
        new JdeField("ALNDPI", "ALNDPI", JdeDataType.String, 2),
        new JdeField("ALUSER", "ALUSER", JdeDataType.String, 20),
        new JdeField("ALPID", "ALPID", JdeDataType.String, 20),
        new JdeField("ALJOBN", "ALJOBN", JdeDataType.String, 20),
        new JdeField("ALUPMJ", "ALUPMJ", JdeDataType.Numeric),
        new JdeField("ALTDAY", "ALTDAY", JdeDataType.Numeric),
        new JdeField("ALPMTN", "ALPMTN", JdeDataType.String, 24),
        new JdeField("ALRULENAME", "ALRULENAME", JdeDataType.String, 20),
        new JdeField("ALPA04", "ALPA04", JdeDataType.String, 2, true, true),
        new JdeField("ALADJQTY", "ALADJQTY", JdeDataType.String, 2),
        new JdeField("ALQTYPY", "ALQTYPY", JdeDataType.Numeric),
        new JdeField("ALSTPRCF", "ALSTPRCF", JdeDataType.String, 2),
        new JdeField("ALTSTRSNM", "ALTSTRSNM", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4074_0", "Primary Key on ALDOCO, ALDCTO, ALKCOO, ALSFXO, ALLNID, ALAKID, ALSRCFD, ALOSEQ, ALSUBSEQ, ALTIER, ALPA04", new[] { "ALDOCO", "ALDCTO", "ALKCOO", "ALSFXO", "ALLNID", "ALAKID", "ALSRCFD", "ALOSEQ", "ALSUBSEQ", "ALTIER", "ALPA04" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4074_2", "Index on ALDOCO, ALDCTO", new[] { "ALDOCO", "ALDCTO" })
    };
}
