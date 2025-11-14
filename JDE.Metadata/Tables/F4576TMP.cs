using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4576TMP - .
/// </summary>
public class F4576TMP : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACDOCO.
        /// </summary>
        public const string ACDOCO = "ACDOCO";

        /// <summary>
        /// ACDCTO.
        /// </summary>
        public const string ACDCTO = "ACDCTO";

        /// <summary>
        /// ACKCOO.
        /// </summary>
        public const string ACKCOO = "ACKCOO";

        /// <summary>
        /// ACSFXO.
        /// </summary>
        public const string ACSFXO = "ACSFXO";

        /// <summary>
        /// ACLNID.
        /// </summary>
        public const string ACLNID = "ACLNID";

        /// <summary>
        /// ACOSEQ.
        /// </summary>
        public const string ACOSEQ = "ACOSEQ";

        /// <summary>
        /// ACPA04.
        /// </summary>
        public const string ACPA04 = "ACPA04";

        /// <summary>
        /// ACAST.
        /// </summary>
        public const string ACAST = "ACAST";

        /// <summary>
        /// ACAGTY.
        /// </summary>
        public const string ACAGTY = "ACAGTY";

        /// <summary>
        /// ACANS8.
        /// </summary>
        public const string ACANS8 = "ACANS8";

        /// <summary>
        /// ACMCU.
        /// </summary>
        public const string ACMCU = "ACMCU";

        /// <summary>
        /// ACIGID.
        /// </summary>
        public const string ACIGID = "ACIGID";

        /// <summary>
        /// ACCGID.
        /// </summary>
        public const string ACCGID = "ACCGID";

        /// <summary>
        /// ACAN8.
        /// </summary>
        public const string ACAN8 = "ACAN8";

        /// <summary>
        /// ACCPGP.
        /// </summary>
        public const string ACCPGP = "ACCPGP";

        /// <summary>
        /// ACITM.
        /// </summary>
        public const string ACITM = "ACITM";

        /// <summary>
        /// ACPRGR.
        /// </summary>
        public const string ACPRGR = "ACPRGR";

        /// <summary>
        /// ACCATN.
        /// </summary>
        public const string ACCATN = "ACCATN";

        /// <summary>
        /// ACCCF3.
        /// </summary>
        public const string ACCCF3 = "ACCCF3";

        /// <summary>
        /// ACCTYE.
        /// </summary>
        public const string ACCTYE = "ACCTYE";

        /// <summary>
        /// ACCLMD.
        /// </summary>
        public const string ACCLMD = "ACCLMD";

        /// <summary>
        /// ACSCNT.
        /// </summary>
        public const string ACSCNT = "ACSCNT";

        /// <summary>
        /// ACACCS.
        /// </summary>
        public const string ACACCS = "ACACCS";

        /// <summary>
        /// ACACCA.
        /// </summary>
        public const string ACACCA = "ACACCA";

        /// <summary>
        /// ACCLAD.
        /// </summary>
        public const string ACCLAD = "ACCLAD";

        /// <summary>
        /// ACCAF.
        /// </summary>
        public const string ACCAF = "ACCAF";

        /// <summary>
        /// ACCRCD.
        /// </summary>
        public const string ACCRCD = "ACCRCD";

        /// <summary>
        /// ACBCRC.
        /// </summary>
        public const string ACBCRC = "ACBCRC";

        /// <summary>
        /// ACCLNR.
        /// </summary>
        public const string ACCLNR = "ACCLNR";

        /// <summary>
        /// ACDESC.
        /// </summary>
        public const string ACDESC = "ACDESC";

        /// <summary>
        /// ACDOC.
        /// </summary>
        public const string ACDOC = "ACDOC";

        /// <summary>
        /// ACDCT.
        /// </summary>
        public const string ACDCT = "ACDCT";

        /// <summary>
        /// ACKCO.
        /// </summary>
        public const string ACKCO = "ACKCO";

        /// <summary>
        /// ACSFX.
        /// </summary>
        public const string ACSFX = "ACSFX";

        /// <summary>
        /// ACSFXE.
        /// </summary>
        public const string ACSFXE = "ACSFXE";

        /// <summary>
        /// ACSDOC.
        /// </summary>
        public const string ACSDOC = "ACSDOC";

        /// <summary>
        /// ACSDCT.
        /// </summary>
        public const string ACSDCT = "ACSDCT";

        /// <summary>
        /// ACSKCO.
        /// </summary>
        public const string ACSKCO = "ACSKCO";

        /// <summary>
        /// ACSFX0.
        /// </summary>
        public const string ACSFX0 = "ACSFX0";

        /// <summary>
        /// ACDOCM.
        /// </summary>
        public const string ACDOCM = "ACDOCM";

        /// <summary>
        /// ACDCTM.
        /// </summary>
        public const string ACDCTM = "ACDCTM";

        /// <summary>
        /// ACSCLM.
        /// </summary>
        public const string ACSCLM = "ACSCLM";

        /// <summary>
        /// ACADDJ.
        /// </summary>
        public const string ACADDJ = "ACADDJ";

        /// <summary>
        /// ACCNFD.
        /// </summary>
        public const string ACCNFD = "ACCNFD";

        /// <summary>
        /// ACCSCD.
        /// </summary>
        public const string ACCSCD = "ACCSCD";

        /// <summary>
        /// ACDSC1.
        /// </summary>
        public const string ACDSC1 = "ACDSC1";

        /// <summary>
        /// ACRPER.
        /// </summary>
        public const string ACRPER = "ACRPER";

        /// <summary>
        /// ACUOM.
        /// </summary>
        public const string ACUOM = "ACUOM";

        /// <summary>
        /// ACSOQS.
        /// </summary>
        public const string ACSOQS = "ACSOQS";

        /// <summary>
        /// ACQYCL.
        /// </summary>
        public const string ACQYCL = "ACQYCL";

        /// <summary>
        /// ACCLRR.
        /// </summary>
        public const string ACCLRR = "ACCLRR";

        /// <summary>
        /// ACBN01.
        /// </summary>
        public const string ACBN01 = "ACBN01";

        /// <summary>
        /// ACBTY1.
        /// </summary>
        public const string ACBTY1 = "ACBTY1";

        /// <summary>
        /// ACICU.
        /// </summary>
        public const string ACICU = "ACICU";

        /// <summary>
        /// ACICUT.
        /// </summary>
        public const string ACICUT = "ACICUT";

        /// <summary>
        /// ACDE01.
        /// </summary>
        public const string ACDE01 = "ACDE01";

        /// <summary>
        /// ACDE02.
        /// </summary>
        public const string ACDE02 = "ACDE02";

        /// <summary>
        /// ACDE03.
        /// </summary>
        public const string ACDE03 = "ACDE03";

        /// <summary>
        /// ACDE04.
        /// </summary>
        public const string ACDE04 = "ACDE04";

        /// <summary>
        /// ACDE05.
        /// </summary>
        public const string ACDE05 = "ACDE05";

        /// <summary>
        /// ACURCD.
        /// </summary>
        public const string ACURCD = "ACURCD";

        /// <summary>
        /// ACURDT.
        /// </summary>
        public const string ACURDT = "ACURDT";

        /// <summary>
        /// ACURAT.
        /// </summary>
        public const string ACURAT = "ACURAT";

        /// <summary>
        /// ACURAB.
        /// </summary>
        public const string ACURAB = "ACURAB";

        /// <summary>
        /// ACURRF.
        /// </summary>
        public const string ACURRF = "ACURRF";

        /// <summary>
        /// ACUSER.
        /// </summary>
        public const string ACUSER = "ACUSER";

        /// <summary>
        /// ACPID.
        /// </summary>
        public const string ACPID = "ACPID";

        /// <summary>
        /// ACJOBN.
        /// </summary>
        public const string ACJOBN = "ACJOBN";

        /// <summary>
        /// ACUPMJ.
        /// </summary>
        public const string ACUPMJ = "ACUPMJ";

        /// <summary>
        /// ACTDAY.
        /// </summary>
        public const string ACTDAY = "ACTDAY";

        /// <summary>
        /// ACABR1.
        /// </summary>
        public const string ACABR1 = "ACABR1";

        /// <summary>
        /// ACABR2.
        /// </summary>
        public const string ACABR2 = "ACABR2";

        /// <summary>
        /// ACABR3.
        /// </summary>
        public const string ACABR3 = "ACABR3";

        /// <summary>
        /// ACABR4.
        /// </summary>
        public const string ACABR4 = "ACABR4";

        /// <summary>
        /// ACABT1.
        /// </summary>
        public const string ACABT1 = "ACABT1";

        /// <summary>
        /// ACABT2.
        /// </summary>
        public const string ACABT2 = "ACABT2";

        /// <summary>
        /// ACABT3.
        /// </summary>
        public const string ACABT3 = "ACABT3";

        /// <summary>
        /// ACABT4.
        /// </summary>
        public const string ACABT4 = "ACABT4";

        /// <summary>
        /// ACUM.
        /// </summary>
        public const string ACUM = "ACUM";

        /// <summary>
        /// ACSBL.
        /// </summary>
        public const string ACSBL = "ACSBL";

        /// <summary>
        /// ACSBLT.
        /// </summary>
        public const string ACSBLT = "ACSBLT";

        /// <summary>
        /// ACANI.
        /// </summary>
        public const string ACANI = "ACANI";

        /// <summary>
        /// ACDAMD.
        /// </summary>
        public const string ACDAMD = "ACDAMD";

        /// <summary>
        /// ACDAMF.
        /// </summary>
        public const string ACDAMF = "ACDAMF";

        /// <summary>
        /// ACEMCU.
        /// </summary>
        public const string ACEMCU = "ACEMCU";

        /// <summary>
        /// ACCO.
        /// </summary>
        public const string ACCO = "ACCO";

        /// <summary>
        /// ACFLIT.
        /// </summary>
        public const string ACFLIT = "ACFLIT";

        /// <summary>
        /// ACSLSP.
        /// </summary>
        public const string ACSLSP = "ACSLSP";
    }

    /// <inheritdoc />
    public override string TableName => "F4576TMP";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACDOCO", "ACDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ACDCTO", "ACDCTO", JdeDataType.String, 4, true, true),
        new JdeField("ACKCOO", "ACKCOO", JdeDataType.String, 10, true, true),
        new JdeField("ACSFXO", "ACSFXO", JdeDataType.String, 6, true, true),
        new JdeField("ACLNID", "ACLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ACOSEQ", "ACOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ACPA04", "ACPA04", JdeDataType.String, 2),
        new JdeField("ACAST", "ACAST", JdeDataType.String, 16),
        new JdeField("ACAGTY", "ACAGTY", JdeDataType.String, 4),
        new JdeField("ACANS8", "ACANS8", JdeDataType.Numeric),
        new JdeField("ACMCU", "ACMCU", JdeDataType.String, 24),
        new JdeField("ACIGID", "ACIGID", JdeDataType.Numeric),
        new JdeField("ACCGID", "ACCGID", JdeDataType.Numeric),
        new JdeField("ACAN8", "ACAN8", JdeDataType.Numeric),
        new JdeField("ACCPGP", "ACCPGP", JdeDataType.String, 16),
        new JdeField("ACITM", "ACITM", JdeDataType.Numeric),
        new JdeField("ACPRGR", "ACPRGR", JdeDataType.String, 16),
        new JdeField("ACCATN", "ACCATN", JdeDataType.String, 16),
        new JdeField("ACCCF3", "ACCCF3", JdeDataType.String, 6),
        new JdeField("ACCTYE", "ACCTYE", JdeDataType.String, 4),
        new JdeField("ACCLMD", "ACCLMD", JdeDataType.String, 2),
        new JdeField("ACSCNT", "ACSCNT", JdeDataType.String, 4),
        new JdeField("ACACCS", "ACACCS", JdeDataType.String, 58),
        new JdeField("ACACCA", "ACACCA", JdeDataType.String, 58),
        new JdeField("ACCLAD", "ACCLAD", JdeDataType.Numeric),
        new JdeField("ACCAF", "ACCAF", JdeDataType.Numeric),
        new JdeField("ACCRCD", "ACCRCD", JdeDataType.String, 6),
        new JdeField("ACBCRC", "ACBCRC", JdeDataType.String, 6),
        new JdeField("ACCLNR", "ACCLNR", JdeDataType.Numeric),
        new JdeField("ACDESC", "ACDESC", JdeDataType.String, 60),
        new JdeField("ACDOC", "ACDOC", JdeDataType.Numeric),
        new JdeField("ACDCT", "ACDCT", JdeDataType.String, 4),
        new JdeField("ACKCO", "ACKCO", JdeDataType.String, 10),
        new JdeField("ACSFX", "ACSFX", JdeDataType.String, 6),
        new JdeField("ACSFXE", "ACSFXE", JdeDataType.Numeric),
        new JdeField("ACSDOC", "ACSDOC", JdeDataType.Numeric),
        new JdeField("ACSDCT", "ACSDCT", JdeDataType.String, 4),
        new JdeField("ACSKCO", "ACSKCO", JdeDataType.String, 10),
        new JdeField("ACSFX0", "ACSFX0", JdeDataType.String, 6),
        new JdeField("ACDOCM", "ACDOCM", JdeDataType.Numeric),
        new JdeField("ACDCTM", "ACDCTM", JdeDataType.String, 4),
        new JdeField("ACSCLM", "ACSCLM", JdeDataType.Numeric),
        new JdeField("ACADDJ", "ACADDJ", JdeDataType.Numeric),
        new JdeField("ACCNFD", "ACCNFD", JdeDataType.Numeric),
        new JdeField("ACCSCD", "ACCSCD", JdeDataType.Numeric),
        new JdeField("ACDSC1", "ACDSC1", JdeDataType.String, 60),
        new JdeField("ACRPER", "ACRPER", JdeDataType.Numeric),
        new JdeField("ACUOM", "ACUOM", JdeDataType.String, 4),
        new JdeField("ACSOQS", "ACSOQS", JdeDataType.Numeric),
        new JdeField("ACQYCL", "ACQYCL", JdeDataType.Numeric),
        new JdeField("ACCLRR", "ACCLRR", JdeDataType.String, 4),
        new JdeField("ACBN01", "ACBN01", JdeDataType.Numeric),
        new JdeField("ACBTY1", "ACBTY1", JdeDataType.String, 4),
        new JdeField("ACICU", "ACICU", JdeDataType.Numeric),
        new JdeField("ACICUT", "ACICUT", JdeDataType.String, 4),
        new JdeField("ACDE01", "ACDE01", JdeDataType.String, 6),
        new JdeField("ACDE02", "ACDE02", JdeDataType.String, 6),
        new JdeField("ACDE03", "ACDE03", JdeDataType.String, 6),
        new JdeField("ACDE04", "ACDE04", JdeDataType.String, 6),
        new JdeField("ACDE05", "ACDE05", JdeDataType.String, 6),
        new JdeField("ACURCD", "ACURCD", JdeDataType.String, 4),
        new JdeField("ACURDT", "ACURDT", JdeDataType.Numeric),
        new JdeField("ACURAT", "ACURAT", JdeDataType.Numeric),
        new JdeField("ACURAB", "ACURAB", JdeDataType.Numeric),
        new JdeField("ACURRF", "ACURRF", JdeDataType.String, 30),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACPID", "ACPID", JdeDataType.String, 20),
        new JdeField("ACJOBN", "ACJOBN", JdeDataType.String, 20),
        new JdeField("ACUPMJ", "ACUPMJ", JdeDataType.Numeric),
        new JdeField("ACTDAY", "ACTDAY", JdeDataType.Numeric),
        new JdeField("ACABR1", "ACABR1", JdeDataType.String, 24),
        new JdeField("ACABR2", "ACABR2", JdeDataType.String, 24),
        new JdeField("ACABR3", "ACABR3", JdeDataType.String, 24),
        new JdeField("ACABR4", "ACABR4", JdeDataType.String, 24),
        new JdeField("ACABT1", "ACABT1", JdeDataType.String, 2),
        new JdeField("ACABT2", "ACABT2", JdeDataType.String, 2),
        new JdeField("ACABT3", "ACABT3", JdeDataType.String, 2),
        new JdeField("ACABT4", "ACABT4", JdeDataType.String, 2),
        new JdeField("ACUM", "ACUM", JdeDataType.String, 4),
        new JdeField("ACSBL", "ACSBL", JdeDataType.String, 16),
        new JdeField("ACSBLT", "ACSBLT", JdeDataType.String, 2),
        new JdeField("ACANI", "ACANI", JdeDataType.String, 58),
        new JdeField("ACDAMD", "ACDAMD", JdeDataType.Numeric),
        new JdeField("ACDAMF", "ACDAMF", JdeDataType.Numeric),
        new JdeField("ACEMCU", "ACEMCU", JdeDataType.String, 24),
        new JdeField("ACCO", "ACCO", JdeDataType.String, 10),
        new JdeField("ACFLIT", "ACFLIT", JdeDataType.Numeric),
        new JdeField("ACSLSP", "ACSLSP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4576TMP_0", "Primary Key on ACDOCO, ACDCTO, ACKCOO, ACSFXO, ACLNID, ACOSEQ", new[] { "ACDOCO", "ACDCTO", "ACKCOO", "ACSFXO", "ACLNID", "ACOSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
