using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I101 - .
/// </summary>
public class F75I101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QBCO.
        /// </summary>
        public const string QBCO = "QBCO";

        /// <summary>
        /// QBDCT.
        /// </summary>
        public const string QBDCT = "QBDCT";

        /// <summary>
        /// QBKCO.
        /// </summary>
        public const string QBKCO = "QBKCO";

        /// <summary>
        /// QBDOC.
        /// </summary>
        public const string QBDOC = "QBDOC";

        /// <summary>
        /// QBSFX.
        /// </summary>
        public const string QBSFX = "QBSFX";

        /// <summary>
        /// QBAN8.
        /// </summary>
        public const string QBAN8 = "QBAN8";

        /// <summary>
        /// QBTAXC.
        /// </summary>
        public const string QBTAXC = "QBTAXC";

        /// <summary>
        /// QBPYE.
        /// </summary>
        public const string QBPYE = "QBPYE";

        /// <summary>
        /// QBDGJ.
        /// </summary>
        public const string QBDGJ = "QBDGJ";

        /// <summary>
        /// QBVINV.
        /// </summary>
        public const string QBVINV = "QBVINV";

        /// <summary>
        /// QBI75ORST.
        /// </summary>
        public const string QBI75ORST = "QBI75ORST";

        /// <summary>
        /// QBAG.
        /// </summary>
        public const string QBAG = "QBAG";

        /// <summary>
        /// QBAA.
        /// </summary>
        public const string QBAA = "QBAA";

        /// <summary>
        /// QBYTXB.
        /// </summary>
        public const string QBYTXB = "QBYTXB";

        /// <summary>
        /// QBYTXS.
        /// </summary>
        public const string QBYTXS = "QBYTXS";

        /// <summary>
        /// QBYTYP.
        /// </summary>
        public const string QBYTYP = "QBYTYP";

        /// <summary>
        /// QBI75WCTY.
        /// </summary>
        public const string QBI75WCTY = "QBI75WCTY";

        /// <summary>
        /// QBYERT.
        /// </summary>
        public const string QBYERT = "QBYERT";

        /// <summary>
        /// QBI75TDSR.
        /// </summary>
        public const string QBI75TDSR = "QBI75TDSR";

        /// <summary>
        /// QBI75TSUR.
        /// </summary>
        public const string QBI75TSUR = "QBI75TSUR";

        /// <summary>
        /// QBYGRP.
        /// </summary>
        public const string QBYGRP = "QBYGRP";

        /// <summary>
        /// QBADT.
        /// </summary>
        public const string QBADT = "QBADT";

        /// <summary>
        /// QBADTJ.
        /// </summary>
        public const string QBADTJ = "QBADTJ";

        /// <summary>
        /// QBCPDT.
        /// </summary>
        public const string QBCPDT = "QBCPDT";

        /// <summary>
        /// QBBAN8.
        /// </summary>
        public const string QBBAN8 = "QBBAN8";

        /// <summary>
        /// QBYGCA.
        /// </summary>
        public const string QBYGCA = "QBYGCA";

        /// <summary>
        /// QBYSNM.
        /// </summary>
        public const string QBYSNM = "QBYSNM";

        /// <summary>
        /// QBYAOC.
        /// </summary>
        public const string QBYAOC = "QBYAOC";

        /// <summary>
        /// QBYDSD.
        /// </summary>
        public const string QBYDSD = "QBYDSD";

        /// <summary>
        /// QBYDFD.
        /// </summary>
        public const string QBYDFD = "QBYDFD";

        /// <summary>
        /// QBYJIF.
        /// </summary>
        public const string QBYJIF = "QBYJIF";

        /// <summary>
        /// QBIRSO.
        /// </summary>
        public const string QBIRSO = "QBIRSO";

        /// <summary>
        /// QBFADT.
        /// </summary>
        public const string QBFADT = "QBFADT";

        /// <summary>
        /// QBATTL.
        /// </summary>
        public const string QBATTL = "QBATTL";

        /// <summary>
        /// QBUSER.
        /// </summary>
        public const string QBUSER = "QBUSER";

        /// <summary>
        /// QBPID.
        /// </summary>
        public const string QBPID = "QBPID";

        /// <summary>
        /// QBJOBN.
        /// </summary>
        public const string QBJOBN = "QBJOBN";

        /// <summary>
        /// QBUPMJ.
        /// </summary>
        public const string QBUPMJ = "QBUPMJ";

        /// <summary>
        /// QBUPMT.
        /// </summary>
        public const string QBUPMT = "QBUPMT";

        /// <summary>
        /// QBTORG.
        /// </summary>
        public const string QBTORG = "QBTORG";

        /// <summary>
        /// QBCHGF.
        /// </summary>
        public const string QBCHGF = "QBCHGF";

        /// <summary>
        /// QBI75CERA.
        /// </summary>
        public const string QBI75CERA = "QBI75CERA";

        /// <summary>
        /// QBI75CEAM.
        /// </summary>
        public const string QBI75CEAM = "QBI75CEAM";

        /// <summary>
        /// QBI75PRSU.
        /// </summary>
        public const string QBI75PRSU = "QBI75PRSU";

        /// <summary>
        /// QBAPAOW.
        /// </summary>
        public const string QBAPAOW = "QBAPAOW";

        /// <summary>
        /// QBCKCS.
        /// </summary>
        public const string QBCKCS = "QBCKCS";

        /// <summary>
        /// QBAAMF.
        /// </summary>
        public const string QBAAMF = "QBAAMF";

        /// <summary>
        /// QBSFXE.
        /// </summary>
        public const string QBSFXE = "QBSFXE";

        /// <summary>
        /// QBPST.
        /// </summary>
        public const string QBPST = "QBPST";

        /// <summary>
        /// QBPYST.
        /// </summary>
        public const string QBPYST = "QBPYST";

        /// <summary>
        /// QBGLC.
        /// </summary>
        public const string QBGLC = "QBGLC";

        /// <summary>
        /// QBTAWH.
        /// </summary>
        public const string QBTAWH = "QBTAWH";

        /// <summary>
        /// QBSFXM.
        /// </summary>
        public const string QBSFXM = "QBSFXM";

        /// <summary>
        /// QBSFXO.
        /// </summary>
        public const string QBSFXO = "QBSFXO";

        /// <summary>
        /// QBACR.
        /// </summary>
        public const string QBACR = "QBACR";

        /// <summary>
        /// QBACRF.
        /// </summary>
        public const string QBACRF = "QBACRF";

        /// <summary>
        /// QBDDJ.
        /// </summary>
        public const string QBDDJ = "QBDDJ";

        /// <summary>
        /// QBFY.
        /// </summary>
        public const string QBFY = "QBFY";

        /// <summary>
        /// QBCTRY.
        /// </summary>
        public const string QBCTRY = "QBCTRY";

        /// <summary>
        /// QBI75CHNO.
        /// </summary>
        public const string QBI75CHNO = "QBI75CHNO";

        /// <summary>
        /// QBI75CHDT.
        /// </summary>
        public const string QBI75CHDT = "QBI75CHDT";

        /// <summary>
        /// QBI75CENO.
        /// </summary>
        public const string QBI75CENO = "QBI75CENO";

        /// <summary>
        /// QBI75PRTD.
        /// </summary>
        public const string QBI75PRTD = "QBI75PRTD";
    }

    /// <inheritdoc />
    public override string TableName => "F75I101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QBCO", "QBCO", JdeDataType.String, 10, true, true),
        new JdeField("QBDCT", "QBDCT", JdeDataType.String, 4, true, true),
        new JdeField("QBKCO", "QBKCO", JdeDataType.String, 10, true, true),
        new JdeField("QBDOC", "QBDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("QBSFX", "QBSFX", JdeDataType.String, 6, true, true),
        new JdeField("QBAN8", "QBAN8", JdeDataType.Numeric),
        new JdeField("QBTAXC", "QBTAXC", JdeDataType.String, 2),
        new JdeField("QBPYE", "QBPYE", JdeDataType.Numeric),
        new JdeField("QBDGJ", "QBDGJ", JdeDataType.Numeric),
        new JdeField("QBVINV", "QBVINV", JdeDataType.String, 50),
        new JdeField("QBI75ORST", "QBI75ORST", JdeDataType.String, 6),
        new JdeField("QBAG", "QBAG", JdeDataType.Numeric),
        new JdeField("QBAA", "QBAA", JdeDataType.Numeric),
        new JdeField("QBYTXB", "QBYTXB", JdeDataType.Numeric),
        new JdeField("QBYTXS", "QBYTXS", JdeDataType.Numeric),
        new JdeField("QBYTYP", "QBYTYP", JdeDataType.String, 2),
        new JdeField("QBI75WCTY", "QBI75WCTY", JdeDataType.String, 2),
        new JdeField("QBYERT", "QBYERT", JdeDataType.Numeric),
        new JdeField("QBI75TDSR", "QBI75TDSR", JdeDataType.Numeric),
        new JdeField("QBI75TSUR", "QBI75TSUR", JdeDataType.Numeric),
        new JdeField("QBYGRP", "QBYGRP", JdeDataType.String, 2),
        new JdeField("QBADT", "QBADT", JdeDataType.Numeric),
        new JdeField("QBADTJ", "QBADTJ", JdeDataType.Numeric),
        new JdeField("QBCPDT", "QBCPDT", JdeDataType.Numeric),
        new JdeField("QBBAN8", "QBBAN8", JdeDataType.Numeric),
        new JdeField("QBYGCA", "QBYGCA", JdeDataType.Numeric),
        new JdeField("QBYSNM", "QBYSNM", JdeDataType.String, 80),
        new JdeField("QBYAOC", "QBYAOC", JdeDataType.String, 80),
        new JdeField("QBYDSD", "QBYDSD", JdeDataType.Numeric),
        new JdeField("QBYDFD", "QBYDFD", JdeDataType.Numeric),
        new JdeField("QBYJIF", "QBYJIF", JdeDataType.String, 2),
        new JdeField("QBIRSO", "QBIRSO", JdeDataType.Numeric),
        new JdeField("QBFADT", "QBFADT", JdeDataType.Numeric),
        new JdeField("QBATTL", "QBATTL", JdeDataType.String, 80),
        new JdeField("QBUSER", "QBUSER", JdeDataType.String, 20),
        new JdeField("QBPID", "QBPID", JdeDataType.String, 20),
        new JdeField("QBJOBN", "QBJOBN", JdeDataType.String, 20),
        new JdeField("QBUPMJ", "QBUPMJ", JdeDataType.Numeric),
        new JdeField("QBUPMT", "QBUPMT", JdeDataType.Numeric),
        new JdeField("QBTORG", "QBTORG", JdeDataType.String, 20),
        new JdeField("QBCHGF", "QBCHGF", JdeDataType.String, 2),
        new JdeField("QBI75CERA", "QBI75CERA", JdeDataType.Numeric),
        new JdeField("QBI75CEAM", "QBI75CEAM", JdeDataType.Numeric),
        new JdeField("QBI75PRSU", "QBI75PRSU", JdeDataType.String, 2),
        new JdeField("QBAPAOW", "QBAPAOW", JdeDataType.String, 30),
        new JdeField("QBCKCS", "QBCKCS", JdeDataType.String, 30),
        new JdeField("QBAAMF", "QBAAMF", JdeDataType.String, 2),
        new JdeField("QBSFXE", "QBSFXE", JdeDataType.Numeric),
        new JdeField("QBPST", "QBPST", JdeDataType.String, 2),
        new JdeField("QBPYST", "QBPYST", JdeDataType.String, 2),
        new JdeField("QBGLC", "QBGLC", JdeDataType.String, 8),
        new JdeField("QBTAWH", "QBTAWH", JdeDataType.Numeric),
        new JdeField("QBSFXM", "QBSFXM", JdeDataType.String, 6),
        new JdeField("QBSFXO", "QBSFXO", JdeDataType.String, 6),
        new JdeField("QBACR", "QBACR", JdeDataType.Numeric),
        new JdeField("QBACRF", "QBACRF", JdeDataType.Numeric),
        new JdeField("QBDDJ", "QBDDJ", JdeDataType.Numeric),
        new JdeField("QBFY", "QBFY", JdeDataType.Numeric),
        new JdeField("QBCTRY", "QBCTRY", JdeDataType.Numeric),
        new JdeField("QBI75CHNO", "QBI75CHNO", JdeDataType.String, 120),
        new JdeField("QBI75CHDT", "QBI75CHDT", JdeDataType.Numeric),
        new JdeField("QBI75CENO", "QBI75CENO", JdeDataType.Numeric),
        new JdeField("QBI75PRTD", "QBI75PRTD", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I101_0", "Primary Key on QBCO, QBDCT, QBKCO, QBDOC, QBSFX", new[] { "QBCO", "QBDCT", "QBKCO", "QBDOC", "QBSFX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I101_2", "Index on QBAN8, QBYTYP, QBFY, QBCTRY, QBI75WCTY", new[] { "QBAN8", "QBYTYP", "QBFY", "QBCTRY", "QBI75WCTY" }),
        new JdeIndex("F75I101_3", "Index on QBKCO, QBDCT, QBDOC", new[] { "QBKCO", "QBDCT", "QBDOC" })
    };
}
