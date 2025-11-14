using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1521 - .
/// </summary>
public class F1521 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NBLGLV.
        /// </summary>
        public const string NBLGLV = "NBLGLV";

        /// <summary>
        /// NBLGNM.
        /// </summary>
        public const string NBLGNM = "NBLGNM";

        /// <summary>
        /// NBDOCO.
        /// </summary>
        public const string NBDOCO = "NBDOCO";

        /// <summary>
        /// NBLSVR.
        /// </summary>
        public const string NBLSVR = "NBLSVR";

        /// <summary>
        /// NBMCU.
        /// </summary>
        public const string NBMCU = "NBMCU";

        /// <summary>
        /// NBUNIT.
        /// </summary>
        public const string NBUNIT = "NBUNIT";

        /// <summary>
        /// NBLGCL.
        /// </summary>
        public const string NBLGCL = "NBLGCL";

        /// <summary>
        /// NBDL01.
        /// </summary>
        public const string NBDL01 = "NBDL01";

        /// <summary>
        /// NBEXR.
        /// </summary>
        public const string NBEXR = "NBEXR";

        /// <summary>
        /// NBSTSC.
        /// </summary>
        public const string NBSTSC = "NBSTSC";

        /// <summary>
        /// NBEFTB.
        /// </summary>
        public const string NBEFTB = "NBEFTB";

        /// <summary>
        /// NBEXPR.
        /// </summary>
        public const string NBEXPR = "NBEXPR";

        /// <summary>
        /// NBTKDT.
        /// </summary>
        public const string NBTKDT = "NBTKDT";

        /// <summary>
        /// NBEPCD.
        /// </summary>
        public const string NBEPCD = "NBEPCD";

        /// <summary>
        /// NBAMID.
        /// </summary>
        public const string NBAMID = "NBAMID";

        /// <summary>
        /// NBPMU1.
        /// </summary>
        public const string NBPMU1 = "NBPMU1";

        /// <summary>
        /// NBUM.
        /// </summary>
        public const string NBUM = "NBUM";

        /// <summary>
        /// NBRO01.
        /// </summary>
        public const string NBRO01 = "NBRO01";

        /// <summary>
        /// NBRO02.
        /// </summary>
        public const string NBRO02 = "NBRO02";

        /// <summary>
        /// NBRQ.
        /// </summary>
        public const string NBRQ = "NBRQ";

        /// <summary>
        /// NBJOB#.
        /// </summary>
        public const string NBJOB_ = "NBJOB#";

        /// <summary>
        /// NBSUSC.
        /// </summary>
        public const string NBSUSC = "NBSUSC";

        /// <summary>
        /// NBAN8.
        /// </summary>
        public const string NBAN8 = "NBAN8";

        /// <summary>
        /// NBANP.
        /// </summary>
        public const string NBANP = "NBANP";

        /// <summary>
        /// NBFLOR.
        /// </summary>
        public const string NBFLOR = "NBFLOR";

        /// <summary>
        /// NBFOTY.
        /// </summary>
        public const string NBFOTY = "NBFOTY";

        /// <summary>
        /// NBARGC.
        /// </summary>
        public const string NBARGC = "NBARGC";

        /// <summary>
        /// NBARGV.
        /// </summary>
        public const string NBARGV = "NBARGV";

        /// <summary>
        /// NBURCD.
        /// </summary>
        public const string NBURCD = "NBURCD";

        /// <summary>
        /// NBURDT.
        /// </summary>
        public const string NBURDT = "NBURDT";

        /// <summary>
        /// NBURAT.
        /// </summary>
        public const string NBURAT = "NBURAT";

        /// <summary>
        /// NBURAB.
        /// </summary>
        public const string NBURAB = "NBURAB";

        /// <summary>
        /// NBURRF.
        /// </summary>
        public const string NBURRF = "NBURRF";

        /// <summary>
        /// NBUSER.
        /// </summary>
        public const string NBUSER = "NBUSER";

        /// <summary>
        /// NBPID.
        /// </summary>
        public const string NBPID = "NBPID";

        /// <summary>
        /// NBUPMJ.
        /// </summary>
        public const string NBUPMJ = "NBUPMJ";

        /// <summary>
        /// NBUPMT.
        /// </summary>
        public const string NBUPMT = "NBUPMT";

        /// <summary>
        /// NBJOBN.
        /// </summary>
        public const string NBJOBN = "NBJOBN";

        /// <summary>
        /// NBENTJ.
        /// </summary>
        public const string NBENTJ = "NBENTJ";

        /// <summary>
        /// NBTORG.
        /// </summary>
        public const string NBTORG = "NBTORG";

        /// <summary>
        /// NBNUMB.
        /// </summary>
        public const string NBNUMB = "NBNUMB";

        /// <summary>
        /// NBLZNPA.
        /// </summary>
        public const string NBLZNPA = "NBLZNPA";
    }

    /// <inheritdoc />
    public override string TableName => "F1521";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NBLGLV", "NBLGLV", JdeDataType.String, 2),
        new JdeField("NBLGNM", "NBLGNM", JdeDataType.Numeric, null, true, true),
        new JdeField("NBDOCO", "NBDOCO", JdeDataType.Numeric),
        new JdeField("NBLSVR", "NBLSVR", JdeDataType.Numeric),
        new JdeField("NBMCU", "NBMCU", JdeDataType.String, 24),
        new JdeField("NBUNIT", "NBUNIT", JdeDataType.String, 16),
        new JdeField("NBLGCL", "NBLGCL", JdeDataType.String, 4),
        new JdeField("NBDL01", "NBDL01", JdeDataType.String, 60),
        new JdeField("NBEXR", "NBEXR", JdeDataType.String, 60),
        new JdeField("NBSTSC", "NBSTSC", JdeDataType.String, 2),
        new JdeField("NBEFTB", "NBEFTB", JdeDataType.Numeric),
        new JdeField("NBEXPR", "NBEXPR", JdeDataType.Numeric),
        new JdeField("NBTKDT", "NBTKDT", JdeDataType.Numeric),
        new JdeField("NBEPCD", "NBEPCD", JdeDataType.String, 4),
        new JdeField("NBAMID", "NBAMID", JdeDataType.String, 8),
        new JdeField("NBPMU1", "NBPMU1", JdeDataType.Numeric),
        new JdeField("NBUM", "NBUM", JdeDataType.String, 4),
        new JdeField("NBRO01", "NBRO01", JdeDataType.String, 6),
        new JdeField("NBRO02", "NBRO02", JdeDataType.String, 6),
        new JdeField("NBRQ", "NBRQ", JdeDataType.String, 2),
        new JdeField("NBJOB#", "NBJOB#", JdeDataType.Numeric),
        new JdeField("NBSUSC", "NBSUSC", JdeDataType.String, 2),
        new JdeField("NBAN8", "NBAN8", JdeDataType.Numeric),
        new JdeField("NBANP", "NBANP", JdeDataType.Numeric),
        new JdeField("NBFLOR", "NBFLOR", JdeDataType.String, 8),
        new JdeField("NBFOTY", "NBFOTY", JdeDataType.String, 10),
        new JdeField("NBARGC", "NBARGC", JdeDataType.String, 8),
        new JdeField("NBARGV", "NBARGV", JdeDataType.String, 10),
        new JdeField("NBURCD", "NBURCD", JdeDataType.String, 4),
        new JdeField("NBURDT", "NBURDT", JdeDataType.Numeric),
        new JdeField("NBURAT", "NBURAT", JdeDataType.Numeric),
        new JdeField("NBURAB", "NBURAB", JdeDataType.Numeric),
        new JdeField("NBURRF", "NBURRF", JdeDataType.String, 30),
        new JdeField("NBUSER", "NBUSER", JdeDataType.String, 20),
        new JdeField("NBPID", "NBPID", JdeDataType.String, 20),
        new JdeField("NBUPMJ", "NBUPMJ", JdeDataType.Numeric),
        new JdeField("NBUPMT", "NBUPMT", JdeDataType.Numeric),
        new JdeField("NBJOBN", "NBJOBN", JdeDataType.String, 20),
        new JdeField("NBENTJ", "NBENTJ", JdeDataType.Numeric),
        new JdeField("NBTORG", "NBTORG", JdeDataType.String, 20),
        new JdeField("NBNUMB", "NBNUMB", JdeDataType.Numeric),
        new JdeField("NBLZNPA", "NBLZNPA", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1521_0", "Primary Key on NBLGNM", new[] { "NBLGNM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1521_10", "Index on NBLGCL, NBAMID, NBMCU, NBUNIT", new[] { "NBLGCL", "NBAMID", "NBMCU", "NBUNIT" }),
        new JdeIndex("F1521_13", "Index on NBMCU, NBARGC, NBLGCL, NBAMID", new[] { "NBMCU", "NBARGC", "NBLGCL", "NBAMID" }),
        new JdeIndex("F1521_14", "Index on NBMCU, NBFLOR, NBARGC, NBLGCL, NBAMID", new[] { "NBMCU", "NBFLOR", "NBARGC", "NBLGCL", "NBAMID" }),
        new JdeIndex("F1521_15", "Index on NBDOCO, NBLSVR", new[] { "NBDOCO", "NBLSVR" }),
        new JdeIndex("F1521_2", "Index on NBDOCO, NBLGCL, NBAMID", new[] { "NBDOCO", "NBLGCL", "NBAMID" }),
        new JdeIndex("F1521_3", "Index on NBMCU, NBFLOR, NBARGC, NBARGV, NBUNIT, NBLGLV", new[] { "NBMCU", "NBFLOR", "NBARGC", "NBARGV", "NBUNIT", "NBLGLV" }),
        new JdeIndex("F1521_4", "Index on NBMCU, NBFLOR, NBUNIT, NBLGCL, NBAMID, NBEFTB", new[] { "NBMCU", "NBFLOR", "NBUNIT", "NBLGCL", "NBAMID", "NBEFTB" }),
        new JdeIndex("F1521_5", "Index on NBDOCO, NBMCU, NBFLOR, NBUNIT, NBLGCL, NBAMID, NBEFTB", new[] { "NBDOCO", "NBMCU", "NBFLOR", "NBUNIT", "NBLGCL", "NBAMID", "NBEFTB" }),
        new JdeIndex("F1521_6", "Index on NBMCU, NBTKDT, NBLGCL", new[] { "NBMCU", "NBTKDT", "NBLGCL" }),
        new JdeIndex("F1521_7", "Index on NBDOCO, NBTKDT, NBLGCL", new[] { "NBDOCO", "NBTKDT", "NBLGCL" }),
        new JdeIndex("F1521_8", "Index on NBMCU, NBUNIT, NBAMID, NBFLOR", new[] { "NBMCU", "NBUNIT", "NBAMID", "NBFLOR" }),
        new JdeIndex("F1521_9", "Index on NBMCU, NBEPCD, NBLGCL, NBAMID", new[] { "NBMCU", "NBEPCD", "NBLGCL", "NBAMID" })
    };
}
