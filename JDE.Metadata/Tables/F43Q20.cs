using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q20 - .
/// </summary>
public class F43Q20 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EHEVNU.
        /// </summary>
        public const string EHEVNU = "EHEVNU";

        /// <summary>
        /// EHDCTO.
        /// </summary>
        public const string EHDCTO = "EHDCTO";

        /// <summary>
        /// EHKCOO.
        /// </summary>
        public const string EHKCOO = "EHKCOO";

        /// <summary>
        /// EHBIDQN.
        /// </summary>
        public const string EHBIDQN = "EHBIDQN";

        /// <summary>
        /// EHDESC.
        /// </summary>
        public const string EHDESC = "EHDESC";

        /// <summary>
        /// EHBIDCODE.
        /// </summary>
        public const string EHBIDCODE = "EHBIDCODE";

        /// <summary>
        /// EHBQTYP.
        /// </summary>
        public const string EHBQTYP = "EHBQTYP";

        /// <summary>
        /// EHBIDQUES.
        /// </summary>
        public const string EHBIDQUES = "EHBIDQUES";

        /// <summary>
        /// EHUOM.
        /// </summary>
        public const string EHUOM = "EHUOM";

        /// <summary>
        /// EHBESTAMT.
        /// </summary>
        public const string EHBESTAMT = "EHBESTAMT";

        /// <summary>
        /// EHWSAMT.
        /// </summary>
        public const string EHWSAMT = "EHWSAMT";

        /// <summary>
        /// EHBESTQTY.
        /// </summary>
        public const string EHBESTQTY = "EHBESTQTY";

        /// <summary>
        /// EHWSTQ.
        /// </summary>
        public const string EHWSTQ = "EHWSTQ";

        /// <summary>
        /// EHWDAT.
        /// </summary>
        public const string EHWDAT = "EHWDAT";

        /// <summary>
        /// EHBESTDATE.
        /// </summary>
        public const string EHBESTDATE = "EHBESTDATE";

        /// <summary>
        /// EHIDTX.
        /// </summary>
        public const string EHIDTX = "EHIDTX";

        /// <summary>
        /// EHIYON.
        /// </summary>
        public const string EHIYON = "EHIYON";

        /// <summary>
        /// EHDBQR.
        /// </summary>
        public const string EHDBQR = "EHDBQR";

        /// <summary>
        /// EHOUTRANGE.
        /// </summary>
        public const string EHOUTRANGE = "EHOUTRANGE";

        /// <summary>
        /// EHWHTG.
        /// </summary>
        public const string EHWHTG = "EHWHTG";

        /// <summary>
        /// EHDISBDQ.
        /// </summary>
        public const string EHDISBDQ = "EHDISBDQ";

        /// <summary>
        /// EHBQO.
        /// </summary>
        public const string EHBQO = "EHBQO";

        /// <summary>
        /// EHBRQD.
        /// </summary>
        public const string EHBRQD = "EHBRQD";

        /// <summary>
        /// EHRSC.
        /// </summary>
        public const string EHRSC = "EHRSC";

        /// <summary>
        /// EHRSEN.
        /// </summary>
        public const string EHRSEN = "EHRSEN";

        /// <summary>
        /// EHRSLN.
        /// </summary>
        public const string EHRSLN = "EHRSLN";

        /// <summary>
        /// EHURCD.
        /// </summary>
        public const string EHURCD = "EHURCD";

        /// <summary>
        /// EHURDT.
        /// </summary>
        public const string EHURDT = "EHURDT";

        /// <summary>
        /// EHURAT.
        /// </summary>
        public const string EHURAT = "EHURAT";

        /// <summary>
        /// EHURAB.
        /// </summary>
        public const string EHURAB = "EHURAB";

        /// <summary>
        /// EHURRF.
        /// </summary>
        public const string EHURRF = "EHURRF";

        /// <summary>
        /// EHTORG.
        /// </summary>
        public const string EHTORG = "EHTORG";

        /// <summary>
        /// EHUSER.
        /// </summary>
        public const string EHUSER = "EHUSER";

        /// <summary>
        /// EHPID.
        /// </summary>
        public const string EHPID = "EHPID";

        /// <summary>
        /// EHJOBN.
        /// </summary>
        public const string EHJOBN = "EHJOBN";

        /// <summary>
        /// EHUPMJ.
        /// </summary>
        public const string EHUPMJ = "EHUPMJ";

        /// <summary>
        /// EHTDAY.
        /// </summary>
        public const string EHTDAY = "EHTDAY";

        /// <summary>
        /// EHMULTSEL.
        /// </summary>
        public const string EHMULTSEL = "EHMULTSEL";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q20";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EHEVNU", "EHEVNU", JdeDataType.Numeric, null, true, true),
        new JdeField("EHDCTO", "EHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("EHKCOO", "EHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("EHBIDQN", "EHBIDQN", JdeDataType.Numeric, null, true, true),
        new JdeField("EHDESC", "EHDESC", JdeDataType.String, 60),
        new JdeField("EHBIDCODE", "EHBIDCODE", JdeDataType.String, 36),
        new JdeField("EHBQTYP", "EHBQTYP", JdeDataType.String, 4),
        new JdeField("EHBIDQUES", "EHBIDQUES", JdeDataType.String, 3998),
        new JdeField("EHUOM", "EHUOM", JdeDataType.String, 4),
        new JdeField("EHBESTAMT", "EHBESTAMT", JdeDataType.Numeric),
        new JdeField("EHWSAMT", "EHWSAMT", JdeDataType.Numeric),
        new JdeField("EHBESTQTY", "EHBESTQTY", JdeDataType.Numeric),
        new JdeField("EHWSTQ", "EHWSTQ", JdeDataType.Numeric),
        new JdeField("EHWDAT", "EHWDAT", JdeDataType.Numeric),
        new JdeField("EHBESTDATE", "EHBESTDATE", JdeDataType.Numeric),
        new JdeField("EHIDTX", "EHIDTX", JdeDataType.String, 1000),
        new JdeField("EHIYON", "EHIYON", JdeDataType.String, 2),
        new JdeField("EHDBQR", "EHDBQR", JdeDataType.String, 2),
        new JdeField("EHOUTRANGE", "EHOUTRANGE", JdeDataType.String, 2),
        new JdeField("EHWHTG", "EHWHTG", JdeDataType.Numeric),
        new JdeField("EHDISBDQ", "EHDISBDQ", JdeDataType.String, 2),
        new JdeField("EHBQO", "EHBQO", JdeDataType.String, 2),
        new JdeField("EHBRQD", "EHBRQD", JdeDataType.String, 2),
        new JdeField("EHRSC", "EHRSC", JdeDataType.String, 10),
        new JdeField("EHRSEN", "EHRSEN", JdeDataType.Numeric),
        new JdeField("EHRSLN", "EHRSLN", JdeDataType.Numeric),
        new JdeField("EHURCD", "EHURCD", JdeDataType.String, 4),
        new JdeField("EHURDT", "EHURDT", JdeDataType.Numeric),
        new JdeField("EHURAT", "EHURAT", JdeDataType.Numeric),
        new JdeField("EHURAB", "EHURAB", JdeDataType.Numeric),
        new JdeField("EHURRF", "EHURRF", JdeDataType.String, 30),
        new JdeField("EHTORG", "EHTORG", JdeDataType.String, 20),
        new JdeField("EHUSER", "EHUSER", JdeDataType.String, 20),
        new JdeField("EHPID", "EHPID", JdeDataType.String, 20),
        new JdeField("EHJOBN", "EHJOBN", JdeDataType.String, 20),
        new JdeField("EHUPMJ", "EHUPMJ", JdeDataType.Numeric),
        new JdeField("EHTDAY", "EHTDAY", JdeDataType.Numeric),
        new JdeField("EHMULTSEL", "EHMULTSEL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q20_0", "Primary Key on EHEVNU, EHDCTO, EHKCOO, EHBIDQN", new[] { "EHEVNU", "EHDCTO", "EHKCOO", "EHBIDQN" }, isUnique: true, isPrimaryKey: true)
    };
}
