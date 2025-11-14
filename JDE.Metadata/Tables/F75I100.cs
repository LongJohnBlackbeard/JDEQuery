using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I100 - .
/// </summary>
public class F75I100 : JdeTable
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
        /// QBI75CEAM.
        /// </summary>
        public const string QBI75CEAM = "QBI75CEAM";

        /// <summary>
        /// QBYERT.
        /// </summary>
        public const string QBYERT = "QBYERT";

        /// <summary>
        /// QBYTYP.
        /// </summary>
        public const string QBYTYP = "QBYTYP";

        /// <summary>
        /// QBI75WCTY.
        /// </summary>
        public const string QBI75WCTY = "QBI75WCTY";

        /// <summary>
        /// QBI75TDSR.
        /// </summary>
        public const string QBI75TDSR = "QBI75TDSR";

        /// <summary>
        /// QBI75TSUR.
        /// </summary>
        public const string QBI75TSUR = "QBI75TSUR";

        /// <summary>
        /// QBI75CERA.
        /// </summary>
        public const string QBI75CERA = "QBI75CERA";

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
        /// QBI75CENO.
        /// </summary>
        public const string QBI75CENO = "QBI75CENO";

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
        /// QBI75PRSU.
        /// </summary>
        public const string QBI75PRSU = "QBI75PRSU";

        /// <summary>
        /// QBI75PRTD.
        /// </summary>
        public const string QBI75PRTD = "QBI75PRTD";

        /// <summary>
        /// QBI75NGLN.
        /// </summary>
        public const string QBI75NGLN = "QBI75NGLN";

        /// <summary>
        /// QBIRSO.
        /// </summary>
        public const string QBIRSO = "QBIRSO";

        /// <summary>
        /// QBI75CHDN.
        /// </summary>
        public const string QBI75CHDN = "QBI75CHDN";

        /// <summary>
        /// QBATTL.
        /// </summary>
        public const string QBATTL = "QBATTL";

        /// <summary>
        /// QBI75CHNO.
        /// </summary>
        public const string QBI75CHNO = "QBI75CHNO";

        /// <summary>
        /// QBI75CHDT.
        /// </summary>
        public const string QBI75CHDT = "QBI75CHDT";

        /// <summary>
        /// QBI75BKBC.
        /// </summary>
        public const string QBI75BKBC = "QBI75BKBC";

        /// <summary>
        /// QBI75BKNM.
        /// </summary>
        public const string QBI75BKNM = "QBI75BKNM";

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
        /// QBYR.
        /// </summary>
        public const string QBYR = "QBYR";

        /// <summary>
        /// QBCTRY.
        /// </summary>
        public const string QBCTRY = "QBCTRY";

        /// <summary>
        /// QBI75CEPR.
        /// </summary>
        public const string QBI75CEPR = "QBI75CEPR";

        /// <summary>
        /// QBI75MOYR.
        /// </summary>
        public const string QBI75MOYR = "QBI75MOYR";

        /// <summary>
        /// QBSFXO.
        /// </summary>
        public const string QBSFXO = "QBSFXO";

        /// <summary>
        /// QBI75ORST.
        /// </summary>
        public const string QBI75ORST = "QBI75ORST";

        /// <summary>
        /// QBI75INOT.
        /// </summary>
        public const string QBI75INOT = "QBI75INOT";

        /// <summary>
        /// QBI75THIN.
        /// </summary>
        public const string QBI75THIN = "QBI75THIN";

        /// <summary>
        /// QBI75NTOR.
        /// </summary>
        public const string QBI75NTOR = "QBI75NTOR";
    }

    /// <inheritdoc />
    public override string TableName => "F75I100";

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
        new JdeField("QBAG", "QBAG", JdeDataType.Numeric),
        new JdeField("QBAA", "QBAA", JdeDataType.Numeric),
        new JdeField("QBYTXB", "QBYTXB", JdeDataType.Numeric),
        new JdeField("QBYTXS", "QBYTXS", JdeDataType.Numeric),
        new JdeField("QBI75CEAM", "QBI75CEAM", JdeDataType.Numeric),
        new JdeField("QBYERT", "QBYERT", JdeDataType.Numeric),
        new JdeField("QBYTYP", "QBYTYP", JdeDataType.String, 2),
        new JdeField("QBI75WCTY", "QBI75WCTY", JdeDataType.String, 2),
        new JdeField("QBI75TDSR", "QBI75TDSR", JdeDataType.Numeric),
        new JdeField("QBI75TSUR", "QBI75TSUR", JdeDataType.Numeric),
        new JdeField("QBI75CERA", "QBI75CERA", JdeDataType.Numeric),
        new JdeField("QBYGRP", "QBYGRP", JdeDataType.String, 2),
        new JdeField("QBADT", "QBADT", JdeDataType.Numeric),
        new JdeField("QBADTJ", "QBADTJ", JdeDataType.Numeric),
        new JdeField("QBCPDT", "QBCPDT", JdeDataType.Numeric),
        new JdeField("QBBAN8", "QBBAN8", JdeDataType.Numeric),
        new JdeField("QBI75CENO", "QBI75CENO", JdeDataType.Numeric),
        new JdeField("QBYGCA", "QBYGCA", JdeDataType.Numeric),
        new JdeField("QBYSNM", "QBYSNM", JdeDataType.String, 80),
        new JdeField("QBYAOC", "QBYAOC", JdeDataType.String, 80),
        new JdeField("QBYDSD", "QBYDSD", JdeDataType.Numeric),
        new JdeField("QBYDFD", "QBYDFD", JdeDataType.Numeric),
        new JdeField("QBYJIF", "QBYJIF", JdeDataType.String, 2),
        new JdeField("QBI75PRSU", "QBI75PRSU", JdeDataType.String, 2),
        new JdeField("QBI75PRTD", "QBI75PRTD", JdeDataType.String, 2),
        new JdeField("QBI75NGLN", "QBI75NGLN", JdeDataType.String, 2),
        new JdeField("QBIRSO", "QBIRSO", JdeDataType.Numeric),
        new JdeField("QBI75CHDN", "QBI75CHDN", JdeDataType.String, 30),
        new JdeField("QBATTL", "QBATTL", JdeDataType.String, 80),
        new JdeField("QBI75CHNO", "QBI75CHNO", JdeDataType.String, 120),
        new JdeField("QBI75CHDT", "QBI75CHDT", JdeDataType.Numeric),
        new JdeField("QBI75BKBC", "QBI75BKBC", JdeDataType.Numeric),
        new JdeField("QBI75BKNM", "QBI75BKNM", JdeDataType.String, 60),
        new JdeField("QBUSER", "QBUSER", JdeDataType.String, 20),
        new JdeField("QBPID", "QBPID", JdeDataType.String, 20),
        new JdeField("QBJOBN", "QBJOBN", JdeDataType.String, 20),
        new JdeField("QBUPMJ", "QBUPMJ", JdeDataType.Numeric),
        new JdeField("QBUPMT", "QBUPMT", JdeDataType.Numeric),
        new JdeField("QBTORG", "QBTORG", JdeDataType.String, 20),
        new JdeField("QBYR", "QBYR", JdeDataType.Numeric),
        new JdeField("QBCTRY", "QBCTRY", JdeDataType.Numeric),
        new JdeField("QBI75CEPR", "QBI75CEPR", JdeDataType.String, 2),
        new JdeField("QBI75MOYR", "QBI75MOYR", JdeDataType.String, 2),
        new JdeField("QBSFXO", "QBSFXO", JdeDataType.String, 6),
        new JdeField("QBI75ORST", "QBI75ORST", JdeDataType.String, 6),
        new JdeField("QBI75INOT", "QBI75INOT", JdeDataType.Numeric),
        new JdeField("QBI75THIN", "QBI75THIN", JdeDataType.Numeric),
        new JdeField("QBI75NTOR", "QBI75NTOR", JdeDataType.String, 100)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I100_0", "Primary Key on QBCO, QBKCO, QBDCT, QBDOC, QBSFX", new[] { "QBCO", "QBKCO", "QBDCT", "QBDOC", "QBSFX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I100_12", "Index on QBCO, QBKCO, QBYGRP, QBTAXC, QBAN8", new[] { "QBCO", "QBKCO", "QBYGRP", "QBTAXC", "QBAN8" }),
        new JdeIndex("F75I100_13", "Index on QBKCO, QBDCT, QBDOC", new[] { "QBKCO", "QBDCT", "QBDOC" }),
        new JdeIndex("F75I100_2", "Index on QBCO, QBKCO, QBAN8, QBYGRP", new[] { "QBCO", "QBKCO", "QBAN8", "QBYGRP" }),
        new JdeIndex("F75I100_3", "Index on QBCO, QBKCO, QBYGRP, QBDOC, QBDCT", new[] { "QBCO", "QBKCO", "QBYGRP", "QBDOC", "QBDCT" }),
        new JdeIndex("F75I100_4", "Index on QBCO, QBKCO, QBYGRP, QBI75PRTD", new[] { "QBCO", "QBKCO", "QBYGRP", "QBI75PRTD" }),
        new JdeIndex("F75I100_5", "Index on QBCO, QBKCO, QBYGRP, QBAN8", new[] { "QBCO", "QBKCO", "QBYGRP", "QBAN8" }),
        new JdeIndex("F75I100_6", "Index on QBCO, QBKCO, QBYGRP, QBI75CENO", new[] { "QBCO", "QBKCO", "QBYGRP", "QBI75CENO" })
    };
}
