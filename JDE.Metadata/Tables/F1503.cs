using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1503 - .
/// </summary>
public class F1503 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NBDOCO.
        /// </summary>
        public const string NBDOCO = "NBDOCO";

        /// <summary>
        /// NBLSET.
        /// </summary>
        public const string NBLSET = "NBLSET";

        /// <summary>
        /// NBMCU.
        /// </summary>
        public const string NBMCU = "NBMCU";

        /// <summary>
        /// NBSTYL.
        /// </summary>
        public const string NBSTYL = "NBSTYL";

        /// <summary>
        /// NBUNIT.
        /// </summary>
        public const string NBUNIT = "NBUNIT";

        /// <summary>
        /// NBUTTY.
        /// </summary>
        public const string NBUTTY = "NBUTTY";

        /// <summary>
        /// NBLGCL.
        /// </summary>
        public const string NBLGCL = "NBLGCL";

        /// <summary>
        /// NBLGNO.
        /// </summary>
        public const string NBLGNO = "NBLGNO";

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
        /// NBUSER.
        /// </summary>
        public const string NBUSER = "NBUSER";

        /// <summary>
        /// NBUPMJ.
        /// </summary>
        public const string NBUPMJ = "NBUPMJ";

        /// <summary>
        /// NBPID.
        /// </summary>
        public const string NBPID = "NBPID";

        /// <summary>
        /// NBJOBN.
        /// </summary>
        public const string NBJOBN = "NBJOBN";

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
        /// NBUPMT.
        /// </summary>
        public const string NBUPMT = "NBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1503";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NBDOCO", "NBDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NBLSET", "NBLSET", JdeDataType.String, 4),
        new JdeField("NBMCU", "NBMCU", JdeDataType.String, 24, true, true),
        new JdeField("NBSTYL", "NBSTYL", JdeDataType.String, 4),
        new JdeField("NBUNIT", "NBUNIT", JdeDataType.String, 16, true, true),
        new JdeField("NBUTTY", "NBUTTY", JdeDataType.String, 10),
        new JdeField("NBLGCL", "NBLGCL", JdeDataType.String, 4),
        new JdeField("NBLGNO", "NBLGNO", JdeDataType.Numeric, null, true, true),
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
        new JdeField("NBUSER", "NBUSER", JdeDataType.String, 20),
        new JdeField("NBUPMJ", "NBUPMJ", JdeDataType.Numeric),
        new JdeField("NBPID", "NBPID", JdeDataType.String, 20),
        new JdeField("NBJOBN", "NBJOBN", JdeDataType.String, 20),
        new JdeField("NBAN8", "NBAN8", JdeDataType.Numeric),
        new JdeField("NBANP", "NBANP", JdeDataType.Numeric),
        new JdeField("NBFLOR", "NBFLOR", JdeDataType.String, 8, true, true),
        new JdeField("NBFOTY", "NBFOTY", JdeDataType.String, 10),
        new JdeField("NBARGC", "NBARGC", JdeDataType.String, 8, true, true),
        new JdeField("NBARGV", "NBARGV", JdeDataType.String, 10, true, true),
        new JdeField("NBUPMT", "NBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1503_0", "Primary Key on NBDOCO, NBMCU, NBUNIT, NBFLOR, NBARGC, NBARGV, NBLGNO", new[] { "NBDOCO", "NBMCU", "NBUNIT", "NBFLOR", "NBARGC", "NBARGV", "NBLGNO" }, isUnique: true, isPrimaryKey: true)
    };
}
