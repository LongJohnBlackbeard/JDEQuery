using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43147 - .
/// </summary>
public class F43147 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FDJOBS.
        /// </summary>
        public const string FDJOBS = "FDJOBS";

        /// <summary>
        /// FDCTID.
        /// </summary>
        public const string FDCTID = "FDCTID";

        /// <summary>
        /// FDXTLN.
        /// </summary>
        public const string FDXTLN = "FDXTLN";

        /// <summary>
        /// FDOSEQ.
        /// </summary>
        public const string FDOSEQ = "FDOSEQ";

        /// <summary>
        /// FDKCOO.
        /// </summary>
        public const string FDKCOO = "FDKCOO";

        /// <summary>
        /// FDDOCO.
        /// </summary>
        public const string FDDOCO = "FDDOCO";

        /// <summary>
        /// FDDCTO.
        /// </summary>
        public const string FDDCTO = "FDDCTO";

        /// <summary>
        /// FDSFXO.
        /// </summary>
        public const string FDSFXO = "FDSFXO";

        /// <summary>
        /// FDLNID.
        /// </summary>
        public const string FDLNID = "FDLNID";

        /// <summary>
        /// FDNLIN.
        /// </summary>
        public const string FDNLIN = "FDNLIN";

        /// <summary>
        /// FDDLNID.
        /// </summary>
        public const string FDDLNID = "FDDLNID";

        /// <summary>
        /// FDDSC1.
        /// </summary>
        public const string FDDSC1 = "FDDSC1";

        /// <summary>
        /// FDUITM.
        /// </summary>
        public const string FDUITM = "FDUITM";

        /// <summary>
        /// FDITM.
        /// </summary>
        public const string FDITM = "FDITM";

        /// <summary>
        /// FDLNTY.
        /// </summary>
        public const string FDLNTY = "FDLNTY";

        /// <summary>
        /// FDIVI.
        /// </summary>
        public const string FDIVI = "FDIVI";

        /// <summary>
        /// FDGLPT.
        /// </summary>
        public const string FDGLPT = "FDGLPT";

        /// <summary>
        /// FDMCU.
        /// </summary>
        public const string FDMCU = "FDMCU";

        /// <summary>
        /// FDCO.
        /// </summary>
        public const string FDCO = "FDCO";

        /// <summary>
        /// FDAID.
        /// </summary>
        public const string FDAID = "FDAID";

        /// <summary>
        /// FDANI.
        /// </summary>
        public const string FDANI = "FDANI";

        /// <summary>
        /// FDOMCU.
        /// </summary>
        public const string FDOMCU = "FDOMCU";

        /// <summary>
        /// FDOBJ.
        /// </summary>
        public const string FDOBJ = "FDOBJ";

        /// <summary>
        /// FDSUB.
        /// </summary>
        public const string FDSUB = "FDSUB";

        /// <summary>
        /// FDSBL.
        /// </summary>
        public const string FDSBL = "FDSBL";

        /// <summary>
        /// FDSBLT.
        /// </summary>
        public const string FDSBLT = "FDSBLT";

        /// <summary>
        /// FDUORG.
        /// </summary>
        public const string FDUORG = "FDUORG";

        /// <summary>
        /// FDUOM.
        /// </summary>
        public const string FDUOM = "FDUOM";

        /// <summary>
        /// FDAEXP.
        /// </summary>
        public const string FDAEXP = "FDAEXP";

        /// <summary>
        /// FDFEA.
        /// </summary>
        public const string FDFEA = "FDFEA";

        /// <summary>
        /// FDCRCD.
        /// </summary>
        public const string FDCRCD = "FDCRCD";

        /// <summary>
        /// FDCRR.
        /// </summary>
        public const string FDCRR = "FDCRR";

        /// <summary>
        /// FDDGL.
        /// </summary>
        public const string FDDGL = "FDDGL";

        /// <summary>
        /// FDFDP.
        /// </summary>
        public const string FDFDP = "FDFDP";

        /// <summary>
        /// FDFDAD.
        /// </summary>
        public const string FDFDAD = "FDFDAD";

        /// <summary>
        /// FDFDAF.
        /// </summary>
        public const string FDFDAF = "FDFDAF";

        /// <summary>
        /// FDFDANI.
        /// </summary>
        public const string FDFDANI = "FDFDANI";

        /// <summary>
        /// FDFDOMCU.
        /// </summary>
        public const string FDFDOMCU = "FDFDOMCU";

        /// <summary>
        /// FDFDOBJ.
        /// </summary>
        public const string FDFDOBJ = "FDFDOBJ";

        /// <summary>
        /// FDFDSUB.
        /// </summary>
        public const string FDFDSUB = "FDFDSUB";

        /// <summary>
        /// FDFDSBL.
        /// </summary>
        public const string FDFDSBL = "FDFDSBL";

        /// <summary>
        /// FDFDSBLT.
        /// </summary>
        public const string FDFDSBLT = "FDFDSBLT";

        /// <summary>
        /// FDABR1.
        /// </summary>
        public const string FDABR1 = "FDABR1";

        /// <summary>
        /// FDABR2.
        /// </summary>
        public const string FDABR2 = "FDABR2";

        /// <summary>
        /// FDABR3.
        /// </summary>
        public const string FDABR3 = "FDABR3";

        /// <summary>
        /// FDABR4.
        /// </summary>
        public const string FDABR4 = "FDABR4";

        /// <summary>
        /// FDABT1.
        /// </summary>
        public const string FDABT1 = "FDABT1";

        /// <summary>
        /// FDABT2.
        /// </summary>
        public const string FDABT2 = "FDABT2";

        /// <summary>
        /// FDABT3.
        /// </summary>
        public const string FDABT3 = "FDABT3";

        /// <summary>
        /// FDABT4.
        /// </summary>
        public const string FDABT4 = "FDABT4";

        /// <summary>
        /// FDURCD.
        /// </summary>
        public const string FDURCD = "FDURCD";

        /// <summary>
        /// FDURDT.
        /// </summary>
        public const string FDURDT = "FDURDT";

        /// <summary>
        /// FDURAT.
        /// </summary>
        public const string FDURAT = "FDURAT";

        /// <summary>
        /// FDURAB.
        /// </summary>
        public const string FDURAB = "FDURAB";

        /// <summary>
        /// FDURRF.
        /// </summary>
        public const string FDURRF = "FDURRF";

        /// <summary>
        /// FDUSER.
        /// </summary>
        public const string FDUSER = "FDUSER";

        /// <summary>
        /// FDPID.
        /// </summary>
        public const string FDPID = "FDPID";

        /// <summary>
        /// FDJOBN.
        /// </summary>
        public const string FDJOBN = "FDJOBN";

        /// <summary>
        /// FDUUPMJ.
        /// </summary>
        public const string FDUUPMJ = "FDUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F43147";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FDJOBS", "FDJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("FDCTID", "FDCTID", JdeDataType.String, 30, true, true),
        new JdeField("FDXTLN", "FDXTLN", JdeDataType.Numeric, null, true, true),
        new JdeField("FDOSEQ", "FDOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("FDKCOO", "FDKCOO", JdeDataType.String, 10),
        new JdeField("FDDOCO", "FDDOCO", JdeDataType.Numeric),
        new JdeField("FDDCTO", "FDDCTO", JdeDataType.String, 4),
        new JdeField("FDSFXO", "FDSFXO", JdeDataType.String, 6),
        new JdeField("FDLNID", "FDLNID", JdeDataType.Numeric),
        new JdeField("FDNLIN", "FDNLIN", JdeDataType.Numeric),
        new JdeField("FDDLNID", "FDDLNID", JdeDataType.Numeric),
        new JdeField("FDDSC1", "FDDSC1", JdeDataType.String, 60),
        new JdeField("FDUITM", "FDUITM", JdeDataType.String, 52),
        new JdeField("FDITM", "FDITM", JdeDataType.Numeric),
        new JdeField("FDLNTY", "FDLNTY", JdeDataType.String, 4),
        new JdeField("FDIVI", "FDIVI", JdeDataType.String, 2),
        new JdeField("FDGLPT", "FDGLPT", JdeDataType.String, 8),
        new JdeField("FDMCU", "FDMCU", JdeDataType.String, 24),
        new JdeField("FDCO", "FDCO", JdeDataType.String, 10),
        new JdeField("FDAID", "FDAID", JdeDataType.String, 16),
        new JdeField("FDANI", "FDANI", JdeDataType.String, 58),
        new JdeField("FDOMCU", "FDOMCU", JdeDataType.String, 24),
        new JdeField("FDOBJ", "FDOBJ", JdeDataType.String, 12),
        new JdeField("FDSUB", "FDSUB", JdeDataType.String, 16),
        new JdeField("FDSBL", "FDSBL", JdeDataType.String, 16),
        new JdeField("FDSBLT", "FDSBLT", JdeDataType.String, 2),
        new JdeField("FDUORG", "FDUORG", JdeDataType.Numeric),
        new JdeField("FDUOM", "FDUOM", JdeDataType.String, 4),
        new JdeField("FDAEXP", "FDAEXP", JdeDataType.Numeric),
        new JdeField("FDFEA", "FDFEA", JdeDataType.Numeric),
        new JdeField("FDCRCD", "FDCRCD", JdeDataType.String, 6),
        new JdeField("FDCRR", "FDCRR", JdeDataType.Numeric),
        new JdeField("FDDGL", "FDDGL", JdeDataType.Numeric),
        new JdeField("FDFDP", "FDFDP", JdeDataType.Numeric),
        new JdeField("FDFDAD", "FDFDAD", JdeDataType.Numeric),
        new JdeField("FDFDAF", "FDFDAF", JdeDataType.Numeric),
        new JdeField("FDFDANI", "FDFDANI", JdeDataType.String, 58),
        new JdeField("FDFDOMCU", "FDFDOMCU", JdeDataType.String, 24),
        new JdeField("FDFDOBJ", "FDFDOBJ", JdeDataType.String, 12),
        new JdeField("FDFDSUB", "FDFDSUB", JdeDataType.String, 16),
        new JdeField("FDFDSBL", "FDFDSBL", JdeDataType.String, 16),
        new JdeField("FDFDSBLT", "FDFDSBLT", JdeDataType.String, 2),
        new JdeField("FDABR1", "FDABR1", JdeDataType.String, 24),
        new JdeField("FDABR2", "FDABR2", JdeDataType.String, 24),
        new JdeField("FDABR3", "FDABR3", JdeDataType.String, 24),
        new JdeField("FDABR4", "FDABR4", JdeDataType.String, 24),
        new JdeField("FDABT1", "FDABT1", JdeDataType.String, 2),
        new JdeField("FDABT2", "FDABT2", JdeDataType.String, 2),
        new JdeField("FDABT3", "FDABT3", JdeDataType.String, 2),
        new JdeField("FDABT4", "FDABT4", JdeDataType.String, 2),
        new JdeField("FDURCD", "FDURCD", JdeDataType.String, 4),
        new JdeField("FDURDT", "FDURDT", JdeDataType.Numeric),
        new JdeField("FDURAT", "FDURAT", JdeDataType.Numeric),
        new JdeField("FDURAB", "FDURAB", JdeDataType.Numeric),
        new JdeField("FDURRF", "FDURRF", JdeDataType.String, 30),
        new JdeField("FDUSER", "FDUSER", JdeDataType.String, 20),
        new JdeField("FDPID", "FDPID", JdeDataType.String, 20),
        new JdeField("FDJOBN", "FDJOBN", JdeDataType.String, 20),
        new JdeField("FDUUPMJ", "FDUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43147_0", "Primary Key on FDJOBS, FDCTID, FDXTLN, FDOSEQ", new[] { "FDJOBS", "FDCTID", "FDXTLN", "FDOSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43147_2", "Index on FDJOBS, FDCTID, FDXTLN, FDDOCO, FDDCTO, FDKCOO, FDSFXO, FDLNID, FDNLIN, FDDLNID", new[] { "FDJOBS", "FDCTID", "FDXTLN", "FDDOCO", "FDDCTO", "FDKCOO", "FDSFXO", "FDLNID", "FDNLIN", "FDDLNID" })
    };
}
