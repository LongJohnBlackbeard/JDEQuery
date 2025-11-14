using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4100 - .
/// </summary>
public class F4100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LMMCU.
        /// </summary>
        public const string LMMCU = "LMMCU";

        /// <summary>
        /// LMLOCN.
        /// </summary>
        public const string LMLOCN = "LMLOCN";

        /// <summary>
        /// LMAISL.
        /// </summary>
        public const string LMAISL = "LMAISL";

        /// <summary>
        /// LMBIN.
        /// </summary>
        public const string LMBIN = "LMBIN";

        /// <summary>
        /// LMLA03.
        /// </summary>
        public const string LMLA03 = "LMLA03";

        /// <summary>
        /// LMLA04.
        /// </summary>
        public const string LMLA04 = "LMLA04";

        /// <summary>
        /// LMLA05.
        /// </summary>
        public const string LMLA05 = "LMLA05";

        /// <summary>
        /// LMLA06.
        /// </summary>
        public const string LMLA06 = "LMLA06";

        /// <summary>
        /// LMLA07.
        /// </summary>
        public const string LMLA07 = "LMLA07";

        /// <summary>
        /// LMLA08.
        /// </summary>
        public const string LMLA08 = "LMLA08";

        /// <summary>
        /// LMLA09.
        /// </summary>
        public const string LMLA09 = "LMLA09";

        /// <summary>
        /// LMLA10.
        /// </summary>
        public const string LMLA10 = "LMLA10";

        /// <summary>
        /// LMLLDL.
        /// </summary>
        public const string LMLLDL = "LMLLDL";

        /// <summary>
        /// LMSTY1.
        /// </summary>
        public const string LMSTY1 = "LMSTY1";

        /// <summary>
        /// LMCGRP.
        /// </summary>
        public const string LMCGRP = "LMCGRP";

        /// <summary>
        /// LMLHLD.
        /// </summary>
        public const string LMLHLD = "LMLHLD";

        /// <summary>
        /// LMFREZ.
        /// </summary>
        public const string LMFREZ = "LMFREZ";

        /// <summary>
        /// LMNETA.
        /// </summary>
        public const string LMNETA = "LMNETA";

        /// <summary>
        /// LMMNUP.
        /// </summary>
        public const string LMMNUP = "LMMNUP";

        /// <summary>
        /// LMMNUK.
        /// </summary>
        public const string LMMNUK = "LMMNUK";

        /// <summary>
        /// LMLCOD.
        /// </summary>
        public const string LMLCOD = "LMLCOD";

        /// <summary>
        /// LMMMTH.
        /// </summary>
        public const string LMMMTH = "LMMMTH";

        /// <summary>
        /// LMEQTY.
        /// </summary>
        public const string LMEQTY = "LMEQTY";

        /// <summary>
        /// LMCTNF.
        /// </summary>
        public const string LMCTNF = "LMCTNF";

        /// <summary>
        /// LMMCNT.
        /// </summary>
        public const string LMMCNT = "LMMCNT";

        /// <summary>
        /// LMMLOT.
        /// </summary>
        public const string LMMLOT = "LMMLOT";

        /// <summary>
        /// LMMITM.
        /// </summary>
        public const string LMMITM = "LMMITM";

        /// <summary>
        /// LMSTAG.
        /// </summary>
        public const string LMSTAG = "LMSTAG";

        /// <summary>
        /// LMLVER.
        /// </summary>
        public const string LMLVER = "LMLVER";

        /// <summary>
        /// LMPCNF.
        /// </summary>
        public const string LMPCNF = "LMPCNF";

        /// <summary>
        /// LMKCNF.
        /// </summary>
        public const string LMKCNF = "LMKCNF";

        /// <summary>
        /// LMAPUT.
        /// </summary>
        public const string LMAPUT = "LMAPUT";

        /// <summary>
        /// LMAPIK.
        /// </summary>
        public const string LMAPIK = "LMAPIK";

        /// <summary>
        /// LMARPL.
        /// </summary>
        public const string LMARPL = "LMARPL";

        /// <summary>
        /// LMPZON.
        /// </summary>
        public const string LMPZON = "LMPZON";

        /// <summary>
        /// LMKZON.
        /// </summary>
        public const string LMKZON = "LMKZON";

        /// <summary>
        /// LMZONR.
        /// </summary>
        public const string LMZONR = "LMZONR";

        /// <summary>
        /// LMSTGP.
        /// </summary>
        public const string LMSTGP = "LMSTGP";

        /// <summary>
        /// LMSTGK.
        /// </summary>
        public const string LMSTGK = "LMSTGK";

        /// <summary>
        /// LMSTGR.
        /// </summary>
        public const string LMSTGR = "LMSTGR";

        /// <summary>
        /// LMWSQP.
        /// </summary>
        public const string LMWSQP = "LMWSQP";

        /// <summary>
        /// LMWSQQ.
        /// </summary>
        public const string LMWSQQ = "LMWSQQ";

        /// <summary>
        /// LMWSQR.
        /// </summary>
        public const string LMWSQR = "LMWSQR";

        /// <summary>
        /// LMDISX.
        /// </summary>
        public const string LMDISX = "LMDISX";

        /// <summary>
        /// LMDISY.
        /// </summary>
        public const string LMDISY = "LMDISY";

        /// <summary>
        /// LMDISZ.
        /// </summary>
        public const string LMDISZ = "LMDISZ";

        /// <summary>
        /// LMEQTP.
        /// </summary>
        public const string LMEQTP = "LMEQTP";

        /// <summary>
        /// LMURCD.
        /// </summary>
        public const string LMURCD = "LMURCD";

        /// <summary>
        /// LMURDT.
        /// </summary>
        public const string LMURDT = "LMURDT";

        /// <summary>
        /// LMURAT.
        /// </summary>
        public const string LMURAT = "LMURAT";

        /// <summary>
        /// LMURAB.
        /// </summary>
        public const string LMURAB = "LMURAB";

        /// <summary>
        /// LMURRF.
        /// </summary>
        public const string LMURRF = "LMURRF";

        /// <summary>
        /// LMOT1Y.
        /// </summary>
        public const string LMOT1Y = "LMOT1Y";

        /// <summary>
        /// LMOT2Y.
        /// </summary>
        public const string LMOT2Y = "LMOT2Y";

        /// <summary>
        /// LMUSER.
        /// </summary>
        public const string LMUSER = "LMUSER";

        /// <summary>
        /// LMPID.
        /// </summary>
        public const string LMPID = "LMPID";

        /// <summary>
        /// LMJOBN.
        /// </summary>
        public const string LMJOBN = "LMJOBN";

        /// <summary>
        /// LMUPMJ.
        /// </summary>
        public const string LMUPMJ = "LMUPMJ";

        /// <summary>
        /// LMTDAY.
        /// </summary>
        public const string LMTDAY = "LMTDAY";

        /// <summary>
        /// LMMIXL.
        /// </summary>
        public const string LMMIXL = "LMMIXL";

        /// <summary>
        /// LMMPTL.
        /// </summary>
        public const string LMMPTL = "LMMPTL";

        /// <summary>
        /// LMMUMS.
        /// </summary>
        public const string LMMUMS = "LMMUMS";
    }

    /// <inheritdoc />
    public override string TableName => "F4100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LMMCU", "LMMCU", JdeDataType.String, 24, true, true),
        new JdeField("LMLOCN", "LMLOCN", JdeDataType.String, 40, true, true),
        new JdeField("LMAISL", "LMAISL", JdeDataType.String, 16),
        new JdeField("LMBIN", "LMBIN", JdeDataType.String, 16),
        new JdeField("LMLA03", "LMLA03", JdeDataType.String, 8),
        new JdeField("LMLA04", "LMLA04", JdeDataType.String, 8),
        new JdeField("LMLA05", "LMLA05", JdeDataType.String, 8),
        new JdeField("LMLA06", "LMLA06", JdeDataType.String, 8),
        new JdeField("LMLA07", "LMLA07", JdeDataType.String, 8),
        new JdeField("LMLA08", "LMLA08", JdeDataType.String, 8),
        new JdeField("LMLA09", "LMLA09", JdeDataType.String, 8),
        new JdeField("LMLA10", "LMLA10", JdeDataType.String, 8),
        new JdeField("LMLLDL", "LMLLDL", JdeDataType.String, 2),
        new JdeField("LMSTY1", "LMSTY1", JdeDataType.String, 12),
        new JdeField("LMCGRP", "LMCGRP", JdeDataType.String, 12),
        new JdeField("LMLHLD", "LMLHLD", JdeDataType.String, 4),
        new JdeField("LMFREZ", "LMFREZ", JdeDataType.String, 2),
        new JdeField("LMNETA", "LMNETA", JdeDataType.String, 2),
        new JdeField("LMMNUP", "LMMNUP", JdeDataType.Numeric),
        new JdeField("LMMNUK", "LMMNUK", JdeDataType.Numeric),
        new JdeField("LMLCOD", "LMLCOD", JdeDataType.String, 4),
        new JdeField("LMMMTH", "LMMMTH", JdeDataType.String, 8),
        new JdeField("LMEQTY", "LMEQTY", JdeDataType.String, 10),
        new JdeField("LMCTNF", "LMCTNF", JdeDataType.String, 2),
        new JdeField("LMMCNT", "LMMCNT", JdeDataType.String, 2),
        new JdeField("LMMLOT", "LMMLOT", JdeDataType.String, 2),
        new JdeField("LMMITM", "LMMITM", JdeDataType.Numeric),
        new JdeField("LMSTAG", "LMSTAG", JdeDataType.String, 2),
        new JdeField("LMLVER", "LMLVER", JdeDataType.String, 10),
        new JdeField("LMPCNF", "LMPCNF", JdeDataType.String, 2),
        new JdeField("LMKCNF", "LMKCNF", JdeDataType.String, 2),
        new JdeField("LMAPUT", "LMAPUT", JdeDataType.String, 2),
        new JdeField("LMAPIK", "LMAPIK", JdeDataType.String, 2),
        new JdeField("LMARPL", "LMARPL", JdeDataType.String, 2),
        new JdeField("LMPZON", "LMPZON", JdeDataType.String, 12),
        new JdeField("LMKZON", "LMKZON", JdeDataType.String, 12),
        new JdeField("LMZONR", "LMZONR", JdeDataType.String, 12),
        new JdeField("LMSTGP", "LMSTGP", JdeDataType.String, 40),
        new JdeField("LMSTGK", "LMSTGK", JdeDataType.String, 40),
        new JdeField("LMSTGR", "LMSTGR", JdeDataType.String, 40),
        new JdeField("LMWSQP", "LMWSQP", JdeDataType.Numeric),
        new JdeField("LMWSQQ", "LMWSQQ", JdeDataType.Numeric),
        new JdeField("LMWSQR", "LMWSQR", JdeDataType.Numeric),
        new JdeField("LMDISX", "LMDISX", JdeDataType.Numeric),
        new JdeField("LMDISY", "LMDISY", JdeDataType.Numeric),
        new JdeField("LMDISZ", "LMDISZ", JdeDataType.Numeric),
        new JdeField("LMEQTP", "LMEQTP", JdeDataType.String, 6),
        new JdeField("LMURCD", "LMURCD", JdeDataType.String, 4),
        new JdeField("LMURDT", "LMURDT", JdeDataType.Numeric),
        new JdeField("LMURAT", "LMURAT", JdeDataType.Numeric),
        new JdeField("LMURAB", "LMURAB", JdeDataType.Numeric),
        new JdeField("LMURRF", "LMURRF", JdeDataType.String, 30),
        new JdeField("LMOT1Y", "LMOT1Y", JdeDataType.String, 2),
        new JdeField("LMOT2Y", "LMOT2Y", JdeDataType.String, 2),
        new JdeField("LMUSER", "LMUSER", JdeDataType.String, 20),
        new JdeField("LMPID", "LMPID", JdeDataType.String, 20),
        new JdeField("LMJOBN", "LMJOBN", JdeDataType.String, 20),
        new JdeField("LMUPMJ", "LMUPMJ", JdeDataType.Numeric),
        new JdeField("LMTDAY", "LMTDAY", JdeDataType.Numeric),
        new JdeField("LMMIXL", "LMMIXL", JdeDataType.String, 2),
        new JdeField("LMMPTL", "LMMPTL", JdeDataType.String, 2),
        new JdeField("LMMUMS", "LMMUMS", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4100_0", "Primary Key on LMMCU, LMLOCN", new[] { "LMMCU", "LMLOCN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4100_2", "Index on LMMCU, LMWSQP, LMLOCN", new[] { "LMMCU", "LMWSQP", "LMLOCN" }),
        new JdeIndex("F4100_3", "Index on LMMCU, LMWSQQ, LMLOCN", new[] { "LMMCU", "LMWSQQ", "LMLOCN" }),
        new JdeIndex("F4100_4", "Index on LMMCU, LMWSQR, LMLOCN", new[] { "LMMCU", "LMWSQR", "LMLOCN" }),
        new JdeIndex("F4100_5", "Index on LMMCU, LMCGRP", new[] { "LMMCU", "LMCGRP" }),
        new JdeIndex("F4100_6", "Index on LMMCU, LMPZON", new[] { "LMMCU", "LMPZON" })
    };
}
